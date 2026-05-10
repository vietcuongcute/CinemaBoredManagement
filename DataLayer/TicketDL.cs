using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class TicketDL
    {
        DataProvider dp = new DataProvider();

        public List<int> LayDanhSachGheDaDat(int suatChieuID)
        {
            List<int> dsGhe = new List<int>();

            string sql = @"
                SELECT SeatNumber 
                FROM Ve 
                WHERE SuatChieuID = @SuatChieuID";

            SqlParameter[] prms =
            {
                new SqlParameter("@SuatChieuID", suatChieuID)
            };

            DataTable dt = dp.ExecuteQuery(sql, prms);

            foreach (DataRow row in dt.Rows)
            {
                dsGhe.Add(Convert.ToInt32(row["SeatNumber"]));
            }

            return dsGhe;
        }

        public bool KiemTraGheDaDat(int suatChieuID, int seatNumber)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM Ve 
                WHERE SuatChieuID = @SuatChieuID 
                AND SeatNumber = @SeatNumber";

            SqlParameter[] prms =
            {
                new SqlParameter("@SuatChieuID", suatChieuID),
                new SqlParameter("@SeatNumber", seatNumber)
            };

            int count = (int)dp.ExecuteScalar(sql, prms);
            return count > 0;
        }

        public bool ThemVe(int billID, int seatNumber, int movieID, int suatChieuID)
        {
            string sql = @"
                INSERT INTO Ve(BillID, SeatNumber, MovieID, SuatChieuID)
                VALUES(@BillID, @SeatNumber, @MovieID, @SuatChieuID)";

            SqlParameter[] prms =
            {
                new SqlParameter("@BillID", billID),
                new SqlParameter("@SeatNumber", seatNumber),
                new SqlParameter("@MovieID", movieID),
                new SqlParameter("@SuatChieuID", suatChieuID)
            };

            return dp.ExecuteNonQuery(sql, prms) > 0;
        }
    }
}