Imports System.Text
Imports System.Drawing.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class nueva_frase
    Private Sub nueva_frase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combobox Fuentes
        'Ancho por defecto para el ComboBox
        cbFuente.Width = 200

        Dim font_family As FontFamily
        Dim installed_fonts As New InstalledFontCollection

        'Limpiamos el ComboBox en caso que tenga algo
        cbFuente.Items.Clear()

        'cargamos las fuentes (como items)en el ComboBox
        For Each font_family In FontFamily.Families
            cbFuente.Items.Add(font_family.Name)
        Next

        'Fuente Seleccionada por Defecto (Opcional)
        cbFuente.SelectedItem = "Arial"

        If txtidfrase.Text = "" Then
            limpiar()
        End If

    End Sub


    Private Sub mayusculaTipoTitulo()
        Dim fraseARetornar As String = rtb1.Text

        'primera letra
        fraseARetornar = String.Format("{0}{1}", rtb1.Text.Substring(0, 1).ToUpper, rtb1.Text.Substring(1))

        'Mayúsculas después de signos de puntuación
        Dim esMayuscula As Boolean = False
        Dim sb As New StringBuilder
        For Each c As Char In fraseARetornar
            Select Case c
                Case "."c, "¿"c, "?"c, "¡"c, "!"c
                    esMayuscula = True
                    sb.Append(c.ToString)
                    Continue For

                Case Else
                    If Char.IsLetter(c) And esMayuscula Then
                        sb.Append(Char.ToUpper(c))
                        esMayuscula = False
                        Continue For
                    Else
                        sb.Append(c.ToString)
                        esMayuscula = False
                        Continue For
                    End If
            End Select
        Next

        fraseARetornar = sb.ToString

        'Mayúsculas después de punto y seguido, interrogantes, exclamaciones
        Dim parts() As String = fraseARetornar.Split(" ")
        sb = New StringBuilder
        Dim ponerMayusculaSiguienteLetra As Boolean = False
        For i As Integer = 0 To parts.Length - 1
            If parts(i).Contains(".") OrElse parts(i).Contains("?") OrElse parts(i).Contains("!") Then
                If ponerMayusculaSiguienteLetra Then
                    sb.Append(String.Format("{0}{1} ", parts(i).Substring(0, 1).ToUpper, parts(i).Substring(1)))
                Else
                    sb.Append(String.Format("{0} ", parts(i)))
                End If

                ponerMayusculaSiguienteLetra = True
            Else
                If ponerMayusculaSiguienteLetra Then
                    sb.Append(String.Format("{0}{1} ", parts(i).Substring(0, 1).ToUpper, parts(i).Substring(1)))
                Else
                    sb.Append(String.Format("{0} ", parts(i)))
                End If

                ponerMayusculaSiguienteLetra = False
            End If
        Next

        fraseARetornar = sb.ToString

        rtb1.Text = fraseARetornar
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        rtb1.Text = rtb1.Text.ToLower
        mayusculaTipoTitulo()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        rtb1.SelectedText = rtb1.SelectedText.ToUpper
        rtb1.Select(rtb1.SelectedText.Length, 0)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rtb1.Undo()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        rtb1.Redo()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        rtb1.SelectAll()
    End Sub

    Private Sub btnFuente_Click(sender As Object, e As EventArgs) Handles btnFuente.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = rtb1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                rtb1.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Color()
    End Sub

    Public Sub Color()
        Dim colorDialog1 As ColorDialog = New ColorDialog()
        colorDialog1.Color = rtb1.SelectionColor

        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso colorDialog1.Color <> rtb1.SelectionColor Then
            rtb1.SelectionColor = colorDialog1.Color
        End If
    End Sub

    Private Sub btnNegritas_Click(sender As Object, e As EventArgs) Handles btnNegritas.Click
        negrita()
    End Sub

    Private Sub negrita()
        If rtb1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = rtb1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If rtb1.SelectionFont.Bold = True Then
                newFontStyle = FontStyle.Regular

            Else
                newFontStyle = FontStyle.Bold

            End If

            rtb1.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        rtb1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        rtb1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        rtb1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub btnCursivas_Click(sender As Object, e As EventArgs) Handles btnCursivas.Click
        cursiva()
    End Sub

    Private Sub cursiva()
        If rtb1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = rtb1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If rtb1.SelectionFont.Italic = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Italic
            End If

            rtb1.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If
    End Sub

    Private Sub btnSubrayado_Click(sender As Object, e As EventArgs) Handles btnSubrayado.Click
        subrayado()
    End Sub

    Private Sub subrayado()
        If rtb1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = rtb1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If rtb1.SelectionFont.Underline = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Underline
            End If

            rtb1.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If
    End Sub

    Private Sub cbtamano_TextChanged(sender As Object, e As EventArgs) Handles cbtamano.TextChanged
        rtb1.SelectionFont = New Font(cbFuente.Text, CInt(cbtamano.Text))
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        rtb1.SelectionBullet = True
        rtb1.SelectionIndent = 16
    End Sub

    Private Sub cbFuente_TextChanged(sender As Object, e As EventArgs) Handles cbFuente.TextChanged
        rtb1.SelectionFont = New Font(cbFuente.Text, CInt(cbtamano.Text))
    End Sub

    Private Sub guardar_frase()

        If (Not System.IO.Directory.Exists("C:\osiris\files\temp")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp")
        End If

        rtb1.SaveFile("C:\osiris\files\temp\temporal.rtf", RichTextBoxStreamType.RichNoOleObjs)

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
        myCommand.CommandText = "INSERT INTO frases (nombre,frase,idusuario) VALUES (?nombre,?frase,?idusuario)"
        myCommand.Parameters.AddWithValue("?nombre", txtdescripcion.Text)
        myCommand.Parameters.AddWithValue("?frase", arrFile)
        myCommand.Parameters.AddWithValue("?idusuario", main_menu.txtidusuario.Text)

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

    Private Sub actualizar_frase()

        If (Not System.IO.Directory.Exists("C:\osiris\files\temp")) Then
            System.IO.Directory.CreateDirectory("C:\osiris\files\temp")
        End If

        rtb1.SaveFile("C:\osiris\files\temp\temporal.rtf", RichTextBoxStreamType.RichNoOleObjs)

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
        myCommand.CommandText = "UPDATE frases SET nombre=?nombre,frase=?frase WHERE idfrase =" & txtidfrase.Text
        myCommand.Parameters.AddWithValue("?nombre", txtdescripcion.Text)
        myCommand.Parameters.AddWithValue("?frase", arrFile)

        Try
            conec.Open()
            myCommand.ExecuteNonQuery()
            'Mensaje de Confirmacion
            MsgBox("Actualizado con exito", MsgBoxStyle.Information, "Exito!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub


    Public Sub limpiar()
        rtb1.Clear()
        txtdescripcion.Clear()
        txtidfrase.Clear()
        rtb1.Text = ""
        rtb1.Select()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtidfrase.Text <> "" Then
            If txtdescripcion.Text <> "" Then
                actualizar_frase()
                limpiar()
                frases.llenar_datagridview_frases()
                Me.Close()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtdescripcion.Text <> "" Then
                guardar_frase()
                limpiar()
                frases.llenar_datagridview_frases()
                Me.Close()
            Else
                MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Error al intentar actualizar el centro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub obtener_frase()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT frase FROM frases WHERE idfrase='" & txtidfrase.Text & "'")
            If tabla.Rows.Count <> 0 Then
                'Creo mi arreglo que almacenara los bytes del archivo
                Dim barrFile() As Byte = CType(tabla.Rows(0)(0), Byte())
                'Creo el archivo apartir de los bytes
                Using newFile As New FileStream(("C:\osiris\files\temp\temporal1.rtf"), FileMode.Create, FileAccess.Write)
                    newFile.Write(barrFile, 0, barrFile.Length)
                    newFile.Flush()
                    newFile.Close()
                End Using
                'Abro el archivo temporal en el RichTextBox
                rtb1.LoadFile("C:\osiris\files\temp\temporal1.rtf")


            End If
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub


    Private Function MuestraDB(ByVal Query As String)

        Dim conexion As New MySqlConnection
        'Dim myCommand As New MySqlCommand
        conexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        Dim ds As DataSet = New DataSet()
        Dim adaptador As MySqlDataAdapter
        Dim tabla As DataTable = New DataTable
        Dim constructor As MySqlCommandBuilder

        Try
            adaptador = New MySqlDataAdapter(Query, conexion)
            constructor = New MySqlCommandBuilder(adaptador) 'Se interpreta la consulta
            adaptador.Fill(tabla) 'Se guarda los registros obtenido en la variable tabla
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al leer la base de datos")
        End Try
        Return tabla
    End Function

    Private Sub txtidfrase_TextChanged(sender As Object, e As EventArgs) Handles txtidfrase.TextChanged
        obtener_frase()
        If txtidfrase.Text <> "" Then
            btnRegistrar.Text = "ACTUALIZAR"
        Else
            btnRegistrar.Text = "AGREGAR"
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtdescripcion.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

End Class