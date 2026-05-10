using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class SuatChieuDL
    {
        DataProvider dp = new DataProvider();

        public DataTable LayTatCaSuatChieu()
        {
            string sql = @"
                SELECT sc.SuatChieuID, sc.MovieID, p.Title, sc.NgayChieu, sc.GioChieu, sc.PhongChieu, sc.TrangThai
                FROM SuatChieu sc
                INNER JOIN Phim p ON sc.MovieID = p.MovieID
                ORDER BY sc.NgayChieu, sc.GioChieu";

            return dp.ExecuteQuery(sql);
        }

        public DataTable LaySuatChieuTheoPhim(int movieID)
        {
            string sql = @"
                SELECT SuatChieuID, MovieID, NgayChieu, GioChieu, PhongChieu, TrangThai
                FROM SuatChieu
                WHERE MovieID = @MovieID
                AND TrangThai = N'Có sẵn'
                ORDER BY NgayChieu, GioChieu";

            SqlParameter[] prms =
            {
                new SqlParameter("@MovieID", movieID)
            };

            return dp.ExecuteQuery(sql, prms);
        }

        public bool ThemSuatChieu(int movieID, DateTime ngayChieu, TimeSpan gioChieu, string phongChieu, string trangThai)
        {
            string sql = @"
                INSERT INTO SuatChieu(MovieID, NgayChieu, GioChieu, PhongChieu, TrangThai)
                VALUES(@MovieID, @NgayChieu, @GioChieu, @PhongChieu, @TrangThai)";

            SqlParameter[] prms =
            {
                new SqlParameter("@MovieID", movieID),
                new SqlParameter("@NgayChieu", ngayChieu.Date),
                new SqlParameter("@GioChieu", gioChieu),
                new SqlParameter("@PhongChieu", phongChieu),
                new SqlParameter("@TrangThai", trangThai)
            };

            return dp.ExecuteNonQuery(sql, prms) > 0;
        }

        public bool CapNhatSuatChieu(int suatChieuID, int movieID, DateTime ngayChieu, TimeSpan gioChieu, string phongChieu, string trangThai)
        {
            string sql = @"
                UPDATE SuatChieu
                SET MovieID = @MovieID,
                    NgayChieu = @NgayChieu,
                    GioChieu = @GioChieu,
                    PhongChieu = @PhongChieu,
                    TrangThai = @TrangThai
                WHERE SuatChieuID = @SuatChieuID";

            SqlParameter[] prms =
            {
                new SqlParameter("@SuatChieuID", suatChieuID),
                new SqlParameter("@MovieID", movieID),
                new SqlParameter("@NgayChieu", ngayChieu.Date),
                new SqlParameter("@GioChieu", gioChieu),
                new SqlParameter("@PhongChieu", phongChieu),
                new SqlParameter("@TrangThai", trangThai)
            };

            return dp.ExecuteNonQuery(sql, prms) > 0;
        }

        public bool XoaSuatChieu(int suatChieuID)
        {
            string sql = "DELETE FROM SuatChieu WHERE SuatChieuID = @SuatChieuID";

            SqlParameter[] prms =
            {
                new SqlParameter("@SuatChieuID", suatChieuID)
            };

            return dp.ExecuteNonQuery(sql, prms) > 0;
        }
    }
}