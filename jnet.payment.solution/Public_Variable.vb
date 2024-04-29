Imports System.ComponentModel
Imports DevExpress.XtraSplashScreen
Imports System.Data.SqlClient


Module Public_Variable






    'database connection declarations
    Public server_ip, server_uid, server_password, myConnectionString, server_name, db_name, private_key, private_user, cloud_ip As String

    Public conn As New SqlConnection
    Public mycommand As New SqlCommand
    Public myreader As SqlDataReader
    Public _isConnected As Boolean
    Public query As String



End Module
