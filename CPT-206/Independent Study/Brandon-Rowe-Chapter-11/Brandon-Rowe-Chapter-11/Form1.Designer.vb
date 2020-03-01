<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFamily = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbRac = New System.Windows.Forms.CheckBox()
        Me.cbTennis = New System.Windows.Forms.CheckBox()
        Me.cbGolf = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBasicFee = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAdditionalFee = New System.Windows.Forms.Label()
        Me.lblMonthlyDues = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFamily)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'radFamily
        '
        Me.radFamily.AutoSize = True
        Me.radFamily.Location = New System.Drawing.Point(7, 61)
        Me.radFamily.Name = "radFamily"
        Me.radFamily.Size = New System.Drawing.Size(54, 17)
        Me.radFamily.TabIndex = 1
        Me.radFamily.TabStop = True
        Me.radFamily.Text = "&Family"
        Me.radFamily.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(7, 28)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(54, 17)
        Me.radSingle.TabIndex = 0
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "&Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbRac)
        Me.GroupBox2.Controls.Add(Me.cbTennis)
        Me.GroupBox2.Controls.Add(Me.cbGolf)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 92)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional"
        '
        'cbRac
        '
        Me.cbRac.AutoSize = True
        Me.cbRac.Location = New System.Drawing.Point(6, 65)
        Me.cbRac.Name = "cbRac"
        Me.cbRac.Size = New System.Drawing.Size(83, 17)
        Me.cbRac.TabIndex = 2
        Me.cbRac.Text = "Racquetball"
        Me.cbRac.UseVisualStyleBackColor = True
        '
        'cbTennis
        '
        Me.cbTennis.AutoSize = True
        Me.cbTennis.Location = New System.Drawing.Point(6, 42)
        Me.cbTennis.Name = "cbTennis"
        Me.cbTennis.Size = New System.Drawing.Size(58, 17)
        Me.cbTennis.TabIndex = 1
        Me.cbTennis.Text = "Tennis"
        Me.cbTennis.UseVisualStyleBackColor = True
        '
        'cbGolf
        '
        Me.cbGolf.AutoSize = True
        Me.cbGolf.Location = New System.Drawing.Point(6, 19)
        Me.cbGolf.Name = "cbGolf"
        Me.cbGolf.Size = New System.Drawing.Size(45, 17)
        Me.cbGolf.TabIndex = 0
        Me.cbGolf.Text = "Golf"
        Me.cbGolf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Basic fee:"
        '
        'lblBasicFee
        '
        Me.lblBasicFee.BackColor = System.Drawing.SystemColors.Control
        Me.lblBasicFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBasicFee.Location = New System.Drawing.Point(12, 139)
        Me.lblBasicFee.Name = "lblBasicFee"
        Me.lblBasicFee.Size = New System.Drawing.Size(100, 23)
        Me.lblBasicFee.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Additional:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Monthly dues:"
        '
        'lblAdditionalFee
        '
        Me.lblAdditionalFee.BackColor = System.Drawing.SystemColors.Control
        Me.lblAdditionalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditionalFee.Location = New System.Drawing.Point(130, 139)
        Me.lblAdditionalFee.Name = "lblAdditionalFee"
        Me.lblAdditionalFee.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditionalFee.TabIndex = 6
        '
        'lblMonthlyDues
        '
        Me.lblMonthlyDues.BackColor = System.Drawing.SystemColors.Control
        Me.lblMonthlyDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyDues.Location = New System.Drawing.Point(12, 190)
        Me.lblMonthlyDues.Name = "lblMonthlyDues"
        Me.lblMonthlyDues.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlyDues.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalc.Location = New System.Drawing.Point(130, 190)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(211, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Location = New System.Drawing.Point(12, 231)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(39, 13)
        Me.timeLbl.TabIndex = 10
        Me.timeLbl.Text = "Label2"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Location = New System.Drawing.Point(133, 231)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(39, 13)
        Me.dateLbl.TabIndex = 11
        Me.dateLbl.Text = "Label4"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(273, 253)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblMonthlyDues)
        Me.Controls.Add(Me.lblAdditionalFee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBasicFee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(289, 292)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(289, 292)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Glasgow Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radFamily As System.Windows.Forms.RadioButton
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents cbRac As System.Windows.Forms.CheckBox
    Friend WithEvents cbTennis As System.Windows.Forms.CheckBox
    Friend WithEvents cbGolf As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBasicFee As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalFee As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyDues As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label

End Class
