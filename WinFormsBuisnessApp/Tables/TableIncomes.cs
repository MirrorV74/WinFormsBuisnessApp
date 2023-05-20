using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableIncomes
    {
        public NpgsqlConnection _connection;

        public TableIncomes(NpgsqlConnection connection)
        {
            _connection = connection;
        }
    }
}
