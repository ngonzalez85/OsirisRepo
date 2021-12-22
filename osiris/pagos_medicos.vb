Imports MySql.Data.MySqlClient

Public Class pagos_medicos
    Private Sub pagos_medicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datagridview("sinfiltro")
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir reporte")
        Me.ToolTip1.IsBalloon = True
        Try
            cbCentro_usuario.Items.Clear()
            llenar_combobox_centrosXusuarios(cbCentro_usuario, main_menu.txtidusuario.Text)
            cbCentro_usuario.SelectedItem = cbCentro_usuario.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        txtbuscar.ForeColor = Color.Gray
        txtbuscar.Text = "Nombre del Medico"
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable

    'Dim db As String = "bdisis"

    Public Sub llenar_datagridview(tipo)
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT COUNT(e.idestudio) cant_estudios,c.nombre centro,(pr.procedimiento) AS estudio,(u.nombre) AS medico,
            e.idusuariomedico, e.idprocedimiento, SUM(pc.medico) total
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario
            INNER JOIN precios pc ON e.idcentro=pc.idcentro
            INNER JOIN centros c ON e.idcentro=c.idcentro "

            If tipo = "sinfiltro" Then

                consulta += " WHERE e.idcentro ='" & txtidcentro_usuario.Text & "'  AND e.estado='FIRMADO' AND DATE(e.fecha_hora)  BETWEEN '" & desde & "' AND '" & hasta & "' 
            GROUP BY e.idprocedimiento "

            Else
                consulta += "WHERE e.idcentro ='" & txtidcentro_usuario.Text & "'  AND e.estado='FIRMADO' AND DATE(e.fecha_hora)  BETWEEN '" & desde & "' AND '" & hasta & "' "

                Dim busqueda As String = txtbuscar.Text

                Dim arreglo As String() = Split(busqueda, " ")

                For i As Integer = 0 To arreglo.Length - 1 Step 1

                    consulta += "AND u.nombre like '%" & arreglo(i) & "%' "
                Next

                consulta += "GROUP BY e.idprocedimiento"
                Console.WriteLine(consulta)

            End If
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "pagos")
            dgEstudios.DataSource = datos
            dgEstudios.DataMember = "pagos"
            retocar_columnas()
            sumar_datagrid()
            lblcant.Text = dgEstudios.Rows.Count
        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Esta experimentado problemas con la conexión de la base de datos, favor comuníquese con el departamento técnico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgEstudios.Columns(0).HeaderText = "CANT. INF"
            Me.dgEstudios.Columns(1).HeaderText = "CENTRO"
            Me.dgEstudios.Columns(2).HeaderText = "ESTUDIO"
            Me.dgEstudios.Columns(3).HeaderText = "MEDICO"
            Me.dgEstudios.Columns(4).Visible = False
            Me.dgEstudios.Columns(5).Visible = False
            Me.dgEstudios.Columns(6).HeaderText = "TOTAL"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sumar_datagrid()
        'Variable que guardara el valor
        Dim cant_inf As Double = 0
        Dim total As Double = 0
        Dim total_medvital As Double = 0

        Dim iTotal As Integer = Me.dgEstudios.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla

        Dim i As Integer

        For i = 0 To iTotal - 1
            cant_inf = cant_inf + Double.Parse(Me.dgEstudios(0, i).Value)
            total = total + Double.Parse(Me.dgEstudios(6, i).Value)
        Next

        txtcant_informes.Text = Format(cant_inf, "#,0")
        txttotalpagar.Text = Format(total, "GS #,0")

    End Sub

    Private Sub cbCentro_usuario_TextChanged(sender As Object, e As EventArgs) Handles cbCentro_usuario.TextChanged
        If cbCentro_usuario.Text <> "" Then
            consultar_id_centro(cbCentro_usuario.Text)
            If dr.Read Then
                txtidcentro_usuario.Text = dr(0)
            End If
        End If
        llenar_datagridview("sinfiltro")
    End Sub

    Private Sub txtdesde_ValueChanged(sender As Object, e As EventArgs) Handles txtdesde.ValueChanged
        llenar_datagridview("sinfiltro")
    End Sub

    Private Sub txthasta_ValueChanged(sender As Object, e As EventArgs) Handles txthasta.ValueChanged
        llenar_datagridview("sinfiltro")
    End Sub

    Private Sub cbCentro_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCentro_usuario.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtbuscar_LostFocus(sender As Object, e As EventArgs) Handles txtbuscar.LostFocus
        If Trim(txtbuscar.Text) = Nothing Then
            txtbuscar.ForeColor = Color.Gray
            txtbuscar.Text = "Nombre del medico"
        End If
    End Sub

    Private Sub txtbuscar_GotFocus(sender As Object, e As EventArgs) Handles txtbuscar.GotFocus
        If txtbuscar.Text = "NOMBRE DEL MEDICO" Then
            txtbuscar.ForeColor = Color.Black
            txtbuscar.Text = ""
        End If
    End Sub

    Private Sub txtbuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            If txtbuscar.Text <> "" Then
                'buscar en base de datos'
                llenar_datagridview("calculo")
            Else

                llenar_datagridview("sinfiltro")
            End If

        Else
            'buscar en base de datos'
            llenar_datagridview("sinfiltro")
        End If

        Console.WriteLine(e.KeyCode)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        reportemedicos.desde = Me.txtdesde.Text
        reportemedicos.hasta = Me.txthasta.Text
        reportemedicos.centro_consulta = Me.cbCentro_usuario.Text
        reportemedicos.cant_inf = Me.txtcant_informes.Text
        reportemedicos.total_pagar = Me.txttotalpagar.Text
        reportemedicos.idcentro = Me.txtidcentro_usuario.Text
        reportemedicos.Show()
    End Sub
End Class