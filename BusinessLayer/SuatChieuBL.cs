using System;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class SuatChieuBL
    {
        SuatChieuDL suatChieuDL = new SuatChieuDL();

        public DataTable LayTatCaSuatChieu()
        {
            return suatChieuDL.LayTatCaSuatChieu();
        }

        public DataTable LaySuatChieuTheoPhim(int movieID)
        {
            if (movieID <= 0)
                return new DataTable();

            return suatChieuDL.LaySuatChieuTheoPhim(movieID);
        }

        public bool ThemSuatChieu(int movieID, DateTime ngayChieu, TimeSpan gioChieu, string phongChieu, string trangThai)
        {
            if (movieID <= 0) return false;
            if (string.IsNullOrWhiteSpace(phongChieu)) return false;
            if (string.IsNullOrWhiteSpace(trangThai)) return false;

            return suatChieuDL.ThemSuatChieu(movieID, ngayChieu, gioChieu, phongChieu.Trim(), trangThai.Trim());
        }

        public bool CapNhatSuatChieu(int suatChieuID, int movieID, DateTime ngayChieu, TimeSpan gioChieu, string phongChieu, string trangThai)
        {
            if (suatChieuID <= 0) return false;
            if (movieID <= 0) return false;
            if (string.IsNullOrWhiteSpace(phongChieu)) return false;
            if (string.IsNullOrWhiteSpace(trangThai)) return false;

            return suatChieuDL.CapNhatSuatChieu(suatChieuID, movieID, ngayChieu, gioChieu, phongChieu.Trim(), trangThai.Trim());
        }

        public bool XoaSuatChieu(int suatChieuID)
        {
            if (suatChieuID <= 0) return false;
            return suatChieuDL.XoaSuatChieu(suatChieuID);
        }

        public DataTable LayPhimTheoNgay(DateTime ngayChieu)
        {
            return suatChieuDL.LayPhimTheoNgay(ngayChieu);
        }

        public DataTable LaySuatChieuTheoPhimVaNgay(int movieID, DateTime ngayChieu)
        {
            if (movieID <= 0) return new DataTable();

            return suatChieuDL.LaySuatChieuTheoPhimVaNgay(movieID, ngayChieu);
        }
    }
}