Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports MySql.Data.MySqlClient
Public Class adjuntos

    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim formulario As String = "adjuntos"

    Public Sub llenar_datagridview()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM antecedentes WHERE idestudio = '" & txtidestudio.Text & "' "
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "antecedentes")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "antecedentes"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_adjuntos()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM adjuntos WHERE idestudio = '" & txtidestudio.Text & "' "
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "adjuntos")
            dgadjuntos.DataSource = datos
            dgadjuntos.DataMember = "adjuntos"
            retocar_columnas_adjuntos()

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

    Private Sub retocar_columnas_adjuntos()
        Try
            Me.dgadjuntos.Columns(0).HeaderText = "ID"
            Me.dgadjuntos.Columns(1).HeaderText = "ORD"
            Me.dgadjuntos.Columns(2).Visible = False
            Me.dgadjuntos.Columns(3).HeaderText = "ADJUNTO"
            Me.dgadjuntos.Columns(4).HeaderText = "T. ARCHIVO"
            Me.dgadjuntos.Columns(5).HeaderText = "FECHA DE SUBIDA"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub adjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidantecedente.Clear()

        limpiar()
        limpiar_est()
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Seleccionar estudio desde CD/DVD o archivo")
        Me.ToolTip1.SetToolTip(Me.pb1, "Agregar adjunto")
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Cerrar")
        Me.ToolTip1.SetToolTip(Me.btndescargar, "Descargar estudio anterior")
        Me.ToolTip1.IsBalloon = True

        llenar_combobox_tipoarchivo(cbtipoarchivo)
        cbtipoarchivo.SelectedItem = cbtipoarchivo.Items(0)
        llenar_datagridview()
        llenar_datagridview_adjuntos()
        Button4.Visible = True
    End Sub

    Private Sub limpiar()

        txtidadjunto1.Text = ""
        btn_nuevo.Visible = False
        btnborrar.Visible = False
        lbadjunto.Visible = False
        lbadjunto.Text = ""
        idadjunto.Visible = False
        idadjunto.Text = ""
        txtarchivo.Text = ""
        btndescargar.Visible = False

        If pb1.Image IsNot Nothing Then
            pb1.Image.Dispose()
            pb1.Image = Nothing
        End If
    End Sub

    Private Sub limpiar_est()
        btnSubir.Enabled = False
        lblinforme.Visible = False
        lbldireccion.Text = ""

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        If txtidantecedente.Text <> "" Then
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar el estudio?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                quitar_anterior(txtidantecedente.Text)

                llenar_datagridview()
                txtidantecedente.Clear()
                btnSubir.Text = "SUBIR ESTUDIO ANTERIOR"
            End If
        Else
            If lblinforme.Text = "LA CARPETA CONTIENE IMAGENES" And txtobs.Text <> "" Then

                insertar()
            Else
                MessageBox.Show("Seleccione un estudio anterior", "Error al intentar subir el estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtidantecedente.Clear()
        txtarchivo.Clear()
        Try
            If dlg.ShowDialog() = DialogResult.OK Then
                lbldireccion.Text = dlg.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim ord As Integer

    Private Sub consultar_orden()
        consultar_ord(txtidestudio.Text)
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
            insertar_antecedente(ord, txtidestudio.Text, txtidestudio.Text & "_" & ord & "_ESTUDIO_ANTERIOR.zip", txtobs.Text)

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
    Dim estudio_anterior As String
    Private Sub comprimir_DoWork(sender As Object, e As DoWorkEventArgs) Handles comprimir.DoWork
        'Realiza una tarea

        estudio_anterior = txtidestudio.Text & "_" & ord & "_ESTUDIO_ANTERIOR.zip"

        'Crea las carpetas de cada usuario si aún no existen
        If (Not System.IO.Directory.Exists("C:\osiris\files\temp\")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp\")
        End If

        ZipFile.CreateFromDirectory(lbldireccion.Text, "C:\osiris\files\temp\" & estudio_anterior)
    End Sub

    Private Sub comprimir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles comprimir.RunWorkerCompleted
        lblprogreso.Text = "SUBIENDO EL ESTUDIO ANTERIOR..."
        subir_archivo()
    End Sub

    Private Sub subir_archivo()

        My.Computer.Network.UploadFile("C:\osiris\files\temp\" & estudio_anterior, anterioresftp & estudio_anterior, "sadmin", "Sadmin7050*", True, 500)
        lblprogreso.Text = ""
        lblprogreso.Visible = False
        'pbloading.Visible = False
        btnSubir.Enabled = True
        lblinforme.Visible = False
        txtobs.Text = "SIN OBSERVACIONES"
        MessageBox.Show("Estudio subido correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        llenar_datagridview()
        limpiar_est()

        System.IO.File.Delete("C:\osiris\files\temp\" & estudio_anterior)
    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        abrir_adjunto_1()
    End Sub

    Dim filename As String
    Private Sub abrir_adjunto_1()
        '   Dim filename As String
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg)|*.jpg|All Files (*.*)|*.*"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Me.pb1.Image = Image.FromFile(filename)
            lblestado1.Text = "OK"
        End If
    End Sub

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Dim ord_img As Integer
    Private Sub consultar_orden_img()
        consultar_ord_img(txtidestudio.Text)
        If dr.Read Then
            ord_img = dr(0) + 1
        Else
            ord_img = 1
        End If
    End Sub

    Dim ord_ad As Integer
    Private Sub consultar_orden_adjunto()
        consultar_ord_img(txtidestudio.Text)
        If dr.Read Then
            ord_ad = dr(0)
        Else
            ord_ad = 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        guardar_adjunto1()
    End Sub

    Dim img_name As String
    Private Sub guardar_adjunto1()
        Try
            'If txtidadjunto1.Text <> "" Then
            '    If pb1.Image IsNot Nothing Then
            '        consultar_orden_adjunto()
            '        img_name = txtidestudio.Text & "_" & ord_ad & "_adjunto.jpg"

            '        Dim sql As String = "UPDATE adjuntos SET archivo=?archivo WHERE idadjunto=" & txtidadjunto1.Text
            '        Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            '        Dim Comando As New MySqlCommand(sql, cnn)
            '        Dim Imag1 As Byte()
            '        Imag1 = Imagen_Bytes(Me.pb1.Image)

            '        Comando.Parameters.AddWithValue("?archivo", img_name)
            '        My.Computer.Network.UploadFile(filename, adjuntosagendaftp & img_name, "ordenes", "Sadmin7050*", True, 500)

            '        cnn.Open()
            '        If cnn.State = ConnectionState.Open Then
            '            Comando.ExecuteNonQuery()
            '        End If
            '        cnn.Close()

            '        MessageBox.Show("Datos modificados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        'limpiar()

            '        pb1.Image.Dispose()
            '        pb1.Image = Nothing
            '        lblestado1.Text = "estado"
            '        txtidadjunto1.Text = ""
            '        llenar_datagridview_adjuntos()
            '    End If
            'Else
            If pb1.Image IsNot Nothing Then
                    consultar_orden_img()
                    img_name = txtidestudio.Text & "_" & ord_img & "_" & cbtipoarchivo.SelectedItem.trim() & ".jpg"

                    Dim sql As String = "INSERT INTO adjuntos (ord,idestudio,archivo,tipoarchivo)values(?ord,?idestudio,?archivo, ?tipoarchivo)"
                    Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
                    Dim Comando As New MySqlCommand(sql, cnn)
                    Dim Imag1 As Byte()
                    Imag1 = Imagen_Bytes(Me.pb1.Image)

                    Comando.Parameters.AddWithValue("?ord", ord_img)
                    Comando.Parameters.AddWithValue("?idestudio", txtidestudio.Text)
                    Comando.Parameters.AddWithValue("?archivo", img_name)
                    Comando.Parameters.AddWithValue("?tipoarchivo", cbtipoarchivo.SelectedItem)

                    My.Computer.Network.UploadFile(filename, adjuntosagendaftp & img_name, "ordenes", "Sadmin7050*", True, 500)

                    cnn.Open()
                    If cnn.State = ConnectionState.Open Then
                        Comando.ExecuteNonQuery()
                    End If
                    cnn.Close()

                    MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'limpiar()

                    pb1.Image.Dispose()
                    pb1.Image = Nothing
                    lblestado1.Text = "estado"
                    llenar_datagridview_adjuntos()
                    txtidadjunto1.Text = ""
                End If
            '  End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado

            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ' Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
    '    txtidantecedente.Text = dgContenedor.SelectedCells.Item(0).Value
    ' End Sub

    Private Sub txtidantecedente_TextChanged(sender As Object, e As EventArgs) Handles txtidantecedente.TextChanged
        If txtidantecedente.Text <> "" Then
            btnSubir.Text = "QUITAR ESTUDIO ANTERIOR"
            btnSubir.Enabled = True
        Else
            btnSubir.Text = "SUBIR ESTUDIO ANTERIOR"
            btnSubir.Enabled = False
        End If
    End Sub

    Private Sub dgContenedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellContentClick
        txtidantecedente.Text = dgContenedor.SelectedCells.Item(0).Value
        txtarchivo.Text = dgContenedor.SelectedCells.Item(3).Value
    End Sub

    'DESCARGA DE ESTUDIO ANTERIOR



    Private Sub dgadjuntos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgadjuntos.CellContentClick
        txtidadjunto1.Text = dgadjuntos.SelectedCells.Item(0).Value
        lbadjunto.Visible = True
        idadjunto.Visible = True
        lbadjunto.Text = dgadjuntos.SelectedCells.Item(3).Value
        idadjunto.Text = "Nro adjunto: " & dgadjuntos.SelectedCells.Item(0).Value
    End Sub

    Private Sub txtidadjunto1_TextChanged(sender As Object, e As EventArgs) Handles txtidadjunto1.TextChanged
        Button4.Visible = False
        If txtidadjunto1.Text <> "" Then
            btn_nuevo.Visible = True
            btnborrar.Visible = True
        End If

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txtidadjunto1.Text = ""
        btn_nuevo.Visible = False
        btnborrar.Visible = False
        lbadjunto.Visible = False
        lbadjunto.Text = ""
        idadjunto.Visible = False
        idadjunto.Text = ""
        Button4.Visible = True
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Try

            Dim sql As String = "DELETE FROM adjuntos WHERE idadjunto=" & txtidadjunto1.Text
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            MessageBox.Show("Datos borrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'limpiar()

            lbadjunto.Text = ""
            llenar_datagridview_adjuntos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            descargar_estudios_anteriores()
        End If

    End Sub

    Private Sub descargar_estudios_anteriores()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_anteriores\" & txtarchivo.Text)) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                My.Computer.Network.DownloadFile(anterioresftp & txtarchivo.Text, "C:\osiris\files\estudios_anteriores\" & txtarchivo.Text, "sadmin", "Sadmin7050*", False, 11000, True)
                verificar_estudio_anterior()
                'pbloading.Visible = False
                'lblestado.Visible = False
            Else
                verificar_estudio_anterior()
                'descarga.Close()
            End If
            'verificar_estudio_anterior()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Dim ubi_visor As String
    Dim abrir As Integer = 1

    Private Sub verificar_estudio_anterior()
        Try
            If (Not System.IO.File.Exists("C:\osiris\files\estudios_anteriores\" & txtarchivo.Text)) Then
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
                    Shell(ubi_visor & " " & "C:\osiris\files\estudios_anteriores\" & txtarchivo.Text, AppWinStyle.MaximizedFocus)
                Else
                    MessageBox.Show("Estudio descargado correctamente en C:\osiris\files\estudios_anteriores ", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

End Class