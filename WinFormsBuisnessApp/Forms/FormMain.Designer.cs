namespace WinFormsBuisnessApp;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabControl1 = new TabControl();
        tabPageIncomes = new TabPage();
        buttonIncomeAddIncome = new Button();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        numericUpDownIncomeInputMoney = new NumericUpDown();
        textBoxIncomeInputDescription = new TextBox();
        comboBoxIncomeInputCategory = new ComboBox();
        dateTimePickerIncomeInputDate = new DateTimePicker();
        tabPageOutcomes = new TabPage();
        tabPageBalance = new TabPage();
        tabControl1.SuspendLayout();
        tabPageIncomes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownIncomeInputMoney).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPageIncomes);
        tabControl1.Controls.Add(tabPageOutcomes);
        tabControl1.Controls.Add(tabPageBalance);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(934, 600);
        tabControl1.TabIndex = 0;
        // 
        // tabPageIncomes
        // 
        tabPageIncomes.Controls.Add(buttonIncomeAddIncome);
        tabPageIncomes.Controls.Add(label5);
        tabPageIncomes.Controls.Add(label4);
        tabPageIncomes.Controls.Add(label3);
        tabPageIncomes.Controls.Add(label2);
        tabPageIncomes.Controls.Add(label1);
        tabPageIncomes.Controls.Add(numericUpDownIncomeInputMoney);
        tabPageIncomes.Controls.Add(textBoxIncomeInputDescription);
        tabPageIncomes.Controls.Add(comboBoxIncomeInputCategory);
        tabPageIncomes.Controls.Add(dateTimePickerIncomeInputDate);
        tabPageIncomes.Location = new Point(4, 29);
        tabPageIncomes.Name = "tabPageIncomes";
        tabPageIncomes.Padding = new Padding(3);
        tabPageIncomes.Size = new Size(926, 567);
        tabPageIncomes.TabIndex = 0;
        tabPageIncomes.Text = "Доходы";
        tabPageIncomes.UseVisualStyleBackColor = true;
        // 
        // buttonIncomeAddIncome
        // 
        buttonIncomeAddIncome.Location = new Point(8, 174);
        buttonIncomeAddIncome.Name = "buttonIncomeAddIncome";
        buttonIncomeAddIncome.Size = new Size(901, 29);
        buttonIncomeAddIncome.TabIndex = 9;
        buttonIncomeAddIncome.Text = "Добавить доход";
        buttonIncomeAddIncome.UseVisualStyleBackColor = true;
        buttonIncomeAddIncome.Click += buttonIncomeAddIncome_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(797, 73);
        label5.Name = "label5";
        label5.Size = new Size(72, 28);
        label5.TabIndex = 8;
        label5.Text = "Сумма";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(587, 73);
        label4.Name = "label4";
        label4.Size = new Size(104, 28);
        label4.TabIndex = 7;
        label4.Text = "Описание";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(381, 73);
        label3.Name = "label3";
        label3.Size = new Size(106, 28);
        label3.TabIndex = 6;
        label3.Text = "Категория";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(107, 73);
        label2.Name = "label2";
        label2.Size = new Size(54, 28);
        label2.TabIndex = 5;
        label2.Text = "Дата";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(329, 3);
        label1.Name = "label1";
        label1.Size = new Size(271, 38);
        label1.TabIndex = 4;
        label1.Text = "Добавление дохода";
        // 
        // numericUpDownIncomeInputMoney
        // 
        numericUpDownIncomeInputMoney.Location = new Point(759, 129);
        numericUpDownIncomeInputMoney.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        numericUpDownIncomeInputMoney.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownIncomeInputMoney.Name = "numericUpDownIncomeInputMoney";
        numericUpDownIncomeInputMoney.Size = new Size(150, 27);
        numericUpDownIncomeInputMoney.TabIndex = 3;
        numericUpDownIncomeInputMoney.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // textBoxIncomeInputDescription
        // 
        textBoxIncomeInputDescription.Location = new Point(565, 132);
        textBoxIncomeInputDescription.Name = "textBoxIncomeInputDescription";
        textBoxIncomeInputDescription.Size = new Size(150, 27);
        textBoxIncomeInputDescription.TabIndex = 2;
        // 
        // comboBoxIncomeInputCategory
        // 
        comboBoxIncomeInputCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxIncomeInputCategory.FormattingEnabled = true;
        comboBoxIncomeInputCategory.Location = new Point(353, 129);
        comboBoxIncomeInputCategory.Name = "comboBoxIncomeInputCategory";
        comboBoxIncomeInputCategory.Size = new Size(151, 28);
        comboBoxIncomeInputCategory.TabIndex = 1;
        // 
        // dateTimePickerIncomeInputDate
        // 
        dateTimePickerIncomeInputDate.Location = new Point(8, 130);
        dateTimePickerIncomeInputDate.Name = "dateTimePickerIncomeInputDate";
        dateTimePickerIncomeInputDate.Size = new Size(250, 27);
        dateTimePickerIncomeInputDate.TabIndex = 0;
        // 
        // tabPageOutcomes
        // 
        tabPageOutcomes.Location = new Point(4, 29);
        tabPageOutcomes.Name = "tabPageOutcomes";
        tabPageOutcomes.Padding = new Padding(3);
        tabPageOutcomes.Size = new Size(926, 567);
        tabPageOutcomes.TabIndex = 1;
        tabPageOutcomes.Text = "Расходы";
        tabPageOutcomes.UseVisualStyleBackColor = true;
        // 
        // tabPageBalance
        // 
        tabPageBalance.Location = new Point(4, 29);
        tabPageBalance.Name = "tabPageBalance";
        tabPageBalance.Padding = new Padding(3);
        tabPageBalance.Size = new Size(926, 567);
        tabPageBalance.TabIndex = 2;
        tabPageBalance.Text = "Баланс";
        tabPageBalance.UseVisualStyleBackColor = true;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(934, 600);
        Controls.Add(tabControl1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormMain";
        Text = "Form1";
        Load += FormMain_Load;
        tabControl1.ResumeLayout(false);
        tabPageIncomes.ResumeLayout(false);
        tabPageIncomes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownIncomeInputMoney).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPageIncomes;
    private Button buttonIncomeAddIncome;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private NumericUpDown numericUpDownIncomeInputMoney;
    private TextBox textBoxIncomeInputDescription;
    private ComboBox comboBoxIncomeInputCategory;
    private DateTimePicker dateTimePickerIncomeInputDate;
    private TabPage tabPageOutcomes;
    private TabPage tabPageBalance;
}