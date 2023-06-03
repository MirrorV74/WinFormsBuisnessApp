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
            
            //List<Income> list = _dbManager.TableIncomes.GetByDate(new DateOnly(2023,5,20));
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
                MessageBox.Show("Ошибка: база данных не отвечает");
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

        public void OutcomeFillComboBoxOutcomeInputCategory()
        {
            TabPage tabPageOutcomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageOutcomes"];
            ComboBox comboBoxOutcomeInputCategory = (ComboBox)tabPageOutcomes.Controls["comboBoxOutcomeInputCategory"];

            List<OutcomeCategory> outcomeCategories = _dbManager.TableOutcomeCatedories.GetAll();

            comboBoxOutcomeInputCategory.DataSource = null;
            comboBoxOutcomeInputCategory.DataSource = outcomeCategories;

            comboBoxOutcomeInputCategory.DisplayMember = "Name";

            comboBoxOutcomeInputCategory.SelectedIndex = -1;
        }

        public void OutcomeAddNew()
        {
            TabPage tabPageOutcomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageOutcomes"];

            DateTimePicker dateTimePickerOutcomeInputDate =
                (DateTimePicker)tabPageOutcomes.Controls["dateTimePickerOutcomeInputDate"];
            ComboBox comboBoxOutcomeInputCategory = (ComboBox)tabPageOutcomes.Controls["comboBoxOutcomeInputCategory"];
            TextBox textBoxOutcomeInputDescription = (TextBox)tabPageOutcomes.Controls["textBoxOutcomeInputDescription"];
            NumericUpDown numericUpDownOutcomeInputMoney = (NumericUpDown)tabPageOutcomes.Controls["numericUpDownOutcomeInputMoney"];

            if (dateTimePickerOutcomeInputDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ошибка: расход из будущего");
                return;
            }

            if (comboBoxOutcomeInputCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка: Не выбрана категория");
                return;
            }

            if (textBoxOutcomeInputDescription.Text.Length == 0)
            {
                MessageBox.Show("Ошибка: Нет описания");
                return;
            }

            Outcome outcome = new Outcome()
            {
                Date = DateOnly.FromDateTime(dateTimePickerOutcomeInputDate.Value),
                CategoryId = ((OutcomeCategory)comboBoxOutcomeInputCategory.SelectedItem).Id,
                Description = textBoxOutcomeInputDescription.Text,
                Money = (int)numericUpDownOutcomeInputMoney.Value
            };

            try
            {
                _dbManager.TableOutcomes.AddNew(outcome);
            }
            catch
            {
                MessageBox.Show("Ошибка: база данных не отвечает");
                return;
            }

            dateTimePickerOutcomeInputDate.Value = DateTime.Now.Date;
            comboBoxOutcomeInputCategory.SelectedIndex = -1;
            textBoxOutcomeInputDescription.Clear();
            numericUpDownOutcomeInputMoney.Value = numericUpDownOutcomeInputMoney.Minimum;

            MessageBox.Show("Успех: Расход добавлен");
        }
    }
}
