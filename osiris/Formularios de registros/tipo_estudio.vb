Imports MySql.Data.MySqlClient
Public Class tipo_estudio
    'llenar datagrid 
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_tipoestudios()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM tipo_estudios where habilitado=1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "tipoestudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "tipoestudios"
            retocar_columnas()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "TIPO DE ESTUDIO"
            Me.dgContenedor.Columns(1).Width = 300
            Me.dgContenedor.Columns(2).Visible = False
            Me.dgContenedor.Columns(3).Visible = False
            Me.dgContenedor.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tipo_estudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbmodalidad.Items.Clear()
        llenar_combobox_modalidades(cbmodalidad, main_menu.txtidcentro.Text)
        llenar_datagridview_tipoestudios()
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidtipoestudio.Text = dgContenedor.SelectedCells.Item(0).Value
        txttipoestudio.Text = dgContenedor.SelectedCells.Item(1).Value
        txtidmodalidad.Text = dgContenedor.SelectedCells.Item(3).Value
    End Sub

    Private Sub guardar()
        Try

            Dim sql As String = "INSERT INTO tipo_estudios (tipoestudio,idmodalidad)values(?tipoestudio,?idmodalidad)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)


            Comando.Parameters.AddWithValue("?tipoestudio", txttipoestudio.Text)
            Comando.Parameters.AddWithValue("?idmodalidad", txtidmodalidad.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()


            MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub actualizar()

        Try
            Dim sql As String = "UPDATE tipo_estudios SET tipoestudio =?tipoestudio,idmodalidad=?idmodalidad where idtipoestudio=?idtipoestudio"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idtipoestudio", txtidtipoestudio.Text)
            Comando.Parameters.AddWithValue("?tipoestudio", txttipoestudio.Text)
            Comando.Parameters.AddWithValue("?idmodalidad", txtidmodalidad.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub quitar()

        Try
            Dim sql As String = "UPDATE tipo_estudios SET habilitado =0 where idtipoestudio=?idtipoestudio"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idtipoestudio", txtidtipoestudio.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            MessageBox.Show("Datos eliminados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub limpiar()
        txtidtipoestudio.Clear()
        txttipoestudio.Clear()
        txttipoestudio.Select()
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        If txtidtipoestudio.Text <> "" Then
            If txttipoestudio.Text <> "" Then
                limpiar()

            End If
        Else
            If txttipoestudio.Text <> "" Then
                guardar()
                procedimientos.actualizar_combo()
                llenar_datagridview_tipoestudios()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtidtipoestudio_TextChanged(sender As Object, e As EventArgs) Handles txtidtipoestudio.TextChanged
        If txtidtipoestudio.Text <> "" Then
            btnaccion.Text = "NUEVO"
            Button1.Visible = True
        Else
            btnaccion.Text = "GUARDAR"
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtidtipoestudio.Text <> "" Then
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar el registro?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                quitar()
                llenar_datagridview_tipoestudios()
                procedimientos.actualizar_combo()
            End If
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub txtidmodalidad_TextChanged(sender As Object, e As EventArgs) Handles txtidmodalidad.TextChanged
        If txtidmodalidad.Text <> "" Then
            consultar_modalidad(main_menu.txtidcentro.Text, txtidmodalidad.Text)
            If dr.Read Then
                If Not IsDBNull(dr(2)) Then
                    cbmodalidad.Text = dr(2)
                End If
            End If
        End If
    End Sub

    Private Sub cbmodalidad_TextChanged(sender As Object, e As EventArgs) Handles cbmodalidad.TextChanged
        If cbmodalidad.Text <> "" Then
            consultar_modalidadXcentro(main_menu.txtidcentro.Text, cbmodalidad.Text)
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    txtidmodalidad.Text = dr(0)
                End If
            End If
        End If
    End Sub
End Class