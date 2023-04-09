using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaiTapLonWinform
{
    public class Conection
    {
        public static string url = @"Data Source=MANHHUNG-ECO\DUCHUY719;Initial Catalog=PHONE_STORE_MANAGER;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(url);
        }
    }
}
