
Imports MySql.Data.MySqlClient
Module conn_autocompletar
    Public conexiones As MySqlConnection
    Public enunciado As MySqlCommand
    Public respuesta As MySqlDataReader
    Public adaptador As MySqlDataAdapter


    'FUNCION DE CONEXION A LA BASE DE DATOS'
    '***********************************************************************************************************************************************'

    Sub abrir()
        Try
            conexiones = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            conexiones.Open()
            'conn.Open()
            'MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            'MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexiones.Close() 'Cierra la conexion'
            'conn.Close()
        End Try
    End Sub

    'Llena un texbox con opciones de autocompletar'
    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)

        Try
            enunciado = New MySqlCommand("select procedimiento from procedimientos", conexiones)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("procedimiento"))
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub autoCompletarUsuario(ByVal campoTexto As TextBox)

        Try
            enunciado = New MySqlCommand("select nombre from usuarios", conexiones)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombre"))
            End While
            respuesta.Close()

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Sub autoCompletarPlantilla(ByVal campoTexto As TextBox, ByRef idusuario As String)

        Try
            enunciado = New MySqlCommand("select descripcion from plantillas WHERE idusuario='" & idusuario & "'", conexiones)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("descripcion"))
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Sub autoCompletarMedico(ByVal campoTexto As TextBox)

    '    Try
    '        enunciado = New MySqlCommand("SELECT u.nombre FROM usuarios u INNER JOIN roles r ON u.idrol=r.idrol WHERE  u.habilitado=1 AND (r.rol='MEDICO' OR r.rol='MEDICO ADMINISTRADOR')", conexiones)
    '        respuesta = enunciado.ExecuteReader()
    '        While respuesta.Read
    '            campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombre"))
    '        End While
    '        respuesta.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub

    'Sub autoCompletarPaciente(ByVal campoTexto As TextBox)

    '    Try
    '        enunciado = New MySqlCommand("SELECT CONCAT(apellido,' ',nombre) as paciente FROM pacientes", conexiones)
    '        respuesta = enunciado.ExecuteReader()
    '        While respuesta.Read
    '            campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("paciente"))
    '        End While
    '        respuesta.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub

End Module
