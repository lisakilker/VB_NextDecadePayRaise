<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNextDecadePayRaise
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstListBox = New System.Windows.Forms.ListBox()
        Me.lblCurrentHourly = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblIncreasePercent = New System.Windows.Forms.Label()
        Me.lblYearlyIncrease = New System.Windows.Forms.Label()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.lblYouEntered = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(67, 32)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(325, 24)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Let's predict your future salary!"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(140, 68)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(179, 41)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Compute Future Pay"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lstListBox
        '
        Me.lstListBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstListBox.ForeColor = System.Drawing.Color.Green
        Me.lstListBox.FormattingEnabled = True
        Me.lstListBox.ItemHeight = 16
        Me.lstListBox.Location = New System.Drawing.Point(238, 260)
        Me.lstListBox.Name = "lstListBox"
        Me.lstListBox.Size = New System.Drawing.Size(200, 116)
        Me.lstListBox.TabIndex = 2
        Me.lstListBox.Visible = False
        '
        'lblCurrentHourly
        '
        Me.lblCurrentHourly.AutoSize = True
        Me.lblCurrentHourly.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentHourly.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentHourly.Location = New System.Drawing.Point(235, 155)
        Me.lblCurrentHourly.Name = "lblCurrentHourly"
        Me.lblCurrentHourly.Size = New System.Drawing.Size(72, 16)
        Me.lblCurrentHourly.TabIndex = 4
        Me.lblCurrentHourly.Text = "Hourly Pay"
        Me.lblCurrentHourly.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(459, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblIncreasePercent
        '
        Me.lblIncreasePercent.AutoSize = True
        Me.lblIncreasePercent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncreasePercent.ForeColor = System.Drawing.Color.Black
        Me.lblIncreasePercent.Location = New System.Drawing.Point(235, 184)
        Me.lblIncreasePercent.Name = "lblIncreasePercent"
        Me.lblIncreasePercent.Size = New System.Drawing.Size(127, 16)
        Me.lblIncreasePercent.TabIndex = 6
        Me.lblIncreasePercent.Text = "Percentage Increase"
        Me.lblIncreasePercent.Visible = False
        '
        'lblYearlyIncrease
        '
        Me.lblYearlyIncrease.AutoSize = True
        Me.lblYearlyIncrease.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyIncrease.ForeColor = System.Drawing.Color.Black
        Me.lblYearlyIncrease.Location = New System.Drawing.Point(234, 234)
        Me.lblYearlyIncrease.Name = "lblYearlyIncrease"
        Me.lblYearlyIncrease.Size = New System.Drawing.Size(211, 19)
        Me.lblYearlyIncrease.TabIndex = 7
        Me.lblYearlyIncrease.Text = "Yearly increase prediction:"
        Me.lblYearlyIncrease.Visible = False
        '
        'picPicture
        '
        Me.picPicture.Image = Global.NextDecadePayRaiseApplication.My.Resources.Resources.imag
        Me.picPicture.Location = New System.Drawing.Point(12, 124)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(213, 252)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 3
        Me.picPicture.TabStop = False
        '
        'lblYouEntered
        '
        Me.lblYouEntered.AutoSize = True
        Me.lblYouEntered.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouEntered.ForeColor = System.Drawing.Color.Black
        Me.lblYouEntered.Location = New System.Drawing.Point(254, 125)
        Me.lblYouEntered.Name = "lblYouEntered"
        Me.lblYouEntered.Size = New System.Drawing.Size(108, 19)
        Me.lblYouEntered.TabIndex = 8
        Me.lblYouEntered.Text = "You Entered:"
        Me.lblYouEntered.Visible = False
        '
        'frmNextDecadePayRaise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(459, 388)
        Me.Controls.Add(Me.lblYouEntered)
        Me.Controls.Add(Me.lblYearlyIncrease)
        Me.Controls.Add(Me.lblIncreasePercent)
        Me.Controls.Add(Me.lblCurrentHourly)
        Me.Controls.Add(Me.lstListBox)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picPicture)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNextDecadePayRaise"
        Me.Text = "Pay Raise Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstListBox As System.Windows.Forms.ListBox
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblCurrentHourly As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblIncreasePercent As System.Windows.Forms.Label
    Friend WithEvents lblYearlyIncrease As System.Windows.Forms.Label
    Friend WithEvents lblYouEntered As System.Windows.Forms.Label

End Class
