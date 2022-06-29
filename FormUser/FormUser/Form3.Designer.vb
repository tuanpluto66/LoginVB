<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Btn_Open = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Richtxt = New System.Windows.Forms.RichTextBox()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Btn_Open
        '
        Me.Btn_Open.BackColor = System.Drawing.Color.Salmon
        Me.Btn_Open.Location = New System.Drawing.Point(530, 173)
        Me.Btn_Open.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Open.Name = "Btn_Open"
        Me.Btn_Open.Size = New System.Drawing.Size(71, 32)
        Me.Btn_Open.TabIndex = 0
        Me.Btn_Open.Text = "OPEN"
        Me.Btn_Open.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Clear.Location = New System.Drawing.Point(530, 231)
        Me.Btn_Clear.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(71, 32)
        Me.Btn_Clear.TabIndex = 0
        Me.Btn_Clear.Text = "CLEAR"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.Yellow
        Me.Btn_Exit.Location = New System.Drawing.Point(530, 530)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(71, 32)
        Me.Btn_Exit.TabIndex = 0
        Me.Btn_Exit.Text = "EXIT"
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(189, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "READ WRITE TEXT FORM"
        '
        'Richtxt
        '
        Me.Richtxt.BackColor = System.Drawing.Color.FloralWhite
        Me.Richtxt.Location = New System.Drawing.Point(12, 76)
        Me.Richtxt.Name = "Richtxt"
        Me.Richtxt.Size = New System.Drawing.Size(488, 486)
        Me.Richtxt.TabIndex = 2
        Me.Richtxt.Text = ""
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(628, 593)
        Me.Controls.Add(Me.Richtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Open)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Open As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Richtxt As RichTextBox
    Friend WithEvents OpenFile As OpenFileDialog
End Class
