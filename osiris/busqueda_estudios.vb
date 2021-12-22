Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.IO
Public Class busqueda_estudios
    Private Sub busqueda_estudios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar lista")
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir reporte")
        Me.ToolTip1.IsBalloon = True

        Dim inicio As New DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day)
        inicio = inicio.AddDays(-2)
        txtdesde.Value = inicio

        Try
            llenar_combobox_tipo_estudio(cbEstudio)
            cbEstudio.SelectedItem = cbEstudio.Items(0)
            cbCentro_usuario.Items.Clear()
            llenar_combobox_centrosXusuarios(cbCentro_usuario, main_menu.txtidusuario.Text)
            cbCentro_usuario.SelectedItem = cbCentro_usuario.Items(0)
            cbbuscar.SelectedItem = cbbuscar.Items(0)
            llenar_datagridview_estudios("fecha")
            txtbuscar.Clear()
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If main_menu.quitarfirma = 1 Then
            ContextMenuStrip1.Items(2).Visible = True
        Else
            ContextMenuStrip1.Items(2).Visible = False
        End If

        If txtlike.Text = "paciente" Then
            txtbuscar.ForeColor = Color.Gray
            txtbuscar.Text = "Nombre o cedula del paciente"
        End If
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable
    Dim filtro As String
    Dim formulario As String = "busqueda_estudios"
    'Dim db As String = "bdisis"
    ' Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
    Dim habilitar As Integer = 1

    Public Sub llenar_datagridview_estudios(tipoinforme)
        Try

            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")

            ' Dim inicio As Date = txtdesde.Value.ToShortDateString
            'Dim desde As String = inicio.AddDays(-3)
            Console.WriteLine(inicio)

            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,DATE(e.fecha_hora) as fecha, 
            CONCAT(p.apellido,' ',p.nombre) AS paciente, 
            p.edad,(pr.procedimiento) AS estudio,e.tecnico,e.estado, 
            e.fecha_firma,(u.nombre) AS medico,e.fecha_entrega,e.hora_entrega,e.idusuariomedico 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario "
            If tipoinforme = "fecha" Then

                consulta += "WHERE e.idcentro = '" & txtidcentro_usuario.Text & "' AND date(e.fecha_hora) 
                    BETWEEN '" & desde & "' AND '" & hasta & "' ORDER BY e.fecha_entrega ASC, e.hora_entrega ASC"


            ElseIf tipoinforme = "paciente" Then
                consulta += "WHERE e.idcentro = '" & txtidcentro_usuario.Text & "' "

                Dim busqueda As String = txtbuscar.Text
                Dim combo As String = cbEstudio.Text
                If combo <> "TODOS" Then
                    filtro = busqueda & " " & combo
                Else
                    filtro = busqueda
                End If

                'Dim palabra As String = filtro.Substring(0, 1)
                ' Console.WriteLine(palabra)

                Dim arreglo As String() = Split(filtro, " ")

                For i As Integer = 0 To arreglo.Length - 1 Step 1

                    '      consulta += "AND p.apellido like '" & arreglo(i) & "%' "

                    consulta += "AND CONCAT(p.apellido, ' ', p.nombre, ' ', pr.procedimiento, ' ', p.cin) like '%" & arreglo(i) & "%' "
                Next

                consulta += "ORDER BY e.fecha_entrega ASC, e.hora_entrega ASC"
                Console.WriteLine(consulta)

            Else
                consulta += "WHERE e.idcentro = '" & txtidcentro_usuario.Text & "' AND p.cin = '" & txtbuscar.Text & "' 
                ORDER BY e.fecha_entrega ASC, e.hora_entrega ASC "

            End If

            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEstudios.DataSource = datos
            dgEstudios.DataMember = "estudios"
            retocar_columnas()
            colorear_filas()
            lblcant.Text = dgEstudios.Rows.Count
        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub llenar_datagridview_id()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,DATE(e.fecha_hora) as fecha,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,(pr.procedimiento) AS estudio,e.estado,(u.nombre) AS medico,e.fecha_entrega,e.hora_entrega,e.idusuariomedico FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario WHERE e.idcentro = '" & txtidcentro_usuario.Text & "' ORDER BY e.fecha_hora ASC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEstudios.DataSource = datos
            dgEstudios.DataMember = "estudios"
            retocar_columnas()
            colorear_filas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgEstudios.Columns(0).HeaderText = "ID"
            Me.dgEstudios.Columns(1).HeaderText = "FECHA"
            Me.dgEstudios.Columns(2).HeaderText = "PACIENTE"
            Me.dgEstudios.Columns(3).HeaderText = "EDAD"
            Me.dgEstudios.Columns(4).HeaderText = "ESTUDIO REALIZADO"
            Me.dgEstudios.Columns(5).HeaderText = "TECNICO"
            Me.dgEstudios.Columns(6).HeaderText = "ESTADO"
            Me.dgEstudios.Columns(7).HeaderText = "FECHA FIRMA"
            Me.dgEstudios.Columns(8).HeaderText = "MEDICO"
            Me.dgEstudios.Columns(9).HeaderText = "FECHA ENTRE."
            Me.dgEstudios.Columns(10).HeaderText = "HORA ENTRE."
            Me.dgEstudios.Columns(11).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub colorear_filas()
        For Each r As DataGridViewRow In dgEstudios.Rows
            If r.Cells("estado").Value = "FIRMADO" Then
                r.DefaultCellStyle.BackColor = Color.Green
                r.DefaultCellStyle.ForeColor = Color.White
            ElseIf r.Cells("estado").Value = "EN PROCESO" Then
                r.DefaultCellStyle.BackColor = Color.Orange
                r.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub cbCentro_usuario_TextChanged(sender As Object, e As EventArgs) Handles cbCentro_usuario.TextChanged
        If cbCentro_usuario.Text <> "" Then
            consultar_id_centro(cbCentro_usuario.Text)
            If dr.Read Then
                txtidcentro_usuario.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbCentro_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCentro_usuario.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtidcentro_usuario_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro_usuario.TextChanged
        If txtidcentro_usuario.Text <> "" Then
            llenar_datagridview_estudios("fecha")
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_estudios("fecha")
        Dim row As Integer = dgEstudios.RowCount
        If row > 0 Then
            If txtidtemp.Text <> "" Then
                Dim i As Integer = txtidtemp.Text
                dgEstudios.Item(0, i).Selected = True
            Else
                '  dgEstudios.Rows(0).Selected = True
            End If
        End If
    End Sub

    Private Sub txtdesde_ValueChanged(sender As Object, e As EventArgs) Handles txtdesde.ValueChanged
        llenar_datagridview_estudios("fecha")
    End Sub

    Private Sub txthasta_ValueChanged(sender As Object, e As EventArgs) Handles txthasta.ValueChanged
        llenar_datagridview_estudios("fecha")
    End Sub

    Private Sub cbbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbuscar.KeyPress
        e.Handled = True
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


    Dim firma_informe As String
    Dim idmedico_firmante As Integer
    Dim idestudio As String
    Dim nom_paciente As String


    Private cellValue As String = String.Empty

    Private Sub dgEstudios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEstudios.CellMouseClick
        If e.Button <> MouseButtons.Right Then Return
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
        cellValue = dgEstudios(e.ColumnIndex, e.RowIndex).Value.ToString()
        ContextMenuStrip1.Show(MousePosition)
    End Sub

    Dim respuesta As String
    Dim resultado As String

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "reimprimir"
                ContextMenuStrip1.Close()
                ides = dgEstudios.SelectedCells.Item(0).Value
                idmedico_firmante = dgEstudios.SelectedCells.Item(11).Value
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
                    Try
                        vista_previa.Show()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Aqui el error")
                    End Try

                End If

            Case "ver_imagen"
                ContextMenuStrip1.Close()
                If dgEstudios.Rows.Count > 0 Then
                    txtprueba.Text = dgEstudios.SelectedCells.Item(0).Value
                    descargar_estudios_anteriores()
                End If

            Case "cambiar_estado"
                ContextMenuStrip1.Close()
                If dgEstudios.Rows.Count > 0 Then
                    Dim id As Integer
                    id = dgEstudios.SelectedCells.Item(0).Value
                    modificarEstado(id)
                    llenar_datagridview_estudios("fecha")
                End If

            Case "ver_firma"
                ContextMenuStrip1.Close()
                If dgEstudios.Rows.Count > 0 Then

                    Dim id As Integer

                    If ver_firma.Checked Then
                        resultado = "NO"
                    Else
                        resultado = "SI"
                    End If
                    id = dgEstudios.SelectedCells.Item(0).Value
                    visualizar_firma(id, resultado)
                End If

            Case "descargar"
                ContextMenuStrip1.Close()
                If dgEstudios.Rows.Count > 0 Then
                    txtprueba.Text = dgEstudios.SelectedCells.Item(0).Value
                    descargar_estudios_anteriores2()
                End If
            Case "modificarfecha"
                ContextMenuStrip1.Close()
                If dgEstudios.Rows.Count > 0 Then
                    modificar_fecha.txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value
                    modificar_fecha.txtfecha_entrega.Text = dgEstudios.SelectedCells.Item(9).Value
                    modificar_fecha.txthora_entrega.Text = dgEstudios.SelectedCells.Item(10).Value

                    modificar_fecha.ShowDialog()
                End If
            Case "est_anterior"
                If dgEstudios.Rows.Count > 0 Then
                    adjuntos.txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value
                    adjuntos.lblpaciente.Text = "PACIENTE: " & dgEstudios.SelectedCells.Item(2).Value
                    adjuntos.ShowDialog()
                End If
            Case "subirmodificado"
                If dgEstudios.Rows.Count > 0 Then
                    estudio_mod.txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value
                    estudio_mod.lblpaciente.Text = "PACIENTE: " & dgEstudios.SelectedCells.Item(2).Value
                    estudio_mod.ShowDialog()
                End If
            Case "resubirest"
                If dgEstudios.Rows.Count > 0 Then
                    resubir.lblid.Text = dgEstudios.SelectedCells.Item(0).Value
                    resubir.lblpaciente.Text = dgEstudios.SelectedCells.Item(2).Value
                    resubir.ShowDialog()
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

    Private Sub descargar_estudios_anteriores2()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip")) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Computer.Network.DownloadFile(estudiosftp & txtprueba.Text & ".zip", "C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip", "sadmin", "Sadmin7050*", False, 11000, True)
                'pbloading.Visible = False
                'lblestado.Visible = False
            Else
                MessageBox.Show("Este estudio ya esta descargado,", "revise su directorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'descarga.Close()
            End If
            'verificar_estudio_anterior()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Dim abrir As Integer = 1
    'Dim ubi_visor As String
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
                If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip")) Then
                    MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & txtprueba.Text & ".zip")
                End If
            Else
                abrir = 0
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

            idestudio = dgEstudios.SelectedCells.Item(0).Value
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

    Private Sub cbbuscar_TextChanged(sender As Object, e As EventArgs) Handles cbbuscar.TextChanged
        If cbbuscar.Text = "PACIENTE" Then
            txtlike.Text = "paciente"
        ElseIf cbbuscar.Text = "ESTUDIO" Then
            txtlike.Text = "estudio"
        ElseIf cbbuscar.Text = "ESTADO" Then
            txtlike.Text = "estado"
        ElseIf cbbuscar.Text = "MEDICO" Then
            txtlike.Text = "medico"
        ElseIf cbbuscar.Text = "CEDULA" Then
            txtlike.Text = "cedula"
        End If
    End Sub

    Private Sub cbEstudio_TextChanged(sender As Object, e As EventArgs) Handles cbEstudio.TextChanged
        If CheckBox1.Checked = True Then
            filtro_estudio()
        End If
    End Sub

    Private Sub filtro_estudio()
        Try
            Dim combo1 As String = cbEstudio.Text
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "estudio" & " like '%" & combo1 & "%'"

            If dv.Count <> 0 Then
                dgEstudios.DataSource = dv
                retocar_columnas()
            Else
                dgEstudios.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buscar()
        Try

            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = txtlike.Text & " like '%" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgEstudios.DataSource = dv
                retocar_columnas()
            Else
                dgEstudios.DataSource = Nothing

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If CheckBox1.Checked = True Then
            'buscar en base de datos'
            buscar()
            colorear_filas()
        Else
            If txtlike.Text <> "paciente" And txtlike.Text <> "cedula" Then
                buscar()
                colorear_filas()
            End If
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        reporte_estudios.desde = Me.txtdesde.Text
        reporte_estudios.hasta = Me.txthasta.Text
        reporte_estudios.centro_consulta = Me.cbCentro_usuario.Text
        reporte_estudios.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

        consultar_informe_estudio(dgEstudios.SelectedCells.Item(0).Value, formulario)

        If dr.Read Then
            If Not IsDBNull(dr(15)) Then
                respuesta = dr(15)
            End If
        End If

        If respuesta = "SI" Then
            Me.ver_firma.Checked = True
        Else
            Me.ver_firma.Checked = False
        End If
    End Sub

    Private Sub dgEstudios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEstudios.CellClick
        Dim row As Integer = dgEstudios.RowCount
        If e.RowIndex > -1 Then
            If row > 0 Then
                txtidtemp.Text = dgEstudios.CurrentRow.Index
            End If
        End If
    End Sub

    Private Sub txtbuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            If txtbuscar.Text <> "" And CheckBox1.Checked = False Then
                'buscar en base de datos'
                If txtlike.Text = "paciente" Then
                    colorear_filas()
                    llenar_datagridview_estudios("paciente")
                Else
                    If txtlike.Text = "cedula" Then
                        colorear_filas()
                        llenar_datagridview_estudios("cedula")

                    End If
                End If

            Else
                'buscar en base de datos'
                colorear_filas()
                llenar_datagridview_estudios("fecha")
            End If
        End If

        Console.WriteLine(e.KeyCode)
    End Sub


    Private Sub txtbuscar_LostFocus(sender As Object, e As EventArgs) Handles txtbuscar.LostFocus
        If txtlike.Text = "paciente" Then
            If Trim(txtbuscar.Text) = Nothing Then
                txtbuscar.ForeColor = Color.Gray
                txtbuscar.Text = "Nombre o cedula del paciente"
            End If
        End If
    End Sub

    Private Sub txtbuscar_GotFocus(sender As Object, e As EventArgs) Handles txtbuscar.GotFocus
        If txtbuscar.Text = "NOMBRE O CEDULA DEL PACIENTE" Then
            txtbuscar.ForeColor = Color.Black
            txtbuscar.Text = ""
        End If

    End Sub

End Class