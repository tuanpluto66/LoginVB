Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UserSignUp

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim strPwd As String
        strPwd = txtPass.Text 'textbox containing password
        If txtFirstname.Text = "" Then
            MsgBox("Firstname cannot be empty", MsgBoxStyle.Exclamation)
            txtFirstname.Select()
        ElseIf txtLastname.Text = "" Then
            MsgBox("Lastname cannot be empty", MsgBoxStyle.Exclamation)
            txtLastname.Select()
        ElseIf txtEmail.Text = "" Then
            MsgBox("Email cannot be empty", MsgBoxStyle.Exclamation)
        ElseIf Not Regex.Match(txtEmail.Text, "^[a-zA-Z0-9\w.]+[@]+[a-zA-Z0-9\w]+[.]+[a-zA-Z0-9\w]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Enter a valid e-mail address ", MsgBoxStyle.Exclamation)
            txtEmail.Select()
        ElseIf txtPass.Text = "" Then
            MsgBox("Password cannot be empty", MsgBoxStyle.Exclamation)
            txtPass.Select()
        ElseIf ValidatePassword(strPwd) = False Then
            MsgBox("Password is invalid. Please try again.", MsgBoxStyle.Exclamation)
            txtPass.Select()
        ElseIf txtCpass.Text <> txtPass.Text Then
            MsgBox("Password do not match", MsgBoxStyle.Exclamation)
            txtCpass.Select()
        Else
            Dim Sqlstr As String
            Dim connectionString As String = "Data Source=TUANPLUTO\ANHTUAN;Initial Catalog=Demo_Login;Integrated Security=True"
            Sqlstr = "INSERT INTO [dbo].[USERSINGUP]
           ([Email]
           ,[Firstname]
           ,[Lastname]
           ,[Password])
     VALUES(@Email,@Firstname,@Lastname,@Password)"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim cmd As New SqlCommand(Sqlstr, connection)
                cmd.Parameters.Add("@Email", Data.SqlDbType.VarChar).Value = txtEmail.Text()
                cmd.Parameters.Add("@Firstname", Data.SqlDbType.VarChar).Value = txtFirstname.Text()
                cmd.Parameters.Add("@Lastname", Data.SqlDbType.VarChar).Value = txtLastname.Text()
                cmd.Parameters.Add("@Password", Data.SqlDbType.VarChar).Value = txtPass.Text()
                cmd.ExecuteNonQuery()
                connection.Close()
            End Using
            MessageBox.Show("Sign Up Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Loginform As New Login
            Loginform.Show()
            Me.Hide()
        End If

    End Sub
    'function kiem tra password max, min
    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 6,
        Optional ByVal numNumbers As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.

        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If number.Matches(pwd).Count < numNumbers Then Return False
        ' Passed all checks.
        Return True
    End Function


    Private Sub UserSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnSignUp.Select()
        txtPass.UseSystemPasswordChar = True
        txtCpass.UseSystemPasswordChar = True
        txtPass.MaxLength = 15
        txtCpass.MaxLength = 15

    End Sub
    'button show hide password
    Private Sub Btn_showP_Click(sender As Object, e As EventArgs) Handles Btn_showP.Click
        If txtPass.UseSystemPasswordChar = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
    'button show hide password
    Private Sub Btn_ShowCP_Click(sender As Object, e As EventArgs) Handles Btn_ShowCP.Click
        If txtCpass.UseSystemPasswordChar = True Then
            txtCpass.UseSystemPasswordChar = False
        Else
            txtCpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Btnloginuser_Click(sender As Object, e As EventArgs) Handles Btnloginuser.Click
        Dim Loginform As New Login
        Loginform.Show()
        Me.Hide()
    End Sub

End Class
