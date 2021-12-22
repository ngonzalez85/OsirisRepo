Imports System.IO
'Imports System.Runtime.InteropServices
Imports System.Drawing.Text
Imports System.Text
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class colaboraciones
    Private Sub colaboraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnimagen, "Ver estudio")
        Me.ToolTip1.SetToolTip(Me.btnverimagen, "Ver estudio")
        Me.ToolTip1.SetToolTip(Me.btnverinforme, "Ver informe")
        Me.ToolTip1.SetToolTip(Me.btn_listo, "Marcar como leido")

        Me.ToolTip1.IsBalloon = True

        llenar_datagridview_solicitudes()
        Dim row1 As Integer = dgSolicitudes.RowCount
        If row1 > 0 Then
            dgSolicitudes.Rows(0).Selected = False
        End If

        llenar_datagridview_pedidos()
        Dim row As Integer = dgPedidos.RowCount
        If row > 0 Then
            dgPedidos.Rows(0).Selected = False
        End If

        limpiar()

        Try
            cbcentro.Items.Clear()
            cbcentro2.Items.Clear()
            llenar_combobox_centrosXusuarios(cbcentro, main_menu.txtidusuario.Text)
            llenar_combobox_centrosXusuarios(cbcentro2, main_menu.txtidusuario.Text)
            cbcentro.SelectedItem = cbcentro.Items(0)
            cbcentro2.SelectedItem = cbcentro2.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim ubi_visor As String

    Public Sub llenar_datagridview_solicitudes()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,e.motivo,e.idcentro,e.idusuariomedico,e.idcentro_solicitante,e.reserva
            ,e.idpaciente,e.idcita,e.dicom,u3.nombre medicoayudante, u2.nombre medicosolicitante, 
            DATE(c.fechasolicitud)fecha, c.fecharespuesta, c.estado, c.idcolaboracion,
            c.idmedicosolicitante, c.comentariosolicitante,c.idmedicoayudante,c.comentariocolaborador
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario
            INNER JOIN colaboraciones c USING (idestudio) 
            INNER JOIN usuarios u2 ON c.idmedicosolicitante = u2.idusuario 
            INNER JOIN usuarios u3 ON c.idmedicoayudante = u3.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio 
            WHERE e.idcentro= '" & txtidcentro.Text & "' AND e.estado != 'FIRMADO' AND c.estado !='LEIDO' AND e.idusuariomedico = '" & main_menu.txtidusuario.Text & "' AND idestudio IN (SELECT idestudio FROM colaboraciones)"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgSolicitudes.DataSource = datos
            dgSolicitudes.DataMember = "estudios"
            retocar_columnas_solicitudes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_solicitudes()
        Try
            Me.dgSolicitudes.Columns(0).HeaderText = "ID"
            Me.dgSolicitudes.Columns(1).HeaderText = "PACIENTE"
            Me.dgSolicitudes.Columns(2).Visible = False
            Me.dgSolicitudes.Columns(3).HeaderText = "ESTUDIO REALIZADO"
            Me.dgSolicitudes.Columns(4).HeaderText = "T. ESTUDIO"
            Me.dgSolicitudes.Columns(5).Visible = False 'motivo
            Me.dgSolicitudes.Columns(6).Visible = False 'idcentro
            Me.dgSolicitudes.Columns(7).Visible = False 'idusauriomedico    
            Me.dgSolicitudes.Columns(8).Visible = False 'idcentro_solicitante
            Me.dgSolicitudes.Columns(9).Visible = False 'reserva
            Me.dgSolicitudes.Columns(10).Visible = False 'idpaciente
            Me.dgSolicitudes.Columns(11).Visible = False 'idcita
            Me.dgSolicitudes.Columns(12).Visible = False 'dicom
            Me.dgSolicitudes.Columns(13).HeaderText = "SOLICITADO A"
            Me.dgSolicitudes.Columns(14).Visible = False 'medicosolicitante
            Me.dgSolicitudes.Columns(15).HeaderText = "FECHA SOLICITUD"
            Me.dgSolicitudes.Columns(16).Visible = False ' fecharespuesta
            Me.dgSolicitudes.Columns(17).HeaderText = "ESTADO"
            Me.dgSolicitudes.Columns(18).Visible = False ' idcolaboracion
            Me.dgSolicitudes.Columns(19).Visible = False 'idmedicosolicitante
            Me.dgSolicitudes.Columns(20).Visible = False 'comentariosolicitante
            Me.dgSolicitudes.Columns(21).Visible = False 'idmedicoayudante
            Me.dgSolicitudes.Columns(22).Visible = False 'comentariocolaborador
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_pedidos()
        Console.WriteLine(txtidcentro2.Text)
        Console.WriteLine(main_menu.txtidusuario.Text)
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,e.motivo,e.idcentro,e.idusuariomedico,e.idcentro_solicitante,e.reserva
            ,e.idpaciente,e.idcita,e.dicom,u3.nombre medicoayudante, u2.nombre medicosolicitante, 
            DATE(c.fechasolicitud)fecha, c.fecharespuesta, c.estado, c.idcolaboracion,
            c.idmedicosolicitante, c.comentariosolicitante,c.idmedicoayudante,c.comentariocolaborador
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario
            INNER JOIN colaboraciones c USING (idestudio) 
            INNER JOIN usuarios u2 ON c.idmedicosolicitante = u2.idusuario 
            INNER JOIN usuarios u3 ON c.idmedicoayudante = u3.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio 
            WHERE e.idcentro= '" & txtidcentro2.Text & "' AND e.estado != 'FIRMADO' AND c.idmedicoayudante = '" & main_menu.txtidusuario.Text & "' AND idestudio IN (SELECT idestudio FROM colaboraciones)"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgPedidos.DataSource = datos
            dgPedidos.DataMember = "estudios"
            retocar_columnas_pedidos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_pedidos()
        Try
            Me.dgPedidos.Columns(0).HeaderText = "ID"
            Me.dgPedidos.Columns(1).HeaderText = "PACIENTE"
            Me.dgPedidos.Columns(2).Visible = False
            Me.dgPedidos.Columns(3).HeaderText = "ESTUDIO REALIZADO"
            Me.dgPedidos.Columns(4).HeaderText = "T. ESTUDIO"
            Me.dgPedidos.Columns(5).Visible = False 'motivo
            Me.dgPedidos.Columns(6).Visible = False 'idcentro
            Me.dgPedidos.Columns(7).Visible = False 'idusauriomedico    
            Me.dgPedidos.Columns(8).Visible = False 'idcentro_solicitante
            Me.dgPedidos.Columns(9).Visible = False 'reserva
            Me.dgPedidos.Columns(10).Visible = False 'idpaciente
            Me.dgPedidos.Columns(11).Visible = False 'idcita
            Me.dgPedidos.Columns(12).Visible = False 'dicom
            Me.dgPedidos.Columns(13).HeaderText = "SOLICITADO A"
            Me.dgPedidos.Columns(14).Visible = False 'medicosolicitante
            Me.dgPedidos.Columns(15).HeaderText = "FECHA SOLICITUD"
            Me.dgPedidos.Columns(16).Visible = False ' fecharespuesta
            Me.dgPedidos.Columns(17).HeaderText = "ESTADO"
            Me.dgPedidos.Columns(18).Visible = False ' idcolaboracion
            Me.dgPedidos.Columns(19).Visible = False 'idmedicosolicitante
            Me.dgPedidos.Columns(20).Visible = False 'comentariosolicitante
            Me.dgPedidos.Columns(21).Visible = False 'idmedicoayudante
            Me.dgPedidos.Columns(22).Visible = False 'comentariocolaborador
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cbcentro_TextChanged(sender As Object, e As EventArgs) Handles cbcentro.TextChanged

        If cbcentro.Text <> "" Then
            consultar_id_centro(cbcentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtidcentro_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro.TextChanged
        If txtidcentro.Text <> "" Then
            llenar_datagridview_solicitudes()
        End If
    End Sub

    Private Sub cbcentro2_TextChanged(sender As Object, e As EventArgs) Handles cbcentro2.TextChanged

        If cbcentro.Text <> "" Then
            consultar_id_centro(cbcentro.Text)
            If dr.Read Then
                txtidcentro2.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtidcentro2_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro2.TextChanged
        If txtidcentro2.Text <> "" Then
            llenar_datagridview_pedidos()
        End If
    End Sub


    Private Sub dgSolicitudes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSolicitudes.CellClick

        Dim row As Integer = dgSolicitudes.RowCount
        If row > 0 Then
            txtidestudio.Text = dgSolicitudes.SelectedCells.Item(0).Value
            lblpaciente.Text = dgSolicitudes.SelectedCells.Item(1).Value
            lblestudio.Text = dgSolicitudes.SelectedCells.Item(3).Value
            lblestado.Text = dgSolicitudes.SelectedCells.Item(17).Value
            txtmotivo.Text = dgSolicitudes.SelectedCells.Item(5).Value
            txtidcentro_solicitante.Text = dgSolicitudes.SelectedCells.Item(8).Value
            txtidmedicosoli.Text = dgSolicitudes.SelectedCells.Item(19).Value
            txtidmedicoayudante.Text = dgSolicitudes.SelectedCells.Item(21).Value
            txtreserva.Text = dgSolicitudes.SelectedCells.Item(9).Value
            txtidcita.Text = dgSolicitudes.SelectedCells.Item(11).Value
            txtdicom.Text = dgSolicitudes.SelectedCells.Item(12).Value
            lblmedicosoli.Text = dgSolicitudes.SelectedCells.Item(14).Value
            lblfechasoli.Text = dgSolicitudes.SelectedCells.Item(15).Value
            lblcomentariosoli.Text = dgSolicitudes.SelectedCells.Item(20).Value
            lblmedicoreci.Text = dgSolicitudes.SelectedCells.Item(13).Value
            lblcomentarioreci.Text = dgSolicitudes.SelectedCells.Item(22).Value
            txtidtemp.Text = dgSolicitudes.CurrentRow.Index
        End If
    End Sub


    Private Sub dgPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPedidos.CellClick

        Dim row As Integer = dgPedidos.RowCount
        If row > 0 Then
            txtidestudio.Text = dgPedidos.SelectedCells.Item(0).Value
            lblpaciente.Text = dgPedidos.SelectedCells.Item(1).Value
            lblestudio.Text = dgPedidos.SelectedCells.Item(3).Value
            lblestado.Text = dgPedidos.SelectedCells.Item(17).Value
            txtmotivo.Text = dgPedidos.SelectedCells.Item(5).Value
            txtidcentro_solicitante.Text = dgPedidos.SelectedCells.Item(8).Value
            txtidmedicosoli.Text = dgPedidos.SelectedCells.Item(19).Value
            txtidmedicoayudante.Text = dgPedidos.SelectedCells.Item(21).Value
            txtreserva.Text = dgPedidos.SelectedCells.Item(9).Value
            txtidcita.Text = dgPedidos.SelectedCells.Item(11).Value
            txtdicom.Text = dgPedidos.SelectedCells.Item(12).Value
            lblmedicosoli.Text = dgPedidos.SelectedCells.Item(14).Value
            lblfechasoli.Text = dgPedidos.SelectedCells.Item(15).Value
            lblcomentariosoli.Text = dgPedidos.SelectedCells.Item(20).Value
            lblmedicoreci.Text = dgPedidos.SelectedCells.Item(13).Value
            txtidtemp.Text = dgPedidos.CurrentRow.Index
        End If
    End Sub

    Private Sub limpiar()
        lblpaciente.Text = ""
        lblestudio.Text = ""
        lblfechasoli.Text = ""
        lblmedicosoli.Text = ""
        lblcomentariosoli.Text = ""
        lblcomentarioreci.Text = ""
        txtidestudio.Text = ""
        txtidtemp.Text = ""
        txtmotivo.Text = ""
        lblmedicoreci.Text = ""
        lblestado.Text = ""
        txtcomentario.Text = ""
    End Sub

    Private Sub btnimagen_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        descargar_estudios_anteriores()
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        guardar_colaboracion(lblmedicosoli.Text)
    End Sub

    Private Sub guardar_colaboracion(ByRef nombremedico As String)
        Try

            Dim conec As New MySqlConnection
            Dim myCommand As New MySqlCommand
            conec.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
            'myCommand.Connection = conec
            myCommand.Connection = conec 'Cadena de conexión.
            myCommand.CommandText = "UPDATE colaboraciones SET comentariocolaborador=?comentariocolaborador,estado=?estado,fecharespuesta=?fecharespuesta WHERE idestudio='" & txtidestudio.Text & "' AND idmedicoayudante=" & main_menu.txtidusuario.Text
            myCommand.Parameters.AddWithValue("?comentariocolaborador", txtcomentario.Text)
            myCommand.Parameters.AddWithValue("?fecharespuesta", Now())
            myCommand.Parameters.AddWithValue("?estado", "RESPONDIDO")
            Try
                conec.Open()
                myCommand.ExecuteNonQuery()
                ' Mensaje de Confirmacion
                MsgBox("Respondido a " & nombremedico & " correctamente!", MsgBoxStyle.Information, "Exito!")
                llenar_datagridview_pedidos()
                limpiar()
            Catch ex As Exception
                MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
            End Try
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try

    End Sub

    Private Sub descargar_estudios_anteriores()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_descargados\" & txtidestudio.Text & ".zip")) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                My.Computer.Network.DownloadFile(estudiosftp & txtidestudio.Text & ".zip", "C:\osiris\files\estudios_descargados\" & txtidestudio.Text & ".zip", "sadmin", "Sadmin7050*", False, 11000, True)
                verificar_estudio_anterior()
                'pbloading.Visible = False
                'lblestado.Visible = False
            Else
                verificar_estudio_anterior()
                'descarga.Close()
            End If
            'verificar_estudio_anterior()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Dim abrir As Integer = 1
    Private Sub verificar_estudio_anterior()
        Try

            Dim result As DialogResult
            result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If (result = DialogResult.Yes) Then
                ubi_visor = visorRadiant
            ElseIf result = DialogResult.No Then
                ubi_visor = visorMicro
            ElseIf result = DialogResult.Cancel Then
                abrir = 0
            End If

            If abrir = 1 Then
                If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & txtidestudio.Text & ".zip")) Then
                    MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & txtidestudio.Text & ".zip")
                End If
            Else
                abrir = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try
    End Sub

    Public ides As Integer
    Public Sub obtener_cuerpo()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT cuerpo FROM informes WHERE idestudio=" & ides)
            If tabla.Rows.Count <> 0 Then
                'Creo mi arreglo que almacenara los bytes del archivo
                Dim barrFile() As Byte = CType(tabla.Rows(0)(0), Byte())
                'Creo el archivo apartir de los bytes
                Using newFile As New FileStream(("C:\osiris\files\temp\temporal1.rtf"), FileMode.Create, FileAccess.Write)
                    newFile.Write(barrFile, 0, barrFile.Length)
                    newFile.Flush()
                    newFile.Close()
                End Using
                'Abro el archivo temporal en el RichTextBox
                rtb1.LoadFile("C:\osiris\files\temp\temporal1.rtf")


            End If
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub

    Private Function MuestraDB(ByVal Query As String)

        Dim conexion As New MySqlConnection
        'Dim myCommand As New MySqlCommand
        conexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        Dim ds As DataSet = New DataSet()
        Dim adaptador As MySqlDataAdapter
        Dim tabla As DataTable = New DataTable
        Dim constructor As MySqlCommandBuilder

        Try
            adaptador = New MySqlDataAdapter(Query, conexion)
            constructor = New MySqlCommandBuilder(adaptador) 'Se interpreta la consulta
            adaptador.Fill(tabla) 'Se guarda los registros obtenido en la variable tabla
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al leer la base de datos")
        End Try
        Return tabla
    End Function

    Private Sub btnverimagen_Click(sender As Object, e As EventArgs) Handles btnverimagen.Click
        descargar_estudios_anteriores()
    End Sub

    Private Sub txtidestudio_TextChanged(sender As Object, e As EventArgs) Handles txtidestudio.TextChanged
        If txtidestudio.Text <> "" Then
            btnverimagen.Enabled = True
            btnverinforme.Enabled = True
            btnimagen.Enabled = True
            btn_listo.Enabled = True
        Else
            btnverimagen.Enabled = False
            btnverinforme.Enabled = False
            btnimagen.Enabled = False
            btn_listo.Enabled = False
        End If

    End Sub

    Private Sub btnverinforme_Click(sender As Object, e As EventArgs) Handles btnverinforme.Click
        ver_informe()
    End Sub

    Private Sub ver_informe()
        If dgPedidos.Rows.Count > 0 Then
            ides = dgPedidos.SelectedCells.Item(0).Value
            obtener_cuerpo()

            buscar_informe(ides)

            If dr.Read Then
                vista_previa.cuerpo = Me.rtb1.Rtf
                vista_previa.cin = dr(4)
                vista_previa.edad = dr(6)
                vista_previa.fecha = dr(7)
                vista_previa.estudio = dr(8)
                vista_previa.motivo = dr(9)
                vista_previa.paciente = dr(5)
                vista_previa.idcentro = dr(2)
                vista_previa.idcentro_solicitante = dr(2)
                vista_previa.idmedico = dr(10)
                vista_previa.idestudio = dr(1)
                vista_previa.tecnico = dr(12)
                vista_previa.fecha_informe = dr(14)
                buscar_estudio(ides)
                If dr.Read Then
                    vista_previa.doctor_solicitante = dr(18)
                End If

                vista_previa.flag = 3
                'vista_previa.firma_informe = Me.firma_informe
                Try
                    vista_previa.Show()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Aqui el error")
                End Try
            End If
        End If
    End Sub

    Private Sub btn_listo_Click(sender As Object, e As EventArgs) Handles btn_listo.Click
        Try
            consultar_estudio_colab(txtidestudio.Text, txtidmedicoayudante.Text)

            If dr.Read Then
                MsgBox("Este estudio aun no esta respondido!", MsgBoxStyle.Information, "Atencion!")
            Else
                actualizar_estado_colab(txtidestudio.Text, txtidmedicoayudante.Text)
                MsgBox("Marcado como leido correctamente!", MsgBoxStyle.Information, "Exito!")
                llenar_datagridview_solicitudes()
            End If

        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try

    End Sub
End Class