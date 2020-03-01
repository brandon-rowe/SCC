Public Class TrackerTableView

    Public Sub TrackerTableView()
        InitializeComponent()
    End Sub

    Private Sub TrackerTableView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FINANCEDataSet.FINANCE_TRACKER' table. You can move, or remove it, as needed.
        Me.FINANCE_TRACKERTableAdapter.Fill(Me.FINANCEDataSet.FINANCE_TRACKER)

    End Sub

    Private Sub FINANCE_TRACKERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FINANCE_TRACKERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FINANCE_TRACKERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FINANCEDataSet)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnOrderAsc_Click(sender As Object, e As EventArgs) Handles btnOrderAsc.Click
        Me.FINANCE_TRACKERTableAdapter.FillByNAMEASC(Me.FINANCEDataSet.FINANCE_TRACKER)
    End Sub

    Private Sub btnDesc_Click(sender As Object, e As EventArgs) Handles btnDesc.Click
        Me.FINANCE_TRACKERTableAdapter.FillByDESC(Me.FINANCEDataSet.FINANCE_TRACKER)
    End Sub

End Class