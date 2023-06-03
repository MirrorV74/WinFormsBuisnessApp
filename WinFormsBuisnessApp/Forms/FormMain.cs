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
    }

    private void buttonIncomeAddIncome_Click(object sender, EventArgs e)
    {
        _formMainController.IncomeAddNew();
    }

    private void buttonOutcomeAddOutcome_Click(object sender, EventArgs e)
    {
        _formMainController.OutcomeAddNew();
    }
}