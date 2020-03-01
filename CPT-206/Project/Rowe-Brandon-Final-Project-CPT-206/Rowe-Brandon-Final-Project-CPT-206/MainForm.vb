Public Class MainForm

    Dim incomeOne As Double
    Dim incomeTwo As Double
    Dim incomeThree As Double
    Dim totalIncome As Double
    Dim homeExpense As Double
    Dim yearlyHome As Double
    Dim carExpense As Double
    Dim yearlyCar As Double
    Dim creditCards As Double
    Dim powerExpense As Double
    Dim waterExpense As Double
    Dim gasExpense As Double
    Dim phoneExpense As Double
    Dim internetTvExpense As Double
    Dim securityExpense As Double
    Dim avgBills As Double
    Dim expenseTotal As Double


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.Income' table. You can move, or remove it, as needed.
        Me.IncomeTableAdapter.Fill(Me.BudgetDataSet.Income)
        Timer1.Start()
        gbBudget.Visible = False
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Brandon Rowe Final Project", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = DateAndTime.Now.ToLongTimeString
        lblDate.Text = DateAndTime.Now.ToLongDateString

    End Sub

    Private Sub btnCalcBudget_Click(sender As Object, e As EventArgs) Handles btnCalcBudget.Click
        gbBudget.Visible = True

        incomeOne = txtIncome1.Text
        incomeTwo = txtIncome2.Text
        incomeThree = txtIncome3.Text

        totalIncome = incomeOne + incomeTwo + incomeThree

        lblTotalIncome.Text = totalIncome.ToString("C2")

        homeExpense = txtHomeExpense.Text
        yearlyHome = homeExpense * 12
        carExpense = txtCarExpense.Text
        yearlyCar = carExpense * 12
        creditCards = txtCreditCardExpense.Text
        powerExpense = txtPowerExpense.Text
        waterExpense = txtWaterExpense.Text
        gasExpense = txtGasExpense.Text
        phoneExpense = txtPhoneExpense.Text
        internetTvExpense = txtInternetExpense.Text
        securityExpense = txtSecurityExpense.Text
        avgBills = (powerExpense + waterExpense + gasExpense + phoneExpense + internetTvExpense + securityExpense) * 12
        expenseTotal = homeExpense + carExpense + creditCards + powerExpense + waterExpense + gasExpense


        If totalIncome < expenseTotal Then
            MessageBox.Show("You need to consider decreasing your expenses. Your monthly expenses are greater than your monthly income.")
        End If

        lblAverageYearlyBills.Text = avgBills.ToString("C2")
        lblTotalExpenses.Text = expenseTotal.ToString("C2")
        lblYearlyCarPayments.Text = yearlyCar.ToString("C2")
        lblYearlyHomeMortgage.Text = yearlyHome.ToString("C2")



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub IncomeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IncomeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IncomeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub
End Class
