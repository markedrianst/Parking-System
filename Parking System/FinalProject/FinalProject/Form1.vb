Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Register.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Username.Text = "Admin" AndAlso Pass.Text = "Admin" Then
            MainForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Username Or Password does not match !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
