Public Class reporte_pagos
    Dim usuario As String = main_menu.lblusuario.Text
    Public idcentro As Integer
    Dim centro As String
    Dim dir_centro As String
    Dim tel_centro As String
    Dim logo_cen As String
    Dim encabezado As String
    Public desde As String
    Public hasta As String
    Public centro_consulta As String
    Public cant_inf As String
    Public total_pagar As String
    Public comision As String
    Public neto As String
    Public total_medvital As String
    Dim formulario As String = "reporte_pagos"

    Private Sub reporte_pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            consultar_centro(idcentro)
            If dr.Read Then
                centro = dr(1)
                dir_centro = dr(7)
                tel_centro = dr(3)
                logo_cen = dr(17)
                encabezado = dr(18)
            End If
        Catch ex As Exception

        End Try


        Dim dt As New DataTable

        With dt
            .Columns.Add("cant_estudios")
            .Columns.Add("centro")
            .Columns.Add("medico")
            .Columns.Add("a_pagar")
            .Columns.Add("comision")
            .Columns.Add("medvital")
            .Columns.Add("neto")
        End With

        For Each dr As DataGridViewRow In pagos.dgEstudios.Rows
            dt.Rows.Add(dr.Cells("cant_estudios").Value, dr.Cells("centro").Value, dr.Cells("medico").Value, dr.Cells("a_pagar").Value, dr.Cells("comision").Value, dr.Cells("medvital").Value, dr.Cells("neto").Value)
        Next

        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New rpt_pagos
        rptdoc.SetDataSource(dt)

        If encabezado = "SI" Then
            rptdoc.SetParameterValue("centro", centro)
            rptdoc.SetParameterValue("dir_centro", dir_centro)
            rptdoc.SetParameterValue("tel_centro", tel_centro)
            rptdoc.SetParameterValue("logo_cen", logo_cen)
        Else
            rptdoc.SetParameterValue("centro", "")
            rptdoc.SetParameterValue("dir_centro", "")
            rptdoc.SetParameterValue("tel_centro", "")
            rptdoc.SetParameterValue("logo_cen", "")
        End If

        rptdoc.SetParameterValue("desde", desde)
        rptdoc.SetParameterValue("hasta", hasta)
        rptdoc.SetParameterValue("centro_consulta", centro_consulta)
        rptdoc.SetParameterValue("usuario", usuario)
        rptdoc.SetParameterValue("cant_inf", cant_inf)
        rptdoc.SetParameterValue("total_pagar", total_pagar)
        rptdoc.SetParameterValue("comision", comision)
        rptdoc.SetParameterValue("total_medvital", total_medvital)
        rptdoc.SetParameterValue("neto_pagar", neto)


        Me.CrystalReportViewer1.ReportSource = rptdoc
    End Sub
End Class