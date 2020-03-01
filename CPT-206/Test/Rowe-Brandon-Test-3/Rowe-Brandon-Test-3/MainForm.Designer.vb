<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim OriginLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TblTripsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TripsDataSet = New Rowe_Brandon_Test_3.TripsDataSet()
        Me.lblNumTrips = New System.Windows.Forms.Label()
        Me.rbBusiness = New System.Windows.Forms.RadioButton()
        Me.rbPleasure = New System.Windows.Forms.RadioButton()
        Me.btnPopup = New System.Windows.Forms.Button()
        Me.btnPleasureRows = New System.Windows.Forms.Button()
        Me.btnBusinessRows = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.TblTripsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.TblTripsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblTripsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTripsTableAdapter = New Rowe_Brandon_Test_3.TripsDataSetTableAdapters.tblTripsTableAdapter()
        Me.TableAdapterManager = New Rowe_Brandon_Test_3.TripsDataSetTableAdapters.TableAdapterManager()
        Me.cbOrigin = New System.Windows.Forms.ComboBox()
        Me.cbDestination = New System.Windows.Forms.ComboBox()
        OriginLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        CType(Me.TblTripsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TripsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTripsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTripsBindingNavigator.SuspendLayout()
        CType(Me.TblTripsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OriginLabel
        '
        OriginLabel.AutoSize = True
        OriginLabel.Location = New System.Drawing.Point(602, 31)
        OriginLabel.Name = "OriginLabel"
        OriginLabel.Size = New System.Drawing.Size(44, 15)
        OriginLabel.TabIndex = 18
        OriginLabel.Text = "Origin:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(606, 73)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(74, 15)
        DestinationLabel.TabIndex = 19
        DestinationLabel.Text = "Destination:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(896, 67)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(87, 27)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(899, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 324)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 15)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(843, 324)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 15)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Label2"
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(606, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of trips from origin to desination:"
        '
        'TblTripsBindingSource
        '
        Me.TblTripsBindingSource.DataMember = "tblTrips"
        Me.TblTripsBindingSource.DataSource = Me.TripsDataSet
        '
        'TripsDataSet
        '
        Me.TripsDataSet.DataSetName = "TripsDataSet"
        Me.TripsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNumTrips
        '
        Me.lblNumTrips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumTrips.Location = New System.Drawing.Point(896, 121)
        Me.lblNumTrips.Name = "lblNumTrips"
        Me.lblNumTrips.Size = New System.Drawing.Size(90, 22)
        Me.lblNumTrips.TabIndex = 9
        Me.lblNumTrips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbBusiness
        '
        Me.rbBusiness.AutoSize = True
        Me.rbBusiness.Location = New System.Drawing.Point(609, 165)
        Me.rbBusiness.Name = "rbBusiness"
        Me.rbBusiness.Size = New System.Drawing.Size(72, 19)
        Me.rbBusiness.TabIndex = 10
        Me.rbBusiness.TabStop = True
        Me.rbBusiness.Text = "&Business"
        Me.rbBusiness.UseVisualStyleBackColor = True
        '
        'rbPleasure
        '
        Me.rbPleasure.AutoSize = True
        Me.rbPleasure.Location = New System.Drawing.Point(609, 203)
        Me.rbPleasure.Name = "rbPleasure"
        Me.rbPleasure.Size = New System.Drawing.Size(72, 19)
        Me.rbPleasure.TabIndex = 11
        Me.rbPleasure.TabStop = True
        Me.rbPleasure.Text = "&Pleasure"
        Me.rbPleasure.UseVisualStyleBackColor = True
        '
        'btnPopup
        '
        Me.btnPopup.Location = New System.Drawing.Point(743, 182)
        Me.btnPopup.Name = "btnPopup"
        Me.btnPopup.Size = New System.Drawing.Size(103, 40)
        Me.btnPopup.TabIndex = 12
        Me.btnPopup.Text = "Popup Display &How Many?"
        Me.btnPopup.UseVisualStyleBackColor = True
        '
        'btnPleasureRows
        '
        Me.btnPleasureRows.Location = New System.Drawing.Point(609, 257)
        Me.btnPleasureRows.Name = "btnPleasureRows"
        Me.btnPleasureRows.Size = New System.Drawing.Size(87, 27)
        Me.btnPleasureRows.TabIndex = 13
        Me.btnPleasureRows.Text = "Pleasure Rows"
        Me.btnPleasureRows.UseVisualStyleBackColor = True
        '
        'btnBusinessRows
        '
        Me.btnBusinessRows.Location = New System.Drawing.Point(752, 257)
        Me.btnBusinessRows.Name = "btnBusinessRows"
        Me.btnBusinessRows.Size = New System.Drawing.Size(87, 27)
        Me.btnBusinessRows.TabIndex = 14
        Me.btnBusinessRows.Text = "Business Rows"
        Me.btnBusinessRows.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(899, 257)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(87, 27)
        Me.btnRestore.TabIndex = 15
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'TblTripsBindingNavigator
        '
        Me.TblTripsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTripsBindingNavigator.BindingSource = Me.TblTripsBindingSource
        Me.TblTripsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTripsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTripsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTripsBindingNavigatorSaveItem})
        Me.TblTripsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTripsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTripsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTripsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTripsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTripsBindingNavigator.Name = "TblTripsBindingNavigator"
        Me.TblTripsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTripsBindingNavigator.Size = New System.Drawing.Size(1008, 25)
        Me.TblTripsBindingNavigator.TabIndex = 16
        Me.TblTripsBindingNavigator.Text = "BindingNavigator1"
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
        'TblTripsBindingNavigatorSaveItem
        '
        Me.TblTripsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTripsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTripsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTripsBindingNavigatorSaveItem.Name = "TblTripsBindingNavigatorSaveItem"
        Me.TblTripsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTripsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTripsDataGridView
        '
        Me.TblTripsDataGridView.AutoGenerateColumns = False
        Me.TblTripsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTripsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblTripsDataGridView.DataSource = Me.TblTripsBindingSource
        Me.TblTripsDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.TblTripsDataGridView.Name = "TblTripsDataGridView"
        Me.TblTripsDataGridView.Size = New System.Drawing.Size(533, 271)
        Me.TblTripsDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TripDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TripDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Origin"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Origin"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BusinessPleasure"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BusinessPleasure"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TblTripsTableAdapter
        '
        Me.TblTripsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblTripsTableAdapter = Me.TblTripsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Rowe_Brandon_Test_3.TripsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cbOrigin
        '
        Me.cbOrigin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTripsBindingSource, "Origin", True))
        Me.cbOrigin.FormattingEnabled = True
        Me.cbOrigin.Items.AddRange(New Object() {"Chicago", "Nashville", "Atlanta", "Los Angeles"})
        Me.cbOrigin.Location = New System.Drawing.Point(718, 28)
        Me.cbOrigin.Name = "cbOrigin"
        Me.cbOrigin.Size = New System.Drawing.Size(121, 23)
        Me.cbOrigin.TabIndex = 19
        '
        'cbDestination
        '
        Me.cbDestination.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTripsBindingSource, "Destination", True))
        Me.cbDestination.FormattingEnabled = True
        Me.cbDestination.Items.AddRange(New Object() {"Nashville", "Chicago", "Atlanta", "Los Angeles"})
        Me.cbDestination.Location = New System.Drawing.Point(718, 65)
        Me.cbDestination.Name = "cbDestination"
        Me.cbDestination.Size = New System.Drawing.Size(121, 23)
        Me.cbDestination.TabIndex = 20
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1008, 355)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.cbDestination)
        Me.Controls.Add(OriginLabel)
        Me.Controls.Add(Me.cbOrigin)
        Me.Controls.Add(Me.TblTripsDataGridView)
        Me.Controls.Add(Me.TblTripsBindingNavigator)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBusinessRows)
        Me.Controls.Add(Me.btnPleasureRows)
        Me.Controls.Add(Me.btnPopup)
        Me.Controls.Add(Me.rbPleasure)
        Me.Controls.Add(Me.rbBusiness)
        Me.Controls.Add(Me.lblNumTrips)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 394)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 394)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rowe-Brandon-Test-3"
        CType(Me.TblTripsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TripsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTripsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTripsBindingNavigator.ResumeLayout(False)
        Me.TblTripsBindingNavigator.PerformLayout()
        CType(Me.TblTripsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNumTrips As System.Windows.Forms.Label
    Friend WithEvents rbBusiness As System.Windows.Forms.RadioButton
    Friend WithEvents rbPleasure As System.Windows.Forms.RadioButton
    Friend WithEvents btnPopup As System.Windows.Forms.Button
    Friend WithEvents btnPleasureRows As System.Windows.Forms.Button
    Friend WithEvents btnBusinessRows As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents TripsDataSet As Rowe_Brandon_Test_3.TripsDataSet
    Friend WithEvents TblTripsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTripsTableAdapter As Rowe_Brandon_Test_3.TripsDataSetTableAdapters.tblTripsTableAdapter
    Friend WithEvents TableAdapterManager As Rowe_Brandon_Test_3.TripsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTripsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTripsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTripsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbOrigin As System.Windows.Forms.ComboBox
    Friend WithEvents cbDestination As System.Windows.Forms.ComboBox

End Class
