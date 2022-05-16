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
        private static string stringConnection = @"Data Source=NGAN\SQLEXPRESS01;Initial Catalog=QL_DETAI1;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=NGAN\SQLEXPRESS01;Initial Catalog=QL_DETAI1;Integrated Security=True");

        public SqlConnection GetCon()
        {
            return connection ;
        }

    }
}
