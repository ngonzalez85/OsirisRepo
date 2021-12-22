Imports System.ComponentModel
Imports System.IO.Compression
Imports MySql.Data.MySqlClient

Public Class envio

    'conexion para bdpersona base de datos de cedulas paraguayas
    Dim cadConexion As String = "server=" & serverdb & ";database=bdpersona;user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
    Dim connec As New MySqlConnection(cadConexion)
    Public cmd_ As New MySqlCommand
    Public dr_ As MySqlDataReader
    Dim formulario As String = "envio"

    Public Sub conect()
        Try
            connec.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function disconect()
        Try
            If connec.State = ConnectionState.Open Then
                connec.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'para llenar el grid ************************************************

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    'Dim db As String = "bdisis"

    Public Sub llenar_datagridview_estudios()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,e.fecha_hora,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento,e.estado,u.nombre,e.fecha_entrega,e.hora_entrega, IFNULL(u.dobles,0) doble, e.idcita 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento
            LEFT JOIN (SELECT idcita, COUNT(idcita) dobles FROM medvitaltest.estudiosunificados u GROUP BY idcita ) u
            USING(idcita)
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario WHERE e.estado != 'FIRMADO' AND e.idcentro = '" & txtidcentro_usuario.Text & "' 
            ORDER BY STR_TO_DATE(e.fecha_entrega, '%d/%m/%Y') ASC, STR_TO_DATE(e.hora_entrega, '%h,%i,%s') ASC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEstudios.DataSource = datos
            dgEstudios.DataMember = "estudios"
            retocar_columnas()
            'colorear_filas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgEstudios.Columns(0).HeaderText = "ID"
            Me.dgEstudios.Columns(1).HeaderText = "FECHA"
            Me.dgEstudios.Columns(2).HeaderText = "PACIENTE"
            Me.dgEstudios.Columns(3).HeaderText = "EDAD"
            Me.dgEstudios.Columns(4).HeaderText = "ESTUDIO REALIZADO"
            Me.dgEstudios.Columns(5).HeaderText = "ESTADO"
            Me.dgEstudios.Columns(6).HeaderText = "MEDICO"
            Me.dgEstudios.Columns(7).HeaderText = "FECHA ENTRE."
            Me.dgEstudios.Columns(8).HeaderText = "HORA ENTRE."
            Me.dgEstudios.Columns(9).HeaderText = "DOBLE"
            Me.dgEstudios.Columns(9).Visible = False
            Me.dgEstudios.Columns(10).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub colorear_filas()
        For Each r As DataGridViewRow In dgEstudios.Rows
            If r.Cells("estado").Value = "INGRESADO" Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
                'ElseIf r.Cells("estado").Value = "ASIGNADO" Then
                'r.DefaultCellStyle.BackColor = Color.Gold
                'r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    '*******************************************************************

    'Counsulta de ci db persona
    Private Sub consultar_ci(ByRef cin As String)
        disconect()
        conect()

        cmd_.Connection = connec
        cmd_.CommandType = CommandType.Text

        cmd_.CommandText = "select * from persona where ced_num='" & cin & "' "

        Try
            dr_ = cmd_.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '****************************************************************************************

    'declaracion de variables
    Dim estudio_listo As String
    'Dim carpeta_estudios_subidos As String
    Dim dir_medico As String
    Dim idestudio As Integer

    Private Sub envio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button5.Select()
        'consultar_centro(main_menu.txtidcentro.Text)
        'If dr.Read Then
        'txtdirectorio.Text = dr(10)
        'carpeta_estudios_subidos = dr(11)
        'End If
        llenar_combobox_tecnicos(cbtecnicos, main_menu.txtidcentro.Text)
        llenar_combobox_modalidades(cbModalidad, main_menu.txtidcentro.Text)
        '  llenar_combobox_centros(cbCentro, main_menu.txtidcentro.Text)
        llenar_combobox_centrosXusuarios(cbCentro, main_menu.txtidusuario.Text)
        cbCentro.SelectedItem = cbCentro.Items(0)
        llenar_combobox_prioridades(cbprioridad)
        llenar_combobox_seguros(cbSeguros)
        'cargar_procedimiento()
        llenar_datagridview_proce()

        llenar_datagridview_estudios()
        Dim row As Integer = dgEstudios.RowCount
        If row > 0 Then
            dgEstudios.Rows(0).Selected = False
        End If

        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar lista de estudios")
        Me.ToolTip1.SetToolTip(Me.Button5, "Seleccionar estudio desde CD/DVD o archivo")
        Me.ToolTip1.SetToolTip(Me.btnagregar_estudio, "Agregar un nuevo procedimiento a la lista")
        Me.ToolTip1.SetToolTip(Me.btnagregar_estudio, "Agregar estudio")
        Me.ToolTip1.SetToolTip(Me.Button1, "Buscar informe")
        Me.ToolTip1.SetToolTip(Me.btnenviar_correo, "Agregar una dirección de correo para envío del informe")
        Me.ToolTip1.IsBalloon = True

        ' Console.WriteLine(txtidcentro.Text)
        Try
            cbCentro_usuario.Items.Clear()
            llenar_combobox_centrosXusuarios(cbCentro_usuario, main_menu.txtidusuario.Text)
            cbCentro_usuario.SelectedItem = cbCentro_usuario.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


    Public Sub cargar_procedimiento()
        abrir()
        autoCompletarTexbox(txtprocedimiento)
    End Sub


    Private Sub txtci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtci.KeyPress
        'If Char.IsDigit(e.KeyChar) Then
        'ndled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        'e.Handled = False
        'Else
        'e.Handled = True
        'End If

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then

            If txtci.Text <> "" Then
                consultar_paciente(txtci.Text)
                If dr.Read Then
                    txtidpaciente.Clear()
                    txtnombre.Clear()
                    txtapellido.Clear()
                    'txtnomPaciente.Clear()
                    'txtapePaciente.Clear()
                    txtedad.Clear()
                    txtsexo.Clear()


                    cbSeguros.Text = ("")

                    txtidpaciente.Text = dr(0)
                    txtnombre.Text = dr(2)
                    txtapellido.Text = dr(3)
                    'txtnomPaciente.Text = dr(3)
                    'txtapePaciente.Text = dr(2)
                    txtedad.Text = dr(4)
                    txtsexo.Text = dr(7)

                    'llenar_combobox_seguros(cbSeguros)
                    consultar_pacienteXseguro(txtci.Text)
                    If dr.Read Then
                        txtidseguro.Text = dr(1)
                        cbSeguros.SelectedItem = dr(2)
                    End If
                Else

                    consultar_ci(txtci.Text)
                    If dr_.Read Then
                        txtidpaciente.Clear()
                        txtnombre.Clear()
                        txtapellido.Clear()
                        'txtnomPaciente.Clear()
                        'txtapePaciente.Clear()

                        txtedad.Clear()
                        txtsexo.Clear()

                        cbSeguros.Text = ("")

                        txtnombre.Text = dr_(3)
                        txtapellido.Text = dr_(2)
                        'txtnomPaciente.Text = dr_(3)
                        'txtapePaciente.Text = dr_(2)
                        'llenar_combobox_seguros(cbSeguros)
                        Dim fechaBD As String = dr_(4)

                        Try
                            Dim fecha2 As Date = Date.Parse(fechaBD)
                            Dim fecha1 As Date = Now
                            Dim edad As Long = DateDiff(DateInterval.Year, fecha2, fecha1)
                            txtedad.Text = edad
                            consultar_pacienteXseguro(txtci.Text)
                            If dr.Read Then
                                txtidpaciente.Text = dr(0)
                                txtidseguro.Text = dr(1)
                                cbSeguros.SelectedItem = dr(2)
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Invalid Date: " & ex.Message)
                        End Try
                        Dim sigla_sexo As String = dr_(5)
                        If sigla_sexo = "M" Then
                            txtsexo.Text = "MASCULINO"
                        Else
                            txtsexo.Text = "FEMENINO"
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If dlg.ShowDialog() = DialogResult.OK Then
                txtdirectorio.Text = dlg.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbSeguros_TextChanged(sender As Object, e As EventArgs) Handles cbSeguros.TextChanged
        If cbSeguros.Text <> "" Then
            consultar_id_seguro(cbSeguros.Text)
            If dr.Read Then
                txtidseguro.Text = dr(0)
            End If
        End If

        If txtidpaciente.Text = "" And txtci.Text <> "" And txtedad.Text <> "" And txtsexo.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And cbSeguros.Text <> "" Then
            insertar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtsexo.Text, txtidseguro.Text)
            consultar_paciente(txtci.Text)
            If dr.Read Then
                txtidpaciente.Text = dr(0)
            End If
        ElseIf txtidpaciente.Text <> "" And cbSeguros.Text <> "" Then
            actualizar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, txtsexo.Text, txtidseguro.Text, txtidpaciente.Text)
        End If
    End Sub

    Private Sub txtmotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmotivo.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtmotivo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Dim fecha As String
    Dim subir As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If txtdirectorio.Text <> "" And txtci.Text <> "" And txtidpaciente.Text <> "" And txtidseguro.Text <> "" And txtidmodalidad.Text <> "" And txtidprioridad.Text <> "" And txtidtecnico.Text <> "" And txtidprocedimiento.Text <> "" And txtmotivo.Text <> "" And cbtecnicos.Text <> "" And txtdoctor_solicitante.Text <> "" Then

            Try
                consultar_estudio_existe(txtidpaciente.Text, txtidmodalidad.Text, txtidprocedimiento.Text)
                If dr.Read Then
                    txtidestudioe.Text = dr(0)
                    fecha = dr(1)

                    consultar_permiso_estudio(main_menu.lblidrol.Text)

                    If dr.Read Then
                        subir = dr(0)
                    End If

                    If subir = 1 Then
                        Dim ask As MsgBoxResult = MsgBox("Ya existe este estudio con este paciente de la fecha " & fecha & ". Desea modificar el existente?", MsgBoxStyle.YesNoCancel, "Atención")

                        If ask = MsgBoxResult.Yes Then
                            modificar_e()
                        ElseIf ask = MsgBoxResult.No Then
                            insertar()
                        Else
                        End If
                    Else
                        MessageBox.Show("Ya existe este estudio con este paciente de la fecha " & fecha, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    insertar()
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar subir el estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub insertar()

        Try
            Dim horaentrega As String = txthora_entrega.Value.ToString("HH:mm:ss")
            Dim fechaentrega As String = txtfecha_entrega.Value.ToString("dd/MM/yyyy")
            'Inserta dotos del estudio en la BD
            insertar_estudio(txtidcentro.Text, main_menu.txtidusuario.Text, txtidpaciente.Text, txtidseguro.Text, txtidmodalidad.Text, txtidprioridad.Text, 0, txtidprocedimiento.Text, "SUBIENDO", txtmotivo.Text, cbtecnicos.Text, main_menu.txtidcentro.Text, txtdoctor_solicitante.Text, fechaentrega, horaentrega, txtcorreo.Text, numCant.Value)

            'Actualiza la fecha de su ultimo estudio
            actualizar_ultimo_estudio_paciente(txtidpaciente.Text)

            'asigna valores de los cntroles a las variables antes de vaciarlas

            dir_medico = txtmedico.Text

            'se vuelve a recargar el formulario

            Button4.Enabled = False
            lblprogreso.Text = "COMPRIMIENDO EL ESTUDIO..."
            pbloading.Visible = True
            comprimir.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub modificar_e()

        Try
            Dim horaentrega As String = txthora_entrega.Value.ToString("HH:mm:ss")
            Dim fechaentrega As String = txtfecha_entrega.Value.ToString("dd/MM/yyyy")
            'Inserta dotos del estudio en la BD
            mod_estudio(txtidcentro.Text, main_menu.txtidusuario.Text, txtidpaciente.Text, txtidseguro.Text, txtidmodalidad.Text, txtidprioridad.Text, 0, txtidprocedimiento.Text, "SUBIENDO", txtmotivo.Text, cbtecnicos.Text, main_menu.txtidcentro.Text, txtdoctor_solicitante.Text, fechaentrega, horaentrega, txtcorreo.Text, txtidestudioe.Text, numCant.Value)

            'Actualiza la fecha de su ultimo estudio
            actualizar_ultimo_estudio_paciente(txtidpaciente.Text)

            'asigna valores de los cntroles a las variables antes de vaciarlas

            dir_medico = txtmedico.Text

            'se vuelve a recargar el formulario

            Button4.Enabled = False
            lblprogreso.Text = "COMPRIMIENDO EL ESTUDIO..."
            pbloading.Visible = True
            comprimir.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub comprimir_DoWork(sender As Object, e As DoWorkEventArgs) Handles comprimir.DoWork

        'Realiza una tarea
        consultar_ultimo_estudio()
        If dr.Read Then
            estudio_listo = dr(0) & ".zip"
            ' estudio_listo = "test" & ".zip"
            idestudio = dr(0)
        End If

        'Crea las carpetas de cada usuario si aún no existen
        If (Not System.IO.Directory.Exists("C:\osiris\files\temp\")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp\")
        End If

        ZipFile.CreateFromDirectory(txtdirectorio.Text, "C:\osiris\files\temp\" & estudio_listo)

    End Sub

    Private Sub comprimir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles comprimir.RunWorkerCompleted
        lblprogreso.Text = "SUBIENDO EL ESTUDIO..."
        subir_archivo()
    End Sub

    Private Sub subir_archivo()
        My.Computer.Network.UploadFile("C:\osiris\files\temp\" & estudio_listo, estudiosftp & estudio_listo, "sadmin", "Sadmin7050*", True, 500)
        lblprogreso.Text = ""
        pbloading.Visible = False
        MessageBox.Show("Estudio subido correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        recargar_formulario()
        actualizar_estado_estudio(idestudio)
        llenar_datagridview_estudios()
        System.IO.File.Delete("C:\osiris\files\temp\" & estudio_listo)
    End Sub

    Private Sub txtdirectorio_TextChanged(sender As Object, e As EventArgs) Handles txtdirectorio.TextChanged
        If System.IO.File.Exists(txtdirectorio.Text & "\DICOMDIR") Then
            lblinforme.Visible = True
            lblinforme.ForeColor = Color.Green
            lblinforme.Text = "LA CARPETA CONTIENE IMAGENES"
            Button4.Enabled = True
        Else
            lblinforme.Visible = True
            lblinforme.ForeColor = Color.Red
            lblinforme.Text = "LA CARPETA NO CONTIENE IMAGENES"
            Button4.Enabled = False
        End If
    End Sub

    Private Sub cbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cbModalidad.TextChanged
        If cbModalidad.Text <> "" Then
            consultar_modalidadXcentro(main_menu.txtidcentro.Text, cbModalidad.Text)
            If dr.Read Then
                txtidmodalidad.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbtecnicos_TextChanged(sender As Object, e As EventArgs) Handles cbtecnicos.TextChanged
        Try
            If cbtecnicos.Text <> "" Then
                consultar_medico(cbtecnicos.Text)
                If dr.Read Then
                    txtidtecnico.Text = dr(0)
                    txtmedico.Text = dr(3)
                End If
            End If
        Catch ex As Exception
            'mensaje pendiente
        End Try

    End Sub

    Private Sub cbprioridad_TextChanged(sender As Object, e As EventArgs) Handles cbprioridad.TextChanged
        If cbprioridad.Text <> "" Then
            consultar_prioridad(cbprioridad.Text)
            If dr.Read Then
                txtidprioridad.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub recargar_formulario()
        Button5.Select()
        txtdirectorio.Clear()
        consultar_centro(main_menu.txtidcentro.Text)
        If dr.Read Then
            'txtdirectorio.Text = dr(10)
            'carpeta_estudios_subidos = dr(11)
        End If
        lblinforme.Text = ""
        txtdirectorio.Clear()
        txtci.Clear()
        txtedad.Clear()
        txtsexo.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        cbtecnicos.Items.Clear()
        llenar_combobox_tecnicos(cbtecnicos, main_menu.txtidcentro.Text)
        cbModalidad.Items.Clear()
        llenar_combobox_modalidades(cbModalidad, main_menu.txtidcentro.Text)
        cbprioridad.Items.Clear()
        llenar_combobox_prioridades(cbprioridad)
        cbSeguros.Items.Clear()
        llenar_combobox_seguros(cbSeguros)
        txtprocedimiento.Clear()
        txtmotivo.Clear()
        cbCentro.Items.Clear()
        llenar_combobox_centros(cbCentro, main_menu.txtidcentro.Text)
        txtidcentro.Clear()
        txtdoctor_solicitante.Text = "NINGUNO"
        txtmedico.Clear()
        txtidprioridad.Clear()
        txtidmodalidad.Clear()
        txtidprocedimiento.Clear()
        txtidtecnico.Clear()
        txtidseguro.Clear()
        txtidpaciente.Clear()
        llenar_datagridview_estudios()
        txtcorreo.Text = "NINGUNO"
    End Sub


    'variable para almacenar el ultimo adjunto
    Dim idadjunto As Integer


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCentro_TextChanged(sender As Object, e As EventArgs) Handles cbCentro.TextChanged
        If cbCentro.Text <> "" Then
            consultar_id_centro(cbCentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)
                Console.WriteLine(dr(0))
            End If
        End If

        llenar_datagridview_proce()

    End Sub

    Private Sub btnagregar_estudio_Click(sender As Object, e As EventArgs) Handles btnagregar_estudio.Click
        Dim frm As New procedimientos
        AddOwnedForm(frm)
        frm.txtflag.Text = 1
        frm.ShowDialog()
    End Sub

    Private cellValue As String = String.Empty
    Private Sub dgEstudios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEstudios.CellMouseClick
        If e.Button <> MouseButtons.Right Then Return
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
        cellValue = dgEstudios(e.ColumnIndex, e.RowIndex).Value.ToString()
        ContextMenuStrip1.Show(MousePosition)
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "modificar"
                If dgEstudios.Rows.Count > 0 Then
                    modificar_estudio.txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value

                    modificar_estudio.ShowDialog()
                End If
            Case "est_anterior"
                If dgEstudios.Rows.Count > 0 Then
                    adjuntos.txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value
                    adjuntos.lblpaciente.Text = "PACIENTE: " & dgEstudios.SelectedCells.Item(2).Value
                    adjuntos.ShowDialog()
                End If
            Case "resubirest"
                If dgEstudios.Rows.Count > 0 Then
                    resubir.lblid.Text = dgEstudios.SelectedCells.Item(0).Value
                    resubir.lblpaciente.Text = dgEstudios.SelectedCells.Item(2).Value
                    resubir.ShowDialog()
                End If
            Case "lista_estudios"
                If dgEstudios.Rows.Count > 0 Then
                    vista_estudio.txtcita.Text = dgEstudios.SelectedCells.Item(10).Value

                    vista_estudio.ShowDialog()
                End If
            Case "subirmodificado"
                If dgEstudios.Rows.Count > 0 Then
                    estudio_mod.txtidestudio.Text = dgEstudios.SelectedCells.Item(0).Value
                    estudio_mod.lblpaciente.Text = "PACIENTE: " & dgEstudios.SelectedCells.Item(2).Value
                    estudio_mod.ShowDialog()
                End If

        End Select
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_estudios()
        Dim row As Integer = dgEstudios.RowCount
        If row > 0 Then
            dgEstudios.Rows(0).Selected = False
            If txtidtemp.Text <> "" Then
                Dim i As Integer = txtidtemp.Text
                dgEstudios.Item(0, i).Selected = True
            End If
        End If

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub dgEstudios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEstudios.CellClick
        Dim row As Integer = dgEstudios.RowCount
        If e.RowIndex > -1 Then
            If row > 0 Then
                txtidtemp.Text = dgEstudios.CurrentRow.Index
            End If
        End If

    End Sub

    Private Sub cbCentro_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCentro_usuario.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbCentro_usuario_TextChanged(sender As Object, e As EventArgs) Handles cbCentro_usuario.TextChanged
        If cbCentro_usuario.Text <> "" Then
            consultar_id_centro(cbCentro_usuario.Text)
            If dr.Read Then
                txtidcentro_usuario.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtidcentro_usuario_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro_usuario.TextChanged
        If txtidcentro_usuario.Text <> "" Then
            llenar_datagridview_estudios()
        End If
    End Sub

    'busqueda nueva de procedimiento
    Public Sub llenar_datagridview_proce()
        Try
            If cbCentro.SelectedItem = "UNIMED" Then
                Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "SELECT procedimiento
                FROM centros c
                JOIN modalidades m USING (idcentro)
                JOIN procedimientos p USING(idtipoestudio)
                WHERE idcentro=2"
                adaptador = New MySqlDataAdapter(consulta, Conexion3)
                datos = New DataSet
                'data table
                dt = New DataTable
                adaptador.Fill(dt)
                adaptador.Fill(datos, "procedimientos")
                dgproc.DataSource = datos
                dgproc.DataMember = "procedimientos"
                'retocar_columnas()
            Else
                Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "SELECT procedimiento FROM procedimientos WHERE habilitado = 1"
                adaptador = New MySqlDataAdapter(consulta, Conexion3)
                datos = New DataSet
                'data table
                dt = New DataTable
                adaptador.Fill(dt)
                adaptador.Fill(datos, "procedimientos")
                dgproc.DataSource = datos
                dgproc.DataMember = "procedimientos"
                'retocar_columnas()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Dim dt As DataTable

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "procedimiento" & " like '%" & txtprocedimiento.Text & "%'"

            If dv.Count <> 0 Then
                dgproc.DataSource = dv
                'retocar_columnas()
            Else
                dgproc.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgproc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgproc.CellClick
        If dgproc.Rows.Count > 0 Then
            txtprocedimiento.Text = dgproc.SelectedCells.Item(0).Value
            dgproc.Visible = False
        End If
    End Sub

    Private Sub txtprocedimiento_TextChanged(sender As Object, e As EventArgs) Handles txtprocedimiento.TextChanged
        If txtprocedimiento.Text <> "" Then
            consultar_procedimiento(txtprocedimiento.Text)
            If dr.Read Then
                txtidprocedimiento.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtprocedimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprocedimiento.KeyPress
        If txtprocedimiento.Text <> "" Then
            dgproc.Visible = True
            buscar()
        Else
            dgproc.Visible = False
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub btnenviar_correo_Click(sender As Object, e As EventArgs) Handles btnenviar_correo.Click
        Dim frm As New agregar_correo
        AddOwnedForm(frm)
        frm.txtcorreo.Text = Me.txtcorreo.Text
        frm.ShowDialog()
    End Sub

    Private Sub dgEstudios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgEstudios.CellFormatting
        Dim celda As DataGridViewCell

        If dgEstudios.Rows(e.RowIndex).Cells("doble").Value = "2" Then
            For Each celda In dgEstudios.Rows(e.RowIndex).Cells
                lista_estudios.Visible = True
                e.CellStyle.BackColor = Color.Gold
                'celda.Style.ForeColor = Color.White  
            Next
        Else
            lista_estudios.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        busqueda_informe.ShowDialog()

    End Sub
End Class