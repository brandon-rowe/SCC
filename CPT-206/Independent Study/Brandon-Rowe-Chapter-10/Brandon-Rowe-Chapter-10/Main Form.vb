Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Votes.txt") Then
            saveBtn()
        End If

        Timer1.Start()

        lstCommercial.Items.Add("Budweiser")
        lstCommercial.Items.Add("FedEx")
        lstCommercial.Items.Add("E*TRADE")
        lstCommercial.Items.Add("Pepsi")

    End Sub

    Private Sub saveBtn()
        Dim btnSave As New Button()
        AddHandler btnSave.Click, AddressOf Me.saveVoteBtn_Click
    End Sub

    Private Sub saveVoteBtn_Click(sender As Object, e As EventArgs) Handles saveVoteBtn.Click
        Dim outFile As IO.StreamWriter
        outFile = IO.File.AppendText("Votes.txt")
        outFile.WriteLine(lstCommercial.SelectedItem)
        outFile.Close()
    End Sub

    Private Sub displayVoteBtn_Click(sender As Object, e As EventArgs) Handles displayVoteBtn.Click
        Dim budTotal As Integer
        Dim fedTotal As Integer
        Dim etrTotal As Integer
        Dim pepTotal As Integer

        If IO.File.Exists("Votes.txt") Then
            Dim inFile As IO.StreamReader
            inFile = IO.File.OpenText("Votes.txt")
            Dim strCommercialLst As String
            Do Until inFile.Peek = -1
                strCommercialLst = inFile.ReadLine

                Select Case strCommercialLst
                    Case "Budweiser"
                        budTotal += 1

                    Case "FedEx"
                        fedTotal += 1

                    Case "E*TRADE"
                        etrTotal += 1

                    Case "Pepsi"
                        pepTotal += 1

                End Select
            Loop

            budLbl.Text = budTotal.ToString
            fedLbl.Text = fedTotal.ToString
            etLbl.Text = etrTotal.ToString
            pepLbl.Text = pepTotal.ToString
            inFile.Close()
        Else
            MessageBox.Show("Unable to find file.")
        End If

    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Brandon Rowe Chapter 10", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timeLbl.Text = DateAndTime.Now.ToLongTimeString
        dateLbl.Text = DateAndTime.Now.ToLongDateString

    End Sub
End Class

'Private Sub voteBtn()
'Dim btnVote As New Button()
'AddHandler btnVote.Click, AddressOf Me.displayVoteBtn_Click
'End Sub



