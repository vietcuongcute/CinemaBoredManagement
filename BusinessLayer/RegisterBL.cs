using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RegisterBL
    {
        RegisterDL registerDL = new RegisterDL();

        public bool KiemTraTonTaiTaiKhoan(string tenDangNhap)
        {
            return registerDL.KiemTraTonTaiTaiKhoan(tenDangNhap);
        }

        public bool DangKy(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
                return false;

            if (registerDL.KiemTraTonTaiTaiKhoan(tenDangNhap))
                return false;

            return registerDL.DangKyTaiKhoan(tenDangNhap, matKhau);
        }
    }
}
