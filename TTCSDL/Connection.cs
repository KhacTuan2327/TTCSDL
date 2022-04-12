using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TTCSDL
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-CM6N3SA\SQLEXPRESS;Initial Catalog=QL_DETAI;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
