Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports MySql.Data.MySqlClient
Public Class verestudios
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim formulario As String = "adjuntos"

    Private Sub verestudios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidmodificado.Clear()
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        Me.ToolTip1.SetToolTip(Me.btndescargar, "Descargar y ver estudio modificado")
        Me.ToolTip1.IsBalloon = True

        llenar_datagridview()

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub limpiar()
        txtarchivo.Text = ""
        btndescargar.Visible = False
    End Sub

    Public Sub llenar_datagridview()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM estudios_modificados WHERE idestudio = '" & txtidestudio.Text & "' "
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios_modificados")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios_modificados"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor.Columns(1).HeaderText = "ORD"
            Me.dgContenedor.Columns(2).HeaderText = "ESTUDIO"
            Me.dgContenedor.Columns(3).Visible = False
            Me.dgContenedor.Columns(4).HeaderText = "FECHA DE SUBIDA"
            Me.dgContenedor.Columns(5).HeaderText = "OBS."

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgContenedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellContentClick
        txtidmodificado.Text = dgContenedor.SelectedCells.Item(0).Value
        txtarchivo.Text = dgContenedor.SelectedCells.Item(3).Value
    End Sub

    Private Sub txtarchivo_TextChanged(sender As Object, e As EventArgs) Handles txtarchivo.TextChanged
        If txtarchivo.Text <> "" Then
            btndescargar.Visible = True
        Else
            btndescargar.Visible = False
        End If
    End Sub

    Private Sub btndescargar_Click(sender As Object, e As EventArgs) Handles btndescargar.Click

        If txtarchivo.Text <> "" Then
            descargar_estudios_modificados()
        End If

    End Sub

    Private Sub descargar_estudios_modificados()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_modificados\" & txtarchivo.Text)) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                My.Computer.Network.DownloadFile(modificadosftp & txtarchivo.Text, "C:\osiris\files\estudios_modificados\" & txtarchivo.Text, "sadmin", "Sadmin7050*", False, 11000, True)
                verificar_estudio_modificado()
                'pbloading.Visible = False
                'lblestado.Visible = False
            Else
                verificar_estudio_modificado()
                'descarga.Close()
            End If
            'verificar_estudio_anterior()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Dim ubi_visor As String
    Dim abrir As Integer = 1

    Private Sub verificar_estudio_modificado()
        Try
            If (Not System.IO.File.Exists("C:\osiris\files\estudios_modificados\" & txtarchivo.Text)) Then
                MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim result As DialogResult
                result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                If (result = DialogResult.Yes) Then
                    ubi_visor = visorRadiant
                ElseIf result = DialogResult.No Then
                    ubi_visor = visorMicro
                ElseIf result = DialogResult.Cancel Then
                    abrir = 0
                End If

                If abrir = 1 Then
                    Shell(ubi_visor & " " & "C:\osiris\files\estudios_modificados\" & txtarchivo.Text, AppWinStyle.MaximizedFocus)
                Else
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

End Class