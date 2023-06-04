using Npgsql;

namespace WinFormsBuisnessApp.Tables;

public class TableUtils
{
    public NpgsqlConnection _connection;

    public TableUtils(NpgsqlConnection connection)
    {
        _connection = connection;
    }
    public DateTime GetMinimumDateFromIncomesAndOutcomes()
    {

        string sqlRequest = @"
            SELECT min(mn)
            FROM (
            SELECT  min(income_date) AS mn FROM incomes
            UNION
            SELECT  min(outcome_date) AS mn FROM outcomes
                ) AS t1";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        dataReader.Read();
        DateTime date = dataReader.GetDateTime(dataReader.GetOrdinal("min"));
        
        dataReader.Close();

        return date;
    }
    
    public DateTime GetMaximumDateFromIncomesAndOutcomes()
    {

        string sqlRequest = @"
        SELECT max(mx)
            FROM (
            SELECT  max(income_date) AS mx FROM incomes
            UNION
            SELECT  max(outcome_date) AS mx FROM outcomes
                ) AS t1";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        dataReader.Read();
        DateTime date = dataReader.GetDateTime(dataReader.GetOrdinal("max"));
        
        dataReader.Close();

        return date;
    }
}