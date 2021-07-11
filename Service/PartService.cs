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
        private Part GetPartFromDataRow(DataRow row)
        {
            return new Part
            {
                PartCode = row["PartCode"].ToString(),
                PartName = row["PartName"].ToString(),
                Price = (decimal)row["Price"],
                Manufacture = row["ManufactureCode"].ToString(),
                Year = (DateTime)row["Year"],
                Model = row["Model"].ToString()
            };
        }
        public async Task<List<Part>> PartListGet()
        {
            var sql = "select * from CarParts ";

            var dt = Util.Select(sql);
            var list = new List<Part>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetPartFromDataRow(row));
            }
            return list;
        }
       

    }
}
