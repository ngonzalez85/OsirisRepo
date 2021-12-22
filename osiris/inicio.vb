Imports System.IO
Imports MySql.Data.MySqlClient
Public Class inicio
    Private Sub horaActual_Tick(sender As Object, e As EventArgs) Handles horaActual.Tick
        Me.lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Dim formulario As String = "inicio"
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.horaActual.Enabled = True
        lblusuario.Text = main_menu.lblusuario.Text
        lblpc.Text = main_menu.lblpc.Text
        abrir_logo_centro()
        abrir_foto_perfil()

        consultar_informes(main_menu.txtidusuario.Text)
        If dr.Read Then
            lbltotalGeneral.Text = dr(0)
        End If

        consultar_informes_mes(main_menu.txtidusuario.Text)
        If dr.Read Then
            lblcantidadMes.Text = dr(0)
        End If

        Me.ToolTip1.SetToolTip(Me.pbperfil, "Pulse aquí para cambiar su foto de perfil")
        Me.ToolTip1.IsBalloon = True
        lblrol.Text = main_menu.lblrol.Text
        comprobar_med()

        llenar_datagridview_estudios_pendientes()

        dgContenedor.ClearSelection()
        dgContenedor.CurrentCell = Nothing
    End Sub

    Private Sub abrir_logo_centro()

        consultar_centro(main_menu.txtidcentro.Text)
        If dr.Read Then
            Dim logo As Byte()
            logo = dr(8)
            pblogo.Image = Bytes_Imagen(logo)

        End If
    End Sub

    Private Sub abrir_foto_perfil()

        consultar_usuario_id(main_menu.txtidusuario.Text)
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

            Comando.Parameters.AddWithValue("?idusuario", main_menu.txtidusuario.Text)
            Comando.Parameters.AddWithValue("?foto_perfil", perfil)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblplantilla.Click
        'plantillas.ShowDialog()
        cambiar_clave.ShowDialog()
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
        Else
            'lblplantilla.Visible = False
            lbltus_estadisticas.Visible = False
            lblinformes_realizados.Visible = False
            lbltotal_mes.Visible = False
            lbltotal_general.Visible = False
            lblcantidadMes.Visible = False
            lbltotalGeneral.Visible = False
            dgContenedor.Visible = False
            btnactualizar.Visible = False
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        llenar_datagridview_estudios_pendientes()
        dgContenedor.ClearSelection()
        dgContenedor.CurrentCell = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        llenar_datagridview_estudios_pendientes()
        dgContenedor.ClearSelection()
        dgContenedor.CurrentCell = Nothing
    End Sub

    Private Sub dgContenedor_MouseUp(sender As Object, e As MouseEventArgs) Handles dgContenedor.MouseUp
        dgContenedor.CurrentCell = Nothing
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    Public Sub llenar_datagridview_estudios_pendientes()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT c.nombre AS centro, COUNT(e.idestudio) AS pendiente FROM estudios e INNER JOIN centros c ON e.idcentro=c.idcentro WHERE e.idusuariomedico = " & main_menu.txtidusuario.Text & " AND e.estado !='FIRMADO' GROUP BY c.nombre"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
            'colorear_filas()
        Catch ex As Exception
            MsgBox(ex.Message)
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
End Class