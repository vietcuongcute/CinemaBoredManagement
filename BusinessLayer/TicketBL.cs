using System.Collections.Generic;
using DataLayer;

namespace BusinessLayer
{
    public class TicketBL
    {
        TicketDL ticketDL = new TicketDL();

        public List<int> LayDanhSachGheDaDat(int suatChieuID)
        {
            return ticketDL.LayDanhSachGheDaDat(suatChieuID);
        }

        public bool KiemTraGheDaDat(int suatChieuID, int seatNumber)
        {
            return ticketDL.KiemTraGheDaDat(suatChieuID, seatNumber);
        }

        public bool ThemVe(int billID, int seatNumber, int movieID, int suatChieuID)
        {
            return ticketDL.ThemVe(billID, seatNumber, movieID, suatChieuID);
        }
    }
}