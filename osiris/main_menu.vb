Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class main_menu
    'Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
    'Dim Formulario As Form
    'Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'
    'Si form no fue econtrado/ no existe'
    'If Formulario Is Nothing Then
    'Formulario = New Miform()
    'Formulario.TopLevel = False
    'Formulario.FormBorderStyle = FormBorderStyle.None
    'Formulario.Dock = DockStyle.Fill
    'PanelFormularios.Controls.Add(Formulario)
    'PanelFormularios.Tag = Formulario
    'Formulario.Show()
    'Formulario.BringToFront()
    'Else
    'Formulario.BringToFront()
    'End If
    'End Sub
    Dim formulario As String = "main_manu"

    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New Miform()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    Public Sub llenar_datagridview_estudios_pendientes()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT c.nombre AS centro, COUNT(e.idestudio) AS pendiente 
           FROM estudios e 
           INNER JOIN centros c ON e.idcentro=c.idcentro 
           WHERE e.idusuariomedico = " & txtidusuario.Text & " AND e.estado !='FIRMADO' GROUP BY c.nombre"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
            'colorear_filas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor.Columns(0).HeaderText = "CENTRO"
            Me.dgContenedor.Columns(1).HeaderText = "PENDIENTES"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_datagridview_colab_pendientes()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT estado , COUNT(idestudio) pendiente 
            FROM colaboraciones 
            WHERE idmedicosolicitante = " & txtidusuario.Text & " AND estado != 'LEIDO'
            GROUP BY estado"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "colaboraciones")
            dgcolaboraciones.DataSource = datos
            dgcolaboraciones.DataMember = "colaboraciones"
            retocar_columnas_colab()
            'colorear_filas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_colab()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgcolaboraciones.Columns(0).HeaderText = "ESTADO"
            Me.dgcolaboraciones.Columns(1).HeaderText = "CANTIDAD"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        AbrirFormEnPanel(Of registros)()
    End Sub

    Private Sub btninicio_Click(sender As Object, e As EventArgs) Handles btninicio.Click
        AbrirFormEnPanel(Of inicio)()
    End Sub

    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Osiris │ Bienvenido " & lblusuario.Text
        Me.horaActual.Enabled = True

        abrir_logo_centro()
        abrir_foto_perfil()

        consultar_informes(txtidusuario.Text)
        If dr.Read Then
            lbltotalGeneral.Text = dr(0)
        End If

        consultar_informes_mes(txtidusuario.Text)
        If dr.Read Then
            lblcantidadMes.Text = dr(0)
        End If

        Me.ToolTip1.SetToolTip(Me.pbperfil, "Pulse aquí para cambiar su foto de perfil")
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Acerca de Osiris")
        Me.ToolTip1.SetToolTip(Me.btnconfig, "Configuración del usuario")
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar datos")
        Me.ToolTip1.SetToolTip(Me.btnsalir, "Cerrar sesión")
        Me.ToolTip1.IsBalloon = True

        consultar_roles_usuarios(txtidusuario.Text)
        If dr.Read Then
            lblrol.Text = dr(0)
            lblidrol.Text = dr(1)
        End If

        verificar_rol()
        comprobar_med()
        formulario_inicio()
        llenar_datagridview_estudios_pendientes()
        llenar_datagridview_colab_pendientes()

        dgContenedor.ClearSelection()
        dgContenedor.CurrentCell = Nothing
        dgcolaboraciones.ClearSelection()
        dgcolaboraciones.CurrentCell = Nothing
        descargar_logo()

        llenar_datagridview_medicos()
        descargar_firma()

        llenar_datagridview_logos()
        descargar_logos_centros()
    End Sub

    Private Sub abrir_logo_centro()

        consultar_centro(txtidcentro.Text)
        If dr.Read Then
            Dim logo As Byte()
            logo = dr(8)
            pblogo.Image = Bytes_Imagen(logo)
            lbldir_logo.Text = dr(17)

        End If
    End Sub

    Private Sub abrir_foto_perfil()

        consultar_usuario_id(txtidusuario.Text)
        If dr.Read Then
            Dim logo As Byte()
            logo = dr(12)
            pbperfil.Image = Bytes_Imagen(logo)

        End If
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

    Private Sub horaActual_Tick(sender As Object, e As EventArgs) Handles horaActual.Tick
        Me.lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub btnConfiguraciones_Click(sender As Object, e As EventArgs) Handles btnConfiguraciones.Click
        AbrirFormEnPanel(Of configuraciones)()
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        AbrirFormEnPanel(Of informes)()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Of envio)()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Of asignacion)()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(Of administracion)()
    End Sub


    Private Sub abrir_f_perfil()
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
            actualizar_foto_perfil()
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

    Private Sub actualizar_foto_perfil()
        Try
            Dim sql As String = "UPDATE usuarios SET foto_perfil=?foto_perfil where idusuario=?idusuario"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Dim perfil As Byte()
            perfil = Imagen_Bytes(Me.pbperfil.Image)

            Comando.Parameters.AddWithValue("?idusuario", txtidusuario.Text)
            Comando.Parameters.AddWithValue("?foto_perfil", perfil)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblplantilla.Click
        'plantillas.ShowDialog()
        cambiar_clave.ShowDialog()
    End Sub


    ' variables de permisos

    Public seguros As Integer
    Public pacientes As Integer
    Public roles As Integer
    Public usuarios As Integer
    Public centros As Integer
    Public centros_usuario As Integer
    Public plantilla As Integer
    Public frase As Integer
    Public reporte As Integer
    Public reportemedico As Integer
    Public quitarfirma As Integer
    Public modalidades As Integer
    Public procedimientos As Integer
    Public tarifa_procedimientos As Integer
    Public PInformes As Integer
    Public Eimágenes As Integer
    Public asignacion_informes As Integer
    Public busqueda_informes As Integer
    Public firmar As Integer
    Public primerapellido As Integer
    Private Sub verificar_rol()
        consultar_permisos(lblidrol.Text)
        If dr.Read Then
            seguros = dr(2)
            pacientes = dr(3)
            roles = dr(4)
            usuarios = dr(5)
            centros = dr(6)
            centros_usuario = dr(7)
            plantilla = dr(8)
            modalidades = dr(9)
            procedimientos = dr(10)
            tarifa_procedimientos = dr(11)
            PInformes = (12)
            Eimágenes = dr(13)
            asignacion_informes = dr(14)
            busqueda_informes = dr(15)
            frase = dr(17)
            reporte = dr(18)
            quitarfirma = dr(19)
            reportemedico = dr(20)
            firmar = dr(21)
            primerapellido = dr(22)
        End If

        If PInformes <> 0 Then
            btnInformes.Enabled = True
        Else
            btnInformes.Enabled = False
        End If

        If Eimágenes <> 0 Then
            Button1.Enabled = True
            'Button4.Enabled = True
        Else
            Button1.Enabled = False
            'Button4.Enabled = False
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        acerca.ShowDialog()
    End Sub

    Private Sub pbperfil_Click(sender As Object, e As EventArgs) Handles pbperfil.Click
        abrir_f_perfil()
    End Sub

    Private Sub comprobar_med()
        If lblrol.Text = "MEDICO" Then
            'lblplantilla.Visible = True
            lbltus_estadisticas.Visible = True
            lblinformes_realizados.Visible = True
            lbltotal_mes.Visible = True
            lbltotal_general.Visible = True
            lblcantidadMes.Visible = True
            lbltotalGeneral.Visible = True
            dgContenedor.Visible = True
            btnactualizar.Visible = True
            dgcolaboraciones.Visible = False
            btnactcolab.Visible = False
            lblcolabo.Visible = False
            'Button2.Enabled = False
        ElseIf lblrol.Text = "MEDICO ADMINISTRADOR" Then
            'lblplantilla.Visible = True
            lbltus_estadisticas.Visible = True
            lblinformes_realizados.Visible = True
            lbltotal_mes.Visible = True
            lbltotal_general.Visible = True
            lblcantidadMes.Visible = True
            lbltotalGeneral.Visible = True
            dgContenedor.Visible = True
            btnactualizar.Visible = True
            dgcolaboraciones.Visible = False
            btnactcolab.Visible = False
            lblcolabo.Visible = False
        ElseIf lblrol.Text = "MEDICO CARDIOLOGO" Then
            'lblplantilla.Visible = True
            lbltus_estadisticas.Visible = True
            lblinformes_realizados.Visible = True
            lbltotal_mes.Visible = True
            lbltotal_general.Visible = True
            lblcantidadMes.Visible = True
            lbltotalGeneral.Visible = True
            dgContenedor.Visible = True
            dgcolaboraciones.Visible = False
            btnactcolab.Visible = False
            lblcolabo.Visible = False
            'Button2.Enabled = True
        ElseIf lblrol.Text = "ROOT" Then
            lbltus_estadisticas.Visible = False
            lblinformes_realizados.Visible = False
            lbltotal_mes.Visible = False
            lbltotal_general.Visible = False
            lblcantidadMes.Visible = False
            lbltotalGeneral.Visible = False
            dgContenedor.Visible = False
            btnactualizar.Visible = False
            dgcolaboraciones.Visible = False
            btnactcolab.Visible = False
            lblcolabo.Visible = False
            'Button2.Enabled = True
        Else
            'lblplantilla.Visible = Falsse
            lbltus_estadisticas.Visible = False
            lblinformes_realizados.Visible = False
            lbltotal_mes.Visible = False
            lbltotal_general.Visible = False
            lblcantidadMes.Visible = False
            lbltotalGeneral.Visible = False
            dgContenedor.Visible = False
            btnactualizar.Visible = False
            dgcolaboraciones.Visible = False
            btnactcolab.Visible = False
            lblcolabo.Visible = False
            'Button2.Enabled = False
        End If
    End Sub

    Private Sub formulario_inicio()
        consultar_usuario_id(txtidusuario.Text)
        If dr.Read Then
            lbldir_firma.Text = dr(13)
            lblvisor_auto.Text = dr(14)
            lblfirma_informe.Text = dr(15)
            lblformulario.Text = dr(16)
        End If
        If lblformulario.Text = "Panel de informes" Then
            AbrirFormEnPanel(Of informes)()
        ElseIf lblformulario.Text = "Panel de Asignación" Then
            AbrirFormEnPanel(Of asignacion)()
        ElseIf lblformulario.Text = "Envío de estudios" Then
            AbrirFormEnPanel(Of envio)()
        End If
    End Sub

    Private Sub btnconfig_Click(sender As Object, e As EventArgs) Handles btnconfig.Click
        config_sistema.ShowDialog()
    End Sub

    Private Sub dgContenedor_MouseUp(sender As Object, e As MouseEventArgs) Handles dgContenedor.MouseUp
        dgContenedor.CurrentCell = Nothing

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        llenar_datagridview_estudios_pendientes()
        dgContenedor.ClearSelection()
        dgContenedor.CurrentCell = Nothing

        llenar_datagridview_colab_pendientes()
        dgcolaboraciones.ClearSelection()
        dgcolaboraciones.CurrentCell = Nothing
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_estudios_pendientes()
        dgContenedor.ClearSelection()
        dgContenedor.CurrentCell = Nothing
    End Sub

    Private Sub descargar_logo()


        Try
            Dim logo As String = lbldir_logo.Text.Substring(lbldir_logo.Text.LastIndexOf("\") + 1)
            If lbldir_logo.Text = "" Or lbldir_logo.Text = "NINGUNO" Then

            Else
                If (Not File.Exists("C:\osiris\files\logos_centros\" & logo)) Then

                    My.Computer.Network.DownloadFile(logosftp & logo, "C:\osiris\files\logos_centros\" & logo, "sadmin", "Sadmin7050*", False, 11000, True)

                End If
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Dim cant_reg As Integer
    Dim dir_firma As String
    Public Sub llenar_datagridview_medicos()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT u.nombre AS medico,u.`dir_firma` FROM usuarios  u INNER JOIN roles r ON u.idrol = r.idrol INNER JOIN usuarios_centros uc ON u.idusuario = uc.idusuario WHERE r.rol ='MEDICO' OR r.rol ='MEDICO ADMINISTRADOR'  GROUP BY medico ORDER BY u.nombre ASC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "medicos")
            dgfirma.DataSource = datos
            dgfirma.DataMember = "medicos"
            cant_reg = dgfirma.Rows.Count - 1
            'retocar_columnas()
            'colorear_filas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub descargar_firma()
        'llenar_datagridview_estudios()
        For i As Integer = 0 To cant_reg



            dir_firma = dgfirma.Rows.Item(i).Cells(1).Value

            Try
                Dim firma As String = dir_firma.Substring(dir_firma.LastIndexOf("\") + 1)
                If dir_firma = "" Or dir_firma = "NINGUNO" Then

                Else
                    If (Not File.Exists("C:\osiris\files\firmas\" & firma)) Then

                        My.Computer.Network.DownloadFile(firmasftp & firma, "C:\osiris\files\firmas\" & firma, "sadmin", "Sadmin7050*", False, 11000, True)

                    End If
                End If

            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
            End Try

        Next

    End Sub



    Dim cant_reg2 As Integer
    Dim dir_logo As String
    Public Sub llenar_datagridview_logos()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT idcentro,ubi_logo FROM centros"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "logos")
            dgLogo.DataSource = datos
            dgLogo.DataMember = "logos"
            cant_reg2 = dgLogo.Rows.Count - 1
            'retocar_columnas()
            'colorear_filas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub descargar_logos_centros()
        'llenar_datagridview_estudios()
        For i As Integer = 0 To cant_reg2

            dir_logo = dgLogo.Rows.Item(i).Cells(1).Value

            Try
                Dim logo As String = dir_logo.Substring(dir_logo.LastIndexOf("\") + 1)
                If dir_logo = "" Or dir_logo = "NINGUNO" Then

                Else
                    If (Not File.Exists("C:\osiris\files\logos_centros\" & logo)) Then

                        My.Computer.Network.DownloadFile(logosftp & logo, "C:\osiris\files\logos_centros\" & logo, "sadmin", "Sadmin7050*", False, 11000, True)

                    End If
                End If

            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
            End Try

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(Of agenda)()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'AbrirFormEnPanel(Of navegador_agenda)()
        consultaUsuario()
        generar_aleatorio()
        MD5EncryptPass(token)
        Try
            login_agenda_token(tokenConMd5, ci_usuario)
            Dim direccionAgenda As String = "http://agenda.medvital.com.py/login.php?token=" & tokenConMd5
            Process.Start(direccionAgenda)
        Catch ex As Exception


        End Try

    End Sub

    '**************************** FUNCIONES PARA ABRIR PAGINA DE AGENDAMIENTO **************************** 
    Dim token As Integer
    Dim ci_usuario As String
    Dim tokenConMd5 As String

    Private Sub consultaUsuario()
        Try
            consultar_usuario_id(txtidusuario.Text)
            If dr.Read Then
                ci_usuario = dr(1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generar_aleatorio()
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100000, 1500000)
        token = System.Convert.ToString(numAleatorio.Next)
    End Sub

    Private Sub MD5EncryptPass(ByVal StrPass As String)
        tokenConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer
        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)
        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()
        For i = 0 To bytHash.Length - 1
            tokenConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro que desea cerrar la sesión actual", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        If result = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub main_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        If e.CloseReason = CloseReason.UserClosing Then
            result = MessageBox.Show("Esta seguro que desea cerrar el sistema?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If (result = DialogResult.Yes) Then
                Application.Exit()
            Else
                ' Cancel the close
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnactcolab_Click(sender As Object, e As EventArgs) Handles btnactcolab.Click
        llenar_datagridview_colab_pendientes()
        dgcolaboraciones.ClearSelection()
        dgcolaboraciones.CurrentCell = Nothing
    End Sub

    Private Sub dgcolaboraciones_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgcolaboraciones.CellMouseUp
        dgcolaboraciones.CurrentCell = Nothing
    End Sub

End Class
