'This application calculates membership fees based on the choices selected for a country club.

Public Class frmMain

    Dim singleBool As Boolean = False
    Dim famBool As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timeLbl.Text = DateAndTime.Now.ToLongTimeString
        dateLbl.Text = DateAndTime.Now.ToLongDateString

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If radSingle.Checked = True Then
            singleBool = True
            famBool = False
        ElseIf radFamily.Checked = True Then
            famBool = True
            singleBool = False
        Else
            MessageBox.Show("Please select a membership choice.", "Glasgow Health Club")
        End If

        Dim fees As New fees
        Call fees.calculateTotal(singleBool, famBool, cbGolf.Checked, cbTennis.Checked, cbRac.Checked)

        lblBasicFee.Text = fees.MemberFee.ToString("c2")
        lblAdditionalFee.Text = fees.addFee.ToString("c2")
        lblMonthlyDues.Text = (fees.MemberFee + fees.addFee).ToString("c2")

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Brandon Rowe Chapter 11", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
