using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalManagementSystem
{
    public interface IDbConnection : IDisposable
    {
        void Open();
        IDbCommand CreateCommand();
    }
}
