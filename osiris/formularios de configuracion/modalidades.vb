Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles
Public Class modalidades
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

    'llenar datagrid
    Dim formulario As String = "modalidades"
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_modalidades()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM modalidades WHERE habilitado = 1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "modalidades")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "modalidades"
            retocar_columnas()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).Visible = False
            Me.dgContenedor.Columns(2).HeaderText = "MODALIDAD"
            Me.dgContenedor.Columns(2).Width = 150
            Me.dgContenedor.Columns(3).HeaderText = "AE TITLE"
            Me.dgContenedor.Columns(3).Width = 100
            Me.dgContenedor.Columns(4).HeaderText = "IP LOCAL"
            Me.dgContenedor.Columns(4).Width = 100
            Me.dgContenedor.Columns(5).HeaderText = "MARCA"
            Me.dgContenedor.Columns(5).Width = 100
            Me.dgContenedor.Columns(6).HeaderText = "PUERTO WL"
            Me.dgContenedor.Columns(6).Width = 100
            Me.dgContenedor.Columns(7).HeaderText = "PUERTO DIC."
            Me.dgContenedor.Columns(7).Width = 120
            Me.dgContenedor.Columns(8).Visible = False
            Me.dgContenedor.Columns(9).Visible = False
            Me.dgContenedor.Columns(10).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub modalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        cbcentro.Items.Clear()
        llenar_combobox_centros(cbcentro, main_menu.txtidcentro.Text)
        cbtipo_estudio.Items.Clear()
        llenar_combobox_tipo_estudio(cbtipo_estudio)
        llenar_datagridview_modalidades()
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidmodalidad.Text = dgContenedor.SelectedCells.Item(0).Value
        txtidcentro.Text = dgContenedor.SelectedCells.Item(1).Value
        txtmodalidad.Text = dgContenedor.SelectedCells.Item(2).Value
        txtaetitle.Text = dgContenedor.SelectedCells.Item(3).Value
        txtiplocal.Text = dgContenedor.SelectedCells.Item(4).Value
        txtmarca.Text = dgContenedor.SelectedCells.Item(5).Value
        txtpuerto_wl.Text = dgContenedor.SelectedCells.Item(6).Value
        txtpuerto_dicom.Text = dgContenedor.SelectedCells.Item(7).Value
        txtidtipo_estudio.Text = dgContenedor.SelectedCells.Item(9).Value
        txtidrispy.Text = dgContenedor.SelectedCells.Item(10).Value
    End Sub

    Private Sub guardar()
        Try

            Dim sql As String = "INSERT INTO modalidades (idcentro,modalidad,aetitle,iplocal,marca,puerto_wl,puerto_dicom,idtipoestudio,idrispy)values(?idcentro,?modalidad,?aetitle,?iplocal,?marca,?puerto_wl,?puerto_dicom,?idtipoestudio,?idrispy)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idcentro", txtidcentro.Text)
            Comando.Parameters.AddWithValue("?modalidad", txtmodalidad.Text)
            Comando.Parameters.AddWithValue("?aetitle", txtaetitle.Text)
            Comando.Parameters.AddWithValue("?iplocal", txtiplocal.Text)
            Comando.Parameters.AddWithValue("?marca", txtmarca.Text)
            Comando.Parameters.AddWithValue("?puerto_wl", txtpuerto_wl.Text)
            Comando.Parameters.AddWithValue("?puerto_dicom", txtpuerto_dicom.Text)
            Comando.Parameters.AddWithValue("?idtipoestudio", txtidtipo_estudio.Text)
            Comando.Parameters.AddWithValue("?idrispy", txtidrispy.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()


            MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub actualizar()

        Try
            Dim sql As String = "UPDATE modalidades SET idcentro =?idcentro,modalidad=?modalidad,aetitle=?aetitle,iplocal=?iplocal,marca=?marca,puerto_wl=?puerto_wl,puerto_dicom=?puerto_dicom,idtipoestudio=?idtipoestudio,idrispy=?idrispy where idmodalidad=?idmodalidad"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idmodalidad", txtidmodalidad.Text)
            Comando.Parameters.AddWithValue("?idcentro", txtidcentro.Text)
            Comando.Parameters.AddWithValue("?modalidad", txtmodalidad.Text)
            Comando.Parameters.AddWithValue("?aetitle", txtaetitle.Text)
            Comando.Parameters.AddWithValue("?iplocal", txtiplocal.Text)
            Comando.Parameters.AddWithValue("?marca", txtmarca.Text)
            Comando.Parameters.AddWithValue("?puerto_wl", txtpuerto_wl.Text)
            Comando.Parameters.AddWithValue("?puerto_dicom", txtpuerto_dicom.Text)
            Comando.Parameters.AddWithValue("?idtipoestudio", txtidtipo_estudio.Text)
            Comando.Parameters.AddWithValue("?idrispy", txtidrispy.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtidmodalidad.Clear()
        txtidcentro.Clear()
        cbcentro.Text = ""
        txtmodalidad.Clear()
        txtaetitle.Clear()
        txtiplocal.Clear()
        txtmarca.Clear()
        txtpuerto_wl.Clear()
        txtpuerto_dicom.Clear()
        txtidtipo_estudio.Clear()
        txtidrispy.Clear()
        cbtipo_estudio.Text = ""
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        Try
            If txtidmodalidad.Text <> "" Then
                If txtidcentro.Text <> "" And txtmodalidad.Text <> "" And txtaetitle.Text <> "" And txtiplocal.Text <> "" And txtmarca.Text <> "" And txtpuerto_wl.Text <> "" And txtpuerto_dicom.Text <> "" And txtidtipo_estudio.Text <> "" And txtidrispy.Text <> "" Then
                    actualizar()
                    llenar_datagridview_modalidades()
                Else
                    MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If txtidcentro.Text <> "" And txtmodalidad.Text <> "" And txtaetitle.Text <> "" And txtiplocal.Text <> "" And txtmarca.Text <> "" And txtpuerto_wl.Text <> "" And txtpuerto_dicom.Text <> "" And txtidtipo_estudio.Text <> "" And txtidrispy.Text <> "" Then
                    guardar()
                    llenar_datagridview_modalidades()
                Else
                    MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtidmodalidad_TextChanged(sender As Object, e As EventArgs) Handles txtidmodalidad.TextChanged
        If txtidmodalidad.Text <> "" Then
            btnaccion.Text = "ACTUALIZAR"
        Else
            btnaccion.Text = "GUARDAR"
        End If
    End Sub

    Private Sub cbcentro_TextChanged(sender As Object, e As EventArgs) Handles cbcentro.TextChanged
        If cbcentro.Text <> "" Then
            consultar_id_centro(cbcentro.Text)
            If dr.Read Then
                txtidcentro.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbtipo_estudio_TextChanged(sender As Object, e As EventArgs) Handles cbtipo_estudio.TextChanged
        If cbtipo_estudio.Text <> "" Then
            consultar_id_tipoestudio(cbtipo_estudio.Text)
            If dr.Read Then
                txtidtipo_estudio.Text = dr(0)
            End If
        End If
    End Sub



    Private Sub txtidcentro_TextChanged(sender As Object, e As EventArgs) Handles txtidcentro.TextChanged
        Try
            If txtidcentro.Text <> "" Then
                consultar_centro(txtidcentro.Text)

                If dr.Read Then
                    cbcentro.Text = dr(1)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtmodalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmodalidad.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtmodalidad.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtmarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmarca.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtmarca.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub txtidtipo_estudio_TextChanged(sender As Object, e As EventArgs) Handles txtidtipo_estudio.TextChanged
        If txtidtipo_estudio.Text <> "" Then
            consultar_tipoestudio(txtidtipo_estudio.Text)
            If dr.Read Then
                cbtipo_estudio.Text = dr(1)
            End If
        End If
    End Sub
End Class