Imports System.Security.Cryptography
Public Class navegador_agenda
    Dim token As Integer
    Dim ci As String
    Private Sub navegador_agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaUsuario()
        generar_aleatorio()
        MD5EncryptPass(token)
        login_agenda_token(PasConMd5, ci)
        Dim webAddress As String = "http://agenda.medvital.com.py/login.php?token=" & PasConMd5
        Process.Start(webAddress)
        'navegador.Navigate("http://agenda.medvital.com.py/login.php?token=" & PasConMd5)

    End Sub

    Dim PasConMd5 As String

    Private Sub consultaUsuario()
        consultar_usuario_id(main_menu.txtidusuario.Text)
        If dr.Read Then
            ci = dr(1)
        End If
    End Sub
    Private Sub generar_aleatorio()
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 1500000)
        token = System.Convert.ToString(numAleatorio.Next)
    End Sub

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
End Class