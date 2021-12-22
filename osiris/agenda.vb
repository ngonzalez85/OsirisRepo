Imports MySql.Data.MySqlClient
Public Class agenda
    Dim sql_add As String
    Private Sub agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Recargar datos")
        Me.ToolTip1.IsBalloon = True
        'sincorinzar_un_minuto()
        ' Console.WriteLine(TabControl1.SelectedIndex)
        cbEstado.SelectedItem = cbEstado.Items(0)

        If cbEstado.Text = "PENDIENTES" Then
            sql_add = "AND idcita NOT IN (select idcita from bdisis.estudios)"
        Else
            sql_add = ""
        End If
    End Sub

    Dim Conexion3 As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub llenar_dgElectrocardiograma()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=1 AND fecha
                    BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            'consulta = "select * from agendavichito where idmodalidad=1 and fecha = '" & fecha & "'"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgElectrocardiograma.DataSource = datos
            dgElectrocardiograma.DataMember = "estudios"
            lblcant_electrocardiograma.Text = dgElectrocardiograma.Rows.Count
            retocar_columnas()
            colorear_filas()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgEco2()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=3 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEco2.DataSource = datos
            dgEco2.DataMember = "estudios"
            lblcant_eco2.Text = dgEco2.Rows.Count
            retocar_columnas_eco2()
            colorear_filas_eco2()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgEco3()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=4 and fecha  BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEco3.DataSource = datos
            dgEco3.DataMember = "estudios"
            lblcant_eco3.Text = dgEco3.Rows.Count
            retocar_columnas_eco3()
            colorear_filas_eco3()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgOrtopantomografia()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=5 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgOrtopantomografia.DataSource = datos
            dgOrtopantomografia.DataMember = "estudios"
            lblcant_ortopantomografia.Text = dgOrtopantomografia.Rows.Count
            retocar_columnas_ortopantomografia()
            colorear_filas_ortopantomografia()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgRayosx()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=6 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgRayosx.DataSource = datos
            dgRayosx.DataMember = "estudios"
            lblcant_rayosx.Text = dgRayosx.Rows.Count
            retocar_columnas_rayosx()
            colorear_filas_rayosx()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgResonancia()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=7 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgResonancia.DataSource = datos
            dgResonancia.DataMember = "estudios"
            lblcant_resonancia.Text = dgResonancia.Rows.Count
            retocar_columnas_resonancia()
            colorear_filas_resonancia()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgTomografia()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=8 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgTomografia.DataSource = datos
            dgTomografia.DataMember = "estudios"
            lblcant_tomografia.Text = dgTomografia.Rows.Count
            retocar_columnas_tomografia()
            colorear_filas_tomografia()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgElectromiografia()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=27 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgElectromiografia.DataSource = datos
            dgElectromiografia.DataMember = "estudios"
            lblcant_electromiografia.Text = dgElectromiografia.Rows.Count
            retocar_columnas_electromiografia()
            colorear_filas_electromiografia()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgEndoscopia()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=28 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgEndoscopia.DataSource = datos
            dgEndoscopia.DataMember = "estudios"
            lblcant_endoscopia.Text = dgEndoscopia.Rows.Count
            retocar_columnas_endoscopia()
            colorear_filas_endoscopia()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgElectroencefalograma()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database = " & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "Select * from agendaosiris where idmodalidad=29 And fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgElectroencefalograma.DataSource = datos
            dgElectroencefalograma.DataMember = "estudios"
            lblcant_electroencefalograma.Text = dgElectroencefalograma.Rows.Count
            retocar_columnas_electroencefalograma()
            colorear_filas_electroencefalograma()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgHelastograma()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=74 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgHelastograma.DataSource = datos
            dgHelastograma.DataMember = "estudios"
            lblcant_helastograma.Text = dgHelastograma.Rows.Count
            retocar_columnas_Helastograma()
            colorear_filas_Helastograma()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgLuriet()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=81 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgLuriet.DataSource = datos
            dgLuriet.DataMember = "estudios"
            lblcantLuriet.Text = dgLuriet.Rows.Count
            retocar_columnas_luriet()
            colorear_filas_luriet()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenar_dgHistero()
        Try
            Dim desde As String = txtdesde.Value.ToString("yyyy-MM-dd")
            Dim hasta As String = txthasta.Value.ToString("yyyy-MM-dd")
            Conexion3.ConnectionString = "server=" & serverdb_agenda & ";database=" & db_agenda & ";user id=" & userdb_agenda & ";password=" & passdb_agenda & ";port=" & portdb_agenda & ";Convert Zero Datetime=True"
            Dim consulta As String
            consulta = "select * from agendaosiris where idmodalidad=83 and fecha BETWEEN '" & desde & "' AND '" & hasta & "'" & sql_add & ""
            'consulta = "select * from agendavichito where idmodalidad=1 and fecha = '" & fecha & "'"
            adaptador = New MySqlDataAdapter(consulta, Conexion3)
            datos = New DataSet
            adaptador.Fill(datos, "estudios")
            dgHistero.DataSource = datos
            dgHistero.DataMember = "estudios"
            lblcantHistero.Text = dgHistero.Rows.Count
            retocar_columnas_hist()
            colorear_filas_histero()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas()
        Try
            Me.dgElectrocardiograma.Columns(0).Visible = False
            Me.dgElectrocardiograma.Columns(1).HeaderText = "ID"
            Me.dgElectrocardiograma.Columns(2).Visible = False
            Me.dgElectrocardiograma.Columns(3).Visible = False
            Me.dgElectrocardiograma.Columns(4).HeaderText = "FECHA"
            Me.dgElectrocardiograma.Columns(5).HeaderText = "HORA"
            Me.dgElectrocardiograma.Columns(6).HeaderText = "ESTADO"
            Me.dgElectrocardiograma.Columns(7).HeaderText = "NOMBRE"
            Me.dgElectrocardiograma.Columns(8).HeaderText = "APELLIDO"
            Me.dgElectrocardiograma.Columns(9).HeaderText = "CI"
            Me.dgElectrocardiograma.Columns(10).HeaderText = "CONCEPTO"
            Me.dgElectrocardiograma.Columns(11).HeaderText = "MODALIDAD"
            Me.dgElectrocardiograma.Columns(12).HeaderText = "SEXO"
            Me.dgElectrocardiograma.Columns(13).HeaderText = "EDAD"
            Me.dgElectrocardiograma.Columns(14).Visible = False
            Me.dgElectrocardiograma.Columns(15).Visible = False
            Me.dgElectrocardiograma.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgElectrocardiograma.Columns(17).HeaderText = "MOTIVO"
            Me.dgElectrocardiograma.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgElectrocardiograma.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgElectrocardiograma.Columns(20).Visible = False
            Me.dgElectrocardiograma.Columns(21).Visible = False
            Me.dgElectrocardiograma.Columns(22).Visible = False
            Me.dgElectrocardiograma.Columns(23).Visible = False
            Me.dgElectrocardiograma.Columns(24).Visible = False
            Me.dgElectrocardiograma.Columns(25).Visible = False
            Me.dgElectrocardiograma.Columns(26).Visible = False
            Me.dgElectrocardiograma.Columns(27).Visible = False
            Me.dgElectrocardiograma.Columns(28).Visible = False
            Me.dgElectrocardiograma.Columns(29).Visible = False

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_eco2()
        Try
            Me.dgEco2.Columns(0).Visible = False
            Me.dgEco2.Columns(1).HeaderText = "ID"
            Me.dgEco2.Columns(2).Visible = False
            Me.dgEco2.Columns(3).Visible = False
            Me.dgEco2.Columns(4).HeaderText = "FECHA"
            Me.dgEco2.Columns(5).HeaderText = "HORA"
            Me.dgEco2.Columns(6).HeaderText = "ESTADO"
            Me.dgEco2.Columns(7).HeaderText = "NOMBRE"
            Me.dgEco2.Columns(8).HeaderText = "APELLIDO"
            Me.dgEco2.Columns(9).HeaderText = "CI"
            Me.dgEco2.Columns(10).HeaderText = "CONCEPTO"
            Me.dgEco2.Columns(11).HeaderText = "MODALIDAD"
            Me.dgEco2.Columns(12).HeaderText = "SEXO"
            Me.dgEco2.Columns(13).HeaderText = "EDAD"
            Me.dgEco2.Columns(14).Visible = False
            Me.dgEco2.Columns(15).Visible = False
            Me.dgEco2.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgEco2.Columns(17).HeaderText = "MOTIVO"
            Me.dgEco2.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgEco2.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgEco2.Columns(20).Visible = False
            Me.dgEco2.Columns(21).Visible = False
            Me.dgEco2.Columns(22).Visible = False
            Me.dgEco2.Columns(23).Visible = False
            Me.dgEco2.Columns(24).Visible = False
            Me.dgEco2.Columns(25).Visible = False
            Me.dgEco2.Columns(26).Visible = False
            Me.dgEco2.Columns(27).Visible = False
            Me.dgEco2.Columns(28).Visible = False
            Me.dgEco2.Columns(29).Visible = False

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_eco3()
        Try
            Me.dgEco3.Columns(0).Visible = False
            Me.dgEco3.Columns(1).HeaderText = "ID"
            Me.dgEco3.Columns(2).Visible = False
            Me.dgEco3.Columns(3).Visible = False
            Me.dgEco3.Columns(4).HeaderText = "FECHA"
            Me.dgEco3.Columns(5).HeaderText = "HORA"
            Me.dgEco3.Columns(6).HeaderText = "ESTADO"
            Me.dgEco3.Columns(7).HeaderText = "NOMBRE"
            Me.dgEco3.Columns(8).HeaderText = "APELLIDO"
            Me.dgEco3.Columns(9).HeaderText = "CI"
            Me.dgEco3.Columns(10).HeaderText = "CONCEPTO"
            Me.dgEco3.Columns(11).HeaderText = "MODALIDAD"
            Me.dgEco3.Columns(12).HeaderText = "SEXO"
            Me.dgEco3.Columns(13).HeaderText = "EDAD"
            Me.dgEco3.Columns(14).Visible = False
            Me.dgEco3.Columns(15).Visible = False
            Me.dgEco3.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgEco3.Columns(17).HeaderText = "MOTIVO"
            Me.dgEco3.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgEco3.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgEco3.Columns(20).Visible = False
            Me.dgEco3.Columns(21).Visible = False
            Me.dgEco3.Columns(22).Visible = False
            Me.dgEco3.Columns(23).Visible = False
            Me.dgEco3.Columns(24).Visible = False
            Me.dgEco3.Columns(25).Visible = False
            Me.dgEco3.Columns(26).Visible = False
            Me.dgEco3.Columns(27).Visible = False
            Me.dgEco3.Columns(28).Visible = False
            Me.dgEco3.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_ortopantomografia()
        Try
            Me.dgOrtopantomografia.Columns(0).Visible = False
            Me.dgOrtopantomografia.Columns(1).HeaderText = "ID"
            Me.dgOrtopantomografia.Columns(2).Visible = False
            Me.dgOrtopantomografia.Columns(3).Visible = False
            Me.dgOrtopantomografia.Columns(4).HeaderText = "FECHA"
            Me.dgOrtopantomografia.Columns(5).HeaderText = "HORA"
            Me.dgOrtopantomografia.Columns(6).HeaderText = "ESTADO"
            Me.dgOrtopantomografia.Columns(7).HeaderText = "NOMBRE"
            Me.dgOrtopantomografia.Columns(8).HeaderText = "APELLIDO"
            Me.dgOrtopantomografia.Columns(9).HeaderText = "CI"
            Me.dgOrtopantomografia.Columns(10).HeaderText = "CONCEPTO"
            Me.dgOrtopantomografia.Columns(11).HeaderText = "MODALIDAD"
            Me.dgOrtopantomografia.Columns(12).HeaderText = "SEXO"
            Me.dgOrtopantomografia.Columns(13).HeaderText = "EDAD"
            Me.dgOrtopantomografia.Columns(14).Visible = False
            Me.dgOrtopantomografia.Columns(15).Visible = False
            Me.dgOrtopantomografia.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgOrtopantomografia.Columns(17).HeaderText = "MOTIVO"
            Me.dgOrtopantomografia.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgOrtopantomografia.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgOrtopantomografia.Columns(20).Visible = False
            Me.dgOrtopantomografia.Columns(21).Visible = False
            Me.dgOrtopantomografia.Columns(22).Visible = False
            Me.dgOrtopantomografia.Columns(23).Visible = False
            Me.dgOrtopantomografia.Columns(24).Visible = False
            Me.dgOrtopantomografia.Columns(25).Visible = False
            Me.dgOrtopantomografia.Columns(26).Visible = False
            Me.dgOrtopantomografia.Columns(27).Visible = False
            Me.dgOrtopantomografia.Columns(28).Visible = False
            Me.dgOrtopantomografia.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_rayosx()
        Try
            Me.dgRayosx.Columns(0).Visible = False
            Me.dgRayosx.Columns(1).HeaderText = "ID"
            Me.dgRayosx.Columns(2).Visible = False
            Me.dgRayosx.Columns(3).Visible = False
            Me.dgRayosx.Columns(4).HeaderText = "FECHA"
            Me.dgRayosx.Columns(5).HeaderText = "HORA"
            Me.dgRayosx.Columns(6).HeaderText = "ESTADO"
            Me.dgRayosx.Columns(7).HeaderText = "NOMBRE"
            Me.dgRayosx.Columns(8).HeaderText = "APELLIDO"
            Me.dgRayosx.Columns(9).HeaderText = "CI"
            Me.dgRayosx.Columns(10).HeaderText = "CONCEPTO"
            Me.dgRayosx.Columns(11).HeaderText = "MODALIDAD"
            Me.dgRayosx.Columns(12).HeaderText = "SEXO"
            Me.dgRayosx.Columns(13).HeaderText = "EDAD"
            Me.dgRayosx.Columns(14).Visible = False
            Me.dgRayosx.Columns(15).Visible = False
            Me.dgRayosx.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgRayosx.Columns(17).HeaderText = "MOTIVO"
            Me.dgRayosx.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgRayosx.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgRayosx.Columns(20).Visible = False
            Me.dgRayosx.Columns(21).Visible = False
            Me.dgRayosx.Columns(22).Visible = False
            Me.dgRayosx.Columns(23).Visible = False
            Me.dgRayosx.Columns(24).Visible = False
            Me.dgRayosx.Columns(25).Visible = False
            Me.dgRayosx.Columns(26).Visible = False
            Me.dgRayosx.Columns(27).Visible = False
            Me.dgRayosx.Columns(26).Visible = False
            Me.dgRayosx.Columns(27).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_resonancia()
        Try
            Me.dgResonancia.Columns(0).Visible = False
            Me.dgResonancia.Columns(1).HeaderText = "ID"
            Me.dgResonancia.Columns(2).Visible = False
            Me.dgResonancia.Columns(3).Visible = False
            Me.dgResonancia.Columns(4).HeaderText = "FECHA"
            Me.dgResonancia.Columns(5).HeaderText = "HORA"
            Me.dgResonancia.Columns(6).HeaderText = "ESTADO"
            Me.dgResonancia.Columns(7).HeaderText = "NOMBRE"
            Me.dgResonancia.Columns(8).HeaderText = "APELLIDO"
            Me.dgResonancia.Columns(9).HeaderText = "CI"
            Me.dgResonancia.Columns(10).HeaderText = "CONCEPTO"
            Me.dgResonancia.Columns(11).HeaderText = "MODALIDAD"
            Me.dgResonancia.Columns(12).HeaderText = "SEXO"
            Me.dgResonancia.Columns(13).HeaderText = "EDAD"
            Me.dgResonancia.Columns(14).Visible = False
            Me.dgResonancia.Columns(15).Visible = False
            Me.dgResonancia.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgResonancia.Columns(17).HeaderText = "MOTIVO"
            Me.dgResonancia.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgResonancia.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgResonancia.Columns(20).Visible = False
            Me.dgResonancia.Columns(21).Visible = False
            Me.dgResonancia.Columns(22).Visible = False
            Me.dgResonancia.Columns(23).Visible = False
            Me.dgResonancia.Columns(24).Visible = False
            Me.dgResonancia.Columns(25).Visible = False
            Me.dgResonancia.Columns(26).Visible = False
            Me.dgResonancia.Columns(27).Visible = False
            Me.dgResonancia.Columns(28).Visible = False
            Me.dgResonancia.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_tomografia()
        Try
            Me.dgTomografia.Columns(0).Visible = False
            Me.dgTomografia.Columns(1).HeaderText = "ID"
            Me.dgTomografia.Columns(2).Visible = False
            Me.dgTomografia.Columns(3).Visible = False
            Me.dgTomografia.Columns(4).HeaderText = "FECHA"
            Me.dgTomografia.Columns(5).HeaderText = "HORA"
            Me.dgTomografia.Columns(6).HeaderText = "ESTADO"
            Me.dgTomografia.Columns(7).HeaderText = "NOMBRE"
            Me.dgTomografia.Columns(8).HeaderText = "APELLIDO"
            Me.dgTomografia.Columns(9).HeaderText = "CI"
            Me.dgTomografia.Columns(10).HeaderText = "CONCEPTO"
            Me.dgTomografia.Columns(11).HeaderText = "MODALIDAD"
            Me.dgTomografia.Columns(12).HeaderText = "SEXO"
            Me.dgTomografia.Columns(13).HeaderText = "EDAD"
            Me.dgTomografia.Columns(14).Visible = False
            Me.dgTomografia.Columns(15).Visible = False
            Me.dgTomografia.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgTomografia.Columns(17).HeaderText = "MOTIVO"
            Me.dgTomografia.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgTomografia.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgTomografia.Columns(20).Visible = False
            Me.dgTomografia.Columns(21).Visible = False
            Me.dgTomografia.Columns(22).Visible = False
            Me.dgTomografia.Columns(23).Visible = False
            Me.dgTomografia.Columns(24).Visible = False
            Me.dgTomografia.Columns(25).Visible = False
            Me.dgTomografia.Columns(26).Visible = False
            Me.dgTomografia.Columns(27).Visible = False
            Me.dgTomografia.Columns(28).Visible = False
            Me.dgTomografia.Columns(29).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_electromiografia()
        Try
            Me.dgElectromiografia.Columns(0).Visible = False
            Me.dgElectromiografia.Columns(1).HeaderText = "ID"
            Me.dgElectromiografia.Columns(2).Visible = False
            Me.dgElectromiografia.Columns(3).Visible = False
            Me.dgElectromiografia.Columns(4).HeaderText = "FECHA"
            Me.dgElectromiografia.Columns(5).HeaderText = "HORA"
            Me.dgElectromiografia.Columns(6).HeaderText = "ESTADO"
            Me.dgElectromiografia.Columns(7).HeaderText = "NOMBRE"
            Me.dgElectromiografia.Columns(8).HeaderText = "APELLIDO"
            Me.dgElectromiografia.Columns(9).HeaderText = "CI"
            Me.dgElectromiografia.Columns(10).HeaderText = "CONCEPTO"
            Me.dgElectromiografia.Columns(11).HeaderText = "MODALIDAD"
            Me.dgElectromiografia.Columns(12).HeaderText = "SEXO"
            Me.dgElectromiografia.Columns(13).HeaderText = "EDAD"
            Me.dgElectromiografia.Columns(14).Visible = False
            Me.dgElectromiografia.Columns(15).Visible = False
            Me.dgElectromiografia.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgElectromiografia.Columns(17).HeaderText = "MOTIVO"
            Me.dgElectromiografia.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgElectromiografia.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgElectromiografia.Columns(20).Visible = False
            Me.dgElectromiografia.Columns(21).Visible = False
            Me.dgElectromiografia.Columns(22).Visible = False
            Me.dgElectromiografia.Columns(23).Visible = False
            Me.dgElectromiografia.Columns(24).Visible = False
            Me.dgElectromiografia.Columns(25).Visible = False
            Me.dgElectromiografia.Columns(26).Visible = False
            Me.dgElectromiografia.Columns(27).Visible = False
            Me.dgElectromiografia.Columns(28).Visible = False
            Me.dgElectromiografia.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_endoscopia()
        Try
            Me.dgEndoscopia.Columns(0).Visible = False
            Me.dgEndoscopia.Columns(1).HeaderText = "ID"
            Me.dgEndoscopia.Columns(2).Visible = False
            Me.dgEndoscopia.Columns(3).Visible = False
            Me.dgEndoscopia.Columns(4).HeaderText = "FECHA"
            Me.dgEndoscopia.Columns(5).HeaderText = "HORA"
            Me.dgEndoscopia.Columns(6).HeaderText = "ESTADO"
            Me.dgEndoscopia.Columns(7).HeaderText = "NOMBRE"
            Me.dgEndoscopia.Columns(8).HeaderText = "APELLIDO"
            Me.dgEndoscopia.Columns(9).HeaderText = "CI"
            Me.dgEndoscopia.Columns(10).HeaderText = "CONCEPTO"
            Me.dgEndoscopia.Columns(11).HeaderText = "MODALIDAD"
            Me.dgEndoscopia.Columns(12).HeaderText = "SEXO"
            Me.dgEndoscopia.Columns(13).HeaderText = "EDAD"
            Me.dgEndoscopia.Columns(14).Visible = False
            Me.dgEndoscopia.Columns(15).Visible = False
            Me.dgEndoscopia.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgEndoscopia.Columns(17).HeaderText = "MOTIVO"
            Me.dgEndoscopia.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgEndoscopia.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgEndoscopia.Columns(20).Visible = False
            Me.dgEndoscopia.Columns(21).Visible = False
            Me.dgEndoscopia.Columns(22).Visible = False
            Me.dgEndoscopia.Columns(23).Visible = False
            Me.dgEndoscopia.Columns(24).Visible = False
            Me.dgEndoscopia.Columns(25).Visible = False
            Me.dgEndoscopia.Columns(26).Visible = False
            Me.dgEndoscopia.Columns(27).Visible = False
            Me.dgEndoscopia.Columns(28).Visible = False
            Me.dgEndoscopia.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_electroencefalograma()
        Try
            Me.dgElectroencefalograma.Columns(0).Visible = False
            Me.dgElectroencefalograma.Columns(1).HeaderText = "ID"
            Me.dgElectroencefalograma.Columns(2).Visible = False
            Me.dgElectroencefalograma.Columns(3).Visible = False
            Me.dgElectroencefalograma.Columns(4).HeaderText = "FECHA"
            Me.dgElectroencefalograma.Columns(5).HeaderText = "HORA"
            Me.dgElectroencefalograma.Columns(6).HeaderText = "ESTADO"
            Me.dgElectroencefalograma.Columns(7).HeaderText = "NOMBRE"
            Me.dgElectroencefalograma.Columns(8).HeaderText = "APELLIDO"
            Me.dgElectroencefalograma.Columns(9).HeaderText = "CI"
            Me.dgElectroencefalograma.Columns(10).HeaderText = "CONCEPTO"
            Me.dgElectroencefalograma.Columns(11).HeaderText = "MODALIDAD"
            Me.dgElectroencefalograma.Columns(12).HeaderText = "SEXO"
            Me.dgElectroencefalograma.Columns(13).HeaderText = "EDAD"
            Me.dgElectroencefalograma.Columns(14).Visible = False
            Me.dgElectroencefalograma.Columns(15).Visible = False
            Me.dgElectroencefalograma.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgElectroencefalograma.Columns(17).HeaderText = "MOTIVO"
            Me.dgElectroencefalograma.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgElectroencefalograma.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgElectroencefalograma.Columns(20).Visible = False
            Me.dgElectroencefalograma.Columns(21).Visible = False
            Me.dgElectroencefalograma.Columns(22).Visible = False
            Me.dgElectroencefalograma.Columns(23).Visible = False
            Me.dgElectroencefalograma.Columns(24).Visible = False
            Me.dgElectroencefalograma.Columns(25).Visible = False
            Me.dgElectroencefalograma.Columns(26).Visible = False
            Me.dgElectroencefalograma.Columns(27).Visible = False
            Me.dgElectroencefalograma.Columns(28).Visible = False
            Me.dgElectroencefalograma.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_helastograma()
        Try
            Me.dgHelastograma.Columns(0).Visible = False
            Me.dgHelastograma.Columns(1).HeaderText = "ID"
            Me.dgHelastograma.Columns(2).Visible = False
            Me.dgHelastograma.Columns(3).Visible = False
            Me.dgHelastograma.Columns(4).HeaderText = "FECHA"
            Me.dgHelastograma.Columns(5).HeaderText = "HORA"
            Me.dgHelastograma.Columns(6).HeaderText = "ESTADO"
            Me.dgHelastograma.Columns(7).HeaderText = "NOMBRE"
            Me.dgHelastograma.Columns(8).HeaderText = "APELLIDO"
            Me.dgHelastograma.Columns(9).HeaderText = "CI"
            Me.dgHelastograma.Columns(10).HeaderText = "CONCEPTO"
            Me.dgHelastograma.Columns(11).HeaderText = "MODALIDAD"
            Me.dgHelastograma.Columns(12).HeaderText = "SEXO"
            Me.dgHelastograma.Columns(13).HeaderText = "EDAD"
            Me.dgHelastograma.Columns(14).Visible = False
            Me.dgHelastograma.Columns(15).Visible = False
            Me.dgHelastograma.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgHelastograma.Columns(17).HeaderText = "MOTIVO"
            Me.dgHelastograma.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgHelastograma.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgHelastograma.Columns(20).Visible = False
            Me.dgHelastograma.Columns(21).Visible = False
            Me.dgHelastograma.Columns(22).Visible = False
            Me.dgHelastograma.Columns(23).Visible = False
            Me.dgHelastograma.Columns(24).Visible = False
            Me.dgHelastograma.Columns(25).Visible = False
            Me.dgHelastograma.Columns(26).Visible = False
            Me.dgHelastograma.Columns(27).Visible = False
            Me.dgHelastograma.Columns(28).Visible = False
            Me.dgHelastograma.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_luriet()
        Try
            Me.dgLuriet.Columns(0).Visible = False
            Me.dgLuriet.Columns(1).HeaderText = "ID"
            Me.dgLuriet.Columns(2).Visible = False
            Me.dgLuriet.Columns(3).Visible = False
            Me.dgLuriet.Columns(4).HeaderText = "FECHA"
            Me.dgLuriet.Columns(5).HeaderText = "HORA"
            Me.dgLuriet.Columns(6).HeaderText = "ESTADO"
            Me.dgLuriet.Columns(7).HeaderText = "NOMBRE"
            Me.dgLuriet.Columns(8).HeaderText = "APELLIDO"
            Me.dgLuriet.Columns(9).HeaderText = "CI"
            Me.dgLuriet.Columns(10).HeaderText = "CONCEPTO"
            Me.dgLuriet.Columns(11).HeaderText = "MODALIDAD"
            Me.dgLuriet.Columns(12).HeaderText = "SEXO"
            Me.dgLuriet.Columns(13).HeaderText = "EDAD"
            Me.dgLuriet.Columns(14).Visible = False
            Me.dgLuriet.Columns(15).Visible = False
            Me.dgLuriet.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgLuriet.Columns(17).HeaderText = "MOTIVO"
            Me.dgLuriet.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgLuriet.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgLuriet.Columns(20).Visible = False
            Me.dgLuriet.Columns(21).Visible = False
            Me.dgLuriet.Columns(22).Visible = False
            Me.dgLuriet.Columns(23).Visible = False
            Me.dgLuriet.Columns(24).Visible = False
            Me.dgLuriet.Columns(25).Visible = False
            Me.dgLuriet.Columns(26).Visible = False
            Me.dgLuriet.Columns(27).Visible = False
            Me.dgLuriet.Columns(28).Visible = False
            Me.dgLuriet.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub retocar_columnas_hist()
        Try
            Me.dgHistero.Columns(0).Visible = False
            Me.dgHistero.Columns(1).HeaderText = "ID"
            Me.dgHistero.Columns(2).Visible = False
            Me.dgHistero.Columns(3).Visible = False
            Me.dgHistero.Columns(4).HeaderText = "FECHA"
            Me.dgHistero.Columns(5).HeaderText = "HORA"
            Me.dgHistero.Columns(6).HeaderText = "ESTADO"
            Me.dgHistero.Columns(7).HeaderText = "NOMBRE"
            Me.dgHistero.Columns(8).HeaderText = "APELLIDO"
            Me.dgHistero.Columns(9).HeaderText = "CI"
            Me.dgHistero.Columns(10).HeaderText = "CONCEPTO"
            Me.dgHistero.Columns(11).HeaderText = "MODALIDAD"
            Me.dgHistero.Columns(12).HeaderText = "SEXO"
            Me.dgHistero.Columns(13).HeaderText = "EDAD"
            Me.dgHistero.Columns(14).Visible = False
            Me.dgHistero.Columns(15).Visible = False
            Me.dgHistero.Columns(16).HeaderText = "MED. SOLIC."
            Me.dgHistero.Columns(17).HeaderText = "MOTIVO"
            Me.dgHistero.Columns(18).HeaderText = "F. ENTREGA"
            Me.dgHistero.Columns(19).HeaderText = "H.ENTREGA"
            Me.dgHistero.Columns(20).Visible = False
            Me.dgHistero.Columns(21).Visible = False
            Me.dgHistero.Columns(22).Visible = False
            Me.dgHistero.Columns(23).Visible = False
            Me.dgHistero.Columns(24).Visible = False
            Me.dgHistero.Columns(25).Visible = False
            Me.dgHistero.Columns(26).Visible = False
            Me.dgHistero.Columns(27).Visible = False
            Me.dgHistero.Columns(28).Visible = False
            Me.dgHistero.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub colorear_filas()
        For Each r As DataGridViewRow In dgElectrocardiograma.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_eco2()
        For Each r As DataGridViewRow In dgEco2.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_eco3()
        For Each r As DataGridViewRow In dgEco3.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_ortopantomografia()
        For Each r As DataGridViewRow In dgOrtopantomografia.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_rayosx()
        For Each r As DataGridViewRow In dgRayosx.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_resonancia()
        For Each r As DataGridViewRow In dgResonancia.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_tomografia()
        For Each r As DataGridViewRow In dgTomografia.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_electromiografia()
        For Each r As DataGridViewRow In dgElectromiografia.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_endoscopia()
        For Each r As DataGridViewRow In dgEndoscopia.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_electroencefalograma()
        For Each r As DataGridViewRow In dgElectroencefalograma.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_helastograma()
        For Each r As DataGridViewRow In dgHelastograma.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_luriet()
        For Each r As DataGridViewRow In dgHistero.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub colorear_filas_histero()
        For Each r As DataGridViewRow In dgHistero.Rows
            If r.Cells("URGENTE").Value = 1 Then
                r.DefaultCellStyle.BackColor = Color.Red
                r.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub txtfecha_ValueChanged(sender As Object, e As EventArgs)
        'llenar_dgElectrocardiograma()
        'llenar_dgEco2()
        'llenar_dgEco3()
        'llenar_dgOrtopantomografia()
        'llenar_dgRayosx()
        'llenar_dgResonancia()
        'llenar_dgTomografia()
        'llenar_dgElectromiografia()
        'llenar_dgEndoscopia()
        'llenar_dgElectroencefalograma()
        'llenar_dgHelastograma()
        'llenar_dgLuriet()
        'llenar_dgHistero()
        actualizarEstudios()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub sincorinzar_un_minuto()
        llenar_dgElectrocardiograma()
        llenar_dgEco2()
        llenar_dgEco3()
        llenar_dgOrtopantomografia()
        llenar_dgRayosx()
        llenar_dgResonancia()
        llenar_dgTomografia()
        llenar_dgElectromiografia()
        llenar_dgEndoscopia()
        llenar_dgElectroencefalograma()
        llenar_dgHelastograma()
        llenar_dgLuriet()
        llenar_dgHistero()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '   sincorinzar_un_minuto()

        actualizarEstudios()
    End Sub

    Private Sub dgElectrocardiograma_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgElectrocardiograma.CellDoubleClick
        If dgElectrocardiograma.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgElectrocardiograma.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgElectrocardiograma.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgElectrocardiograma.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgElectrocardiograma.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgElectrocardiograma.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgElectrocardiograma.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgElectrocardiograma.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgElectrocardiograma.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgElectrocardiograma.SelectedCells.Item(14).Value

            If dgElectrocardiograma.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgElectrocardiograma.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgElectrocardiograma.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgElectrocardiograma.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgElectrocardiograma.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgElectrocardiograma.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgEco2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEco2.CellDoubleClick
        If dgEco2.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgEco2.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgEco2.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgEco2.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgEco2.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgEco2.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgEco2.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgEco2.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgEco2.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgEco2.SelectedCells.Item(14).Value

            If dgEco2.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgEco2.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgEco2.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgEco2.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgEco2.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgEco2.SelectedCells.Item(19).Value.ToString
            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgEco3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEco3.CellDoubleClick
        If dgEco3.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgEco3.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgEco3.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgEco3.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgEco3.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgEco3.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgEco3.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgEco3.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgEco3.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgEco3.SelectedCells.Item(14).Value

            If dgEco3.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgEco3.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgEco3.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgEco3.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgEco3.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgEco3.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgOrtopantomografia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrtopantomografia.CellDoubleClick
        If dgOrtopantomografia.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgOrtopantomografia.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgOrtopantomografia.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgOrtopantomografia.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgOrtopantomografia.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgOrtopantomografia.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgOrtopantomografia.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgOrtopantomografia.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgOrtopantomografia.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgOrtopantomografia.SelectedCells.Item(14).Value

            If dgOrtopantomografia.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgOrtopantomografia.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgOrtopantomografia.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgOrtopantomografia.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgOrtopantomografia.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgOrtopantomografia.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgRayosx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRayosx.CellDoubleClick
        If dgRayosx.Rows.Count > 0 Then
            envio_agenda_imagenes.txtcidoctor.Text = dgRayosx.SelectedCells.Item(0).Value
            envio_agenda_imagenes.txtidcita.Text = dgRayosx.SelectedCells.Item(1).Value
            envio_agenda_imagenes.txtidprocedimiento.Text = dgRayosx.SelectedCells.Item(3).Value
            envio_agenda_imagenes.txtnombre.Text = dgRayosx.SelectedCells.Item(7).Value
            envio_agenda_imagenes.txtapellido.Text = dgRayosx.SelectedCells.Item(8).Value
            envio_agenda_imagenes.txtci.Text = dgRayosx.SelectedCells.Item(9).Value
            envio_agenda_imagenes.txtsexo.Text = dgRayosx.SelectedCells.Item(12).Value
            envio_agenda_imagenes.txtedad.Text = dgRayosx.SelectedCells.Item(13).Value
            envio_agenda_imagenes.txtidmodalidad_rispy.Text = dgRayosx.SelectedCells.Item(14).Value

            If dgRayosx.SelectedCells.Item(15).Value = 1 Then
                envio_agenda_imagenes.txtprioridad.Text = "URGENCIAS"
                envio_agenda_imagenes.txtidprioridad.Text = 3
            Else
                envio_agenda_imagenes.txtprioridad.Text = "NORMAL"
                envio_agenda_imagenes.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgRayosx.SelectedCells.Item(16).Value) Then
                envio_agenda_imagenes.txtdoctor_solicitante.Text = dgRayosx.SelectedCells.Item(16).Value
            Else
                envio_agenda_imagenes.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda_imagenes.txtmotivo.Text = dgRayosx.SelectedCells.Item(17).Value
            envio_agenda_imagenes.txtfecha_entrega.Text = dgRayosx.SelectedCells.Item(18).Value.ToString
            envio_agenda_imagenes.txthora_entrega.Text = dgRayosx.SelectedCells.Item(19).Value.ToString


            envio_agenda_imagenes.ShowDialog()
        End If
    End Sub

    Private Sub dgResonancia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResonancia.CellDoubleClick
        If dgResonancia.Rows.Count > 0 Then
            envio_agenda_imagenes.txtcidoctor.Text = dgResonancia.SelectedCells.Item(0).Value
            envio_agenda_imagenes.txtidcita.Text = dgResonancia.SelectedCells.Item(1).Value
            envio_agenda_imagenes.txtidprocedimiento.Text = dgResonancia.SelectedCells.Item(3).Value
            envio_agenda_imagenes.txtnombre.Text = dgResonancia.SelectedCells.Item(7).Value
            envio_agenda_imagenes.txtapellido.Text = dgResonancia.SelectedCells.Item(8).Value
            envio_agenda_imagenes.txtci.Text = dgResonancia.SelectedCells.Item(9).Value
            envio_agenda_imagenes.txtsexo.Text = dgResonancia.SelectedCells.Item(12).Value
            envio_agenda_imagenes.txtedad.Text = dgResonancia.SelectedCells.Item(13).Value
            envio_agenda_imagenes.txtidmodalidad_rispy.Text = dgResonancia.SelectedCells.Item(14).Value

            If dgResonancia.SelectedCells.Item(15).Value = 1 Then
                envio_agenda_imagenes.txtprioridad.Text = "URGENCIAS"
                envio_agenda_imagenes.txtidprioridad.Text = 3
            Else
                envio_agenda_imagenes.txtprioridad.Text = "NORMAL"
                envio_agenda_imagenes.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgResonancia.SelectedCells.Item(16).Value) Then
                envio_agenda_imagenes.txtdoctor_solicitante.Text = dgResonancia.SelectedCells.Item(16).Value
            Else
                envio_agenda_imagenes.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda_imagenes.txtmotivo.Text = dgResonancia.SelectedCells.Item(17).Value
            envio_agenda_imagenes.txtfecha_entrega.Text = dgResonancia.SelectedCells.Item(18).Value.ToString
            envio_agenda_imagenes.txthora_entrega.Text = dgResonancia.SelectedCells.Item(19).Value.ToString

            envio_agenda_imagenes.ShowDialog()
        End If
    End Sub

    Private Sub dgTomografia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTomografia.CellDoubleClick
        If dgTomografia.Rows.Count > 0 Then
            envio_agenda_imagenes.txtcidoctor.Text = dgTomografia.SelectedCells.Item(0).Value
            envio_agenda_imagenes.txtidcita.Text = dgTomografia.SelectedCells.Item(1).Value
            envio_agenda_imagenes.txtidprocedimiento.Text = dgTomografia.SelectedCells.Item(3).Value
            envio_agenda_imagenes.txtnombre.Text = dgTomografia.SelectedCells.Item(7).Value
            envio_agenda_imagenes.txtapellido.Text = dgTomografia.SelectedCells.Item(8).Value
            envio_agenda_imagenes.txtci.Text = dgTomografia.SelectedCells.Item(9).Value
            envio_agenda_imagenes.txtsexo.Text = dgTomografia.SelectedCells.Item(12).Value
            envio_agenda_imagenes.txtedad.Text = dgTomografia.SelectedCells.Item(13).Value
            envio_agenda_imagenes.txtidmodalidad_rispy.Text = dgTomografia.SelectedCells.Item(14).Value

            If dgTomografia.SelectedCells.Item(15).Value = 1 Then
                envio_agenda_imagenes.txtprioridad.Text = "URGENCIAS"
                envio_agenda_imagenes.txtidprioridad.Text = 3
            Else
                envio_agenda_imagenes.txtprioridad.Text = "NORMAL"
                envio_agenda_imagenes.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgTomografia.SelectedCells.Item(16).Value) Then
                envio_agenda_imagenes.txtdoctor_solicitante.Text = dgTomografia.SelectedCells.Item(16).Value
            Else
                envio_agenda_imagenes.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda_imagenes.txtmotivo.Text = dgTomografia.SelectedCells.Item(17).Value
            envio_agenda_imagenes.txtfecha_entrega.Text = dgTomografia.SelectedCells.Item(18).Value.ToString
            envio_agenda_imagenes.txthora_entrega.Text = dgTomografia.SelectedCells.Item(19).Value.ToString

            envio_agenda_imagenes.ShowDialog()
        End If
    End Sub

    Private Sub dgElectromiografia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgElectromiografia.CellDoubleClick
        If dgElectromiografia.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgElectromiografia.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgElectromiografia.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgElectromiografia.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgElectromiografia.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgElectromiografia.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgElectromiografia.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgElectromiografia.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgElectromiografia.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgElectromiografia.SelectedCells.Item(14).Value

            If dgElectromiografia.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgElectromiografia.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgElectromiografia.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgElectromiografia.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgElectromiografia.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgElectromiografia.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgEndoscopia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEndoscopia.CellDoubleClick
        If dgEndoscopia.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgEndoscopia.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgEndoscopia.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgEndoscopia.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgEndoscopia.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgEndoscopia.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgEndoscopia.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgEndoscopia.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgEndoscopia.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgEndoscopia.SelectedCells.Item(14).Value

            If dgEndoscopia.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgEndoscopia.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgEndoscopia.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgEndoscopia.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgEndoscopia.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgEndoscopia.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgElectroencefalograma_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgElectroencefalograma.CellDoubleClick
        If dgElectroencefalograma.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgElectroencefalograma.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgElectroencefalograma.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgElectroencefalograma.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgElectroencefalograma.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgElectroencefalograma.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgElectroencefalograma.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgElectroencefalograma.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgElectroencefalograma.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgElectroencefalograma.SelectedCells.Item(14).Value

            If dgElectroencefalograma.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgElectroencefalograma.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgElectroencefalograma.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgElectroencefalograma.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgElectroencefalograma.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgElectroencefalograma.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub cbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbEstado.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbEstado_TextChanged(sender As Object, e As EventArgs) Handles cbEstado.TextChanged
        If cbEstado.Text = "PENDIENTES" Then
            sql_add = "AND idcita NOT IN (select idcita from bdisis.estudios)"
        Else
            sql_add = ""
        End If
        'llenar_dgElectrocardiograma()
        'llenar_dgEco2()
        'llenar_dgEco3()
        'llenar_dgOrtopantomografia()
        'llenar_dgRayosx()
        'llenar_dgResonancia()
        'llenar_dgTomografia()
        'llenar_dgElectromiografia()
        'llenar_dgEndoscopia()
        'llenar_dgElectroencefalograma()
        'llenar_dgHelastograma()
        'llenar_dgLuriet()
        actualizarEstudios()
    End Sub

    Private Sub dgHelastograma_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHelastograma.CellDoubleClick
        If dgHelastograma.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgHelastograma.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgHelastograma.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgHelastograma.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgHelastograma.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgHelastograma.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgHelastograma.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgHelastograma.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgHelastograma.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgHelastograma.SelectedCells.Item(14).Value

            If dgHelastograma.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgHelastograma.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgHelastograma.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgHelastograma.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgHelastograma.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgHelastograma.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If cbEstado.Text = "PENDIENTES" Then
            sql_add = "AND idcita NOT IN (select idcita from bdisis.estudios)"
        Else
            sql_add = ""
        End If
        actualizarEstudios()
        'llenar_dgElectrocardiograma()
        'llenar_dgEco2()
        'llenar_dgEco3()
        'llenar_dgOrtopantomografia()
        'llenar_dgRayosx()
        'llenar_dgResonancia()
        'llenar_dgTomografia()
        'llenar_dgElectromiografia()
        'llenar_dgEndoscopia()
        'llenar_dgElectroencefalograma()
        'llenar_dgHelastograma()
        'llenar_dgLuriet()
        'llenar_dgHistero()
    End Sub

    Private Sub dgLuriet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLuriet.CellDoubleClick
        If dgLuriet.Rows.Count > 0 Then
            envio_agenda.txtcidoctor.Text = dgLuriet.SelectedCells.Item(0).Value
            envio_agenda.txtidcita.Text = dgLuriet.SelectedCells.Item(1).Value
            envio_agenda.txtidprocedimiento.Text = dgLuriet.SelectedCells.Item(3).Value
            envio_agenda.txtnombre.Text = dgLuriet.SelectedCells.Item(7).Value
            envio_agenda.txtapellido.Text = dgLuriet.SelectedCells.Item(8).Value
            envio_agenda.txtci.Text = dgLuriet.SelectedCells.Item(9).Value
            envio_agenda.txtsexo.Text = dgLuriet.SelectedCells.Item(12).Value
            envio_agenda.txtedad.Text = dgLuriet.SelectedCells.Item(13).Value
            envio_agenda.txtidmodalidad_rispy.Text = dgLuriet.SelectedCells.Item(14).Value

            If dgLuriet.SelectedCells.Item(15).Value = 1 Then
                envio_agenda.txtprioridad.Text = "URGENCIAS"
                envio_agenda.txtidprioridad.Text = 3
            Else
                envio_agenda.txtprioridad.Text = "NORMAL"
                envio_agenda.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgLuriet.SelectedCells.Item(16).Value) Then
                envio_agenda.txtdoctor_solicitante.Text = dgLuriet.SelectedCells.Item(16).Value
            Else
                envio_agenda.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda.txtmotivo.Text = dgLuriet.SelectedCells.Item(17).Value
            envio_agenda.txtfecha_entrega.Text = dgLuriet.SelectedCells.Item(18).Value.ToString
            envio_agenda.txthora_entrega.Text = dgLuriet.SelectedCells.Item(19).Value.ToString

            envio_agenda.ShowDialog()
        End If
    End Sub

    Private Sub dgHistero_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHistero.CellDoubleClick
        If dgHistero.Rows.Count > 0 Then
            envio_agenda_imagenes.txtcidoctor.Text = dgHistero.SelectedCells.Item(0).Value
            envio_agenda_imagenes.txtidcita.Text = dgHistero.SelectedCells.Item(1).Value
            envio_agenda_imagenes.txtidprocedimiento.Text = dgHistero.SelectedCells.Item(3).Value
            envio_agenda_imagenes.txtnombre.Text = dgHistero.SelectedCells.Item(7).Value
            envio_agenda_imagenes.txtapellido.Text = dgHistero.SelectedCells.Item(8).Value
            envio_agenda_imagenes.txtci.Text = dgHistero.SelectedCells.Item(9).Value
            envio_agenda_imagenes.txtsexo.Text = dgHistero.SelectedCells.Item(12).Value
            envio_agenda_imagenes.txtedad.Text = dgHistero.SelectedCells.Item(13).Value
            envio_agenda_imagenes.txtidmodalidad_rispy.Text = dgHistero.SelectedCells.Item(14).Value

            If dgHistero.SelectedCells.Item(15).Value = 1 Then
                envio_agenda_imagenes.txtprioridad.Text = "URGENCIAS"
                envio_agenda_imagenes.txtidprioridad.Text = 3
            Else
                envio_agenda_imagenes.txtprioridad.Text = "NORMAL"
                envio_agenda_imagenes.txtidprioridad.Text = 1
            End If

            If Not IsDBNull(dgHistero.SelectedCells.Item(16).Value) Then
                envio_agenda_imagenes.txtdoctor_solicitante.Text = dgHistero.SelectedCells.Item(16).Value
            Else
                envio_agenda_imagenes.txtdoctor_solicitante.Text = "NINGUNO"
            End If

            envio_agenda_imagenes.txtmotivo.Text = dgHistero.SelectedCells.Item(17).Value
            envio_agenda_imagenes.txtfecha_entrega.Text = dgHistero.SelectedCells.Item(18).Value.ToString
            envio_agenda_imagenes.txthora_entrega.Text = dgHistero.SelectedCells.Item(19).Value.ToString

            envio_agenda_imagenes.ShowDialog()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        actualizarEstudios()
    End Sub

    Private Sub actualizarEstudios()
        Console.WriteLine(TabControl1.SelectedIndex)
        Select Case TabControl1.SelectedIndex
            Case 0
                llenar_dgElectrocardiograma()
            Case 1
                llenar_dgEco2()
            Case 2
                llenar_dgEco3()
            Case 3
                llenar_dgOrtopantomografia()
            Case 4
                llenar_dgRayosx()
            Case 5
                llenar_dgResonancia()
            Case 6
                llenar_dgTomografia()
            Case 7
                llenar_dgElectromiografia()
            Case 8
                llenar_dgEndoscopia()
            Case 9
                llenar_dgElectroencefalograma()
            Case 10
                llenar_dgHelastograma()
            Case 11
                llenar_dgLuriet()
            Case 12
                llenar_dgHistero()
        End Select

    End Sub

    Private Sub txtdesde_ValueChanged(sender As Object, e As EventArgs) Handles txtdesde.ValueChanged
        actualizarEstudios()
    End Sub

    Private Sub txthasta_ValueChanged(sender As Object, e As EventArgs) Handles txthasta.ValueChanged
        actualizarEstudios()
    End Sub
End Class