Public Class agregar_correo
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As envio = CType(Owner, envio)
        If txtcorreo.Text <> "" Then
            frm.txtcorreo.Text = Me.txtcorreo.Text
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class