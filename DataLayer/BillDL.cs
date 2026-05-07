using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class BillDL
    {
        DataProvider dp = new DataProvider();

        public int ThemHoaDonVaLayBillID(int customerID, int movieID, string gheDaChon,
            decimal tienGhe, decimal tienDoAn, decimal tongTien, string phuongThuc)
        {
            string sql = @"INSERT INTO HoaDon(CustomerID, MovieID, GheDaChon, TienGhe, TienDoAn, TongTien, PhuongThucThanhToan)
                           VALUES(@CustomerID, @MovieID, @GheDaChon, @TienGhe, @TienDoAn, @TongTien, @PhuongThuc);
                           SELECT SCOPE_IDENTITY();";

            SqlParameter[] prms =
            {
                new SqlParameter("@CustomerID", customerID),
                new SqlParameter("@MovieID", movieID),
                new SqlParameter("@GheDaChon", gheDaChon),
                new SqlParameter("@TienGhe", tienGhe),
                new SqlParameter("@TienDoAn", tienDoAn),
                new SqlParameter("@TongTien", tongTien),
                new SqlParameter("@PhuongThuc", phuongThuc)
            };

            object result = dp.ExecuteScalar(sql, prms);
            return System.Convert.ToInt32(result);
        }
    }
}
