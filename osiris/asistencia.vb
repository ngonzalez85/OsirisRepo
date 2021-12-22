Imports MySql.Data.MySqlClient
Imports System.IO
Public Class asistencia
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim dt As DataTable
    Private Sub asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_datagridview_estudios()
    End Sub

    Public Sub llenar_datagridview_estudios()

        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT u.idusuario,u.cin,u.nombre AS medico,u.especialidad 
            from usuarios u 
            INNER JOIN roles r ON u.idrol = r.idrol 
            INNER JOIN usuarios_centros uc ON u.idusuario = uc.idusuario 
            WHERE r.ismedico=1 AND uc.idcentro='" & main_menu.txtidcentro.Text & "' 
            GROUP BY medico ORDER BY u.nombre ASC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            'data table
            dt = New DataTable
            adaptador.Fill(dt)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "estudios"
            retocar_columnas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(1).Visible = False
            Me.dgContenedor.Columns(2).Visible = False
            Me.dgContenedor.Columns(3).HeaderText = "MEDICO"
            Me.dgContenedor.Columns(4).HeaderText = "ESPECIALIDAD"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    Dim isCheched As Boolean
    Private Sub dgContenedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellContentClick
        If e.ColumnIndex = Me.dgContenedor.Columns.Item("check").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgContenedor.Rows(e.RowIndex).Cells("check")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim medicoayudante As Integer
        Dim nombremedico As String
        For Each fila As DataGridViewRow In Me.dgContenedor.Rows
            If Convert.ToBoolean(fila.Cells("check").Value) Then
                ' MessageBox.Show("Medico:" + fila.Cells("medico").Value.ToString())
                ' MessageBox.Show("idusuario:" + fila.Cells("idusuario").Value.ToString())
                medicoayudante = fila.Cells("idusuario").Value.ToString()
                nombremedico = fila.Cells("medico").Value.ToString()
                guardar_colaboracion(medicoayudante, nombremedico)
            End If
        Next
    End Sub

    Private Sub guardar_colaboracion(ByRef medicoayudante As Integer, ByRef nombremedico As String)
        Try
            Dim conec As New MySqlConnection
            Dim myCommand As New MySqlCommand
            conec.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
            'myCommand.Connection = conec
            myCommand.Connection = conec 'Cadena de conexión.
            myCommand.CommandText = "INSERT INTO colaboraciones (idestudio,idinforme,idmedicosolicitante,idmedicoayudante,comentariosolicitante, estado) VALUES (?idestudio,?idinforme,?idmedicosolicitante,?idmedicoayudante,?comentariosolicitante,?estado)"
            myCommand.Parameters.AddWithValue("?idestudio", txtidestudio.Text)
            myCommand.Parameters.AddWithValue("?idinforme", txtidinforme.Text)
            myCommand.Parameters.AddWithValue("?idmedicosolicitante", txtidmedico.Text)
            myCommand.Parameters.AddWithValue("?idmedicoayudante", medicoayudante)
            myCommand.Parameters.AddWithValue("?comentariosolicitante", txtcomentario.Text)
            myCommand.Parameters.AddWithValue("?estado", "SOLICITADO")
            Try
                conec.Open()
                myCommand.ExecuteNonQuery()
                ' Mensaje de Confirmacion
                MsgBox("Enviado a " & nombremedico & " con exito", MsgBoxStyle.Information, "Exito!")
            Catch ex As Exception
                ' MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
            End Try
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try

    End Sub


End Class