<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.gbIncome = New System.Windows.Forms.GroupBox()
        Me.txtIncome3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIncome2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIncome1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbExpenses = New System.Windows.Forms.GroupBox()
        Me.txtSecurityExpense = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtInternetExpense = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPhoneExpense = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGasExpense = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWaterExpense = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPowerExpense = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbCredit = New System.Windows.Forms.GroupBox()
        Me.txtCarExpense = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCreditCardExpense = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCreditCard2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHomeExpense = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalcBudget = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbBudget = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblAverageYearlyBills = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblYearlyCarPayments = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblYearlyHomeMortgage = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalIncome = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BudgetDataSet = New Rowe_Brandon_Final_Project_CPT_206.BudgetDataSet()
        Me.IncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncomeTableAdapter = New Rowe_Brandon_Final_Project_CPT_206.BudgetDataSetTableAdapters.IncomeTableAdapter()
        Me.TableAdapterManager = New Rowe_Brandon_Final_Project_CPT_206.BudgetDataSetTableAdapters.TableAdapterManager()
        Me.IncomeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncomeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IncomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbIncome.SuspendLayout()
        Me.gbExpenses.SuspendLayout()
        Me.gbCredit.SuspendLayout()
        Me.gbBudget.SuspendLayout()
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IncomeBindingNavigator.SuspendLayout()
        CType(Me.IncomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbIncome
        '
        Me.gbIncome.Controls.Add(Me.txtIncome3)
        Me.gbIncome.Controls.Add(Me.Label3)
        Me.gbIncome.Controls.Add(Me.txtIncome2)
        Me.gbIncome.Controls.Add(Me.Label2)
        Me.gbIncome.Controls.Add(Me.txtIncome1)
        Me.gbIncome.Controls.Add(Me.Label1)
        Me.gbIncome.Location = New System.Drawing.Point(47, 54)
        Me.gbIncome.Name = "gbIncome"
        Me.gbIncome.Size = New System.Drawing.Size(295, 185)
        Me.gbIncome.TabIndex = 0
        Me.gbIncome.TabStop = False
        Me.gbIncome.Text = "Income"
        Me.ToolTip1.SetToolTip(Me.gbIncome, "Enter your monthly post tax (bring home) pay from all sources.")
        '
        'txtIncome3
        '
        Me.txtIncome3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome3.Location = New System.Drawing.Point(135, 131)
        Me.txtIncome3.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtIncome3.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtIncome3.Name = "txtIncome3"
        Me.txtIncome3.Size = New System.Drawing.Size(140, 21)
        Me.txtIncome3.TabIndex = 2
        Me.txtIncome3.Text = "Monthly Income"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Income 3:"
        '
        'txtIncome2
        '
        Me.txtIncome2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome2.Location = New System.Drawing.Point(135, 76)
        Me.txtIncome2.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtIncome2.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtIncome2.Name = "txtIncome2"
        Me.txtIncome2.Size = New System.Drawing.Size(140, 21)
        Me.txtIncome2.TabIndex = 1
        Me.txtIncome2.Text = "Monthly Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Income 2:"
        '
        'txtIncome1
        '
        Me.txtIncome1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome1.Location = New System.Drawing.Point(135, 27)
        Me.txtIncome1.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtIncome1.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtIncome1.Name = "txtIncome1"
        Me.txtIncome1.Size = New System.Drawing.Size(140, 21)
        Me.txtIncome1.TabIndex = 0
        Me.txtIncome1.Text = "Monthly Income"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Income 1:"
        '
        'gbExpenses
        '
        Me.gbExpenses.Controls.Add(Me.txtSecurityExpense)
        Me.gbExpenses.Controls.Add(Me.Label20)
        Me.gbExpenses.Controls.Add(Me.txtInternetExpense)
        Me.gbExpenses.Controls.Add(Me.Label18)
        Me.gbExpenses.Controls.Add(Me.txtPhoneExpense)
        Me.gbExpenses.Controls.Add(Me.Label12)
        Me.gbExpenses.Controls.Add(Me.txtGasExpense)
        Me.gbExpenses.Controls.Add(Me.Label9)
        Me.gbExpenses.Controls.Add(Me.txtWaterExpense)
        Me.gbExpenses.Controls.Add(Me.Label5)
        Me.gbExpenses.Controls.Add(Me.txtPowerExpense)
        Me.gbExpenses.Controls.Add(Me.Label7)
        Me.gbExpenses.Location = New System.Drawing.Point(389, 54)
        Me.gbExpenses.Name = "gbExpenses"
        Me.gbExpenses.Size = New System.Drawing.Size(540, 185)
        Me.gbExpenses.TabIndex = 4
        Me.gbExpenses.TabStop = False
        Me.gbExpenses.Text = "Expenses"
        Me.ToolTip1.SetToolTip(Me.gbExpenses, "Enter monthly expenses.")
        '
        'txtSecurityExpense
        '
        Me.txtSecurityExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityExpense.Location = New System.Drawing.Point(362, 129)
        Me.txtSecurityExpense.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtSecurityExpense.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtSecurityExpense.Name = "txtSecurityExpense"
        Me.txtSecurityExpense.Size = New System.Drawing.Size(140, 21)
        Me.txtSecurityExpense.TabIndex = 5
        Me.txtSecurityExpense.Text = "Monthly Security Bill"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(259, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Security:"
        '
        'txtInternetExpense
        '
        Me.txtInternetExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInternetExpense.Location = New System.Drawing.Point(362, 71)
        Me.txtInternetExpense.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtInternetExpense.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtInternetExpense.Name = "txtInternetExpense"
        Me.txtInternetExpense.Size = New System.Drawing.Size(140, 21)
        Me.txtInternetExpense.TabIndex = 4
        Me.txtInternetExpense.Text = "Monthly Internet/TV Bill"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(237, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 18)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Internet/TV:"
        '
        'txtPhoneExpense
        '
        Me.txtPhoneExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneExpense.Location = New System.Drawing.Point(362, 25)
        Me.txtPhoneExpense.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtPhoneExpense.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtPhoneExpense.Name = "txtPhoneExpense"
        Me.txtPhoneExpense.Size = New System.Drawing.Size(140, 21)
        Me.txtPhoneExpense.TabIndex = 3
        Me.txtPhoneExpense.Text = "Monthly Phone Bill"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(275, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Phone:"
        '
        'txtGasExpense
        '
        Me.txtGasExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGasExpense.Location = New System.Drawing.Point(91, 25)
        Me.txtGasExpense.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtGasExpense.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtGasExpense.Name = "txtGasExpense"
        Me.txtGasExpense.Size = New System.Drawing.Size(140, 21)
        Me.txtGasExpense.TabIndex = 0
        Me.txtGasExpense.Text = "Monthly Gas Bill"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Gas:"
        '
        'txtWaterExpense
        '
        Me.txtWaterExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterExpense.Location = New System.Drawing.Point(91, 129)
        Me.txtWaterExpense.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtWaterExpense.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtWaterExpense.Name = "txtWaterExpense"
        Me.txtWaterExpense.Size = New System.Drawing.Size(140, 21)
        Me.txtWaterExpense.TabIndex = 2
        Me.txtWaterExpense.Text = "Monthly Water Bill"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Water:"
        '
        'txtPowerExpense
        '
        Me.txtPowerExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerExpense.Location = New System.Drawing.Point(91, 74)
        Me.txtPowerExpense.MaximumSize = New System.Drawing.Size(140, 26)
        Me.txtPowerExpense.MinimumSize = New System.Drawing.Size(140, 26)
        Me.txtPowerExpense.Name = "txtPowerExpense"
        Me.txtPowerExpense.Size = New System.Drawing.Size(140, 21)
        Me.txtPowerExpense.TabIndex = 1
        Me.txtPowerExpense.Text = "Monthly Power Bill"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Power:"
        '
        'gbCredit
        '
        Me.gbCredit.Controls.Add(Me.txtCarExpense)
        Me.gbCredit.Controls.Add(Me.Label11)
        Me.gbCredit.Controls.Add(Me.txtCreditCardExpense)
        Me.gbCredit.Controls.Add(Me.Label10)
        Me.gbCredit.Controls.Add(Me.txtCreditCard2)
        Me.gbCredit.Controls.Add(Me.Label14)
        Me.gbCredit.Controls.Add(Me.txtHomeExpense)
        Me.gbCredit.Controls.Add(Me.Label8)
        Me.gbCredit.Location = New System.Drawing.Point(970, 54)
        Me.gbCredit.Name = "gbCredit"
        Me.gbCredit.Size = New System.Drawing.Size(331, 278)
        Me.gbCredit.TabIndex = 12
        Me.gbCredit.TabStop = False
        Me.gbCredit.Text = "Credit/Debt"
        Me.ToolTip1.SetToolTip(Me.gbCredit, "Enter monthly expenses.")
        '
        'txtCarExpense
        '
        Me.txtCarExpense.Location = New System.Drawing.Point(158, 92)
        Me.txtCarExpense.Name = "txtCarExpense"
        Me.txtCarExpense.Size = New System.Drawing.Size(140, 26)
        Me.txtCarExpense.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Car Payment:"
        '
        'txtCreditCardExpense
        '
        Me.txtCreditCardExpense.Location = New System.Drawing.Point(158, 151)
        Me.txtCreditCardExpense.Name = "txtCreditCardExpense"
        Me.txtCreditCardExpense.Size = New System.Drawing.Size(140, 26)
        Me.txtCreditCardExpense.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Credit Cards"
        '
        'txtCreditCard2
        '
        Me.txtCreditCard2.Location = New System.Drawing.Point(158, 202)
        Me.txtCreditCard2.Name = "txtCreditCard2"
        Me.txtCreditCard2.Size = New System.Drawing.Size(140, 26)
        Me.txtCreditCard2.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 18)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Credit Cards"
        '
        'txtHomeExpense
        '
        Me.txtHomeExpense.Location = New System.Drawing.Point(158, 35)
        Me.txtHomeExpense.Name = "txtHomeExpense"
        Me.txtHomeExpense.Size = New System.Drawing.Size(140, 26)
        Me.txtHomeExpense.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Home:"
        '
        'btnCalcBudget
        '
        Me.btnCalcBudget.Location = New System.Drawing.Point(34, 563)
        Me.btnCalcBudget.Name = "btnCalcBudget"
        Me.btnCalcBudget.Size = New System.Drawing.Size(95, 45)
        Me.btnCalcBudget.TabIndex = 0
        Me.btnCalcBudget.Text = "&Calculate Budget"
        Me.btnCalcBudget.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(182, 563)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 45)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbBudget
        '
        Me.gbBudget.Controls.Add(Me.Label16)
        Me.gbBudget.Controls.Add(Me.Label17)
        Me.gbBudget.Controls.Add(Me.lblAverageYearlyBills)
        Me.gbBudget.Controls.Add(Me.Label19)
        Me.gbBudget.Controls.Add(Me.lblYearlyCarPayments)
        Me.gbBudget.Controls.Add(Me.Label13)
        Me.gbBudget.Controls.Add(Me.lblYearlyHomeMortgage)
        Me.gbBudget.Controls.Add(Me.Label15)
        Me.gbBudget.Location = New System.Drawing.Point(389, 275)
        Me.gbBudget.Name = "gbBudget"
        Me.gbBudget.Size = New System.Drawing.Size(351, 246)
        Me.gbBudget.TabIndex = 3
        Me.gbBudget.TabStop = False
        Me.gbBudget.Text = "Budget Totals"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(228, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 25)
        Me.Label16.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 197)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Total Expenses: "
        '
        'lblAverageYearlyBills
        '
        Me.lblAverageYearlyBills.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAverageYearlyBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageYearlyBills.Location = New System.Drawing.Point(228, 136)
        Me.lblAverageYearlyBills.Name = "lblAverageYearlyBills"
        Me.lblAverageYearlyBills.Size = New System.Drawing.Size(95, 25)
        Me.lblAverageYearlyBills.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(31, 146)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(174, 15)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Average Yearly Expenses:"
        '
        'lblYearlyCarPayments
        '
        Me.lblYearlyCarPayments.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearlyCarPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearlyCarPayments.Location = New System.Drawing.Point(228, 88)
        Me.lblYearlyCarPayments.Name = "lblYearlyCarPayments"
        Me.lblYearlyCarPayments.Size = New System.Drawing.Size(95, 25)
        Me.lblYearlyCarPayments.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Yearly Car Payments:"
        '
        'lblYearlyHomeMortgage
        '
        Me.lblYearlyHomeMortgage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearlyHomeMortgage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearlyHomeMortgage.Location = New System.Drawing.Point(228, 37)
        Me.lblYearlyHomeMortgage.Name = "lblYearlyHomeMortgage"
        Me.lblYearlyHomeMortgage.Size = New System.Drawing.Size(95, 25)
        Me.lblYearlyHomeMortgage.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Yearly Home Mortgage:"
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalExpenses.Location = New System.Drawing.Point(162, 332)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(95, 25)
        Me.lblTotalExpenses.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Expenses: "
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalIncome.Location = New System.Drawing.Point(162, 281)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(95, 25)
        Me.lblTotalIncome.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Income: "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 617)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(72, 18)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Label21"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(1150, 617)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 18)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "Label21"
        '
        'Timer1
        '
        '
        'BudgetDataSet
        '
        Me.BudgetDataSet.DataSetName = "BudgetDataSet"
        Me.BudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncomeBindingSource
        '
        Me.IncomeBindingSource.DataMember = "Income"
        Me.IncomeBindingSource.DataSource = Me.BudgetDataSet
        '
        'IncomeTableAdapter
        '
        Me.IncomeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IncomeTableAdapter = Me.IncomeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Rowe_Brandon_Final_Project_CPT_206.BudgetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IncomeBindingNavigator
        '
        Me.IncomeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IncomeBindingNavigator.BindingSource = Me.IncomeBindingSource
        Me.IncomeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IncomeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IncomeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IncomeBindingNavigatorSaveItem})
        Me.IncomeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IncomeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IncomeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IncomeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IncomeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IncomeBindingNavigator.Name = "IncomeBindingNavigator"
        Me.IncomeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IncomeBindingNavigator.Size = New System.Drawing.Size(1357, 25)
        Me.IncomeBindingNavigator.TabIndex = 15
        Me.IncomeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IncomeBindingNavigatorSaveItem
        '
        Me.IncomeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IncomeBindingNavigatorSaveItem.Image = CType(resources.GetObject("IncomeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IncomeBindingNavigatorSaveItem.Name = "IncomeBindingNavigatorSaveItem"
        Me.IncomeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IncomeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IncomeDataGridView
        '
        Me.IncomeDataGridView.AutoGenerateColumns = False
        Me.IncomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncomeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.IncomeDataGridView.DataSource = Me.IncomeBindingSource
        Me.IncomeDataGridView.Location = New System.Drawing.Point(778, 363)
        Me.IncomeDataGridView.Name = "IncomeDataGridView"
        Me.IncomeDataGridView.Size = New System.Drawing.Size(454, 220)
        Me.IncomeDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IncomeName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IncomeName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IncomeAmount"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IncomeAmount"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 683)
        Me.Controls.Add(Me.IncomeDataGridView)
        Me.Controls.Add(Me.IncomeBindingNavigator)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.gbCredit)
        Me.Controls.Add(Me.lblTotalExpenses)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotalIncome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbExpenses)
        Me.Controls.Add(Me.gbBudget)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcBudget)
        Me.Controls.Add(Me.gbIncome)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brandon-Rowe-Final-Project"
        Me.gbIncome.ResumeLayout(False)
        Me.gbIncome.PerformLayout()
        Me.gbExpenses.ResumeLayout(False)
        Me.gbExpenses.PerformLayout()
        Me.gbCredit.ResumeLayout(False)
        Me.gbCredit.PerformLayout()
        Me.gbBudget.ResumeLayout(False)
        Me.gbBudget.PerformLayout()
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IncomeBindingNavigator.ResumeLayout(False)
        Me.IncomeBindingNavigator.PerformLayout()
        CType(Me.IncomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbIncome As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncome3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIncome2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIncome1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCalcBudget As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gbBudget As System.Windows.Forms.GroupBox
    Friend WithEvents gbExpenses As System.Windows.Forms.GroupBox
    Friend WithEvents txtGasExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCreditCardExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCarExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWaterExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPowerExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHomeExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblAverageYearlyBills As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblYearlyCarPayments As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblYearlyHomeMortgage As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalIncome As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbCredit As System.Windows.Forms.GroupBox
    Friend WithEvents txtCreditCard2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSecurityExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtInternetExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BudgetDataSet As Rowe_Brandon_Final_Project_CPT_206.BudgetDataSet
    Friend WithEvents IncomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncomeTableAdapter As Rowe_Brandon_Final_Project_CPT_206.BudgetDataSetTableAdapters.IncomeTableAdapter
    Friend WithEvents TableAdapterManager As Rowe_Brandon_Final_Project_CPT_206.BudgetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IncomeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IncomeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IncomeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
