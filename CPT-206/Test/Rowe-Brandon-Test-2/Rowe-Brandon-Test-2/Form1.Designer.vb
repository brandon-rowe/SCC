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
        Me.readFileBtn = New System.Windows.Forms.Button()
        Me.lstStudentFiles = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gradeLbl = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.numRecLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'readFileBtn
        '
        Me.readFileBtn.Location = New System.Drawing.Point(43, 37)
        Me.readFileBtn.Name = "readFileBtn"
        Me.readFileBtn.Size = New System.Drawing.Size(120, 23)
        Me.readFileBtn.TabIndex = 0
        Me.readFileBtn.Text = "&Read From Student File"
        Me.readFileBtn.UseVisualStyleBackColor = True
        '
        'lstStudentFiles
        '
        Me.lstStudentFiles.FormattingEnabled = True
        Me.lstStudentFiles.Location = New System.Drawing.Point(43, 78)
        Me.lstStudentFiles.Name = "lstStudentFiles"
        Me.lstStudentFiles.Size = New System.Drawing.Size(120, 95)
        Me.lstStudentFiles.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Records:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Letter Grade"
        '
        'gradeLbl
        '
        Me.gradeLbl.AutoSize = True
        Me.gradeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeLbl.Location = New System.Drawing.Point(223, 108)
        Me.gradeLbl.Name = "gradeLbl"
        Me.gradeLbl.Size = New System.Drawing.Size(76, 25)
        Me.gradeLbl.TabIndex = 4
        Me.gradeLbl.Text = "Grade"
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Location = New System.Drawing.Point(12, 313)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(39, 13)
        Me.timeLbl.TabIndex = 5
        Me.timeLbl.Text = "Label4"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Location = New System.Drawing.Point(192, 313)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(39, 13)
        Me.dateLbl.TabIndex = 6
        Me.dateLbl.Text = "Label5"
        '
        'numRecLbl
        '
        Me.numRecLbl.AutoSize = True
        Me.numRecLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numRecLbl.Location = New System.Drawing.Point(192, 190)
        Me.numRecLbl.Name = "numRecLbl"
        Me.numRecLbl.Size = New System.Drawing.Size(16, 16)
        Me.numRecLbl.TabIndex = 7
        Me.numRecLbl.Text = "0"
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 335)
        Me.Controls.Add(Me.numRecLbl)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.gradeLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstStudentFiles)
        Me.Controls.Add(Me.readFileBtn)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(365, 374)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(365, 374)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rowe CPT-206-Test-2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents readFileBtn As System.Windows.Forms.Button
    Friend WithEvents lstStudentFiles As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gradeLbl As System.Windows.Forms.Label
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents numRecLbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
