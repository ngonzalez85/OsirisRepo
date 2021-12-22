Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports MySql.Data.MySqlClient
Public Class estudio_mod
    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim formulario As String = "adjuntos"

    Private Sub estudio_mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidmodificado.Clear()

        limpiar()
        limpiar_est()
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Seleccionar estudio desde CD/DVD o archivo")
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        Me.ToolTip1.SetToolTip(Me.btndescargar, "Descargar estudio modificado")
        Me.ToolTip1.IsBalloon = True

        llenar_datagridview()
    End Sub

    Private Sub limpiar()
        txtarchivo.Text = ""
        btndescargar.Visible = False
    End Sub

    Private Sub limpiar_est()
        btnSubir.Enabled = False
        lblinforme.Visible = False
        lbldireccion.Text = ""

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtidmodificado.Clear()
        txtarchivo.Clear()
        Try
            If dlg.ShowDialog() = DialogResult.OK Then
                lbldireccion.Text = dlg.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbldireccion_TextChanged(sender As Object, e As EventArgs) Handles lbldireccion.TextChanged
        If lbldireccion.Text <> "" Then

            If System.IO.File.Exists(lbldireccion.Text & "\DICOMDIR") Then
                lblinforme.Visible = True
                lblinforme.ForeColor = Color.Green
                lblinforme.Text = "LA CARPETA CONTIENE IMAGENES"
                btnSubir.Enabled = True
            Else
                lblinforme.Visible = True
                lblinforme.ForeColor = Color.Red
                lblinforme.Text = "LA CARPETA NO CONTIENE IMAGENES"
                btnSubir.Enabled = False
            End If
        End If
    End Sub

    Dim ord As Integer
    Private Sub consultar_orden()
        consultar_orden2(txtidestudio.Text)
        If dr.Read Then
            ord = dr(0) + 1
        Else
            ord = 1
        End If
    End Sub


    Public Sub insertar()

        Try
            consultar_orden()
            'Inserta dotos del estudio en la BD
            insertar_modificado(ord, txtidestudio.Text, txtidestudio.Text & "_" & ord & "_ESTUDIO_MODIFICADO.zip", txtobs.Text)

            'se vuelve a recargar el formulario

            btnSubir.Enabled = False
            lblprogreso.Visible = True
            lblprogreso.Text = "COMPRIMIENDO EL ESTUDIO..."
            'pbloading.Visible = True
            comprimir.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'declaracion de variables
    Dim estudio_modificado As String
    Private Sub comprimir_DoWork(sender As Object, e As DoWorkEventArgs) Handles comprimir.DoWork
        'Realiza una tarea

        estudio_modificado = txtidestudio.Text & "_" & ord & "_ESTUDIO_MODIFICADO.zip"

        'Crea las carpetas de cada usuario si aún no existen
        If (Not System.IO.Directory.Exists("C:\osiris\files\temp\")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp\")
        End If

        ZipFile.CreateFromDirectory(lbldireccion.Text, "C:\osiris\files\temp\" & estudio_modificado)
    End Sub

    Private Sub comprimir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles comprimir.RunWorkerCompleted
        lblprogreso.Text = "SUBIENDO EL ESTUDIO MODIFICADO..."
        subir_archivo()
    End Sub

    Private Sub subir_archivo()

        My.Computer.Network.UploadFile("C:\osiris\files\temp\" & estudio_modificado, modificadosftp & estudio_modificado, "sadmin", "Sadmin7050*", True, 500)
        lblprogreso.Text = ""
        lblprogreso.Visible = False
        'pbloading.Visible = False
        btnSubir.Enabled = True
        lblinforme.Visible = False
        txtobs.Text = "SIN OBSERVACIONES"
        MessageBox.Show("Estudio subido correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        llenar_datagridview()
        limpiar_est()

        System.IO.File.Delete("C:\osiris\files\temp\" & estudio_modificado)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        If txtidmodificado.Text <> "" Then
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar el estudio?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                quitar_modificado(txtidmodificado.Text)

                llenar_datagridview()
                txtidmodificado.Clear()
                btnSubir.Text = "SUBIR ESTUDIO MODIFICADO"
            End If
        Else
            If lblinforme.Text = "LA CARPETA CONTIENE IMAGENES" And txtobs.Text <> "" Then

                insertar()
            Else
                MessageBox.Show("Seleccione un estudio", "Error al intentar subir el estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

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
                result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                If result = DialogResult.Yes Then
                    ubi_visor = visorRadiant
                ElseIf result = DialogResult.No Then
                    abrir = 0
                End If

                If abrir = 1 Then
                    Shell(ubi_visor & " " & "C:\osiris\files\estudios_modificados\" & txtarchivo.Text, AppWinStyle.MaximizedFocus)
                Else
                    MessageBox.Show("Estudio descargado correctamente en C:\osiris\files\estudios_modificados ", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

    Private Sub txtidmodificado_TextChanged(sender As Object, e As EventArgs) Handles txtidmodificado.TextChanged
        If txtidmodificado.Text <> "" Then
            btnSubir.Text = "QUITAR ESTUDIO MODIFICADO"
            btnSubir.Enabled = True
        Else
            btnSubir.Text = "SUBIR ESTUDIO MODIFICADO"
            btnSubir.Enabled = False
        End If
    End Sub
End Class