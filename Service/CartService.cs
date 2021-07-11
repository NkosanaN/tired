using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieApiV.Model;

namespace MovieApiV.Services
{
    public partial class DataHandler
    {
        private Cart GetCartFromDataRow(DataRow row)
        {
            return new Cart
            {
                ItemCode = row["ItemCode"].ToString(),
                ItemName = row["ItemName"].ToString(),
                Price = (decimal)row["Price"],
                Quantity = (int)row["Quantity"],
                Description = row["Description"].ToString()
            };
        }

        public async Task<List<Cart>> CartGetList()
        {
            var sql = "select * from Cart ";

            var dt = Util.Select(sql);
            var list = new List<Cart>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetCartFromDataRow(row));
            }
            return list;
        }

        public async Task<bool> CartAddUpdate(Cart data, int mode)
        {
            var sql = $"exec sp_cart @Mode=4,@ItemCode='{data.ItemCode}',@ItemName='{ data.ItemName}'," +
                $"@Description='{ data.Description}',@Price={ data.Price},@Quantity={ data.Quantity}";
            return Util.Execute(sql);
        }

        public async Task<bool> CartDelete(string code)
        {
            var sql = $"exec sp_cart @Mode=3,@ItemCode='{code}'";
            return Util.Execute(sql);
        }

        public async Task<bool> CheckOut(CheckOut data)
        {
            var sql = $"exec sp_carsold @Mode=4,@CarSoldCode='{data.CarSoldCode}',@CarCode='{ data.CarCode}'," +
                $"@CustomerCode='{ data.CustomerCode}',@AgreedPrice={ data.AgreedPrice},@DateSold='{ data.DateSold}'," +
                $"@MonthlyPaymentAmount={ data.MonthlyPaymentAmount},@MonthlyPaymentDate='{ data.MonthlyPaymentDate}',@Details={ data.Details}";
            return Util.Execute(sql);
        }

        public async Task<bool> Payment(Payments data)
        {
            var sql = $"exec sp_carsold @Mode=5, @CustomerPaymentCode='{data.CustomerPaymentCode}',@CarSoldCode='{ data.CarSoldCode}'," +
                $"@CustomerCode='{ data.CustomerCode}',@PaymentStatusCode='{ data.PaymentStatusCode}',@PaymentDateDue='{ data.PaymentDateDue}'," +
                $"@PaymentAmount={ data.PaymentAmount}";
            return Util.Execute(sql);
        }


        private Payments GetPaymentFromDataRow(DataRow row)
        {
            return new Payments
            {
                CarSoldCode = row["CarSoldCode"].ToString(),
                CustomerCode = row["CustomerCode"].ToString(),
                CustomerPaymentCode = row["CustomerPaymentCode"].ToString(),
                PaymentAmount = (decimal)row["PaymentAmount"],
                PaymentDateDue = (DateTime)row["PaymentDateDue"],
                PaymentStatusCode = row["PaymentStatusCode"].ToString(),

            };
        }

        public async Task<List<Payments>> PaymentList()
        {
            var sql = "exec sp_carsold @Mode=6";

            var dt = Util.Select(sql);
            var list = new List<Payments>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetPaymentFromDataRow(row));
            }
            return list;
        }
    }
}
