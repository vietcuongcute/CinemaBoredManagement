using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class FoodBL
    {
        FoodDL foodDL = new FoodDL();
        public DataTable LayDoAnTheoLoai(string loai)
        {
            return foodDL.LayDoAnTheoLoai(loai);
        }
    }
}
