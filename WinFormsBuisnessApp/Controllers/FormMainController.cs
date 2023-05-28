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

        public void IncomeAddNew()
        {
            TabPage tabPageIncomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageIncomes"];
            
            DateTimePicker dateTimePickerIncomeInputDate = 
                (DateTimePicker)tabPageIncomes.Controls["dateTimePickerIncomeInputDate"];
            ComboBox comboBoxIncomeInputCategory = (ComboBox)tabPageIncomes.Controls["comboBoxIncomeInputCategory"];
            TextBox textBoxIncomeInputDescription = (TextBox)tabPageIncomes.Controls["textBoxIncomeInputDescription"];
            NumericUpDown numericUpDownIncomeInputMoney = (NumericUpDown)tabPageIncomes.Controls["numericUpDownIncomeInputMoney"];

            if (dateTimePickerIncomeInputDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ошибка: доход из будщего");
                return;
            }
            
            if (comboBoxIncomeInputCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка: Не выбрана категория");
                return;
            }
            
            if (textBoxIncomeInputDescription.Text.Length == 0)
            {
                MessageBox.Show("Ошибка: Нет описания");
                return;
            }
            
            Income income = new Income()
            {
                Date = DateOnly.FromDateTime(dateTimePickerIncomeInputDate.Value),
                CategoryId = ((IncomeCategory)comboBoxIncomeInputCategory.SelectedItem).Id,
                Description = textBoxIncomeInputDescription.Text,
                Money = (int)numericUpDownIncomeInputMoney.Value
            };

            try 
            {
                _dbManager.TableIncomes.AddNew(income);
            }
            catch 
            {
                MessageBox.Show("Ошибка: с база данных не отвечает");
                return;
            }

            dateTimePickerIncomeInputDate.Value = DateTime.Now.Date;
            comboBoxIncomeInputCategory.SelectedIndex = -1;
            textBoxIncomeInputDescription.Clear();
            numericUpDownIncomeInputMoney.Value = numericUpDownIncomeInputMoney.Minimum;

            MessageBox.Show("Успех: Доход добавлен");
        }

        public void IncomeFillComboBoxIncomeInputCategory()
        {
            TabPage tabPageIncomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageIncomes"];
            ComboBox comboBoxIncomeInputCategory = (ComboBox)tabPageIncomes.Controls["comboBoxIncomeInputCategory"];

            List<IncomeCategory> incomeCategories =_dbManager.TableIncomesCategories.GetAll();

            comboBoxIncomeInputCategory.DataSource = null;
            comboBoxIncomeInputCategory.DataSource = incomeCategories;

            comboBoxIncomeInputCategory.DisplayMember = "Name";

            comboBoxIncomeInputCategory.SelectedIndex = -1;
        }
    }
}
