Imports System.IO
Imports CrystalDecisions.Shared

Public Class reporte_estudios

    Dim usuario As String = main_menu.lblusuario.Text
    Dim idcentro As Integer = main_menu.txtidcentro.Text
    Dim centro As String
    Dim dir_centro As String
    Dim tel_centro As String
    Dim logo_cen As String
    Dim encabezado As String
    Public desde As String
    Public hasta As String
    Public centro_consulta As String
    Dim formulario As String = "reporte_estudios"
    Private Sub reporte_estudios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .Columns.Add("id")
            .Columns.Add("fecha")
            .Columns.Add("paciente")
            .Columns.Add("edad")
            .Columns.Add("estudio")
            .Columns.Add("medico")
            .Columns.Add("estado")
        End With

        For Each dr As DataGridViewRow In busqueda_informe.dgContenedor.Rows
            dt.Rows.Add(dr.Cells("idestudio").Value, dr.Cells("fecha_hora").Value, dr.Cells("paciente").Value, dr.Cells("edad").Value, dr.Cells("procedimiento").Value, dr.Cells("nombre").Value, dr.Cells("estado").Value)
        Next

        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New rpt_estudios
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

        Me.CrystalReportViewer1.ReportSource = rptdoc

    End Sub
End Class