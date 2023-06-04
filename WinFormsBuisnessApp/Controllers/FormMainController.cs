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

        public void ResetDataTimePickers() 
        {
            TabPage tabPageOutcomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageOutcomes"];
            TabPage tabPageIncomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageIncomes"];

            DateTimePicker dateTimePickerOutcomeInputDate =
                (DateTimePicker)tabPageOutcomes.Controls["dateTimePickerOutcomeInputDate"];
            DateTimePicker dateTimePickerOutcomeChooseDate =
                (DateTimePicker)tabPageOutcomes.Controls["dateTimePickerOutcomeChooseDate"];
            DateTimePicker dateTimePickerIncomeInputDate =
                (DateTimePicker)tabPageIncomes.Controls["dateTimePickerIncomeInputDate"];
            DateTimePicker dateTimePickerIncomeChooseDate =
                (DateTimePicker)tabPageIncomes.Controls["dateTimePickerIncomeChooseDate"];

            dateTimePickerOutcomeInputDate.Value = DateTime.Now.Date;
            dateTimePickerOutcomeChooseDate.Value = DateTime.Now.Date;
            dateTimePickerIncomeInputDate.Value = DateTime.Now.Date;
            dateTimePickerIncomeChooseDate.Value = DateTime.Now.Date;
        }

        public void FillDataGridViewIncomeChooseIncomesByDate() 
        {
            TabPage tabPageIncomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageIncomes"];
            DateTimePicker dateTimePickerIncomeChooseDate =
                (DateTimePicker)tabPageIncomes.Controls["dateTimePickerIncomeChooseDate"];
            DataGridView dataGridView = (DataGridView)tabPageIncomes.Controls["dataGridViewIncomeChooseIncomes"];

            DateOnly chooseDate = DateOnly.FromDateTime(dateTimePickerIncomeChooseDate.Value);

            dataGridView.DataSource = null;
            dataGridView.DataSource = _dbManager.TableIncomes.GetByDate(chooseDate);

            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Date"].HeaderText = "Дата";
            dataGridView.Columns["CategoryId"].Visible = false;
            dataGridView.Columns["CategoryName"].HeaderText = "Категория";
            dataGridView.Columns["Description"].HeaderText = "Описание";
            dataGridView.Columns["Money"].HeaderText = "Сумма";
        }

        public void DeleteIncomeById() 
        {
            TabPage tabPageIncomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageIncomes"];
            DataGridView dataGridView = (DataGridView)tabPageIncomes.Controls["dataGridViewIncomeChooseIncomes"];

            if (dataGridView.SelectedRows.Count == 0) 
            {
                return;
            }

            int id = ((Income)dataGridView.SelectedRows[0].DataBoundItem).Id;

            try
            {
                _dbManager.TableIncomes.DeleteById(id);
            }
            catch
            {
                MessageBox.Show("Ошибка: база данных не отвечает");
                return;
            }
        }

        public void FillDataGridViewOutcomeChooseOutcomesByDate()
        {
            TabPage tabPageOutcomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageOutcomes"];
            DateTimePicker dateTimePickerOutcomeChooseDate =
                (DateTimePicker)tabPageOutcomes.Controls["dateTimePickerOutcomeChooseDate"];
            DataGridView dataGridView = (DataGridView)tabPageOutcomes.Controls["dataGridViewOutcomeChooseOutcomes"];

            DateOnly chooseDate = DateOnly.FromDateTime(dateTimePickerOutcomeChooseDate.Value);

            dataGridView.DataSource = null;
            dataGridView.DataSource = _dbManager.TableOutcomes.GetByDate(chooseDate);

            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Date"].HeaderText = "Дата";
            dataGridView.Columns["CategoryId"].Visible = false;
            dataGridView.Columns["CategoryName"].HeaderText = "Категория";
            dataGridView.Columns["Description"].HeaderText = "Описание";
            dataGridView.Columns["Money"].HeaderText = "Сумма";
        }

        public void DeleteOutcomeById()
        {
            TabPage tabPageOutcomes = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageOutcomes"];
            DataGridView dataGridView = (DataGridView)tabPageOutcomes.Controls["dataGridViewOutcomeChooseOutcomes"];

            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            int id = ((Outcome)dataGridView.SelectedRows[0].DataBoundItem).Id;

            try
            {
                _dbManager.TableOutcomes.DeleteById(id);
            }
            catch
            {
                MessageBox.Show("Ошибка: база данных не отвечает");
                return;
            }
        }

        public void SetBalanceDateTimePickerToTotalPeriod()
        {
            TabPage tabPageBalance = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageBalance"];
            DateTimePicker dateTimePickerBalanceStartDate =
                (DateTimePicker)tabPageBalance.Controls["dateTimePickerBalanceStartDate"];
            DateTimePicker dateTimePickerBalanceFinishDate =
                (DateTimePicker)tabPageBalance.Controls["dateTimePickerBalanceFinishDate"];

            dateTimePickerBalanceStartDate.Value = _dbManager.TableUtils.GetMinimumDateFromIncomesAndOutcomes();
            dateTimePickerBalanceFinishDate.Value = _dbManager.TableUtils.GetMaximumDateFromIncomesAndOutcomes();
        }

        public void ChooseBalanceFromPeriod()
        {
            TabPage tabPageBalance = (TabPage)((TabControl)_formMain.Controls["tabControl1"]).Controls["tabPageBalance"];
            DateTimePicker dateTimePickerBalanceStartDate =
                (DateTimePicker)tabPageBalance.Controls["dateTimePickerBalanceStartDate"];
            DateTimePicker dateTimePickerBalanceFinishDate =
                (DateTimePicker)tabPageBalance.Controls["dateTimePickerBalanceFinishDate"];

            TextBox textBoxBalanceTotalIncome = (TextBox)tabPageBalance.Controls["textBoxBalanceTotalIncome"];
            TextBox textBoxBalanceTotalOutcome = (TextBox)tabPageBalance.Controls["textBoxBalanceTotalOutcome"];
            TextBox textBoxBalanceMoneyBalance = (TextBox)tabPageBalance.Controls["textBoxBalanceMoneyBalance"];
            
            DateTime startDate = dateTimePickerBalanceStartDate.Value;
            DateTime finishDate = dateTimePickerBalanceFinishDate.Value;

            if (startDate.Date > finishDate.Date)
            {
                return;
            }
            int incomeMoney = _dbManager.TableIncomes.GetMoneyFromPeriod(startDate, finishDate);
            int outcomeMoney = _dbManager.TableOutcomes.GetMoneyFromPeriod(startDate, finishDate);
            int result = incomeMoney - outcomeMoney;

            textBoxBalanceTotalIncome.Text = incomeMoney.ToString();
            textBoxBalanceTotalOutcome.Text = outcomeMoney.ToString();
            textBoxBalanceMoneyBalance.Text = result.ToString();
        }
    }
}
