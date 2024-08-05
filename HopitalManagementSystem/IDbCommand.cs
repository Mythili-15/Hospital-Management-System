using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalManagementSystem
{
    public interface IDbCommand : IDisposable
    {
        int ExecuteNonQuery();
        void AddParameter(string name, object value);
        void SetCommandText(string commandText);
        void SetCommandType(CommandType commandType);
        DataTable FillDataTable();
        IDataReader ExecuteReader();
        object ExecuteScalar();
    }
}
