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
                Model = row["Model"].ToString(),
                ImagePicture = (byte[])row["Image"],
                ImagePath = (string)row["ImagePath"],
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


        public async Task<bool> PartDelete(string code)
        {
            var sql = $"exec sp_carpart @Mode=3,@PartCode={code}";
            return Util.Execute(sql);
        }

        public async Task<bool> DeletePicture(string code)
        {
            var sql = $"exec sp_carpart @Mode=6,@PartCode={code}";
            return Util.Execute(sql);
        }

        public async Task<bool> PartAddUpdate(Part data, int mode)
        {
            string image = string.Empty;
            if (data.ImagePicture == null)
            {
                image = "0x";
            }
            else
            {
                image = "0x" + BitConverter.ToString(data.ImagePicture).Replace("-", "");
            }
            
           
            var sql = $"exec sp_carpart @Mode={mode},@PartCode='{data.PartCode}',@PartName='{data.PartName}'," +
            $"@Price='{data.Price}',@ManufactureCode='{data.Manufacture}',@Model='{data.Model}',@Year='{ data.Year}'," +
            $"@Image={ image},@ImagePath='{data.ImagePath}'";
            return Util.Execute(sql);
        }
    }
}
