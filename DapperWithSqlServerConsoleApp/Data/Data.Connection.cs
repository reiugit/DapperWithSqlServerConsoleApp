using Microsoft.Data.SqlClient; // or System.Data.SqlClient

namespace DapperWithSqlServerConsoleApp.Data;

internal static class Connection
{
    public static SqlConnection Open()
    {
        // for brevity without appsettings.json, IConfiguration,
        // ConnectionFactory, Dependency Injection etc.

        var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ProductsDb;Trusted_Connection=True;";

        var connection = new SqlConnection(connectionString);
        connection.Open();

        return connection;
    }
}
