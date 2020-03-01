Public Class Form1

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub


    Private Sub boxCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles boxCheckBox.CheckedChanged
        If boxCheckBox.Checked = True Then
            boxTxt.Visible = True
        End If

        If boxCheckBox.Checked = False Then
            boxTxt.Visible = False
            boxTxt.Text = String.Empty
            ticketsLbl.Text = String.Empty
            amountDueLbl.Text = String.Empty
        End If




    End Sub

    Private Sub pavilionCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles pavilionCheckBox.CheckedChanged
        If pavilionCheckBox.Checked = True Then
            pavilionTxt.Visible = True
        End If

        If pavilionCheckBox.Checked = False Then
            pavilionTxt.Visible = False
            pavilionTxt.Text = String.Empty
            ticketsLbl.Text = String.Empty
            amountDueLbl.Text = String.Empty
        End If
    End Sub

    Private Sub lawnCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles lawnCheckBox.CheckedChanged
        If lawnCheckBox.Checked = True Then
            lawnTxt.Visible = True
        End If

        If lawnCheckBox.Checked = False Then
            lawnTxt.Visible = False
            lawnTxt.Text = String.Empty
            ticketsLbl.Text = String.Empty
            amountDueLbl.Text = String.Empty
        End If

    End Sub

    Private Sub boxTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxTxt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub pavilionTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pavilionTxt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub lawnTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lawnTxt.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click

        Dim boxSeats As Double
        Dim pavSeats As Double
        Dim lawnSeats As Double
        Const boxPrice As Double = 75
        Const pavPrice As Double = 30
        Const lawnPrice As Double = 21
        Dim boxSeatTotal As Double
        Dim pavSeatTotal As Double
        Dim lawnSeatTotal As Double
        Dim numberOfTickets As Double
        Dim totalAmtDue As Double

        Double.TryParse(boxTxt.Text, boxSeats)
        Double.TryParse(pavilionTxt.Text, pavSeats)
        Double.TryParse(lawnTxt.Text, lawnSeats)

        numberOfTickets = boxSeats + pavSeats + lawnSeats

        boxSeatTotal = boxPrice * boxSeats
        pavSeatTotal = pavPrice * pavSeats
        lawnSeatTotal = lawnPrice * lawnSeats

        totalAmtDue = boxSeatTotal + pavSeatTotal + lawnSeatTotal

        ticketsLbl.Text = numberOfTickets.ToString()
        amountDueLbl.Text = totalAmtDue.ToString("c2")



    End Sub

End Class
