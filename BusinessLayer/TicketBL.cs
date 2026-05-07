using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TicketBL
    {
        TicketDL ticketDL = new TicketDL();

        public List<int> LayDanhSachGheDaDat(int movieID)
        {
            return ticketDL.LayDanhSachGheDaDat(movieID);
        }

        public bool KiemTraGheDaDat(int movieID, int seatNumber)
        {
            return ticketDL.KiemTraGheDaDat(movieID, seatNumber);
        }

        public bool ThemVe(int billID, int seatNumber, int movieID)
        {
            return ticketDL.ThemVe(billID, seatNumber, movieID);
        }
    }
}
