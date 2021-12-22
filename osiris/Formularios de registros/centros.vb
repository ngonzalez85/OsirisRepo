Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Security.Cryptography

Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles

Public Class centros

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


    'variable para almacenar el md5
    Dim PasConMd5 As String

    Private Sub abrir_imagen()
        Dim filename As String
        Dim openfiler As New OpenFileDialog
        Dim file As String
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.png)|*.png|All Files (*.*)|*.*"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            'filename = openfiler.FileName
            'Me.PictureBox1.Image = Image.FromFile(filename)


            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            file = filename.Substring(filename.LastIndexOf("\") + 1)
            lbldlogo.Text = filename
            lblnlogo.Text = file
            lbldirlogo.Text = "C:\osiris\files\logos_centros\" & file
            Me.PictureBox1.Image = Image.FromFile(filename)
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

    Private Sub subir_logo()
        If lbldlogo.Text <> "NINGUNO" Then
            My.Computer.Network.UploadFile(lbldlogo.Text, logosftp & lblnlogo.Text, "sadmin", "Sadmin7050*", True, 500)
        End If
    End Sub

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

    Private Sub guardar()
        Try
            'llamado a la funcion de encriptado de contrasena
            MD5EncryptPass(txtcontrasena.Text)

            Dim sql As String = "INSERT INTO centros (nombre,responsable,telefono,correo,correo_informe,ruc,direccion,logo,ubi_estudios_subidos,servidor_smtp,cuenta_smtp,puerto_smtp,password_smtp,ubi_visor,ubi_logo,encabezado)values(?nombre,?responsable,?telefono,?correo,?correo_informe,?ruc,?direccion,?logo,?ubi_estudios_subidos,?servidor_smtp,?cuenta_smtp,?puerto_smtp,?password_smtp,?ubi_visor,?ubi_logo,?encabezado)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)
            Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.PictureBox1.Image)

            Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
            Comando.Parameters.AddWithValue("?responsable", txtresponsable.Text)
            Comando.Parameters.AddWithValue("?telefono", txttelefono.Text)
            Comando.Parameters.AddWithValue("?correo", txtcorreo.Text)
            Comando.Parameters.AddWithValue("?correo_informe", txtcorreo_informe.Text)
            Comando.Parameters.AddWithValue("?ruc", txtruc.Text)
            Comando.Parameters.AddWithValue("?direccion", txtdireccion.Text)
            Comando.Parameters.AddWithValue("?logo", Imag)
            Comando.Parameters.AddWithValue("?ubi_estudios_subidos", txtestudios_subidos.Text)
            Comando.Parameters.AddWithValue("?servidor_smtp", txtservidor.Text)
            Comando.Parameters.AddWithValue("?cuenta_smtp", txtcuenta.Text)
            Comando.Parameters.AddWithValue("?puerto_smtp", txtpuerto.Text)
            Comando.Parameters.AddWithValue("?password_smtp", PasConMd5)
            Comando.Parameters.AddWithValue("?ubi_visor", txtvisor.Text)
            Comando.Parameters.AddWithValue("?ubi_logo", lbldirlogo.Text)
            Comando.Parameters.AddWithValue("?encabezado", cbencabezado.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            subir_logo()
            MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub actualizar()
        If txtcontrasena.Text <> "" Then
            Try
                'llamado a la funcion de encriptado de contrasena
                MD5EncryptPass(txtcontrasena.Text)

                Dim sql As String = "UPDATE centros SET nombre =?nombre,responsable=?responsable,telefono=?telefono,correo=?correo,correo_informe=?correo_informe,ruc=?ruc,direccion=?direccion,logo=?logo,ubi_estudios_subidos=?ubi_estudios_subidos,servidor_smtp=?servidor_smtp,cuenta_smtp=?cuenta_smtp,puerto_smtp=?puerto_smtp,password_smtp=?password_smtp,ubi_visor=?ubi_visor,ubi_logo=?ubi_logo,encabezado=?encabezado where idcentro=?idcentro"
                Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
                Dim Comando As New MySqlCommand(sql, cnn)
                Dim Imag As Byte()
                Imag = Imagen_Bytes(Me.PictureBox1.Image)

                Comando.Parameters.AddWithValue("?idcentro", txtidcentro.Text)
                Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
                Comando.Parameters.AddWithValue("?responsable", txtresponsable.Text)
                Comando.Parameters.AddWithValue("?telefono", txttelefono.Text)
                Comando.Parameters.AddWithValue("?correo", txtcorreo.Text)
                Comando.Parameters.AddWithValue("?correo_informe", txtcorreo_informe.Text)
                Comando.Parameters.AddWithValue("?ruc", txtruc.Text)
                Comando.Parameters.AddWithValue("?direccion", txtdireccion.Text)
                Comando.Parameters.AddWithValue("?logo", Imag)
                Comando.Parameters.AddWithValue("?ubi_estudios_subidos", txtestudios_subidos.Text)
                Comando.Parameters.AddWithValue("?servidor_smtp", txtservidor.Text)
                Comando.Parameters.AddWithValue("?cuenta_smtp", txtcuenta.Text)
                Comando.Parameters.AddWithValue("?puerto_smtp", txtpuerto.Text)
                Comando.Parameters.AddWithValue("?password_smtp", PasConMd5)
                Comando.Parameters.AddWithValue("?ubi_visor", txtvisor.Text)
                Comando.Parameters.AddWithValue("?ubi_logo", lbldirlogo.Text)
                Comando.Parameters.AddWithValue("?encabezado", cbencabezado.Text)

                cnn.Open()
                If cnn.State = ConnectionState.Open Then
                    Comando.ExecuteNonQuery()
                End If
                cnn.Close()

                subir_logo()
                MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try

                Dim sql As String = "UPDATE centros SET nombre =?nombre,responsable=?responsable,telefono=?telefono,correo=?correo,correo_informe=?correo_informe,ruc=?ruc,direccion=?direccion,logo=?logo,ubi_estudios_subidos=?ubi_estudios_subidos,servidor_smtp=?servidor_smtp,cuenta_smtp=?cuenta_smtp,puerto_smtp=?puerto_smtp,ubi_visor=?ubi_visor,ubi_logo=?ubi_logo,encabezado=?encabezado where idcentro=?idcentro"
                Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
                Dim Comando As New MySqlCommand(sql, cnn)
                Dim Imag As Byte()
                Imag = Imagen_Bytes(Me.PictureBox1.Image)

                Comando.Parameters.AddWithValue("?idcentro", txtidcentro.Text)
                Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
                Comando.Parameters.AddWithValue("?responsable", txtresponsable.Text)
                Comando.Parameters.AddWithValue("?telefono", txttelefono.Text)
                Comando.Parameters.AddWithValue("?correo", txtcorreo.Text)
                Comando.Parameters.AddWithValue("?correo_informe", txtcorreo_informe.Text)
                Comando.Parameters.AddWithValue("?ruc", txtruc.Text)
                Comando.Parameters.AddWithValue("?direccion", txtdireccion.Text)
                Comando.Parameters.AddWithValue("?logo", Imag)
                Comando.Parameters.AddWithValue("?ubi_estudios_subidos", txtestudios_subidos.Text)
                Comando.Parameters.AddWithValue("?servidor_smtp", txtservidor.Text)
                Comando.Parameters.AddWithValue("?cuenta_smtp", txtcuenta.Text)
                Comando.Parameters.AddWithValue("?puerto_smtp", txtpuerto.Text)
                Comando.Parameters.AddWithValue("?ubi_visor", txtvisor.Text)
                Comando.Parameters.AddWithValue("?ubi_logo", lbldirlogo.Text)
                Comando.Parameters.AddWithValue("?encabezado", cbencabezado.Text)

                cnn.Open()
                If cnn.State = ConnectionState.Open Then
                    Comando.ExecuteNonQuery()
                End If
                cnn.Close()

                subir_logo()
                MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub limpiar()
        txtidcentro.Clear()
        txtnombre.Clear()
        txtruc.Clear()
        txtresponsable.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()
        txtcorreo.Clear()
        txtcorreo_informe.Clear()
        txtestudios_subidos.Clear()
        txtservidor.Clear()
        txtcuenta.Clear()
        txtpuerto.Clear()
        txtcontrasena.Clear()
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Global.osiris.My.Resources.Resources.logoempresa
        Else
            PictureBox1.Image = Global.osiris.My.Resources.Resources.logoempresa
        End If

        lbldlogo.Text = "NINGUNO"
        lblnlogo.Text = "NINGUNO"
        lbldirlogo.Text = "NINGUNO"
        cbencabezado.Text = ""
        txtnombre.Select()
    End Sub

    Private Sub btnlogo_Click(sender As Object, e As EventArgs) Handles btnlogo.Click
        abrir_imagen()
    End Sub

    Private Sub btnubi_Click(sender As Object, e As EventArgs) Handles btnubi.Click
        Try
            If dlg.ShowDialog() = DialogResult.OK Then
                txtestudios_subidos.Text = dlg.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtidcentro.Text <> "" Then
            If txtnombre.Text <> "" And txtruc.Text <> "" And txtresponsable.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtcorreo.Text <> "" And txtcorreo_informe.Text <> "" And txtestudios_subidos.Text <> "" And txtservidor.Text <> "" And txtcuenta.Text <> "" And txtpuerto.Text <> "" And txtvisor.Text <> "" Then
                actualizar()
                llenar_datagridview_centros()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtnombre.Text <> "" And txtruc.Text <> "" And txtresponsable.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtcorreo.Text <> "" And txtcorreo_informe.Text <> "" And txtestudios_subidos.Text <> "" And txtservidor.Text <> "" And txtcuenta.Text <> "" And txtpuerto.Text <> "" And txtcontrasena.Text <> "" And txtvisor.Text <> "" Then
                guardar()
                llenar_datagridview_centros()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub

    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_centros()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM centros  WHERE habilitado = 1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "CENTRO"
            Me.dgContenedor.Columns(1).Width = 120
            Me.dgContenedor.Columns(2).HeaderText = "RESPONSABLE"
            Me.dgContenedor.Columns(2).Width = 200
            Me.dgContenedor.Columns(3).HeaderText = "TELEFONO"
            Me.dgContenedor.Columns(3).Width = 80
            Me.dgContenedor.Columns(4).HeaderText = "CORREO"
            Me.dgContenedor.Columns(4).Width = 100
            Me.dgContenedor.Columns(5).HeaderText = "C. ENTREGA"
            Me.dgContenedor.Columns(5).Width = 100
            Me.dgContenedor.Columns(6).HeaderText = "RUC"
            Me.dgContenedor.Columns(6).Width = 80
            Me.dgContenedor.Columns(7).HeaderText = "DIRECCION"
            Me.dgContenedor.Columns(7).Width = 290
            Me.dgContenedor.Columns(8).Visible = False
            Me.dgContenedor.Columns(9).Visible = False
            Me.dgContenedor.Columns(10).Visible = False
            Me.dgContenedor.Columns(11).HeaderText = "UBICACION DE IMAGENES SUBIDAS"
            Me.dgContenedor.Columns(11).Width = 290
            Me.dgContenedor.Columns(12).HeaderText = "SERVIDOR SMTP"
            Me.dgContenedor.Columns(12).Width = 120
            Me.dgContenedor.Columns(13).HeaderText = "CUENTA SMTP"
            Me.dgContenedor.Columns(13).Width = 120
            Me.dgContenedor.Columns(14).HeaderText = "PUERTO SMTP"
            Me.dgContenedor.Columns(14).Width = 120
            Me.dgContenedor.Columns(15).Visible = False
            Me.dgContenedor.Columns(16).Visible = False
            Me.dgContenedor.Columns(17).Visible = False
            Me.dgContenedor.Columns(18).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub centros_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenar_datagridview_centros()
    End Sub

    Private Sub txtidcentro_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro.TextChanged
        If txtidcentro.Text <> "" Then
            btnRegistrar.Text = "ACTUALIZAR"
        Else
            btnRegistrar.Text = "GUARDAR"
        End If
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidcentro.Text = dgContenedor.SelectedCells.Item(0).Value
        txtnombre.Text = dgContenedor.SelectedCells.Item(1).Value
        txtresponsable.Text = dgContenedor.SelectedCells.Item(2).Value
        txttelefono.Text = dgContenedor.SelectedCells.Item(3).Value
        txtcorreo.Text = dgContenedor.SelectedCells.Item(4).Value
        txtcorreo_informe.Text = dgContenedor.SelectedCells.Item(5).Value
        txtruc.Text = dgContenedor.SelectedCells.Item(6).Value
        txtdireccion.Text = dgContenedor.SelectedCells.Item(7).Value

        Dim img As Byte()
        img = dgContenedor.SelectedCells.Item(8).Value
        PictureBox1.Image = Bytes_Imagen(img)

        txtestudios_subidos.Text = dgContenedor.SelectedCells.Item(11).Value
        txtservidor.Text = dgContenedor.SelectedCells.Item(12).Value
        txtcuenta.Text = dgContenedor.SelectedCells.Item(13).Value
        txtpuerto.Text = dgContenedor.SelectedCells.Item(14).Value
        txtvisor.Text = dgContenedor.SelectedCells.Item(16).Value
        lbldirlogo.Text = dgContenedor.SelectedCells.Item(17).Value
        cbencabezado.Text = dgContenedor.SelectedCells.Item(18).Value
    End Sub

    'convertir binario a imágen

    Dim img As Byte()
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

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ofd.ShowDialog() = DialogResult.OK Then
                txtvisor.Text = ofd.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtnombre.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtresponsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtresponsable.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtresponsable.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtdireccion.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub cbencabezado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbencabezado.KeyPress
        e.Handled = True
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub
End Class