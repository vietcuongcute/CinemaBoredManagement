using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class LoginDL
    {
        DataProvider dp = new DataProvider();

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sql = @"SELECT COUNT(*) 
                           FROM TaiKhoan
                           WHERE TenDangNhap = @TenDangNhap
                           AND MatKhau = @MatKhau";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau)
            };

            int count = (int)dp.ExecuteScalar(sql, parameters);
            return count > 0;
            
        }

        public string LayVaiTro(string tenDangNhap)
        {
            string sql = @"SELECT VaiTro
                           FROM TaiKhoan
                           WHERE TenDangNhap = @TenDangNhap";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap)
            };

            object result = dp.ExecuteScalar(sql, parameters);
            return result != null ? result.ToString() : "";
        }
    }
}
