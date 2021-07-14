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
        private Bookings GetBookingsFromDataRow(DataRow row)
        {
            return new Bookings
            {
                CustomerId = (int)row["CustomerId"],
                TestingCarName = row["TestingCarName"].ToString(),
                CustName = row["CustName"].ToString(),
                Revdate = (DateTime)row["Revdate"],
                hasCome = (bool)row["hasCome"],
            };
        }
        public async Task<List<Bookings>> BookingListGet()
        {
            var sql = "exec sp_booking_data @Mode=0  ";

            var dt = Util.Select(sql);
            var list = new List<Bookings>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetBookingsFromDataRow(row));
            }
            return list;
        }
        public async Task<Bookings> BookingGetSingle(int Id)
        {
            var sql = $"exec sp_booking_data @Mode=1, @id={Id}";

            var dt = Util.Select(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            var r = GetBookingsFromDataRow(dt.Rows[0]);
            return r;
        }
        public async Task<bool> AddBooking(Bookings data)
        {
            var sql = $"exec sp_booking_process @Mode=0  , @TestingCarName='{data.TestingCarName}',@CustName = '{data.CustName}', @Revdate = '{data.Revdate}', @hasCome ='{data.hasCome}' ";
            return Util.Execute(sql);
        }
        public async Task<bool> UpdateBooking(Bookings data, int selectedCust)
        {
            var sql = $"exec sp_booking_process @Mode=2 , " +
                $"@TestingCarName='{data.TestingCarName}'," +
                $"@CustName = '{data.CustName}', " +
                $"@CustomerId = '{data.CustomerId}'," +
                $"@Revdate = '{data.Revdate}'," +
                $"@hasCome ='{data.hasCome}' ";
            return Util.Execute(sql);
        }
        public async Task<bool> DeleteBooking(int Id)
        {
            var sql = $"exec sp_booking_data @Mode=2, @id={Id}";
            return Util.Execute(sql);
        }
    }
}
