using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class TicketDL
    {
        DataProvider dp = new DataProvider();
        public List<int> LayDanhSachGheDaDat(int movieID)
        {
            List<int> dsGhe = new List<int>();
            string sql = "SELECT SeatNumber FROM Ve WHERE MovieID = @MovieID";
            SqlParameter[] prms =
            {
                new SqlParameter("@MovieID", movieID)
            };

            DataTable dt = dp.ExecuteQuery(sql, prms);
            foreach (DataRow row in dt.Rows)
            {
                dsGhe.Add(System.Convert.ToInt32(row["SeatNumber"]));
            }

            return dsGhe;
        }

        public bool KiemTraGheDaDat(int movieID, int seatNumber)
        {
            string sql = "SELECT COUNT(*) FROM Ve WHERE MovieID = @MovieID AND SeatNumber = @SeatNumber";

            SqlParameter[] prms =
            {
                new SqlParameter("@MovieID", movieID),
                new SqlParameter("@SeatNumber", seatNumber)
            };
            int count = (int)dp.ExecuteScalar(sql, prms);
            return count > 0;
        }
        public bool ThemVe(int billID, int seatNumber, int movieID)
        {
            string sql = @"INSERT INTO Ve(BillID, SeatNumber, MovieID)
                           VALUES(@BillID, @SeatNumber, @MovieID)";

            SqlParameter[] prms =
            {
                new SqlParameter("@BillID", billID),
                new SqlParameter("@SeatNumber", seatNumber),
                new SqlParameter("@MovieID", movieID)
            };

            return dp.ExecuteNonQuery(sql, prms) > 0;
        }
    }
}
