using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class RegisterDL
    {
        DataProvider dp = new DataProvider();

        public bool KiemTraTonTaiTaiKhoan(string tenDangNhap)
        {
            string sql = @"SELECT COUNT(*) 
                           FROM TaiKhoan 
                           WHERE TenDangNhap = @TenDangNhap";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap)
            };

            int count = (int)dp.ExecuteScalar(sql, parameters);
            return count > 0;
        }

        public bool DangKyTaiKhoan(string tenDangNhap, string matKhau)
        {
            string sql = @"INSERT INTO TaiKhoan(TenDangNhap, MatKhau, VaiTro)
                           VALUES(@TenDangNhap, @MatKhau, @VaiTro)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau),
                new SqlParameter("@VaiTro", "NhanVien")
            };

            int rows = dp.ExecuteNonQuery(sql, parameters);
            return rows > 0;
        }
    }
}
