<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSignUp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.txtCpass = New System.Windows.Forms.TextBox()
        Me.Btn_showP = New System.Windows.Forms.Button()
        Me.Btn_ShowCP = New System.Windows.Forms.Button()
        Me.Btnloginuser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(235, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Free Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(173, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Don't have an account? Create your"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(173, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "account, it takes les than a minute"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Full Name"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(46, 225)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.MinimumSize = New System.Drawing.Size(50, 30)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(252, 34)
        Me.txtFirstname.TabIndex = 3
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(318, 225)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(252, 34)
        Me.txtLastname.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Emai address"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(46, 328)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(524, 34)
        Me.txtEmail.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.Location = New System.Drawing.Point(142, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "(6 characters minimum)"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPass.Location = New System.Drawing.Point(52, 435)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass.MaxLength = 32
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(473, 34)
        Me.txtPass.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Password Confirmation"
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSignUp.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSignUp.Location = New System.Drawing.Point(146, 611)
        Me.BtnSignUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(127, 47)
        Me.BtnSignUp.TabIndex = 4
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'txtCpass
        '
        Me.txtCpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtCpass.Location = New System.Drawing.Point(52, 546)
        Me.txtCpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCpass.Name = "txtCpass"
        Me.txtCpass.Size = New System.Drawing.Size(473, 34)
        Me.txtCpass.TabIndex = 3
        '
        'Btn_showP
        '
        Me.Btn_showP.BackColor = System.Drawing.SystemColors.Menu
        Me.Btn_showP.BackgroundImage = CType(resources.GetObject("Btn_showP.BackgroundImage"), System.Drawing.Image)
        Me.Btn_showP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_showP.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_showP.Location = New System.Drawing.Point(523, 435)
        Me.Btn_showP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_showP.Name = "Btn_showP"
        Me.Btn_showP.Size = New System.Drawing.Size(47, 34)
        Me.Btn_showP.TabIndex = 5
        Me.Btn_showP.UseVisualStyleBackColor = False
        '
        'Btn_ShowCP
        '
        Me.Btn_ShowCP.BackColor = System.Drawing.SystemColors.Menu
        Me.Btn_ShowCP.BackgroundImage = CType(resources.GetObject("Btn_ShowCP.BackgroundImage"), System.Drawing.Image)
        Me.Btn_ShowCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_ShowCP.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_ShowCP.Location = New System.Drawing.Point(523, 546)
        Me.Btn_ShowCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ShowCP.Name = "Btn_ShowCP"
        Me.Btn_ShowCP.Size = New System.Drawing.Size(42, 34)
        Me.Btn_ShowCP.TabIndex = 5
        Me.Btn_ShowCP.UseVisualStyleBackColor = False
        '
        'Btnloginuser
        '
        Me.Btnloginuser.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Btnloginuser.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Btnloginuser.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btnloginuser.Location = New System.Drawing.Point(313, 611)
        Me.Btnloginuser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnloginuser.Name = "Btnloginuser"
        Me.Btnloginuser.Size = New System.Drawing.Size(127, 47)
        Me.Btnloginuser.TabIndex = 11
        Me.Btnloginuser.Text = "Log In"
        Me.Btnloginuser.UseVisualStyleBackColor = False
        '
        'UserSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(615, 704)
        Me.Controls.Add(Me.Btnloginuser)
        Me.Controls.Add(Me.Btn_ShowCP)
        Me.Controls.Add(Me.Btn_showP)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtCpass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UserSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents txtCpass As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Btn_showP As Button
    Friend WithEvents Btn_ShowCP As Button
    Friend WithEvents Btnloginuser As Button
End Class
