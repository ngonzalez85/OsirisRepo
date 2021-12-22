Public Class preview
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If lblpagina.Text = "1 de 4" Then
            pbPreview.Image = pbminiatura2.Image
            lblpagina.Text = "2 de 4"
        ElseIf lblpagina.Text = "2 de 4" Then
            pbPreview.Image = pbminiatura3.Image
            lblpagina.Text = "3 de 4"
        ElseIf lblpagina.Text = "3 de 4" Then
            pbPreview.Image = pbminiatura4.Image
            lblpagina.Text = "4 de 4"
        ElseIf lblpagina.Text = "4 de 4" Then
            pbPreview.Image = pbminiatura1.Image
            lblpagina.Text = "1 de 4"
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If lblpagina.Text = "1 de 4" Then
            pbPreview.Image = pbminiatura4.Image
            lblpagina.Text = "4 de 4"
        ElseIf lblpagina.Text = "2 de 4" Then
            pbPreview.Image = pbminiatura1.Image
            lblpagina.Text = "1 de 4"
        ElseIf lblpagina.Text = "3 de 4" Then
            pbPreview.Image = pbminiatura2.Image
            lblpagina.Text = "2 de 4"
        ElseIf lblpagina.Text = "4 de 4" Then
            pbPreview.Image = pbminiatura3.Image
            lblpagina.Text = "3 de 4"
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Me.Refresh()
        If pbPreview.Image IsNot Nothing Then
            pbPreview.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            pbPreview.Refresh()
        End If
    End Sub

    Private Sub pbPreview_MouseWheel(sender As Object, e As MouseEventArgs) Handles pbPreview.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                If pbPreview.Width < 500 Then Exit Sub 'minimum 500?
            Else
                If pbPreview.Width > 2000 Then Exit Sub 'maximum 2000?
            End If
            pbPreview.Width += CInt(pbPreview.Width * e.Delta / 1000)
            pbPreview.Height += CInt(pbPreview.Height * e.Delta / 1000)
        End If
    End Sub

    Private Sub pbPreview_MouseDown(sender As Object, e As MouseEventArgs) Handles pbPreview.MouseDown
        'el boton izquierdo esta pulsado
        If e.Button = MouseButtons.Left Then
            btnDown = True
            offsetX = e.X
            offsetY = e.Y
        End If
    End Sub

    Private Sub pbPreview_MouseMove(sender As Object, e As MouseEventArgs) Handles pbPreview.MouseMove
        If btnDown Then
            'mover el pictureBox con el raton               
            pbPreview.Left += e.X - offsetX
            pbPreview.Top += e.Y - offsetY
        End If
    End Sub

    Private Sub pbPreview_MouseUp(sender As Object, e As MouseEventArgs) Handles pbPreview.MouseUp
        'el boton izquierdo se libera
        If e.Button = MouseButtons.Left Then
            btnDown = False
        End If
    End Sub

    Dim btnDown As Boolean
    Dim offsetX As Integer
    Dim offsetY As Integer

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class