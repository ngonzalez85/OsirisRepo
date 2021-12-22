Imports MySql.Data.MySqlClient


Module conexionprueba
    'VARIABLES PARA APP.CONFIG
    Dim ip_servidor2 As String = My.Settings.ip_servidor
    Dim ftp As String = My.Settings.ftp
    Public serverdb2 As String = ip_servidor2
    'Public serverdb As String = "localhost"
    Public db2 As String = "bdisis"
    'Public db As String = "osiris"
    'Public db As String = "bdisistest"
    Public userdb2 As String = "liberty"
    Public passdb2 As String = "l1b3rty*"
    'Public portdb As String = "3337"
    Public portdb2 As String = "3306"
    'Public estudiosftp As String = "ftp://192.168.10.136:21/estudios/"
    'Public firmasftp As String = "ftp://192.168.10.136:21/firmas/"
    'Public logosftp As String = "ftp://192.168.10.136:21/logo_centros/"
    'Public informesftp As String = "ftp://192.168.10.136:21/informes/"
    'Public anterioresftp As String = "ftp://192.168.10.136:21/estudios_anteriores/"
    'Public adjuntosftp As String = "ftp://192.168.10.136:21/adjuntos/"
    'Public estudiosftp As String = ftp & "/pruebas/"
    Public estudiosftp2 As String = ftp & "/estudios/"
    Public firmasftp2 As String = ftp & "/firmas/"
    Public logosftp2 As String = ftp & "/logo_centros/"
    Public informesftp2 As String = ftp & "/informes/"
    Public anterioresftp2 As String = ftp & "/estudios_anteriores/"
    Public adjuntosftp2 As String = ftp & "/adjuntos/"

    Public cadenaConexion2 As String = "server=" & serverdb2 & ";database=" & db2 & ";user id=" & userdb2 & ";password=" & passdb2 & ";port=" & portdb2 & ""
    Public conn2 As New MySqlConnection(cadenaConexion2)
    Public cmd2 As New MySqlCommand
    Public dr2 As MySqlDataReader

    'Counsulta del centro
    Public Sub consultar_centro2(ByRef idcentro As String, ByRef formulario As String)
        conn.Close()
        inicioejecucion = DateTime.Now.ToString("hh:mm:ss")
        Console.WriteLine(inicioejecucion)

        conn2.Open()
        cmd2.Connection = conn2
        cmd2.CommandType = CommandType.Text

        cmd2.CommandText = "SELECT * FROM centros WHERE idcentro='" & idcentro & "'"

        Try
            dr2 = cmd2.ExecuteReader()
            finalejecucion = DateTime.Now.ToString("hh:mm:ss")
            funcionorigen = "consultar_centro2"
            Console.WriteLine(finalejecucion)

            '  Dim cadena As String
            ' cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            '   auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Auditar
    Public Sub auditar(ByRef formulario As String, ByRef tiempo As String, ByRef funcion As String)

        cmd2.Connection = conn2
        cmd2.CommandType = CommandType.Text

        cmd2.CommandText = "INSERT INTO auditoriaosiris.auditoriaosiris (idusuario,formulario,fecha,tiempo, funcion) VALUES (" & main_menu.txtidusuario.Text & "," & formulario & "," & ", NOW(), " & tiempo & "," & funcion & ")"

        Try
            dr2 = cmd2.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
