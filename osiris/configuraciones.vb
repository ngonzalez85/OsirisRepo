Imports System.Drawing.Drawing2D
Public Class configuraciones

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

    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If main_menu.centros_usuario <> 0 Then
            medicos_centros.ShowDialog()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If main_menu.plantilla <> 0 Then
            plantillas.ShowDialog()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If main_menu.modalidades <> 0 Then
            modalidades.ShowDialog()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If main_menu.procedimientos <> 0 Then
            procedimientos.ShowDialog()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If main_menu.tarifa_procedimientos <> 0 Then
            procedimientos_centros.ShowDialog()
        End If

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sicronizar_procedimiento.Show()
    End Sub

    Private Sub Button6_Paint(sender As Object, e As PaintEventArgs) Handles Button6.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        tipo_estudio.Show()
    End Sub

    Private Sub Button7_Paint(sender As Object, e As PaintEventArgs) Handles Button7.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If main_menu.frase <> 0 Then
            frases.ShowDialog()
        End If
    End Sub

    Private Sub Button8_Paint(sender As Object, e As PaintEventArgs) Handles Button8.Paint
        buttonBorderRadius(sender, 25)
    End Sub
End Class