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
            con = new SqlConnection("data source =LOYD-DELL-G3-LT; database=CarInventory; integrated security =SSPI;");
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

            if (dt.Rows[0][0].ToString() == "ok")
                flag = true;

            return flag;
        }
    }
}
