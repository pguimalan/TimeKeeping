using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    public abstract class DataManager
    {
        protected IDbConnection GetDbConnection()
        {
            string dbConn = ConfigurationManager.ConnectionStrings["HRInfo"].ConnectionString;
            return new SqlConnection(dbConn);
        }
    }
}
