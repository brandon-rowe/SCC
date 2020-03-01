Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        monthLst.Visible = False
        domLst.Visible = False
        intLst.Visible = False
        domTotalLbl.Visible = False
        intTotalLbl.Visible = False
        totalSalesLbl.Visible = False

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Brandon Rowe Chapter 9", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLbl.Text = DateAndTime.Now.ToLongTimeString
        dateLbl.Text = DateAndTime.Now.ToLongDateString
    End Sub

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click


        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        monthLst.Visible = True
        domLst.Visible = True
        intLst.Visible = True
        domTotalLbl.Visible = True
        intTotalLbl.Visible = True
        totalSalesLbl.Visible = True

        'Create Array
        Dim dblSales(,) As Double = {{1, 100000, 150000},
                                    {2, 90000, 120000},
                                    {3, 75000, 210000},
                                    {4, 88000, 50000},
                                    {5, 125000, 220000},
                                    {6, 63000, 80000}}

        Dim domTotal As Double
        Dim intTotal As Double
        Dim totalSales As Double

        For C As Integer = 0 To 5

            'Write to listboxes
            monthLst.Items.Add(C + 1)
            domLst.Items.Add(dblSales(C, 1).ToString("C2"))
            intLst.Items.Add(dblSales(C, 2).ToString("C2"))

            'Make calculations for listboxes
            domTotal += dblSales(C, 1)
            intTotal += dblSales(C, 2)
            totalSales = domTotal + intTotal

            'Write totals to textboxes
            domTotalLbl.Text = domTotal.ToString("C2")
            intTotalLbl.Text = intTotal.ToString("C2")
            totalSalesLbl.Text = totalSales.ToString("C2")
        Next
    End Sub
End Class
