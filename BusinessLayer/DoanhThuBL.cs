using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class DoanhThuBL
    {
        DoanhThuDL doanhThuDL = new DoanhThuDL();

        public DataTable LayDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
                return new DataTable();

            return doanhThuDL.LayDoanhThuTheoNgay(tuNgay, denNgay);
        }

        public DataTable LayThongKeDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
                return new DataTable();

            return doanhThuDL.LayThongKeDoanhThu(tuNgay, denNgay);
        }
        public decimal TinhTongDoanhThu()
        {
            return doanhThuDL.TinhTongDoanhThu();
        }
    }
}
