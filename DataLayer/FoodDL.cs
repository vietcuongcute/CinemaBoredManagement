using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class FoodDL
    {
        DataProvider dp = new DataProvider();

        public DataTable LayDoAnTheoLoai(string loai)
        {
            string sql = "SELECT FoodID, FoodName, Price FROM DoAn WHERE Category = @Category";

            SqlParameter[] prms =
            {
                new SqlParameter("@Category", loai)
            };

            return dp.ExecuteQuery(sql, prms);
        }
    }
}
