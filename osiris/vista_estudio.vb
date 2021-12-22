Imports MySql.Data.MySqlClient
Public Class vista_estudio
    Private Sub vista_estudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_dgVista()
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable
    Public Sub llenar_dgVista()
        Try
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT concepto FROM citas cu
            JOIN estudiosunificados e USING(idcita)
            JOIN conceptos co USING(idconcepto) 
            WHERE idcita = '" & txtcita.Text & "' "
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            ' dt = New DataTable
            ' adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgVista.DataSource = datos
            dgVista.DataMember = "estudios"
            'dgVista.Text = dgVista.Rows.Count
            Console.WriteLine(consulta)
            retocar_columnas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgVista.Columns(0).HeaderText = "ESTUDIOS REALIZADOS"


        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

End Class