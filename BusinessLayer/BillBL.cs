using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BillBL
    {
        BillDL billDL = new BillDL();

        public int ThemHoaDonVaLayBillID(int customerID, int movieID, int suatChieuID, string gheDaChon,
    decimal tienGhe, decimal tienDoAn, decimal tongTien, string phuongThuc)
        {
            return billDL.ThemHoaDonVaLayBillID(customerID, movieID, suatChieuID, gheDaChon, tienGhe, tienDoAn, tongTien, phuongThuc);
        }
    }
}
