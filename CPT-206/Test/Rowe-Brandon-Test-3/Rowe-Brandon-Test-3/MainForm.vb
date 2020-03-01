Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TripsDataSet.tblTrips' table. You can move, or remove it, as needed.
        Me.TblTripsTableAdapter.Fill(Me.TripsDataSet.tblTrips)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = DateAndTime.Now.ToLongTimeString
        lblDate.Text = DateAndTime.Now.ToLongDateString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Brandon Rowe Test 3", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub


    Private Sub TblTripsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblTripsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTripsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TripsDataSet)

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Me.TblTripsTableAdapter.Fill(Me.TripsDataSet.tblTrips)
        rbPleasure.Checked = False
        rbBusiness.Checked = False
        lblNumTrips.Text = " "

    End Sub

    Private Sub btnPopup_Click(sender As Object, e As EventArgs) Handles btnPopup.Click
        If rbBusiness.Checked = True Then
            MessageBox.Show("Number of business trips: " + Me.TblTripsTableAdapter.ScalarQueryBUSINESS.ToString)
        ElseIf rbPleasure.Checked = True Then
            MessageBox.Show("Number of pleasure trips: " + Me.TblTripsTableAdapter.ScalarQueryPLEASURE.ToString)
        Else
            MessageBox.Show("Number of pleasure trips: " + Me.TblTripsTableAdapter.ScalarQueryPLEASURE.ToString)
            MessageBox.Show("Number of business trips: " + Me.TblTripsTableAdapter.ScalarQueryBUSINESS.ToString)
        End If
    End Sub

    Private Sub btnPleasureRows_Click(sender As Object, e As EventArgs) Handles btnPleasureRows.Click
        Me.TblTripsTableAdapter.FillByPLEASURE(Me.TripsDataSet.tblTrips)
    End Sub

    Private Sub btnBusinessRows_Click(sender As Object, e As EventArgs) Handles btnBusinessRows.Click
        Me.TblTripsTableAdapter.FillByBUSINESS(Me.TripsDataSet.tblTrips)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim origin As String = cbOrigin.SelectedItem.ToString
        Dim destination As String = cbDestination.SelectedItem.ToString
        Dim total As Double

        If origin = "Chicago" And destination = "Nashville" Then
            total = 3
        ElseIf origin = "Chicago" And destination = "Atlanta" Then
            total = 1
        ElseIf origin = "Nashville" And destination = "Chicago" Then
            total = 1
        ElseIf origin = "Nashville" And destination = "Atlanta" Then
            total = 1
        ElseIf origin = "Atlanta" And destination = "Los Angeles" Then
            total = 2
        ElseIf origin = "Los Angeles" And destination = "Chicago" Then
            total = 2
        Else
            MessageBox.Show("You do not have any trips from the origin to destination selected.")
            total = 0
        End If

        lblNumTrips.Text = total.ToString()
    End Sub
End Class
