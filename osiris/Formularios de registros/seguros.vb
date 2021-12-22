Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class seguros

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
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_seguros()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM seguros WHERE habilitado = 1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "seguros")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "seguros"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "SEGURO"
            Me.dgContenedor.Columns(1).Width = 150
            Me.dgContenedor.Columns(2).HeaderText = "TELEFONO"
            Me.dgContenedor.Columns(2).Width = 100
            Me.dgContenedor.Columns(3).Visible = False
            Me.dgContenedor.Columns(4).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub seguros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datagridview_seguros()
        Me.ToolTip1.SetToolTip(Me.btnlimpiar, "Vaciar campos")
        Me.ToolTip1.IsBalloon = True
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidseguro.Text = dgContenedor.SelectedCells.Item(0).Value
        txtseguro.Text = dgContenedor.SelectedCells.Item(1).Value
        txttelefono.Text = dgContenedor.SelectedCells.Item(2).Value
    End Sub

    Private Sub guardar()
        Try

            Dim sql As String = "INSERT INTO seguros (seguro,tel_seguro,idcentro)values(?seguro,?tel_seguro,?idcentro)"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)


            Comando.Parameters.AddWithValue("?seguro", txtseguro.Text)
            Comando.Parameters.AddWithValue("?tel_seguro", txttelefono.Text)
            Comando.Parameters.AddWithValue("?idcentro", main_menu.txtidcentro.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()


            MessageBox.Show("Datos registrados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub actualizar()

        Try
            Dim sql As String = "UPDATE seguros SET seguro =?seguro,tel_seguro=?tel_seguro,idcentro=?idcentro where idseguro=?idseguro"
            Dim cnn = New MySqlConnection("server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & "")
            Dim Comando As New MySqlCommand(sql, cnn)

            Comando.Parameters.AddWithValue("?idseguro", txtidseguro.Text)
            Comando.Parameters.AddWithValue("?seguro", txtseguro.Text)
            Comando.Parameters.AddWithValue("?tel_seguro", txttelefono.Text)
            Comando.Parameters.AddWithValue("?idcentro", main_menu.txtidcentro.Text)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

            MessageBox.Show("Datos actualizados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtidseguro.Clear()
        txtseguro.Clear()
        txttelefono.Clear()
        txtseguro.Select()
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        If txtidseguro.Text <> "" Then
            If txtseguro.Text <> "" And txttelefono.Text <> "" Then
                actualizar()
                llenar_datagridview_seguros()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtseguro.Text <> "" And txttelefono.Text <> "" Then
                guardar()
                llenar_datagridview_seguros()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar registrar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtidseguro_TextChanged(sender As Object, e As EventArgs) Handles txtidseguro.TextChanged
        If txtidseguro.Text <> "" Then
            btnaccion.Text = "ACTUALIZAR"
        Else
            btnaccion.Text = "GUARDAR"
        End If
    End Sub

    Private Sub txtseguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtseguro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtseguro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class