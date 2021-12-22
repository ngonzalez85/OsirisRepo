Imports System.IO
Imports System.Runtime.InteropServices
Public Class config_sistema


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

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar los archivos temporales?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Try
                eliminar_estudios()
                eliminar_anteriores()
                eliminar_tempoales()
                eliminar_informes()
                eliminar_adjuntos_agenda()
            Catch ex As Exception

            End Try

            MessageBox.Show("Archivos temporales eliminados", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub eliminar_estudios()
        For Each fichero As String In Directory.GetFiles("C:\osiris\files\estudios_descargados", "*.zip")
            File.Delete(fichero)
        Next
    End Sub

    Private Sub eliminar_anteriores()
        For Each fichero As String In Directory.GetFiles("C:\osiris\files\estudios_anteriores", "*.zip")
            File.Delete(fichero)
        Next
    End Sub

    Private Sub eliminar_tempoales()
        For Each fichero As String In Directory.GetFiles("C:\osiris\files\temp", "*.zip")
            File.Delete(fichero)
        Next
    End Sub

    Private Sub eliminar_informes()
        For Each fichero As String In Directory.GetFiles("C:\osiris\files\informes_descargados", "*.pdf")
            File.Delete(fichero)
        Next
    End Sub

    Private Sub eliminar_adjuntos_agenda()
        For Each fichero As String In Directory.GetFiles("C:\osiris\files\adjuntos_agenda", "*.*")
            File.Delete(fichero)
        Next
    End Sub

    Private Sub config_sistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If main_menu.lblrol.Text = "MEDICO" Then
            cbvisor_auto.Enabled = True
            cbfirma_informe.Enabled = True
        ElseIf main_menu.lblrol.Text = "MEDICO ADMINISTRADOR" Then
            cbvisor_auto.Enabled = True
            cbfirma_informe.Enabled = True
        Else
            cbvisor_auto.Enabled = False
            cbfirma_informe.Enabled = False
        End If

        Try
            consultar_usuario_(main_menu.txtidusuario.Text)
            If dr.Read Then
                cbvisor_auto.Text = dr(0)
                cbfirma_informe.Text = dr(1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbvisor_auto_TextChanged(sender As Object, e As EventArgs) Handles cbvisor_auto.TextChanged
        Try
            If cbvisor_auto.Text <> "" And cbfirma_informe.Text <> "" Then
                actualizar_configuracion_usuario(cbvisor_auto.Text, cbfirma_informe.Text, main_menu.txtidusuario.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbfirma_informe_TextChanged(sender As Object, e As EventArgs) Handles cbfirma_informe.TextChanged
        Try
            If cbvisor_auto.Text <> "" And cbfirma_informe.Text <> "" Then
                actualizar_configuracion_usuario(cbvisor_auto.Text, cbfirma_informe.Text, main_menu.txtidusuario.Text)
            End If
        Catch ex As Exception

        End Try

        If cbfirma_informe.Text = "SI" Then
            main_menu.lblfirma_informe.Text = "SI"
        Else
            main_menu.lblfirma_informe.Text = "NO"
        End If
    End Sub

    Private Sub cbformulario_TextChanged(sender As Object, e As EventArgs)
        Try
            If cbvisor_auto.Text <> "" And cbfirma_informe.Text <> "" Then
                actualizar_configuracion_usuario(cbvisor_auto.Text, cbfirma_informe.Text, main_menu.txtidusuario.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class