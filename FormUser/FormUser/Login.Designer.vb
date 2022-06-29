<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.CheckBox_Remember = New System.Windows.Forms.CheckBox()
        Me.BtnLogIn = New System.Windows.Forms.Button()
        Me.Btn_sp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(260, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign In"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(151, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter your email address and pasword to"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(220, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "access SANZE system"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email address"
        '
        'txtEmail1
        '
        Me.txtEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtEmail1.Location = New System.Drawing.Point(49, 273)
        Me.txtEmail1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(519, 34)
        Me.txtEmail1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Password"
        '
        'txtPass1
        '
        Me.txtPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPass1.Location = New System.Drawing.Point(49, 416)
        Me.txtPass1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.Size = New System.Drawing.Size(478, 34)
        Me.txtPass1.TabIndex = 7
        '
        'CheckBox_Remember
        '
        Me.CheckBox_Remember.AutoSize = True
        Me.CheckBox_Remember.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.CheckBox_Remember.Location = New System.Drawing.Point(63, 503)
        Me.CheckBox_Remember.Name = "CheckBox_Remember"
        Me.CheckBox_Remember.Size = New System.Drawing.Size(156, 27)
        Me.CheckBox_Remember.TabIndex = 9
        Me.CheckBox_Remember.Text = "Remember me"
        Me.CheckBox_Remember.UseVisualStyleBackColor = True
        '
        'BtnLogIn
        '
        Me.BtnLogIn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnLogIn.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLogIn.Location = New System.Drawing.Point(245, 603)
        Me.BtnLogIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(127, 47)
        Me.BtnLogIn.TabIndex = 10
        Me.BtnLogIn.Text = "Log In"
        Me.BtnLogIn.UseVisualStyleBackColor = False
        '
        'Btn_sp
        '
        Me.Btn_sp.BackColor = System.Drawing.SystemColors.Menu
        Me.Btn_sp.BackgroundImage = CType(resources.GetObject("Btn_sp.BackgroundImage"), System.Drawing.Image)
        Me.Btn_sp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_sp.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_sp.Location = New System.Drawing.Point(522, 416)
        Me.Btn_sp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_sp.Name = "Btn_sp"
        Me.Btn_sp.Size = New System.Drawing.Size(46, 34)
        Me.Btn_sp.TabIndex = 11
        Me.Btn_sp.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(615, 704)
        Me.Controls.Add(Me.Btn_sp)
        Me.Controls.Add(Me.BtnLogIn)
        Me.Controls.Add(Me.CheckBox_Remember)
        Me.Controls.Add(Me.txtPass1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPass1 As TextBox
    Friend WithEvents CheckBox_Remember As CheckBox
    Friend WithEvents BtnLogIn As Button
    Friend WithEvents Btn_sp As Button
End Class
