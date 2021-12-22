Imports MySql.Data.MySqlClient
Imports System.IO

Public Class busqueda_informe

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub busqueda_informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar lista")
        Me.ToolTip1.SetToolTip(Me.primerApellido, "Desactivar en caso de buscar nombre completo")
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Activar si quiere filtar por fecha")

        Me.ToolTip1.IsBalloon = True

        ' autoCompletarMedico(txtmedico)
        ' autoCompletarPaciente(txtpaciente)

        Dim inicio As New DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day)
        inicio = inicio.AddDays(-2)
        txtdesde.Value = inicio

        Try
            cbCentro_usuario.Items.Clear()
            llenar_combobox_centrosXusuarios(cbCentro_usuario, main_menu.txtidusuario.Text)
            cbCentro_usuario.SelectedItem = cbCentro_usuario.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If main_menu.quitarfirma = 1 Then
            ContextMenuStrip1.Items(2).Visible = True
        Else
            ContextMenuStrip1.Items(2).Visible = False
        End If

        If main_menu.primerapellido = 1 Then
            primerApellido.Checked = True
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtci.Visible = True
            Panel1.Visible = True
            txtci.ForeColor = Color.Gray
            txtci.Text = "CEDULA DEL PACIENTE"
            porMedico.Checked = False
        Else
            txtci.Visible = False
            Panel1.Visible = False
        End If
    End Sub

    Private Sub txtci_LostFocus(sender As Object, e As EventArgs) Handles txtci.LostFocus
        If Trim(txtci.Text) = Nothing Then
            txtci.ForeColor = Color.Gray
            txtci.Text = "CEDULA DEL PACIENTE"
        End If
    End Sub

    Private Sub txtci_GotFocus(sender As Object, e As EventArgs) Handles txtci.GotFocus
        If txtci.Text = "CEDULA DEL PACIENTE" Then
            txtci.ForeColor = Color.Black
            txtci.Text = ""
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtpaciente.Visible = True
            Panel2.Visible = True

            If primerApellido.Checked = True Then
                txtpaciente.ForeColor = Color.Gray
                txtpaciente.Text = "Primer apellido del paciente"
            Else
                txtpaciente.ForeColor = Color.Gray
                txtpaciente.Text = "Nombre y apellido del paciente"
            End If

        Else
            txtpaciente.Visible = False
            Panel2.Visible = False
        End If
    End Sub

    Private Sub txtpaciente_LostFocus(sender As Object, e As EventArgs) Handles txtpaciente.LostFocus
        If primerApellido.Checked Then
            If Trim(txtpaciente.Text) = Nothing Then
                txtpaciente.ForeColor = Color.Gray
                txtpaciente.Text = "Primer apellido del paciente"
            End If
        Else
            If Trim(txtpaciente.Text) = Nothing Then
                txtpaciente.ForeColor = Color.Gray
                txtpaciente.Text = "Nombre y apellido del paciente"
            End If
        End If
    End Sub

    Private Sub txtpaciente_GotFocus(sender As Object, e As EventArgs) Handles txtpaciente.GotFocus
        If txtpaciente.Text = "NOMBRE Y APELLIDO DEL PACIENTE" Then
            txtpaciente.ForeColor = Color.Black
            txtpaciente.Text = ""
        End If

        If txtpaciente.Text = "PRIMER APELLIDO DEL PACIENTE" Then
            txtpaciente.ForeColor = Color.Black
            txtpaciente.Text = ""
        End If
    End Sub

    'Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    'End Sub

    Private Sub porMedico_CheckedChanged(sender As Object, e As EventArgs) Handles porMedico.CheckedChanged
        If porMedico.Checked = True Then
            txtmedico.Visible = True
            Panel3.Visible = True
            txtmedico.ForeColor = Color.Gray
            txtmedico.Text = "Nombre o apellido del medico"
            ' autoCompletarMedico(txtmedico)
        Else
            txtmedico.Visible = False
            Panel3.Visible = False
        End If
    End Sub

    Private Sub txtmedico_LostFocus(sender As Object, e As EventArgs) Handles txtmedico.LostFocus
        If Trim(txtmedico.Text) = Nothing Then
            txtmedico.ForeColor = Color.Gray
            txtmedico.Text = "Nombre o apellido del medico"
        End If
    End Sub

    Private Sub txtmedico_GotFocus(sender As Object, e As EventArgs) Handles txtmedico.GotFocus
        If txtmedico.Text = "NOMBRE O APELLIDO DEL MEDICO" Then
            txtmedico.ForeColor = Color.Black
            txtmedico.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label1.Visible = True
            txtdesde.Visible = True
            Label2.Visible = True
            txthasta.Visible = True
        Else
            Label1.Visible = False
            txtdesde.Visible = False
            Label2.Visible = False
            txthasta.Visible = False
        End If

        If RadioButton1.Checked = True Then
            llenar_datagridview_estudios_ci(Me.txtci.Text)
        ElseIf RadioButton2.Checked = True Then
            If txtpaciente.Text <> "PRIMER APELLIDO DEL PACIENTE" Then
                If txtpaciente.Text <> "NOMBRE Y APELLIDO DEL PACIENTE" Then
                    llenar_datagridview_estudios_paciente(Me.txtpaciente.Text)
                End If
            End If
        ElseIf porMedico.Checked = True Then
            If txtmedico.Text <> "NOMBRE O APELLIDO DEL MEDICO" Then
                llenar_datagridview_estudios_medico(Me.txtmedico.Text)
            End If
        End If
    End Sub

    Private Sub txtmedico_TextChanged(sender As Object, e As EventArgs) Handles txtmedico.TextChanged
        If txtmedico.Text <> "" Then
            consultar_medico(txtmedico.Text)
            If dr.Read Then
                txtidmedico.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtci_KeyDown(sender As Object, e As KeyEventArgs) Handles txtci.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True

            If RadioButton1.Checked = True Then
                If txtci.Text <> "" Then
                    llenar_datagridview_estudios_ci(Me.txtci.Text)
                End If
            End If
        End If
    End Sub

    Private Sub txtpaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpaciente.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True

            If RadioButton2.Checked = True Then
                If txtpaciente.Text <> "" Then
                    llenar_datagridview_estudios_paciente(Me.txtpaciente.Text)
                End If
            End If
        End If
    End Sub

    Private Sub txtmedico_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmedico.KeyDown
        'If Char.IsLower(e.KeyChar) Then

        '    txtmedico.SelectedText = Char.ToUpper(e.KeyChar)
        '    e.Handled = True

        'End If
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            If porMedico.Checked = True Then
                If txtmedico.Text <> "" Then
                    llenar_datagridview_estudios_medico(Me.txtmedico.Text)
                End If
            End If
        End If
    End Sub

    Private Sub colorear_filas()
        For Each r As DataGridViewRow In dgContenedor.Rows
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

    Public Sub llenar_datagridview_estudios_ci(ci)

        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma,e.fecha_entrega,e.hora_entrega 
            FROM estudios e INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio
            WHERE e.idcentro= '" & txtidcentro_usuario.Text & "' AND p.cin = '" & ci & "' "

            If CheckBox1.Checked = True Then
                consulta += " AND date(e.fecha_hora) 
                    BETWEEN '" & desde & "' AND '" & hasta & "' "
            End If

            consulta += "ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
            colorear_filas()
            lblcant.Text = dgContenedor.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_estudios_paciente(paciente)

        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,
            pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma, e.fecha_entrega,e.hora_entrega  
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio WHERE e.idcentro= '" & txtidcentro_usuario.Text & "' "

            If primerApellido.Checked = True Then
                consulta += "  AND TRIM(CONCAT(p.apellido, ' ', p.nombre)) LIKE '" & paciente & "%' "
            Else
                Dim arreglo As String() = Split(paciente, " ")

                For i As Integer = 0 To arreglo.Length - 1 Step 1
                    consulta += "AND CONCAT(p.apellido, ' ', p.nombre) LIKE '%" & arreglo(i) & "%' "
                Next
            End If

            If CheckBox1.Checked = True Then
                consulta += " AND date(e.fecha_hora) 
                    BETWEEN '" & desde & "' AND '" & hasta & "' "
            End If

            If porMedico.Checked = True Then
                If txtmedico.Text <> "NOMBRE O APELLIDO DEL MEDICO" Then
                    Dim arreglom As String() = Split(txtmedico.Text, " ")

                    For i As Integer = 0 To arreglom.Length - 1 Step 1
                        consulta += "AND u.nombre LIKE '%" & arreglom(i) & "%' "
                    Next
                End If
            End If

            consulta += "ORDER BY e.idestudio DESC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
            colorear_filas()
            lblcant.Text = dgContenedor.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_estudios_medico(medico)

        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre,
            e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma ,e.fecha_entrega,e.hora_entrega 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio 
            WHERE e.idcentro= '" & txtidcentro_usuario.Text & "' "

            Dim arreglom As String() = Split(medico, " ")

            For i As Integer = 0 To arreglom.Length - 1 Step 1
                consulta += "AND u.nombre LIKE '%" & arreglom(i) & "%' "
            Next

            If CheckBox1.Checked = True Then
                consulta += " AND date(e.fecha_hora) 
                    BETWEEN '" & desde & "' AND '" & hasta & "' "
            End If


            If RadioButton2.Checked = True Then
                Console.WriteLine(txtpaciente.Text)
                If txtpaciente.Text <> "NOMBRE Y APELLIDO DEL PACIENTE" Then
                    If txtpaciente.Text <> "PRIMER APELLIDO DEL PACIENTE" Then
                        If primerApellido.Checked = True Then
                            consulta += "  AND TRIM(CONCAT(p.apellido, ' ', p.nombre)) LIKE '" & txtpaciente.Text & "%' "
                        Else
                            Dim arreglo As String() = Split(txtpaciente.Text, " ")

                            For i As Integer = 0 To arreglo.Length - 1 Step 1
                                consulta += "AND CONCAT(p.apellido, ' ', p.nombre) LIKE '%" & arreglo(i) & "%' "
                            Next
                        End If
                    End If
                End If
            End If

            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
            colorear_filas()
            lblcant.Text = dgContenedor.Rows.Count
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
            Me.dgContenedor.Columns(3).Width = 280
            Me.dgContenedor.Columns(4).Visible = False
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
            Me.dgContenedor.Columns(13).HeaderText = "TECNICO"
            Me.dgContenedor.Columns(13).Width = 290
            Me.dgContenedor.Columns(14).Visible = False
            Me.dgContenedor.Columns(15).HeaderText = "F. FIRMA"
            Me.dgContenedor.Columns(15).Width = 130
            Me.dgContenedor.Columns(16).HeaderText = "F. ENTREGA"
            Me.dgContenedor.Columns(16).Width = 130
            Me.dgContenedor.Columns(17).HeaderText = "H. ENTREGA"
            Me.dgContenedor.Columns(17).Width = 130

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim firma_informe As String
    Dim idmedico_firmante As Integer
    Dim idestudio As String
    Dim nom_paciente As String


    Private cellValue As String = String.Empty

    Private Sub dgContenedor_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgContenedor.CellMouseClick
        If e.Button <> MouseButtons.Right Then Return
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
        cellValue = dgContenedor(e.ColumnIndex, e.RowIndex).Value.ToString()
        ContextMenuStrip1.Show(MousePosition)
    End Sub

    Dim respuesta As String
    Dim resultado As String

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "reimprimir"
                ContextMenuStrip1.Close()
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
                    vista_previa.estudio = dr(17)
                    vista_previa.motivo = dr(9)
                    vista_previa.paciente = dr(16)
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
                If dgContenedor.Rows.Count > 0 Then
                    txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
                    descargar_estudios_anteriores()
                End If

            Case "cambiar_estado"
                ContextMenuStrip1.Close()
                If dgContenedor.Rows.Count > 0 Then
                    Dim id As Integer
                    id = dgContenedor.SelectedCells.Item(0).Value
                    modificarEstado(id)
                End If

            Case "ver_firma"
                ContextMenuStrip1.Close()
                If dgContenedor.Rows.Count > 0 Then

                    Dim id As Integer

                    If ver_firma.Checked Then
                        resultado = "NO"
                    Else
                        resultado = "SI"
                    End If
                    id = dgContenedor.SelectedCells.Item(0).Value
                    visualizar_firma(id, resultado)
                End If

            Case "descargar"
                ContextMenuStrip1.Close()
                If dgContenedor.Rows.Count > 0 Then
                    txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
                    descargar_estudios_anteriores2()
                End If
            Case "modificarfecha"
                ContextMenuStrip1.Close()
                If dgContenedor.Rows.Count > 0 Then
                    modificar_fecha.txtidestudio.Text = dgContenedor.SelectedCells.Item(0).Value
                    modificar_fecha.txtfecha_entrega.Text = dgContenedor.SelectedCells.Item(16).Value
                    modificar_fecha.txthora_entrega.Text = dgContenedor.SelectedCells.Item(17).Value

                    modificar_fecha.ShowDialog()
                End If
            Case "est_anterior"
                If dgContenedor.Rows.Count > 0 Then
                    adjuntos.txtidestudio.Text = dgContenedor.SelectedCells.Item(0).Value
                    adjuntos.lblpaciente.Text = "PACIENTE: " & dgContenedor.SelectedCells.Item(1).Value
                    adjuntos.ShowDialog()
                End If
            Case "subirmodificado"
                If dgContenedor.Rows.Count > 0 Then
                    estudio_mod.txtidestudio.Text = dgContenedor.SelectedCells.Item(0).Value
                    estudio_mod.lblpaciente.Text = "PACIENTE: " & dgContenedor.SelectedCells.Item(1).Value
                    estudio_mod.ShowDialog()
                End If
            Case "resubirest"
                If dgContenedor.Rows.Count > 0 Then
                    resubir.lblid.Text = dgContenedor.SelectedCells.Item(0).Value
                    resubir.lblpaciente.Text = dgContenedor.SelectedCells.Item(1).Value
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

    Private Sub primerApellido_CheckedChanged(sender As Object, e As EventArgs) Handles primerApellido.CheckedChanged
        If primerApellido.Checked = True Then
            If txtpaciente.Text = "" Or txtpaciente.Text = "NOMBRE Y APELLIDO DEL PACIENTE" Then
                txtpaciente.ForeColor = Color.Gray
                txtpaciente.Text = "Primer apellido del paciente"
            End If
        Else
            If txtpaciente.Text = "" Or txtpaciente.Text = "PRIMER APELLIDO DEL PACIENTE" Then
                txtpaciente.ForeColor = Color.Gray
                txtpaciente.Text = "Nombre y apellido del paciente"
            End If
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If RadioButton1.Checked = True Then
            llenar_datagridview_estudios_ci(Me.txtci.Text)
        ElseIf RadioButton2.Checked = True Then
            If txtpaciente.Text <> "PRIMER APELLIDO DEL PACIENTE" Then
                If txtpaciente.Text <> "NOMBRE Y APELLIDO DEL PACIENTE" Then
                    llenar_datagridview_estudios_paciente(Me.txtpaciente.Text)
                End If
            End If
        ElseIf porMedico.Checked = True Then
            If txtmedico.Text <> "NOMBRE O APELLIDO DEL MEDICO" Then
                llenar_datagridview_estudios_medico(Me.txtmedico.Text)
            End If
        End If
    End Sub

    Private Sub txtdesde_ValueChanged(sender As Object, e As EventArgs) Handles txtdesde.ValueChanged
        If RadioButton1.Checked = True Then
            llenar_datagridview_estudios_ci(Me.txtci.Text)
        ElseIf RadioButton2.Checked = True Then
            If txtpaciente.Text <> "PRIMER APELLIDO DEL PACIENTE" Then
                If txtpaciente.Text <> "NOMBRE Y APELLIDO DEL PACIENTE" Then
                    llenar_datagridview_estudios_paciente(Me.txtpaciente.Text)
                End If
            End If
        ElseIf porMedico.Checked = True Then
            If txtmedico.Text <> "NOMBRE O APELLIDO DEL MEDICO" Then
                llenar_datagridview_estudios_medico(Me.txtmedico.Text)
            End If
        End If
    End Sub

    Private Sub txthasta_ValueChanged(sender As Object, e As EventArgs) Handles txthasta.ValueChanged
        If RadioButton1.Checked = True Then
            llenar_datagridview_estudios_ci(Me.txtci.Text)
        ElseIf RadioButton2.Checked = True Then
            If txtpaciente.Text <> "PRIMER APELLIDO DEL PACIENTE" Then
                If txtpaciente.Text <> "NOMBRE Y APELLIDO DEL PACIENTE" Then
                    llenar_datagridview_estudios_paciente(Me.txtpaciente.Text)
                End If
            End If
        ElseIf porMedico.Checked = True Then
            If txtmedico.Text <> "NOMBRE O APELLIDO DEL MEDICO" Then
                llenar_datagridview_estudios_medico(Me.txtmedico.Text)
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        reporte_estudios.desde = Me.txtdesde.Text
        reporte_estudios.hasta = Me.txthasta.Text
        reporte_estudios.centro_consulta = Me.cbCentro_usuario.Text
        reporte_estudios.Show()
    End Sub
End Class