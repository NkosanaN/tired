using System;
using System.Data;
using System.Data.SqlClient;
namespace MovieApiV
{
    public class Utils
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter adp;

        public Utils()
        {
            con = new SqlConnection("data source =NKOSANA-LT; database=Users; integrated security =SSPI;");
            con.Open();
        }
        public DataTable Select(string sql)
        {
            adp = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }
        public bool Execute(string sql)
        {
            bool flag = false;
            adp = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
                flag = true;

            return flag;
        }
    }
}
