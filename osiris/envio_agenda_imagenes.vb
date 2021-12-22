Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports MySql.Data.MySqlClient

Public Class envio_agenda_imagenes
    Dim formulario As String = "envio_agenda_imagenes"
    Private Sub envio_agenda_imagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        txtidcentro.Text = main_menu.txtidcentro.Text

        'consultar_procedimiento_idrispy(txtidrispy.Text)
        'If dr.Read Then
        'txtidprocedimiento.Text = dr(0)
        'txtprocedimiento.Text = dr(1)
        'End If

        consultar_procedimiento_id(txtidprocedimiento.Text)
        If dr.Read Then
            txtprocedimiento.Text = dr(1)
        End If

        cbModalidad.Items.Clear()
        cbtecnicos.Items.Clear()
        llenar_datagridview_proce()
        cbMedico.Items.Clear()
        llenar_combobox_medicos(cbMedico, main_menu.txtidcentro.Text)
        llenar_combobox_modalidades(cbModalidad, main_menu.txtidcentro.Text)
        llenar_combobox_tecnicos(cbtecnicos, main_menu.txtidcentro.Text)
        buscarCentro()

        consultar_modalidad_idrispy(txtidmodalidad_rispy.Text)
        If dr.Read Then
            txtidmodalidad.Text = dr(0)
            cbModalidad.Text = dr(2)
        End If

        If main_menu.lblrol.Text = "MEDICO" Or main_menu.lblrol.Text = "MEDICO ADMINISTRADOR" Then
            consultar_usuariomedico(main_menu.txtidusuario.Text)
            If dr.Read Then
                txtidusuario_medico.Text = dr(0)
                cbMedico.Text = dr(3)
            End If
        Else
            consultar_usuario(txtcidoctor.Text)
            If dr.Read Then
                txtidusuario_medico.Text = dr(0)
                cbMedico.Text = dr(3)
            End If
        End If

        consultar_usuariotecnico(main_menu.txtidusuario.Text)
        If dr.Read Then
            txtidtecnico.Text = dr(0)
            cbtecnicos.Text = dr(3)
        End If

        'consulta_paciente()
        'inserta_paciente()
        consulta_de_paciente()

        If main_menu.lblrol.Text = "MEDICO" Or main_menu.lblrol.Text = "MEDICO ADMINISTRADOR" Then
            consultar_perfilmedico()
            If dr.Read Then
                txtidtecnico.Text = dr(0)
                cbtecnicos.Text = dr(3)
            End If
        End If
    End Sub

    Private Sub consulta_de_paciente()
        If txtci.Text <> "" Then
            txtidpaciente.Clear()
            consultar_paciente(txtci.Text)
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    txtidpaciente.Text = dr(0)
                End If
            Else
                insertar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtsexo.Text, txtidseguro.Text)
                txtidpaciente.Clear()
                consultar_paciente(txtci.Text)
                If dr.Read Then
                    txtidpaciente.Text = dr(0)
                End If
            End If
        End If
    End Sub

    Private Sub inserta_paciente()
        If txtidpaciente.Text = "" Then
            consultar_paciente(txtci.Text)
            If dr.Read Then

            Else
                insertar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtsexo.Text, txtidseguro.Text)
                consultar_paciente(txtci.Text)
                If dr.Read Then
                    txtidpaciente.Text = dr(0)
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
            'MsgBox(ex.Message)
        End Try
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

    'DESDE AQUI

    Private Sub txtci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtci.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtsexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsexo.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtseguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtseguro.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtprioridad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprioridad.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtcentro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcentro.KeyPress
        e.Handled = True
    End Sub

    Private Sub buscarCentro()
        consultar_centro(txtidcentro.Text)
        If dr.Read Then
            txtcentro.Text = dr(1)
        End If
    End Sub

    'busqueda nueva de procedimiento
    Public Sub llenar_datagridview_proce()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT procedimiento FROM procedimientos WHERE habilitado = 1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            'data table908iu7tx
            dt = New DataTable
            adaptador.Fill(dt)
            adaptador.Fill(datos, "procedimientos")
            dgproc.DataSource = datos
            dgproc.DataMember = "procedimientos"
            'retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim dt As DataTable
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

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
        txtprocedimiento.Text = dgproc.SelectedCells.Item(0).Value
        dgproc.Visible = False
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
        dgproc.Visible = True
        buscar()
    End Sub

    Private Sub cbtecnicos_TextChanged(sender As Object, e As EventArgs) Handles cbtecnicos.TextChanged
        Try
            If cbtecnicos.Text <> "" Then
                consultar_medico(cbtecnicos.Text)
                If dr.Read Then
                    txtidtecnico.Text = dr(0)
                    'txtmedico.Text = dr(3)
                End If
                'inserta_paciente()
            End If
        Catch ex As Exception
            'mensaje pendiente
        End Try
    End Sub

    Private Sub limpiar()
        txtdirectorio.Clear()
        txtidpaciente.Clear()
        txtidtecnico.Clear()
        txtidusuario_medico.Clear()
        'txtidprocedimiento.Clear()
        'txtprocedimiento.Clear()
        'txtmotivo.Clear()
        txtidcentro.Clear()
        txtidmodalidad.Clear()
    End Sub

    Dim fecha As String
    Dim subir As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        verificar()
        If txtci.Text <> "" And txtidpaciente.Text <> "" And txtidseguro.Text <> "" And txtidmodalidad.Text <> "" And txtidprioridad.Text <> "" And txtidtecnico.Text <> "" And txtidprocedimiento.Text <> "" And txtmotivo.Text <> "" And cbtecnicos.Text <> "" And txtdoctor_solicitante.Text <> "" And txtidusuario_medico.Text <> "" Then
            Try
                ' consultar_estudio_existe(txtidpaciente.Text, txtidmodalidad.Text, txtidprocedimiento.Text)
                consultar_cita_existe(txtidcita.Text)

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
                            Modificar()
                            txtmotivo.Clear()
                            txtidprocedimiento.Clear()
                            txtprocedimiento.Clear()
                        ElseIf ask = MsgBoxResult.No Then
                            insertar()
                            txtmotivo.Clear()
                            txtidprocedimiento.Clear()
                            txtprocedimiento.Clear()
                        Else

                        End If
                    Else
                        MessageBox.Show("Ya existe este estudio con este paciente de la fecha " & fecha & ". Debe resubir imagen al estudio existente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    insertar()
                    txtmotivo.Clear()
                    txtidprocedimiento.Clear()
                    txtprocedimiento.Clear()
                    Me.Close()
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
            insertar_estudio_agenda(txtidcentro.Text, main_menu.txtidusuario.Text, txtidpaciente.Text, txtidseguro.Text, txtidmodalidad.Text, txtidprioridad.Text, txtidusuario_medico.Text, txtidprocedimiento.Text, "SUBIENDO", txtmotivo.Text, cbtecnicos.Text, main_menu.txtidcentro.Text, txtdoctor_solicitante.Text, fechaentrega, horaentrega, txtidcita.Text, "SI", numCant.Value)

            'Actualiza la fecha de su ultimo estudio
            actualizar_ultimo_estudio_paciente(txtidpaciente.Text)

            '  extraer_archivos()
            txtarchivo.Clear()

            'se vuelve a recargar el formulario

            Button4.Enabled = False
            lblprogreso.Text = "COMPRIMIENDO EL ESTUDIO..."
            pbloading.Visible = True
            comprimir.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Modificar()

        Try
            Dim horaentrega As String = txthora_entrega.Value.ToString("HH:mm:ss")
            Dim fechaentrega As String = txtfecha_entrega.Value.ToString("dd/MM/yyyy")
            'Modifica datos del estudio en la BD
            modificar_estudio_agenda(txtidcentro.Text, main_menu.txtidusuario.Text, txtidpaciente.Text, txtidseguro.Text, txtidmodalidad.Text, txtidprioridad.Text, txtidusuario_medico.Text, txtidprocedimiento.Text, "ASIGNADO", txtmotivo.Text, cbtecnicos.Text, main_menu.txtidcentro.Text, txtdoctor_solicitante.Text, fechaentrega, horaentrega, txtidcita.Text, "SI", txtidestudioe.Text, numCant.Value)

            'Actualiza la fecha de su ultimo estudio
            actualizar_ultimo_estudio_paciente(txtidpaciente.Text)

            '   extraer_archivos()
            txtarchivo.Clear()

            'se vuelve a recargar el formulario

            Button4.Enabled = False
            lblprogreso.Text = "COMPRIMIENDO EL ESTUDIO..."
            pbloading.Visible = True
            comprimir.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim estudio_listo As String
    Dim idestudio As Integer

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

        actualizar_estado_estudio_agenda(idestudio)

        System.IO.File.Delete("C:\osiris\files\temp\" & estudio_listo)
        Me.Close()
    End Sub

    Private Sub cbMedico_TextChanged(sender As Object, e As EventArgs) Handles cbMedico.TextChanged
        If cbMedico.Text <> "" Then
            consultar_medico(cbMedico.Text)
            If dr.Read Then
                txtidusuario_medico.Text = dr(0)
            End If
        End If
    End Sub

    'Private Sub extraer_archivos()
    '    Try
    '        If txtarchivo.Text <> "" Then
    '            If (txtarchivo.Text.StartsWith(" ")) Then
    '                txtarchivo.Text = txtarchivo.Text.Substring(1)
    '            End If

    '            Dim ord As Integer = 0
    '            Dim cita As Integer = txtidcita.Text
    '            Dim arrayPalabras() As String, i As Integer
    '            arrayPalabras = Strings.Split(txtarchivo.Text, " ")
    '            For i = 0 To UBound(arrayPalabras)
    '                ord += 1
    '                insertar_adjunto_agenda(cita, ord, arrayPalabras(i), txtci.Text)
    '            Next i
    '        End If
    '    Catch errorN As Exception

    '    End Try
    'End Sub

    Private Sub verificar()
        If txtidtecnico.Text = "" Then
            consultar_tecnico(cbtecnicos.Text)
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    txtidtecnico.Text = dr(0)
                End If
            End If
        End If

        If txtidprocedimiento.Text = "" Then
            consultar_procedimiento(txtprocedimiento.Text)
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    txtidprocedimiento.Text = dr(0)
                End If
            End If
        End If

        If txtidusuario_medico.Text = "" Then
            consultar_medico(cbMedico.Text)
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    txtidusuario_medico.Text = dr(0)
                End If
            End If
        End If
    End Sub

End Class