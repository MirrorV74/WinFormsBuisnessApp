using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableOutcomes
    {
        public NpgsqlConnection _connection;

        public TableOutcomes(NpgsqlConnection connection)
        {
            _connection = connection;
        }
    }
}
