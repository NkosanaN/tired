using MovieApiV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiV.Services
{
    public partial class DataHandler
    {
        private StockBal GetStockFromDataRow(DataRow row)
        {
            return new StockBal
            {
                PaymentType = row["PaymentType"].ToString(),
                TotalStockQty = (decimal)row["TotalStockQty"],
                CarModel = row["CarModel"].ToString(),
                Approve = (bool)row["Approve"],
                StockId = (int)row["StockId"],
            };
        }
        public async Task<List<StockBal>> StockListGet()
        {   
            var sql = "exec sp_transaction_data 0 ";

            var dt = Util.Select(sql);
            var list = new List<StockBal>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetStockFromDataRow(row));
            }
            return list;
        }
        public async Task<StockBal> StockGetSingle(int Id)
        {
            var sql = $"exec sp_transaction_data 1, @id={Id}";

            var dt = Util.Select(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            var r = GetStockFromDataRow(dt.Rows[0]);
            return r;
        }
        //public async Task<bool> AddBooking(StockBal data)
        //{
        //    var sql = $"exec sp_transaction_process 0 , @TestingCarName='{data.TestingCarName}',@CustName = '{data.CustName}', @Revdate = '{data.Revdate}', @hasCome ='{data.hasCome}' ";
        //    return Util.Execute(sql);
        //}
        public async Task<bool> UpdateBooking(StockBal data, int selectedCust)
        {
            var sql = $"exec sp_transaction_process 1 , " +
                $"@StockId = '{data.StockId}',"+
                $"@PaymentType='{data.PaymentType}'," +
                $"@CarModel = '{data.CarModel}', " +
                $"@Approve = '{data.Approve}'";
            return Util.Execute(sql);
        }
        //public async Task<bool> DeleteBooking(int Id)
        //{
        //    var sql = $"exec sp_booking_data 2 @id={Id}";
        //    return Util.Execute(sql);
        //}
    }
}