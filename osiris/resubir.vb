Imports System.ComponentModel
Imports System.IO.Compression
Imports System.Runtime.InteropServices

Public Class resubir

    'para formulariocon bordes redondeados
    'Public SD As Integer
    'Public Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (Dt As IntPtr, UI As Integer) As Integer
    'Public Declare Function GetDesktopWindow Lib "user32" () As Integer
    'Public Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (Dt As IntPtr, IDF As Integer, IGT As Integer) As Integer
    'Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (Wo As IntPtr, NI As Integer, NK As Integer) As Integer

    'Public Sub New()

    'Esta llamada es exigida por el diseñador.
    'InitializeComponent()

    'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    'SuspendLayout()
    'FormBorderStyle = FormBorderStyle.None
    'Const CS_DROPSHADOW As Integer = &H20000
    'SD = SetWindowLong(Handle, -0, GetDesktopWindow())
    'SetClassLong(Handle, -26, GetClassLong(Handle, -26) Or CS_DROPSHADOW)
    'ResumeLayout(False)
    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If dlg.ShowDialog() = DialogResult.OK Then
                txtdirectorio.Text = dlg.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtdirectorio_TextChanged(sender As Object, e As EventArgs) Handles txtdirectorio.TextChanged
        If System.IO.File.Exists(txtdirectorio.Text & "\DICOMDIR") Then
            lblinforme.Visible = True
            lblinforme.ForeColor = Color.Green
            lblinforme.Text = "LA CARPETA CONTIENE IMAGENES"
            Button4.Enabled = True
        Else
            lblinforme.Visible = True
            lblinforme.ForeColor = Color.Red
            lblinforme.Text = "LA CARPETA NO CONTIENE IMAGENES"
            Button4.Enabled = False
        End If
    End Sub

    Private Sub subir_archivo()

        My.Computer.Network.UploadFile("C:\osiris\files\temp\" & lblid.Text & ".zip", estudiosftp & lblid.Text & ".zip", "sadmin", "Sadmin7050*", True, 500)
        lblprogreso.Text = ""
        pbloading.Visible = False
        lblinforme.Text = ""
        txtdirectorio.Clear()
        MessageBox.Show("Estudio subido correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)


        System.IO.File.Delete("C:\osiris\files\temp\" & lblid.Text & ".zip")
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
        lblprogreso.Text = "COMPRIMIENDO EL ESTUDIO..."
        pbloading.Visible = True
        comprimir.RunWorkerAsync()
    End Sub

    Private Sub comprimir_DoWork(sender As Object, e As DoWorkEventArgs) Handles comprimir.DoWork

        'Crea las carpetas de cada usuario si aún no existen
        If (Not System.IO.Directory.Exists("C:\osiris\files\temp\")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp\")
        End If

        ZipFile.CreateFromDirectory(txtdirectorio.Text, "C:\osiris\files\temp\" & lblid.Text & ".zip")

    End Sub

    Private Sub comprimir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles comprimir.RunWorkerCompleted
        lblprogreso.Text = "SUBIENDO EL ESTUDIO..."
        subir_archivo()
    End Sub

    Private Sub resubir_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ToolTip1.SetToolTip(Me.Button5, "Seleccionar estudio desde CD/DVD o archivo")
        Me.ToolTip1.IsBalloon = True
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class