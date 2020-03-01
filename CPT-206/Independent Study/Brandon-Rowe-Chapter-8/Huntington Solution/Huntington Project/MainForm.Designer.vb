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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.numbersSoldTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fullTimeLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.partTimeLbl = New System.Windows.Forms.Label()
        Me.newCarLbl = New System.Windows.Forms.Label()
        Me.usedCarLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calcBtn
        '
        Me.calcBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calcBtn.Location = New System.Drawing.Point(133, 78)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcBtn.TabIndex = 0
        Me.calcBtn.Text = "&Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Location = New System.Drawing.Point(236, 78)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(60, 23)
        Me.exitBtn.TabIndex = 1
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(133, 39)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(60, 20)
        Me.IDtxt.TabIndex = 2
        '
        'numbersSoldTxt
        '
        Me.numbersSoldTxt.Location = New System.Drawing.Point(236, 39)
        Me.numbersSoldTxt.Name = "numbersSoldTxt"
        Me.numbersSoldTxt.Size = New System.Drawing.Size(60, 20)
        Me.numbersSoldTxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Number sold:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cars sold by full-time employees:"
        '
        'fullTimeLbl
        '
        Me.fullTimeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullTimeLbl.Location = New System.Drawing.Point(236, 137)
        Me.fullTimeLbl.Name = "fullTimeLbl"
        Me.fullTimeLbl.Size = New System.Drawing.Size(60, 23)
        Me.fullTimeLbl.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cars sold by part-time employees:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cars sold by new car employees:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cars sold by used car employees:"
        '
        'partTimeLbl
        '
        Me.partTimeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.partTimeLbl.Location = New System.Drawing.Point(236, 182)
        Me.partTimeLbl.Name = "partTimeLbl"
        Me.partTimeLbl.Size = New System.Drawing.Size(60, 23)
        Me.partTimeLbl.TabIndex = 11
        '
        'newCarLbl
        '
        Me.newCarLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newCarLbl.Location = New System.Drawing.Point(236, 236)
        Me.newCarLbl.Name = "newCarLbl"
        Me.newCarLbl.Size = New System.Drawing.Size(60, 23)
        Me.newCarLbl.TabIndex = 12
        '
        'usedCarLbl
        '
        Me.usedCarLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usedCarLbl.Location = New System.Drawing.Point(236, 293)
        Me.usedCarLbl.Name = "usedCarLbl"
        Me.usedCarLbl.Size = New System.Drawing.Size(60, 23)
        Me.usedCarLbl.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 120)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.calcBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitBtn
        Me.ClientSize = New System.Drawing.Size(364, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.usedCarLbl)
        Me.Controls.Add(Me.newCarLbl)
        Me.Controls.Add(Me.partTimeLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fullTimeLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numbersSoldTxt)
        Me.Controls.Add(Me.IDtxt)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.calcBtn)
        Me.Name = "frmMain"
        Me.Text = "Huntington Motors"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents IDtxt As System.Windows.Forms.TextBox
    Friend WithEvents numbersSoldTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fullTimeLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents partTimeLbl As System.Windows.Forms.Label
    Friend WithEvents newCarLbl As System.Windows.Forms.Label
    Friend WithEvents usedCarLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
