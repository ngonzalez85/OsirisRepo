Imports MySql.Data.MySqlClient
'Imports System.Runtime.InteropServices
Public Class pacientes

    'conexion para bdpersona base de datos de cedulas paraguayas
    Dim cadConexion As String = "server=" & serverdb & ";database=bdpersona;user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
    Dim connec As New MySqlConnection(cadConexion)
    Dim cmd_ As New MySqlCommand
    Dim dr_ As MySqlDataReader
    Dim dt As DataTable

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

    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_centros()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT p.idpaciente,p.cin,p.nombre,p.apellido,p.edad,p.fecha_ingreso,p.fecha_ultimo_estudio,p.sexo,p.telefono,p.idseguro,s.seguro FROM pacientes p INNER JOIN seguros s ON  p.idseguro = s.idseguro WHERE p.habilitado = 1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "pacientes")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "pacientes"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "CINº"
            Me.dgContenedor.Columns(1).Width = 80
            Me.dgContenedor.Columns(2).HeaderText = "NOMBRE"
            Me.dgContenedor.Columns(2).Width = 100
            Me.dgContenedor.Columns(3).HeaderText = "APELLIDO"
            Me.dgContenedor.Columns(3).Width = 100
            Me.dgContenedor.Columns(4).HeaderText = "EDAD"
            Me.dgContenedor.Columns(4).Width = 70
            Me.dgContenedor.Columns(5).HeaderText = "F. INGRESO"
            Me.dgContenedor.Columns(5).Width = 110
            Me.dgContenedor.Columns(6).HeaderText = "F. ULTIMO EST."
            Me.dgContenedor.Columns(6).Width = 110
            Me.dgContenedor.Columns(7).HeaderText = "SEXO"
            Me.dgContenedor.Columns(7).Width = 80
            Me.dgContenedor.Columns(8).HeaderText = "TELEFONO"
            Me.dgContenedor.Columns(8).Width = 100
            Me.dgContenedor.Columns(9).Visible = False
            Me.dgContenedor.Columns(10).HeaderText = "SEGURO"
            Me.dgContenedor.Columns(10).Width = 100

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        txtseguro.Items.Clear()
        llenar_datagridview_centros()
        llenar_combobox_seguros(txtseguro)
        Me.ToolTip1.SetToolTip(Me.btnlimpiar, "Vaciar campos")
        Me.ToolTip1.IsBalloon = True
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidpaciente.Text = dgContenedor.SelectedCells.Item(0).Value
        txtci.Text = dgContenedor.SelectedCells.Item(1).Value
        txtnombre.Text = dgContenedor.SelectedCells.Item(2).Value
        txtapellido.Text = dgContenedor.SelectedCells.Item(3).Value
        txtedad.Text = dgContenedor.SelectedCells.Item(4).Value
        txtsexo.Text = dgContenedor.SelectedCells.Item(7).Value
        txttelefono.Text = dgContenedor.SelectedCells.Item(8).Value
        txtidseguro.Text = dgContenedor.SelectedCells.Item(7).Value
        txtseguro.Text = dgContenedor.SelectedCells.Item(10).Value
    End Sub

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

    Private Sub txtci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtci.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then

            If txtci.Text <> "" Then
                consultar_paciente(txtci.Text)
                If dr.Read Then
                    'txtidpaciente.Clear()
                    txtnombre.Clear()
                    txtapellido.Clear()
                    txtedad.Clear()
                    txtsexo.Text = ""
                    txtidpaciente.Text = dr(0)
                    txtnombre.Text = dr(2)
                    txtapellido.Text = dr(3)
                    txtedad.Text = dr(4)
                    txtsexo.Text = dr(7)
                Else

                    consultar_ci(txtci.Text)
                    If dr_.Read Then
                        'txtidpaciente.Clear()
                        txtnombre.Clear()
                        txtedad.Clear()
                        txtsexo.Text = ""
                        txtnombre.Text = dr_(3)
                        txtapellido.Text = dr_(2)
                        Dim fechaBD As String = dr_(4)

                        Try
                            Dim fecha2 As Date = Date.Parse(fechaBD)
                            Dim fecha1 As Date = Now
                            Dim edad As Long = DateDiff(DateInterval.Year, fecha2, fecha1)
                            txtedad.Text = edad
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

    Private Sub txtseguro_TextChanged(sender As Object, e As EventArgs) Handles txtseguro.TextChanged
        If txtseguro.Text <> "" Then
            consultar_id_seguro(txtseguro.Text)
            If dr.Read Then
                txtidseguro.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub guardar()
        Try

            Dim sql As String = "INSERT INTO pacientes (cin,nombre,apellido,edad,sexo,telefono,idseguro)values(?cin,?nombre,?apellido,?edad,?sexo,?telefono,?idseguro)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)


            Comando.Parameters.AddWithValue("?cin", txtci.Text)
            Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
            Comando.Parameters.AddWithValue("?apellido", txtapellido.Text)
            Comando.Parameters.AddWithValue("?edad", txtedad.Text)
            Comando.Parameters.AddWithValue("?sexo", txtsexo.Text)
            Comando.Parameters.AddWithValue("?telefono", txttelefono.Text)
            Comando.Parameters.AddWithValue("?idseguro", txtidseguro.Text)

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
            Dim sql As String = "UPDATE pacientes SET cin =?cin,nombre=?nombre,apellido=?apellido,edad=?edad,sexo=?sexo,telefono=?telefono,idseguro=?idseguro where idpaciente=?idpaciente"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idpaciente", txtidpaciente.Text)
            Comando.Parameters.AddWithValue("?cin", txtci.Text)
            Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
            Comando.Parameters.AddWithValue("?apellido", txtapellido.Text)
            Comando.Parameters.AddWithValue("?edad", txtedad.Text)
            Comando.Parameters.AddWithValue("?sexo", txtsexo.Text)
            Comando.Parameters.AddWithValue("?telefono", txttelefono.Text)
            Comando.Parameters.AddWithValue("?idseguro", txtidseguro.Text)

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
        txtidpaciente.Clear()
        txtci.Clear()
        txtedad.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txttelefono.Clear()
        txtsexo.Text = ""
        txtseguro.Text = ""
        txtidseguro.Clear()
        txtci.Select()
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        If txtidpaciente.Text <> "" Then
            If txtidpaciente.Text <> "" And txtci.Text <> "" And txtedad.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And txtsexo.Text <> "" And txtseguro.Text <> "" Then
                actualizar()
                llenar_datagridview_centros()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtci.Text <> "" And txtedad.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And txtsexo.Text <> "" And txtseguro.Text <> "" Then
                guardar()
                llenar_datagridview_centros()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtidpaciente_TextChanged(sender As Object, e As EventArgs) Handles txtidpaciente.TextChanged
        If txtidpaciente.Text <> "" Then
            btnRoles.Text = "ACTUALIZAR"
        Else
            btnRoles.Text = "GUARDAR"
        End If
    End Sub


    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtnombre.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtapellido.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()
    End Sub

    Private Sub buscar_nombre()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre" & " Like '%" & txtnombre.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor.DataSource = dv
                retocar_columnas()
            Else
                dgContenedor.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buscar_apellido()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "apellido" & " Like '%" & txtapellido.Text & "%'"

            If dv.Count <> 0 Then
                dgContenedor.DataSource = dv
                retocar_columnas()
            Else
                dgContenedor.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        ' buscar_nombre()
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged
        ' buscar_apellido()
    End Sub
End Class