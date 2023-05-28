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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIncomes = new System.Windows.Forms.TabPage();
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
            this.tabPageBalance = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageIncomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncomeInputMoney)).BeginInit();
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
            this.tabPageOutcomes.Location = new System.Drawing.Point(4, 24);
            this.tabPageOutcomes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageOutcomes.Name = "tabPageOutcomes";
            this.tabPageOutcomes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageOutcomes.Size = new System.Drawing.Size(809, 422);
            this.tabPageOutcomes.TabIndex = 1;
            this.tabPageOutcomes.Text = "Расходы";
            this.tabPageOutcomes.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncomeInputMoney)).EndInit();
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
}