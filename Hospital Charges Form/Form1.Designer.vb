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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRehab = New System.Windows.Forms.TextBox()
        Me.txtLabFees = New System.Windows.Forms.TextBox()
        Me.txtSurgicalCharges = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.lblPhysicalRehab = New System.Windows.Forms.Label()
        Me.lblLabFees = New System.Windows.Forms.Label()
        Me.lblSurgicalCharges = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblLenghtOfStay = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 372)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(109, 66)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate Charges"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(138, 372)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 66)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 66)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtRehab)
        Me.Panel1.Controls.Add(Me.txtLabFees)
        Me.Panel1.Controls.Add(Me.txtSurgicalCharges)
        Me.Panel1.Controls.Add(Me.txtMedication)
        Me.Panel1.Controls.Add(Me.txtDays)
        Me.Panel1.Controls.Add(Me.lblPhysicalRehab)
        Me.Panel1.Controls.Add(Me.lblLabFees)
        Me.Panel1.Controls.Add(Me.lblSurgicalCharges)
        Me.Panel1.Controls.Add(Me.lblMedication)
        Me.Panel1.Controls.Add(Me.lblLenghtOfStay)
        Me.Panel1.Location = New System.Drawing.Point(26, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 230)
        Me.Panel1.TabIndex = 9
        '
        'txtRehab
        '
        Me.txtRehab.Location = New System.Drawing.Point(197, 186)
        Me.txtRehab.Name = "txtRehab"
        Me.txtRehab.Size = New System.Drawing.Size(100, 22)
        Me.txtRehab.TabIndex = 9
        '
        'txtLabFees
        '
        Me.txtLabFees.Location = New System.Drawing.Point(197, 140)
        Me.txtLabFees.Name = "txtLabFees"
        Me.txtLabFees.Size = New System.Drawing.Size(100, 22)
        Me.txtLabFees.TabIndex = 8
        '
        'txtSurgicalCharges
        '
        Me.txtSurgicalCharges.Location = New System.Drawing.Point(197, 102)
        Me.txtSurgicalCharges.Name = "txtSurgicalCharges"
        Me.txtSurgicalCharges.Size = New System.Drawing.Size(100, 22)
        Me.txtSurgicalCharges.TabIndex = 7
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(194, 58)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(100, 22)
        Me.txtMedication.TabIndex = 6
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(194, 11)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 22)
        Me.txtDays.TabIndex = 5
        '
        'lblPhysicalRehab
        '
        Me.lblPhysicalRehab.AutoSize = True
        Me.lblPhysicalRehab.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicalRehab.Location = New System.Drawing.Point(63, 189)
        Me.lblPhysicalRehab.Name = "lblPhysicalRehab"
        Me.lblPhysicalRehab.Size = New System.Drawing.Size(125, 17)
        Me.lblPhysicalRehab.TabIndex = 4
        Me.lblPhysicalRehab.Text = "Physical Rehab:"
        '
        'lblLabFees
        '
        Me.lblLabFees.AutoSize = True
        Me.lblLabFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabFees.Location = New System.Drawing.Point(108, 145)
        Me.lblLabFees.Name = "lblLabFees"
        Me.lblLabFees.Size = New System.Drawing.Size(80, 17)
        Me.lblLabFees.TabIndex = 3
        Me.lblLabFees.Text = "Lab Fees:"
        '
        'lblSurgicalCharges
        '
        Me.lblSurgicalCharges.AutoSize = True
        Me.lblSurgicalCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurgicalCharges.Location = New System.Drawing.Point(51, 105)
        Me.lblSurgicalCharges.Name = "lblSurgicalCharges"
        Me.lblSurgicalCharges.Size = New System.Drawing.Size(137, 17)
        Me.lblSurgicalCharges.TabIndex = 2
        Me.lblSurgicalCharges.Text = "Surgical Charges:"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.Location = New System.Drawing.Point(97, 61)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(91, 17)
        Me.lblMedication.TabIndex = 1
        Me.lblMedication.Text = "Medication:"
        '
        'lblLenghtOfStay
        '
        Me.lblLenghtOfStay.AutoSize = True
        Me.lblLenghtOfStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLenghtOfStay.Location = New System.Drawing.Point(16, 14)
        Me.lblLenghtOfStay.Name = "lblLenghtOfStay"
        Me.lblLenghtOfStay.Size = New System.Drawing.Size(172, 17)
        Me.lblLenghtOfStay.TabIndex = 0
        Me.lblLenghtOfStay.Text = "Length of Stay (Days):"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblTotalCost)
        Me.Panel2.Location = New System.Drawing.Point(26, 266)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 73)
        Me.Panel2.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(194, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 27)
        Me.lblTotal.TabIndex = 1
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(16, 22)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(102, 20)
        Me.lblTotalCost.TabIndex = 0
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPhysicalRehab As Label
    Friend WithEvents lblLabFees As Label
    Friend WithEvents lblSurgicalCharges As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblLenghtOfStay As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRehab As TextBox
    Friend WithEvents txtLabFees As TextBox
    Friend WithEvents txtSurgicalCharges As TextBox
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalCost As Label
End Class
