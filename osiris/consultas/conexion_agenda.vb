Imports MySql.Data.MySqlClient
Module conexion_agenda
    'VARIABLES PARA APP.CONFIG
    Dim ip_servidor As String = My.Settings.ip_agenda

    ' Public serverdb_agenda As String = "localhost"
    Public serverdb_agenda As String = ip_servidor
    Public db_agenda As String = "medvitaltest"
    Public userdb_agenda As String = "liberty"
    Public passdb_agenda As String = "l1b3rty*"
    Public portdb_agenda As String = "3306"

    Public cadenaConexion_agenda As String = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ""
    Public conn_agenda As New MySqlConnection(cadenaConexion_agenda)
    Public cmd_agenda As New MySqlCommand
    Public dr_agenda As MySqlDataReader

    '********** FTP AGENDA **********'
    Public userftp_agenda As String = "sadmin"
    Public passftp_agenda As String = "Sadmin7050*"
    Public agendaftp As String = "ftp://192.168.1.27:21/"

    Public Sub conectarse_agenda()
        Try
            conn_agenda.Open()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'MsgBox("Falla en la conexión con la base de datos ☹")
        End Try
    End Sub

    Public Function desconectado_agenda()
        Try
            If conn_agenda.State = ConnectionState.Open Then
                conn_agenda.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Sincronizar procedimiento
    Public Sub sincronizar_concepto(ByRef idconcepto As Integer, ByRef concepto As String)
        desconectado_agenda()
        conectarse_agenda()

        cmd_agenda.Connection = conn_agenda
        cmd_agenda.CommandType = CommandType.Text

        cmd_agenda.CommandText = "UPDATE conceptos SET concepto='" & concepto & "' WHERE idconcepto = " & idconcepto

        Try
            dr_agenda = cmd_agenda.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'buscar concepto
    Public Sub buscar_concepto(ByRef idconcepto As Integer)
        desconectado_agenda()
        conectarse_agenda()

        cmd_agenda.Connection = conn_agenda
        cmd_agenda.CommandType = CommandType.Text

        cmd_agenda.CommandText = "SELECT concepto FROM conceptos WHERE idconcepto=" & idconcepto

        Try
            dr_agenda = cmd_agenda.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub login_agenda_token(ByRef token As String, ByRef ci As String)
        desconectado_agenda()
        conectarse_agenda()

        cmd_agenda.Connection = conn_agenda
        cmd_agenda.CommandType = CommandType.Text

        cmd_agenda.CommandText = "INSERT INTO tokens (token, fechahora, idusuario, activo) VALUES ('" & token & "', NOW(), '" & ci & "', 1)"

        Try
            dr_agenda = cmd_agenda.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Module
