
Imports System.Security.Cryptography
Public Class login

    Dim nombre_pc As String
    Dim sala_pc As String

    'variable para almacenar el md5
    Dim PasConMd5 As String

    'funcion para encriptar contrasena
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


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub ok_Click_1(sender As Object, e As EventArgs) Handles ok.Click
        ingreso()
    End Sub

    Private Sub ingreso()

        Try
            'llamado a la funcion de encriptado de contrasena
            MD5EncryptPass(txtcontrasena.Text)

            consultar_usuario_login(txtusuario.Text, PasConMd5, txtidcentro.Text)
            If dr.Read Then
                main_menu.lblusuario.Text = dr(0)
                main_menu.txtidusuario.Text = Me.txtidusuario.Text
                main_menu.txtidcentro.Text = Me.txtidcentro.Text
                nombre_pc = My.Computer.Name
                'consultar_usuario_pc(nombre_pc, txtidusuario.Text)
                'If dr.Read Then
                'sala_pc = dr(2)
                'Crea las carpetas de cada usuario si aún no existen
                'Dim medico As String = dr(0) & " " & dr(1)
                If (Not System.IO.Directory.Exists("C:\osiris\files\temp")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\temp")
                End If

                If (Not System.IO.Directory.Exists("C:\osiris\files\estudios_descargados")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\estudios_descargados")
                End If

                If (Not System.IO.Directory.Exists("C:\osiris\files\firmas")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\firmas")
                End If

                If (Not System.IO.Directory.Exists("C:\osiris\files\informes_descargados")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\informes_descargados")
                End If

                If (Not System.IO.Directory.Exists("C:\osiris\files\estudios_anteriores")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\estudios_anteriores")
                End If
                If (Not System.IO.Directory.Exists("C:\osiris\files\logos_centros")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\logos_centros")
                End If
                If (Not System.IO.Directory.Exists("C:\osiris\files\adjuntos_agenda")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\adjuntos_agenda")
                End If
                If (Not System.IO.Directory.Exists("C:\osiris\files\estudios_modificados")) Then
                    System.IO.Directory.CreateDirectory("C:\osiris\files\estudios_modificados")
                End If
                'Else
                'MessageBox.Show("Lo sentimos pero no esta atorizado a usar el sistema en esta computadora. Comuniquese con el soporte técnico de LibertyTech", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If
                'main_menu.txtubi_visor.Text = dr(3)
                'main_menu.txtMipc.Text = sala_pc
                main_menu.txtidusuario_pc.Text = dr(0)
                main_menu.lblpc.Text = nombre_pc


                main_menu.Show()

                Me.Close()

            Else
                MessageBox.Show("El Usuario y/o la contraseña no validos o No ha seleccionado ningún CENTRO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtusuario.Clear()
                txtcontrasena.Clear()
                txtusuario.Select()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Shell("C:\Program Files\Fortinet\FortiClient\FortiClient.exe")
        End Try
    End Sub

    Private Sub cbCentro_TextChanged(sender As Object, e As EventArgs) Handles cbCentro.TextChanged
        If cbCentro.Text <> "" Then
            consultar_id_centro(cbCentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        If txtusuario.Text <> "" Then
            Try
                consultar_id_usuario(txtusuario.Text)
                If dr.Read Then
                    txtidusuario.Text = dr(0)
                End If
            Catch ex As Exception
                MessageBox.Show("Existe un problema con la conexión a la base de datos, favor comuniquese con un administrador del sistema para una posible solución", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If
    End Sub

    Private Sub txtidusuario_TextChanged(sender As Object, e As EventArgs) Handles txtidusuario.TextChanged
        Try
            cbCentro.Items.Clear()
            llenar_combobox_centrosXusuarios(cbCentro, txtidusuario.Text)
            cbCentro.SelectedItem = cbCentro.Items(0)
        Catch ex As Exception
            MessageBox.Show("El Usuario no posee ningún CENTRO asignado, favor comuniquese con un administrador del sistema para dicha asignación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub txtcontrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontrasena.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            ingreso()
        End If
    End Sub
End Class
