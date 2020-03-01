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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.assetCostTxt = New System.Windows.Forms.TextBox()
        Me.salvageValueTxt = New System.Windows.Forms.TextBox()
        Me.usefulLifeListbox = New System.Windows.Forms.ListBox()
        Me.displayBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.outputTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Asset cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Useful life:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Salvage value:"
        '
        'assetCostTxt
        '
        Me.assetCostTxt.Location = New System.Drawing.Point(25, 53)
        Me.assetCostTxt.Name = "assetCostTxt"
        Me.assetCostTxt.Size = New System.Drawing.Size(80, 20)
        Me.assetCostTxt.TabIndex = 3
        '
        'salvageValueTxt
        '
        Me.salvageValueTxt.Location = New System.Drawing.Point(289, 53)
        Me.salvageValueTxt.Name = "salvageValueTxt"
        Me.salvageValueTxt.Size = New System.Drawing.Size(109, 20)
        Me.salvageValueTxt.TabIndex = 4
        '
        'usefulLifeListbox
        '
        Me.usefulLifeListbox.DisplayMember = "1"
        Me.usefulLifeListbox.FormattingEnabled = True
        Me.usefulLifeListbox.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.usefulLifeListbox.Location = New System.Drawing.Point(153, 53)
        Me.usefulLifeListbox.Name = "usefulLifeListbox"
        Me.usefulLifeListbox.Size = New System.Drawing.Size(95, 95)
        Me.usefulLifeListbox.TabIndex = 5
        '
        'displayBtn
        '
        Me.displayBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.displayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayBtn.Location = New System.Drawing.Point(25, 421)
        Me.displayBtn.Name = "displayBtn"
        Me.displayBtn.Size = New System.Drawing.Size(219, 63)
        Me.displayBtn.TabIndex = 6
        Me.displayBtn.Text = "&Display Depreciation Schedule"
        Me.displayBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(318, 421)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(80, 63)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Depreciation schedule:"
        '
        'outputTxt
        '
        Me.outputTxt.Location = New System.Drawing.Point(25, 217)
        Me.outputTxt.Multiline = True
        Me.outputTxt.Name = "outputTxt"
        Me.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outputTxt.Size = New System.Drawing.Size(373, 185)
        Me.outputTxt.TabIndex = 9
        '
        'Form1
        '
        Me.AcceptButton = Me.displayBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.displayBtn
        Me.ClientSize = New System.Drawing.Size(421, 518)
        Me.Controls.Add(Me.outputTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.displayBtn)
        Me.Controls.Add(Me.usefulLifeListbox)
        Me.Controls.Add(Me.salvageValueTxt)
        Me.Controls.Add(Me.assetCostTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brandon-Rowe-Chapter-6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents assetCostTxt As System.Windows.Forms.TextBox
    Friend WithEvents salvageValueTxt As System.Windows.Forms.TextBox
    Friend WithEvents usefulLifeListbox As System.Windows.Forms.ListBox
    Friend WithEvents displayBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents outputTxt As System.Windows.Forms.TextBox

End Class
