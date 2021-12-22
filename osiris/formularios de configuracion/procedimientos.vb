Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles

Public Class procedimientos

    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable

    Dim orderby As String

    Public Sub llenar_datagridview_tipoestudio()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT p.idprocedimiento,p.procedimiento,t.tipoestudio FROM procedimientos p INNER JOIN tipo_estudios t ON p.idtipoestudio= t.idtipoestudio WHERE p.habilitado = 1" & orderby
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "procedimientos")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "procedimientos"
            retocar_columnas()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "PROCEDIMIENTO"
            Me.dgContenedor.Columns(1).Width = 250
            Me.dgContenedor.Columns(2).HeaderText = "T. ESTUDIO"
            Me.dgContenedor.Columns(2).Width = 180

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub procedimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        chkOrdenar.CheckState = CheckState.Checked
        cbtipo_estudio.Items.Clear()
        llenar_combobox_tipo_estudio(cbtipo_estudio)

        llenar_datagridview_tipoestudio()

        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        Me.ToolTip1.SetToolTip(Me.btnagregar, "Agregar o quitar tipo de estudio")
        Me.ToolTip1.SetToolTip(Me.btnlimpiar, "Vaciar campos")
        Me.ToolTip1.SetToolTip(Me.btneliminar, "Eliminar registro")
        Me.ToolTip1.IsBalloon = True
    End Sub

    Private Sub cbtipo_estudio_TextChanged(sender As Object, e As EventArgs) Handles cbtipo_estudio.TextChanged
        If cbtipo_estudio.Text <> "" Then
            consultar_id_tipoestudio(cbtipo_estudio.Text)
            If dr.Read Then
                txtidtipo_estudio.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        Try
            txtidprocedimiento.Text = dgContenedor.SelectedCells.Item(0).Value
            txtprocedimiento.Text = dgContenedor.SelectedCells.Item(1).Value
            cbtipo_estudio.Text = dgContenedor.SelectedCells.Item(2).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub guardar()
        Try

            Dim sql As String = "INSERT INTO procedimientos (procedimiento,idtipoestudio)values(?procedimiento,?idtipoestudio)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)


            Comando.Parameters.AddWithValue("?procedimiento", txtprocedimiento.Text)
            Comando.Parameters.AddWithValue("?idtipoestudio", txtidtipo_estudio.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()


            MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub actualizar()

        Try
            Dim sql As String = "UPDATE procedimientos Set procedimiento =?procedimiento,idtipoestudio=?idtipoestudio where idprocedimiento=?idprocedimiento"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idprocedimiento", txtidprocedimiento.Text)
            Comando.Parameters.AddWithValue("?procedimiento", txtprocedimiento.Text)
            Comando.Parameters.AddWithValue("?idtipoestudio", txtidtipo_estudio.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtidprocedimiento.Clear()
        txtprocedimiento.Clear()
        cbtipo_estudio.Text = ""
        txtidtipo_estudio.Clear()
        txtprocedimiento.Select()
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        If txtidprocedimiento.Text <> "" Then
            If txtprocedimiento.Text <> "" And txtidtipo_estudio.Text <> "" Then
                actualizar()
                llenar_datagridview_tipoestudio()
                If txtflag.Text <> "" Then
                    Dim frm As envio = CType(Owner, envio)
                    frm.cargar_procedimiento()
                    txtflag.Clear()
                End If
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtprocedimiento.Text <> "" And txtidtipo_estudio.Text <> "" Then
                guardar()
                llenar_datagridview_tipoestudio()
                If txtflag.Text <> "" Then
                    Dim frm As envio = CType(Owner, envio)
                    frm.cargar_procedimiento()
                    txtflag.Clear()
                End If
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtidprocedimiento_TextChanged(sender As Object, e As EventArgs) Handles txtidprocedimiento.TextChanged
        If txtidprocedimiento.Text <> "" Then
            btnaccion.Text = "ACTUALIZAR"
            btneliminar.Visible = True
        Else
            btnaccion.Text = "GUARDAR"
            btneliminar.Visible = False
        End If
    End Sub



    Private Sub txtprocedimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprocedimiento.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtprocedimiento.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Public Sub actualizar_combo()
        llenar_combobox_tipo_estudio(cbtipo_estudio)
    End Sub

    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        If dgContenedor.Rows.Count > 0 Then
            procedimientos_centros.txtidprocedimiento.Text = dgContenedor.SelectedCells.Item(0).Value
            procedimientos_centros.txtprocedimiento.Text = dgContenedor.SelectedCells.Item(1).Value
            redactar_informe.obtener_plantilla()
            Me.Close()
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        tipo_estudio.ShowDialog()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    '<DllImport(DllName, EntryPoint:="CreateRoundRectRgn")>
    'Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, br As Integer, we As Integer, he As Integer) As IntPtr
    'End Function

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "procedimiento" & " Like '%" & txtprocedimiento.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor.DataSource = dv
                retocar_columnas()
            Else
                dgContenedor.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtprocedimiento_TextChanged(sender As Object, e As EventArgs) Handles txtprocedimiento.TextChanged
        buscar()
    End Sub

    Private Sub chkOrdenar_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrdenar.CheckedChanged
        If chkOrdenar.Checked Then
            orderby = " order by p.procedimiento asc"
            llenar_datagridview_tipoestudio()
        Else
            orderby = " order by p.idprocedimiento asc"
            llenar_datagridview_tipoestudio()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        reporte_procedimientos.Show()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtidprocedimiento.Text <> "" Then
            eliminar_procedimiento(txtidprocedimiento.Text)
            MessageBox.Show("Registro eliminado correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenar_datagridview_tipoestudio()
            limpiar()
        End If
    End Sub

    Private Sub cbtipo_estudio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbtipo_estudio.KeyPress
        e.Handled = True
    End Sub
End Class