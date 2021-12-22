Imports MySql.Data.MySqlClient

Public Class sicronizar_procedimiento

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable
    Dim dt2 As DataTable
    Dim dt3 As DataTable

    Public Sub llenar_datagridview_procedimientos()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT idprocedimiento,procedimiento,idrispy FROM procedimientos order by procedimiento asc"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "procedimientos")
            dgContenedor_osiris.DataSource = datos
            dgContenedor_osiris.DataMember = "procedimientos"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor_osiris.Columns(0).HeaderText = "ID"
            Me.dgContenedor_osiris.Columns(1).HeaderText = "PROCEDIMIENTO"
            Me.dgContenedor_osiris.Columns(2).HeaderText = "ID RISPY"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_procedimientos_sinc()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT idprocedimiento,procedimiento,idrispy FROM procedimientos where idrispy!= 0 order by procedimiento asc"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt3 = New DataTable
            adaptador.Fill(dt3)
            datos = New DataSet
            adaptador.Fill(datos, "procedimientos_sinc")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "procedimientos_sinc"
            retocar_columnas2()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas2()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(1).HeaderText = "PROCEDIMIENTO"
            Me.dgContenedor.Columns(2).HeaderText = "ID RISPY"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub sicronizar_procedimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnRoles, "Sincronizar")
        Me.ToolTip1.SetToolTip(Me.btncambiar, "Cambiar procedimiento de RISPY")
        Me.ToolTip1.SetToolTip(Me.btnlimpiar, "Limpiar campos")
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Recargar datos")
        Me.ToolTip1.IsBalloon = True

        llenar_datagridview_procedimientos()
        llenar_datagridview_procedimientos_sinc()
        llenar_datagridview_rispy()
    End Sub



    Private Sub buscar_osiris()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "procedimiento" & " like '%" & txtbuscar_osiris.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor_osiris.DataSource = dv
                retocar_columnas()
            Else
                dgContenedor_osiris.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub



    'Conexion agenda
    Dim Conexion4 As New MySqlConnection
    Dim datos4 As DataSet
    Dim adaptador4 As New MySqlDataAdapter

    Public Sub llenar_datagridview_rispy()
        Try
            Conexion4.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta4 As String
            consulta4 = "SELECT idconcepto,concepto from conceptos order by concepto asc"
            adaptador4 = New MySqlDataAdapter(consulta4, Conexion4)
            'data table
            dt2 = New DataTable
            adaptador4.Fill(dt2)
            datos4 = New DataSet
            adaptador4.Fill(datos4, "conceptos")
            dgContenedor_rispy.DataSource = datos4
            dgContenedor_rispy.DataMember = "conceptos"
            'TextBox1.Text = DataGridView1.Rows.Count - 1
            retocar_columnas3()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas3()
        Try
            Me.dgContenedor_rispy.Columns(0).HeaderText = "ID"
            Me.dgContenedor_rispy.Columns(1).HeaderText = "CONCEPTO"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscar_rispy()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt2.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "concepto" & " like '%" & txtbuscar_rispy.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor_rispy.DataSource = dv
                'retocar_columnas2()
            Else
                dgContenedor_rispy.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buscar_sinc()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt3.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "procedimiento" & " like '%" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor.DataSource = dv
                'retocar_columnas2()
            Else
                dgContenedor.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub dgContenedor_osiris_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor_osiris.CellClick
        txtidosiris.Text = dgContenedor_osiris.SelectedCells.Item(0).Value
        txtprocedimiento.Text = dgContenedor_osiris.SelectedCells.Item(1).Value
        txtidrispy.Text = dgContenedor_osiris.SelectedCells.Item(2).Value
    End Sub

    Private Sub dgContenedor_rispy_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor_rispy.CellClick
        txtidrispy.Text = dgContenedor_rispy.SelectedCells.Item(0).Value
        txtconcepto_rispy.Text = dgContenedor_rispy.SelectedCells.Item(1).Value
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        If txtprocedimiento.Text <> "" And txtidosiris.Text <> "" And txtidrispy.Text <> "" Then
            sincronizar_procedimiento(txtidosiris.Text, txtidrispy.Text)
            sincronizar_concepto(txtidrispy.Text, txtconcepto_rispy.Text)
            llenar_datagridview_procedimientos_sinc()
            llenar_datagridview_rispy()
            limpiar()
        End If

    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidosiris.Text = dgContenedor.SelectedCells.Item(0).Value
        txtprocedimiento.Text = dgContenedor.SelectedCells.Item(1).Value
        txtidrispy.Text = dgContenedor.SelectedCells.Item(2).Value
    End Sub

    Private Sub limpiar()
        txtprocedimiento.Clear()
        txtidosiris.Clear()
        txtidrispy.Clear()
        txtconcepto_rispy.Clear()
    End Sub



    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub txtbuscar_osiris_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar_osiris.TextChanged
        buscar_osiris()
        txtbuscar_rispy.Text = txtbuscar_osiris.Text
    End Sub

    Private Sub txtbuscar_rispy_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar_rispy.TextChanged
        buscar_rispy()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar_sinc()
    End Sub

    Private Sub btncambiar_Click(sender As Object, e As EventArgs) Handles btncambiar.Click
        If txtprocedimiento.Text <> "" Then
            txtconcepto_rispy.Text = txtprocedimiento.Text
        End If
    End Sub

    Private Sub txtidrispy_TextChanged(sender As Object, e As EventArgs) Handles txtidrispy.TextChanged
        txtconcepto_rispy.Clear()
        Try
            If txtidrispy.Text <> "" Or txtidrispy.Text <> 0 Then
                buscar_concepto(txtidrispy.Text)
                If dr_agenda.Read Then
                    txtconcepto_rispy.Text = dr_agenda(0)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_procedimientos()
        llenar_datagridview_procedimientos_sinc()
        llenar_datagridview_rispy()
    End Sub
End Class