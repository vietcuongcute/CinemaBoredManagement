using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class NhanVienBL
    {
        NhanVienDL nhanVienDL = new NhanVienDL();

        public DataTable LayDanhSachNhanVien()
        {
            return nhanVienDL.LayDanhSachNhanVien();
        }

        public bool ThemNhanVien(string tenDangNhap, string matKhau, string vaiTro)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(vaiTro))
                return false;

            if (nhanVienDL.KiemTraTenDangNhapTonTai(tenDangNhap))
                return false;

            return nhanVienDL.ThemNhanVien(tenDangNhap.Trim(), matKhau.Trim(), vaiTro.Trim());
        }

        public bool CapNhatNhanVien(int maTK, string tenDangNhap, string matKhau, string vaiTro)
        {
            if (maTK <= 0 ||
                string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(vaiTro))
                return false;

            return nhanVienDL.CapNhatNhanVien(maTK, tenDangNhap.Trim(), matKhau.Trim(), vaiTro.Trim());
        }

        public bool XoaNhanVien(int maTK)
        {
            if (maTK <= 0) return false;
            return nhanVienDL.XoaNhanVien(maTK);
        }

        public bool XoaHetNhanVien()
        {
            return nhanVienDL.XoaHetNhanVien();
        }

    }
}
