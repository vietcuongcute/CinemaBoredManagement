using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class NhanVienDL
    {
        DataProvider dp = new DataProvider();

        public DataTable LayDanhSachNhanVien()
        {
            string sql = @"SELECT MaTK, TenDangNhap, MatKhau, VaiTro
                       FROM TaiKhoan
                       ORDER BY MaTK ASC";
            return dp.ExecuteQuery(sql);
        }

        public bool ThemNhanVien(string tenDangNhap, string matKhau, string vaiTro)
        {
            string sql = @"INSERT INTO TaiKhoan(TenDangNhap, MatKhau, VaiTro)
                       VALUES(@TenDangNhap, @MatKhau, @VaiTro)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@TenDangNhap", tenDangNhap),
            new SqlParameter("@MatKhau", matKhau),
            new SqlParameter("@VaiTro", vaiTro)
        };

            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool CapNhatNhanVien(int maTK, string tenDangNhap, string matKhau, string vaiTro)
        {
            string sql = @"UPDATE TaiKhoan
                       SET TenDangNhap = @TenDangNhap,
                           MatKhau = @MatKhau,
                           VaiTro = @VaiTro
                       WHERE MaTK = @MaTK";

            SqlParameter[] parameters =
            {
            new SqlParameter("@MaTK", maTK),
            new SqlParameter("@TenDangNhap", tenDangNhap),
            new SqlParameter("@MatKhau", matKhau),
            new SqlParameter("@VaiTro", vaiTro)
        };

            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool XoaNhanVien(int maTK)
        {
            string sql = @"DELETE FROM TaiKhoan WHERE MaTK = @MaTK";

            SqlParameter[] parameters =
            {
            new SqlParameter("@MaTK", maTK)
        };

            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool XoaHetNhanVien()
        {
            string sql = @"DELETE FROM TaiKhoan WHERE VaiTro = @VaiTro";

            SqlParameter[] parameters =
            {
            new SqlParameter("@VaiTro", "Nhân viên")
        };

            int kq = dp.ExecuteNonQuery(sql, parameters);
            return kq > 0;
        }

        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
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
        public int DemSoNhanVien()
        {
            string sql = @"
        SELECT COUNT(*) 
        FROM TaiKhoan
        WHERE VaiTro = N'Nhân viên' OR VaiTro = N'NhanVien'";

            object result = dp.ExecuteScalar(sql);
            return Convert.ToInt32(result);
        }
    }
}
