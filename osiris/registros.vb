Imports System.Drawing.Drawing2D
Public Class registros


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
    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        buttonBorderRadius(sender, 25)

    End Sub
    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub btnRoles_Paint(sender As Object, e As PaintEventArgs) Handles btnRoles.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub btnUsuarios_Paint(sender As Object, e As PaintEventArgs) Handles btnUsuarios.Paint
        buttonBorderRadius(sender, 25)
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        buttonBorderRadius(sender, 25)
    End Sub



    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        If main_menu.roles <> 0 Then
            roles.ShowDialog()
        End If

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        If main_menu.usuarios <> 0 Then
            usuarios.ShowDialog()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If main_menu.centros <> 0 Then
            centros.ShowDialog()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If main_menu.seguros <> 0 Then
            seguros.ShowDialog()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If main_menu.pacientes <> 0 Then
            pacientes.ShowDialog()
        End If

    End Sub

    Private Sub registros_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class