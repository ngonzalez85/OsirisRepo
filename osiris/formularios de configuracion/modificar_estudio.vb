Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class modificar_estudio

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

    'conexion para bdpersona base de datos de cedulas paraguayas
    Dim cadConexion As String = "server=" & serverdb & ";database=bdpersona;user id=" & userdb & ";password=" & passdb & ";port=" & portdb & ""
    Dim connec As New MySqlConnection(cadConexion)
    Public cmd_ As New MySqlCommand
    Public dr_ As MySqlDataReader
    Dim formulario As String = "modificar_estudio"

    Public Sub conect()
        Try
            connec.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function disconect()
        Try
            If connec.State = ConnectionState.Open Then
                connec.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Counsulta de ci db persona
    Private Sub consultar_ci(ByRef cin As String)
        disconect()
        conect()

        cmd_.Connection = connec
        cmd_.CommandType = CommandType.Text

        cmd_.CommandText = "select * from persona where ced_num='" & cin & "' "

        Try
            dr_ = cmd_.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub modificar_estudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbModalidad.Items.Clear()
        cbCentro.Items.Clear()
        cbprioridad.Items.Clear()
        cbSeguros.Items.Clear()
        llenar_combobox_modalidades(cbModalidad, main_menu.txtidcentro.Text)
        'llenar_combobox_centros(cbCentro, main_menu.txtidcentro.Text)
        llenar_combobox_centrosXusuarios(cbCentro, main_menu.txtidusuario.Text)
        llenar_combobox_prioridades(cbprioridad)
        llenar_combobox_seguros(cbSeguros)
        abrir()
        autoCompletarTexbox(txtprocedimiento)

        buscarEstudio()
        buscarPaciente()
        buscarCentro()
        buscarModalidad()
        buscarSeguro()
        buscarPrioridad()
        buscarprocedimiento()
    End Sub

    Private Sub buscarEstudio()
        buscar_estudio(txtidestudio.Text)
        If dr.Read Then
            txtidcentro.Text = dr(1)
            txtidpaciente.Text = dr(3)
            txtidseguro.Text = dr(4)
            txtidmodalidad.Text = dr(5)
            txtidprioridad.Text = dr(6)
            txtidprocedimiento.Text = dr(8)
            txtmotivo.Text = dr(11)
            txtdoctor_solicitante.Text = dr(18)
            cbestado.Text = dr(10)
        End If
    End Sub

    Private Sub buscarPaciente()
        buscar_paciente(txtidpaciente.Text)
        If dr.Read Then
            txtci.Text = dr(1)
            txtedad.Text = dr(4)
            txtsexo.Text = dr(7)
            txtnombre.Text = dr(2)
            txtapellido.Text = dr(3)

        End If
    End Sub

    Private Sub buscarCentro()
        consultar_centro(txtidcentro.Text)
        If dr.Read Then
            cbCentro.Text = dr(1)
        End If
    End Sub

    Private Sub buscarModalidad()
        consultar_modalidad(main_menu.txtidcentro.Text, txtidmodalidad.Text)
        If dr.Read Then
            cbModalidad.Text = dr(2)
        End If
    End Sub

    Private Sub buscarSeguro()
        consultar_seguro(txtidseguro.Text)
        If dr.Read Then
            cbSeguros.Text = dr(1)
        End If
    End Sub

    Private Sub buscarPrioridad()
        consultar_prioridad_id(txtidprioridad.Text)
        If dr.Read Then
            cbprioridad.Text = dr(1)
        End If
    End Sub

    Private Sub buscarprocedimiento()
        consultar_procedimiento_id(txtidprocedimiento.Text)
        If dr.Read Then
            txtprocedimiento.Text = dr(1)
        End If
    End Sub

    Private Sub txtci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtci.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then

            If txtci.Text <> "" Then
                consultar_ci(txtci.Text)
                If dr_.Read Then

                    txtidpaciente.Clear()
                    txtnombre.Clear()
                    txtapellido.Clear()
                    txtedad.Clear()
                    txtsexo.Clear()
                    cbSeguros.Text = ("")


                    txtnombre.Text = dr_(3)
                    txtapellido.Text = dr_(2)

                    Dim fechaBD As String = dr_(4)


                    Dim fecha2 As Date = Date.Parse(fechaBD)
                        Dim fecha1 As Date = Now
                        Dim edad As Long = DateDiff(DateInterval.Year, fecha2, fecha1)
                        txtedad.Text = edad

                    Dim sigla_sexo As String = dr_(5)
                    If sigla_sexo = "M" Then
                        txtsexo.Text = "MASCULINO"
                    Else
                        txtsexo.Text = "FEMENINO"
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub cbCentro_TextChanged(sender As Object, e As EventArgs) Handles cbCentro.TextChanged
        If txtidcentro.Text <> "" Then
            If cbCentro.Text <> "" Then
                consultar_id_centro(cbCentro.Text)
                If dr.Read Then
                    txtidcentro.Text = dr(0)
                End If
            End If
        End If
    End Sub

    Private Sub cbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cbModalidad.TextChanged
        If cbModalidad.Text <> "" Then
            consultar_modalidadXcentro(main_menu.txtidcentro.Text, cbModalidad.Text)
            If dr.Read Then
                txtidmodalidad.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbSeguros_TextChanged(sender As Object, e As EventArgs) Handles cbSeguros.TextChanged
        If cbSeguros.Text <> "" Then
            consultar_id_seguro(cbSeguros.Text)
            If dr.Read Then
                txtidseguro.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub cbprioridad_TextChanged(sender As Object, e As EventArgs) Handles cbprioridad.TextChanged
        If cbprioridad.Text <> "" Then
            consultar_prioridad(cbprioridad.Text)
            If dr.Read Then
                txtidprioridad.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub txtprocedimiento_TextChanged(sender As Object, e As EventArgs) Handles txtprocedimiento.TextChanged
        If txtprocedimiento.Text <> "" Then
            consultar_procedimiento(txtprocedimiento.Text)
            If dr.Read Then
                txtidprocedimiento.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim idpaciente As Integer
        If txtci.Text <> "" And txtedad.Text <> "" And txtsexo.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtidcentro.Text <> "" And txtidmodalidad.Text <> "" And txtidseguro.Text <> "" And txtidprioridad.Text <> "" And txtidprocedimiento.Text <> "" And txtmotivo.Text <> "" And txtdoctor_solicitante.Text <> "" Then
            verificarPaciente()
            If txtidpaciente.Text = "" Then
                consultar_ultimo_paciente()
                If dr.Read Then
                    idpaciente = dr(0)
                End If
            Else
                idpaciente = txtidpaciente.Text
            End If

            modificarEstudio(txtidcentro.Text, idpaciente, txtidseguro.Text, txtidmodalidad.Text, txtidprioridad.Text, txtidprocedimiento.Text, txtmotivo.Text, txtdoctor_solicitante.Text, txtidestudio.Text, cbestado.Text)
            consultarInforme(txtidestudio.Text)
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    modificarInforme(txtidestudio.Text, txtidcentro.Text, txtci.Text, txtnombre.Text & " " & txtapellido.Text, txtedad.Text, txtprocedimiento.Text, txtmotivo.Text)
                End If
            End If

            MessageBox.Show("Datos modificados correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            envio.llenar_datagridview_estudios()
            Me.Close()
        Else
            MessageBox.Show("Todos los datos solicitados son obligatorios, por favor rellene los campos e intentelo de nuevo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub verificarPaciente()
        verificar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, txtsexo.Text)
        If dr.Read Then
            txtidpaciente.Text = dr(0)
            actualizar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, txtsexo.Text, txtidseguro.Text, txtidpaciente.Text)
        Else
            insertar_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtsexo.Text, txtidseguro.Text)
            id_paciente(txtci.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, txtsexo.Text)
            If dr.Read Then
                txtidpaciente.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtidestudio.Text <> "" Then
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea eliminar el estudio?. No se podrá revertir esta decisión", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                quitar_estudio(txtidestudio.Text)
                envio.llenar_datagridview_estudios()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class