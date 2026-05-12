using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DoanhThuDL
    {
        DataProvider dp = new DataProvider();

        public DataTable LayDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
                SELECT 
                    hd.BillID,
                    kh.FullName,
                    p.Title,
                    hd.GheDaChon,
                    hd.TienGhe,
                    hd.TienDoAn,
                    hd.TongTien,
                    hd.PhuongThucThanhToan,
                    hd.NgayMua
                FROM HoaDon hd
                LEFT JOIN KhachHang kh ON hd.CustomerID = kh.CustomerID
                LEFT JOIN Phim p ON hd.MovieID = p.MovieID
                WHERE hd.NgayMua >= @TuNgay
                AND hd.NgayMua < DATEADD(DAY, 1, @DenNgay)
                ORDER BY hd.NgayMua DESC";

            SqlParameter[] prms =
            {
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date)
            };

            return dp.ExecuteQuery(sql, prms);
        }

        public DataTable LayThongKeDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
        SELECT
            (SELECT COUNT(*) 
             FROM HoaDon 
             WHERE NgayMua >= @TuNgay AND NgayMua < DATEADD(DAY, 1, @DenNgay)) AS TongHoaDon,

            (SELECT COUNT(*) 
             FROM Ve v
             INNER JOIN HoaDon hd ON v.BillID = hd.BillID
             WHERE hd.NgayMua >= @TuNgay AND hd.NgayMua < DATEADD(DAY, 1, @DenNgay)) AS TongVe,

            (SELECT ISNULL(SUM(TienGhe), 0) 
             FROM HoaDon 
             WHERE NgayMua >= @TuNgay AND NgayMua < DATEADD(DAY, 1, @DenNgay)) AS TongTienVe,

            (SELECT ISNULL(SUM(TienDoAn), 0) 
             FROM HoaDon 
             WHERE NgayMua >= @TuNgay AND NgayMua < DATEADD(DAY, 1, @DenNgay)) AS TongTienDoAn,

            (SELECT ISNULL(SUM(TongTien), 0) 
             FROM HoaDon 
             WHERE NgayMua >= @TuNgay AND NgayMua < DATEADD(DAY, 1, @DenNgay)) AS TongDoanhThu";

            SqlParameter[] prms =
            {
        new SqlParameter("@TuNgay", tuNgay.Date),
        new SqlParameter("@DenNgay", denNgay.Date)
    };

            return dp.ExecuteQuery(sql, prms);
        }
        public decimal TinhTongDoanhThu()
        {
            string sql = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon";

            object result = dp.ExecuteScalar(sql);
            return Convert.ToDecimal(result);
        }
    }
}
