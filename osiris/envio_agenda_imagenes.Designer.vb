<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class envio_agenda_imagenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(envio_agenda_imagenes))
        Me.txtidprocedimiento = New System.Windows.Forms.TextBox()
        Me.txtidseguro = New System.Windows.Forms.TextBox()
        Me.dgproc = New System.Windows.Forms.DataGridView()
        Me.txtcentro = New System.Windows.Forms.TextBox()
        Me.txtseguro = New System.Windows.Forms.TextBox()
        Me.txtprioridad = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtidtecnico = New System.Windows.Forms.TextBox()
        Me.txtidpaciente = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.txtidmodalidad = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pbloading = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txthora_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdoctor_solicitante = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidprioridad = New System.Windows.Forms.TextBox()
        Me.lblprogreso = New System.Windows.Forms.Label()
        Me.txtfecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.txtidmodalidad_rispy = New System.Windows.Forms.TextBox()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.txtidrispy = New System.Windows.Forms.TextBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbMedico = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbtecnicos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblsexo = New System.Windows.Forms.Label()
        Me.txtsexo = New System.Windows.Forms.TextBox()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprocedimiento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbModalidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtdirectorio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.comprimir = New System.ComponentModel.BackgroundWorker()
        Me.txtidusuario_medico = New System.Windows.Forms.TextBox()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.txtarchivo = New System.Windows.Forms.TextBox()
        Me.txtcidoctor = New System.Windows.Forms.TextBox()
        Me.txtidestudioe = New System.Windows.Forms.TextBox()
        Me.numCant = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgproc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidprocedimiento
        '
        Me.txtidprocedimiento.Location = New System.Drawing.Point(317, 847)
        Me.txtidprocedimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidprocedimiento.Name = "txtidprocedimiento"
        Me.txtidprocedimiento.Size = New System.Drawing.Size(21, 22)
        Me.txtidprocedimiento.TabIndex = 75
        Me.txtidprocedimiento.Visible = False
        '
        'txtidseguro
        '
        Me.txtidseguro.Location = New System.Drawing.Point(256, 847)
        Me.txtidseguro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidseguro.Name = "txtidseguro"
        Me.txtidseguro.Size = New System.Drawing.Size(21, 22)
        Me.txtidseguro.TabIndex = 71
        Me.txtidseguro.Text = "6"
        Me.txtidseguro.Visible = False
        '
        'dgproc
        '
        Me.dgproc.AllowUserToAddRows = False
        Me.dgproc.AllowUserToDeleteRows = False
        Me.dgproc.AllowUserToResizeRows = False
        Me.dgproc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgproc.BackgroundColor = System.Drawing.Color.White
        Me.dgproc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgproc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproc.ColumnHeadersVisible = False
        Me.dgproc.GridColor = System.Drawing.Color.White
        Me.dgproc.Location = New System.Drawing.Point(32, 458)
        Me.dgproc.Margin = New System.Windows.Forms.Padding(4)
        Me.dgproc.Name = "dgproc"
        Me.dgproc.ReadOnly = True
        Me.dgproc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgproc.RowHeadersVisible = False
        Me.dgproc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgproc.Size = New System.Drawing.Size(401, 210)
        Me.dgproc.TabIndex = 73
        Me.dgproc.Visible = False
        '
        'txtcentro
        '
        Me.txtcentro.BackColor = System.Drawing.Color.White
        Me.txtcentro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcentro.Location = New System.Drawing.Point(32, 282)
        Me.txtcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcentro.Name = "txtcentro"
        Me.txtcentro.ReadOnly = True
        Me.txtcentro.Size = New System.Drawing.Size(347, 15)
        Me.txtcentro.TabIndex = 72
        '
        'txtseguro
        '
        Me.txtseguro.BackColor = System.Drawing.Color.White
        Me.txtseguro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtseguro.Location = New System.Drawing.Point(260, 334)
        Me.txtseguro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtseguro.Name = "txtseguro"
        Me.txtseguro.Size = New System.Drawing.Size(152, 15)
        Me.txtseguro.TabIndex = 71
        Me.txtseguro.Text = "PARTICULAR"
        '
        'txtprioridad
        '
        Me.txtprioridad.BackColor = System.Drawing.Color.White
        Me.txtprioridad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprioridad.Location = New System.Drawing.Point(32, 390)
        Me.txtprioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprioridad.Name = "txtprioridad"
        Me.txtprioridad.ReadOnly = True
        Me.txtprioridad.Size = New System.Drawing.Size(194, 15)
        Me.txtprioridad.TabIndex = 70
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel14.Location = New System.Drawing.Point(260, 356)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(152, 4)
        Me.Panel14.TabIndex = 68
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel13.Location = New System.Drawing.Point(35, 356)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(193, 4)
        Me.Panel13.TabIndex = 67
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel12.Location = New System.Drawing.Point(36, 407)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(192, 4)
        Me.Panel12.TabIndex = 66
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel11.Location = New System.Drawing.Point(35, 303)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(344, 4)
        Me.Panel11.TabIndex = 65
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel10.Location = New System.Drawing.Point(35, 250)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(344, 4)
        Me.Panel10.TabIndex = 63
        '
        'txtidtecnico
        '
        Me.txtidtecnico.Location = New System.Drawing.Point(287, 847)
        Me.txtidtecnico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtecnico.Name = "txtidtecnico"
        Me.txtidtecnico.Size = New System.Drawing.Size(21, 22)
        Me.txtidtecnico.TabIndex = 74
        Me.txtidtecnico.Visible = False
        '
        'txtidpaciente
        '
        Me.txtidpaciente.Location = New System.Drawing.Point(225, 846)
        Me.txtidpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidpaciente.Name = "txtidpaciente"
        Me.txtidpaciente.Size = New System.Drawing.Size(21, 22)
        Me.txtidpaciente.TabIndex = 70
        Me.txtidpaciente.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel9.Location = New System.Drawing.Point(32, 601)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(376, 4)
        Me.Panel9.TabIndex = 64
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel8.Location = New System.Drawing.Point(32, 543)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(376, 4)
        Me.Panel8.TabIndex = 63
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel6.Location = New System.Drawing.Point(225, 196)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(187, 4)
        Me.Panel6.TabIndex = 61
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Location = New System.Drawing.Point(35, 196)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(187, 4)
        Me.Panel5.TabIndex = 41
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(240, 142)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 4)
        Me.Panel4.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(160, 142)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(68, 4)
        Me.Panel3.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(32, 142)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 4)
        Me.Panel1.TabIndex = 38
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(348, 847)
        Me.txtidcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(21, 22)
        Me.txtidcentro.TabIndex = 76
        Me.txtidcentro.Visible = False
        '
        'txtidmodalidad
        '
        Me.txtidmodalidad.Location = New System.Drawing.Point(379, 847)
        Me.txtidmodalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmodalidad.Name = "txtidmodalidad"
        Me.txtidmodalidad.Size = New System.Drawing.Size(21, 22)
        Me.txtidmodalidad.TabIndex = 72
        Me.txtidmodalidad.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel7.Location = New System.Drawing.Point(32, 458)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(344, 4)
        Me.Panel7.TabIndex = 62
        '
        'pbloading
        '
        Me.pbloading.Image = Global.osiris.My.Resources.Resources.Loading_2
        Me.pbloading.Location = New System.Drawing.Point(37, 839)
        Me.pbloading.Margin = New System.Windows.Forms.Padding(4)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(49, 42)
        Me.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbloading.TabIndex = 69
        Me.pbloading.TabStop = False
        Me.pbloading.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(32, 69)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 4)
        Me.Panel2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(225, 642)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Hora"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(28, 642)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 17)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Fecha"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(28, 612)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 17)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Entrega del estudio"
        '
        'txthora_entrega
        '
        Me.txthora_entrega.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.txthora_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txthora_entrega.Location = New System.Drawing.Point(277, 639)
        Me.txthora_entrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txthora_entrega.Name = "txthora_entrega"
        Me.txthora_entrega.ShowUpDown = True
        Me.txthora_entrega.Size = New System.Drawing.Size(125, 22)
        Me.txthora_entrega.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(217, 154)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Apellido"
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.White
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellido.Location = New System.Drawing.Point(221, 174)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(187, 15)
        Me.txtapellido.TabIndex = 13
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(32, 174)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(187, 15)
        Me.txtnombre.TabIndex = 11
        '
        'txtdoctor_solicitante
        '
        Me.txtdoctor_solicitante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdoctor_solicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctor_solicitante.Location = New System.Drawing.Point(32, 577)
        Me.txtdoctor_solicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdoctor_solicitante.Name = "txtdoctor_solicitante"
        Me.txtdoctor_solicitante.Size = New System.Drawing.Size(376, 15)
        Me.txtdoctor_solicitante.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(31, 558)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Doctor que solicita el estudio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(31, 258)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Centro que realizará el informe"
        '
        'txtidprioridad
        '
        Me.txtidprioridad.Location = New System.Drawing.Point(409, 847)
        Me.txtidprioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidprioridad.Name = "txtidprioridad"
        Me.txtidprioridad.Size = New System.Drawing.Size(21, 22)
        Me.txtidprioridad.TabIndex = 73
        Me.txtidprioridad.Visible = False
        '
        'lblprogreso
        '
        Me.lblprogreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblprogreso.AutoSize = True
        Me.lblprogreso.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblprogreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogreso.ForeColor = System.Drawing.Color.White
        Me.lblprogreso.Location = New System.Drawing.Point(91, 849)
        Me.lblprogreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprogreso.Name = "lblprogreso"
        Me.lblprogreso.Size = New System.Drawing.Size(0, 24)
        Me.lblprogreso.TabIndex = 68
        '
        'txtfecha_entrega
        '
        Me.txtfecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_entrega.Location = New System.Drawing.Point(85, 639)
        Me.txtfecha_entrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha_entrega.Name = "txtfecha_entrega"
        Me.txtfecha_entrega.Size = New System.Drawing.Size(129, 22)
        Me.txtfecha_entrega.TabIndex = 33
        '
        'txtidmodalidad_rispy
        '
        Me.txtidmodalidad_rispy.Location = New System.Drawing.Point(164, 844)
        Me.txtidmodalidad_rispy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmodalidad_rispy.Name = "txtidmodalidad_rispy"
        Me.txtidmodalidad_rispy.Size = New System.Drawing.Size(21, 22)
        Me.txtidmodalidad_rispy.TabIndex = 78
        Me.txtidmodalidad_rispy.Visible = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.Location = New System.Drawing.Point(28, 73)
        Me.lblinforme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(0, 17)
        Me.lblinforme.TabIndex = 3
        Me.lblinforme.Visible = False
        '
        'txtidrispy
        '
        Me.txtidrispy.Location = New System.Drawing.Point(195, 847)
        Me.txtidrispy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidrispy.Name = "txtidrispy"
        Me.txtidrispy.Size = New System.Drawing.Size(21, 22)
        Me.txtidrispy.TabIndex = 77
        Me.txtidrispy.Visible = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lbltitulo.Location = New System.Drawing.Point(13, 6)
        Me.lbltitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(271, 29)
        Me.lbltitulo.TabIndex = 66
        Me.lbltitulo.Text = "ENVIO DE IMAGENES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numCant)
        Me.GroupBox1.Controls.Add(Me.Panel15)
        Me.GroupBox1.Controls.Add(Me.Panel16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbMedico)
        Me.GroupBox1.Controls.Add(Me.dgproc)
        Me.GroupBox1.Controls.Add(Me.txtcentro)
        Me.GroupBox1.Controls.Add(Me.txtseguro)
        Me.GroupBox1.Controls.Add(Me.txtprioridad)
        Me.GroupBox1.Controls.Add(Me.Panel14)
        Me.GroupBox1.Controls.Add(Me.Panel13)
        Me.GroupBox1.Controls.Add(Me.Panel12)
        Me.GroupBox1.Controls.Add(Me.Panel11)
        Me.GroupBox1.Controls.Add(Me.Panel10)
        Me.GroupBox1.Controls.Add(Me.Panel9)
        Me.GroupBox1.Controls.Add(Me.Panel8)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txthora_entrega)
        Me.GroupBox1.Controls.Add(Me.txtfecha_entrega)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtdoctor_solicitante)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblinforme)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbtecnicos)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.lblsexo)
        Me.GroupBox1.Controls.Add(Me.txtsexo)
        Me.GroupBox1.Controls.Add(Me.txtci)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmotivo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtprocedimiento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbModalidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtdirectorio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(441, 791)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subir archivos al servidor"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel15.Location = New System.Drawing.Point(23, 722)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(385, 4)
        Me.Panel15.TabIndex = 79
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel16.Location = New System.Drawing.Point(260, 407)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(157, 4)
        Me.Panel16.TabIndex = 72
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(257, 363)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 17)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Cantidad de estudios"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(19, 672)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 17)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Asignar un médico informante"
        '
        'cbMedico
        '
        Me.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMedico.FormattingEnabled = True
        Me.cbMedico.Location = New System.Drawing.Point(23, 692)
        Me.cbMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedico.Name = "cbMedico"
        Me.cbMedico.Size = New System.Drawing.Size(384, 24)
        Me.cbMedico.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(28, 363)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Prioridad"
        '
        'cbtecnicos
        '
        Me.cbtecnicos.BackColor = System.Drawing.Color.White
        Me.cbtecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbtecnicos.FormattingEnabled = True
        Me.cbtecnicos.Location = New System.Drawing.Point(32, 225)
        Me.cbtecnicos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbtecnicos.Name = "cbtecnicos"
        Me.cbtecnicos.Size = New System.Drawing.Size(373, 24)
        Me.cbtecnicos.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(28, 206)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(280, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Seleccione el técnico que realizó el estudio"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.osiris.My.Resources.Resources.upload
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(207, 736)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(201, 46)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "SUBIR ARCHIVOS"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblsexo
        '
        Me.lblsexo.AutoSize = True
        Me.lblsexo.ForeColor = System.Drawing.Color.DimGray
        Me.lblsexo.Location = New System.Drawing.Point(236, 100)
        Me.lblsexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsexo.Name = "lblsexo"
        Me.lblsexo.Size = New System.Drawing.Size(39, 17)
        Me.lblsexo.TabIndex = 8
        Me.lblsexo.Text = "Sexo"
        '
        'txtsexo
        '
        Me.txtsexo.BackColor = System.Drawing.Color.White
        Me.txtsexo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsexo.Location = New System.Drawing.Point(236, 119)
        Me.txtsexo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(172, 15)
        Me.txtsexo.TabIndex = 9
        '
        'txtci
        '
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtci.Location = New System.Drawing.Point(32, 119)
        Me.txtci.Margin = New System.Windows.Forms.Padding(4)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(120, 15)
        Me.txtci.TabIndex = 5
        '
        'txtedad
        '
        Me.txtedad.BackColor = System.Drawing.Color.White
        Me.txtedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtedad.Location = New System.Drawing.Point(160, 119)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(68, 15)
        Me.txtedad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(156, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Edad"
        '
        'txtmotivo
        '
        Me.txtmotivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmotivo.Location = New System.Drawing.Point(32, 486)
        Me.txtmotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmotivo.Multiline = True
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(376, 49)
        Me.txtmotivo.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(28, 466)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Motivo del estudio"
        '
        'txtprocedimiento
        '
        Me.txtprocedimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtprocedimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtprocedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprocedimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprocedimiento.Location = New System.Drawing.Point(32, 436)
        Me.txtprocedimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprocedimiento.Name = "txtprocedimiento"
        Me.txtprocedimiento.Size = New System.Drawing.Size(344, 15)
        Me.txtprocedimiento.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(28, 416)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Estudio realizado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(225, 310)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Seguro"
        '
        'cbModalidad
        '
        Me.cbModalidad.BackColor = System.Drawing.Color.White
        Me.cbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbModalidad.FormattingEnabled = True
        Me.cbModalidad.Location = New System.Drawing.Point(32, 330)
        Me.cbModalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbModalidad.Name = "cbModalidad"
        Me.cbModalidad.Size = New System.Drawing.Size(219, 24)
        Me.cbModalidad.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(28, 310)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Modalidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(28, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CINº"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(28, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre del paciente"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(364, 36)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 37)
        Me.Button5.TabIndex = 2
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtdirectorio
        '
        Me.txtdirectorio.BackColor = System.Drawing.Color.White
        Me.txtdirectorio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdirectorio.Location = New System.Drawing.Point(32, 47)
        Me.txtdirectorio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdirectorio.Name = "txtdirectorio"
        Me.txtdirectorio.ReadOnly = True
        Me.txtdirectorio.Size = New System.Drawing.Size(324, 15)
        Me.txtdirectorio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directorio de imágenes"
        '
        'comprimir
        '
        Me.comprimir.WorkerReportsProgress = True
        '
        'txtidusuario_medico
        '
        Me.txtidusuario_medico.Location = New System.Drawing.Point(133, 844)
        Me.txtidusuario_medico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidusuario_medico.Name = "txtidusuario_medico"
        Me.txtidusuario_medico.Size = New System.Drawing.Size(21, 22)
        Me.txtidusuario_medico.TabIndex = 79
        Me.txtidusuario_medico.Visible = False
        '
        'txtidcita
        '
        Me.txtidcita.Location = New System.Drawing.Point(103, 846)
        Me.txtidcita.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(21, 22)
        Me.txtidcita.TabIndex = 81
        Me.txtidcita.Visible = False
        '
        'txtarchivo
        '
        Me.txtarchivo.Location = New System.Drawing.Point(5, 857)
        Me.txtarchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtarchivo.Name = "txtarchivo"
        Me.txtarchivo.Size = New System.Drawing.Size(49, 22)
        Me.txtarchivo.TabIndex = 80
        Me.txtarchivo.Visible = False
        '
        'txtcidoctor
        '
        Me.txtcidoctor.Location = New System.Drawing.Point(72, 844)
        Me.txtcidoctor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcidoctor.Name = "txtcidoctor"
        Me.txtcidoctor.Size = New System.Drawing.Size(21, 22)
        Me.txtcidoctor.TabIndex = 82
        Me.txtcidoctor.Visible = False
        '
        'txtidestudioe
        '
        Me.txtidestudioe.Location = New System.Drawing.Point(442, 851)
        Me.txtidestudioe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudioe.Name = "txtidestudioe"
        Me.txtidestudioe.Size = New System.Drawing.Size(21, 22)
        Me.txtidestudioe.TabIndex = 83
        Me.txtidestudioe.Visible = False
        '
        'numCant
        '
        Me.numCant.Location = New System.Drawing.Point(260, 383)
        Me.numCant.Name = "numCant"
        Me.numCant.Size = New System.Drawing.Size(157, 22)
        Me.numCant.TabIndex = 81
        '
        'envio_agenda_imagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(476, 891)
        Me.Controls.Add(Me.txtidestudioe)
        Me.Controls.Add(Me.txtcidoctor)
        Me.Controls.Add(Me.txtidcita)
        Me.Controls.Add(Me.txtidusuario_medico)
        Me.Controls.Add(Me.txtidprocedimiento)
        Me.Controls.Add(Me.txtarchivo)
        Me.Controls.Add(Me.txtidseguro)
        Me.Controls.Add(Me.txtidtecnico)
        Me.Controls.Add(Me.txtidpaciente)
        Me.Controls.Add(Me.txtidcentro)
        Me.Controls.Add(Me.txtidmodalidad)
        Me.Controls.Add(Me.pbloading)
        Me.Controls.Add(Me.txtidprioridad)
        Me.Controls.Add(Me.lblprogreso)
        Me.Controls.Add(Me.txtidmodalidad_rispy)
        Me.Controls.Add(Me.txtidrispy)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "envio_agenda_imagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir estudio"
        CType(Me.dgproc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidprocedimiento As TextBox
    Friend WithEvents txtidseguro As TextBox
    Friend WithEvents dgproc As DataGridView
    Friend WithEvents txtcentro As TextBox
    Friend WithEvents txtseguro As TextBox
    Friend WithEvents txtprioridad As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtidtecnico As TextBox
    Friend WithEvents txtidpaciente As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents txtidmodalidad As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pbloading As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txthora_entrega As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdoctor_solicitante As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtidprioridad As TextBox
    Friend WithEvents lblprogreso As Label
    Friend WithEvents txtfecha_entrega As DateTimePicker
    Friend WithEvents txtidmodalidad_rispy As TextBox
    Friend WithEvents lblinforme As Label
    Friend WithEvents txtidrispy As TextBox
    Friend WithEvents lbltitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbtecnicos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents lblsexo As Label
    Friend WithEvents txtsexo As TextBox
    Friend WithEvents txtci As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmotivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprocedimiento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbModalidad As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents txtdirectorio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dlg As FolderBrowserDialog
    Friend WithEvents comprimir As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cbMedico As ComboBox
    Friend WithEvents txtidusuario_medico As TextBox
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents txtarchivo As TextBox
    Friend WithEvents txtcidoctor As TextBox
    Friend WithEvents txtidestudioe As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents numCant As NumericUpDown
End Class
