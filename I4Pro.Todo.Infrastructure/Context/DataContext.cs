using I4Pro.Todo.Shared;
using System;
using System.Data;
using System.Data.SqlClient;

namespace I4Pro.Todo.Infrastructure.Context
{
    public class DataContext : IDisposable
    {
        public DataContext()
        {
            Connection = new SqlConnection(Settings.Connection);
            Connection.Open();
        }

        public SqlConnection Connection { get; private set; }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
