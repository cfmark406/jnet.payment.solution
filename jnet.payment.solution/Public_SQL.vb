
Imports DevExpress.XtraEditors

Module Public_SQL


    Public Sub get_connected()

        _isConnected = False

        myConnectionString = $"Data Source={server_name};User ID=sa;Password=123456;Initial Catalog={db_name}"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            mycommand.Connection = conn

        Catch ex As Exception
            XtraMessageBox.Show($"Unable to connect to any specified database server.{vbNewLine & vbNewLine}Please contact your system administrator.", "Error_Message_Cannot_Proceed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
        _isConnected = True
    End Sub

    Public Sub _restablish_db_connection()
        If conn.State = ConnectionState.Broken Or conn.State = ConnectionState.Closed Then
            get_connected()
        End If
    End Sub

    Public Sub _refresh_db_connection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        _isConnected = False

        myConnectionString = $"Data Source={server_name};User ID=sa;Password=123456;Initial Catalog={db_name}"
        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            mycommand.Connection = conn

        Catch ex As Exception
            XtraMessageBox.Show($"Unable to connect to any specified database server.{vbNewLine & vbNewLine}Please contact your system administrator.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
        _isConnected = True
    End Sub

End Module
