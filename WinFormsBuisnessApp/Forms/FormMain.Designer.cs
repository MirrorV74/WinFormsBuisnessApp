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
        components = new System.ComponentModel.Container();
        tabControl1 = new TabControl();
        tabPageIncomes = new TabPage();
        dateTimePickerIncomeChooseDate = new DateTimePicker();
        label6 = new Label();
        dataGridViewIncomeChooseIncomes = new DataGridView();
        contextMenuStripIncomeDataGridView = new ContextMenuStrip(components);
        удалитьToolStripMenuItem = new ToolStripMenuItem();
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
        dateTimePickerOutcomeChooseDate = new DateTimePicker();
        label7 = new Label();
        dataGridView1 = new DataGridView();
        buttonOutcomeAddOutcome = new Button();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        numericUpDownOutcomeInputMoney = new NumericUpDown();
        textBoxOutcomeInputDescription = new TextBox();
        comboBoxOutcomeInputCategory = new ComboBox();
        dateTimePickerOutcomeInputDate = new DateTimePicker();
        tabPageBalance = new TabPage();
        tabControl1.SuspendLayout();
        tabPageIncomes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewIncomeChooseIncomes).BeginInit();
        contextMenuStripIncomeDataGridView.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownIncomeInputMoney).BeginInit();
        tabPageOutcomes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownOutcomeInputMoney).BeginInit();
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
        tabPageIncomes.Controls.Add(dateTimePickerIncomeChooseDate);
        tabPageIncomes.Controls.Add(label6);
        tabPageIncomes.Controls.Add(dataGridViewIncomeChooseIncomes);
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
        // dateTimePickerIncomeChooseDate
        // 
        dateTimePickerIncomeChooseDate.Location = new Point(535, 225);
        dateTimePickerIncomeChooseDate.Margin = new Padding(3, 4, 3, 4);
        dateTimePickerIncomeChooseDate.Name = "dateTimePickerIncomeChooseDate";
        dateTimePickerIncomeChooseDate.Size = new Size(265, 27);
        dateTimePickerIncomeChooseDate.TabIndex = 12;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(258, 217);
        label6.Name = "label6";
        label6.Size = new Size(222, 38);
        label6.TabIndex = 11;
        label6.Text = "Доходы на дату:";
        // 
        // dataGridViewIncomeChooseIncomes
        // 
        dataGridViewIncomeChooseIncomes.AllowUserToAddRows = false;
        dataGridViewIncomeChooseIncomes.AllowUserToDeleteRows = false;
        dataGridViewIncomeChooseIncomes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewIncomeChooseIncomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewIncomeChooseIncomes.ContextMenuStrip = contextMenuStripIncomeDataGridView;
        dataGridViewIncomeChooseIncomes.Location = new Point(9, 279);
        dataGridViewIncomeChooseIncomes.Margin = new Padding(3, 4, 3, 4);
        dataGridViewIncomeChooseIncomes.MultiSelect = false;
        dataGridViewIncomeChooseIncomes.Name = "dataGridViewIncomeChooseIncomes";
        dataGridViewIncomeChooseIncomes.ReadOnly = true;
        dataGridViewIncomeChooseIncomes.RowHeadersWidth = 51;
        dataGridViewIncomeChooseIncomes.RowTemplate.Height = 25;
        dataGridViewIncomeChooseIncomes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewIncomeChooseIncomes.Size = new Size(909, 273);
        dataGridViewIncomeChooseIncomes.TabIndex = 10;
        // 
        // contextMenuStripIncomeDataGridView
        // 
        contextMenuStripIncomeDataGridView.ImageScalingSize = new Size(20, 20);
        contextMenuStripIncomeDataGridView.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
        contextMenuStripIncomeDataGridView.Name = "contextMenuStripIncomeDataGridView";
        contextMenuStripIncomeDataGridView.Size = new Size(135, 28);
        // 
        // удалитьToolStripMenuItem
        // 
        удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
        удалитьToolStripMenuItem.Size = new Size(134, 24);
        удалитьToolStripMenuItem.Text = "Удалить";
        // 
        // buttonIncomeAddIncome
        // 
        buttonIncomeAddIncome.Location = new Point(8, 173);
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
        dateTimePickerIncomeInputDate.Location = new Point(8, 131);
        dateTimePickerIncomeInputDate.Name = "dateTimePickerIncomeInputDate";
        dateTimePickerIncomeInputDate.Size = new Size(250, 27);
        dateTimePickerIncomeInputDate.TabIndex = 0;
        // 
        // tabPageOutcomes
        // 
        tabPageOutcomes.Controls.Add(dateTimePickerOutcomeChooseDate);
        tabPageOutcomes.Controls.Add(label7);
        tabPageOutcomes.Controls.Add(dataGridView1);
        tabPageOutcomes.Controls.Add(buttonOutcomeAddOutcome);
        tabPageOutcomes.Controls.Add(label8);
        tabPageOutcomes.Controls.Add(label9);
        tabPageOutcomes.Controls.Add(label10);
        tabPageOutcomes.Controls.Add(label11);
        tabPageOutcomes.Controls.Add(label12);
        tabPageOutcomes.Controls.Add(numericUpDownOutcomeInputMoney);
        tabPageOutcomes.Controls.Add(textBoxOutcomeInputDescription);
        tabPageOutcomes.Controls.Add(comboBoxOutcomeInputCategory);
        tabPageOutcomes.Controls.Add(dateTimePickerOutcomeInputDate);
        tabPageOutcomes.Location = new Point(4, 29);
        tabPageOutcomes.Name = "tabPageOutcomes";
        tabPageOutcomes.Padding = new Padding(3);
        tabPageOutcomes.Size = new Size(926, 567);
        tabPageOutcomes.TabIndex = 1;
        tabPageOutcomes.Text = "Расходы";
        tabPageOutcomes.UseVisualStyleBackColor = true;
        // 
        // dateTimePickerOutcomeChooseDate
        // 
        dateTimePickerOutcomeChooseDate.Location = new Point(533, 228);
        dateTimePickerOutcomeChooseDate.Margin = new Padding(3, 4, 3, 4);
        dateTimePickerOutcomeChooseDate.Name = "dateTimePickerOutcomeChooseDate";
        dateTimePickerOutcomeChooseDate.Size = new Size(265, 27);
        dateTimePickerOutcomeChooseDate.TabIndex = 25;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(256, 220);
        label7.Name = "label7";
        label7.Size = new Size(230, 38);
        label7.TabIndex = 24;
        label7.Text = "Расходы на дату:";
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.ContextMenuStrip = contextMenuStripIncomeDataGridView;
        dataGridView1.Location = new Point(7, 282);
        dataGridView1.Margin = new Padding(3, 4, 3, 4);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(909, 273);
        dataGridView1.TabIndex = 23;
        // 
        // buttonOutcomeAddOutcome
        // 
        buttonOutcomeAddOutcome.Location = new Point(6, 176);
        buttonOutcomeAddOutcome.Name = "buttonOutcomeAddOutcome";
        buttonOutcomeAddOutcome.Size = new Size(901, 29);
        buttonOutcomeAddOutcome.TabIndex = 22;
        buttonOutcomeAddOutcome.Text = "Добавить доход";
        buttonOutcomeAddOutcome.UseVisualStyleBackColor = true;
        buttonOutcomeAddOutcome.Click += buttonOutcomeAddOutcome_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label8.Location = new Point(794, 76);
        label8.Name = "label8";
        label8.Size = new Size(72, 28);
        label8.TabIndex = 21;
        label8.Text = "Сумма";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label9.Location = new Point(585, 76);
        label9.Name = "label9";
        label9.Size = new Size(104, 28);
        label9.TabIndex = 20;
        label9.Text = "Описание";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label10.Location = new Point(378, 76);
        label10.Name = "label10";
        label10.Size = new Size(106, 28);
        label10.TabIndex = 19;
        label10.Text = "Категория";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label11.Location = new Point(105, 76);
        label11.Name = "label11";
        label11.Size = new Size(54, 28);
        label11.TabIndex = 18;
        label11.Text = "Дата";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        label12.Location = new Point(327, 6);
        label12.Name = "label12";
        label12.Size = new Size(283, 38);
        label12.TabIndex = 17;
        label12.Text = "Добавление расхода";
        // 
        // numericUpDownOutcomeInputMoney
        // 
        numericUpDownOutcomeInputMoney.Location = new Point(757, 132);
        numericUpDownOutcomeInputMoney.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        numericUpDownOutcomeInputMoney.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownOutcomeInputMoney.Name = "numericUpDownOutcomeInputMoney";
        numericUpDownOutcomeInputMoney.Size = new Size(150, 27);
        numericUpDownOutcomeInputMoney.TabIndex = 16;
        numericUpDownOutcomeInputMoney.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // textBoxOutcomeInputDescription
        // 
        textBoxOutcomeInputDescription.Location = new Point(562, 135);
        textBoxOutcomeInputDescription.Name = "textBoxOutcomeInputDescription";
        textBoxOutcomeInputDescription.Size = new Size(150, 27);
        textBoxOutcomeInputDescription.TabIndex = 15;
        // 
        // comboBoxOutcomeInputCategory
        // 
        comboBoxOutcomeInputCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxOutcomeInputCategory.FormattingEnabled = true;
        comboBoxOutcomeInputCategory.Location = new Point(351, 132);
        comboBoxOutcomeInputCategory.Name = "comboBoxOutcomeInputCategory";
        comboBoxOutcomeInputCategory.Size = new Size(151, 28);
        comboBoxOutcomeInputCategory.TabIndex = 14;
        // 
        // dateTimePickerOutcomeInputDate
        // 
        dateTimePickerOutcomeInputDate.Location = new Point(6, 134);
        dateTimePickerOutcomeInputDate.Name = "dateTimePickerOutcomeInputDate";
        dateTimePickerOutcomeInputDate.Size = new Size(250, 27);
        dateTimePickerOutcomeInputDate.TabIndex = 13;
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
        ((System.ComponentModel.ISupportInitialize)dataGridViewIncomeChooseIncomes).EndInit();
        contextMenuStripIncomeDataGridView.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDownIncomeInputMoney).EndInit();
        tabPageOutcomes.ResumeLayout(false);
        tabPageOutcomes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownOutcomeInputMoney).EndInit();
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
    private Label label6;
    private DataGridView dataGridViewIncomeChooseIncomes;
    private DateTimePicker dateTimePickerIncomeChooseDate;
    private ContextMenuStrip contextMenuStripIncomeDataGridView;
    private ToolStripMenuItem удалитьToolStripMenuItem;
    private DateTimePicker dateTimePickerOutcomeChooseDate;
    private Label label7;
    private DataGridView dataGridView1;
    private Button buttonOutcomeAddOutcome;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private NumericUpDown numericUpDownOutcomeInputMoney;
    private TextBox textBoxOutcomeInputDescription;
    private ComboBox comboBoxOutcomeInputCategory;
    private DateTimePicker dateTimePickerOutcomeInputDate;
}