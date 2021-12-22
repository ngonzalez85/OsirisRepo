Public Class reporte_pagoDetallado
    Dim usuario As String = main_menu.lblusuario.Text
    Dim idcentro As Integer = main_menu.txtidcentro.Text
    Dim centro As String
    Dim dir_centro As String
    Dim tel_centro As String
    Dim logo_cen As String
    Dim encabezado As String
    Public desde As String
    Public hasta As String
    Public centro_consulta As String = "NINGUNO"
    Public total As String
    Dim formulario As String = "reporte_pagoDetallado"
    Private Sub reporte_pagoDetallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .Columns.Add("idestudio")
            .Columns.Add("fecha")
            .Columns.Add("paciente")
            .Columns.Add("estudio")
            .Columns.Add("medico")
            .Columns.Add("monto")
        End With

        For Each dr As DataGridViewRow In pago_detallado.dgEstudios.Rows
            dt.Rows.Add(dr.Cells("idestudio").Value, dr.Cells("fecha").Value, dr.Cells("paciente").Value, dr.Cells("estudio").Value, dr.Cells("medico").Value, dr.Cells("monto").Value)
        Next

        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New rpt_pago_detallado
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
        rptdoc.SetParameterValue("total", total)
        rptdoc.SetParameterValue("usuario", usuario)

        Me.CrystalReportViewer1.ReportSource = rptdoc
    End Sub
End Class