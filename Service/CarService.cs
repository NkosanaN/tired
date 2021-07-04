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
                CarId = (int)row["CarId"],
                Make = row["Make"].ToString(),
                Price = (decimal)row["Price"],
                Color = row["Color"].ToString(),
                Mileage = (decimal)row["Mileage"],
                Year = (int)row["Year"],
                Model = row["Model"].ToString()
            };
        }
        public async Task<List<Car>> CarListGet()
        {
            var sql = "exec sp_car_data 0 ";

            var dt = Util.Select(sql);
            var list = new List<Car>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetCarFromDataRow(row));
            }
            return list;
        }
        public async Task<Car> CarGetSingle(int Id)
        {
            var sql = $"exec sp_movie_data 1, @id={Id}";

            var dt = Util.Select(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            var r = GetCarFromDataRow(dt.Rows[0]);
            return r;
        }
        public bool AddCar(Car data)
        {
            //var sql = $"exec sp_users_process 0 , @Title='{data.Title}',@Genre = '{data.Genre}'";
            //return Util.Execute(sql);
            return true;
        }
        //must test this one
        public bool DeleteCar(int Id)
        {
            var sql = $"exec sp_movie_data 2 @id={Id}";
            return Util.Execute(sql);
        }

    }
}
