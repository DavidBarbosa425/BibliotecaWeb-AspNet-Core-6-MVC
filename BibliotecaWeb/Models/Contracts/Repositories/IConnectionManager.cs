using System.Data.SqlClient;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
