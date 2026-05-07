using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MovieDL
    {
        DataProvider dp = new DataProvider();
        public DataTable LayDanhSachPhim()
        {
            string sql = @"SELECT MovieID, Title, Genre, Duration, Status, Capacity, Price, Picture
                           FROM Phim
                           WHERE Status = N'Có sẵn'";
            return dp.ExecuteQuery(sql);
        }
        public int DemSoPhim()
        {
            string sql = "SELECT COUNT(*) FROM Phim WHERE Status = N'Có sẵn'";
            return (int)dp.ExecuteScalar(sql);
        }

        public DataTable LayDanhSachTatCaPhim()
        {
            string sql = @"SELECT MovieID, Title, Genre, Duration, Status, Capacity, Price, Picture
                           FROM Phim
                            ORDER BY MovieID ASC";
            return dp.ExecuteQuery(sql);
        }
        public bool ThemPhim(string title, string genre, int duration, string status, int capacity, decimal price, string picture)
        {
            string sql = @"INSERT INTO Phim(Title, Genre, Duration, Status, Capacity, Price, Picture)
                       VALUES(@Title, @Genre, @Duration, @Status, @Capacity, @Price, @Picture)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@Title", title),
            new SqlParameter("@Genre", genre),
            new SqlParameter("@Duration", duration),
            new SqlParameter("@Status", status),
            new SqlParameter("@Capacity", capacity),
            new SqlParameter("@Price", price),
            new SqlParameter("@Picture", picture)
        };
            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }


        public bool CapNhatPhim(int movieID, string title, string genre, int duration, string status, int capacity, decimal price, string picture)
        {
            string sql = @"UPDATE Phim
                       SET Title = @Title,
                           Genre = @Genre,
                           Duration = @Duration,
                           Status = @Status,
                           Capacity = @Capacity,
                           Price = @Price,
                           Picture = @Picture
                       WHERE MovieID = @MovieID";

            SqlParameter[] parameters =
            {
            new SqlParameter("@MovieID", movieID),
            new SqlParameter("@Title", title),
            new SqlParameter("@Genre", genre),
            new SqlParameter("@Duration", duration),
            new SqlParameter("@Status", status),
            new SqlParameter("@Capacity", capacity),
            new SqlParameter("@Price", price),
            new SqlParameter("@Picture", picture)
        };

            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool XoaPhim(int movieID)
        {
            string sql = @"DELETE FROM Phim WHERE MovieID = @MovieID";

            SqlParameter[] parameters =
            {
            new SqlParameter("@MovieID", movieID)
        };

            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool XoaHetPhim()
        {
            string sql = @"DELETE FROM Movie";
            int kq = dp.ExecuteNonQuery(sql, null);
            return kq > 0;
        }
    }
}
