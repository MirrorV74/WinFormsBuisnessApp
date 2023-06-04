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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIncomes = new System.Windows.Forms.TabPage();
            this.dateTimePickerIncomeChooseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewIncomeChooseIncomes = new System.Windows.Forms.DataGridView();
            this.contextMenuStripIncomeDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIncomeAddIncome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIncomeInputMoney = new System.Windows.Forms.NumericUpDown();
            this.textBoxIncomeInputDescription = new System.Windows.Forms.TextBox();
            this.comboBoxIncomeInputCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIncomeInputDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageOutcomes = new System.Windows.Forms.TabPage();
            this.dateTimePickerOutcomeChooseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewOutcomeChooseOutcomes = new System.Windows.Forms.DataGridView();
            this.contextMenuStripOutcomeDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuOutcomeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOutcomeAddOutcome = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownOutcomeInputMoney = new System.Windows.Forms.NumericUpDown();
            this.textBoxOutcomeInputDescription = new System.Windows.Forms.TextBox();
            this.comboBoxOutcomeInputCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOutcomeInputDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageBalance = new System.Windows.Forms.TabPage();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageIncomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomeChooseIncomes)).BeginInit();
            this.contextMenuStripIncomeDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncomeInputMoney)).BeginInit();
            this.tabPageOutcomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcomeChooseOutcomes)).BeginInit();
            this.contextMenuStripOutcomeDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutcomeInputMoney)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIncomes);
            this.tabControl1.Controls.Add(this.tabPageOutcomes);
            this.tabControl1.Controls.Add(this.tabPageBalance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageIncomes
            // 
            this.tabPageIncomes.Controls.Add(this.dateTimePickerIncomeChooseDate);
            this.tabPageIncomes.Controls.Add(this.label6);
            this.tabPageIncomes.Controls.Add(this.dataGridViewIncomeChooseIncomes);
            this.tabPageIncomes.Controls.Add(this.buttonIncomeAddIncome);
            this.tabPageIncomes.Controls.Add(this.label5);
            this.tabPageIncomes.Controls.Add(this.label4);
            this.tabPageIncomes.Controls.Add(this.label3);
            this.tabPageIncomes.Controls.Add(this.label2);
            this.tabPageIncomes.Controls.Add(this.label1);
            this.tabPageIncomes.Controls.Add(this.numericUpDownIncomeInputMoney);
            this.tabPageIncomes.Controls.Add(this.textBoxIncomeInputDescription);
            this.tabPageIncomes.Controls.Add(this.comboBoxIncomeInputCategory);
            this.tabPageIncomes.Controls.Add(this.dateTimePickerIncomeInputDate);
            this.tabPageIncomes.Location = new System.Drawing.Point(4, 24);
            this.tabPageIncomes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageIncomes.Name = "tabPageIncomes";
            this.tabPageIncomes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageIncomes.Size = new System.Drawing.Size(809, 422);
            this.tabPageIncomes.TabIndex = 0;
            this.tabPageIncomes.Text = "Доходы";
            this.tabPageIncomes.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerIncomeChooseDate
            // 
            this.dateTimePickerIncomeChooseDate.Location = new System.Drawing.Point(468, 169);
            this.dateTimePickerIncomeChooseDate.Name = "dateTimePickerIncomeChooseDate";
            this.dateTimePickerIncomeChooseDate.Size = new System.Drawing.Size(232, 23);
            this.dateTimePickerIncomeChooseDate.TabIndex = 12;
            this.dateTimePickerIncomeChooseDate.ValueChanged += new System.EventHandler(this.dateTimePickerIncomeChooseDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(226, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Доходы на дату:";
            // 
            // dataGridViewIncomeChooseIncomes
            // 
            this.dataGridViewIncomeChooseIncomes.AllowUserToAddRows = false;
            this.dataGridViewIncomeChooseIncomes.AllowUserToDeleteRows = false;
            this.dataGridViewIncomeChooseIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncomeChooseIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomeChooseIncomes.ContextMenuStrip = this.contextMenuStripIncomeDataGridView;
            this.dataGridViewIncomeChooseIncomes.Location = new System.Drawing.Point(8, 209);
            this.dataGridViewIncomeChooseIncomes.MultiSelect = false;
            this.dataGridViewIncomeChooseIncomes.Name = "dataGridViewIncomeChooseIncomes";
            this.dataGridViewIncomeChooseIncomes.ReadOnly = true;
            this.dataGridViewIncomeChooseIncomes.RowHeadersWidth = 51;
            this.dataGridViewIncomeChooseIncomes.RowTemplate.Height = 25;
            this.dataGridViewIncomeChooseIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIncomeChooseIncomes.Size = new System.Drawing.Size(795, 205);
            this.dataGridViewIncomeChooseIncomes.TabIndex = 10;
            // 
            // contextMenuStripIncomeDataGridView
            // 
            this.contextMenuStripIncomeDataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripIncomeDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStripIncomeDataGridView.Name = "contextMenuStripIncomeDataGridView";
            this.contextMenuStripIncomeDataGridView.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // buttonIncomeAddIncome
            // 
            this.buttonIncomeAddIncome.Location = new System.Drawing.Point(7, 130);
            this.buttonIncomeAddIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIncomeAddIncome.Name = "buttonIncomeAddIncome";
            this.buttonIncomeAddIncome.Size = new System.Drawing.Size(788, 22);
            this.buttonIncomeAddIncome.TabIndex = 9;
            this.buttonIncomeAddIncome.Text = "Добавить доход";
            this.buttonIncomeAddIncome.UseVisualStyleBackColor = true;
            this.buttonIncomeAddIncome.Click += new System.EventHandler(this.buttonIncomeAddIncome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(697, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(514, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(333, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавление дохода";
            // 
            // numericUpDownIncomeInputMoney
            // 
            this.numericUpDownIncomeInputMoney.Location = new System.Drawing.Point(664, 97);
            this.numericUpDownIncomeInputMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownIncomeInputMoney.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownIncomeInputMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIncomeInputMoney.Name = "numericUpDownIncomeInputMoney";
            this.numericUpDownIncomeInputMoney.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownIncomeInputMoney.TabIndex = 3;
            this.numericUpDownIncomeInputMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxIncomeInputDescription
            // 
            this.textBoxIncomeInputDescription.Location = new System.Drawing.Point(494, 99);
            this.textBoxIncomeInputDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIncomeInputDescription.Name = "textBoxIncomeInputDescription";
            this.textBoxIncomeInputDescription.Size = new System.Drawing.Size(132, 23);
            this.textBoxIncomeInputDescription.TabIndex = 2;
            // 
            // comboBoxIncomeInputCategory
            // 
            this.comboBoxIncomeInputCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncomeInputCategory.FormattingEnabled = true;
            this.comboBoxIncomeInputCategory.Location = new System.Drawing.Point(309, 97);
            this.comboBoxIncomeInputCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIncomeInputCategory.Name = "comboBoxIncomeInputCategory";
            this.comboBoxIncomeInputCategory.Size = new System.Drawing.Size(133, 23);
            this.comboBoxIncomeInputCategory.TabIndex = 1;
            // 
            // dateTimePickerIncomeInputDate
            // 
            this.dateTimePickerIncomeInputDate.Location = new System.Drawing.Point(7, 98);
            this.dateTimePickerIncomeInputDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerIncomeInputDate.Name = "dateTimePickerIncomeInputDate";
            this.dateTimePickerIncomeInputDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerIncomeInputDate.TabIndex = 0;
            // 
            // tabPageOutcomes
            // 
            this.tabPageOutcomes.Controls.Add(this.dateTimePickerOutcomeChooseDate);
            this.tabPageOutcomes.Controls.Add(this.label7);
            this.tabPageOutcomes.Controls.Add(this.dataGridViewOutcomeChooseOutcomes);
            this.tabPageOutcomes.Controls.Add(this.buttonOutcomeAddOutcome);
            this.tabPageOutcomes.Controls.Add(this.label8);
            this.tabPageOutcomes.Controls.Add(this.label9);
            this.tabPageOutcomes.Controls.Add(this.label10);
            this.tabPageOutcomes.Controls.Add(this.label11);
            this.tabPageOutcomes.Controls.Add(this.label12);
            this.tabPageOutcomes.Controls.Add(this.numericUpDownOutcomeInputMoney);
            this.tabPageOutcomes.Controls.Add(this.textBoxOutcomeInputDescription);
            this.tabPageOutcomes.Controls.Add(this.comboBoxOutcomeInputCategory);
            this.tabPageOutcomes.Controls.Add(this.dateTimePickerOutcomeInputDate);
            this.tabPageOutcomes.Location = new System.Drawing.Point(4, 24);
            this.tabPageOutcomes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageOutcomes.Name = "tabPageOutcomes";
            this.tabPageOutcomes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageOutcomes.Size = new System.Drawing.Size(809, 422);
            this.tabPageOutcomes.TabIndex = 1;
            this.tabPageOutcomes.Text = "Расходы";
            this.tabPageOutcomes.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerOutcomeChooseDate
            // 
            this.dateTimePickerOutcomeChooseDate.Location = new System.Drawing.Point(466, 171);
            this.dateTimePickerOutcomeChooseDate.Name = "dateTimePickerOutcomeChooseDate";
            this.dateTimePickerOutcomeChooseDate.Size = new System.Drawing.Size(232, 23);
            this.dateTimePickerOutcomeChooseDate.TabIndex = 25;
            this.dateTimePickerOutcomeChooseDate.ValueChanged += new System.EventHandler(this.dateTimePickerOutcomeChooseDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(224, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Расходы на дату:";
            // 
            // dataGridViewOutcomeChooseOutcomes
            // 
            this.dataGridViewOutcomeChooseOutcomes.AllowUserToAddRows = false;
            this.dataGridViewOutcomeChooseOutcomes.AllowUserToDeleteRows = false;
            this.dataGridViewOutcomeChooseOutcomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutcomeChooseOutcomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutcomeChooseOutcomes.ContextMenuStrip = this.contextMenuStripOutcomeDataGridView;
            this.dataGridViewOutcomeChooseOutcomes.Location = new System.Drawing.Point(6, 212);
            this.dataGridViewOutcomeChooseOutcomes.MultiSelect = false;
            this.dataGridViewOutcomeChooseOutcomes.Name = "dataGridViewOutcomeChooseOutcomes";
            this.dataGridViewOutcomeChooseOutcomes.ReadOnly = true;
            this.dataGridViewOutcomeChooseOutcomes.RowHeadersWidth = 51;
            this.dataGridViewOutcomeChooseOutcomes.RowTemplate.Height = 25;
            this.dataGridViewOutcomeChooseOutcomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOutcomeChooseOutcomes.Size = new System.Drawing.Size(795, 205);
            this.dataGridViewOutcomeChooseOutcomes.TabIndex = 23;
            // 
            // contextMenuStripOutcomeDataGridView
            // 
            this.contextMenuStripOutcomeDataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripOutcomeDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuOutcomeItem});
            this.contextMenuStripOutcomeDataGridView.Name = "contextMenuStripIncomeDataGridView";
            this.contextMenuStripOutcomeDataGridView.Size = new System.Drawing.Size(181, 48);
            // 
            // удалитьToolStripMenuOutcomeItem
            // 
            this.удалитьToolStripMenuOutcomeItem.Name = "удалитьToolStripMenuOutcomeItem";
            this.удалитьToolStripMenuOutcomeItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuOutcomeItem.Text = "Удалить";
            this.удалитьToolStripMenuOutcomeItem.Click += new System.EventHandler(this.удалитьToolStripMenuOutcomeItem_Click);
            // 
            // buttonOutcomeAddOutcome
            // 
            this.buttonOutcomeAddOutcome.Location = new System.Drawing.Point(5, 132);
            this.buttonOutcomeAddOutcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOutcomeAddOutcome.Name = "buttonOutcomeAddOutcome";
            this.buttonOutcomeAddOutcome.Size = new System.Drawing.Size(788, 22);
            this.buttonOutcomeAddOutcome.TabIndex = 22;
            this.buttonOutcomeAddOutcome.Text = "Добавить расход";
            this.buttonOutcomeAddOutcome.UseVisualStyleBackColor = true;
            this.buttonOutcomeAddOutcome.Click += new System.EventHandler(this.buttonOutcomeAddOutcome_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(695, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Сумма";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(512, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Описание";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(331, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Категория";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(92, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Дата";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(286, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 30);
            this.label12.TabIndex = 17;
            this.label12.Text = "Добавление расхода";
            // 
            // numericUpDownOutcomeInputMoney
            // 
            this.numericUpDownOutcomeInputMoney.Location = new System.Drawing.Point(662, 99);
            this.numericUpDownOutcomeInputMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownOutcomeInputMoney.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownOutcomeInputMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOutcomeInputMoney.Name = "numericUpDownOutcomeInputMoney";
            this.numericUpDownOutcomeInputMoney.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownOutcomeInputMoney.TabIndex = 16;
            this.numericUpDownOutcomeInputMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxOutcomeInputDescription
            // 
            this.textBoxOutcomeInputDescription.Location = new System.Drawing.Point(492, 101);
            this.textBoxOutcomeInputDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutcomeInputDescription.Name = "textBoxOutcomeInputDescription";
            this.textBoxOutcomeInputDescription.Size = new System.Drawing.Size(132, 23);
            this.textBoxOutcomeInputDescription.TabIndex = 15;
            // 
            // comboBoxOutcomeInputCategory
            // 
            this.comboBoxOutcomeInputCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutcomeInputCategory.FormattingEnabled = true;
            this.comboBoxOutcomeInputCategory.Location = new System.Drawing.Point(307, 99);
            this.comboBoxOutcomeInputCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOutcomeInputCategory.Name = "comboBoxOutcomeInputCategory";
            this.comboBoxOutcomeInputCategory.Size = new System.Drawing.Size(133, 23);
            this.comboBoxOutcomeInputCategory.TabIndex = 14;
            // 
            // dateTimePickerOutcomeInputDate
            // 
            this.dateTimePickerOutcomeInputDate.Location = new System.Drawing.Point(5, 100);
            this.dateTimePickerOutcomeInputDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOutcomeInputDate.Name = "dateTimePickerOutcomeInputDate";
            this.dateTimePickerOutcomeInputDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerOutcomeInputDate.TabIndex = 13;
            // 
            // tabPageBalance
            // 
            this.tabPageBalance.Location = new System.Drawing.Point(4, 24);
            this.tabPageBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBalance.Name = "tabPageBalance";
            this.tabPageBalance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBalance.Size = new System.Drawing.Size(809, 422);
            this.tabPageBalance.TabIndex = 2;
            this.tabPageBalance.Text = "Баланс";
            this.tabPageBalance.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStripIncomeDataGridView";
            this.contextMenuStrip2.Size = new System.Drawing.Size(119, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageIncomes.ResumeLayout(false);
            this.tabPageIncomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomeChooseIncomes)).EndInit();
            this.contextMenuStripIncomeDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncomeInputMoney)).EndInit();
            this.tabPageOutcomes.ResumeLayout(false);
            this.tabPageOutcomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcomeChooseOutcomes)).EndInit();
            this.contextMenuStripOutcomeDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutcomeInputMoney)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

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
    private DataGridView dataGridViewOutcomeChooseOutcomes;
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
    private ContextMenuStrip contextMenuStripOutcomeDataGridView;
    private ToolStripMenuItem удалитьToolStripMenuOutcomeItem;
    private ContextMenuStrip contextMenuStrip2;
    private ToolStripMenuItem toolStripMenuItem2;
}