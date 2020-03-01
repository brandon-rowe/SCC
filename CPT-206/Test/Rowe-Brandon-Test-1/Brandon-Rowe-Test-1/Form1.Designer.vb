<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.boxCheckBox = New System.Windows.Forms.CheckBox()
        Me.pavilionCheckBox = New System.Windows.Forms.CheckBox()
        Me.lawnCheckBox = New System.Windows.Forms.CheckBox()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lawnTxt = New System.Windows.Forms.TextBox()
        Me.pavilionTxt = New System.Windows.Forms.TextBox()
        Me.boxTxt = New System.Windows.Forms.TextBox()
        Me.ticketsLbl = New System.Windows.Forms.Label()
        Me.amountDueLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxCheckBox
        '
        Me.boxCheckBox.AutoSize = True
        Me.boxCheckBox.Location = New System.Drawing.Point(22, 33)
        Me.boxCheckBox.Name = "boxCheckBox"
        Me.boxCheckBox.Size = New System.Drawing.Size(47, 17)
        Me.boxCheckBox.TabIndex = 0
        Me.boxCheckBox.Text = "&Box"
        Me.boxCheckBox.UseVisualStyleBackColor = True
        '
        'pavilionCheckBox
        '
        Me.pavilionCheckBox.AutoSize = True
        Me.pavilionCheckBox.Location = New System.Drawing.Point(118, 33)
        Me.pavilionCheckBox.Name = "pavilionCheckBox"
        Me.pavilionCheckBox.Size = New System.Drawing.Size(71, 17)
        Me.pavilionCheckBox.TabIndex = 1
        Me.pavilionCheckBox.Text = "&Pavilion"
        Me.pavilionCheckBox.UseVisualStyleBackColor = True
        '
        'lawnCheckBox
        '
        Me.lawnCheckBox.AutoSize = True
        Me.lawnCheckBox.Location = New System.Drawing.Point(238, 33)
        Me.lawnCheckBox.Name = "lawnCheckBox"
        Me.lawnCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.lawnCheckBox.TabIndex = 2
        Me.lawnCheckBox.Text = "&Lawn"
        Me.lawnCheckBox.UseVisualStyleBackColor = True
        '
        'calcBtn
        '
        Me.calcBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calcBtn.Location = New System.Drawing.Point(57, 191)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(87, 35)
        Me.calcBtn.TabIndex = 9
        Me.calcBtn.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.calcBtn, "Press to Calculate Tickets")
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Location = New System.Drawing.Point(369, 191)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(87, 35)
        Me.exitBtn.TabIndex = 11
        Me.exitBtn.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitBtn, "Press to exit")
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.lawnTxt)
        Me.GroupBox1.Controls.Add(Me.pavilionTxt)
        Me.GroupBox1.Controls.Add(Me.boxTxt)
        Me.GroupBox1.Controls.Add(Me.boxCheckBox)
        Me.GroupBox1.Controls.Add(Me.pavilionCheckBox)
        Me.GroupBox1.Controls.Add(Me.lawnCheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 144)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'lawnTxt
        '
        Me.lawnTxt.Location = New System.Drawing.Point(238, 56)
        Me.lawnTxt.Name = "lawnTxt"
        Me.lawnTxt.Size = New System.Drawing.Size(54, 20)
        Me.lawnTxt.TabIndex = 19
        Me.lawnTxt.Visible = False
        '
        'pavilionTxt
        '
        Me.pavilionTxt.Location = New System.Drawing.Point(118, 56)
        Me.pavilionTxt.Name = "pavilionTxt"
        Me.pavilionTxt.Size = New System.Drawing.Size(54, 20)
        Me.pavilionTxt.TabIndex = 18
        Me.pavilionTxt.Visible = False
        '
        'boxTxt
        '
        Me.boxTxt.Location = New System.Drawing.Point(22, 56)
        Me.boxTxt.Name = "boxTxt"
        Me.boxTxt.Size = New System.Drawing.Size(54, 20)
        Me.boxTxt.TabIndex = 17
        Me.boxTxt.Visible = False
        '
        'ticketsLbl
        '
        Me.ticketsLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ticketsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ticketsLbl.Location = New System.Drawing.Point(484, 45)
        Me.ticketsLbl.Name = "ticketsLbl"
        Me.ticketsLbl.Size = New System.Drawing.Size(117, 23)
        Me.ticketsLbl.TabIndex = 13
        Me.ticketsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'amountDueLbl
        '
        Me.amountDueLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.amountDueLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amountDueLbl.Location = New System.Drawing.Point(484, 133)
        Me.amountDueLbl.Name = "amountDueLbl"
        Me.amountDueLbl.Size = New System.Drawing.Size(117, 23)
        Me.amountDueLbl.TabIndex = 14
        Me.amountDueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(458, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Number of tickets sold"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(481, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Total amount due"
        '
        'ToolTip1
        '
        '
        'Form1
        '
        Me.AcceptButton = Me.calcBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitBtn
        Me.ClientSize = New System.Drawing.Size(661, 254)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.amountDueLbl)
        Me.Controls.Add(Me.ticketsLbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.calcBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(677, 293)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(677, 293)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brandon-Rowe-Test-1 Ticket Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents pavilionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lawnCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents calcBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lawnTxt As System.Windows.Forms.TextBox
    Friend WithEvents pavilionTxt As System.Windows.Forms.TextBox
    Friend WithEvents boxTxt As System.Windows.Forms.TextBox
    Friend WithEvents ticketsLbl As System.Windows.Forms.Label
    Friend WithEvents amountDueLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
