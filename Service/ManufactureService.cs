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
        private Manufacture GetManufactureFromDataRow(DataRow row)
        {
            return new Manufacture
            {
                ManufactureCode = (int)row["ManufactureCode"],
                ManufactureName = row["ManufactureName"].ToString()
            };
        }
        public async Task<List<Manufacture>> ManufactureListGet()
        {
            var sql = "select * from Manufactures";

            var dt = Util.Select(sql);
            var list = new List<Manufacture>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetManufactureFromDataRow(row));
            }
            return list;
        }
        

    }
}
