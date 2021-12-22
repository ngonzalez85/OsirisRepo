Imports MySql.Data.MySqlClient
Public Class aplicar_plantilla
    Dim idusuario As Integer
    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_plantillas()
        If cbtipo_estudio.Text = "TODOS" Then
            Try
                Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "SELECT p.idplantilla,p.descripcion,p.fecha_creacion, t.tipoestudio FROM plantillas p INNER JOIN tipo_estudios t ON p.idtipoestudio = t.idtipoestudio WHERE p.idusuario= " & idusuario & " AND p.habilitado = 1"
                adaptador = New MySqlDataAdapter(consulta, Conexion3)
                datos = New DataSet
                adaptador.Fill(datos, "plantillas")
                dgContenedor.DataSource = datos
                dgContenedor.DataMember = "plantillas"
                retocar_columnas()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "SELECT p.idplantilla,p.descripcion,p.fecha_creacion, t.tipoestudio FROM plantillas p INNER JOIN tipo_estudios t ON p.idtipoestudio = t.idtipoestudio WHERE p.idusuario= " & idusuario & " AND t.tipoestudio='" & cbtipo_estudio.Text & "' AND p.habilitado = 1"
                adaptador = New MySqlDataAdapter(consulta, Conexion3)
                datos = New DataSet
                adaptador.Fill(datos, "plantillas")
                dgContenedor.DataSource = datos
                dgContenedor.DataMember = "plantillas"
                retocar_columnas()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).HeaderText = "ID"
            Me.dgContenedor.Columns(0).Width = 30
            Me.dgContenedor.Columns(1).HeaderText = "DESCRIPCION"
            Me.dgContenedor.Columns(1).Width = 250
            Me.dgContenedor.Columns(2).HeaderText = "F. CREACION"
            Me.dgContenedor.Columns(2).Width = 150
            Me.dgContenedor.Columns(3).HeaderText = "T. ESTUDIO"
            Me.dgContenedor.Columns(3).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub aplicar_plantilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idusuario = main_menu.txtidusuario.Text
        llenar_datagridview_plantillas()
        llenar_combobox_tipo_estudio(cbtipo_estudio)
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub cbtipo_estudio_TextChanged(sender As Object, e As EventArgs) Handles cbtipo_estudio.TextChanged
        If cbtipo_estudio.Text <> "" Then
            llenar_datagridview_plantillas()
        End If
    End Sub

    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea aplicar esta plantilla?. Tenga en cuenta que sobrescribirá  lo que ya había hecho en su informe actual", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            If dgContenedor.Rows.Count > 0 Then
                redactar_informe.idplantilla = dgContenedor.SelectedCells.Item(0).Value
                redactar_informe.obtener_plantilla()
                Me.Close()
            End If
        End If
    End Sub
End Class