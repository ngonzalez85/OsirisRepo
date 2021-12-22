Imports System.Drawing.Drawing2D
Public Class administracion

    Public Sub buttonBorderRadius(ByRef buttonObj As Object, ByVal borderRadiusINT As Integer)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        'TOP LEFT CORNER 
        p.AddArc(New Rectangle(0, 0, borderRadiusINT, borderRadiusINT), 180, 90)
        p.AddLine(40, 0, buttonObj.Width - borderRadiusINT, 0)
        'TOP RIGHT CORNER 
        p.AddArc(New Rectangle(buttonObj.Width - borderRadiusINT, 0, borderRadiusINT, borderRadiusINT), -90, 90)
        p.AddLine(buttonObj.Width, 40, buttonObj.Width, buttonObj.Height - borderRadiusINT)
        'BOTTOM RIGHT CORNER 
        p.AddArc(New Rectangle(buttonObj.Width - borderRadiusINT, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 0, 90)
        p.AddLine(buttonObj.Width - borderRadiusINT, buttonObj.Height, borderRadiusINT, buttonObj.Height)
        'BOTTOM LEFT CORNER 
        p.AddArc(New Rectangle(0, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 90, 90)
        p.CloseFigure()
        buttonObj.Region = New Region(p)
    End Sub
    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        buttonBorderRadius(sender, 25)

    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        buttonBorderRadius(sender, 25)

    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        buttonBorderRadius(sender, 25)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If main_menu.asignacion_informes <> 0 Then
            asignacion.Close()
            asignacion.ShowDialog()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If main_menu.busqueda_informes <> 0 Then

            'FUNCION PARA CERRAR FORMLARIO SI ESTA ABIERTO
            For Each f As Form In Application.OpenForms
                If Not f.InvokeRequired Then
                    If f.Name = "busqueda_informe" Then
                        f.Close()
                        Exit For
                    End If
                End If
            Next
            busqueda_informe.ShowDialog()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pagos.ShowDialog()
        'busqueda_reporte.ShowDialog()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub administracion_Load(sender As Object, e As EventArgs) Handles Me.Load
        If main_menu.reporte = 1 Then
            Button3.Visible = True
        Else
            Button3.Visible = False
        End If

        If main_menu.reportemedico = 1 Then
            Button4.Visible = True
        Else
            Button4.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pagos_medicos.ShowDialog()
    End Sub
End Class