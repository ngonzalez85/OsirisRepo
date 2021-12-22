Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading

Public Class informes
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim directorio As String
    Dim carpeta_estudios_subidos As String
    Dim ubi_visor As String
    Dim formulario As String = "informes"

    Public Sub llenar_datagridview_estudios()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,
            e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idcentro_solicitante,e.reserva,e.doctor_solicitante,
            e.idpaciente,e.fecha_entrega,e.hora_entrega,e.idcita,e.dicom, pri.idprioridad 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio 
            WHERE e.idcentro= '" & txtidcentro.Text & "' AND e.estado != 'FIRMADO' AND (e.idusuariomedico = '" & main_menu.txtidusuario.Text & "' OR pri.prioridad = 'URGENCIAS') 
            ORDER BY STR_TO_DATE(e.fecha_entrega, '%d/%m/%Y') ASC, STR_TO_DATE(e.hora_entrega, '%h,%i,%s') ASC"
            'consulta = "SELECT e.idestudio,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idcentro_solicitante,e.reserva,e.doctor_solicitante FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio WHERE e.estado != 'FIRMADO' AND (e.idusuariomedico = '" & main_menu.txtidusuario.Text & "' OR pri.prioridad = 'URGENCIAS') ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEstudios.DataSource = datos
            dgEstudios.DataMember = "estudios"
            retocar_columnas()
            colorear_filas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgEstudios.Columns(0).HeaderText = "ID"
            Me.dgEstudios.Columns(1).HeaderText = "PACIENTE"
            Me.dgEstudios.Columns(2).HeaderText = "EDAD"
            Me.dgEstudios.Columns(3).HeaderText = "ESTUDIO REALIZADO"
            Me.dgEstudios.Columns(4).HeaderText = "T. ESTUDIO"
            Me.dgEstudios.Columns(5).HeaderText = "PRIORIDAD"
            Me.dgEstudios.Columns(6).HeaderText = "FECHA"
            Me.dgEstudios.Columns(7).HeaderText = "ESTADO"
            Me.dgEstudios.Columns(8).HeaderText = "MEDICO ASIGNADO"
            Me.dgEstudios.Columns(9).Visible = False
            Me.dgEstudios.Columns(10).Visible = False
            Me.dgEstudios.Columns(11).Visible = False
            Me.dgEstudios.Columns(12).Visible = False
            Me.dgEstudios.Columns(13).Visible = False
            Me.dgEstudios.Columns(14).Visible = False
            Me.dgEstudios.Columns(15).Visible = False
            Me.dgEstudios.Columns(16).Visible = False
            Me.dgEstudios.Columns(17).Visible = False
            Me.dgEstudios.Columns(18).HeaderText = "FECHA ENTRE."
            Me.dgEstudios.Columns(19).HeaderText = "HORA ENTRE."
            Me.dgEstudios.Columns(20).Visible = False
            Me.dgEstudios.Columns(21).Visible = False
            Me.dgEstudios.Columns(22).Visible = False
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub colorear_filas()
        Dim row As Integer = dgEstudios.RowCount
        If row > 0 Then
            For Each r As DataGridViewRow In dgEstudios.Rows
                If r.Cells("prioridad").Value = "URGENCIAS" Then
                    r.DefaultCellStyle.BackColor = Color.Red
                    r.DefaultCellStyle.ForeColor = Color.White
                    'ElseIf r.Cells("estado").Value = "ASIGNADO" Then
                    'r.DefaultCellStyle.BackColor = Color.Gold
                    'r.DefaultCellStyle.ForeColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnimagen, "Visualizar imágenes del estudio")
        Me.ToolTip1.SetToolTip(Me.btninforme, "Redactar informe sobre el estudio")
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar lista")
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar estudios")
        Me.ToolTip1.SetToolTip(Me.btnfirmas, "Ver mis firmas")
        Me.ToolTip1.SetToolTip(Me.btndescargar, "Descargar estudio")
        Me.ToolTip1.SetToolTip(Me.btndescargar, "Ver colaboraciones")
        Me.ToolTip1.IsBalloon = True

        llenar_datagridview_estudios()
        'Dim row As Integer = dgEstudios.RowCount
        'If row > 0 Then
        '    dgEstudios.Rows(0).Selected = False
        'End If

        descargar()
        descargar_firma()
        descargar_logo()
        If main_menu.lblidrol.Text <> "10" Then
            btndescargar.Visible = False
        Else
            btnimagen.Visible = False
            btndescargar.Visible = True
        End If
        Try
            cbcentro.Items.Clear()
            llenar_combobox_centrosXusuarios(cbcentro, main_menu.txtidusuario.Text)
            cbcentro.SelectedItem = cbcentro.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Dim abrir As Integer = 1
    Private Sub verificar_imagen()
        Try
            consultar_centro(main_menu.txtidcentro.Text)
            If dr.Read Then
                directorio = dr(10)
                carpeta_estudios_subidos = dr(11)
            End If

            If txtdicom.Text = "SI" Then
                Dim result As DialogResult
                result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                If (result = DialogResult.Yes) Then
                    ubi_visor = visorRadiant
                ElseIf result = DialogResult.No Then
                    ubi_visor = visorMicro
                ElseIf result = DialogResult.Cancel Then
                    abrir = 0
                End If

                ' Console.WriteLine("abrir= " & abrir)

                If abrir = 1 Then
                    Dim imagen As String = txtidestudio.Text & ".zip"

                    If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & imagen)) Then
                        MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga. Se abrira el visor una vez completada.", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        My.Computer.Network.DownloadFile(estudiosftp & imagen, "C:\osiris\files\estudios_descargados\" & imagen, "sadmin", "Sadmin7050*", False, 11000, True)
                        Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & imagen, AppWinStyle.MaximizedFocus)
                    Else
                        Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & imagen, AppWinStyle.MaximizedFocus)
                    End If

                Else
                    abrir = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

    Private Sub descargar_estudioC(ByRef tipo As Integer)
        Try
            If txtidestudio.Text <> "" Then

                Dim imagen As String = txtidestudio.Text & ".zip"

                If txtdicom.Text = "SI" Then
                    If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & imagen)) Then
                        MessageBox.Show("Aguarde un momento, el estudio " & txtidestudio.Text & " se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If tipo = 1 Then
                            MessageBox.Show("Este estudio ya esta descargado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else

                        End If
                    End If
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try
    End Sub

    Dim radiant As Process()
    Dim micro As Process()

    Private Sub cerrar_radiant()
        radiant = Process.GetProcessesByName("RadiAntViewer")
        If radiant.Length > 0 Then
            For i = radiant.Length - 1 To 0 Step -1
                radiant(i).Kill()
            Next
        End If

        micro = Process.GetProcessesByName("MicroDicom")
        If micro.Length > 0 Then
            For i = micro.Length - 1 To 0 Step -1
                micro(i).Kill()
            Next
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        verificar_imagen()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btninforme.Click
        If txtbandera.Text = 1 Then
            MessageBox.Show("Se detectó que actualmente se encuentra el redactor abierto, si desea recatar un nuevo informe cierre el actual y vuelva a intentarlo.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            redactar()
        End If
    End Sub

    Private Sub redactar()
        cerrar_radiant()
        redactar_informe.Close()
        vista_previa.Close()

        If txtestado.Text <> "FIRMADO" Then
            varificar_perfil_medico(main_menu.txtidusuario.Text)
            If dr.Read Then
                If txtreserva.Text = 0 Then
                    asignar_estudio(txtidestudio.Text, main_menu.txtidusuario.Text, txtidmedico.Text, txtidprioridad.Text)
                End If
                verificar_estado_estudio(txtidestudio.Text, main_menu.txtidusuario.Text)
                If dr.Read Then
                    MessageBox.Show("Lo sentimos pero este estudio ha sido reservado previamente por otro médico ☹, por favor seleccione otro estudio ", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    verificar_estado_firma(txtidestudio.Text)
                    If dr.Read Then
                        MessageBox.Show("Lo sentimos pero este estudio ya fue firmado, actualize la bandeja", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else

                        If main_menu.lblvisor_auto.Text = "SI" Then
                            ' Console.WriteLine(main_menu.lblidrol.Text)
                            If main_menu.lblidrol.Text <> "10" Then
                                verificar_imagen()
                            Else
                                descargar_estudioC(0)
                            End If
                        End If
                        Dim frm As New redactar_informe
                        AddOwnedForm(frm)
                        frm.lblci.Text = Me.lblci.Text
                        frm.lblpaciente.Text = Me.lblpaciente.Text
                        frm.lbledad.Text = Me.lbledad.Text
                        frm.lblfecha_nac.Text = Me.lblfecha_nac.Text
                        frm.lblestudio.Text = Me.lblestudio.Text
                        frm.lblmotivo.Text = Me.txtmotivo.Text
                        frm.txtidestudio.Text = Me.txtidestudio.Text
                        frm.lbltipoestudio.Text = Me.lbltipoestudio.Text
                        frm.txtidcentro_solicitante.Text = Me.txtidcentro_solicitante.Text
                        frm.txtidmedico.Text = Me.txtidmedico.Text
                        frm.lbltecnico.Text = Me.lbltecnico.Text
                        frm.lblmedicosolicitante.Text = Me.lblmedicosolicitante.Text
                        frm.txtidpaciente.Text = Me.lblidpaciente.Text
                        frm.txtidcentro.Text = Me.txtidcentro.Text
                        frm.txtidcita.Text = Me.txtidcita.Text
                        frm.txtdicom.Text = Me.txtdicom.Text
                        'redactar_informe.rtb1.Text = ""
                        txtbandera.Text = 1

                        frm.Show()
                        'redactar_informe.Show()
                    End If
                End If
            Else
                MessageBox.Show("Esta función solo está disponible para los perfiles de tipo medico", "ACCESO RESTRINGIDO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El estudio ya fue firmado", "ACCESO RESTRINGIDO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtidestudio_TextChanged(sender As Object, e As EventArgs) Handles txtidestudio.TextChanged
        If txtidestudio.Text = "" Then
            btnimagen.Enabled = False
            btninforme.Enabled = False
            btndescargar.Enabled = False
        Else
            btnimagen.Enabled = True
            btninforme.Enabled = True
            btndescargar.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'txtmotivo.Clear()
        descargar()
    End Sub

    Public Sub actualizarinformes()
        'txtmotivo.Clear()
        descargar()
    End Sub

    Private Sub descargar()
        Try
            llenar_datagridview_estudios()
            Dim row As Integer = dgEstudios.RowCount
            Dim UltimaFila As Integer
            UltimaFila = dgEstudios.Rows.Count - 1
            If row > 0 Then
                dgEstudios.Rows(0).Selected = False

                'If txtidtemp.Text <> "" Then
                '    If txtidtemp.Text = UltimaFila Then
                '        Dim a As Integer = txtidtemp.Text - 1
                '        dgEstudios.Item(0, a).Selected = True
                '    Else
                '        Dim i As Integer = txtidtemp.Text
                '        dgEstudios.Item(0, i).Selected = True
                '    End If
                'Else

                'End If
            End If

            contar_archivos()
            Dim proc As Thread
            proc = New Thread(AddressOf descargar_estudios)
            proc.Start()
        Catch ex As Exception

        End Try

    End Sub

    Dim archivo As String
    Private Sub descargar_estudios()
        Try
            If dgEstudios.Rows.Count > 0 Then

                For Each Fila As DataGridViewRow In dgEstudios.Rows
                    If Fila.Cells.Item(21).Value = "SI" Then
                        archivo = Fila.Cells.Item(0).Value & ".zip"

                        If (Not File.Exists("C:\osiris\files\estudios_descargados\" & archivo)) Then
                            My.Computer.Network.DownloadFile(estudiosftp & archivo, "C:\osiris\files\estudios_descargados\" & archivo, "sadmin", "Sadmin7050*", False, 11000, True)
                        End If

                    End If
                Next
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Private Sub descargar_firma()

        Try
            Dim firma As String = main_menu.lbldir_firma.Text.Substring(main_menu.lbldir_firma.Text.LastIndexOf("\") + 1)
            If main_menu.lbldir_firma.Text = "" Or main_menu.lbldir_firma.Text = "NINGUNO" Then

            Else
                If (Not File.Exists("C:\osiris\files\firmas\" & firma)) Then

                    My.Computer.Network.DownloadFile(firmasftp & firma, "C:\osiris\files\firmas\" & firma, "sadmin", "Sadmin7050*", False, 11000, True)

                End If
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub descargar_logo()


        Try
            Dim logo As String = main_menu.lbldir_logo.Text.Substring(main_menu.lbldir_logo.Text.LastIndexOf("\") + 1)
            If main_menu.lbldir_logo.Text = "" Or main_menu.lbldir_logo.Text = "NINGUNO" Then

            Else
                If (Not File.Exists("C:\osiris\files\logos_centros\" & logo)) Then

                    My.Computer.Network.DownloadFile(logosftp & logo, "C:\osiris\files\logos_centros\" & logo, "sadmin", "Sadmin7050*", False, 11000, True)

                End If
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub contar_archivos()
        Try

            Dim ContadorDeArchivos As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            'le indicamos el path que queremos  

            ContadorDeArchivos = My.Computer.FileSystem.GetFiles("C:\osiris\files\estudios_descargados\")

                'nos devuelve la cantidad de archivos
                'Dim row As Integer = dgEstudios.RowCount
                Dim row As Integer
            For Each item As DataGridViewRow In dgEstudios.Rows
                If item.Cells("dicom").Value.ToString().Contains("SI") Then
                    row = row + 1
                End If
            Next

            Dim cant As Integer = CStr(ContadorDeArchivos.Count)

            If row <= cant Then
                lblestado.Visible = False
                pbloading.Visible = False
                '  GroupBox3.Enabled = True
            Else
                lblestado.Visible = True
                pbloading.Visible = True
                '  GroupBox3.Enabled = False
            End If

        Catch oExcep As Exception
            MsgBox("Descripción del error : " &
                   oExcep.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Public Sub proceso()
        My.Computer.Network.DownloadFile(estudiosftp & archivo, "C:\osiris\files\estudios_descargados\" & archivo, "sadmin", "Sadmin7050*", False, 500, True)
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        actualizarinformes()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub cbcentro_TextChanged(sender As Object, e As EventArgs) Handles cbcentro.TextChanged

        limpiar()

        If cbcentro.Text <> "" Then
            consultar_id_centro(cbcentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtidcentro_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro.TextChanged
        If txtidcentro.Text <> "" Then
            llenar_datagridview_estudios()
        End If
    End Sub

    Private Sub cbcentro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbcentro.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If main_menu.busqueda_informes <> 0 Then

            'FUNCION PARA CERRAR FORMLARIO SI ESTA ABIERTO
            For Each f As Form In Application.OpenForms
                If Not f.InvokeRequired Then
                    If f.Name = "busqueda_informe" Then
                        f.Close()
                        Exit For
                    End If
                End If
            Next
            busqueda_informe.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        favoritos.Show()
    End Sub

    Private Sub txtdicom_TextChanged(sender As Object, e As EventArgs) Handles txtdicom.TextChanged
        Console.WriteLine(txtdicom.Text)
        If txtdicom.Text = "NO" Then
            btnimagen.Enabled = False
        Else
            btnimagen.Enabled = True
        End If
    End Sub

    Private Sub dgEstudios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgEstudios.CellFormatting
        Dim celda As DataGridViewCell

        If dgEstudios.Rows(e.RowIndex).Cells("prioridad").Value = "URGENCIAS" Then
            For Each celda In dgEstudios.Rows(e.RowIndex).Cells
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            Next
        End If
    End Sub


    Public Sub limpiar()
        txtidestudio.Clear()
        txtestado.Clear()
        txtmotivo.Clear()
        txtidmedico.Clear()
        txtreserva.Clear()
        txtidcita.Clear()
        txtdicom.Clear()
        txtidtemp.Clear()

        descargar()
    End Sub

    Private Sub dgEstudios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEstudios.CellClick

        Dim row As Integer = dgEstudios.RowCount
        If e.RowIndex > -1 Then
            If row > 0 Then
                txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value
                lblpaciente.Text = dgEstudios.SelectedCells.Item(1).Value
                lbledad.Text = dgEstudios.SelectedCells.Item(2).Value
                lblestudio.Text = dgEstudios.SelectedCells.Item(3).Value
                lbltipoestudio.Text = dgEstudios.SelectedCells.Item(4).Value
                txtestado.Text = dgEstudios.SelectedCells.Item(7).Value
                txtmotivo.Text = dgEstudios.SelectedCells.Item(9).Value
                lblci.Text = dgEstudios.SelectedCells.Item(10).Value
                txtidcentro_solicitante.Text = dgEstudios.SelectedCells.Item(14).Value
                txtidmedico.Text = dgEstudios.SelectedCells.Item(12).Value
                lbltecnico.Text = dgEstudios.SelectedCells.Item(13).Value
                txtreserva.Text = dgEstudios.SelectedCells.Item(15).Value
                lblmedicosolicitante.Text = dgEstudios.SelectedCells.Item(16).Value
                lblidpaciente.Text = dgEstudios.SelectedCells.Item(17).Value
                txtidcita.Text = dgEstudios.SelectedCells.Item(20).Value
                txtdicom.Text = dgEstudios.SelectedCells.Item(21).Value
                txtidprioridad.Text = dgEstudios.SelectedCells.Item(22).Value
                txtidtemp.Text = dgEstudios.CurrentRow.Index
            End If
        End If

    End Sub

    Private Sub btnfirmas_Click(sender As Object, e As EventArgs) Handles btnfirmas.Click
        btnmisfirmas.Show()
    End Sub

    Private cellValue As String = String.Empty
    Private Sub dgEstudios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEstudios.CellMouseClick
        If e.Button <> MouseButtons.Right Then Return
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
        cellValue = dgEstudios(e.ColumnIndex, e.RowIndex).Value.ToString()

        If txtidcentro.Text = 8 Then
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "eliminar_temp"
                If txtidestudio.Text <> "" Then
                    ContextMenuStrip1.Close()
                    eliminar_temporal(txtidestudio.Text)
                    MessageBox.Show(txtidestudio.Text + ": Eliminado correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenar_datagridview_estudios()
                End If
        End Select
    End Sub

    Private Sub btndescargar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click
        descargar_estudioC(1)
    End Sub

    Private Sub btn_colaboracion_Click(sender As Object, e As EventArgs) Handles btn_colaboracion.Click
        colaboraciones.ShowDialog()
    End Sub

    Private Sub btnmisfirmas_Click_1(sender As Object, e As EventArgs) Handles btnmisfirmas.Click

        'FUNCION PARA CERRAR FORMLARIO SI ESTA ABIERTO
        For Each f As Form In Application.OpenForms
            If Not f.InvokeRequired Then
                If f.Name = "misfirmas" Then
                    f.Close()
                    Exit For
                End If
            End If
        Next
        misfirmas.Show()
    End Sub
End Class