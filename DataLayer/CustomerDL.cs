using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerDL
    {
        DataProvider dp = new DataProvider();

        public int ThemKhachHangVaLayID(string hoTen, string sdt, string email)
        {
            string sql = @"INSERT INTO KhachHang(FullName, Phone, Email)
                           VALUES(@FullName, @Phone, @Email);
                           SELECT SCOPE_IDENTITY();";

            SqlParameter[] prms =
            {
                new SqlParameter("@FullName", hoTen),
                new SqlParameter("@Phone", sdt),
                new SqlParameter("@Email", email)
            };

            object result = dp.ExecuteScalar(sql, prms);
            return System.Convert.ToInt32(result);
        }
        public DataTable LayDanhSachKhachHang()
        {
            string sql = @"SELECT CustomerID, FullName, Phone, Email
                           FROM KhachHang";
            return dp.ExecuteQuery(sql);
        }
    }
}
