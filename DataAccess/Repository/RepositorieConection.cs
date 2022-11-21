using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public abstract class RepositorieConection
    {
        private readonly string ConnectionString;
        public RepositorieConection()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["conetion"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
