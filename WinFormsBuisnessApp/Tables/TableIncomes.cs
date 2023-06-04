using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.Models;

namespace WinFormsBuisnessApp.Tables
{
    internal class TableIncomes
    {
        public NpgsqlConnection _connection;

        public TableIncomes(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public void AddNew(Income income)
        {
            string sqlRequest = $"insert into incomes (income_date, income_category_id, description, money) values ('{income.Date.ToString("yyyy-MM-dd")}',{income.CategoryId},'{income.Description}',{income.Money})";

            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            command.ExecuteNonQuery();
        }

        public void DeleteById(int id)
        {
            string sqlRequest = $"delete from incomes where id = {id}";

            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            command.ExecuteNonQuery();
        }

        public List<Income> GetByDate(DateOnly searchDate)
        {
            List<Income> incomes= new List<Income>();

            string sqlRequest = @$"
            select i.id,i.income_date,i.description,i.money,i.income_category_id as category_id,ic.name as category_name 
            from incomes as i
            join income_categories as ic on ic.id = i.income_category_id
            where i.income_date = '{searchDate.ToString("yyyy-MM-dd")}'
            ";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                DateOnly date = DateOnly.FromDateTime(dataReader.GetDateTime(dataReader.GetOrdinal("income_date")));
                int categoryId = dataReader.GetInt32(dataReader.GetOrdinal("category_id"));
                string categoryName = dataReader.GetString(dataReader.GetOrdinal("category_name"));
                string description = dataReader.GetString(dataReader.GetOrdinal("description"));
                int money = dataReader.GetInt32(dataReader.GetOrdinal("money"));
                
                incomes.Add(new Income()
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

            return incomes;
        }

        public int GetMoneyFromPeriod(DateTime startDate, DateTime finishDate)
        {
            string sqlRequest = @$"SELECT sum(money) FROM incomes WHERE 
                                   income_date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{finishDate.ToString("yyyy-MM-dd")}' ";
            
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();
            
            dataReader.Read();
            int money = dataReader.GetInt32(dataReader.GetOrdinal("sum"));
        
            dataReader.Close();

            return money;
        }
    }
}
