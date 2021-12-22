Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles
Public Class plantillas

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


    Dim idusuario As Integer
    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_plantillas()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM plantillas WHERE idusuario= " & idusuario & " AND habilitado = 1"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "plantillas")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "plantillas"
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
            Me.dgContenedor.Columns(2).HeaderText = "DESCRIPCION"
            Me.dgContenedor.Columns(2).Width = 250
            Me.dgContenedor.Columns(3).Visible = False
            Me.dgContenedor.Columns(4).HeaderText = "F. CREACION"
            Me.dgContenedor.Columns(4).Width = 150
            Me.dgContenedor.Columns(5).Visible = False
            Me.dgContenedor.Columns(6).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub plantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idusuario = main_menu.txtidusuario.Text
        llenar_datagridview_plantillas()
        txtidplantilla.Clear()
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidplantilla.Text = dgContenedor.SelectedCells.Item(0).Value
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        If txtidplantilla.Text <> "" Then
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar la plantilla?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                quitar_plantilla(txtidplantilla.Text)
                llenar_datagridview_plantillas()
                txtidplantilla.Clear()
            End If
        Else
            nueva_plantilla.limpiar()
            nueva_plantilla.ShowDialog()
        End If
    End Sub

    Private Sub txtidplantilla_TextChanged(sender As Object, e As EventArgs) Handles txtidplantilla.TextChanged
        If txtidplantilla.Text <> "" Then
            btnaccion.Text = "QUITAR"
            btnNuevo.Visible = True
        Else
            btnaccion.Text = "AGREGAR"
        End If
    End Sub

    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        If dgContenedor.Rows.Count > 0 Then
            nueva_plantilla.txtidplantilla.Text = Me.txtidplantilla.Text
            nueva_plantilla.txtdescripcion.Text = dgContenedor.SelectedCells.Item(2).Value
            nueva_plantilla.txtidtipoestudio.Text = dgContenedor.SelectedCells.Item(6).Value
            nueva_plantilla.ShowDialog()
        End If

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtidplantilla.Clear()
        btnNuevo.Visible = False
    End Sub
End Class