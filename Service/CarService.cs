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
        private Car GetCarFromDataRow(DataRow row) 
        {
            return new Car
            {   
                CarCode = row["CarCode"].ToString().Trim(),
                ManufactureCode = row["ManufactureCode"].ToString().Trim(),
                ModelCode = row["ModelCode"].ToString().Trim(),
                CatCode = row["CatCode"].ToString().Trim(),
                Price = (decimal)row["Price"],
                Mileage = (decimal)row["Mileage"],
                DateAcquired = (DateTime)row["DateAcquired"],
                ReqistationYear = (DateTime)row["ReqistationYear"],
                CarDescription = row["CarDescription"].ToString().Trim(),
            };
        }
        public async Task<List<Car>> CarListGet()
        {
            var sql = "exec sp_car @Mode=1 ";

            var dt = Util.Select(sql);
            var list = new List<Car>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetCarFromDataRow(row));
            }
            return list;
        }
        public async Task<Car> CarGetSingle(string carcode)
        {
            var sql = $"exec sp_car @Mode=2, @CarCode={carcode}";
            var dt = Util.Select(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            var r = GetCarFromDataRow(dt.Rows[0]);
            return r;
        }
        public async Task<bool> CarDelete(string carcode)
        {
            var sql = $"exec sp_car @Mode=3,@CarCode={carcode}";
            return Util.Execute(sql);
        }

        public async Task<bool> CarAddUpdate(Car data, int mode)
        {
            var sql = $"exec sp_car @Mode={mode},@CarCode='{data.CarCode}',@ManufactureCode='{ data.ManufactureCode}'," +
                $"@ModelCode='{ data.ModelCode}',@CatCode='{ data.CatCode}',@Price={ data.Price},@Mileage={ data.Mileage},@DateAcquired={ data.DateAcquired}," +
                $"@ReqistationYear={ data.ReqistationYear},@CarDescription='{ data.CarDescription}',@Color='{ data.Color}',@ImagePicture=null";
            return Util.Execute(sql);
        }

        public async Task<bool> Payment(string type, string model,string customer)
        {
            var sql = $"exec sp_transaction_process @Mode=0,@PaymentType='{type}',@CarModel='{model}',@Approve=0";
            return Util.Execute(sql);
        }
    }
}
