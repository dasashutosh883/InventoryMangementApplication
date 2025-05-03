using Microsoft.Data.SqlClient;
using System.Data;

namespace IMS.Infrastructure.Context
{
    public interface IDapperContext
    {
        // Define methods and properties for Dapper context here
        // For example, you might want to define a method to get a connection
        public IDbConnection GetConnection { get; }
    }
    public class DapperContext : IDapperContext
    {
        public readonly string _connectionString;
        public DapperContext(string connenctionString)
        {
            _connectionString = connenctionString;
        }
        public IDbConnection GetConnection => new SqlConnection(_connectionString);
    }
}
