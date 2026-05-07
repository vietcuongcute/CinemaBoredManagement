using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LoginBL
    {
        LoginDL loginDL = new LoginDL();

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
                return false;

            return loginDL.KiemTraDangNhap(tenDangNhap, matKhau);
        }

        public string LayVaiTro(string tenDangNhap)
        {
            return loginDL.LayVaiTro(tenDangNhap);
        }
    }
}
