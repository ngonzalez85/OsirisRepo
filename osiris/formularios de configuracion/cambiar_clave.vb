Imports System.Security.Cryptography
Public Class cambiar_clave
    Private Sub cambiar_clave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim PasConMd5 As String

    Private Sub MD5EncryptPass(ByVal StrPass As String)
        PasConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

    End Sub

    Private Sub txtveridicar_TextChanged(sender As Object, e As EventArgs) Handles txtveridicar.TextChanged
        If txtclave.Text = txtveridicar.Text Then
            lblreqpass.ForeColor = Color.Green
        Else
            lblreqpass.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btncambiar_Click(sender As Object, e As EventArgs) Handles btncambiar.Click
        If txtclave.Text <> "" And txtveridicar.Text <> "" Then
            If txtclave.Text = txtveridicar.Text Then
                MD5EncryptPass(txtclave.Text)
                actualizar_clave(PasConMd5, main_menu.txtidusuario.Text)
                MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtclave.Clear()
                txtveridicar.Clear()
                Me.Close()
            Else
                MessageBox.Show("Las claves no coinciden", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class