Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Net
Imports System.Net.Mail

Imports MySql.Data.MySqlClient
Imports System.Text
Public Class enviar_informe_medico
    'para el dataset
    Dim formulario As String = "enviar_informe_medico"

    Public cuerpo As String
    Public cin As String
    Public edad As String
    Public fecha As String
    Public estudio As String
    Public motivo As String
    Public paciente As String
    Public idcentro As Integer
    Public idcentro_solicitante As Integer
    Public idmedico As Integer
    Public idestudio As Integer
    Public tecnico As String
    Public fecha_informe As String
    Public doctor_solicitante As String
    Public firma_informe As String

    'Public logo_centro As Byte

    Dim medico As String
    Dim registro As String
    Dim especialidad As String
    Dim firma As String
    Dim alias_ As String

    Dim encabezado As String
    Dim centro As String
    Dim dir_centro As String
    Dim tel_centro As String
    Dim logo_cen As String

    Public flag As Integer

    Dim firmaInforme As String
    Dim formulario2 As String = "enviar_informe_medico"

    Private Sub consulta_med()
        Try
            consultar_usuario_id(idmedico)
            If dr.Read Then
                medico = dr(3)
                registro = dr(8)
                especialidad = dr(11)
                firma = dr(13)
                alias_ = dr(17)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub enviar_informe_medico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Text = "Vista Informe │ Dr./Dra. " & main_menu.lblusuario.Text
        consultar_centro(idcentro)
        If dr.Read Then
            lblemisor.Text = dr(13)
            lblpassword.Text = dr(15)
            lblhost.Text = dr(12)
            lblport.Text = dr(14)
        End If


        consulta_med()

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


        Dim objreporte As New informe_medico

        objreporte.SetParameterValue("cuerpo", cuerpo)
        'objreporte.SetParameterValue("id", idcentro)
        objreporte.SetParameterValue("cin", cin)
        objreporte.SetParameterValue("edad", edad)
        objreporte.SetParameterValue("fecha", fecha)
        objreporte.SetParameterValue("estudio", estudio)
        objreporte.SetParameterValue("motivo", motivo)
        objreporte.SetParameterValue("paciente", paciente)
        'objreporte.SetParameterValue("id", idcentro)
        'objreporte.SetParameterValue("idmed", idmedico)
        objreporte.SetParameterValue("tecnico", tecnico)
        objreporte.SetParameterValue("fecha_informe", fecha_informe)

        objreporte.SetParameterValue("estado", "[INFORME PRELIMINAR]")


        consultar_informe_estudio(idestudio, formulario)
        If dr.Read Then
            firmaInforme = dr(15)
        End If

        If firmaInforme = "SI" Then
            objreporte.SetParameterValue("firma", firma)
            objreporte.SetParameterValue("medico", medico)
            objreporte.SetParameterValue("registro", registro)
            objreporte.SetParameterValue("especialidad", especialidad)

        Else
            objreporte.SetParameterValue("firma", "")
            objreporte.SetParameterValue("medico", "")
            objreporte.SetParameterValue("registro", "")
            objreporte.SetParameterValue("especialidad", "")
        End If

        objreporte.SetParameterValue("alias_", alias_)

        If encabezado = "SI" Then
            objreporte.SetParameterValue("centro", centro)
            objreporte.SetParameterValue("dir_centro", dir_centro)
            objreporte.SetParameterValue("tel_centro", tel_centro)
            objreporte.SetParameterValue("logo_cen", logo_cen)
        Else
            objreporte.SetParameterValue("centro", "")
            objreporte.SetParameterValue("dir_centro", "")
            objreporte.SetParameterValue("tel_centro", "")
            objreporte.SetParameterValue("logo_cen", "")
        End If

        objreporte.SetParameterValue("doctor_solicitante", doctor_solicitante)
        objreporte.SetParameterValue("id", idestudio)

        If flag = 1 Then
            objreporte.SetParameterValue("estado", "")
        ElseIf flag = 3 Then
            objreporte.SetParameterValue("estado", "")
        End If
        CrystalReportViewer1.ReportSource = objreporte

    End Sub

    Public Sub ExportReport(ByVal XCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer)

        Try
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportClass ' Report Name
            CrReport = XCrystalReportViewer.ReportSource

            'Crea las carpetas de cada usuario si aún no existen
            If (Not System.IO.Directory.Exists("C:\osiris\files\temp")) Then
                System.IO.Directory.CreateDirectory("C:\osiris\files\temp")
            End If


            CrReport.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\osiris\files\temp\" & idestudio & " - " & paciente & ".pdf")

        Catch err As Exception

            'MessageBox.Show(err.ToString())

        End Try
    End Sub

    'envio de correo

    Private correos As New MailMessage
    Private envios As New SmtpClient


    Dim emisor As String
    Dim password As String
    Dim host As String
    Dim port As String
    Dim dir_adjunto As String

    Sub enviarCorreo()
        Try
            consultar_centro(idcentro)
            If dr.Read Then
                emisor = dr(13)
                lblemisor.Text = dr(13)
                password = dr(15)
                lblpassword.Text = dr(15)
                host = dr(12)
                lblhost.Text = dr(12)
                port = dr(14)
                lblport.Text = dr(14)
            End If

            dir_adjunto = "C:\osiris\files\temp\" & idestudio & " - " & paciente & ".pdf"

            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = "Informe médico de " & estudio & " del paciente " & paciente & " realizado en el centro médico " & centro & ". Este es un mensaje generado por sistema, por lo tanto por favor no lo responda. Sistema de envío de imagenes Osiris desarrollado por Lberty Tech S.A."
            correos.BodyEncoding = System.Text.Encoding.UTF8
            correos.Subject = "INFORME MÉDICO - " & paciente & ""
            correos.SubjectEncoding = System.Text.Encoding.UTF8
            correos.IsBodyHtml = True
            correos.To.Add(Trim(txtcorreo.Text))

            'If dir_adjunto <> "" Then
            Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(dir_adjunto)
                correos.Attachments.Add(archivo)
            'End If

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = host
            envios.Port = port
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Osiris", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtcorreo.Text <> "" Then
            ExportReport(CrystalReportViewer1)
            enviarCorreo()
            Me.Close()
        End If
    End Sub
End Class