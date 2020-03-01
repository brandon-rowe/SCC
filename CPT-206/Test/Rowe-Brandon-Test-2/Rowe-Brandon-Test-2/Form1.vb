Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timeLbl.Text = DateAndTime.Now.ToLongTimeString
        dateLbl.Text = DateAndTime.Now.ToLongDateString

    End Sub

    Private Sub readFileBtn_Click(sender As Object, e As EventArgs) Handles readFileBtn.Click
        If IO.File.Exists("StudentFile.txt") Then
            Dim inFile As IO.StreamReader
            Dim count As Integer
            inFile = IO.File.OpenText("StudentFile.txt")
            Dim strStudentLst As String
            Do Until inFile.Peek = -1
                strStudentLst = inFile.ReadLine
                lstStudentFiles.Items.Add(strStudentLst.ToString)
                count = lstStudentFiles.Items.Count.ToString
            Loop
            numRecLbl.Text = count.ToString()
            inFile.Close()
        Else
            MessageBox.Show("Can't find the Student File", "Student Final Grade")
        End If
    End Sub

    Private Sub lstStudentFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentFiles.SelectedIndexChanged
        'If IO.File.Exists("StudentFile.txt") Then
        'Dim inFile As IO.StreamReader
        'inFile = IO.File.OpenText("StudentFile.txt")
        Dim strStudentLst As String
        strStudentLst = lstStudentFiles.SelectedItem.ToString()

        'Do Until inFile.Peek = -1
        'strStudentLst = inFile.ReadLine

       
        If strStudentLst.Substring(0, 3) <= 100 & strStudentLst.Substring(0, 2) >= 90 Then
            gradeLbl.Text = "A"
        ElseIf strStudentLst.Substring(0, 2) <= 89 & strStudentLst.Substring(0, 2) >= 80 Then
            gradeLbl.Text = "B"
        ElseIf strStudentLst.Substring(0, 2) <= 79 & strStudentLst.Substring(0, 2) >= 70 Then
            gradeLbl.Text = "C"
        ElseIf strStudentLst.Substring(0, 2) <= 69 & strStudentLst.Substring(0, 2) >= 60 Then
            gradeLbl.Text = "D"
        ElseIf strStudentLst.Substring(0, 2) < 60 & strStudentLst.Substring(0, 2) > 0 Then
            gradeLbl.Text = "F"
        ElseIf strStudentLst.Substring(0, 3) > 100 Then
            MessageBox.Show("Invalid Grade")
        End If


        'Loop

        'Else
        'MessageBox.Show("Unable to find file.")
        'End If
        ' Professor Matt
        ' I tried to use substrings to calculate the grade information but kept getting errors. 


    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Student Grades Program", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.No Then
            Me.Close()
        End If
    End Sub
End Class
