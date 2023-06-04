using WinFormsBuisnessApp.Controllers;

namespace WinFormsBuisnessApp;

public partial class FormMain : Form
{
    private FormMainController _formMainController;

    public FormMain()
    {
        InitializeComponent();

        _formMainController = new FormMainController(this);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        _formMainController.IncomeFillComboBoxIncomeInputCategory();
        _formMainController.OutcomeFillComboBoxOutcomeInputCategory();
        _formMainController.ResetDataTimePickers();
        _formMainController.FillDataGridViewIncomeChooseIncomesByDate();
        _formMainController.FillDataGridViewOutcomeChooseOutcomesByDate();
        _formMainController.SetBalanceDateTimePickerToTotalPeriod();
    }

    private void buttonIncomeAddIncome_Click(object sender, EventArgs e)
    {
        _formMainController.IncomeAddNew();
        _formMainController.FillDataGridViewIncomeChooseIncomesByDate();
    }

    private void buttonOutcomeAddOutcome_Click(object sender, EventArgs e)
    {
        _formMainController.OutcomeAddNew();
        _formMainController.FillDataGridViewOutcomeChooseOutcomesByDate();
    }

    private void dateTimePickerIncomeChooseDate_ValueChanged(object sender, EventArgs e)
    {
        _formMainController.FillDataGridViewIncomeChooseIncomesByDate();
    }

    private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _formMainController.DeleteIncomeById();
        _formMainController.FillDataGridViewIncomeChooseIncomesByDate();
    }

    private void dateTimePickerOutcomeChooseDate_ValueChanged(object sender, EventArgs e)
    {
        _formMainController.FillDataGridViewOutcomeChooseOutcomesByDate();
    }

    private void Û‰‡ÎËÚ¸ToolStripMenuOutcomeItem_Click(object sender, EventArgs e)
    {
        _formMainController.DeleteOutcomeById();
        _formMainController.FillDataGridViewOutcomeChooseOutcomesByDate();
    }

    private void dateTimePickerBalanceStartDate_ValueChanged(object sender, EventArgs e)
    {
        _formMainController.ChooseBalanceFromPeriod();
    }

    private void dateTimePickerBalanceFinishDate_ValueChanged(object sender, EventArgs e)
    {
        _formMainController.ChooseBalanceFromPeriod();
    }
}