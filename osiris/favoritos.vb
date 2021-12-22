Imports MySql.Data.MySqlClient


Public Class favoritos
    Private Sub favoritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datagridview_roles()

        dgContenedor.RowHeadersVisible = False
        dgContenedor.BackgroundColor = Color.White
        dgContenedor.GridColor = Color.White
    End Sub

    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    Public Sub llenar_datagridview_roles()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM roles"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "roles")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "roles"

            'Dim currentDataSet As DataSet = FlipDataSet(datos) ' Flip the DataSet

            'Dim currentDataView As DataView = currentDataSet.Tables(0).DefaultView
            'dgContenedor.DataSource = currentDataView


            'retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function FlipDataSet(ByVal my_DataSet As DataSet) As DataSet

        Dim ds As New DataSet()

        For Each dt As DataTable In my_DataSet.Tables
            Dim table As New DataTable()

            For i As Integer = 0 To dt.Rows.Count
                table.Columns.Add(Convert.ToString(i))
            Next

            Dim r As DataRow

            For k As Integer = 0 To dt.Columns.Count - 1
                r = table.NewRow()
                r(0) = dt.Columns(k).ToString()
                For j As Integer = 1 To dt.Rows.Count
                    r(j) = dt.Rows(j - 1)(k)
                Next
                table.Rows.Add(r)
            Next
            ds.Tables.Add(table)
        Next
        Return ds

    End Function

    Private Sub dgContenedor_Paint(sender As Object, e As PaintEventArgs) Handles dgContenedor.Paint
        Dim columnSum As Integer
        For X As Integer = 0 To dgContenedor.Columns.Count - 1
            columnSum += dgContenedor.Columns(X).Width
            e.Graphics.DrawLine(New Pen(SystemColors.ControlLight), columnSum + 1, 0, columnSum + 1, dgContenedor.Height)
        Next
    End Sub
End Class