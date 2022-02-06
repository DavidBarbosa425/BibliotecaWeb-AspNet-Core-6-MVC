using BibliotecaWeb.Models.Contracts.Repositories;
using System.Data.SqlClient;

namespace BibliotecaWeb.Models.Contexts
{
    public class ConnectionManager : IConnectionManager
    {
        private static string _connectionName = "biblioteca";
        private static SqlConnection connection = null;

        public ConnectionManager(IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString(_connectionName);
            if(connection == null)
                connection = new SqlConnection(connStr);
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
