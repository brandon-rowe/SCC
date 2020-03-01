Public Class MainForm

    Dim incomeOne As Double
    Dim incomeTwo As Double
    Dim incomeThree As Double
    Dim totalYearlyIncome As Double
    Dim totalMonthlyIncome As Double

    Dim homeExpense As Double
    Dim carExpense As Double
    Dim powerExpense As Double
    Dim waterExpense As Double
    Dim gasExpense As Double
    Dim phoneExpense As Double
    Dim internetTvExpense As Double
    Dim securityExpense As Double
    Dim creditCardOne As Double
    Dim creditCardTwo As Double
    Dim expenseTotal As Double

    Dim yearlyCarCost As Double
    Dim yearlyHomeCost As Double
    Dim yearlyBillsCost As Double
    Dim yearlyIncome As Double


    Dim monthlyBills As Double
    Dim minCreditCardPayment As Double
    Dim monthlyIncome As Double



    Private Sub btnCalcBudget_Click(sender As Object, e As EventArgs) Handles btnCalcBudget.Click

        Try

            gbBudget.Visible = True
            btnViewTable.Visible = True

            If txtIncome1.Text = "" Then
                MessageBox.Show("Please enter your monthly income in the first income textbox.", "Brandon Rowe Final Project")
            ElseIf txtIncome2.Text = "" Then
                incomeTwo = 0.0
            ElseIf txtIncome3.Text = "" Then
                incomeTwo = 0.0
            End If

            Double.TryParse(txtIncome1.Text, incomeOne)
            Double.TryParse(txtIncome2.Text, incomeTwo)
            Double.TryParse(txtIncome3.Text, incomeThree)

            totalMonthlyIncome = incomeOne + incomeTwo + incomeThree
            totalYearlyIncome = totalMonthlyIncome * 12

            lblTotalMonthlyIncome.Text = totalMonthlyIncome.ToString("C2")
            lblTotalIncome.Text = totalYearlyIncome.ToString("C2")

            If txtHomeExpense.Text = "" Then
                Dim dlgButton As DialogResult
                dlgButton = MessageBox.Show("Do you pay rent or a mortgage each month?", "Brandon Rowe Final Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlgButton = Windows.Forms.DialogResult.No Then
                    homeExpense = 0
                ElseIf dlgButton = Windows.Forms.DialogResult.Yes Then
                    MessageBox.Show("Please enter your monthly mortagage expenses.", "Brandon Rowe Final Project")
                End If

            ElseIf txtCarExpense.Text = "" Then
                carExpense = 0.0
            ElseIf txtCreditCardExpense1.Text = "" Then
                creditCardOne = 0.0
            ElseIf txtCreditCardExpense2.Text = "" Then
                creditCardTwo = 0.0
            ElseIf txtPowerExpense.Text = "" Then
                powerExpense = 0.0
            ElseIf txtWaterExpense.Text = "" Then
                waterExpense = 0.0
            ElseIf txtGasExpense.Text = "" Then
                gasExpense = 0.0
            ElseIf txtPhoneExpense.Text = "" Then
                phoneExpense = 0.0
            ElseIf txtInternetExpense.Text = "" Then
                internetTvExpense = 0.0
            ElseIf txtSecurityExpense.Text = "" Then
                securityExpense = 0.0
            End If

            Double.TryParse(txtHomeExpense.Text, homeExpense)
            Double.TryParse(txtCarExpense.Text, carExpense)
            Double.TryParse(txtCreditCardExpense1.Text, creditCardOne)
            Double.TryParse(txtCreditCardExpense2.Text, creditCardTwo)
            Double.TryParse(txtPowerExpense.Text, powerExpense)
            Double.TryParse(txtWaterExpense.Text, waterExpense)
            Double.TryParse(txtGasExpense.Text, gasExpense)
            Double.TryParse(txtPhoneExpense.Text, phoneExpense)
            Double.TryParse(txtInternetExpense.Text, internetTvExpense)
            Double.TryParse(txtSecurityExpense.Text, securityExpense)

            minCreditCardPayment = (creditCardOne + creditCardTwo) * 0.05
            monthlyBills = (powerExpense + waterExpense + gasExpense + phoneExpense + internetTvExpense + securityExpense + homeExpense + carExpense + minCreditCardPayment)

            yearlyHomeCost = homeExpense * 12
            yearlyCarCost = carExpense * 12
            yearlyBillsCost = monthlyBills * 12


            expenseTotal = homeExpense + carExpense + creditCardOne + creditCardTwo + powerExpense + waterExpense + gasExpense + phoneExpense + internetTvExpense + securityExpense


            lblMonthlyBills.Text = monthlyBills.ToString("c2")
            lblYearlyBills.Text = yearlyBillsCost.ToString("C2")
            lblTotalExpenses.Text = expenseTotal.ToString("C2")
            lblYearlyCarPayments.Text = yearlyCarCost.ToString("C2")
            lblYearlyHomeMortgage.Text = yearlyHomeCost.ToString("C2")

            If totalMonthlyIncome < monthlyBills Then
                MessageBox.Show("Consider decreasing your expenses. Your monthly bills are greater than your monthly income.", "Brandon Rowe Final Project")
            End If

        Catch
            MessageBox.Show("Please ensure that all of your input data is numerical values only.", "Brandon Rowe Final Project")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        gbBudget.Visible = False
        btnViewTable.Visible = False

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

    Private Sub btnViewTable_Click(sender As Object, e As EventArgs) Handles btnViewTable.Click
        If txtName.Text <> "" Then
            Dim tracker As New TrackerTableView()
            tracker.FINANCEDataSet.FINANCE_TRACKER.AddFINANCE_TRACKERRow(txtName.Text, lblYearlyHomeMortgage.Text, lblYearlyCarPayments.Text,
                                                                 lblYearlyBills.Text, lblMonthlyBills.Text, lblTotalExpenses.Text, lblTotalIncome.Text, lblTotalMonthlyIncome.Text)
            Try
                tracker.FINANCE_TRACKERTableAdapter.Update(tracker.FINANCEDataSet.FINANCE_TRACKER)
            Catch ex As Exception
                MessageBox.Show("Some or all of your data was not saved.")
            End Try
            TrackerTableView.ShowDialog()
        Else
            MessageBox.Show("Please ender your name.", "Brandon-Rowe-Final-Project")
        End If
    End Sub

End Class
