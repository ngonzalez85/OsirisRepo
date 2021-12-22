Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Public Class descagar_estudio
    Private Sub btncambiar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click
        btndescargar.Enabled = False
        btndescargar.Text = "Descargando..."
        pbloading.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub descagar_estudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub descargar_estudios_()
        Try

            If (Not File.Exists("C:\osiris\files\temp\" & lblid.Text & ".zip")) Then

                My.Computer.Network.DownloadFile(estudiosftp & lblid.Text & ".zip", "C:\osiris\files\temp\" & lblid.Text & ".zip", "sadmin", "Sadmin7050*", False, 11000, True)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnlogo_Click(sender As Object, e As EventArgs) Handles btnlogo.Click
        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txtdireccion.Text = FolderBrowserDialog1.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub descomprir_estudio()
        Try
            System.IO.Directory.CreateDirectory(txtdireccion.Text & "\" & lblid.Text & " - " & lblpaciente.Text)
            Dim directorio_final As String = txtdireccion.Text & "\" & lblid.Text & " - " & lblpaciente.Text
            System.IO.Compression.ZipFile.ExtractToDirectory("C:\osiris\files\temp\" & lblid.Text & ".zip", directorio_final)
            btndescargar.Text = "Descargar"
            pbloading.Visible = False
            MessageBox.Show("Estudio descargado correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.IO.File.Delete("C:\osiris\files\temp\" & lblid.Text & ".zip")
            Process.Start("explorer.exe", txtdireccion.Text)
            txtdireccion.Clear()
            btndescargar.Enabled = True
            Me.Close()
        Catch ex As Exception
            btndescargar.Text = "Descargar"
            pbloading.Visible = False
            btndescargar.Enabled = True
            MessageBox.Show("Ya existe una carpeta con el mismo nombre en el directorio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        descargar_estudios_()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        btndescargar.Text = "Descomprimiendo..."
        descomprir_estudio()
    End Sub
End Class