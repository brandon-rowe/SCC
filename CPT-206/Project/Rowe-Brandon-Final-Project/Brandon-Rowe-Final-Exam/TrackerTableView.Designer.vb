<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackerTableView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackerTableView))
        Me.FINANCE_TRACKERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.FINANCE_TRACKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINANCEDataSet = New Brandon_Rowe_Final_Exam.FINANCEDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FINANCE_TRACKERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FINANCE_TRACKERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnOrderAsc = New System.Windows.Forms.Button()
        Me.btnDesc = New System.Windows.Forms.Button()
        Me.FINANCE_TRACKERTableAdapter = New Brandon_Rowe_Final_Exam.FINANCEDataSetTableAdapters.FINANCE_TRACKERTableAdapter()
        Me.TableAdapterManager = New Brandon_Rowe_Final_Exam.FINANCEDataSetTableAdapters.TableAdapterManager()
        CType(Me.FINANCE_TRACKERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FINANCE_TRACKERBindingNavigator.SuspendLayout()
        CType(Me.FINANCE_TRACKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINANCEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINANCE_TRACKERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FINANCE_TRACKERBindingNavigator
        '
        Me.FINANCE_TRACKERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FINANCE_TRACKERBindingNavigator.BindingSource = Me.FINANCE_TRACKERBindingSource
        Me.FINANCE_TRACKERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FINANCE_TRACKERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FINANCE_TRACKERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FINANCE_TRACKERBindingNavigatorSaveItem})
        Me.FINANCE_TRACKERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FINANCE_TRACKERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FINANCE_TRACKERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FINANCE_TRACKERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FINANCE_TRACKERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FINANCE_TRACKERBindingNavigator.Name = "FINANCE_TRACKERBindingNavigator"
        Me.FINANCE_TRACKERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FINANCE_TRACKERBindingNavigator.Size = New System.Drawing.Size(855, 25)
        Me.FINANCE_TRACKERBindingNavigator.TabIndex = 0
        Me.FINANCE_TRACKERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'FINANCE_TRACKERBindingSource
        '
        Me.FINANCE_TRACKERBindingSource.DataMember = "FINANCE_TRACKER"
        Me.FINANCE_TRACKERBindingSource.DataSource = Me.FINANCEDataSet
        '
        'FINANCEDataSet
        '
        Me.FINANCEDataSet.DataSetName = "FINANCEDataSet"
        Me.FINANCEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FINANCE_TRACKERBindingNavigatorSaveItem
        '
        Me.FINANCE_TRACKERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FINANCE_TRACKERBindingNavigatorSaveItem.Image = CType(resources.GetObject("FINANCE_TRACKERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FINANCE_TRACKERBindingNavigatorSaveItem.Name = "FINANCE_TRACKERBindingNavigatorSaveItem"
        Me.FINANCE_TRACKERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FINANCE_TRACKERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FINANCE_TRACKERDataGridView
        '
        Me.FINANCE_TRACKERDataGridView.AutoGenerateColumns = False
        Me.FINANCE_TRACKERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FINANCE_TRACKERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.FINANCE_TRACKERDataGridView.DataSource = Me.FINANCE_TRACKERBindingSource
        Me.FINANCE_TRACKERDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.FINANCE_TRACKERDataGridView.Name = "FINANCE_TRACKERDataGridView"
        Me.FINANCE_TRACKERDataGridView.Size = New System.Drawing.Size(850, 220)
        Me.FINANCE_TRACKERDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "YearlyMortgage"
        Me.DataGridViewTextBoxColumn2.HeaderText = "YearlyMortgage"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "YearlyCar"
        Me.DataGridViewTextBoxColumn3.HeaderText = "YearlyCar"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "YearlyExpenses"
        Me.DataGridViewTextBoxColumn4.HeaderText = "YearlyExpenses"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MonthlyBills"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MonthlyBills"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalExpenses"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TotalExpenses"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "YearlyIncome"
        Me.DataGridViewTextBoxColumn7.HeaderText = "YearlyIncome"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MonthlyIncome"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MonthlyIncome"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(516, 253)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnOrderAsc
        '
        Me.btnOrderAsc.Location = New System.Drawing.Point(245, 254)
        Me.btnOrderAsc.Name = "btnOrderAsc"
        Me.btnOrderAsc.Size = New System.Drawing.Size(75, 23)
        Me.btnOrderAsc.TabIndex = 3
        Me.btnOrderAsc.Text = "Ascending"
        Me.btnOrderAsc.UseVisualStyleBackColor = True
        '
        'btnDesc
        '
        Me.btnDesc.Location = New System.Drawing.Point(383, 254)
        Me.btnDesc.Name = "btnDesc"
        Me.btnDesc.Size = New System.Drawing.Size(75, 23)
        Me.btnDesc.TabIndex = 4
        Me.btnDesc.Text = "Descending"
        Me.btnDesc.UseVisualStyleBackColor = True
        '
        'FINANCE_TRACKERTableAdapter
        '
        Me.FINANCE_TRACKERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FINANCE_TRACKERTableAdapter = Me.FINANCE_TRACKERTableAdapter
        Me.TableAdapterManager.UpdateOrder = Brandon_Rowe_Final_Exam.FINANCEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TrackerTableView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 278)
        Me.Controls.Add(Me.btnDesc)
        Me.Controls.Add(Me.btnOrderAsc)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.FINANCE_TRACKERDataGridView)
        Me.Controls.Add(Me.FINANCE_TRACKERBindingNavigator)
        Me.Name = "TrackerTableView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrackerTableView"
        CType(Me.FINANCE_TRACKERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FINANCE_TRACKERBindingNavigator.ResumeLayout(False)
        Me.FINANCE_TRACKERBindingNavigator.PerformLayout()
        CType(Me.FINANCE_TRACKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINANCEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINANCE_TRACKERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FINANCEDataSet As Brandon_Rowe_Final_Exam.FINANCEDataSet
    Friend WithEvents FINANCE_TRACKERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FINANCE_TRACKERTableAdapter As Brandon_Rowe_Final_Exam.FINANCEDataSetTableAdapters.FINANCE_TRACKERTableAdapter
    Friend WithEvents TableAdapterManager As Brandon_Rowe_Final_Exam.FINANCEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FINANCE_TRACKERBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FINANCE_TRACKERBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FINANCE_TRACKERDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnOrderAsc As System.Windows.Forms.Button
    Friend WithEvents btnDesc As System.Windows.Forms.Button
End Class
