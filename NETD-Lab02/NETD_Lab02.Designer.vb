<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGolfMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGolfMain))
        Me.imgGolfTee = New System.Windows.Forms.PictureBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.nudScore = New System.Windows.Forms.NumericUpDown()
        Me.lblHoleTitle = New System.Windows.Forms.Label()
        Me.lblHoleNum = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtHole = New System.Windows.Forms.TextBox()
        Me.txtPar = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblHoleRecorder = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultFinal = New System.Windows.Forms.TextBox()
        Me.txtParFinal = New System.Windows.Forms.TextBox()
        Me.txtScoreFinal = New System.Windows.Forms.TextBox()
        CType(Me.imgGolfTee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.nudScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgGolfTee
        '
        Me.imgGolfTee.Image = Global.NETD_Lab02.My.Resources.Resources.balle_sur_tee
        Me.imgGolfTee.Location = New System.Drawing.Point(42, 163)
        Me.imgGolfTee.Name = "imgGolfTee"
        Me.imgGolfTee.Size = New System.Drawing.Size(167, 168)
        Me.imgGolfTee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgGolfTee.TabIndex = 0
        Me.imgGolfTee.TabStop = False
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(21, 15)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(539, 54)
        Me.pnlTitle.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Green
        Me.lblTitle.Location = New System.Drawing.Point(53, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(415, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Jeremy's Golf Score Tracker"
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(126, 114)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(69, 40)
        Me.btnScore.TabIndex = 2
        Me.btnScore.Text = "Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Score"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'nudScore
        '
        Me.nudScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudScore.Location = New System.Drawing.Point(54, 114)
        Me.nudScore.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudScore.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudScore.Name = "nudScore"
        Me.nudScore.ReadOnly = True
        Me.nudScore.Size = New System.Drawing.Size(54, 31)
        Me.nudScore.TabIndex = 0
        Me.nudScore.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblHoleTitle
        '
        Me.lblHoleTitle.AutoSize = True
        Me.lblHoleTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoleTitle.Location = New System.Drawing.Point(50, 85)
        Me.lblHoleTitle.Name = "lblHoleTitle"
        Me.lblHoleTitle.Size = New System.Drawing.Size(51, 20)
        Me.lblHoleTitle.TabIndex = 4
        Me.lblHoleTitle.Text = "Hole:"
        '
        'lblHoleNum
        '
        Me.lblHoleNum.AutoSize = True
        Me.lblHoleNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoleNum.ForeColor = System.Drawing.Color.Green
        Me.lblHoleNum.Location = New System.Drawing.Point(117, 85)
        Me.lblHoleNum.Name = "lblHoleNum"
        Me.lblHoleNum.Size = New System.Drawing.Size(19, 20)
        Me.lblHoleNum.TabIndex = 5
        Me.lblHoleNum.Text = "1"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(35, 453)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(72, 47)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(113, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtHole
        '
        Me.txtHole.Enabled = False
        Me.txtHole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHole.Location = New System.Drawing.Point(250, 92)
        Me.txtHole.Multiline = True
        Me.txtHole.Name = "txtHole"
        Me.txtHole.Size = New System.Drawing.Size(49, 370)
        Me.txtHole.TabIndex = 8
        '
        'txtPar
        '
        Me.txtPar.Enabled = False
        Me.txtPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPar.Location = New System.Drawing.Point(305, 92)
        Me.txtPar.Multiline = True
        Me.txtPar.Name = "txtPar"
        Me.txtPar.Size = New System.Drawing.Size(49, 370)
        Me.txtPar.TabIndex = 9
        '
        'txtScore
        '
        Me.txtScore.Enabled = False
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(360, 92)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(49, 370)
        Me.txtScore.TabIndex = 10
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(415, 92)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(132, 370)
        Me.txtResult.TabIndex = 11
        '
        'lblHoleRecorder
        '
        Me.lblHoleRecorder.AutoSize = True
        Me.lblHoleRecorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoleRecorder.Location = New System.Drawing.Point(256, 73)
        Me.lblHoleRecorder.Name = "lblHoleRecorder"
        Me.lblHoleRecorder.Size = New System.Drawing.Size(37, 16)
        Me.lblHoleRecorder.TabIndex = 12
        Me.lblHoleRecorder.Text = "Hole"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Result"
        '
        'txtResultFinal
        '
        Me.txtResultFinal.Enabled = False
        Me.txtResultFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultFinal.Location = New System.Drawing.Point(415, 468)
        Me.txtResultFinal.Name = "txtResultFinal"
        Me.txtResultFinal.Size = New System.Drawing.Size(132, 26)
        Me.txtResultFinal.TabIndex = 16
        '
        'txtParFinal
        '
        Me.txtParFinal.Enabled = False
        Me.txtParFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParFinal.Location = New System.Drawing.Point(305, 467)
        Me.txtParFinal.Name = "txtParFinal"
        Me.txtParFinal.Size = New System.Drawing.Size(47, 26)
        Me.txtParFinal.TabIndex = 17
        Me.txtParFinal.Text = "72"
        '
        'txtScoreFinal
        '
        Me.txtScoreFinal.Enabled = False
        Me.txtScoreFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScoreFinal.Location = New System.Drawing.Point(359, 467)
        Me.txtScoreFinal.Name = "txtScoreFinal"
        Me.txtScoreFinal.Size = New System.Drawing.Size(50, 26)
        Me.txtScoreFinal.TabIndex = 18
        '
        'frmGolfMain
        '
        Me.AcceptButton = Me.btnScore
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 512)
        Me.Controls.Add(Me.txtScoreFinal)
        Me.Controls.Add(Me.txtParFinal)
        Me.Controls.Add(Me.txtResultFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHoleRecorder)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtPar)
        Me.Controls.Add(Me.txtHole)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblHoleNum)
        Me.Controls.Add(Me.lblHoleTitle)
        Me.Controls.Add(Me.nudScore)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.imgGolfTee)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(600, 550)
        Me.MinimumSize = New System.Drawing.Size(600, 550)
        Me.Name = "frmGolfMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trooper Golf Tracker"
        CType(Me.imgGolfTee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.nudScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgGolfTee As PictureBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnScore As Button
    Friend WithEvents nudScore As NumericUpDown
    Friend WithEvents lblHoleTitle As Label
    Friend WithEvents lblHoleNum As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtHole As TextBox
    Friend WithEvents txtPar As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblHoleRecorder As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultFinal As TextBox
    Friend WithEvents txtParFinal As TextBox
    Friend WithEvents txtScoreFinal As TextBox
End Class
