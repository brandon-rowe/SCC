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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalSalesLbl = New System.Windows.Forms.Label()
        Me.intTotalLbl = New System.Windows.Forms.Label()
        Me.domTotalLbl = New System.Windows.Forms.Label()
        Me.intLst = New System.Windows.Forms.ListBox()
        Me.domLst = New System.Windows.Forms.ListBox()
        Me.monthLst = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.displayBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.totalSalesLbl)
        Me.GroupBox1.Controls.Add(Me.intTotalLbl)
        Me.GroupBox1.Controls.Add(Me.domTotalLbl)
        Me.GroupBox1.Controls.Add(Me.intLst)
        Me.GroupBox1.Controls.Add(Me.domLst)
        Me.GroupBox1.Controls.Add(Me.monthLst)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Total Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total Sales ($)"
        '
        'totalSalesLbl
        '
        Me.totalSalesLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalSalesLbl.Location = New System.Drawing.Point(539, 121)
        Me.totalSalesLbl.Name = "totalSalesLbl"
        Me.totalSalesLbl.Size = New System.Drawing.Size(92, 23)
        Me.totalSalesLbl.TabIndex = 14
        Me.totalSalesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intTotalLbl
        '
        Me.intTotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.intTotalLbl.Location = New System.Drawing.Point(358, 198)
        Me.intTotalLbl.Name = "intTotalLbl"
        Me.intTotalLbl.Size = New System.Drawing.Size(125, 23)
        Me.intTotalLbl.TabIndex = 13
        Me.intTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'domTotalLbl
        '
        Me.domTotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.domTotalLbl.Location = New System.Drawing.Point(150, 198)
        Me.domTotalLbl.Name = "domTotalLbl"
        Me.domTotalLbl.Size = New System.Drawing.Size(118, 23)
        Me.domTotalLbl.TabIndex = 10
        Me.domTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'intLst
        '
        Me.intLst.FormattingEnabled = True
        Me.intLst.Location = New System.Drawing.Point(358, 75)
        Me.intLst.Name = "intLst"
        Me.intLst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.intLst.Size = New System.Drawing.Size(125, 108)
        Me.intLst.TabIndex = 9
        '
        'domLst
        '
        Me.domLst.FormattingEnabled = True
        Me.domLst.Location = New System.Drawing.Point(150, 75)
        Me.domLst.Name = "domLst"
        Me.domLst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.domLst.Size = New System.Drawing.Size(118, 108)
        Me.domLst.TabIndex = 8
        '
        'monthLst
        '
        Me.monthLst.FormattingEnabled = True
        Me.monthLst.Location = New System.Drawing.Point(54, 75)
        Me.monthLst.Name = "monthLst"
        Me.monthLst.Size = New System.Drawing.Size(41, 108)
        Me.monthLst.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Domestic Sales ($)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "International Sales ($)"
        '
        'displayBtn
        '
        Me.displayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayBtn.Location = New System.Drawing.Point(155, 310)
        Me.displayBtn.Name = "displayBtn"
        Me.displayBtn.Size = New System.Drawing.Size(125, 33)
        Me.displayBtn.TabIndex = 1
        Me.displayBtn.Text = "&Display Sales"
        Me.displayBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(436, 310)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(125, 33)
        Me.exitBtn.TabIndex = 2
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Location = New System.Drawing.Point(12, 356)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(39, 13)
        Me.timeLbl.TabIndex = 3
        Me.timeLbl.Text = "Label1"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Location = New System.Drawing.Point(612, 356)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(39, 13)
        Me.dateLbl.TabIndex = 4
        Me.dateLbl.Text = "Label2"
        '
        'frmMain
        '
        Me.AcceptButton = Me.displayBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelButton = Me.exitBtn
        Me.ClientSize = New System.Drawing.Size(744, 378)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.displayBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(760, 417)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(760, 417)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brandon Rowe-Conway Solution"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents displayBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents intLst As System.Windows.Forms.ListBox
    Friend WithEvents domLst As System.Windows.Forms.ListBox
    Friend WithEvents monthLst As System.Windows.Forms.ListBox
    Friend WithEvents intTotalLbl As System.Windows.Forms.Label
    Friend WithEvents domTotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totalSalesLbl As System.Windows.Forms.Label

End Class
