using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.Models;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableOutcomeCatedories
    {
        public NpgsqlConnection _connection;

        public TableOutcomeCatedories(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public List<OutcomeCategory> GetAll()
        {
            List<OutcomeCategory> outcomeCategories = new List<OutcomeCategory>();

            string sqlRequest = "SELECT * FROM outcome_categories ORDER BY id";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                string name = dataReader.GetString(dataReader.GetOrdinal("name"));

                outcomeCategories.Add(new OutcomeCategory()
                {
                    Id = id,
                    Name = name,
                });
            }

            dataReader.Close();

            return outcomeCategories;
        }
    }
}
