using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.DB;
using WinFormsBuisnessApp.Models;
using WinFormsBuisnessApp.Tables;

namespace WinFormsBuisnessApp.Controllers
{
    internal class FormMainController
    {
        private FormMain _formMain;
        private DbManager _dbManager;

        public FormMainController(FormMain formfirst)
        {
            _formMain = formfirst;
            _dbManager = DbManager.Instance;
        }

        public void Test() 
        {
            //List<IncomeCategory> list = _dbManager.TableIncomesCategories.GetAll();

            //Income income = new Income()
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now),
            //    CategoryId = 3,
            //    Description = "aasas",
            //    Money = 10000
            //};
            //_dbManager.TableIncomes.AddNew(income);
            
            //Outcome outcome = new Outcome()
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now),
            //    CategoryId = 3,
            //    Description = "aasas",
            //    Money = 10000
            //};
            //_dbManager.TableOutcomes.AddNew(outcome);
            
            //_dbManager.TableIncomes.DeleteById(1);
            
            List<Income> list = _dbManager.TableIncomes.GetByDate(new DateOnly(2023,5,20));

            int i = 5;
        }
    }
}
