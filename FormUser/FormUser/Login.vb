Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Public Class Login
    Dim form3 As New Form3
    Dim connection As New SqlConnection("Data Source=TUANPLUTO\ANHTUAN;Initial Catalog=Demo_Login;Integrated Security=True")
    Private Sub Btn_sp_Click(sender As Object, e As EventArgs) Handles Btn_sp.Click
        If txtPass1.UseSystemPasswordChar = True Then
            txtPass1.UseSystemPasswordChar = False
        Else
            txtPass1.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click

        Dim command As New SqlCommand("SELECT [Email],[Password] FROM [dbo].[USERSINGUP] WHERE [Email] = @Email AND [Password] = @Password ", connection)
        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail1.Text
        command.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPass1.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count = 0 Then
            MsgBox("Invalid Email or Password")
        ElseIf CheckBox_Remember.Checked = True Then
            If txtEmail1.Text <> Nothing Or txtPass1.Text <> Nothing Then
                My.Settings.email = txtEmail1.Text
                My.Settings.password = txtPass1.Text
                My.Settings.check = True
                My.Settings.Save()
                My.Settings.Reload()
                MsgBox("Log In Success")
                form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("Log In Success")
                form3.Show()
                Me.Hide()
            End If
        ElseIf txtEmail1.Text <> Nothing Or txtPass1.Text <> Nothing Then
                MessageBox.Show("Log In Success")
                    form3.Show()
                    Me.Hide()
                End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = BtnLogIn
        txtEmail1.Select()
        txtPass1.UseSystemPasswordChar = True
        If My.Settings.check = True Then
            CheckBox_Remember.Enabled = True
            CheckBox_Remember.Checked = True
            txtEmail1.Text = My.Settings.email
            txtPass1.Text = My.Settings.password
        End If
    End Sub

End Class