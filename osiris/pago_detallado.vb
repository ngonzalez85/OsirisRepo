Imports MySql.Data.MySqlClient
Public Class pago_detallado

    Public idcentro As String

    Private Sub pago_detallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar lista")
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir reporte")
        Me.ToolTip1.IsBalloon = True

        llenar_datagridview_estudios("sinfiltro")

    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable

    'Dim db As String = "bdisis"

    Public Sub llenar_datagridview_estudios(dato)
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,DATE(e.fecha_hora) as fecha,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,(pr.procedimiento) AS estudio,
            e.tecnico,e.estado,e.fecha_firma,(u.nombre) AS medico,e.fecha_entrega,e.hora_entrega,e.idusuariomedico,(96800) AS monto 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario "

            If dato = "sinfiltro" Then

                consulta += "WHERE e.idcentro = '" & idcentro & "' AND date(e.fecha_hora) BETWEEN '" & desde & "' AND '" & hasta & "' AND e.estado='FIRMADO' 
            ORDER BY e.fecha_hora ASC "

            Else
                consulta += "WHERE e.idcentro = '" & idcentro & "' AND date(e.fecha_hora) BETWEEN '" & desde & "' AND '" & hasta & "' AND e.estado='FIRMADO' "

                Dim busqueda As String = txtbuscar.Text

                Dim arreglo As String() = Split(busqueda, " ")

                For i As Integer = 0 To arreglo.Length - 1 Step 1

                    '      consulta += "AND p.apellido like '" & arreglo(i) & "%' "

                    consulta += "AND u.nombre like '%" & arreglo(i) & "%' "
                Next

                consulta += " ORDER BY e.fecha_hora ASC"
                Console.WriteLine(consulta)

            End If

            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEstudios.DataSource = datos
            dgEstudios.DataMember = "estudios"
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
            Me.dgEstudios.Columns(0).HeaderText = "ID"
            Me.dgEstudios.Columns(1).HeaderText = "FECHA"
            Me.dgEstudios.Columns(2).HeaderText = "PACIENTE"
            Me.dgEstudios.Columns(3).Visible = False
            Me.dgEstudios.Columns(4).HeaderText = "ESTUDIO REALIZADO"
            Me.dgEstudios.Columns(5).Visible = False
            Me.dgEstudios.Columns(6).Visible = False
            Me.dgEstudios.Columns(7).Visible = False
            Me.dgEstudios.Columns(8).HeaderText = "MEDICO"
            Me.dgEstudios.Columns(9).Visible = False
            Me.dgEstudios.Columns(10).Visible = False
            Me.dgEstudios.Columns(11).Visible = False
            Me.dgEstudios.Columns(12).HeaderText = "MONTO"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sumar_datagrid()
        'Variable que guardara el valor
        Dim total As Double = 0

        Dim iTotal As Integer = Me.dgEstudios.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla

        Dim i As Integer

        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.dgEstudios(12, i).Value)
        Next

        lbltotal.Text = Format(total, "#,0")

    End Sub

    Private Sub cbbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbuscar.KeyPress
        e.Handled = True
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = txtlike.Text & " like '%" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgEstudios.DataSource = dv
                retocar_columnas()
            Else
                dgEstudios.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If cbfiltrado.Checked = True Then
            'buscar en base de datos'
        Else
            buscar()
        End If
    End Sub

    Private Sub cbbuscar_TextChanged(sender As Object, e As EventArgs) Handles cbbuscar.TextChanged
        If cbbuscar.Text = "PACIENTE" Then
            txtlike.Text = "paciente"
        ElseIf cbbuscar.Text = "ESTUDIO" Then
            txtlike.Text = "estudio"
        ElseIf cbbuscar.Text = "ESTADO" Then
            txtlike.Text = "estado"
        ElseIf cbbuscar.Text = "MEDICO" Then
            txtlike.Text = "medico"
        End If
        cbfiltrado.Checked = True
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_estudios("sinfiltro")
        Dim row As Integer = dgEstudios.RowCount
        If row > 0 Then
            dgEstudios.Rows(0).Selected = False
            If txtidtemp.Text <> "" Then
                Dim i As Integer = txtidtemp.Text
                dgEstudios.Item(0, i).Selected = True
            End If
        End If
    End Sub

    Private Sub dgEstudios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEstudios.CellClick
        txtidtemp.Text = dgEstudios.CurrentRow.Index
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        reporte_pagoDetallado.desde = Me.txtdesde.Text
        reporte_pagoDetallado.hasta = Me.txthasta.Text
        reporte_pagoDetallado.total = Me.lbltotal.Text
        reporte_pagoDetallado.Show()
    End Sub

    Private Sub txtbuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            If txtbuscar.Text <> "" And cbfiltrado.Checked = True Then
                'buscar en base de datos'
                llenar_datagridview_estudios("calculo")
            Else

                llenar_datagridview_estudios("sinfiltro")
            End If

        Else
            'buscar en base de datos'
            llenar_datagridview_estudios("sinfiltro")
        End If

        Console.WriteLine(e.KeyCode)
    End Sub
End Class