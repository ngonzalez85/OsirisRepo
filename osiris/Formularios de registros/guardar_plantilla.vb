
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class guardar_plantilla
    Private Sub guardar_plantilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbtipo_estudio.Items.Clear()
        txtidtipoestudio.Clear()
        txtdescripcion.Clear()
        llenar_combobox_tipo_estudio(cbtipo_estudio)
    End Sub

    Private Sub cbtipo_estudio_TextChanged(sender As Object, e As EventArgs) Handles cbtipo_estudio.TextChanged
        If cbtipo_estudio.Text <> "" Then
            consultar_id_tipoestudio(cbtipo_estudio.Text)
            If dr.Read Then
                txtidtipoestudio.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtdescripcion.Text <> "" And txtidtipoestudio.Text <> "" Then
            guardar_plantilla()
            limpiar()
            Dim frm As redactar_informe = CType(Owner, redactar_informe)
            frm.TreeView1.Nodes.Clear()
            frm.cargar_arbol()

            Me.Close()
        Else
            MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub guardar_plantilla()

        If (Not System.IO.Directory.Exists("C:\osiris\files\temp")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp")
        End If
        Dim frm As redactar_informe = CType(Owner, redactar_informe)
        frm.rtb1.SaveFile("C:\osiris\files\temp\temporal.rtf", RichTextBoxStreamType.RichNoOleObjs)

        'Convertirlo a un arreglo de bytes
        Dim mi_archivo As FileStream = New FileStream(("C:\osiris\files\temp\temporal.rtf"), FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim arrFile() As Byte = New Byte((mi_archivo.Length) - 1) {}
        Dim reader As BinaryReader = New BinaryReader(mi_archivo)
        arrFile = reader.ReadBytes(Convert.ToInt32(mi_archivo.Length))
        reader.Close()
        'Guardarlo en DB
        Dim conec As New MySqlConnection
        Dim myCommand As New MySqlCommand
        conec.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
        'myCommand.Connection = conec
        myCommand.Connection = conec 'Cadena de conexión.
        myCommand.CommandText = "INSERT INTO plantillas (idusuario,descripcion,plantilla,idtipoestudio) VALUES (?idusuario,?descripcion,?plantilla,?idtipoestudio)"
        myCommand.Parameters.AddWithValue("?idusuario", main_menu.txtidusuario.Text)
        myCommand.Parameters.AddWithValue("?descripcion", txtdescripcion.Text)
        myCommand.Parameters.AddWithValue("?plantilla", arrFile)
        myCommand.Parameters.AddWithValue("?idtipoestudio", txtidtipoestudio.Text)

        Try
            conec.Open()
            myCommand.ExecuteNonQuery()
            'Mensaje de Confirmacion
            MsgBox("Guardado con exito", MsgBoxStyle.Information, "Exito!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub

    Private Sub limpiar()
        txtdescripcion.Clear()
        cbtipo_estudio.Text = ""
        txtidtipoestudio.Clear()
    End Sub
End Class