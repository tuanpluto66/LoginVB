Public Class Form3
    Private Sub Btn_Open_Click(sender As Object, e As EventArgs) Handles Btn_Open.Click
        If OpenFile.ShowDialog = DialogResult.OK Then
            Richtxt.Text = My.Computer.FileSystem.ReadAllText(OpenFile.FileName)
        End If
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Application.Exit()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Richtxt.Clear()
    End Sub
End Class