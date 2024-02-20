using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi
{
    class ConnectionKVC
    {
        private static string stringConnection = @"Data Source=ANPHATPC\SQLEXPRESS;Initial Catalog=QLKVC;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
