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
        Me.gbBudget = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblTotalMonthlyIncome = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblMonthlyBills = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblYearlyBills = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblYearlyCarPayments = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotalIncome = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblYearlyHomeMortgage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCarExpense = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCreditCardExpense1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCreditCardExpense2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnViewTable = New System.Windows.Forms.Button()
        Me.txtHomeExpense = New System.Windows.Forms.TextBox()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalcBudget = New System.Windows.Forms.Button()
        Me.IncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINANCE_TRACKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbBudget.SuspendLayout()
        Me.gbIncome.SuspendLayout()
        Me.gbExpenses.SuspendLayout()
        Me.gbCredit.SuspendLayout()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINANCE_TRACKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBudget
        '
        Me.gbBudget.Controls.Add(Me.txtName)
        Me.gbBudget.Controls.Add(Me.Label21)
        Me.gbBudget.Controls.Add(Me.lblTotalMonthlyIncome)
        Me.gbBudget.Controls.Add(Me.Label17)
        Me.gbBudget.Controls.Add(Me.lblMonthlyBills)
        Me.gbBudget.Controls.Add(Me.Label22)
        Me.gbBudget.Controls.Add(Me.lblYearlyBills)
        Me.gbBudget.Controls.Add(Me.Label19)
        Me.gbBudget.Controls.Add(Me.lblYearlyCarPayments)
        Me.gbBudget.Controls.Add(Me.Label13)
        Me.gbBudget.Controls.Add(Me.lblTotalIncome)
        Me.gbBudget.Controls.Add(Me.lblTotalExpenses)
        Me.gbBudget.Controls.Add(Me.Label4)
        Me.gbBudget.Controls.Add(Me.lblYearlyHomeMortgage)
        Me.gbBudget.Controls.Add(Me.Label6)
        Me.gbBudget.Controls.Add(Me.Label15)
        Me.gbBudget.Location = New System.Drawing.Point(834, 19)
        Me.gbBudget.Name = "gbBudget"
        Me.gbBudget.Size = New System.Drawing.Size(441, 458)
        Me.gbBudget.TabIndex = 21
        Me.gbBudget.TabStop = False
        Me.gbBudget.Text = "Finance Totals"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(249, 367)
        Me.txtName.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(170, 21)
        Me.txtName.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(31, 375)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 15)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Enter Your Name:"
        '
        'lblTotalMonthlyIncome
        '
        Me.lblTotalMonthlyIncome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalMonthlyIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalMonthlyIncome.Location = New System.Drawing.Point(249, 35)
        Me.lblTotalMonthlyIncome.Name = "lblTotalMonthlyIncome"
        Me.lblTotalMonthlyIncome.Size = New System.Drawing.Size(170, 33)
        Me.lblTotalMonthlyIncome.TabIndex = 19
        Me.lblTotalMonthlyIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 15)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Monthly Income: "
        '
        'lblMonthlyBills
        '
        Me.lblMonthlyBills.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonthlyBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyBills.Location = New System.Drawing.Point(249, 128)
        Me.lblMonthlyBills.Name = "lblMonthlyBills"
        Me.lblMonthlyBills.Size = New System.Drawing.Size(170, 33)
        Me.lblMonthlyBills.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(31, 142)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 15)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Monthly Bills: "
        '
        'lblYearlyBills
        '
        Me.lblYearlyBills.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearlyBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearlyBills.Location = New System.Drawing.Point(249, 220)
        Me.lblYearlyBills.Name = "lblYearlyBills"
        Me.lblYearlyBills.Size = New System.Drawing.Size(170, 33)
        Me.lblYearlyBills.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(31, 232)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 15)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Yearly Expenses:"
        '
        'lblYearlyCarPayments
        '
        Me.lblYearlyCarPayments.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearlyCarPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearlyCarPayments.Location = New System.Drawing.Point(249, 314)
        Me.lblYearlyCarPayments.Name = "lblYearlyCarPayments"
        Me.lblYearlyCarPayments.Size = New System.Drawing.Size(170, 33)
        Me.lblYearlyCarPayments.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Yearly Car Payments:"
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalIncome.Location = New System.Drawing.Point(249, 82)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(170, 33)
        Me.lblTotalIncome.TabIndex = 9
        Me.lblTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalExpenses.Location = New System.Drawing.Point(249, 173)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(170, 33)
        Me.lblTotalExpenses.TabIndex = 11
        Me.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Yearly Income: "
        '
        'lblYearlyHomeMortgage
        '
        Me.lblYearlyHomeMortgage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearlyHomeMortgage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearlyHomeMortgage.Location = New System.Drawing.Point(249, 266)
        Me.lblYearlyHomeMortgage.Name = "lblYearlyHomeMortgage"
        Me.lblYearlyHomeMortgage.Size = New System.Drawing.Size(170, 33)
        Me.lblYearlyHomeMortgage.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Expenses: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Yearly Home Mortgage:"
        '
        'txtCarExpense
        '
        Me.txtCarExpense.Location = New System.Drawing.Point(201, 56)
        Me.txtCarExpense.Name = "txtCarExpense"
        Me.txtCarExpense.Size = New System.Drawing.Size(186, 24)
        Me.txtCarExpense.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Car Payment:"
        '
        'txtCreditCardExpense1
        '
        Me.txtCreditCardExpense1.Location = New System.Drawing.Point(201, 91)
        Me.txtCreditCardExpense1.Name = "txtCreditCardExpense1"
        Me.txtCreditCardExpense1.Size = New System.Drawing.Size(186, 24)
        Me.txtCreditCardExpense1.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Credit Cards"
        '
        'txtCreditCardExpense2
        '
        Me.txtCreditCardExpense2.Location = New System.Drawing.Point(201, 127)
        Me.txtCreditCardExpense2.Name = "txtCreditCardExpense2"
        Me.txtCreditCardExpense2.Size = New System.Drawing.Size(186, 24)
        Me.txtCreditCardExpense2.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 17)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Credit Cards"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(986, 578)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(57, 17)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Label21"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(10, 578)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(57, 17)
        Me.lblTime.TabIndex = 24
        Me.lblTime.Text = "Label21"
        '
        'Timer1
        '
        '
        'btnViewTable
        '
        Me.btnViewTable.Location = New System.Drawing.Point(1150, 503)
        Me.btnViewTable.Name = "btnViewTable"
        Me.btnViewTable.Size = New System.Drawing.Size(127, 59)
        Me.btnViewTable.TabIndex = 5
        Me.btnViewTable.Text = "&Tracker Table"
        Me.btnViewTable.UseVisualStyleBackColor = True
        '
        'txtHomeExpense
        '
        Me.txtHomeExpense.Location = New System.Drawing.Point(201, 22)
        Me.txtHomeExpense.Name = "txtHomeExpense"
        Me.txtHomeExpense.Size = New System.Drawing.Size(186, 24)
        Me.txtHomeExpense.TabIndex = 0
        '
        'gbIncome
        '
        Me.gbIncome.Controls.Add(Me.TextBox1)
        Me.gbIncome.Controls.Add(Me.Label16)
        Me.gbIncome.Controls.Add(Me.txtIncome3)
        Me.gbIncome.Controls.Add(Me.Label3)
        Me.gbIncome.Controls.Add(Me.txtIncome2)
        Me.gbIncome.Controls.Add(Me.Label2)
        Me.gbIncome.Controls.Add(Me.txtIncome1)
        Me.gbIncome.Controls.Add(Me.Label1)
        Me.gbIncome.Location = New System.Drawing.Point(16, 16)
        Me.gbIncome.Name = "gbIncome"
        Me.gbIncome.Size = New System.Drawing.Size(367, 176)
        Me.gbIncome.TabIndex = 0
        Me.gbIncome.TabStop = False
        Me.gbIncome.Text = "Monthly Income"
        Me.ToolTip1.SetToolTip(Me.gbIncome, "Enter your monthly post tax (bring home) pay from all sources.")
        '
        'txtIncome3
        '
        Me.txtIncome3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome3.Location = New System.Drawing.Point(135, 96)
        Me.txtIncome3.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtIncome3.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtIncome3.Name = "txtIncome3"
        Me.txtIncome3.Size = New System.Drawing.Size(186, 26)
        Me.txtIncome3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Income 3:"
        '
        'txtIncome2
        '
        Me.txtIncome2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome2.Location = New System.Drawing.Point(135, 64)
        Me.txtIncome2.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtIncome2.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtIncome2.Name = "txtIncome2"
        Me.txtIncome2.Size = New System.Drawing.Size(186, 26)
        Me.txtIncome2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Income 2:"
        '
        'txtIncome1
        '
        Me.txtIncome1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome1.Location = New System.Drawing.Point(135, 34)
        Me.txtIncome1.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtIncome1.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtIncome1.Name = "txtIncome1"
        Me.txtIncome1.Size = New System.Drawing.Size(186, 26)
        Me.txtIncome1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
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
        Me.gbExpenses.Location = New System.Drawing.Point(16, 198)
        Me.gbExpenses.Name = "gbExpenses"
        Me.gbExpenses.Size = New System.Drawing.Size(589, 142)
        Me.gbExpenses.TabIndex = 2
        Me.gbExpenses.TabStop = False
        Me.gbExpenses.Text = "Monthly Expenses"
        Me.ToolTip1.SetToolTip(Me.gbExpenses, "Enter monthly expenses.")
        '
        'txtSecurityExpense
        '
        Me.txtSecurityExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityExpense.Location = New System.Drawing.Point(378, 90)
        Me.txtSecurityExpense.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtSecurityExpense.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtSecurityExpense.Name = "txtSecurityExpense"
        Me.txtSecurityExpense.Size = New System.Drawing.Size(186, 26)
        Me.txtSecurityExpense.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(305, 99)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 17)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Security:"
        '
        'txtInternetExpense
        '
        Me.txtInternetExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInternetExpense.Location = New System.Drawing.Point(378, 57)
        Me.txtInternetExpense.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtInternetExpense.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtInternetExpense.Name = "txtInternetExpense"
        Me.txtInternetExpense.Size = New System.Drawing.Size(186, 26)
        Me.txtInternetExpense.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(284, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 17)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Internet/TV:"
        '
        'txtPhoneExpense
        '
        Me.txtPhoneExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneExpense.Location = New System.Drawing.Point(378, 23)
        Me.txtPhoneExpense.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtPhoneExpense.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtPhoneExpense.Name = "txtPhoneExpense"
        Me.txtPhoneExpense.Size = New System.Drawing.Size(186, 26)
        Me.txtPhoneExpense.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(317, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Phone:"
        '
        'txtGasExpense
        '
        Me.txtGasExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGasExpense.Location = New System.Drawing.Point(79, 24)
        Me.txtGasExpense.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtGasExpense.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtGasExpense.Name = "txtGasExpense"
        Me.txtGasExpense.Size = New System.Drawing.Size(186, 26)
        Me.txtGasExpense.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Gas:"
        '
        'txtWaterExpense
        '
        Me.txtWaterExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterExpense.Location = New System.Drawing.Point(79, 91)
        Me.txtWaterExpense.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtWaterExpense.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtWaterExpense.Name = "txtWaterExpense"
        Me.txtWaterExpense.Size = New System.Drawing.Size(186, 26)
        Me.txtWaterExpense.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Water:"
        '
        'txtPowerExpense
        '
        Me.txtPowerExpense.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerExpense.Location = New System.Drawing.Point(79, 57)
        Me.txtPowerExpense.MaximumSize = New System.Drawing.Size(186, 26)
        Me.txtPowerExpense.MinimumSize = New System.Drawing.Size(186, 26)
        Me.txtPowerExpense.Name = "txtPowerExpense"
        Me.txtPowerExpense.Size = New System.Drawing.Size(186, 26)
        Me.txtPowerExpense.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Power:"
        '
        'gbCredit
        '
        Me.gbCredit.Controls.Add(Me.txtCarExpense)
        Me.gbCredit.Controls.Add(Me.Label11)
        Me.gbCredit.Controls.Add(Me.txtCreditCardExpense1)
        Me.gbCredit.Controls.Add(Me.Label10)
        Me.gbCredit.Controls.Add(Me.txtCreditCardExpense2)
        Me.gbCredit.Controls.Add(Me.Label14)
        Me.gbCredit.Controls.Add(Me.txtHomeExpense)
        Me.gbCredit.Controls.Add(Me.Label8)
        Me.gbCredit.Location = New System.Drawing.Point(394, 18)
        Me.gbCredit.Name = "gbCredit"
        Me.gbCredit.Size = New System.Drawing.Size(409, 174)
        Me.gbCredit.TabIndex = 1
        Me.gbCredit.TabStop = False
        Me.gbCredit.Text = "Monthly Debt"
        Me.ToolTip1.SetToolTip(Me.gbCredit, "Enter monthly expenses.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Home:"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(991, 503)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 59)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalcBudget
        '
        Me.btnCalcBudget.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalcBudget.Location = New System.Drawing.Point(834, 503)
        Me.btnCalcBudget.Name = "btnCalcBudget"
        Me.btnCalcBudget.Size = New System.Drawing.Size(127, 59)
        Me.btnCalcBudget.TabIndex = 3
        Me.btnCalcBudget.Text = "&Calculate Finances"
        Me.btnCalcBudget.UseVisualStyleBackColor = True
        '
        'FINANCE_TRACKERBindingSource
        '
        Me.FINANCE_TRACKERBindingSource.DataMember = "FINANCE_TRACKER"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(135, 127)
        Me.TextBox1.MaximumSize = New System.Drawing.Size(186, 26)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(186, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 26)
        Me.TextBox1.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 132)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Income 4:"
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnCalcBudget
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1291, 610)
        Me.Controls.Add(Me.gbBudget)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnViewTable)
        Me.Controls.Add(Me.gbIncome)
        Me.Controls.Add(Me.gbExpenses)
        Me.Controls.Add(Me.gbCredit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcBudget)
        Me.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(1307, 649)
        Me.MinimumSize = New System.Drawing.Size(1307, 649)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Tracker"
        Me.gbBudget.ResumeLayout(False)
        Me.gbBudget.PerformLayout()
        Me.gbIncome.ResumeLayout(False)
        Me.gbIncome.PerformLayout()
        Me.gbExpenses.ResumeLayout(False)
        Me.gbExpenses.PerformLayout()
        Me.gbCredit.ResumeLayout(False)
        Me.gbCredit.PerformLayout()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINANCE_TRACKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbBudget As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblTotalMonthlyIncome As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyBills As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblYearlyBills As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblYearlyCarPayments As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblTotalIncome As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblYearlyHomeMortgage As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCarExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCreditCardExpense1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCreditCardExpense2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents IncomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnViewTable As System.Windows.Forms.Button
    Friend WithEvents FINANCE_TRACKERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtHomeExpense As System.Windows.Forms.TextBox
    Friend WithEvents gbIncome As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncome3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIncome2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIncome1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gbExpenses As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecurityExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtInternetExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGasExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWaterExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPowerExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbCredit As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalcBudget As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
