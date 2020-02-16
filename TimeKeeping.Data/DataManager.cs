using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TimeKeeping.Data
{
    public abstract class DataManager
    {
        protected IDbConnection GetDbConnection()
        {
            string dbConn = ConfigurationManager.ConnectionStrings["TimeKeeping"].ConnectionString;
            return new SqlConnection(dbConn);
        }
    }
}
