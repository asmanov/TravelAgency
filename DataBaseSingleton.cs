using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class DataBaseSingleton
    {
        private static DataBaseSingleton instance = null;
        private static readonly object padlock = new object();
        private readonly SqlConnection connection;
        private readonly string connStr = "Server=localhost\\SQLEXPRESS;" +
                "Database=UserDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;";
        private DataBaseSingleton()
        {
            connection = new SqlConnection(connStr);
            connection.Open();
        }

        public static DataBaseSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataBaseSingleton();
                    }
                    return instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
