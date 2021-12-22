Imports MySql.Data.MySqlClient
Imports System.IO
'Imports System.Runtime.InteropServices
Imports System.Drawing.Text
Imports System.Text
Imports System.Threading
Imports CrystalDecisions.Shared
Imports System.ComponentModel

Public Class redactar_informe
    Dim NEGRITA As Boolean = False
    Dim CURSIVA As Boolean = False
    Dim SUBRAYADO As Boolean = False
    Dim ORIGINAL As Font
    Dim MIESTILO As FontStyle
    Dim formulario As String = "redactar_informe"
    Private Sub redactar_informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Redacción de informe médico │ Dr./Dra. " & main_menu.lblusuario.Text
        chkfirma.CheckState = CheckState.Checked

        Me.lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        abrir_logo_centro()

        Me.ToolTip1.SetToolTip(Me.btnVista, "Informe preliminar")
        Me.ToolTip1.SetToolTip(Me.btnFirmar, "Firmar y enviar informe")
        Me.ToolTip1.SetToolTip(Me.btnimagen, "Ver estudio")
        Me.ToolTip1.SetToolTip(Me.btn_ayuda, "Solicitar colaboración")
        Me.ToolTip1.SetToolTip(Me.btnAsignar, "Asignar a otro medico")
        Me.ToolTip1.IsBalloon = True

        cargar_autoguardado()

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


        'abrir_adjuntos()
        llenar_datagridview_estudios_anteriores()
        TreeView1.Nodes.Clear()
        cargar_arbol()

        llenar_datagridview_estudios_medvital()
        cambiarProceso()
        'autoguardado()
        cargar_arbol_agenda()
        cargar_arbol_adjuntos()

        If txtidcentro.Text <> 1 Then
            consultar_centro(txtidcentro.Text)
            If dr.Read Then
                TabControl1.TabPages.Remove(TabPage1)
                TabPage2.Text = dr(1)
            End If

        Else
            TabControl1.TabPages.Remove(TabPage2)
        End If

        If main_menu.firmar = 1 Then
            btnFirmar.Enabled = True
        Else
            btnFirmar.Enabled = False
        End If
    End Sub

    Private Sub cambiarProceso()
        If rtb1.TextLength > 0 Then
            actualizar_estado_estudio_(txtidestudio.Text)
        Else
            actualizar_estado_estudio_asignado(txtidestudio.Text)
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
        rtb1.SelectedText = rtb1.SelectedText.ToLower
        rtb1.Select(rtb1.SelectedText.Length, 0)
        '  mayusculaTipoTitulo()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        rtb1.SelectedText = rtb1.SelectedText.ToUpper
        rtb1.Select(rtb1.SelectedText.Length, 0)
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnFirmar.Click
        imprimir_con_vista_previa()
        llamar_procedimiento()
        'imprimir_sin_vista_previa()
    End Sub

    Dim band As Integer = 0
    Private Sub imprimir_con_vista_previa()
        Try
            comprobar_permiso_firma(txtidestudio.Text, txtidmedico.Text, formulario)
            If dr.Read Then

                Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea firmar el estudio?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then

                    generar_binario()
                    consultar_ultimo_informe(txtidestudio.Text)
                    If dr.Read Then
                        txtidinforme.Text = dr(0)
                        firmar_estudio(txtidestudio.Text, txtidinforme.Text, txtidmedico.Text, formulario)
                        actualizarmedicoinforme(txtidmedico.Text, txtidinforme.Text)
                        MessageBox.Show("Estudio FIRMADO correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    generar_reporte()

                    rtb1.Enabled = False
                    band = 1

                    informes.limpiar()
                    informes.llenar_datagridview_estudios()
                    Me.Close()
                End If
            Else
                MessageBox.Show("No tiene permiso para firmar este estudio debido a que fue reasignado a otro médico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub imprimir_sin_vista_previa()
        comprobar_permiso_firma(txtidestudio.Text, txtidmedico.Text, formulario)
        If dr.Read Then

            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea firmar el estudio?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then

                generar_binario()
                consultar_ultimo_informe(txtidestudio.Text)
                If dr.Read Then
                    txtidinforme.Text = dr(0)
                    firmar_estudio(txtidestudio.Text, txtidinforme.Text, txtidmedico.Text, formulario)
                    MessageBox.Show("Estudio FIRMADO correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                imprimirInforme()

                rtb1.Enabled = False

                informes.llenar_datagridview_estudios()
                Me.Close()
            End If
        Else
            MessageBox.Show("No tiene permiso para firmar este estudio debido a que fue reasignado a otro médico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub generar_binario()

        consultar_informe_estudio(txtidestudio.Text, formulario)
        If dr.Read Then
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
            myCommand.Connection = conec 'Cadena de conexión.
            myCommand.CommandText = "UPDATE informes SET cuerpo=?cuerpo,firma=?firma WHERE idestudio=?idestudio"
            myCommand.Parameters.AddWithValue("?idestudio", txtidestudio.Text)
            myCommand.Parameters.AddWithValue("?cuerpo", arrFile)
            myCommand.Parameters.AddWithValue("?firma", main_menu.lblfirma_informe.Text)
            Try
                conec.Open()
                myCommand.ExecuteNonQuery()
                'Mensaje de Confirmacion
                'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Exito!")
            Catch ex As Exception
                'MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
            End Try
        Else

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
            myCommand.CommandText = "INSERT INTO informes (idestudio,idcentro_solicitante,idcentro_emisor,cin,paciente,edad,fecha_estudio,estudio_realizado,motivo,idmedico,cuerpo,tecnico,firma) VALUES (?idestudio,?idcentro_solicitante,?idcentro_emisor,?cin,?paciente,?edad,?fecha_estudio,?estudio_realizado,?motivo,?idmedico,?cuerpo,?tecnico,?firma)"
            myCommand.Parameters.AddWithValue("?idestudio", txtidestudio.Text)
            myCommand.Parameters.AddWithValue("?idcentro_solicitante", txtidcentro.Text)
            myCommand.Parameters.AddWithValue("?idcentro_emisor", main_menu.txtidcentro.Text)
            myCommand.Parameters.AddWithValue("?cin", lblci.Text)
            myCommand.Parameters.AddWithValue("?paciente", lblpaciente.Text)
            myCommand.Parameters.AddWithValue("?edad", lbledad.Text)
            myCommand.Parameters.AddWithValue("?fecha_estudio", lblfecha.Text)
            myCommand.Parameters.AddWithValue("?estudio_realizado", lblestudio.Text)
            myCommand.Parameters.AddWithValue("?motivo", lblmotivo.Text)
            myCommand.Parameters.AddWithValue("?idmedico", txtidmedico.Text)
            myCommand.Parameters.AddWithValue("?cuerpo", arrFile)
            myCommand.Parameters.AddWithValue("?tecnico", lbltecnico.Text)
            myCommand.Parameters.AddWithValue("?firma", main_menu.lblfirma_informe.Text)
            Try
                conec.Open()
                myCommand.ExecuteNonQuery()
                'Mensaje de Confirmacion
                'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Exito!")
            Catch ex As Exception
                'MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
            End Try
        End If

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
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al leer la base de datos")
        End Try
        Return tabla
    End Function

    Private Sub btnVista_Click(sender As Object, e As EventArgs) Handles btnVista.Click
        Try
            comprobar_permiso_firma(txtidestudio.Text, txtidmedico.Text, formulario)
            If dr.Read Then
                generar_vista()
            Else
                MessageBox.Show("No tiene permiso para previsualizar este estudio debido a que fue reasignado a otro médico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub generar_vista()
        Dim frmVista As New vista_previa
        AddOwnedForm(frmVista)


        If rtb1.Rtf <> "" Then
            frmVista.cuerpo = Me.rtb1.Rtf
        Else
            frmVista.cuerpo = "INFORME VACIO"
        End If

        frmVista.cin = Me.lblci.Text
        frmVista.edad = Me.lbledad.Text
        frmVista.fecha = Me.lblfecha.Text
        frmVista.estudio = Me.lblestudio.Text
        frmVista.motivo = Me.lblmotivo.Text
        frmVista.paciente = Me.lblpaciente.Text
        frmVista.idcentro = Me.txtidcentro.Text
        frmVista.idcentro_solicitante = Me.txtidcentro_solicitante.Text
        frmVista.idmedico = Me.txtidmedico.Text
        frmVista.idestudio = Me.txtidestudio.Text
        frmVista.tecnico = Me.lbltecnico.Text
        frmVista.fecha_informe = DateTime.Now.ToLongDateString
        frmVista.doctor_solicitante = Me.lblmedicosolicitante.Text
        frmVista.flag = 0

        frmVista.Show()
    End Sub

    Private Sub generar_reporte()
        'Dim frmReporte As New vista_previa
        'AddOwnedForm(frmReporte)
        vista_previa.cuerpo = Me.rtb1.Rtf
        vista_previa.cin = Me.lblci.Text
        vista_previa.edad = Me.lbledad.Text
        vista_previa.fecha = Me.lblfecha.Text
        vista_previa.estudio = Me.lblestudio.Text
        vista_previa.motivo = Me.lblmotivo.Text
        vista_previa.paciente = Me.lblpaciente.Text
        vista_previa.idcentro = txtidcentro.Text
        vista_previa.idcentro_solicitante = Me.txtidcentro_solicitante.Text
        vista_previa.idmedico = Me.txtidmedico.Text
        vista_previa.idestudio = Me.txtidestudio.Text
        vista_previa.tecnico = Me.lbltecnico.Text
        vista_previa.fecha_informe = DateTime.Now.ToLongDateString
        vista_previa.doctor_solicitante = Me.lblmedicosolicitante.Text
        vista_previa.flag = 1

        vista_previa.Show()
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
        texto_negritas()
    End Sub


    Private Sub btnimagen_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        cerrar_radiant()

        If main_menu.lblidrol.Text <> "10" Then
            verificar_imagen()
        Else
            descargar_estudioC()
        End If
    End Sub

    'Dim directorio As String
    'Dim carpeta_estudios_subidos As String
    Dim ubi_visor As String
    Dim abrir As Integer = 1
    Private Sub verificar_imagen()
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If (result = DialogResult.Yes) Then
                ubi_visor = visorRadiant
            ElseIf result = DialogResult.No Then
                ubi_visor = visorMicro
            ElseIf result = DialogResult.Cancel Then
                abrir = 0
            End If

            If abrir = 1 Then
                Dim imagen As String = txtidestudio.Text & ".zip"

                If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & imagen)) Then
                    MessageBox.Show("No se encuentra el archivo de imagenes del estudio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & imagen, AppWinStyle.MaximizedFocus)
                End If
            Else
                abrir = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

    Private Sub descargar_estudioC()
        Try
            If txtidestudio.Text <> "" Then

                Dim imagen As String = txtidestudio.Text & ".zip"

                If txtdicom.Text = "SI" Then
                    If (Not System.IO.File.Exists("C:\osiris\estudios_descargados_cardio\" & imagen)) Then
                        MessageBox.Show("Aguarde un momento, el estudio " & txtidestudio.Text & " se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Este estudio ya esta descargado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try
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
        texto_cursiva()
    End Sub

    Private Sub btnSubrayado_Click(sender As Object, e As EventArgs) Handles btnSubrayado.Click
        texto_subrayado()
    End Sub
    Private Sub texto_negritas()
        If NEGRITA = False Then
            NEGRITA = True
        Else
            NEGRITA = False
        End If
        TVERDAD()
    End Sub

    Private Sub texto_cursiva()
        If CURSIVA = False Then
            CURSIVA = True
        Else
            CURSIVA = False
        End If
        TVERDAD()
    End Sub

    Private Sub texto_subrayado()
        If SUBRAYADO = False Then
            SUBRAYADO = True
        Else
            SUBRAYADO = False
        End If
        TVERDAD()
    End Sub

    Public Sub TVERDAD()

        If NEGRITA = False And CURSIVA = False And SUBRAYADO = False Then '000
            MIESTILO = FontStyle.Regular

        ElseIf NEGRITA = True And CURSIVA = False And SUBRAYADO = False Then '100
            MIESTILO = FontStyle.Bold

        ElseIf NEGRITA = False And CURSIVA = True And SUBRAYADO = False Then '010
            MIESTILO = FontStyle.Italic

        ElseIf NEGRITA = False And CURSIVA = False And SUBRAYADO = True Then '001
            MIESTILO = FontStyle.Underline

        ElseIf NEGRITA = True And CURSIVA = True And SUBRAYADO = False Then '110
            MIESTILO = FontStyle.Bold + FontStyle.Italic

        ElseIf NEGRITA = True And CURSIVA = False And SUBRAYADO = True Then '101
            MIESTILO = FontStyle.Bold + FontStyle.Underline

        ElseIf NEGRITA = False And CURSIVA = True And SUBRAYADO = True Then '011
            MIESTILO = FontStyle.Italic + FontStyle.Underline

        ElseIf NEGRITA = True And CURSIVA = True And SUBRAYADO = True Then '111
            MIESTILO = FontStyle.Bold + FontStyle.Italic + FontStyle.Underline
        End If

        If rtb1.SelectionFont IsNot Nothing Then
            rtb1.SelectionFont = New Font(rtb1.SelectionFont, MIESTILO)
        End If

    End Sub

    Private Sub cbtamano_TextChanged(sender As Object, e As EventArgs) Handles cbtamano.TextChanged
        If IsNumeric(cbtamano.Text) Then
            rtb1.SelectionFont = New Font(cbFuente.Text, CInt(cbtamano.Text))
        End If

    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        rtb1.SelectionBullet = True
        rtb1.SelectionIndent = 16
    End Sub

    Private Sub cbFuente_TextChanged(sender As Object, e As EventArgs) Handles cbFuente.TextChanged
        rtb1.SelectionFont = New Font(cbFuente.Text, CInt(cbtamano.Text))
    End Sub

    'Private Sub pb1_Click(sender As Object, e As EventArgs)
    '    preview.Close()
    '    preview.pbPreview.Image = Me.pb1.Image
    '    preview.pbminiatura1.Image = Me.pb1.Image
    '    preview.pbminiatura2.Image = Me.pb2.Image
    '    preview.pbminiatura3.Image = Me.pb3.Image
    '    preview.pbminiatura4.Image = Me.pb4.Image
    '    preview.lblpagina.Text = "1 de 4"
    '    preview.Show()
    'End Sub

    'Private Sub pb2_Click(sender As Object, e As EventArgs)
    '    preview.Close()
    '    preview.pbPreview.Image = Me.pb2.Image
    '    preview.pbminiatura1.Image = Me.pb1.Image
    '    preview.pbminiatura2.Image = Me.pb2.Image
    '    preview.pbminiatura3.Image = Me.pb3.Image
    '    preview.pbminiatura4.Image = Me.pb4.Image
    '    preview.lblpagina.Text = "2 de 4"
    '    preview.Show()
    'End Sub

    'Private Sub pb3_Click(sender As Object, e As EventArgs)
    '    preview.Close()
    '    preview.pbPreview.Image = Me.pb3.Image
    '    preview.pbminiatura1.Image = Me.pb1.Image
    '    preview.pbminiatura2.Image = Me.pb2.Image
    '    preview.pbminiatura3.Image = Me.pb3.Image
    '    preview.pbminiatura4.Image = Me.pb4.Image
    '    preview.lblpagina.Text = "3 de 4"
    '    preview.Show()
    'End Sub

    'Private Sub pb4_Click(sender As Object, e As EventArgs)
    '    preview.Close()
    '    preview.pbPreview.Image = Me.pb4.Image
    '    preview.pbminiatura1.Image = Me.pb1.Image
    '    preview.pbminiatura2.Image = Me.pb2.Image
    '    preview.pbminiatura3.Image = Me.pb3.Image
    '    preview.pbminiatura4.Image = Me.pb4.Image
    '    preview.lblpagina.Text = "4 de 4"
    '    preview.Show()
    'End Sub

    Private Sub abrir_logo_centro()
        consultar_centro(txtidcentro.Text)
        If dr.Read Then
            Dim logo As Byte()
            logo = dr(8)
            pblogo.Image = Bytes_Imagen(logo)
        End If
    End Sub

    Private Sub abrir_logo_centro2()
        consultar_centro2(txtidcentro.Text, formulario)
        If dr2.Read Then
            Dim logo As Byte()
            logo = dr2(8)
            pblogo.Image = Bytes_Imagen(logo)
        End If
    End Sub

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado

            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs)
        aplicar_plantilla.cbtipo_estudio.Text = Me.lbltipoestudio.Text
        aplicar_plantilla.ShowDialog()
    End Sub


    Private Sub Contextual_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Contextual.ItemClicked
        Select Case e.ClickedItem.Name
            Case "seleccionar"
                rtb1.SelectAll()
            Case "copiar"
                Clipboard.SetDataObject(rtb1.SelectedText)
            Case "cortar"
                Clipboard.SetDataObject(rtb1.SelectedText)
                rtb1.Cut()
            Case "pegar"
                rtb1.Paste()
            Case "guardar"
                Dim frm As New guardar_plantilla
                AddOwnedForm(frm)
                frm.ShowDialog()
        End Select
    End Sub

    '************************************************
    ' variable del objeto DataView, se usa para poder realizar filtros dentro de la misma
    Private oVista As DataView
    ' variable (Flag) usada para indicar que si hay o no un Drag and Drop dentro del TreeView
    Private DragDropTreeView As Boolean
    ' variable que guarda el nodo arrastrado por el usuario.
    Private NodoOrigen As TreeNode
    Dim usuario As Integer = main_menu.txtidusuario.Text

    ''CARGAR ARBOL
    'Public Sub cargar_arbol()
    '    Console.WriteLine(usuario)
    '    Dim nodo As TreeNode

    '    ' crear conexión
    '    Dim oConexion As New MySqlConnection
    '    oConexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

    '    ' crear los DataAdapter
    '    Dim oDAPlantillas As New MySqlDataAdapter("SELECT * FROM plantillas WHERE idusuario=" & main_menu.txtidusuario.Text, oConexion)
    '    Dim oDATipo_estudios As New MySqlDataAdapter("SELECT * FROM tipo_estudios", oConexion)

    '    ' crear conjunto de datos
    '    Dim oDataSet As New DataSet

    '    ' abrir la conexión
    '    oConexion.Open()

    '    ' utilizar los adaptadores para llenar el dataset con las tabla
    '    oDAPlantillas.Fill(oDataSet, "plantillas")
    '    oDATipo_estudios.Fill(oDataSet, "tipo_estudios")

    '    ' cerrar la conexión
    '    oConexion.Close()

    '    ' defino variables del tipo DataTable
    '    Dim oTablaPlantillas As DataTable
    '    Dim oTablaTipo_estudios As DataTable

    '    ' asigno a las variables los datos de las tablas del DataSet
    '    oTablaPlantillas = oDataSet.Tables("plantillas")
    '    oTablaTipo_estudios = oDataSet.Tables("tipo_estudios")

    '    ' lleno la vista con el contenido de la Tabla Territories
    '    oVista = oTablaPlantillas.DefaultView

    '    ' deshabilita la actualización en pantalla del control TreeView 
    '    TreeView1.BeginUpdate()

    '    ' defino variable del tipo DataRow
    '    Dim Registro As DataRow

    '    ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
    '    nodo = TreeView1.Nodes.Add("PLANTILLAS DEL USUARIO")

    '    For Each Registro In oTablaTipo_estudios.Rows
    '        ' agrego el nodo en el segundo nivel
    '        nodo = TreeView1.Nodes(0).Nodes.Add(Trim(Registro("tipoestudio")))
    '        ' si no hay un nodo raiz, se usaría la siguiente línea
    '        'nodo = TreeView1.Nodes.Add(Trim(Registro("RegionDescription")))

    '        ' realizo un filtro dentro de la vista
    '        oVista.RowFilter = "idtipoestudio = " & Registro("idtipoestudio")

    '        ' ciclo para recorrer la vista previamente filtrada
    '        Dim a As Integer
    '        For a = 0 To oVista.Count - 1
    '            ' agrego el nodo en el tercer nivel
    '            nodo.Nodes.Add(Trim(oVista.Item(a).Row("descripcion")))
    '        Next
    '        ' expando todos los nodos de árbol secundario
    '        nodo.ExpandAll()
    '    Next

    '' crear los DataAdapter
    'Dim oDAFrases As New MySqlDataAdapter("SELECT * FROM frases WHERE idusuario=" & usuario, oConexion)

    '    ' abrir la conexión
    '    oConexion.Open()

    '    ' utilizar los adaptadores para llenar el dataset con las tabla
    '    oDAFrases.Fill(oDataSet, "frases")

    '    ' cerrar la conexión
    '    oConexion.Close()

    '    ' defino variables del tipo DataTable
    '    Dim oTablaFrases As DataTable

    '    ' asigno a las variables los datos de las tablas del DataSet
    '    oTablaFrases = oDataSet.Tables("frases")

    '    ' deshabilita la actualización en pantalla del control TreeView 
    '    TreeView1.BeginUpdate()

    '    ' defino variable del tipo DataRow
    '    Dim Registro2 As DataRow

    '    ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
    '    nodo = TreeView1.Nodes.Add("FRASES FRECUENTES")

    '    For Each Registro2 In oTablaFrases.Rows
    '        ' agrego el nodo en el segundo nivel
    '        nodo = TreeView1.Nodes(1).Nodes.Add(Trim(Registro2("nombre")))

    '        ' expando todos los nodos de árbol secundario
    '        nodo.ExpandAll()
    '    Next

    '    ' habilita la actualización en pantalla del control TreeView
    '    TreeView1.EndUpdate()

    '    ' modifico la propiedad AllowDrop a True para poder realizar Drag and Drop
    '    TreeView1.AllowDrop = True

    '    ' modifico la propiedad Sorted a True para que los nodos estén ordenados
    '    TreeView1.Sorted = True
    '    ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)

    'End Sub

    Public Sub cargar_arbol()
        Dim nodo As TreeNode

        ' crear conexión
        Dim oConexion As New MySqlConnection
        oConexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        ' crear los DataAdapter
        Dim oDAPlantillas As New MySqlDataAdapter("SELECT * FROM plantillas WHERE idusuario=" & main_menu.txtidusuario.Text, oConexion)
        Dim oDATipo_estudios As New MySqlDataAdapter("SELECT * FROM tipo_estudios", oConexion)

        ' crear conjunto de datos
        Dim oDataSet As New DataSet

        ' abrir la conexión
        oConexion.Open()

        ' utilizar los adaptadores para llenar el dataset con las tabla
        oDAPlantillas.Fill(oDataSet, "plantillas")
        oDATipo_estudios.Fill(oDataSet, "tipo_estudios")

        ' cerrar la conexión
        oConexion.Close()

        ' defino variables del tipo DataTable
        Dim oTablaPlantillas As DataTable
        Dim oTablaTipo_estudios As DataTable

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaPlantillas = oDataSet.Tables("plantillas")
        oTablaTipo_estudios = oDataSet.Tables("tipo_estudios")

        ' lleno la vista con el contenido de la Tabla Territories
        oVista = oTablaPlantillas.DefaultView

        ' deshabilita la actualización en pantalla del control TreeView 
        TreeView1.BeginUpdate()

        ' defino variable del tipo DataRow
        Dim Registro As DataRow

        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
        nodo = TreeView1.Nodes.Add("PLANTILLAS DEL USUARIO")

        For Each Registro In oTablaTipo_estudios.Rows
            ' agrego el nodo en el segundo nivel
            nodo = TreeView1.Nodes(0).Nodes.Add(Trim(Registro("tipoestudio")))
            ' si no hay un nodo raiz, se usaría la siguiente línea
            'nodo = TreeView1.Nodes.Add(Trim(Registro("RegionDescription")))

            ' realizo un filtro dentro de la vista
            oVista.RowFilter = "idtipoestudio = " & Registro("idtipoestudio")

            ' ciclo para recorrer la vista previamente filtrada
            Dim a As Integer
            For a = 0 To oVista.Count - 1
                ' agrego el nodo en el tercer nivel
                nodo.Nodes.Add(Trim(oVista.Item(a).Row("descripcion")))
            Next
            ' expando todos los nodos de árbol secundario
            nodo.ExpandAll()
        Next

        ' nodo = TreeView1.Nodes.Add("PLANTILLAS NORMALES MEDVITAL")
        nodo = TreeView1.Nodes.Add("FRASES FRECUENTES")

        ' crear los DataAdapter
        Dim oDAFrases As New MySqlDataAdapter("SELECT * FROM frases WHERE idusuario=" & usuario, oConexion)

        ' abrir la conexión
        oConexion.Open()

        ' utilizar los adaptadores para llenar el dataset con las tabla
        oDAFrases.Fill(oDataSet, "frases")

        ' cerrar la conexión
        oConexion.Close()

        ' defino variables del tipo DataTable
        Dim oTablaFrases As DataTable

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaFrases = oDataSet.Tables("frases")


        ' defino variable del tipo DataRow
        Dim Registro2 As DataRow

        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)

        For Each Registro2 In oTablaFrases.Rows
            ' agrego el nodo en el segundo nivel
            nodo = TreeView1.Nodes(1).Nodes.Add(Trim(Registro2("nombre")))

            ' expando todos los nodos de árbol secundario
            nodo.ExpandAll()
        Next

        ' habilita la actualización en pantalla del control TreeView
        TreeView1.EndUpdate()

        ' modifico la propiedad AllowDrop a True para poder realizar Drag and Drop
        TreeView1.AllowDrop = True

        ' modifico la propiedad Sorted a True para que los nodos estén ordenados
        TreeView1.Sorted = True
        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)

    End Sub

    Dim reemplazar As Integer
    Dim idfrase As Integer
    Dim ParentNode As TreeNode
    Dim Padre As String
    Dim ChildNode As TreeNode
    Dim ParentNode2 As TreeNode
    Dim ChildNode2 As TreeNode
    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Try
            If e.Node.Level = 1 Then
                ParentNode = e.Node.Parent
                ChildNode = e.Node
                Padre = ParentNode.Text
            End If

            If e.Node.Level = 2 Then
                ParentNode2 = e.Node.Parent
                ChildNode2 = e.Node
                Padre = "PLANTILLAS DEL USUARIO"
            End If

            If Padre = "PLANTILLAS DEL USUARIO" Then
                ' MessageBox.Show($"Nodo Padre: {ParentNode.Text} - Nodo Hijo: {ChildNode.Text}")
                ' MessageBox.Show($"Nodo Padre: {ParentNode2.Text} - Nodo Hijo: {ChildNode2.Text}")
                If e.Node.Text <> "PLANTILLAS DEL USUARIO" Then
                    If rtb1.Text <> "" Then
                        Dim ask As MsgBoxResult = MsgBox("Desea sobreescribir la plantilla actual? ", MsgBoxStyle.YesNoCancel)
                        If ask = MsgBoxResult.Yes Then
                            consultar_plantilla(e.Node.Text)
                            If dr.Read Then
                                idplantilla = dr(0)
                                reemplazar = 1
                                obtener_plantilla()
                            End If
                        ElseIf ask = MsgBoxResult.No Then
                            consultar_plantilla(e.Node.Text)
                            If dr.Read Then
                                idplantilla = dr(0)
                                reemplazar = 0
                                obtener_plantilla()
                            End If

                        ElseIf ask = MsgBoxResult.Cancel Then

                        End If
                    Else
                        consultar_plantilla(e.Node.Text)
                        If dr.Read Then
                            idplantilla = dr(0)
                            reemplazar = 0
                            obtener_plantilla()
                        End If
                    End If
                End If

            End If

            If Padre = "FRASES FRECUENTES" Then
                If e.Node.Text <> "FRASES FRECUENTES" Then
                    consultar_frase(ChildNode.Text)
                    '  MessageBox.Show(e.Node.Text)

                    If dr.Read Then
                        '  MessageBox.Show(dr(2))
                        '  rtb1.Text = rtb1.Text + dr(2)
                        idfrase = dr(0)
                        obtener_frase()
                    End If
                End If
            End If

            'MessageBox.Show($"Nodo Padre: {Padre}")


        Catch ex As Exception

        End Try
    End Sub

    Dim radiant As Process()
    Dim micro As Process()

    Private Sub cerrar_radiant()
        radiant = Process.GetProcessesByName("RadiAntViewer")
        If radiant.Length > 0 Then
            For i = radiant.Length - 1 To 0 Step -1
                radiant(i).Kill()
            Next
        End If

        micro = Process.GetProcessesByName("MicroDicom")
        If micro.Length > 0 Then
            For i = micro.Length - 1 To 0 Step -1
                micro(i).Kill()
            Next
        End If
    End Sub


    'funion para plantilla
    Public idplantilla As Integer
    Public Sub obtener_plantilla()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT plantilla FROM plantillas WHERE idplantilla=" & idplantilla)
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

                If reemplazar = 1 Then
                    rtb1.LoadFile("C:\osiris\files\temp\temporal1.rtf")
                Else
                    Rtb.LoadFile("C:\osiris\files\temp\temporal1.rtf")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub

    Public Sub obtener_frase()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT frase FROM frases WHERE idfrase=" & idfrase)
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

                Rtb.LoadFile("C:\osiris\files\temp\temporal1.rtf")

            End If
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub

    Private Sub Rtb_TextChanged(sender As Object, e As EventArgs) Handles Rtb.TextChanged
        rtb1.SelectedRtf = Rtb.Rtf
    End Sub

    Private Sub imprimir()
        Dim MyReport As New informe_medico  ' --> Nombre del archivo RPT
        Dim instance As New Printing.PrinterSettings
        Dim MyPrinter As String = instance.PrinterName
        'Dim MyPrinter As String = "\\User-PC\LaserJet 450"

        Try
            With MyReport
                .PrintOptions.PrinterName = MyPrinter
                .PrintToPrinter(1, False, 1, 1)
            End With

        Catch ex As Exception
            MsgBox("Error Printing: " & ex.Message)
        Finally
            If Not IsNothing(MyReport) Then
                If MyReport.IsLoaded Then
                    MyReport.Close()
                End If
            End If
        End Try
    End Sub

    Private Sub redactar_informe_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As informes = CType(Owner, informes)
        frm.txtbandera.Text = 0
        '  conn2.Close()
        If band = 0 Then
            autoguardado()
            cambiarProceso()
        Else

        End If
    End Sub


    'llenar datagrid
    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_datagridview_estudios_anteriores()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT * FROM antecedentes WHERE idestudio = " & txtidestudio.Text
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "antecedentes")
            dgContenedor.DataSource = datos
            dgContenedor.DataMember = "antecedentes"
            retocar_columnas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor.Columns(1).Visible = False
            Me.dgContenedor.Columns(2).Visible = False
            'Me.dgContenedor.Columns(1).HeaderText = "ORD"
            'Me.dgContenedor.Columns(2).HeaderText = "ESTUDIO"
            Me.dgContenedor.Columns(3).Visible = False
            Me.dgContenedor.Columns(4).HeaderText = "FECHA DE SUBIDA"
            Me.dgContenedor.Columns(5).HeaderText = "OBS."

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgContenedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContenedor.CellDoubleClick
        'descarga.ShowDialog()
        Dim row As Integer = dgContenedor.RowCount
        If e.RowIndex > -1 Then
            If row > 0 Then
                txtprueba.Text = dgContenedor.SelectedCells.Item(3).Value

                If txtprueba.Text <> "" Then
                    descargar_estudios_anteriores()
                End If
            End If
        End If

    End Sub

    'DESCARGA DE ESTUDIO ANTERIOR

    Private Sub descargar()
        Dim proc As Thread
        proc = New Thread(AddressOf descargar_estudios_anteriores)
        proc.Start()
    End Sub


    Private Sub descargar_estudios_anteriores()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_anteriores\" & txtprueba.Text)) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                My.Computer.Network.DownloadFile(anterioresftp & txtprueba.Text, "C:\osiris\files\estudios_anteriores\" & txtprueba.Text, "sadmin", "Sadmin7050*", False, 11000, True)
                verificar_estudio_anterior()
                'pbloading.Visible = False
                'lblestado.Visible = False
            Else
                verificar_estudio_anterior()
                'descarga.Close()
            End If
            'verificar_estudio_anterior()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub verificar_estudio_anterior()
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If (result = DialogResult.Yes) Then
                ubi_visor = visorRadiant
            Else
                ubi_visor = visorMicro
            End If

            If (Not System.IO.File.Exists("C:\osiris\files\estudios_anteriores\" & txtprueba.Text)) Then
                MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Shell(ubi_visor & " " & "C:\osiris\files\estudios_anteriores\" & txtprueba.Text, AppWinStyle.MaximizedFocus)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

        Try
            autoguardado()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub autoguardado()

        Try
            consultar_informe_estudio(txtidestudio.Text, formulario)
            If dr.Read Then
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
                myCommand.CommandText = "UPDATE informes SET cuerpo=?cuerpo WHERE idestudio=?idestudio"
                myCommand.Parameters.AddWithValue("?idestudio", txtidestudio.Text)
                myCommand.Parameters.AddWithValue("?cuerpo", arrFile)
                'Try
                conec.Open()
                myCommand.ExecuteNonQuery()
                'Mensaje de Confirmacion
                'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Exito!")
                'Catch ex As Exception
                'MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
                'End Try
            Else
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
                myCommand.CommandText = "INSERT INTO informes (idestudio,idcentro_solicitante,idcentro_emisor,cin,paciente,edad,fecha_estudio,estudio_realizado,motivo,idmedico,cuerpo,tecnico) VALUES (?idestudio,?idcentro_solicitante,?idcentro_emisor,?cin,?paciente,?edad,?fecha_estudio,?estudio_realizado,?motivo,?idmedico,?cuerpo,?tecnico)"
                myCommand.Parameters.AddWithValue("?idestudio", txtidestudio.Text)
                myCommand.Parameters.AddWithValue("?idcentro_solicitante", txtidcentro.Text)
                myCommand.Parameters.AddWithValue("?idcentro_emisor", main_menu.txtidcentro.Text)
                myCommand.Parameters.AddWithValue("?cin", lblci.Text)
                myCommand.Parameters.AddWithValue("?paciente", lblpaciente.Text)
                myCommand.Parameters.AddWithValue("?edad", lbledad.Text)
                myCommand.Parameters.AddWithValue("?fecha_estudio", lblfecha.Text)
                myCommand.Parameters.AddWithValue("?estudio_realizado", lblestudio.Text)
                myCommand.Parameters.AddWithValue("?motivo", lblmotivo.Text)
                myCommand.Parameters.AddWithValue("?idmedico", txtidmedico.Text)
                myCommand.Parameters.AddWithValue("?cuerpo", arrFile)
                myCommand.Parameters.AddWithValue("?tecnico", lbltecnico.Text)
                'Try
                conec.Open()
                myCommand.ExecuteNonQuery()
                'Mensaje de Confirmacion
                'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Exito!")
                'Catch ex As Exception
                'MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
                'End Try
            End If
        Catch ex As Exception
            'MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")

        End Try
    End Sub


    Public Sub cargar_autoguardado()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT cuerpo FROM informes WHERE idestudio=" & txtidestudio.Text)
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

    Private Sub redactar_informe_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then
            texto_negritas()
        ElseIf e.KeyCode = Keys.K AndAlso e.Modifiers = Keys.Control Then
            texto_cursiva()
        ElseIf e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then
            texto_subrayado()
        ElseIf e.KeyCode = Keys.D AndAlso e.Modifiers = Keys.Control Then
            rtb1.SelectionAlignment = HorizontalAlignment.Right
        ElseIf e.KeyCode = Keys.Q AndAlso e.Modifiers = Keys.Control Then
            rtb1.SelectionAlignment = HorizontalAlignment.Left
        ElseIf e.KeyCode = Keys.T AndAlso e.Modifiers = Keys.Control Then
            rtb1.SelectionAlignment = HorizontalAlignment.Center
        End If
    End Sub



    Public Sub llenar_datagridview_estudios_medvital()
        Try
            Conexion3.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "SELECT e.idestudio,CONCAT(p.nombre,' ',p.apellido) AS paciente,p.edad,pr.procedimiento,t.tipoestudio,pri.prioridad,e.fecha_hora,e.estado,u.nombre, e.motivo, p.cin,e.idcentro,e.idusuariomedico,e.tecnico,e.idinforme,e.fecha_firma 
            FROM estudios e 
            INNER JOIN pacientes p ON e.idpaciente = p.idpaciente 
            INNER JOIN procedimientos pr ON e.idprocedimiento = pr.idprocedimiento 
            INNER JOIN prioridades pri ON e.idprioridad = pri.idprioridad 
            INNER JOIN usuarios u ON e.idusuariomedico = u.idusuario 
            INNER JOIN tipo_estudios t ON pr.idtipoestudio= t.idtipoestudio 
            WHERE e.idpaciente= '" & txtidpaciente.Text & "' AND e.estado = 'FIRMADO' ORDER BY e.idestudio ASC"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgContenedor_medvital.DataSource = datos
            dgContenedor_medvital.DataMember = "estudios"
            retocar_columnas_medvital()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_medvital()
        Try
            'Me.dgContenedor.Columns(0).Visible = False
            Me.dgContenedor_medvital.Columns(0).HeaderText = "ID"
            Me.dgContenedor_medvital.Columns(0).Width = 30
            Me.dgContenedor_medvital.Columns(1).Visible = False
            'Me.dgContenedor_medvital.Columns(1).Width = 290
            Me.dgContenedor_medvital.Columns(2).Visible = False
            'Me.dgContenedor_medvital.Columns(2).Width = 50
            Me.dgContenedor_medvital.Columns(3).HeaderText = "ESTUDIO REALIZADO"
            Me.dgContenedor_medvital.Columns(3).Width = 300
            Me.dgContenedor_medvital.Columns(4).HeaderText = "T. ESTUDIO"
            Me.dgContenedor_medvital.Columns(4).Width = 110
            Me.dgContenedor_medvital.Columns(5).Visible = False
            'Me.dgContenedor_medvital.Columns(5).Width = 90
            Me.dgContenedor_medvital.Columns(6).HeaderText = "F. ESTUDIO"
            Me.dgContenedor_medvital.Columns(6).Width = 130
            Me.dgContenedor_medvital.Columns(7).Visible = False
            'Me.dgContenedor_medvital.Columns(7).Width = 80
            Me.dgContenedor_medvital.Columns(8).HeaderText = "MEDICO ASIGNADO"
            Me.dgContenedor_medvital.Columns(8).Width = 290
            Me.dgContenedor_medvital.Columns(9).Visible = False
            Me.dgContenedor_medvital.Columns(10).Visible = False
            Me.dgContenedor_medvital.Columns(11).Visible = False
            Me.dgContenedor_medvital.Columns(12).Visible = False
            Me.dgContenedor_medvital.Columns(13).Visible = False
            Me.dgContenedor_medvital.Columns(14).Visible = False
            Me.dgContenedor_medvital.Columns(15).HeaderText = "F. FIRMA"
            Me.dgContenedor_medvital.Columns(15).Width = 130
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private cellValue As String = String.Empty

    Private Sub dgContenedor_medvital_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgContenedor_medvital.CellMouseClick
        Dim row As Integer = dgContenedor_medvital.RowCount
        If e.RowIndex > -1 Then
            If row > 0 Then
                If e.Button <> MouseButtons.Right Then Return
                If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then Return
                cellValue = dgContenedor(e.ColumnIndex, e.RowIndex).Value.ToString()
                ContextMenuStrip1.Show(MousePosition)
            End If
        End If

    End Sub

    Public ides As Integer

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name

            Case "ver_informe"

                Dim row As Integer = dgContenedor_medvital.Rows.Count
                If row > 0 Then
                    ides = dgContenedor_medvital.SelectedCells.Item(0).Value
                    obtener_cuerpo_anterior()

                    buscar_informe(ides)

                    If dr.Read Then
                        vista_previa.cuerpo = Me.rtb2.Rtf
                        vista_previa.cin = dr(4)
                        vista_previa.edad = dr(6)
                        vista_previa.fecha = dr(7)
                        vista_previa.estudio = dr(8)
                        vista_previa.motivo = dr(9)
                        vista_previa.paciente = dr(16)
                        vista_previa.idcentro = dr(2)
                        vista_previa.idcentro_solicitante = dr(2)
                        vista_previa.idmedico = dr(10)
                        vista_previa.idestudio = dr(1)
                        vista_previa.tecnico = dr(12)
                        vista_previa.fecha_informe = dr(14)
                        buscar_estudio(ides)
                        If dr.Read Then
                            vista_previa.doctor_solicitante = dr(18)
                        End If

                        vista_previa.flag = 3

                        vista_previa.Show()
                    End If

                End If
            Case "ver_imagen"
                If dgContenedor_medvital.Rows.Count > 0 Then
                    ides = dgContenedor_medvital.SelectedCells.Item(0).Value
                    descargar_estudios_medvital()
                End If
        End Select
    End Sub


    Public Sub obtener_cuerpo()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT cuerpo FROM informes WHERE idestudio=" & ides)
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

    Public Sub obtener_cuerpo_anterior()
        Try

            Dim tabla As DataTable = MuestraDB("SELECT cuerpo FROM informes WHERE idestudio=" & ides)
            If tabla.Rows.Count <> 0 Then
                'Creo mi arreglo que almacenara los bytes del archivo
                Dim barrFile() As Byte = CType(tabla.Rows(0)(0), Byte())
                'Creo el archivo apartir de los bytes
                Using newFile As New FileStream(("C:\osiris\files\temp\temporal_med.rtf"), FileMode.Create, FileAccess.Write)
                    newFile.Write(barrFile, 0, barrFile.Length)
                    newFile.Flush()
                    newFile.Close()
                End Using
                'Abro el archivo temporal en el RichTextBox
                rtb2.LoadFile("C:\osiris\files\temp\temporal_med.rtf")


            End If
        Catch ex As Exception
            MsgBox("Error al leer la Base de Datos" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "¡ERROR!")
        End Try
    End Sub


    Private Sub descargar_estudios_medvital()
        Try

            If (Not File.Exists("C:\osiris\files\estudios_descargados\" & ides & ".zip")) Then
                'pbloading.Visible = True
                'lblestado.Visible = True
                My.Computer.Network.DownloadFile(estudiosftp & ides & ".zip", "C:\osiris\files\estudios_descargados\" & ides & ".zip", "sadmin", "Sadmin7050*", False, 11000, True)
                verificar_estudio_medvital()
                'pbloading.Visible = False
                'lblestado.Visible = False
            Else
                verificar_estudio_medvital()
                'descarga.Close()
            End If
            'verificar_estudio_anterior()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub verificar_estudio_medvital()
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Desea abrir con RadiAnt?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If (result = DialogResult.Yes) Then
                ubi_visor = visorRadiant
            Else
                ubi_visor = visorMicro
            End If

            If (Not System.IO.File.Exists("C:\osiris\files\estudios_descargados\" & ides & ".zip")) Then
                MessageBox.Show("Aguarde un momento, el estudio se encuentra en proceso de descarga", "Gracias por su comprensión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Shell(ubi_visor & " " & "C:\osiris\files\estudios_descargados\" & ides & ".zip", AppWinStyle.MaximizedFocus)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Compruebe la ubicación de su visor registrado en el centro actual")
        End Try

    End Sub

    'CARGAR TREE VIEW DE ADJUNTOS DESDE CARPETA LOCAL

    'Private Sub cargar_arbol_agenda()
    'Dim rootNode As TreeNode
    'Dim info As New DirectoryInfo("C:\osiris\files\")

    'If info.Exists Then
    'rootNode = New TreeNode(info.Name)
    'rootNode.Tag = info
    'GetDirectories(info.GetDirectories(), rootNode)
    'TreeView2.Nodes.Add(rootNode)
    'End If

    'End Sub

    'Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)
    'Dim aNode As TreeNode
    'Dim subSubDirs() As DirectoryInfo
    'Dim subDir As DirectoryInfo
    'Dim ArchivoS() As FileInfo

    'For Each subDir In subDirs
    'aNode = New TreeNode(subDir.Name, 0, 0)
    'subSubDirs = subDir.GetDirectories()
    'agregado..
    'ArchivoS = subDir.GetFiles()

    'For Each archivo As FileInfo In ArchivoS
    'Dim aNode2 As TreeNode = New TreeNode(archivo.Name, 0, 0)
    'nodeToAddTo.Nodes.Add(aNode2)
    'Next

    'If subSubDirs.Length <> 0 Then
    'GetDirectories(subSubDirs, aNode)
    'End If

    'nodeToAddTo.Nodes.Add(aNode)

    'Next subDir

    'End Sub

    '************************************************
    ' variable del objeto DataView, se usa para poder realizar filtros dentro de la misma
    Private oVista_agenda As DataView

    Private Sub cargar_arbol_agenda()
        Dim nodo As TreeNode

        ' crear conexión
        Dim oConexion As New MySqlConnection
        oConexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        ' crear los DataAdapter
        Dim oDAAdjuntos_agenda As New MySqlDataAdapter("SELECT SUBSTRING_INDEX(SUBSTRING_INDEX(archivo, ' ', n), ' ', -1 ) AS archivo
            FROM (SELECT idreferencia, TRIM(archivo) archivo FROM medvitaltest.archivos) archivos
            JOIN  filas
              ON CHAR_LENGTH(archivo) 
                - CHAR_LENGTH(REPLACE(archivo, ' ', '')) 
                >= n - 1
             WHERE idreferencia='" & txtidcita.Text & "' AND idreferencia <> 0 ", oConexion)

        ' crear conjunto de datos
        Dim oDataSet As New DataSet

        ' abrir la conexión
        oConexion.Open()

        ' utilizar los adaptadores para llenar el dataset con las tabla
        oDAAdjuntos_agenda.Fill(oDataSet, "archivos")

        ' cerrar la conexión
        oConexion.Close()

        ' defino variables del tipo DataTable
        Dim oTablaAdjuntos_agenda As DataTable

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaAdjuntos_agenda = oDataSet.Tables("archivos")

        ' deshabilita la actualización en pantalla del control TreeView 
        TreeView2.BeginUpdate()

        ' defino variable del tipo DataRow
        Dim Registro As DataRow

        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
        nodo = TreeView2.Nodes.Add("Ordenes médicas")

        For Each Registro In oTablaAdjuntos_agenda.Rows
            ' agrego el nodo en el segundo nivel
            nodo = TreeView2.Nodes(0).Nodes.Add(Trim(Registro("archivo")))

            ' expando todos los nodos de árbol secundario
            nodo.ExpandAll()
        Next

        ' habilita la actualización en pantalla del control TreeView
        TreeView2.EndUpdate()

        ' modifico la propiedad AllowDrop a True para poder realizar Drag and Drop
        TreeView2.AllowDrop = True

        ' modifico la propiedad Sorted a True para que los nodos estén ordenados
        TreeView2.Sorted = True
    End Sub

    Private Sub TreeView2_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView2.NodeMouseClick
        Dim loPSI As New ProcessStartInfo
        Dim loProceso As New Process

        Try
            'My.Computer.Network.DownloadFile(agendaftp & e.Node.Text, "C:\osiris\files\adjuntos_agenda\" & e.Node.Text, userftp_agenda, passftp_agenda, False, 500, True)
            If e.Node.Text <> "Ordenes médicas" Then
                Dim servidor As String = serverdb.Replace("""", "")
                Dim piStart As ProcessStartInfo =
                New ProcessStartInfo("Chrome.exe")
                Process.Start(piStart)
                piStart.Arguments = "http://" & servidor & "/foto/" & e.Node.Text
                Process.Start(piStart)

            End If
        Catch Exp As Exception
            'MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cargar_arbol_adjuntos()
        Dim nodo As TreeNode

        ' crear conexión
        Dim oConexion As New MySqlConnection
        oConexion.ConnectionString = "server=" & serverdb & ";database=" & db & ";user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""

        ' crear los DataAdapter
        Dim oDAAdjuntos As New MySqlDataAdapter("SELECT archivo from adjuntos WHERE idestudio=" & txtidestudio.Text, oConexion)

        ' crear conjunto de datos
        Dim oDataSet As New DataSet

        ' abrir la conexión
        oConexion.Open()

        ' utilizar los adaptadores para llenar el dataset con las tabla
        oDAAdjuntos.Fill(oDataSet, "adjuntos")

        ' cerrar la conexión
        oConexion.Close()

        ' defino variables del tipo DataTable
        Dim oTablaAdjuntos As DataTable

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaAdjuntos = oDataSet.Tables("adjuntos")

        ' deshabilita la actualización en pantalla del control TreeView 
        TreeView3.BeginUpdate()

        ' defino variable del tipo DataRow
        Dim Registro As DataRow

        ' creo un nodo raiz (el nombre Country, puede ser cualquier texto como Raíz, Root, etc.)
        nodo = TreeView3.Nodes.Add("Ordenes médicas")

        For Each Registro In oTablaAdjuntos.Rows
            ' agrego el nodo en el segundo nivel
            nodo = TreeView3.Nodes(0).Nodes.Add(Trim(Registro("archivo")))

            ' expando todos los nodos de árbol secundario
            nodo.ExpandAll()
        Next

        ' habilita la actualización en pantalla del control TreeView
        TreeView3.EndUpdate()

        ' modifico la propiedad AllowDrop a True para poder realizar Drag and Drop
        TreeView3.AllowDrop = True

        ' modifico la propiedad Sorted a True para que los nodos estén ordenados
        TreeView3.Sorted = True
    End Sub

    Private Sub TreeView3_NodeMouseClick_1(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView3.NodeMouseClick
        Dim loPSI As New ProcessStartInfo
        Dim loProceso As New Process

        Try
            'My.Computer.Network.DownloadFile(agendaftp & e.Node.Text, "C:\osiris\files\adjuntos_agenda\" & e.Node.Text, userftp_agenda, passftp_agenda, False, 500, True)
            If e.Node.Text <> "Ordenes médicas" Then
                Dim servidor As String = serverdb.Replace("""", "")
                loPSI.FileName = "Chrome.exe"
                loProceso = Process.Start(loPSI)
                loPSI.Arguments = "http://" & servidor & "/ordenesosiris/" & e.Node.Text
                loProceso = Process.Start(loPSI)

            End If
        Catch Exp As Exception
            'MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtdicom_TextChanged(sender As Object, e As EventArgs) Handles txtdicom.TextChanged
        If txtdicom.Text = "NO" Then
            btnimagen.Enabled = False
        Else
            btnimagen.Enabled = True
        End If
    End Sub

    Private Sub chkfirma_CheckedChanged(sender As Object, e As EventArgs) Handles chkfirma.CheckedChanged
        If chkfirma.Checked Then
            main_menu.lblfirma_informe.Text = "SI"
        Else
            main_menu.lblfirma_informe.Text = "NO"
        End If

        Dim id As Integer
        id = txtidestudio.Text
        visualizar_firma(id, main_menu.lblfirma_informe.Text)
    End Sub


    '*********************************** IMPRIMIR INFORME MEDICO SIN VISTA PREVIA ***********************************

    Dim medico As String
    Dim registro As String
    Dim especialidad As String
    Dim firma As String
    Dim alias_ As String

    Dim encabezado As String
    Dim centro As String
    Dim dir_centro As String
    Dim tel_centro As String
    Dim logo_cen As String

    Public flag As Integer

    Dim firmaInforme As String

    Private Sub consulta_med()
        Try
            consultar_usuario_id(Me.txtidmedico.Text)
            If dr.Read Then
                medico = dr(3)
                registro = dr(8)
                especialidad = dr(11)
                firma = dr(13)
                alias_ = dr(17)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub imprimirInforme()

        consulta_med()

        Try
            consultar_centro(txtidcentro.Text)
            If dr.Read Then
                centro = dr(1)
                dir_centro = dr(7)
                tel_centro = dr(3)
                logo_cen = dr(17)
                encabezado = dr(18)
            End If
        Catch ex As Exception

        End Try


        Dim objreporte As New informe_medico

        objreporte.SetParameterValue("cuerpo", Me.rtb1.Rtf)
        objreporte.SetParameterValue("cin", Me.lblci.Text)
        objreporte.SetParameterValue("edad", Me.lbledad.Text)
        objreporte.SetParameterValue("fecha", Me.lblfecha.Text)
        objreporte.SetParameterValue("estudio", Me.lblestudio.Text)
        objreporte.SetParameterValue("motivo", Me.lblmotivo.Text)
        objreporte.SetParameterValue("paciente", Me.lblpaciente.Text)
        objreporte.SetParameterValue("tecnico", Me.lbltecnico.Text)
        objreporte.SetParameterValue("fecha_informe", DateTime.Now.ToLongDateString)

        objreporte.SetParameterValue("estado", "")


        consultar_informe_estudio(Me.txtidestudio.Text, formulario)
        If dr.Read Then
            firmaInforme = dr(15)
        End If

        If firmaInforme = "SI" Then
            objreporte.SetParameterValue("firma", firma)
            objreporte.SetParameterValue("medico", medico)
            objreporte.SetParameterValue("registro", registro)
            objreporte.SetParameterValue("especialidad", especialidad)

        Else
            objreporte.SetParameterValue("firma", "")
            objreporte.SetParameterValue("medico", "")
            objreporte.SetParameterValue("registro", "")
            objreporte.SetParameterValue("especialidad", "")
        End If

        objreporte.SetParameterValue("alias_", alias_)

        If encabezado = "SI" Then
            objreporte.SetParameterValue("centro", centro)
            objreporte.SetParameterValue("dir_centro", dir_centro)
            objreporte.SetParameterValue("tel_centro", tel_centro)
            objreporte.SetParameterValue("logo_cen", logo_cen)
        Else
            objreporte.SetParameterValue("centro", "")
            objreporte.SetParameterValue("dir_centro", "")
            objreporte.SetParameterValue("tel_centro", "")
            objreporte.SetParameterValue("logo_cen", "")
        End If

        objreporte.SetParameterValue("doctor_solicitante", Me.lblmedicosolicitante.Text)
        objreporte.SetParameterValue("id", Me.txtidestudio.Text)


        'CrystalReportViewer1.ReportSource = objreporte

        Dim miReporte As New informe_medico

        miReporte.PrintToPrinter(1, False, 1, 1)

    End Sub
    '****************************************************************************************************************

    Private Sub btn_ayuda_Click(sender As Object, e As EventArgs) Handles btn_ayuda.Click
        consultar_ultimo_informe(txtidestudio.Text)
        If dr.Read Then
            txtidinforme.Text = dr(0)
        End If

        asistencia.txtidestudio.Text = Me.txtidestudio.Text
        asistencia.txtidinforme.Text = Me.txtidinforme.Text
        asistencia.txtidmedico.Text = Me.txtidmedico.Text


        asistencia.ShowDialog()
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        asignar_informe.txtidestudio = Me.txtidestudio
        asignar_informe.txtidinforme.Text = Me.txtidinforme.Text
        asignar_informe.txtpaciente.Text = Me.lblpaciente.Text
        asignar_informe.txtestudio.Text = Me.lblestudio.Text


        asignar_informe.ShowDialog()
    End Sub
End Class