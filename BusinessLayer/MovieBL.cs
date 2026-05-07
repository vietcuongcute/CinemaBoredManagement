using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class MovieBL
    {
        MovieDL movieDL = new MovieDL();

        public DataTable LayDanhSachPhim()
        {
            return movieDL.LayDanhSachPhim();
        }
        public int DemSoPhim()
        {
            return movieDL.DemSoPhim();
        }

        public DataTable LayDanhSachTatCaPhim()
        {
            return movieDL.LayDanhSachTatCaPhim();
        }
        public bool ThemPhim(string title, string genre, int duration, string status, int capacity, decimal price, string picture)
        {
            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(status))
                return false;

            if (duration <= 0 || capacity <= 0 || price <= 0)
                return false;

            return movieDL.ThemPhim(title.Trim(), genre.Trim(), duration, status.Trim(), capacity, price, picture);
        }
        public bool CapNhatPhim(int movieID, string title, string genre, int duration, string status, int capacity, decimal price, string picture)
        {
            if (movieID <= 0 ||
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(status))
                return false;

            if (duration <= 0 || capacity <= 0 || price <= 0)
                return false;

            return movieDL.CapNhatPhim(movieID, title.Trim(), genre.Trim(), duration, status.Trim(), capacity, price, picture);
        }

        public bool XoaPhim(int movieID)
        {
            if (movieID <= 0) return false;
            return movieDL.XoaPhim(movieID);
        }

        public bool XoaHetPhim()
        {
            return movieDL.XoaHetPhim();
        }
    }
}
