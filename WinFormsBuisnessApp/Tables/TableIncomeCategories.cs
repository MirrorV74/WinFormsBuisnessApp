using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.Models;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableIncomeCategories
    {
        public NpgsqlConnection _connection;

        public TableIncomeCategories(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public List<IncomeCategory> GetAll() 
        { 
            List<IncomeCategory> incomeCategories= new List<IncomeCategory>();

            string sqlRequest = "SELECT * FROM income_categories ORDER BY id";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                string name = dataReader.GetString(dataReader.GetOrdinal("name"));

                incomeCategories.Add(new IncomeCategory()
                {
                    Id = id,
                    Name = name,
                });
            }

            dataReader.Close();

            return incomeCategories;
        }
    }
}
