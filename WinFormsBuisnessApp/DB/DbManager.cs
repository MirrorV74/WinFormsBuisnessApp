using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.Tables;

namespace WinFormsBuisnessApp.DB
{
    internal class DbManager
    {
        private static DbManager _instance = null;

        public static DbManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbManager();
                }
                return _instance;
            }
        }

        public TableIncomes TableIncomes { get; private set; }
        public TableIncomeCategories TableIncomesCategories { get; private set; }
        public TableOutcomes TableOutcomes { get; private set; }
        public TableOutcomeCatedories TableOutcomeCatedories { get; private set; }
        
        public TableUtils TableUtils { get; private set; }


        private DbManager()
        {
            DbConnection dbconection = new DbConnection("194.67.105.79", "buisness_app_user", "12345", "buisness_app_db");
            TableIncomes = new TableIncomes(dbconection.Connection);
            TableIncomesCategories = new TableIncomeCategories(dbconection.Connection);
            TableOutcomes = new TableOutcomes(dbconection.Connection);
            TableOutcomeCatedories = new TableOutcomeCatedories(dbconection.Connection);
            TableUtils = new TableUtils(dbconection.Connection);
        }
    }
}
