Public Class Form1

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click

        Dim assetCost As Double
        Dim salVal As Double
        Dim usefulLife As Double



        Double.TryParse(assetCostTxt.Text, assetCost)
        Double.TryParse(salvageValueTxt.Text, salVal)
        Integer.TryParse(usefulLifeListbox.SelectedItem, usefulLife)

        outputTxt.Text = ControlChars.Tab + "Year" + ControlChars.Tab + "Depreciation" + ControlChars.NewLine

        For intNum As Double = 1 To usefulLife
            outputTxt.Text += ControlChars.Tab + intNum.ToString() + ControlChars.Tab + (Financial.DDB(assetCost, salVal, usefulLife, intNum)).ToString("n2") + ControlChars.NewLine
        Next intNum
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
