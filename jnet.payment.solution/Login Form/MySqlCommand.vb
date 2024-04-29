Imports System.Data.SqlClient

Friend Class MySqlCommand
    Private query As String
    Private conn As SqlConnection

    Public Sub New(query As String, conn As SqlConnection)
        Me.query = query
        Me.conn = conn
    End Sub
End Class
