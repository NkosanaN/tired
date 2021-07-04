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
        private Category GetCategoryFromDataRow(DataRow row)
        {
            return new Category
            {
                CatCode = (int)row["CatCode"],
                CatName = row["CatName"].ToString(),
            };
        }
        public async Task<List<Category>> CategoryListGet()
        {
            var sql = "select * from Category";

            var dt = Util.Select(sql);
            var list = new List<Category>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetCategoryFromDataRow(row));
            }
            return list;
        }
        public async Task<Category> CategoryGetSingle(int Id)
        {
            var sql = $"select * from Category where CatCode={Id}";

            var dt = Util.Select(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            var r = GetCategoryFromDataRow(dt.Rows[0]);
            return r;
        }
       

    }
}
