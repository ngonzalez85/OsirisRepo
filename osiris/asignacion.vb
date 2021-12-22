Imports MySql.Data.MySqlClient
Imports System.IO
Public Class asignacion

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable
    Dim formulario As String = "asignacion"

    Public Sub llenar_datagridview_estudios()
        If main_menu.asignacion_informes = 1 Then
            Try
                Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "SELECT e.idestudio,p.cin,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento, e.fecha_entrega,e.hora_entrega,
                e.estado,u.nombre,e.doctor_solicitante,pri.prioridad,e.fecha_hora,e.idusuariomedico, IFNULL(u.dobles,0) doble, e.idcita,e.idcentro 
                FROM estudios e 
                INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
                INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
                INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
                LEFT JOIN (SELECT idcita, COUNT(idcita) dobles FROM medvitaltest.estudiosunificados u GROUP BY idcita ) u
                USING(idcita)
                INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario
                WHERE e.idcentro = " & txtidcentro.Text & " AND (e.estado = 'INGRESADO' OR e.estado = 'ASIGNADO' OR e.estado = 'EN PROCESO') 
                ORDER BY STR_TO_DATE(e.fecha_entrega, '%d/%m/%Y') ASC, STR_TO_DATE(e.hora_entrega, '%h,%i,%s') ASC"
                adaptador = New MySqlDataAdapter(consulta, Conexion3)
                'data table
                dt = New DataTable
                adaptador.Fill(dt)
                datos = New DataSet
                adaptador.Fill(datos, "estudios")
                dgContenedor.DataSource = datos
                dgContenedor.DataMember = "estudios"
                retocar_columnas()
                ver_proceso()
                colorear_filas()
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Else
            Try
                Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "SELECT e.idestudio,p.cin,CONCAT(p.apellido,' ',p.nombre) AS paciente,p.edad,pr.procedimiento, e.fecha_entrega,e.hora_entrega,
                e.estado,u.nombre,e.doctor_solicitante,pri.prioridad,e.fecha_hora,e.idusuariomedico, IFNULL(u.dobles,0) doble, e.idcita,e.idcentro 
                FROM estudios e 
                INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
                INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
                INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
                INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
                LEFT JOIN (SELECT idcita, COUNT(idcita) dobles FROM medvitaltest.estudiosunificados u GROUP BY idcita ) u
                USING(idcita)
                WHERE e.idcentro = " & txtidcentro.Text & " AND (e.estado = 'INGRESADO' OR e.estado = 'ASIGNADO' OR e.estado = 'EN PROCESO') and e.idusuariomedico= " & main_menu.txtidusuario.Text & " 
                ORDER BY STR_TO_DATE(e.fecha_entrega, '%d/%m/%Y') ASC, STR_TO_DATE(e.hora_entrega, '%h,%i,%s') ASC"
                adaptador = New MySqlDataAdapter(consulta, Conexion3)
                'data table
                dt = New DataTable
                adaptador.Fill(dt)
                datos = New DataSet
                adaptador.Fill(datos, "estudios")
                dgContenedor.DataSource = datos
                dgContenedor.DataMember = "estudios"
                retocar_columnas()
                colorear_filas()
                ver_proceso()
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub retocar_columnas()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(1).HeaderText = "CI"
            Me.dgContenedor.Columns(2).HeaderText = "PACIENTE"
            Me.dgContenedor.Columns(2).Width = 290
            Me.dgContenedor.Columns(3).HeaderText = "EDAD"
            Me.dgContenedor.Columns(3).Width = 50
            Me.dgContenedor.Columns(4).HeaderText = "ESTUDIO REALIZADO"
            Me.dgContenedor.Columns(4).Width = 300
            Me.dgContenedor.Columns(5).HeaderText = "FECHA ENTRE."
            Me.dgContenedor.Columns(6).HeaderText = "HORA ENTRE."
            Me.dgContenedor.Columns(7).HeaderText = "ESTADO"
            Me.dgContenedor.Columns(7).Width = 80
            Me.dgContenedor.Columns(8).HeaderText = "MEDICO ASIGNADO"
            Me.dgContenedor.Columns(8).Width = 290
            Me.dgContenedor.Columns(9).HeaderText = "DR. SOLICITANTE"
            Me.dgContenedor.Columns(9).Width = 290
            Me.dgContenedor.Columns(10).HeaderText = "PRIORIDAD"
            Me.dgContenedor.Columns(10).Width = 90
            Me.dgContenedor.Columns(11).HeaderText = "FECHA"
            Me.dgContenedor.Columns(11).Width = 130
            Me.dgContenedor.Columns(12).Visible = False
            Me.dgContenedor.Columns(13).HeaderText = "DOBLE"
            Me.dgContenedor.Columns(13).Visible = False
            Me.dgContenedor.Columns(14).Visible = False
            Me.dgContenedor.Columns(15).Visible = False
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub colorear_filas()
        For Each r As DataGridViewRow In dgContenedor.Rows
            If r.Cells("prioridad").Value = "URGENCIAS" Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
                'ElseIf r.Cells("estado").Value = "ASIGNADO" Then
                '   r.DefaultCellStyle.BackColor = Color.Gold
                '  r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub ver_proceso()
        For Each r As DataGridViewRow In dgContenedor.Rows
            If r.Cells("estado").Value = "EN PROCESO" Then
                proceso_informe.Visible = True
            Else
                proceso_informe.Visible = False
            End If
        Next
    End Sub

    '*******************************************************************
    Private Sub asignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'llenar_datagridview_estudios()

        Dim row As Integer = dgContenedor.Rows.Count
        If row > 0 Then
            dgContenedor.Rows(0).Selected = False
        End If

        llenar_combobox_procedimientos(cbEstudio)
        cbMedico.Items.Clear()
        llenar_combobox_medicos(cbMedico, main_menu.txtidcentro.Text)

        Me.ToolTip1.SetToolTip(Me.dgContenedor, "Doble clic para visualizar estudio")
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar lista de estudios")
        Me.ToolTip1.IsBalloon = True

        Try
            cbcentro.Items.Clear()
            llenar_combobox_centrosXusuarios(cbcentro, main_menu.txtidusuario.Text)
            cbcentro.SelectedItem = cbcentro.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cbMedico_TextChanged(sender As Object, e As EventArgs) Handles cbMedico.TextChanged
        If cbMedico.Text <> "" Then
            consultar_medico(cbMedico.Text)
            If dr.Read Then
                txtidmedico.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbEstudio_TextChanged(sender As Object, e As EventArgs) Handles cbEstudio.TextChanged
        filtro_estudio()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If txtestado.Text = "EN PROCESO" Then
                'MessageBox.Show("El estudio que desea reasignar se encuentra en proceso de redacción", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea REASIGNAR el estudio?. El estudio que selecionó se encuentra en proceso de redacción por otro médico informante", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    consultar_ultimo_informe(txtidestudio.Text)
                    If dr.Read Then
                        txtidinforme.Text = dr(0)
                    End If
                    If checkUrgente.Checked = True Then
                        reasignar_estudio(txtidestudio.Text, txtidmedico.Text, txtidmedico.Text, txtidinforme.Text, 3)
                    Else
                        reasignar_estudio(txtidestudio.Text, txtidmedico.Text, txtidmedico.Text, txtidinforme.Text, 1)
                    End If
                    reasignar_informe(txtidestudio.Text, txtidmedico.Text)
                    txtidinforme.Clear()
                    llenar_datagridview_estudios()
                End If
            Else
                If txtpaciente.Text <> "" And txtestudio.Text <> "" And txtidmedico.Text <> "" Then
                    If checkUrgente.Checked = True Then
                        asignar_estudio(txtidestudio.Text, txtidmedico.Text, txtidmedico.Text, 3)
                    Else
                        asignar_estudio(txtidestudio.Text, txtidmedico.Text, txtidmedico.Text, 1)
                    End If

                    llenar_datagridview_estudios()
                Else
                    MessageBox.Show("Asegúrese de haber seleccionado un paciente y un médico informante", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        llenar_datagridview_estudios()
        Dim UltimaFila As Integer
        UltimaFila = dgContenedor.Rows.Count - 1
        '    Console.WriteLine("fila: " & UltimaFila)
        '     Console.WriteLine("row: " & txtidtemp.Text)

        Dim row As Integer = dgContenedor.Rows.Count
        'Dim i As Integer
        If row > 0 Then
            dgContenedor.Rows(0).Selected = False

            'If txtidtemp.Text <> "" Then
            '    i = txtidtemp.Text
            '    dgContenedor.Item(0, i).Selected = True
            'Else

            'End If
        End If

        '     Console.WriteLine(txtidtemp.Text, row)
    End Sub

    Dim index As Integer
    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        Dim row As Integer = dgContenedor.Rows.Count
        If e.RowIndex > -1 Then
            If row > 0 Then
                txtidestudio.Text = dgContenedor.SelectedCells.Item(0).Value
                txtidtemp.Text = dgContenedor.CurrentRow.Index
                txtpaciente.Text = dgContenedor.SelectedCells.Item(2).Value
                txtestudio.Text = dgContenedor.SelectedCells.Item(4).Value
                txtestado.Text = dgContenedor.SelectedCells.Item(7).Value
            End If
        End If

        '    Console.WriteLine(txtidtemp.Text)
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_estudios()
        Dim UltimaFila As Integer
        UltimaFila = dgContenedor.Rows.Count - 1
        ' Console.WriteLine("fila: " & UltimaFila)
        'Console.WriteLine("row: " & txtidtemp.Text)

        Dim row As Integer = dgContenedor.Rows.Count
        If row > 0 Then
            dgContenedor.Rows(0).Selected = False

            'If txtidtemp.Text <> "" Then
            '    If txtidtemp.Text = UltimaFila Then
            '        Dim a As Integer = txtidtemp.Text - 1
            '        dgContenedor.Item(0, a).Selected = True
            '    Else
            '        Dim i As Integer = txtidtemp.Text
            '        dgContenedor.Item(0, i).Selected = True
            '    End If
            'Else

            'End If
        End If

        ' Console.WriteLine(txtidtemp.Text, row)
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()

    End Sub

    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        Dim row As Integer = dgContenedor.Rows.Count
        If e.RowIndex > -1 Then
            If row > 0 Then
                txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
                descargar_estudios_anteriores()
            End If
        End If
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

    Dim ubi_visor As String
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


    Dim idmedico_firmante As Integer
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "ver_imagen"
                If dgContenedor.Rows.Count > 0 Then
                    txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
                    descargar_estudios_anteriores()
                End If

            Case "lista_estudios"
                If dgContenedor.Rows.Count > 0 Then
                    txtprueba.Text = dgContenedor.SelectedCells.Item(0).Value
                    vista_estudio.txtcita.Text = dgContenedor.SelectedCells.Item(14).Value

                    vista_estudio.ShowDialog()
                End If

            Case "proceso_informe"
                If dgContenedor.Rows.Count > 0 Then
                    ContextMenuStrip1.Close()
                    ides = dgContenedor.SelectedCells.Item(0).Value
                    idmedico_firmante = dgContenedor.SelectedCells.Item(12).Value
                    obtener_cuerpo()

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
                        'vista_previa.firma_informe = Me.firma_informe
                        Try
                            vista_previa.Show()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aqui el error")
                        End Try
                    End If
                End If

            Case "ver_adjuntos"
                If dgContenedor.Rows.Count > 0 Then
                    orden_medica.txtidestudio.Text = dgContenedor.SelectedCells.Item(0).Value
                    orden_medica.txtidcita.Text = dgContenedor.SelectedCells.Item(14).Value
                    orden_medica.lblpaciente.Text = dgContenedor.SelectedCells.Item(2).Value
                    orden_medica.txtidcentro.Text = dgContenedor.SelectedCells.Item(15).Value

                    orden_medica.ShowDialog()
                End If
        End Select
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

    Private cellValue As String = String.Empty
    Private Sub dgContenedor_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgContenedor.CellMouseClick
        Dim row As Integer = dgContenedor.RowCount
        If e.RowIndex > -1 Then
            If row > 0 Then
                If e.Button <> MouseButtons.Right Then Return
                If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
                cellValue = dgContenedor(e.ColumnIndex, e.RowIndex).Value.ToString()
                ContextMenuStrip1.Show(MousePosition)
            End If
        End If


    End Sub

    Private Sub txtidcentro_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro.TextChanged
        If txtidcentro.Text <> "" Then
            llenar_datagridview_estudios()
        End If
    End Sub

    Private Sub cbcentro_TextChanged(sender As Object, e As EventArgs) Handles cbcentro.TextChanged
        If cbcentro.Text <> "" Then
            consultar_id_centro(cbcentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)

            End If
        End If
    End Sub

    Private Sub cbcentro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbcentro.KeyPress
        e.Handled = True
    End Sub

    Private Sub filtro_estudio()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "procedimiento" & " like '%" & cbEstudio.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor.DataSource = dv
                retocar_columnas()
            Else
                dgContenedor.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgContenedor_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgContenedor.CellFormatting
        Dim celda As DataGridViewCell

        If dgContenedor.Rows(e.RowIndex).Cells("doble").Value = "2" Then
            For Each celda In dgContenedor.Rows(e.RowIndex).Cells
                lista_estudios.Visible = True
                e.CellStyle.BackColor = Color.Gold
                'celda.Style.ForeColor = Color.White  
            Next
        ElseIf dgContenedor.Rows(e.RowIndex).Cells("prioridad").Value = "URGENCIAS" Then
            For Each celda In dgContenedor.Rows(e.RowIndex).Cells
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            Next
            lista_estudios.Visible = False
        ElseIf dgContenedor.Rows(e.RowIndex).Cells("estado").Value = "EN PROCESO" Then
            For Each celda In dgContenedor.Rows(e.RowIndex).Cells
                proceso_informe.Visible = True
            Next
        Else
            lista_estudios.Visible = False
            proceso_informe.Visible = False
        End If
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
End Class