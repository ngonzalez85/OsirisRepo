Imports MySql.Data.MySqlClient

Module conexion

    'VARIABLES PARA APP.CONFIG
    Dim ip_servidor As String = My.Settings.ip_servidor
    Dim ftp As String = My.Settings.ftp
    Public serverdb As String = ip_servidor
    Public visorMicro As String = My.Settings.visorMicro
    Public visorRadiant As String = My.Settings.visorRadiant
    ' Public serverdb As String = "localhost"
    Public db As String = "bdisis"
    'Public db As String = "osiris"
    'Public db As String = "bdisistest"
    Public userdb As String = "liberty"
    Public passdb As String = "l1b3rty*"
    'Public portdb As String = "3337"
    Public portdb As String = "3306"
    'Public estudiosftp As String = "ftp://192.168.10.136:21/estudios/"
    'Public firmasftp As String = "ftp://192.168.10.136:21/firmas/"
    'Public logosftp As String = "ftp://192.168.10.136:21/logo_centros/"
    'Public informesftp As String = "ftp://192.168.10.136:21/informes/"
    'Public anterioresftp As String = "ftp://192.168.10.136:21/estudios_anteriores/"
    'Public adjuntosftp As String = "ftp://192.168.10.136:21/adjuntos/"
    'Public estudiosftp As String = ftp & "/pruebas/"
    Public estudiosftp As String = ftp & "/estudios/"
    Public firmasftp As String = ftp & "/firmas/"
    Public logosftp As String = ftp & "/logo_centros/"
    Public informesftp As String = ftp & "/informes/"
    Public anterioresftp As String = ftp & "/estudios_anteriores/"
    Public modificadosftp As String = ftp & "/estudios_modificados/"
    Public adjuntosftp As String = ftp & "/adjuntos/"
    Public adjuntosagendaftp As String = "ftp://192.168.1.27/"

    Public cadenaConexion As String = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
    Public conn As New MySqlConnection(cadenaConexion)
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public usuario = main_menu.txtidusuario.Text
    Public inicioejecucion As DateTime
    Public finalejecucion As DateTime
    Public funcionorigen As String

    Public Sub conectarse()
        Try
            conn.Open()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "CALL definirusuario('" & main_menu.txtidusuario.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Falla en la conexión con la base de datos ☹")
        End Try
    End Sub

    Public Function desconectado()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    'Counsulta de usuario en login
    Public Sub consultar_usuario_login(ByRef cin As String, ByRef password As String, ByRef idcentro As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT u.nombre FROM usuarios u INNER JOIN usuarios_centros uc ON u.idusuario = uc.idusuario WHERE u.cin='" & cin & "'AND u.PASSWORD ='" & password & "' AND uc.idcentro = '" & idcentro & "' AND u.habilitado=1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de paciente
    Public Sub consultar_paciente(ByRef cin As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM pacientes WHERE cin='" & cin & "' AND habilitado= 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llenar combo procedimientos
    Public Sub llenar_combobox_proce(ByVal cb As ComboBox, ByRef proc As String)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("select procedimiento from procedimientos where procedimiento like '%" & proc & "%' ", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("procedimiento"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'llenar combo centros X usuarios
    Public Sub llenar_combobox_centrosXusuarios(ByVal cb As ComboBox, ByRef idusuario As String)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT uc.idusuario_centro,c.nombre 
            FROM centros c 
            INNER JOIN usuarios_centros uc ON c.idcentro = uc.idcentro 
            WHERE uc.idusuario = '" & idusuario & "'", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("nombre"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'llenar combo centros
    Public Sub llenar_combobox_centros(ByVal cb As ComboBox, ByRef idcentro As Integer)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT nombre from centros where habilitado=1", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("nombre"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'llenar combo centros
    Public Sub llenar_combobox_tipoarchivo(ByVal cb As ComboBox)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT tipoarchivo from tipoarchivos where habilitado=1", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("tipoarchivo"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Consultar id del centro
    Public Sub consultar_id_centro(ByRef centro As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select idcentro from centros where nombre='" & centro & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    'Consultar id del usuario
    Public Sub consultar_id_usuario(ByRef cin As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select idusuario from usuarios where cin='" & cin & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show(ex.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim ask As MsgBoxResult = MsgBox("Esta presentando problemas con la conexión, si está trabajando de forma externa podría verificar su conexión. Le gustaría verificar la conexión de su VPN volviendo a conectarse mediante el FortiClient VPN?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Shell("C:\Program Files\Fortinet\FortiClient\FortiClient.exe")
            End If
        End Try
    End Sub

    'Consultar id del usuario por nombre
    Public Sub consultar_id_usuario_nombre(ByRef nombre As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select idusuario from usuarios where nombre='" & nombre & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llenar combo medicos
    Public Sub llenar_combobox_tecnicos(ByVal cb As ComboBox, ByRef idcentro As String)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT u.nombre AS medico FROM usuarios u INNER JOIN usuarios_centros uc ON u.idusuario = uc.idusuario WHERE (u.idrol =7 OR u.idrol= 8) AND uc.idcentro='" & idcentro & "'", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("medico"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'llenar combo medicos
    Public Sub llenar_combobox_medicos(ByVal cb As ComboBox, ByRef idcentro As String)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT u.nombre AS medico 
            FROM usuarios u 
            INNER JOIN roles r USING(idrol)
            INNER JOIN usuarios_centros uc USING (idusuario)
            WHERE r.ismedico=1 AND uc.idcentro='" & idcentro & "'  
            GROUP BY medico
            ORDER BY u.nombre ASC", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("medico"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Consultar medico
    Public Sub consultar_medico(ByRef nombre As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from usuarios WHERE nombre = '" & nombre & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'verificar perfil medico
    Public Sub varificar_perfil_medico(ByRef idusuario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT u.nombre AS medico 
        FROM usuarios u 
        INNER JOIN roles r ON u.idrol = r.idrol 
        WHERE r.ismedico = 1 AND u.idusuario= '" & idusuario & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llenar combo prioridades
    Public Sub llenar_combobox_prioridades(ByVal cb As ComboBox)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT prioridad FROM prioridades", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("prioridad"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'llenar combo procedimientos
    Public Sub llenar_combobox_procedimientos(ByVal cb As ComboBox)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT * FROM procedimientos", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("procedimiento"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Consultar prioridad
    Public Sub consultar_prioridad(ByRef prioridad As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from prioridades WHERE prioridad = '" & prioridad & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar prioridad id
    Public Sub consultar_prioridad_id(ByRef idprioridad As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from prioridades WHERE idprioridad = '" & idprioridad & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llenar combo seguros
    Public Sub llenar_combobox_seguros(ByVal cb As ComboBox)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT seguro FROM seguros", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("seguro"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'llenar combo roles
    Public Sub llenar_combobox_roles(ByVal cb As ComboBox)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT rol FROM roles", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("rol"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Consultar id del seguro
    Public Sub consultar_id_seguro(ByRef seguro As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select idseguro from seguros where seguro='" & seguro & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llenar combo modalidades X centro
    Public Sub llenar_combobox_modalidades(ByVal cb As ComboBox, ByRef idcentro As String)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT modalidad FROM modalidades WHERE idcentro='" & idcentro & "'", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("modalidad"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Consultar modalidad X centro
    Public Sub consultar_modalidadXcentro(ByRef idcentro As String, ByRef modalidad As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM modalidades WHERE idcentro='" & idcentro & "' AND modalidad= '" & modalidad & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar modalidad
    Public Sub consultar_modalidad(ByRef idcentro As String, ByRef idmodalidad As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM modalidades WHERE idcentro='" & idcentro & "' AND idmodalidad= '" & idmodalidad & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar paciente X seguro
    Public Sub consultar_pacienteXseguro(ByRef cin As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT p.idpaciente, p.idseguro, s.seguro FROM pacientes p INNER JOIN seguros s ON p.idseguro = s.idseguro WHERE p.cin='" & cin & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar paciente
    Public Sub insertar_paciente(ByRef cin As String, ByRef nombre As String, ByRef apellido As String, ByRef edad As String, ByRef fecha_ingreso As String, ByRef sexo As String, ByRef idseguro As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO pacientes (cin,nombre,apellido,edad,fecha_ingreso,sexo,idseguro) VALUES ('" & cin & "','" & nombre & "','" & apellido & "','" & edad & "','" & fecha_ingreso & "','" & sexo & "','" & idseguro & "')"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar paciente
    Public Sub actualizar_paciente(ByRef cin As String, ByRef nombre As String, ByRef apellido As String, ByRef edad As String, ByRef sexo As String, ByRef idseguro As String, ByRef idpaciente As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE pacientes SET cin='" & cin & "',nombre='" & nombre & "',apellido='" & apellido & "',edad='" & edad & "',sexo='" & sexo & "',idseguro='" & idseguro & "' WHERE idpaciente = '" & idpaciente & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del ultimo estudio
    Public Sub consultar_ultimo_estudio()
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM estudios ORDER BY idestudio desc limit 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del ultimo estudio
    Public Sub consultar_ultimo_adjunto()
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM adjuntos ORDER BY idadjunto desc limit 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del ultimo informe
    Public Sub consultar_ultimo_informe(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM informes WHERE idestudio= " & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del adjunto 1
    Public Sub consultar_adjunto1(ByRef idestudio As Integer, ByRef formulario As String)
        desconectado()

        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT archivo,idadjunto,ord FROM adjuntos where idestudio=" & idestudio & " AND ord= 1"

        Try
            dr = cmd.ExecuteReader()
            'funcionorigen = "consultar_adjunto1"
            'finalejecucion = DateTime.Now.ToString
            '  inicioejecucion = DateTime.Now.ToString

            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del adjunto 2
    Public Sub consultar_adjunto2(ByRef idestudio As Integer, ByRef formulario As String)
        desconectado()
        '   inicioejecucion = DateTime.Now.ToLongTimeString
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT archivo,idadjunto,ord FROM adjuntos where idestudio=" & idestudio & " AND ord= 2"

        Try
            dr = cmd.ExecuteReader()
            'funcionorigen = "consultar_adjunto2"
            'finalejecucion = DateTime.Now.ToLongTimeString

            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del adjunto 3
    Public Sub consultar_adjunto3(ByRef idestudio As Integer, ByRef formulario As String)
        desconectado()
        '    inicioejecucion = DateTime.Now.ToLongTimeString
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT archivo,idadjunto,ord FROM adjuntos where idestudio=" & idestudio & " AND ord= 3"

        Try
            dr = cmd.ExecuteReader()
            'funcionorigen = "consultar_adjunto3"
            'finalejecucion = DateTime.Now.ToLongTimeString

            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del adjunto 4
    Public Sub consultar_adjunto4(ByRef idestudio As Integer, ByRef formulario As String)
        desconectado()
        '  inicioejecucion = DateTime.Now.ToLongTimeString
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT archivo,idadjunto,ord FROM adjuntos where idestudio=" & idestudio & " AND ord= 4"

        Try
            dr = cmd.ExecuteReader()
            'funcionorigen = "consultar_adjunto4"
            'finalejecucion = DateTime.Now.ToLongTimeString

            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del centro
    Public Sub consultar_centro(ByRef idcentro As String)
        desconectado()
        '   inicioejecucion = DateTime.Now.ToLongTimeString
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM centros WHERE idcentro='" & idcentro & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    'Counsulta del usuario_pc
    Public Sub consultar_usuario_pc(ByRef mipc As String, ByRef idusuario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT u.idusuario_pc,c.hostname,c.ubicacion_sala, c.ubi_visor FROM configuraciones_pc c INNER JOIN usuarios_pc u ON u.idconfiguraciones_pc = c.idconfiguraciones_pc WHERE c.hostname='" & mipc & "' AND u.idusuario='" & idusuario & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Consultar procedimiento
    Public Sub consultar_procedimiento(ByRef procedimiento As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from procedimientos WHERE procedimiento = '" & procedimiento & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar procedimiento id
    Public Sub consultar_procedimiento_id(ByRef idprocedimiento As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from procedimientos WHERE idprocedimiento = '" & idprocedimiento & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar procedimiento id
    Public Sub consultar_procedimiento_idrispy(ByRef idrispy As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from procedimientos WHERE idrispy = '" & idrispy & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Consultar procedimiento id
    Public Sub consultar_modalidad_idrispy(ByRef idrispy As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from modalidades WHERE idrispy =" & idrispy

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar estudio
    Public Sub insertar_estudio(ByRef idcentro As Integer, ByRef idusuario As Integer, ByRef idpaciente As Integer, ByRef idseguro As Integer, ByRef idmodalidad As Integer, ByRef idprioridad As Integer, ByRef idusuario_medico As Integer, ByRef idprocedimiento As Integer, ByRef estado As String, ByRef motivo As String, ByRef tecnico As String, ByRef idcentro_solicitante As Integer, ByRef doctor_solicitante As String, ByRef fecha_entrega As String, ByRef hora_entega As String, ByRef correo As String, ByRef cant As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO estudios (idcentro,idusuario,idpaciente,idseguro,idmodalidad,idprioridad,idusuariomedico,idprocedimiento,estado,motivo,fecha_hora,tecnico,idinforme,fecha_firma,idcentro_solicitante,doctor_solicitante,fecha_entrega,hora_entrega,correo, cantidad) VALUES (" & idcentro & "," & idusuario & "," & idpaciente & "," & idseguro & "," & idmodalidad & "," & idprioridad & "," & idusuario_medico & "," & idprocedimiento & ",'" & estado & "','" & motivo & "',CURRENT_TIMESTAMP,'" & tecnico & "',0,0," & idcentro_solicitante & ",'" & doctor_solicitante & "','" & fecha_entrega & "','" & hora_entega & "','" & correo & "', '" & cant & "')"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'modificar estudio
    Public Sub mod_estudio(ByRef idcentro As Integer, ByRef idusuario As Integer, ByRef idpaciente As Integer, ByRef idseguro As Integer, ByRef idmodalidad As Integer, ByRef idprioridad As Integer, ByRef idusuario_medico As Integer, ByRef idprocedimiento As Integer, ByRef estado As String, ByRef motivo As String, ByRef tecnico As String, ByRef idcentro_solicitante As Integer, ByRef doctor_solicitante As String, ByRef fecha_entrega As String, ByRef hora_entega As String, ByRef correo As String, ByRef idestudio As Integer, ByRef cant As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET idcentro='" & idcentro & "', idusuario ='" & idusuario & "',idpaciente='" & idpaciente & "',idseguro='" & idseguro & "',idmodalidad='" & idmodalidad & "',idprioridad='" & idprioridad & "',idusuariomedico='" & idusuario_medico & "',idprocedimiento='" & idprocedimiento & "',estado='" & estado & "',motivo='" & motivo & "',fecha_hora=CURRENT_TIMESTAMP ,tecnico='" & tecnico & "',idinforme=0,fecha_firma=0,idcentro_solicitante='" & idcentro_solicitante & "',doctor_solicitante='" & doctor_solicitante & "',fecha_entrega='" & fecha_entrega & "',hora_entrega='" & hora_entega & "',correo='" & correo & "' ,cantidad='" & cant & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar estudio agenda
    Public Sub insertar_estudio_agenda(ByRef idcentro As Integer, ByRef idusuario As Integer, ByRef idpaciente As Integer, ByRef idseguro As Integer, ByRef idmodalidad As Integer, ByRef idprioridad As Integer, ByRef idusuario_medico As Integer, ByRef idprocedimiento As Integer, ByRef estado As String, ByRef motivo As String, ByRef tecnico As String, ByRef idcentro_solicitante As Integer, ByRef doctor_solicitante As String, ByRef fecha_entrega As String, ByRef hora_entega As String, ByRef idcita As Integer, ByRef dicom As String, ByRef cant As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO estudios (idcentro,idusuario,idpaciente,idseguro,idmodalidad,idprioridad,idusuariomedico,idprocedimiento,estado,motivo,fecha_hora,tecnico,idinforme,fecha_firma,idcentro_solicitante,doctor_solicitante,fecha_entrega,hora_entrega,idcita,dicom, cantidad) VALUES (" & idcentro & "," & idusuario & "," & idpaciente & "," & idseguro & "," & idmodalidad & "," & idprioridad & "," & idusuario_medico & "," & idprocedimiento & ",'" & estado & "','" & motivo & "',CURRENT_TIMESTAMP,'" & tecnico & "',0,0," & idcentro_solicitante & ",'" & doctor_solicitante & "','" & fecha_entrega & "','" & hora_entega & "'," & idcita & ",'" & dicom & "', '" & cant & "')"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'modificar estudio agenda
    Public Sub modificar_estudio_agenda(ByRef idcentro As Integer, ByRef idusuario As Integer, ByRef idpaciente As Integer, ByRef idseguro As Integer, ByRef idmodalidad As Integer, ByRef idprioridad As Integer, ByRef idusuario_medico As Integer, ByRef idprocedimiento As Integer, ByRef estado As String, ByRef motivo As String, ByRef tecnico As String, ByRef idcentro_solicitante As Integer, ByRef doctor_solicitante As String, ByRef fecha_entrega As String, ByRef hora_entega As String, ByRef idcita As Integer, ByRef dicom As String, ByRef idestudio As Integer, ByRef cant As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET idcentro='" & idcentro & "', idusuario ='" & idusuario & "',idpaciente='" & idpaciente & "',idseguro='" & idseguro & "',idmodalidad='" & idmodalidad & "',idprioridad='" & idprioridad & "',idusuariomedico='" & idusuario_medico & "',idprocedimiento='" & idprocedimiento & "',estado='" & estado & "',motivo='" & motivo & "',fecha_hora=CURRENT_TIMESTAMP ,tecnico='" & tecnico & "',idinforme=0,fecha_firma=0,idcentro_solicitante='" & idcentro_solicitante & "',doctor_solicitante='" & doctor_solicitante & "',fecha_entrega='" & fecha_entrega & "',hora_entrega='" & hora_entega & "',idcita='" & idcita & "',dicom='" & dicom & "' ,cantidad='" & cant & "' WHERE idestudio = '" & idestudio & "'"
        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar ultimo estudio del paciente
    Public Sub actualizar_ultimo_estudio_paciente(ByRef idpaciente As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE pacientes SET fecha_ultimo_estudio=CURRENT_TIMESTAMP WHERE idpaciente = '" & idpaciente & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar estado del estudio
    Public Sub actualizar_estado_estudio(ByRef idestudio As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='INGRESADO' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar estado del estudio AGENDA
    Public Sub actualizar_estado_estudio_agenda(ByRef idestudio As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='ASIGNADO' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'actualizar estado del estudio
    Public Sub actualizar_estado_estudio_(ByRef idestudi As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        '  cmd.CommandText = "UPDATE estudios SET estado='EN PROCESO' WHERE idestudio ='" & idestudi & "' AND idestudio NOT IN (select idestudio from estudios where estado='FIRMADO' group by idestudio)"
        cmd.CommandText = "UPDATE estudios SET estado='EN PROCESO' WHERE idestudio ='" & idestudi & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar estado del estudio
    Public Sub actualizar_estado_estudio_asignado(ByRef idestudi As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        '  cmd.CommandText = "UPDATE estudios SET estado='EN PROCESO' WHERE idestudio ='" & idestudi & "' AND idestudio NOT IN (select idestudio from estudios where estado='FIRMADO' group by idestudio)"
        cmd.CommandText = "UPDATE estudios SET estado='ASIGNADO' WHERE idestudio ='" & idestudi & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar adjunto id
    Public Sub actualizar_adjunto(ByRef idestudio As String, ByRef idadjunto As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE adjuntos SET idestudio='" & idestudio & "' WHERE idestudio != 0 AND idadjunto = '" & idadjunto & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar archivo del informe
    Public Sub actualizar_archivo_informe(ByRef idinforme As String, ByRef archivo As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE informes SET archivo='" & archivo & "' WHERE idinforme = '" & idinforme & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'asignar estudio
    Public Sub asignar_estudio(ByRef idestudio As String, ByRef idusuariomedico As String, ByRef reserva As String, ByRef idprioridad As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='ASIGNADO', idusuariomedico = '" & idusuariomedico & "',idprioridad= '" & idprioridad & "' ,reserva= '" & reserva & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'reasignar estudio
    Public Sub reasignar_estudio(ByRef idestudio As String, ByRef idusuariomedico As String, ByRef reserva As String, ByRef idinforme As String, ByRef idprioridad As Integer)
        desconectado()
        conectarse()


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='EN PROCESO', idusuariomedico = '" & idusuariomedico & "',reserva= '" & reserva & "',idprioridad= '" & idprioridad & "',idinforme='" & idinforme & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'reasignar estudio
    Public Sub reasignar_informe(ByRef idestudio As String, ByRef idusuariomedico As String)
        desconectado()
        conectarse()


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE informes SET idmedico='" & idusuariomedico & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'verificar estado de estudio
    Public Sub verificar_estado_estudio(ByRef idestudio As String, ByRef idmedico As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM estudios WHERE idestudio= '" & idestudio & "' AND estado='ASIGNADO' AND reserva <> '" & idmedico & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'verificar si estado de estudio esta firmado
    Public Sub verificar_estado_firma(ByRef idestudio As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT idestudio FROM estudios WHERE idestudio= '" & idestudio & "' AND idestudio IN (SELECT idestudio FROM estudios WHERE estado='FIRMADO' GROUP BY idestudio)"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'reservar estudio
    Public Sub reservar_estudio(ByRef idestudio As String, ByRef idusuariomedico As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='ASIGNADO', idusuariomedico = '" & idusuariomedico & "', reserva='" & idusuariomedico & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'firmar estudio
    Public Sub firmar_estudio(ByRef idestudio As Integer, ByRef idinforme As Integer, ByRef idmedico As Integer, ByRef formulario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='FIRMADO',fecha_firma=CURRENT_DATE,idinforme= '" & idinforme & "', idusuariomedico='" & idmedico & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

            'finalejecucion = DateTime.Now.ToLongTimeString
            'funcionorigen = "firmar_estudio"
            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'firmar estudio
    Public Sub actualizarmedicoinforme(ByRef idmedico As Integer, ByRef idinforme As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE informes SET idmedico='" & idmedico & "' WHERE idinforme = '" & idinforme & "'"

        Try
            dr = cmd.ExecuteReader()

            'finalejecucion = DateTime.Now.ToLongTimeString
            'funcionorigen = "firmar_estudio"
            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'visualizar firma
    Public Sub visualizar_firma(ByRef idestudio As Integer, ByRef respuesta As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE informes SET firma = '" & respuesta & "' WHERE idestudio= " & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'insertar informe
    Public Sub insertar_informe(ByRef idestudio As String, ByRef ubi_logo_cs As String, ByRef ubi_logo_ce As String, ByRef cin As String, ByRef paciente As String, ByRef edad As Integer, ByRef fecha_nac As String, ByRef fecha_estudio As String, ByRef estudio_realizado As String, ByRef motivo As String, ByRef idmedico As Integer, ByRef ubi_firma_medico As String, ByRef cuerpo As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO informes (idestudio,ubi_logo_cs,ubi_logo_ce,cin,paciente,edad,fecha_nac,fecha_estudio,estudio_realizado,motivo,idmedico,ubi_firma_medico,cuerpo) VALUES ('" & idestudio & "','" & ubi_logo_cs & "','" & ubi_logo_ce & "','" & cin & "','" & paciente & "','" & edad & "','" & fecha_nac & "','" & fecha_estudio & "','" & estudio_realizado & "','" & motivo & "','" & idmedico & "','" & ubi_firma_medico & "','" & cuerpo & "')"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar informe
    Public Sub consultar_informe(ByRef idinforme As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from informes WHERE idinforme = '" & idinforme & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar informe si existe estudio
    Public Sub consultar_informe_estudio(ByRef idestudio As String, ByRef formulario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from informes WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()
            'finalejecucion = DateTime.Now.ToLongTimeString
            'funcionorigen = "consultar_informe_estudio"
            'Dim cadena As String
            'Dim resta As String
            'cadena = finalejecucion - inicioejecucion
            'resta = cadena.Substring(0, 5)
            'auditar(formulario, cadena, funcionorigen)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar tipo estudio
    Public Sub consultar_tipoestudio(ByRef idtipoestudio As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from tipo_estudios WHERE idtipoestudio = '" & idtipoestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de usuario
    Public Sub consultar_usuario(ByRef cin As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM usuarios WHERE cin='" & cin & "' AND habilitado= 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de usuario po id
    Public Sub consultar_usuario_id(ByRef id As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM usuarios WHERE idusuario='" & id & "' AND habilitado= 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Counsulta de roles
    Public Sub consultar_rol(ByRef idrol As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM roles WHERE idrol=" & idrol

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de roles
    Public Sub consultar_roles(ByRef rol As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM roles WHERE rol=  '" & rol & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de roles
    Public Sub consultar_roles_usuarios(ByRef idusuario As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT r.rol,r.idrol FROM roles r INNER JOIN usuarios u ON r.idrol=u.idrol WHERE u.idusuario=" & idusuario

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta permisos por roles
    Public Sub consultar_permisos(ByRef idrol As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM permisos WHERE idrol=" & idrol

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar centros X usuarios
    Public Sub insertar_centro_usuario(ByRef idusuario As Integer, ByRef idcentro As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO usuarios_centros (idusuario,idcentro) VALUES (" & idusuario & "," & idcentro & ")"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar centros X procedimientos
    Public Sub insertar_centro_procedimiento(ByRef idprocedimiento As Integer, ByRef idcentro As Integer, ByRef precio_informe As Integer, ByRef comision_us As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO procedimientos_centros (idprocedimiento,idcentro,precio_informe,comision_us) VALUES (" & idprocedimiento & "," & idcentro & "," & precio_informe & "," & comision_us & ")"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'quitar centros X usuarios
    Public Sub quitar_centro_usuario(ByRef idusuario_centro As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from usuarios_centros WHERE idusuario_centro=" & idusuario_centro & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'quitar centros X usuarios
    Public Sub quitar_centro_procedimiento(ByRef idprocedimiento_centro As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from procedimientos_centros WHERE idprocedimiento_centro=" & idprocedimiento_centro & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'quitar plantilla
    Public Sub quitar_plantilla(ByRef idplantilla As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from plantillas WHERE idplantilla=" & idplantilla & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'quitar frase
    Public Sub quitar_frase(ByRef idfrase As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from frases WHERE idfrase=" & idfrase & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'quitar estudio anterior
    Public Sub quitar_anterior(ByRef idantecedente As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from antecedentes WHERE idantecedente=" & idantecedente & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'quitar estudio anterior
    Public Sub quitar_modificado(ByRef idmodificado As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from estudios_modificados WHERE idmodificado=" & idmodificado & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'consultar cantidad informes mes
    Public Sub consultar_informes_mes(ByRef idusuario As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT COUNT(idinforme) AS cant_informe FROM informes WHERE MONTH(fecha_informe)=MONTH(CURRENT_DATE()) AND YEAR(fecha_informe)=YEAR(CURRENT_DATE()) AND idmedico =" & idusuario

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'consultar cantidad informes
    Public Sub consultar_informes(ByRef idusuario As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT COUNT(idinforme) AS cant_informe FROM informes where idmedico =" & idusuario

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llenar combo tipo estudio
    Public Sub llenar_combobox_tipo_estudio(ByVal cb As ComboBox)
        Try
            desconectado()
            conectarse()
            cmd = New MySqlCommand("SELECT tipoestudio FROM tipo_estudios where habilitado=1", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cb.Items.Add(dr.Item("tipoestudio"))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Consultar id del tipo de estudio
    Public Sub consultar_id_tipoestudio(ByRef tipoestudio As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select idtipoestudio from tipo_estudios where tipoestudio='" & tipoestudio & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Consultar id del tipo de estudio
    Public Sub consultar_CentreoE(ByRef idcentro As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select logo from centros where idcentro='" & idcentro & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de plantilla
    Public Sub consultar_plantilla(ByRef descripcion As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM plantillas WHERE descripcion='" & descripcion & "' AND idusuario = '" & main_menu.txtidusuario.Text & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Counsulta de plantilla
    Public Sub consultar_frase(ByRef nombre As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM frases WHERE nombre='" & nombre & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'buscar estudio
    Public Sub buscar_estudio(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM estudios WHERE idestudio = " & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'buscar informe segun estudio
    Public Sub buscar_informe(ByRef idinforme As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT i.*, CONCAT(apellido, ' ', nombre) paciente, pr.procedimiento
                            FROM informes i
                            JOIN estudios e USING(idestudio)
                            JOIN pacientes p USING (idpaciente)
                            JOIN procedimientos pr USING (idprocedimiento)
                            WHERE idestudio = " & idinforme

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'buscar paciente
    Public Sub buscar_paciente(ByRef idpaciente As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM pacientes WHERE idpaciente = " & idpaciente

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar estudio
    Public Sub actualizar_estudio(ByRef idestudio As String, ByRef idinforme As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='FIRMADO',fecha_firma=CURRENT_TIMESTAMP,idinforme=" & idinforme & " WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'modificar estudio
    Public Sub modificarEstudio(ByRef idcentro As Integer, ByRef idpaciente As Integer, ByRef idseguro As Integer, ByRef idmodalidad As Integer, ByRef idprioridad As Integer, ByRef idprocedimiento As Integer, ByRef motivo As String, ByRef doctor_solicitante As String, ByRef idestudio As Integer, ByRef estado As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET idcentro=" & idcentro & ", idpaciente=" & idpaciente & ", idseguro=" & idseguro & ", idmodalidad=" & idmodalidad & ", idprioridad=" & idprioridad & ", idprocedimiento=" & idprocedimiento & ", motivo='" & motivo & "', doctor_solicitante='" & doctor_solicitante & "' , estado='" & estado & "' WHERE idestudio =" & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'consultar informe
    Public Sub consultarInforme(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from informes WHERE idestudio =" & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'modificar informe
    Public Sub modificarInforme(ByRef idestudio As Integer, ByRef idcentro_solicitante As Integer, ByRef cin As String, ByRef paciente As String, ByRef edad As Integer, ByRef estudio_realizado As String, ByRef motivo As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE informes SET idcentro_solicitante=" & idcentro_solicitante & ", cin='" & cin & "', paciente='" & paciente & "', edad=" & edad & ", estudio_realizado='" & estudio_realizado & "', motivo='" & motivo & "' WHERE idestudio =" & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'modificar estudio estado
    Public Sub modificarEstado(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='ASIGNADO' WHERE idestudio =" & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'modificar estudio estado
    Public Sub modificarEstadofirma(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET estado='EN PROCESO' WHERE idestudio =" & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar seguro
    Public Sub consultar_seguro(ByRef idseguro As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from seguros where idseguro='" & idseguro & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Verificar existencia de paciente
    Public Sub verificar_paciente(ByRef cin As String, ByRef nombre As String, ByRef apellido As String, ByRef edad As String, ByRef sexo As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM pacientes WHERE cin='" & cin & "' AND nombre='" & nombre & "' AND apellido='" & apellido & "' AND edad='" & edad & "' AND sexo='" & sexo & "' AND habilitado= 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'obtener id de paciente
    Public Sub id_paciente(ByRef cin As String, ByRef nombre As String, ByRef apellido As String, ByRef edad As String, ByRef sexo As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT idpaciente FROM pacientes WHERE cin='" & cin & "' AND '" & nombre & "' AND '" & apellido & "' AND '" & edad & "' AND '" & sexo & "' AND habilitado= 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Verificar existencia de estudio x paciente
    Public Sub verificar_estudio_paciente(ByRef idpaciente As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM estudios WHERE idpaciente='" & idpaciente

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'quitar estudio
    Public Sub quitar_estudio(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from estudios WHERE idestudio=" & idestudio & ""

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta del ultimo paciente
    Public Sub consultar_ultimo_paciente()
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM pacientes ORDER BY idpaciente desc limit 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar orden
    Public Sub consultar_ord(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT ord FROM antecedentes WHERE idestudio='" & idestudio & "' ORDER BY ord DESC LIMIT 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar orden MODIFICADO
    Public Sub consultar_orden2(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT ord FROM estudios_modificados WHERE idestudio='" & idestudio & "' ORDER BY ord DESC LIMIT 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Consultar orden imagen
    Public Sub consultar_ord_img(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT ord FROM adjuntos WHERE idestudio='" & idestudio & "' ORDER BY ord DESC LIMIT 1"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar antecedente
    Public Sub insertar_antecedente(ByRef ord As String, ByRef idestudio As String, ByRef archivo As String, ByRef obs As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO antecedentes (ord,idestudio,archivo,obs) VALUES ('" & ord & "','" & idestudio & "','" & archivo & "','" & obs & "')"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'insertar modificado
    Public Sub insertar_modificado(ByRef ord As String, ByRef idestudio As String, ByRef archivo As String, ByRef obs As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO estudios_modificados (ord,idestudio,archivo,obs) VALUES ('" & ord & "','" & idestudio & "','" & archivo & "','" & obs & "')"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar configuracion
    Public Sub actualizar_configuracion_usuario(ByRef visor_auto As String, ByRef firma_informe As String, ByRef idusuario As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE usuarios SET visor_auto='" & visor_auto & "',firma_informe='" & firma_informe & "' WHERE idusuario = " & idusuario

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Counsulta de usuario medico
    Public Sub consultar_usuario_medico(ByRef idusuario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT visor_auto,firma_informe,formulario_inicio FROM usuarios WHERE idusuario='" & idusuario & "' AND (idrol= 3 OR idrol=6)"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de usuario medico
    Public Sub consultar_usuariomedico(ByRef idusuario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM usuarios WHERE idusuario='" & idusuario & "' AND (idrol= 3 OR idrol=6)"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de usuario medico
    Public Sub consultar_perfilmedico()
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM usuarios WHERE nombre='DOCTOR'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de usuario medico
    Public Sub consultar_usuariotecnico(ByRef idusuario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM usuarios WHERE idusuario='" & idusuario & "' AND idrol= 7"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Counsulta de usuario tecnico
    Public Sub consultar_tecnico(ByRef tecnico As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM usuarios WHERE nombre='" & tecnico & "' AND idrol= 7"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub consultar_usuario_(ByRef idusuario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT visor_auto,firma_informe,formulario_inicio FROM usuarios WHERE idusuario='" & idusuario & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'comprobar permiso para firmar
    Public Sub comprobar_permiso_firma(ByRef idestudio As String, ByRef idmedico As String, ByRef formulario As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM estudios WHERE idestudio='" & idestudio & "' AND idusuariomedico = '" & idmedico & "'"

        Try
            dr = cmd.ExecuteReader()
            'finalejecucion = DateTime.Now.ToLongTimeString
            'funcionorigen = "comprobar_permiso_firma"
            'Dim cadena As String
            'cadena = String.Format("{0:t0}", (finalejecucion - inicioejecucion))
            'auditar(formulario, cadena, funcionorigen)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Dim ask As MsgBoxResult = MsgBox("Esta presentando problemas con la conexión, si está trabajando de forma externa podría verificar su conexión. Le gustaría verificar la conexión de su VPN volviendo a conectarse mediante el FortiClient VPN?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                Shell("C:\Program Files\Fortinet\FortiClient\FortiClient.exe")
            End If
        End Try
    End Sub

    'Sincronizar procedimiento
    Public Sub sincronizar_procedimiento(ByRef idprocedimiento As Integer, ByRef idrispy As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE procedimientos SET idrispy=" & idrispy & " WHERE idprocedimiento = " & idprocedimiento

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Eliminar procedimiento
    Public Sub eliminar_procedimiento(ByRef idprocedimiento As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from procedimientos WHERE idprocedimiento=" & idprocedimiento

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Eliminar temporal
    Public Sub eliminar_temporal(ByRef idestudio As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "DELETE from estudios WHERE idestudio=" & idestudio

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Eliminar procedimiento
    Public Sub llamar_procedimiento()
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "CALL calcular_honorario()"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar clave usuario
    Public Sub actualizar_clave(ByRef pass As String, ByRef idusuario As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE usuarios SET password='" & pass & "' WHERE idusuario = " & idusuario

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub consultar_estudio_existe(ByRef idpaciente As Integer, ByRef idmodalidad As Integer, ByRef idprocedimiento As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT idestudio, DATE(fecha_hora)fecha FROM estudios WHERE idpaciente='" & idpaciente & "' AND idmodalidad='" & idmodalidad & "' AND idprocedimiento='" & idprocedimiento & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'consultar oermiso de subir duplicado
    Public Sub consultar_permiso_estudio(ByRef idrol As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT subir_imagen FROM permisos WHERE idrol='" & idrol & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub consultar_cita_existe(ByRef idcita As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT idestudio, DATE(fecha_hora)fecha FROM estudios WHERE idcita='" & idcita & "' "

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'modificar fecha de entrega
    Public Sub modificar_fechaentrega(ByRef idestudio As Integer, ByRef fechaentrega As String, ByRef horaentrega As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE estudios SET fecha_entrega= '" & fechaentrega & "' ,hora_entrega= '" & horaentrega & "' WHERE idestudio = '" & idestudio & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualizar colaboracion a leido
    Public Sub actualizar_estado_colab(ByRef idestudio As String, ByRef idmedicoayudante As String)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE colaboraciones SET estado='LEIDO' WHERE idestudio = '" & idestudio & "' AND idmedicoayudante= '" & idmedicoayudante & "'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub consultar_estudio_colab(ByRef idestudio As Integer, ByRef idmedicoayudante As Integer)
        desconectado()
        conectarse()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT idestudio FROM colaboraciones 
        WHERE idestudio='" & idestudio & "' AND idmedicoayudante='" & idmedicoayudante & "' AND estado = 'SOLICITADO'"

        Try
            dr = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub autoCompletarPaciente(ByVal campoTexto As TextBox)
        desconectado()
        conectarse()
        Try

            cmd = New MySqlCommand("SELECT CONCAT(apellido,' ',nombre) as paciente FROM pacientes", conn)
            dr = cmd.ExecuteReader()

            While dr.Read
                campoTexto.AutoCompleteCustomSource.Add(dr.Item("paciente"))
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub autoCompletarMedico(ByVal campoTexto As TextBox)
        desconectado()
        conectarse()

        Try
            cmd = New MySqlCommand("SELECT u.nombre FROM usuarios u INNER JOIN roles r ON u.idrol=r.idrol WHERE  u.habilitado=1 AND r.ismedico=1 ", conn)
            dr = cmd.ExecuteReader()
            While dr.Read
                campoTexto.AutoCompleteCustomSource.Add(dr.Item("nombre"))
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
