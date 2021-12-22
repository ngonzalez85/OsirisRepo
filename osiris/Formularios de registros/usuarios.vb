Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices

Public Class usuarios

    'conexion para bdpersona base de datos de cedulas paraguayas
    Dim cadConexion As String = "server=" & serverdb & ";database=bdpersona;user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
    Dim connec As New MySqlConnection(cadConexion)
    Dim cmd_ As New MySqlCommand
    Dim dr_ As MySqlDataReader
    Dim dt As DataTable

    Public Sub conect()
        Try
            connec.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function disconect()
        Try
            If connec.State = ConnectionState.Open Then
                connec.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txtci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtci.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True

        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then

            If txtci.Text <> "" Then
                consultar_usuario(txtci.Text)
                If dr.Read Then
                    'txtidusuario.Clear()
                    txtnombre.Clear()
                    txtcorreo.Clear()
                    txtregistro.Clear()
                    cbrol.Text = ""
                    txtidrol.Clear()
                    txtespecialidad.Clear()
                    txtpass2.Clear()
                    If PictureBox1.Image IsNot Nothing Then
                        PictureBox1.Image.Dispose()
                        PictureBox1.Image = Nothing
                    End If

                    txtidusuario.Text = dr(0)
                    txtnombre.Text = dr(3)
                    txtcorreo.Text = dr(4)
                    txtregistro.Text = dr(8)
                    txtvencimiento.Text = dr(9)
                    txtidrol.Text = dr(2)
                    txtespecialidad.Text = dr(11)
                    'llenar_combobox_roles(cbrol)
                    'consultar_rol(txtidrol.Text)
                    'If dr.Read Then
                    'cbrol.SelectedItem = dr(1)
                    'End If
                Else

                    consultar_ci(txtci.Text)
                    If dr_.Read Then
                        'txtidusuario.Clear()
                        txtnombre.Clear()

                        txtnombre.Text = dr_(3) & " " & dr_(2)

                    End If
                End If

            End If
        End If
    End Sub

    'Counsulta de ci db persona
    Private Sub consultar_ci(ByRef cin As String)
        disconect()
        conect()

        cmd_.Connection = connec
        cmd_.CommandType = CommandType.Text

        cmd_.CommandText = "select * from persona where ced_num='" & cin & "' "

        Try
            dr_ = cmd_.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '************************************************************************************************************
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
            filename = openfiler.FileName
            file = filename.Substring(filename.LastIndexOf("\") + 1)
            lbldfirma.Text = filename
            lblnfirma.Text = file
            lbldirfirma.Text = "C:\osiris\files\firmas\" & file
            Me.PictureBox1.Image = Image.FromFile(filename)
        End If
    End Sub

    Private Sub abrir_foto_perfil()
        Dim filename As String
        Dim openfiler As New OpenFileDialog
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
            filename = openfiler.FileName
            Me.pbperfil.Image = Image.FromFile(filename)
        End If
    End Sub

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Png)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

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
            MD5EncryptPass(txtpass2.Text)

            Dim sql As String = "INSERT INTO usuarios (cin,idrol,nombre,email,password,firma,registro,vencimiento_registro,especialidad,foto_perfil,dir_firma,visor_auto,firma_informe,formulario_inicio,alias)values(?cin,?idrol,?nombre,?email,?password,?firma,?registro,?vencimiento_registro,?especialidad,?foto_perfil,?dir_firma,?visor_auto,?firma_informe,?formulario_inicio,?alias)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)
            Dim Imag As Byte()
            Dim perfil As Byte()
            Imag = Imagen_Bytes(Me.PictureBox1.Image)
            perfil = Imagen_Bytes(Me.pbperfil.Image)

            Comando.Parameters.AddWithValue("?cin", txtci.Text)
            Comando.Parameters.AddWithValue("?idrol", txtidrol.Text)
            Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
            Comando.Parameters.AddWithValue("?email", txtcorreo.Text)
            Comando.Parameters.AddWithValue("?password", PasConMd5)
            Comando.Parameters.AddWithValue("?firma", Imag)
            If cbrol.Text = "MEDICO" Or cbrol.Text = "MEDICO ADMINISTRADOR" Then
                Comando.Parameters.AddWithValue("?registro", txtregistro.Text)
                Comando.Parameters.AddWithValue("?especialidad", txtespecialidad.Text)
                Comando.Parameters.AddWithValue("?vencimiento_registro", txtvencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            Else
                Comando.Parameters.AddWithValue("?registro", "SIN REGISTRO")
                Comando.Parameters.AddWithValue("?especialidad", "USUARIO DEL SISTEMA")
                Comando.Parameters.AddWithValue("?vencimiento_registro", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            End If

            Comando.Parameters.AddWithValue("?foto_perfil", perfil)
            Comando.Parameters.AddWithValue("?dir_firma", lbldirfirma.Text)
            Comando.Parameters.AddWithValue("?visor_auto", cbvisor_auto.Text)
            Comando.Parameters.AddWithValue("?firma_informe", cbfirma_informe.Text)
            Comando.Parameters.AddWithValue("?formulario_inicio", cbformulario.Text)
            Comando.Parameters.AddWithValue("?alias", txtalias.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            subir_firma()
            MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub actualizar()
        If txtpass2.Text <> "" Then
            Try
                'llamado a la funcion de encriptado de contrasena
                MD5EncryptPass(txtpass2.Text)

                Dim sql As String = "UPDATE usuarios SET cin =?cin,idrol=?idrol,nombre=?nombre,email=?email,password=?password,firma=?firma,registro=?registro,vencimiento_registro=?vencimiento_registro, especialidad=?especialidad,foto_perfil=?foto_perfil,dir_firma=?dir_firma,visor_auto=?visor_auto,firma_informe=?firma_informe,formulario_inicio=?formulario_inicio,alias=?alias where idusuario=?idusuario"
                Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
                Dim Comando As New MySqlCommand(sql, cnn)
                Dim Imag As Byte()
                Dim perfil As Byte()
                Imag = Imagen_Bytes(Me.PictureBox1.Image)
                perfil = Imagen_Bytes(Me.pbperfil.Image)

                Comando.Parameters.AddWithValue("?idusuario", txtidusuario.Text)
                Comando.Parameters.AddWithValue("?cin", txtci.Text)
                Comando.Parameters.AddWithValue("?idrol", txtidrol.Text)
                Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
                Comando.Parameters.AddWithValue("?email", txtcorreo.Text)
                Comando.Parameters.AddWithValue("?password", PasConMd5)
                Comando.Parameters.AddWithValue("?firma", Imag)
                Comando.Parameters.AddWithValue("?registro", txtregistro.Text)
                Comando.Parameters.AddWithValue("?vencimiento_registro", txtvencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                Comando.Parameters.AddWithValue("?especialidad", txtespecialidad.Text)
                Comando.Parameters.AddWithValue("?foto_perfil", perfil)
                Comando.Parameters.AddWithValue("?dir_firma", lbldirfirma.Text)
                Comando.Parameters.AddWithValue("?visor_auto", cbvisor_auto.Text)
                Comando.Parameters.AddWithValue("?firma_informe", cbfirma_informe.Text)
                Comando.Parameters.AddWithValue("?formulario_inicio", cbformulario.Text)
                Comando.Parameters.AddWithValue("?alias", txtalias.Text)

                cnn.Open()
                If cnn.State = ConnectionState.Open Then
                    Comando.ExecuteNonQuery()
                End If
                cnn.Close()

                subir_firma()
                MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try

                Dim sql As String = "UPDATE usuarios SET cin =?cin,idrol=?idrol,nombre=?nombre,email=?email,firma=?firma,registro=?registro,vencimiento_registro=?vencimiento_registro,especialidad=?especialidad,foto_perfil=?foto_perfil,dir_firma=?dir_firma,visor_auto=?visor_auto,firma_informe=?firma_informe,formulario_inicio=?formulario_inicio,alias=?alias where idusuario=?idusuario"
                Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
                Dim Comando As New MySqlCommand(sql, cnn)
                Dim Imag As Byte()
                Dim perfil As Byte()
                Imag = Imagen_Bytes(Me.PictureBox1.Image)
                perfil = Imagen_Bytes(Me.pbperfil.Image)

                Comando.Parameters.AddWithValue("?idusuario", txtidusuario.Text)
                Comando.Parameters.AddWithValue("?cin", txtci.Text)
                Comando.Parameters.AddWithValue("?idrol", txtidrol.Text)
                Comando.Parameters.AddWithValue("?nombre", txtnombre.Text)
                Comando.Parameters.AddWithValue("?email", txtcorreo.Text)
                Comando.Parameters.AddWithValue("?firma", Imag)
                Comando.Parameters.AddWithValue("?registro", txtregistro.Text)
                Comando.Parameters.AddWithValue("?vencimiento_registro", txtvencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                Comando.Parameters.AddWithValue("?especialidad", txtespecialidad.Text)
                Comando.Parameters.AddWithValue("?foto_perfil", perfil)
                Comando.Parameters.AddWithValue("?dir_firma", lbldirfirma.Text)
                Comando.Parameters.AddWithValue("?visor_auto", cbvisor_auto.Text)
                Comando.Parameters.AddWithValue("?firma_informe", cbfirma_informe.Text)
                Comando.Parameters.AddWithValue("?formulario_inicio", cbformulario.Text)
                Comando.Parameters.AddWithValue("?alias", txtalias.Text)

                cnn.Open()
                If cnn.State = ConnectionState.Open Then
                    Comando.ExecuteNonQuery()
                End If
                cnn.Close()

                subir_firma()
                MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub limpiar()
        txtidusuario.Clear()
        txtci.Clear()
        txtnombre.Clear()
        txtcorreo.Clear()
        txtregistro.Clear()
        cbrol.Text = ""
        txtidrol.Clear()
        txtespecialidad.Clear()
        txtpass2.Clear()
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Global.osiris.My.Resources.Resources.firmar
        Else
            PictureBox1.Image = Global.osiris.My.Resources.Resources.firmar
        End If
        If pbperfil.Image IsNot Nothing Then
            pbperfil.Image.Dispose()
            pbperfil.Image = Global.osiris.My.Resources.Resources.perfil_usuario
        Else
            pbperfil.Image = Global.osiris.My.Resources.Resources.perfil_usuario
        End If

        txtregistro.Enabled = False

        txtvencimiento.Enabled = False

        txtespecialidad.Enabled = False
        'lblfirma.Visible = False
        Button1.Enabled = False
        cbvisor_auto.Enabled = False
        cbvisor_auto.Text = "NO"
        cbfirma_informe.Enabled = False
        cbfirma_informe.Text = "NO"
        cbformulario.Text = "Menú principal"
        lbldfirma.Text = "NINGUNO"
        lblnfirma.Text = "NINGUNO"
        lbldirfirma.Text = "NINGUNO"
        txtalias.Clear()
        txtci.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrir_imagen()
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        If txtidusuario.Text <> "" Then
            If txtci.Text <> "" And txtnombre.Text <> "" And txtcorreo.Text <> "" And cbrol.Text <> "" And txtalias.Text <> "" Then
                actualizar()
                llenar_datagridview()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtci.Text <> "" And txtnombre.Text <> "" And txtcorreo.Text <> "" And cbrol.Text <> "" And txtpass2.Text <> "" And txtalias.Text <> "" Then
                guardar()
                llenar_datagridview()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtidusuario_TextChanged(sender As Object, e As EventArgs) Handles txtidusuario.TextChanged
        If txtidusuario.Text <> "" Then
            btnaccion.Text = "ACTUALIZAR"
        Else
            btnaccion.Text = "GUARDAR"
        End If
    End Sub

    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM usuarios WHERE habilitado = 1 ORDER BY nombre ASC "
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            contenedor.DataSource = datos
            contenedor.DataMember = "usuarios"
            retocar_columnas()
            'Console.WriteLine(consulta)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.contenedor.Columns(0).Visible = False
            Me.contenedor.Columns(1).HeaderText = "CINº"
            Me.contenedor.Columns(1).Width = 70
            Me.contenedor.Columns(2).Visible = False
            Me.contenedor.Columns(3).HeaderText = "NOMBRE"
            Me.contenedor.Columns(3).Width = 250
            Me.contenedor.Columns(4).HeaderText = "CORREO"
            Me.contenedor.Columns(4).Visible = True
            Me.contenedor.Columns(5).Visible = False
            Me.contenedor.Columns(6).HeaderText = "F. CREACION"
            Me.contenedor.Columns(6).Visible = False
            Me.contenedor.Columns(7).Visible = False
            Me.contenedor.Columns(8).HeaderText = "REGISTRO"
            Me.contenedor.Columns(8).Width = 70
            Me.contenedor.Columns(9).HeaderText = "VEN. REGISTRO"
            Me.contenedor.Columns(10).Visible = False
            Me.contenedor.Columns(11).HeaderText = "ESPECIALIDAD"
            Me.contenedor.Columns(11).Width = 200
            Me.contenedor.Columns(12).Visible = False
            Me.contenedor.Columns(13).Visible = False
            Me.contenedor.Columns(14).Visible = False
            Me.contenedor.Columns(15).Visible = False
            Me.contenedor.Columns(16).Visible = False
            Me.contenedor.Columns(17).HeaderText = "ALIAS"
            Me.contenedor.Columns(17).DisplayIndex = 2
            Me.contenedor.Columns(17).Width = 50
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiar()
        cbrol.Items.Clear()
        llenar_combobox_roles(cbrol)
        llenar_datagridview()

        Me.ToolTip1.SetToolTip(Me.btnlimpiar, "Vaciar campos")
        Me.ToolTip1.SetToolTip(Me.Button1, "Buscar firma")
        Me.ToolTip1.SetToolTip(Me.Button2, "Buscar foto")
        Me.ToolTip1.IsBalloon = True
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



    Private Sub txtidrol_TextChanged(sender As Object, e As EventArgs) Handles txtidrol.TextChanged
        If txtidrol.Text <> "" Then
            consultar_rol(txtidrol.Text)
            If dr.Read Then
                cbrol.SelectedItem = dr(1)
            End If
        End If
    End Sub

    Private Sub cbrol_TextChanged(sender As Object, e As EventArgs) Handles cbrol.TextChanged
        If cbrol.Text = "MEDICO" Or cbrol.Text = "MEDICO ADMINISTRADOR" Or cbrol.Text = "MEDICO CARDIOLOGO" Then
            txtregistro.Enabled = True
            txtvencimiento.Enabled = True
            txtespecialidad.Enabled = True
            'txtespecialidad.Clear()

            'lblfirma.Visible = True
            Button1.Enabled = True
            'PictureBox1.Visible = True
            cbvisor_auto.Enabled = True
            cbfirma_informe.Enabled = True
            lbldfirma.Text = "NINGUNO"
            lblnfirma.Text = "NINGUNO"
            lbldirfirma.Text = "NINGUNO"
        Else
            txtregistro.Enabled = False
            'txtregistro.Clear()
            txtvencimiento.Enabled = False
            txtespecialidad.Enabled = False
            txtespecialidad.Clear()
            'lblfirma.Visible = False
            Button1.Enabled = False
            If PictureBox1.Image IsNot Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Global.osiris.My.Resources.Resources.firmar
            Else
                PictureBox1.Image = Global.osiris.My.Resources.Resources.firmar
            End If
            cbvisor_auto.Enabled = False
            cbvisor_auto.Text = "NO"
            cbfirma_informe.Enabled = False
            cbfirma_informe.Text = "NO"
            lbldfirma.Text = "NINGUNO"
            lblnfirma.Text = "NINGUNO"
            lbldirfirma.Text = "NINGUNO"
            'PictureBox1.Visible = False
        End If

        consultar_roles(cbrol.Text)
        If dr.Read Then
            txtidrol.Text = dr(0)
        End If
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtnombre.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtespecialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtespecialidad.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtespecialidad.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrir_foto_perfil()
    End Sub

    Private Sub cbvisor_auto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbvisor_auto.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbfirma_informe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbfirma_informe.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbformulario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbformulario.KeyPress
        e.Handled = True
    End Sub

    Private Sub subir_firma()
        If lbldfirma.Text <> "NINGUNO" Then
            My.Computer.Network.UploadFile(lbldfirma.Text, firmasftp & lblnfirma.Text, "sadmin", "Sadmin7050*", True, 500)
        End If
    End Sub


    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub buscar_nombre()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre" & " Like '%" & txtnombre.Text & "%'"

            If dv.Count <> 0 Then
                contenedor.DataSource = dv
                retocar_columnas()
            Else
                contenedor.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        'buscar_nombre()
    End Sub

    Private Sub contenedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles contenedor.CellContentClick

        Dim idusuario As String = contenedor.CurrentRow.Cells(0).Value.ToString()
            Dim ci As String = contenedor.CurrentRow.Cells(1).Value.ToString()
            Dim rol As String = contenedor.CurrentRow.Cells(2).Value.ToString()
            Dim nombre As String = contenedor.CurrentRow.Cells(3).Value.ToString()
            Dim correo As String = contenedor.CurrentRow.Cells(4).Value.ToString()


            txtidusuario.Text = idusuario
            txtci.Text = ci
            txtidrol.Text = rol
            txtnombre.Text = nombre
            txtcorreo.Text = correo

                Dim img As Byte()
        img = contenedor.SelectedCells.Item(7).Value
        PictureBox1.Image = Bytes_Imagen(img)

        txtregistro.Text = contenedor.SelectedCells.Item(8).Value
        txtvencimiento.Text = contenedor.SelectedCells.Item(9).Value
            txtespecialidad.Text = contenedor.SelectedCells.Item(11).Value

            Dim perfil As Byte()
            perfil = contenedor.CurrentRow.Cells(12).Value
            pbperfil.Image = Bytes_Imagen(perfil)

            lbldirfirma.Text = contenedor.SelectedCells.Item(13).Value
            cbvisor_auto.Text = contenedor.SelectedCells.Item(14).Value
            cbfirma_informe.Text = contenedor.SelectedCells.Item(15).Value
            cbformulario.Text = contenedor.SelectedCells.Item(16).Value
        txtalias.Text = contenedor.SelectedCells.Item(17).Value


    End Sub

End Class