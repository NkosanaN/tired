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
        private Make GetMakeFromDataRow(DataRow row)
        {
            return new Make
            {
                ModelCode = (int)row["ModelCode"],
                ModelName = row["ModelName"].ToString(),
            };
        }
        public async Task<List<Make>> MakeListGet()
        {
            var sql = "select * from Model";

            var dt = Util.Select(sql);
            var list = new List<Make>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetMakeFromDataRow(row));
            }
            return list;
        }
        public async Task<Make> MakeGetSingle(int Id)
        {
            var sql = $"select * from Model where ModelCode={Id}";

            var dt = Util.Select(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            var r = GetMakeFromDataRow(dt.Rows[0]);
            return r;
        }
       

    }
}
