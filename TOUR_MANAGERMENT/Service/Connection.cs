using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;




namespace TOUR_MANAGERMENT.Service
{
    public class Connenction
    {
        //private static string db = @"MSI";
        private static string db = @"LAPTOP-TBTLP9L8\MSSQLSERVER05";

        private static readonly string baseConnectionString = @$"Data Source={db};Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection(string database)
        {
            string connectionString = $"{baseConnectionString};Initial Catalog={database};";
            return new SqlConnection(connectionString);
        }
        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
