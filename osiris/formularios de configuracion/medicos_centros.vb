Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles
Public Class medicos_centros

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
    Public Sub llenar_datagridview_uc(ByRef idusuario As String)
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT uc.idusuario_centro,c.nombre FROM centros c INNER JOIN usuarios_centros uc ON c.idcentro = uc.idcentro WHERE uc.idusuario = '" & idusuario & "'"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "roles")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "roles"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "CENTRO"
            Me.dgContenedor.Columns(1).Width = 250

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If Char.IsLower(e.KeyChar) Then

            txtusuario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub medicos_centros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        abrir()
        autoCompletarUsuario(txtusuario)
        cbcentro.Items.Clear()
        llenar_combobox_centros(cbcentro, main_menu.txtidcentro.Text)
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        If txtusuario.Text <> "" Then
            consultar_id_usuario_nombre(txtusuario.Text)
            If dr.Read Then
                txtidusuario.Text = dr(0)
            End If
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

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click


        If txtidusuario_centro.Text <> "" Then
            quitar_centro_usuario(txtidusuario_centro.Text)
            llenar_datagridview_uc(txtidusuario.Text)
            txtidusuario_centro.Clear()
        Else
            If txtidusuario.Text <> "" And txtidcentro.Text <> "" Then
                insertar_centro_usuario(txtidusuario.Text, txtidcentro.Text)
                llenar_datagridview_uc(txtidusuario.Text)
            End If
        End If
    End Sub

    Private Sub txtidusuario_TextChanged(sender As Object, e As EventArgs) Handles txtidusuario.TextChanged
        If txtidusuario.Text <> "" Then
            llenar_datagridview_uc(txtidusuario.Text)
        End If
    End Sub

    Private Sub limpiar()
        txtidusuario_centro.Clear()
        txtusuario.Clear()
        txtidusuario.Clear()
        cbcentro.Text = ""
        txtidcentro.Clear()
        txtusuario.Select()
        dgContenedor.DataSource = Nothing
    End Sub



    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidusuario_centro.Text = dgContenedor.SelectedCells.Item(0).Value
    End Sub

    Private Sub txtidusuario_centro_TextChanged(sender As Object, e As EventArgs) Handles txtidusuario_centro.TextChanged
        If txtidusuario_centro.Text <> "" Then
            btnAccion.Text = "QUITAR"
        Else
            btnAccion.Text = "AGREGAR"
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class