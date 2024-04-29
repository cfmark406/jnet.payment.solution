
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Public Class frmLogin

    Private Sub loginUserAccount()
        WaitForm.Show()
        Dim _username As String = frmLoginTextEditUsername.Text
        Dim _password As String = frmLoginTextEditPassword.Text
        conn.Close()

        If AuthenticateUser(_username, _password) Then
            MessageBox.Show("Login successful!")
            Dim frm As New FluentDesignForm1
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If


    End Sub


    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM dbo.users WHERE username = @username AND password = @password"

        mycommand.CommandText = query

        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Try
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return False
            Finally
                conn.Close()
            End Try
        End Using
    End Function




    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles frmLoginTextEditPassword.KeyPress
        If Asc(e.KeyChar) <> 13 Then Exit Sub
        loginUserAccount()

    End Sub

    Private Sub frmLoginBTN_Click(sender As Object, e As EventArgs) Handles frmLoginBTN.Click
        loginUserAccount()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        server_name = "WIN-AD5ES359GKM"
        db_name = "jnet_payment_solution"

        _restablish_db_connection()
    End Sub
End Class