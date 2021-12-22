Imports MySql.Data.MySqlClient
Public Class pagos
    Private Sub pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datagridview()
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir reporte")
        Me.ToolTip1.IsBalloon = True
        Try
            cbCentro_usuario.Items.Clear()
            llenar_combobox_centrosXusuarios(cbCentro_usuario, main_menu.txtidusuario.Text)
            cbCentro_usuario.SelectedItem = cbCentro_usuario.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable

    'Dim db As String = "bdisis"

    Public Sub llenar_datagridview()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT COUNT(e.idestudio) AS cant_estudios,c.nombre AS centro,u.nombre AS medico, 
            (COUNT(e.idestudio) * (p.medico + p.centro + p.comisioninfo)) AS a_pagar,
            (COUNT(e.idestudio) * p.comisioninfo) AS comision,   
            (COUNT(e.idestudio) * p.centro) AS medvital, 
            ((COUNT(e.idestudio) * (p.medico + p.centro + p.comisioninfo))-(COUNT(e.idestudio) * (p.comisioninfo + p.centro))) as neto 
            FROM estudios e  
            INNER JOIN usuarios u ON e.idusuariomedico= u.idusuario 
            INNER JOIN centros c ON e.idcentro=c.idcentro
            INNER JOIN precios p ON c.idcentro=p.idcentro
            WHERE e.estado='FIRMADO' AND date(e.fecha_hora) BETWEEN '" & desde & "' AND '" & hasta & "' AND e.idcentro= '" & txtidcentro_usuario.Text & "' 
            GROUP BY e.idusuariomedico,e.idcentro"
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
            Me.dgEstudios.Columns(0).HeaderText = "CANT. INF."
            Me.dgEstudios.Columns(1).HeaderText = "CENTRO"
            Me.dgEstudios.Columns(2).HeaderText = "MEDICO"
            Me.dgEstudios.Columns(3).HeaderText = "MONTO TOTAL"
            Me.dgEstudios.Columns(4).HeaderText = "COMISION"
            Me.dgEstudios.Columns(5).HeaderText = "MEDVITAL"
            Me.dgEstudios.Columns(6).HeaderText = "NETO A PAGAR"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sumar_datagrid()
        'Variable que guardara el valor
        Dim cant_inf As Double = 0
        Dim total As Double = 0
        Dim comision As Double = 0
        Dim neto As Double = 0
        Dim total_medvital As Double = 0

        Dim iTotal As Integer = Me.dgEstudios.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla

        Dim i As Integer

        For i = 0 To iTotal - 1
            cant_inf = cant_inf + Double.Parse(Me.dgEstudios(0, i).Value)
            total = total + Double.Parse(Me.dgEstudios(3, i).Value)
            comision = comision + Double.Parse(Me.dgEstudios(4, i).Value)
            total_medvital = total_medvital + Double.Parse(Me.dgEstudios(5, i).Value)
            neto = neto + Double.Parse(Me.dgEstudios(6, i).Value)
        Next

        txtcant_informes.Text = Format(cant_inf, "#,0")
        txttotalpagar.Text = Format(total, "GS #,0")
        txttotalcomision.Text = Format(comision, "GS #,0")
        txttotalmedvital.Text = Format(total_medvital, "GS #,0")
        txtneto.Text = Format(neto, "GS #,0")

    End Sub

    Private Sub cbCentro_usuario_TextChanged(sender As Object, e As EventArgs) Handles cbCentro_usuario.TextChanged
        If cbCentro_usuario.Text <> "" Then
            consultar_id_centro(cbCentro_usuario.Text)
            If dr.Read Then
                txtidcentro_usuario.Text = dr(0)
            End If
        End If
        llenar_datagridview()
    End Sub

    Private Sub txtdesde_ValueChanged(sender As Object, e As EventArgs) Handles txtdesde.ValueChanged
        llenar_datagridview()
    End Sub

    Private Sub txthasta_ValueChanged(sender As Object, e As EventArgs) Handles txthasta.ValueChanged
        llenar_datagridview()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        reporte_pagos.desde = Me.txtdesde.Text
        reporte_pagos.hasta = Me.txthasta.Text
        reporte_pagos.idcentro = Me.txtidcentro_usuario.Text
        reporte_pagos.centro_consulta = Me.cbCentro_usuario.Text
        reporte_pagos.cant_inf = Me.txtcant_informes.Text
        reporte_pagos.total_pagar = Me.txttotalpagar.Text
        reporte_pagos.comision = Me.txttotalcomision.Text
        reporte_pagos.total_medvital = Me.txttotalmedvital.Text
        reporte_pagos.neto = Me.txtneto.Text
        reporte_pagos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pago_detallado.txtdesde.Value = Me.txtdesde.Text
        pago_detallado.txthasta.Value = Me.txthasta.Text
        pago_detallado.idcentro = Me.txtidcentro_usuario.Text
        pago_detallado.Show()
    End Sub

    Private Sub cbCentro_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCentro_usuario.KeyPress
        e.Handled = True
    End Sub
End Class