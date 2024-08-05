using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HopitalManagementSystem
{
    public class SqlDbConnection : IDbConnection
    {
        private readonly SqlConnection _sqlConnection;

        public SqlDbConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            _sqlConnection.Open();
        }

        public IDbCommand CreateCommand()
        {
            return new SqlDbCommand(_sqlConnection.CreateCommand());
        }
        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
    }
}
