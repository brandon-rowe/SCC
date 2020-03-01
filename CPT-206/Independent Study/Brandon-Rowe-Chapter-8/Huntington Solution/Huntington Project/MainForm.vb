Public Class frmMain

    Dim usedTotal As Integer
    Dim newTotal As Integer
    Dim fullTotal As Integer
    Dim partTotal As Integer

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim id As String
        Dim sold As Integer

        Integer.TryParse(numbersSoldTxt.Text, sold)
        id = IDtxt.Text

        If id Like "[12][a-zA-Z][a-zA-Z][fFpP]" Then
            If sold > 0 Then
                If id.Substring(0, 1) = "1" Then
                    newTotal += sold
                Else
                    usedTotal += sold
                End If
                If id.Substring(3, 1) = "F" Then
                    fullTotal += sold
                Else
                    partTotal += sold
                End If
            Else
                MessageBox.Show("Cars Sold must be greater than 0")
            End If
        Else
            MessageBox.Show("Invalid ID")
        End If

        fullTimeLbl.Text = fullTotal.ToString()
        partTimeLbl.Text = partTotal.ToString()
        newCarLbl.Text = newTotal.ToString()
        usedCarLbl.Text = usedTotal.ToString()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Joshua Godfrey Chapter 8", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class
