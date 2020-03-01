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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.saveVoteBtn = New System.Windows.Forms.Button()
        Me.displayVoteBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.lstCommercial = New System.Windows.Forms.ListBox()
        Me.budLbl = New System.Windows.Forms.Label()
        Me.fedLbl = New System.Windows.Forms.Label()
        Me.etLbl = New System.Windows.Forms.Label()
        Me.pepLbl = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Commercial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 253)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Budweiser:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 253)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FedEx:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E*TRADE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 253)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pepsi:"
        '
        'saveVoteBtn
        '
        Me.saveVoteBtn.Location = New System.Drawing.Point(319, 54)
        Me.saveVoteBtn.Name = "saveVoteBtn"
        Me.saveVoteBtn.Size = New System.Drawing.Size(112, 33)
        Me.saveVoteBtn.TabIndex = 5
        Me.saveVoteBtn.Text = "&Save Vote"
        Me.saveVoteBtn.UseVisualStyleBackColor = True
        '
        'displayVoteBtn
        '
        Me.displayVoteBtn.Location = New System.Drawing.Point(319, 93)
        Me.displayVoteBtn.Name = "displayVoteBtn"
        Me.displayVoteBtn.Size = New System.Drawing.Size(112, 33)
        Me.displayVoteBtn.TabIndex = 6
        Me.displayVoteBtn.Text = "&Display Votes"
        Me.displayVoteBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(319, 132)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(112, 33)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'lstCommercial
        '
        Me.lstCommercial.FormattingEnabled = True
        Me.lstCommercial.ItemHeight = 16
        Me.lstCommercial.Location = New System.Drawing.Point(64, 54)
        Me.lstCommercial.Name = "lstCommercial"
        Me.lstCommercial.Size = New System.Drawing.Size(120, 164)
        Me.lstCommercial.TabIndex = 8
        '
        'budLbl
        '
        Me.budLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.budLbl.Location = New System.Drawing.Point(64, 288)
        Me.budLbl.Name = "budLbl"
        Me.budLbl.Size = New System.Drawing.Size(71, 28)
        Me.budLbl.TabIndex = 9
        '
        'fedLbl
        '
        Me.fedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fedLbl.Location = New System.Drawing.Point(168, 288)
        Me.fedLbl.Name = "fedLbl"
        Me.fedLbl.Size = New System.Drawing.Size(71, 28)
        Me.fedLbl.TabIndex = 10
        '
        'etLbl
        '
        Me.etLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.etLbl.Location = New System.Drawing.Point(260, 288)
        Me.etLbl.Name = "etLbl"
        Me.etLbl.Size = New System.Drawing.Size(71, 28)
        Me.etLbl.TabIndex = 11
        '
        'pepLbl
        '
        Me.pepLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pepLbl.Location = New System.Drawing.Point(360, 288)
        Me.pepLbl.Name = "pepLbl"
        Me.pepLbl.Size = New System.Drawing.Size(71, 28)
        Me.pepLbl.TabIndex = 12
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Location = New System.Drawing.Point(12, 344)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(49, 16)
        Me.timeLbl.TabIndex = 13
        Me.timeLbl.Text = "Label9"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Location = New System.Drawing.Point(338, 344)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(56, 16)
        Me.dateLbl.TabIndex = 14
        Me.dateLbl.Text = "Label10"
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(493, 369)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.pepLbl)
        Me.Controls.Add(Me.etLbl)
        Me.Controls.Add(Me.fedLbl)
        Me.Controls.Add(Me.budLbl)
        Me.Controls.Add(Me.lstCommercial)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.displayVoteBtn)
        Me.Controls.Add(Me.saveVoteBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(509, 408)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(509, 408)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WKRK-Radio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents saveVoteBtn As System.Windows.Forms.Button
    Friend WithEvents displayVoteBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents lstCommercial As System.Windows.Forms.ListBox
    Friend WithEvents budLbl As System.Windows.Forms.Label
    Friend WithEvents fedLbl As System.Windows.Forms.Label
    Friend WithEvents etLbl As System.Windows.Forms.Label
    Friend WithEvents pepLbl As System.Windows.Forms.Label
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
