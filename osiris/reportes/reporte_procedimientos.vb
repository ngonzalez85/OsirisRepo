Public Class reporte_procedimientos

    Dim usuario As String = main_menu.lblusuario.Text
    Dim idcentro As Integer = main_menu.txtidcentro.Text
    Dim centro As String
    Dim dir_centro As String
    Dim tel_centro As String
    Dim logo_cen As String
    Dim encabezado As String
    Dim formulario As String = "reporte_procedimientos"

    Private Sub reporte_procedimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .Columns.Add("idprocedimiento")
            .Columns.Add("procedimiento")
            .Columns.Add("tipo")
        End With

        For Each dr As DataGridViewRow In procedimientos.dgContenedor.Rows
            dt.Rows.Add(dr.Cells("idprocedimiento").Value, dr.Cells("procedimiento").Value, dr.Cells("tipoestudio").Value)
        Next

        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New rpt_procedimientos
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

        rptdoc.SetParameterValue("usuario", usuario)

        Me.CrystalReportViewer1.ReportSource = rptdoc
    End Sub
End Class