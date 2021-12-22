Imports MySql.Data.MySqlClient
Imports System.IO
Public Class lista_informes
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    Public ci As String
    Public paciente As String
    Public idmedico As String
    Public desde As String
    Public hasta As String
    Public fecha As String

    Dim idestudio As String
    Dim nom_paciente As String
    Dim formulario As String = "lista_informes"

    Public Sub llenar_datagridview_estudios_ci()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio WHERE e.idcentro= '" & main_menu.txtidcentro.Text & "' AND e.estado = 'FIRMADO' AND p.cin = '" & ci & "' ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_estudios_paciente()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio 
            WHERE e.idcentro= '" & main_menu.txtidcentro.Text & "' AND e.estado = 'FIRMADO' AND  TRIM(CONCAT(p.apellido, ' ', p.nombre)) LIKE '" & paciente & "%' 
            ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_estudios_medico()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio WHERE e.idcentro= '" & main_menu.txtidcentro.Text & "' AND e.estado = 'FIRMADO' AND e.idusuariomedico='" & idmedico & "' ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_estudios_rango()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio WHERE e.idcentro= '" & main_menu.txtidcentro.Text & "' AND e.estado = 'FIRMADO' AND e.fecha_firma BETWEEN '" & desde & "' AND '" & hasta & "' ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_estudios_fecha()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio WHERE e.idcentro= '" & main_menu.txtidcentro.Text & "' AND e.estado = 'FIRMADO' AND e.fecha_firma= '" & fecha & "' ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "PACIENTE"
            Me.dgContenedor.Columns(1).Width = 290
            Me.dgContenedor.Columns(2).HeaderText = "EDAD"
            Me.dgContenedor.Columns(2).Width = 50
            Me.dgContenedor.Columns(3).HeaderText = "ESTUDIO REALIZADO"
            Me.dgContenedor.Columns(3).Width = 300
            Me.dgContenedor.Columns(4).HeaderText = "T. ESTUDIO"
            Me.dgContenedor.Columns(4).Width = 110
            Me.dgContenedor.Columns(5).HeaderText = "PRIORIDAD"
            Me.dgContenedor.Columns(5).Width = 90
            Me.dgContenedor.Columns(6).HeaderText = "F. ESTUDIO"
            Me.dgContenedor.Columns(6).Width = 130
            Me.dgContenedor.Columns(7).HeaderText = "ESTADO"
            Me.dgContenedor.Columns(7).Width = 80
            Me.dgContenedor.Columns(8).HeaderText = "MEDICO ASIGNADO"
            Me.dgContenedor.Columns(8).Width = 290
            Me.dgContenedor.Columns(9).Visible = False
            Me.dgContenedor.Columns(10).Visible = False
            Me.dgContenedor.Columns(11).Visible = False
            Me.dgContenedor.Columns(12).Visible = False
            Me.dgContenedor.Columns(13).Visible = False
            Me.dgContenedor.Columns(14).Visible = False
            Me.dgContenedor.Columns(15).HeaderText = "F. FIRMA"
            Me.dgContenedor.Columns(15).Width = 130
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lista_informes_Load(sender As Object, e As EventArgs) Handles Me.Load
        If txtflag.Text = 1 Then
            llenar_datagridview_estudios_ci()
        ElseIf txtflag.Text = 2 Then
            llenar_datagridview_estudios_paciente()
        ElseIf txtflag.Text = 3 Then
            llenar_datagridview_estudios_medico()
        ElseIf txtflag.Text = 4 Then
            llenar_datagridview_estudios_rango()
        ElseIf txtflag.Text = 5 Then
            llenar_datagridview_estudios_fecha()
        End If
    End Sub

    Private Sub abrir_pdf()
        Try
            My.Computer.Network.DownloadFile(informesftp & idestudio & " - " & nom_paciente & ".pdf", "C:\osiris\files\informes_descargados\" & idestudio & " - " & nom_paciente & ".pdf", "sadmin", "Sadmin7050*", False, 9000, True)
            Dim myProcess As New Process
            Dim PathShell As String = "C:\osiris\files\informes_descargados\" & idestudio & " - " & nom_paciente & ".pdf"

            myProcess.StartInfo.FileName = PathShell
            myProcess.StartInfo.UseShellExecute = True
            myProcess.StartInfo.RedirectStandardOutput = False
            myProcess.Start()
            myProcess.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Informe Nro " & idestudio & " - " & nom_paciente & ".pdf no encontrado, comuniquese con el soporte técnico")
        End Try

    End Sub

    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        'If dgContenedor.Rows.Count > 0 Then
        'idestudio = dgContenedor.SelectedCells.Item(0).Value
        'nom_paciente = dgContenedor.SelectedCells.Item(1).Value
        'abrir_pdf()
        'End If

        If dgContenedor.Rows.Count > 0 Then
            txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
            descargar_estudios_anteriores()
        End If

    End Sub

    Private cellValue As String = String.Empty

    Private Sub dgContenedor_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgContenedor.CellMouseClick
        If e.Button <> MouseButtons.Right Then Return
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
        cellValue = dgContenedor(e.ColumnIndex, e.RowIndex).Value.ToString()
        ContextMenuStrip1.Show(MousePosition)
    End Sub

    Dim firma_informe As String
    Dim idmedico_firmante As Integer

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "informe"
                If dgContenedor.Rows.Count > 0 Then
                    idestudio = dgContenedor.SelectedCells.Item(0).Value
                    nom_paciente = dgContenedor.SelectedCells.Item(1).Value
                    abrir_pdf()
                End If
            Case "reimprimir"

                ides = dgContenedor.SelectedCells.Item(0).Value
                idmedico_firmante = dgContenedor.SelectedCells.Item(12).Value
                obtener_cuerpo()
                'firma de informe
                consultar_usuario_id(idmedico_firmante)
                If dr.Read Then
                    firma_informe = dr(15)
                End If

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
                    vista_previa.firma_informe = Me.firma_informe

                    vista_previa.Show()
                End If



            Case "ver_imagen"
                If dgContenedor.Rows.Count > 0 Then
                    txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
                    descargar_estudios_anteriores()
                End If

        End Select
    End Sub

    Private Sub descargar_estudios_anteriores()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip")) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                My.Computer.Network.DownloadFile(estudiosftp & txtprueba.Text & ".zip", "C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip", "sadmin", "Sadmin7050*", False, 11000, True)
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

    'Dim ubi_visor As String
    Private Sub verificar_estudio_anterior()
        Try
            consultar_centro(main_menu.txtidcentro.Text)
            If dr.Read Then

                ubi_visor = dr(16)
            End If

            If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip")) Then
                MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

    Dim directorio As String
    Dim carpeta_estudios_subidos As String
    Dim ubi_visor As String
    Private Sub verificar_imagen()
        Try
            consultar_centro(main_menu.txtidcentro.Text)
            If dr.Read Then
                directorio = dr(10)
                carpeta_estudios_subidos = dr(11)
                Dim result As DialogResult
                result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                If (result = DialogResult.Yes) Then
                    ubi_visor = visorRadiant
                Else
                    ubi_visor = visorMicro
                End If
            End If

            idestudio = dgContenedor.SelectedCells.Item(0).Value
            Dim imagen As String = idestudio & ".zip"

            If (Not System.IO.File.Exists(carpeta_estudios_subidos & "\" & imagen)) Then
                MessageBox.Show("No se encuentra el archivo de imagenes del estudio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (Not System.IO.File.Exists(directorio & "\" & imagen)) Then
                My.Computer.FileSystem.CopyFile(carpeta_estudios_subidos & "\" & imagen, directorio & "\" & imagen, overwrite:=False)
                Shell(ubi_visor & " " & carpeta_estudios_subidos & "\" & imagen)
            Else
                Shell(ubi_visor & " " & carpeta_estudios_subidos & "\" & imagen)
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

    'Private Sub generar_reporte()


    'vista_previa.Show()
    'End Sub
End Class