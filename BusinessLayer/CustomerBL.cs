using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBL
    {
        CustomerDL customerDL = new CustomerDL();

        public int ThemKhachHangVaLayID(string hoTen, string sdt, string email)
        {
            return customerDL.ThemKhachHangVaLayID(hoTen, sdt, email);
        }
        public DataTable LayDanhSachKhachHang()
        {
            return customerDL.LayDanhSachKhachHang();
        }
    }
}
