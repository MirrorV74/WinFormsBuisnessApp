using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBuisnessApp.DB;
using WinFormsBuisnessApp.Models;

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
            List<IncomeCategory> list = _dbManager.TableIncomesCategories.GetAll();
        }
    }
}
