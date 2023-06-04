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
        
        public List<Outcome> GetByDate(DateOnly searchDate)
        {
            List<Outcome> outcomes= new List<Outcome>();

            string sqlRequest = @$"
            select i.id,i.outcome_date,i.description,i.money,i.outcome_category_id as category_id,ic.name as category_name 
            from outcomes as i
            join outcome_categories as ic on ic.id = i.outcome_category_id
            where i.outcome_date = '{searchDate.ToString("yyyy-MM-dd")}'
            ";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                DateOnly date = DateOnly.FromDateTime(dataReader.GetDateTime(dataReader.GetOrdinal("outcome_date")));
                int categoryId = dataReader.GetInt32(dataReader.GetOrdinal("category_id"));
                string categoryName = dataReader.GetString(dataReader.GetOrdinal("category_name"));
                string description = dataReader.GetString(dataReader.GetOrdinal("description"));
                int money = dataReader.GetInt32(dataReader.GetOrdinal("money"));
                
                outcomes.Add(new Outcome()
                {
                    Id = id,
                    Date = date,
                    CategoryId = categoryId,
                    CategoryName = categoryName,
                    Description = description,
                    Money = money
                });
            }

            dataReader.Close();

            return outcomes;
        }
        
        public int GetMoneyFromPeriod(DateTime startDate, DateTime finishDate)
        {
            string sqlRequest = @$"SELECT sum(money) FROM outcomes WHERE 
                                   outcome_date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{finishDate.ToString("yyyy-MM-dd")}' ";
            
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();
            
            dataReader.Read();
            int money = dataReader.GetInt32(dataReader.GetOrdinal("sum"));
        
            dataReader.Close();

            return money;
        }
    }
}
