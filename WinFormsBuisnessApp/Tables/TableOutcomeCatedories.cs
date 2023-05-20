using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableOutcomeCatedories
    {
        public NpgsqlConnection _connection;

        public TableOutcomeCatedories(NpgsqlConnection connection)
        {
            _connection = connection;
        }
    }
}
