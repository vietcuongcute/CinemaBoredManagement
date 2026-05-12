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
        public bool CapNhatKhachHang(int customerID, string hoTen, string sdt, string email)
        {
            if (customerID <= 0) return false;

            if (string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(sdt))
                return false;

            return customerDL.CapNhatKhachHang(
                customerID,
                hoTen.Trim(),
                sdt.Trim(),
                email.Trim()
            );
        }

        public bool XoaKhachHang(int customerID)
        {
            if (customerID <= 0) return false;

            return customerDL.XoaKhachHang(customerID);
        }

        public DataTable TimKiemKhachHang(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
                return customerDL.LayDanhSachKhachHang();

            return customerDL.TimKiemKhachHang(tuKhoa.Trim());
        }
    }
}
