Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        If Password.Text.Length < 6 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub Guna2TextBox6_TextChanged(sender As Object, e As EventArgs) Handles CPassword.TextChanged
        If CPassword.Text.Length < 6 Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(emailorphone.Text) OrElse
            String.IsNullOrWhiteSpace(Fullname.Text) OrElse
            String.IsNullOrWhiteSpace(UserName.Text) OrElse
            String.IsNullOrWhiteSpace(Password.Text) OrElse
            String.IsNullOrWhiteSpace(CPassword.Text) Then
            MessageBox.Show("Fill In all Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Password.Text.Length < 6 Then
            MessageBox.Show("Minimum of 6 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CPassword.Text.Length < 6 Then
            MessageBox.Show("Minimum of 6 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class