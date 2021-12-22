Imports MySql.Data.MySqlClient
Public Class procedimientos_centros
    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_pc(ByRef idcentro As String)
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT pc.idprocedimiento_centro,p.procedimiento,c.nombre,pc.precio_informe,pc.comision_us FROM centros c INNER JOIN procedimientos_centros pc ON c.idcentro = pc.idcentro INNER JOIN procedimientos p ON pc.idprocedimiento = p.idprocedimiento WHERE pc.idcentro = '" & idcentro & "'"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "procedimientos")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "procedimientos"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "PROCEDIMIENTO"
            Me.dgContenedor.Columns(1).Width = 200
            Me.dgContenedor.Columns(2).HeaderText = "CENTRO"
            Me.dgContenedor.Columns(2).Width = 150
            Me.dgContenedor.Columns(3).HeaderText = "P. INFORME"
            Me.dgContenedor.Columns(3).Width = 120
            Me.dgContenedor.Columns(4).HeaderText = "C. USO SOFT."
            Me.dgContenedor.Columns(4).Width = 120

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub procedimientos_centros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        abrir()
        autoCompletarTexbox(txtprocedimiento)
        llenar_combobox_centros(cbcentro, main_menu.txtidcentro.Text)
    End Sub

    Private Sub txtprocedimiento_TextChanged(sender As Object, e As EventArgs) Handles txtprocedimiento.TextChanged
        If txtprocedimiento.Text <> "" Then
            consultar_procedimiento(txtprocedimiento.Text)
            If dr.Read Then
                txtidprocedimiento.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbcentro_TextChanged(sender As Object, e As EventArgs) Handles cbcentro.TextChanged
        If cbcentro.Text <> "" Then
            consultar_id_centro(cbcentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)
                llenar_datagridview_pc(txtidcentro.Text)
            End If
        End If
    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        If txtidprocedimiento_centro.Text <> "" Then
            quitar_centro_procedimiento(txtidprocedimiento_centro.Text)
            llenar_datagridview_pc(txtidcentro.Text)
            txtidprocedimiento_centro.Clear()
            txtprocedimiento.Clear()
            txtidprocedimiento.Clear()
            cbcentro.Text = ""
            txtidcentro.Clear()
            txtprecio.Clear()
            txtcomision.Clear()
            txtprocedimiento.Select()
        Else
            If txtidprocedimiento.Text <> "" And txtidcentro.Text <> "" Then
                insertar_centro_procedimiento(txtidprocedimiento.Text, txtidcentro.Text, txtprecio.Text, txtcomision.Text)
                llenar_datagridview_pc(txtidcentro.Text)
                txtprocedimiento.Clear()
                txtidprocedimiento.Clear()
                cbcentro.Text = ""
                txtidcentro.Clear()
                txtprecio.Clear()
                txtcomision.Clear()
                txtprocedimiento.Select()
            End If
        End If
    End Sub

    Private Sub txtidprocedimiento_TextChanged(sender As Object, e As EventArgs) Handles txtidprocedimiento.TextChanged
        If txtprocedimiento.Text <> "" Then
            llenar_datagridview_pc(txtidcentro.Text)
        End If
    End Sub

    Private Sub limpiar()
        txtidprocedimiento_centro.Clear()
        txtprocedimiento.Clear()
        txtidprocedimiento.Clear()
        cbcentro.Text = ""
        txtidcentro.Clear()
        txtprecio.Clear()
        txtcomision.Clear()
        txtprocedimiento.Select()
        dgContenedor.DataSource = Nothing
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        limpiar()
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidprocedimiento_centro.Text = dgContenedor.SelectedCells.Item(0).Value
    End Sub

    Private Sub txtidprocedimiento_centro_TextChanged(sender As Object, e As EventArgs) Handles txtidprocedimiento_centro.TextChanged
        If txtidprocedimiento_centro.Text <> "" Then
            btnAccion.Text = "QUITAR"
        Else
            btnAccion.Text = "AGREGAR"
        End If
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcomision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomision.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        procedimientos.ShowDialog()
    End Sub
End Class