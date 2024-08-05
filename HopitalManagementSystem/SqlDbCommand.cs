using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalManagementSystem
{
    public class SqlDbCommand : IDbCommand
    {
        private readonly SqlCommand _sqlCommand;

        public SqlDbCommand(SqlCommand sqlCommand)
        {
            _sqlCommand = sqlCommand;
        }

        // Implement IDbCommand methods
        public int ExecuteNonQuery()
        {
            return _sqlCommand.ExecuteNonQuery();
        }

        public void AddParameter(string name, object value)
        {
            _sqlCommand.Parameters.AddWithValue(name, value);
        }

        public void SetCommandText(string commandText)
        {
            _sqlCommand.CommandText = commandText;
        }

        public void SetCommandType(CommandType commandType)
        {
            _sqlCommand.CommandType = commandType;
        }

        public DataTable FillDataTable()
        {
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_sqlCommand))
            {
                sqlDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
        public IDataReader ExecuteReader()
        {
            return _sqlCommand.ExecuteReader();
        }
        public object ExecuteScalar()
        {
            return _sqlCommand.ExecuteScalar();
        }
        public void Dispose()
        {
            _sqlCommand.Dispose();
        }
    }
}
