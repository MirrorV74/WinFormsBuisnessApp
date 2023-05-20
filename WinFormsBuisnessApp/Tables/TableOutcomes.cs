using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.Models;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableOutcomes
    {
        public NpgsqlConnection _connection;

        public TableOutcomes(NpgsqlConnection connection)
        {
            _connection = connection;
        }
        
        public void AddNew(Outcome outcome)
        {
            string sqlRequest = $"insert into outcomes (outcome_date, outcome_category_id, description, money) values ('{outcome.Date.ToString("yyyy-MM-dd")}',{outcome.CategoryId},'{outcome.Description}',{outcome.Money})";

            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            command.ExecuteNonQuery();
        }
        
        public void DeleteById(int id)
        {
            string sqlRequest = $"delete from outcomes where id = {id}";

            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            command.ExecuteNonQuery();
        }
    }
}
