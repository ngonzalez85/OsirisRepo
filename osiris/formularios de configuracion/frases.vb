Imports MySql.Data.MySqlClient
Public Class frases

    Private Sub frases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idusuario = main_menu.txtidusuario.Text
        llenar_datagridview_frases()
        txtidfrase.Clear()
    End Sub

    Dim idusuario As Integer
    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_frases()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM frases WHERE idusuario= " & idusuario
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
            Me.dgContenedor.Columns(1).HeaderText = "NOMBRE"
            Me.dgContenedor.Columns(1).Width = 250
            Me.dgContenedor.Columns(2).Visible = False
            Me.dgContenedor.Columns(3).HeaderText = "F. CREACION"
            Me.dgContenedor.Columns(3).Width = 150
            Me.dgContenedor.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgContenedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellClick
        txtidfrase.Text = dgContenedor.SelectedCells.Item(0).Value
    End Sub

    Private Sub btnaccion_Click(sender As Object, e As EventArgs) Handles btnaccion.Click
        If txtidfrase.Text <> "" Then
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar la plantilla?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                quitar_frase(txtidfrase.Text)
                llenar_datagridview_frases()
                txtidfrase.Clear()
            End If
        Else
            nueva_frase.limpiar()
            nueva_frase.ShowDialog()
        End If
    End Sub

    Private Sub txtidfrase_TextChanged(sender As Object, e As EventArgs) Handles txtidfrase.TextChanged
        If txtidfrase.Text <> "" Then
            btnaccion.Text = "QUITAR"
            btnNuevo.Visible = True
        Else
            btnaccion.Text = "AGREGAR"
        End If
    End Sub

    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        If dgContenedor.Rows.Count > 0 Then
            nueva_frase.txtidfrase.Text = Me.txtidfrase.Text
            nueva_frase.txtdescripcion.Text = dgContenedor.SelectedCells.Item(1).Value
            nueva_frase.ShowDialog()
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtidfrase.Clear()
        btnNuevo.Visible = False
    End Sub
End Class