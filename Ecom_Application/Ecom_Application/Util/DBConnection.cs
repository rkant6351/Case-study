using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Utility
{
    public static class DBConnection
    {
        static SqlConnection connection = null;
        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["AppConnection"].ConnectionString;
            return connection;
        }
    }
}
