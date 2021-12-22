<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class envio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(envio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numCant = New System.Windows.Forms.NumericUpDown()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtidestudioe = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.btnenviar_correo = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.dgproc = New System.Windows.Forms.DataGridView()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txthora_entrega = New System.Windows.Forms.DateTimePicker()
        Me.txtfecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.btnagregar_estudio = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdoctor_solicitante = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbCentro = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.cbprioridad = New System.Windows.Forms.ComboBox()
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
        Me.cbSeguros = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbModalidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtdirectorio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmedico = New System.Windows.Forms.TextBox()
        Me.txtidprocedimiento = New System.Windows.Forms.TextBox()
        Me.txtidtecnico = New System.Windows.Forms.TextBox()
        Me.txtidprioridad = New System.Windows.Forms.TextBox()
        Me.txtidmodalidad = New System.Windows.Forms.TextBox()
        Me.txtidseguro = New System.Windows.Forms.TextBox()
        Me.txtidpaciente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgEstudios = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.modificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.est_anterior = New System.Windows.Forms.ToolStripMenuItem()
        Me.resubirest = New System.Windows.Forms.ToolStripMenuItem()
        Me.lista_estudios = New System.Windows.Forms.ToolStripMenuItem()
        Me.subirmodificado = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.comprimir = New System.ComponentModel.BackgroundWorker()
        Me.lblprogreso = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCentro_usuario = New System.Windows.Forms.ComboBox()
        Me.txtidcentro_usuario = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.pbloading = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numCant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgproc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.numCant)
        Me.GroupBox1.Controls.Add(Me.Panel16)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtidestudioe)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.btnenviar_correo)
        Me.GroupBox1.Controls.Add(Me.Panel14)
        Me.GroupBox1.Controls.Add(Me.dgproc)
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
        Me.GroupBox1.Controls.Add(Me.btnagregar_estudio)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtdoctor_solicitante)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbCentro)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblinforme)
        Me.GroupBox1.Controls.Add(Me.cbprioridad)
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
        Me.GroupBox1.Controls.Add(Me.cbSeguros)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbModalidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtdirectorio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(441, 736)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subir archivos al servidor"
        '
        'numCant
        '
        Me.numCant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numCant.Location = New System.Drawing.Point(229, 394)
        Me.numCant.Name = "numCant"
        Me.numCant.Size = New System.Drawing.Size(157, 18)
        Me.numCant.TabIndex = 84
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel16.Location = New System.Drawing.Point(229, 418)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(157, 4)
        Me.Panel16.TabIndex = 83
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(222, 374)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 17)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = "Cantidad de estudios"
        '
        'txtidestudioe
        '
        Me.txtidestudioe.Location = New System.Drawing.Point(122, 685)
        Me.txtidestudioe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudioe.Name = "txtidestudioe"
        Me.txtidestudioe.Size = New System.Drawing.Size(21, 22)
        Me.txtidestudioe.TabIndex = 72
        Me.txtidestudioe.Visible = False
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(85, 689)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(29, 22)
        Me.txtcorreo.TabIndex = 71
        Me.txtcorreo.Text = "NINGUNO"
        Me.txtcorreo.Visible = False
        '
        'btnenviar_correo
        '
        Me.btnenviar_correo.BackColor = System.Drawing.Color.Transparent
        Me.btnenviar_correo.BackgroundImage = Global.osiris.My.Resources.Resources.email
        Me.btnenviar_correo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnenviar_correo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnenviar_correo.FlatAppearance.BorderSize = 0
        Me.btnenviar_correo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnenviar_correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnenviar_correo.ForeColor = System.Drawing.Color.White
        Me.btnenviar_correo.Location = New System.Drawing.Point(27, 683)
        Me.btnenviar_correo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnenviar_correo.Name = "btnenviar_correo"
        Me.btnenviar_correo.Size = New System.Drawing.Size(40, 37)
        Me.btnenviar_correo.TabIndex = 70
        Me.btnenviar_correo.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel14.Location = New System.Drawing.Point(229, 366)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(152, 4)
        Me.Panel14.TabIndex = 68
        '
        'dgproc
        '
        Me.dgproc.AllowUserToAddRows = False
        Me.dgproc.AllowUserToDeleteRows = False
        Me.dgproc.AllowUserToResizeRows = False
        Me.dgproc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgproc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgproc.BackgroundColor = System.Drawing.Color.White
        Me.dgproc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgproc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproc.ColumnHeadersVisible = False
        Me.dgproc.GridColor = System.Drawing.Color.White
        Me.dgproc.Location = New System.Drawing.Point(32, 471)
        Me.dgproc.Margin = New System.Windows.Forms.Padding(4)
        Me.dgproc.Name = "dgproc"
        Me.dgproc.ReadOnly = True
        Me.dgproc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgproc.RowHeadersVisible = False
        Me.dgproc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgproc.Size = New System.Drawing.Size(401, 177)
        Me.dgproc.TabIndex = 69
        Me.dgproc.Visible = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel13.Location = New System.Drawing.Point(35, 366)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(160, 4)
        Me.Panel13.TabIndex = 67
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel12.Location = New System.Drawing.Point(35, 417)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(163, 4)
        Me.Panel12.TabIndex = 66
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel11.Location = New System.Drawing.Point(35, 313)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(344, 4)
        Me.Panel11.TabIndex = 65
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel10.Location = New System.Drawing.Point(35, 260)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(344, 4)
        Me.Panel10.TabIndex = 63
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel9.Location = New System.Drawing.Point(32, 610)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(376, 4)
        Me.Panel9.TabIndex = 64
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel8.Location = New System.Drawing.Point(32, 553)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(376, 4)
        Me.Panel8.TabIndex = 63
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel7.Location = New System.Drawing.Point(32, 468)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(344, 4)
        Me.Panel7.TabIndex = 62
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel6.Location = New System.Drawing.Point(225, 206)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(187, 4)
        Me.Panel6.TabIndex = 61
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Location = New System.Drawing.Point(35, 206)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(187, 4)
        Me.Panel5.TabIndex = 41
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(240, 151)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 4)
        Me.Panel4.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(160, 151)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(68, 4)
        Me.Panel3.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(32, 151)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 4)
        Me.Panel1.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(32, 79)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 4)
        Me.Panel2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(225, 652)
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
        Me.Label17.Location = New System.Drawing.Point(28, 652)
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
        Me.Label16.Location = New System.Drawing.Point(28, 622)
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
        Me.txthora_entrega.Location = New System.Drawing.Point(277, 649)
        Me.txthora_entrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txthora_entrega.Name = "txthora_entrega"
        Me.txthora_entrega.ShowUpDown = True
        Me.txthora_entrega.Size = New System.Drawing.Size(125, 22)
        Me.txthora_entrega.TabIndex = 35
        '
        'txtfecha_entrega
        '
        Me.txtfecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_entrega.Location = New System.Drawing.Point(85, 649)
        Me.txtfecha_entrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha_entrega.Name = "txtfecha_entrega"
        Me.txtfecha_entrega.Size = New System.Drawing.Size(129, 22)
        Me.txtfecha_entrega.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(217, 164)
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
        Me.txtapellido.Location = New System.Drawing.Point(221, 183)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(187, 15)
        Me.txtapellido.TabIndex = 13
        '
        'btnagregar_estudio
        '
        Me.btnagregar_estudio.BackColor = System.Drawing.Color.SteelBlue
        Me.btnagregar_estudio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar_estudio.FlatAppearance.BorderSize = 0
        Me.btnagregar_estudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnagregar_estudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar_estudio.ForeColor = System.Drawing.Color.White
        Me.btnagregar_estudio.Location = New System.Drawing.Point(380, 446)
        Me.btnagregar_estudio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnagregar_estudio.Name = "btnagregar_estudio"
        Me.btnagregar_estudio.Size = New System.Drawing.Size(24, 25)
        Me.btnagregar_estudio.TabIndex = 26
        Me.btnagregar_estudio.Text = "+"
        Me.btnagregar_estudio.UseVisualStyleBackColor = False
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(32, 183)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(187, 15)
        Me.txtnombre.TabIndex = 11
        '
        'txtdoctor_solicitante
        '
        Me.txtdoctor_solicitante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdoctor_solicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctor_solicitante.Location = New System.Drawing.Point(32, 587)
        Me.txtdoctor_solicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdoctor_solicitante.Name = "txtdoctor_solicitante"
        Me.txtdoctor_solicitante.Size = New System.Drawing.Size(376, 15)
        Me.txtdoctor_solicitante.TabIndex = 30
        Me.txtdoctor_solicitante.Text = "NINGUNO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(31, 567)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Doctor que solicita el estudio"
        '
        'cbCentro
        '
        Me.cbCentro.BackColor = System.Drawing.Color.White
        Me.cbCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCentro.FormattingEnabled = True
        Me.cbCentro.Location = New System.Drawing.Point(32, 288)
        Me.cbCentro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Size = New System.Drawing.Size(373, 24)
        Me.cbCentro.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(31, 268)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Seleccione el centro que realizará el informe"
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.Location = New System.Drawing.Point(28, 82)
        Me.lblinforme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(0, 17)
        Me.lblinforme.TabIndex = 3
        Me.lblinforme.Visible = False
        '
        'cbprioridad
        '
        Me.cbprioridad.BackColor = System.Drawing.Color.White
        Me.cbprioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbprioridad.FormattingEnabled = True
        Me.cbprioridad.Location = New System.Drawing.Point(32, 393)
        Me.cbprioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbprioridad.Name = "cbprioridad"
        Me.cbprioridad.Size = New System.Drawing.Size(187, 24)
        Me.cbprioridad.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(28, 373)
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
        Me.cbtecnicos.Location = New System.Drawing.Point(32, 235)
        Me.cbtecnicos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbtecnicos.Name = "cbtecnicos"
        Me.cbtecnicos.Size = New System.Drawing.Size(373, 24)
        Me.cbtecnicos.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(28, 215)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(280, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Seleccione el técnico que realizó el estudio"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.osiris.My.Resources.Resources.upload
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(207, 673)
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
        Me.lblsexo.Location = New System.Drawing.Point(236, 110)
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
        Me.txtsexo.Location = New System.Drawing.Point(236, 129)
        Me.txtsexo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(172, 15)
        Me.txtsexo.TabIndex = 9
        '
        'txtci
        '
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtci.Location = New System.Drawing.Point(32, 129)
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
        Me.txtedad.Location = New System.Drawing.Point(160, 129)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(68, 15)
        Me.txtedad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(156, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Edad"
        '
        'txtmotivo
        '
        Me.txtmotivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmotivo.Location = New System.Drawing.Point(32, 496)
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
        Me.Label9.Location = New System.Drawing.Point(28, 476)
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
        Me.txtprocedimiento.Location = New System.Drawing.Point(32, 446)
        Me.txtprocedimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprocedimiento.Name = "txtprocedimiento"
        Me.txtprocedimiento.Size = New System.Drawing.Size(344, 15)
        Me.txtprocedimiento.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(28, 426)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Estudio realizado"
        '
        'cbSeguros
        '
        Me.cbSeguros.BackColor = System.Drawing.Color.White
        Me.cbSeguros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSeguros.FormattingEnabled = True
        Me.cbSeguros.Location = New System.Drawing.Point(229, 340)
        Me.cbSeguros.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSeguros.Name = "cbSeguros"
        Me.cbSeguros.Size = New System.Drawing.Size(177, 24)
        Me.cbSeguros.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(225, 320)
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
        Me.cbModalidad.Location = New System.Drawing.Point(32, 340)
        Me.cbModalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbModalidad.Name = "cbModalidad"
        Me.cbModalidad.Size = New System.Drawing.Size(188, 24)
        Me.cbModalidad.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(28, 320)
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
        Me.Label3.Location = New System.Drawing.Point(28, 110)
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
        Me.Label2.Location = New System.Drawing.Point(28, 164)
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
        Me.Button5.Location = New System.Drawing.Point(364, 46)
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
        Me.txtdirectorio.Location = New System.Drawing.Point(32, 57)
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
        Me.Label1.Location = New System.Drawing.Point(28, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directorio de imágenes"
        '
        'txtmedico
        '
        Me.txtmedico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmedico.Location = New System.Drawing.Point(1319, 751)
        Me.txtmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedico.Name = "txtmedico"
        Me.txtmedico.Size = New System.Drawing.Size(20, 22)
        Me.txtmedico.TabIndex = 34
        Me.txtmedico.Visible = False
        '
        'txtidprocedimiento
        '
        Me.txtidprocedimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidprocedimiento.Location = New System.Drawing.Point(1196, 751)
        Me.txtidprocedimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidprocedimiento.Name = "txtidprocedimiento"
        Me.txtidprocedimiento.Size = New System.Drawing.Size(21, 22)
        Me.txtidprocedimiento.TabIndex = 32
        Me.txtidprocedimiento.Visible = False
        '
        'txtidtecnico
        '
        Me.txtidtecnico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidtecnico.Location = New System.Drawing.Point(1165, 751)
        Me.txtidtecnico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtecnico.Name = "txtidtecnico"
        Me.txtidtecnico.Size = New System.Drawing.Size(21, 22)
        Me.txtidtecnico.TabIndex = 31
        Me.txtidtecnico.Visible = False
        '
        'txtidprioridad
        '
        Me.txtidprioridad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidprioridad.Location = New System.Drawing.Point(1288, 751)
        Me.txtidprioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidprioridad.Name = "txtidprioridad"
        Me.txtidprioridad.Size = New System.Drawing.Size(21, 22)
        Me.txtidprioridad.TabIndex = 30
        Me.txtidprioridad.Visible = False
        '
        'txtidmodalidad
        '
        Me.txtidmodalidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidmodalidad.Location = New System.Drawing.Point(1257, 751)
        Me.txtidmodalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmodalidad.Name = "txtidmodalidad"
        Me.txtidmodalidad.Size = New System.Drawing.Size(21, 22)
        Me.txtidmodalidad.TabIndex = 29
        Me.txtidmodalidad.Visible = False
        '
        'txtidseguro
        '
        Me.txtidseguro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidseguro.Location = New System.Drawing.Point(1135, 751)
        Me.txtidseguro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidseguro.Name = "txtidseguro"
        Me.txtidseguro.Size = New System.Drawing.Size(21, 22)
        Me.txtidseguro.TabIndex = 28
        Me.txtidseguro.Visible = False
        '
        'txtidpaciente
        '
        Me.txtidpaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidpaciente.Location = New System.Drawing.Point(1104, 750)
        Me.txtidpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidpaciente.Name = "txtidpaciente"
        Me.txtidpaciente.Size = New System.Drawing.Size(21, 22)
        Me.txtidpaciente.TabIndex = 27
        Me.txtidpaciente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgEstudios)
        Me.GroupBox2.Location = New System.Drawing.Point(489, 68)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(905, 676)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de estudios"
        '
        'dgEstudios
        '
        Me.dgEstudios.AllowUserToAddRows = False
        Me.dgEstudios.AllowUserToDeleteRows = False
        Me.dgEstudios.AllowUserToResizeRows = False
        Me.dgEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgEstudios.BackgroundColor = System.Drawing.Color.White
        Me.dgEstudios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEstudios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgEstudios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstudios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstudios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgEstudios.EnableHeadersVisualStyles = False
        Me.dgEstudios.Location = New System.Drawing.Point(15, 23)
        Me.dgEstudios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEstudios.Name = "dgEstudios"
        Me.dgEstudios.ReadOnly = True
        Me.dgEstudios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgEstudios.RowHeadersVisible = False
        Me.dgEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstudios.Size = New System.Drawing.Size(867, 619)
        Me.dgEstudios.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modificar, Me.est_anterior, Me.resubirest, Me.lista_estudios, Me.subirmodificado})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(350, 124)
        '
        'modificar
        '
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(349, 24)
        Me.modificar.Text = "Modificar Datos"
        '
        'est_anterior
        '
        Me.est_anterior.Name = "est_anterior"
        Me.est_anterior.Size = New System.Drawing.Size(349, 24)
        Me.est_anterior.Text = "Agregar estudio anterior u orden médica"
        '
        'resubirest
        '
        Me.resubirest.Name = "resubirest"
        Me.resubirest.Size = New System.Drawing.Size(349, 24)
        Me.resubirest.Text = "Resubir imágenes"
        '
        'lista_estudios
        '
        Me.lista_estudios.Name = "lista_estudios"
        Me.lista_estudios.Size = New System.Drawing.Size(349, 24)
        Me.lista_estudios.Text = "Lista de estudios"
        '
        'subirmodificado
        '
        Me.subirmodificado.Name = "subirmodificado"
        Me.subirmodificado.Size = New System.Drawing.Size(349, 24)
        Me.subirmodificado.Text = "Resubir Modificado"
        '
        'txtidcentro
        '
        Me.txtidcentro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidcentro.Location = New System.Drawing.Point(1227, 751)
        Me.txtidcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(21, 22)
        Me.txtidcentro.TabIndex = 35
        Me.txtidcentro.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(20, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(271, 29)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ENVIO DE IMAGENES"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 60000
        '
        'comprimir
        '
        Me.comprimir.WorkerReportsProgress = True
        '
        'lblprogreso
        '
        Me.lblprogreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblprogreso.AutoSize = True
        Me.lblprogreso.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblprogreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogreso.ForeColor = System.Drawing.Color.White
        Me.lblprogreso.Location = New System.Drawing.Point(561, 774)
        Me.lblprogreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprogreso.Name = "lblprogreso"
        Me.lblprogreso.Size = New System.Drawing.Size(0, 24)
        Me.lblprogreso.TabIndex = 29
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(1076, 698)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 55
        Me.txtidtemp.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(504, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Centros disponibles"
        '
        'cbCentro_usuario
        '
        Me.cbCentro_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCentro_usuario.FormattingEnabled = True
        Me.cbCentro_usuario.Location = New System.Drawing.Point(643, 27)
        Me.cbCentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCentro_usuario.Name = "cbCentro_usuario"
        Me.cbCentro_usuario.Size = New System.Drawing.Size(192, 24)
        Me.cbCentro_usuario.TabIndex = 3
        '
        'txtidcentro_usuario
        '
        Me.txtidcentro_usuario.Location = New System.Drawing.Point(1217, 22)
        Me.txtidcentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_usuario.Name = "txtidcentro_usuario"
        Me.txtidcentro_usuario.Size = New System.Drawing.Size(51, 22)
        Me.txtidcentro_usuario.TabIndex = 4
        Me.txtidcentro_usuario.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(868, 31)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(150, 17)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Busqueda de informes"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.osiris.My.Resources.Resources.medical_report
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1025, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 56
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close_gray
        Me.btncerrar.Location = New System.Drawing.Point(1368, 15)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(27, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 51
        Me.btncerrar.TabStop = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnactualizar.BackColor = System.Drawing.Color.White
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.FlatAppearance.BorderSize = 0
        Me.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
        Me.btnactualizar.Location = New System.Drawing.Point(1355, 750)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(40, 37)
        Me.btnactualizar.TabIndex = 50
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'pbloading
        '
        Me.pbloading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbloading.Image = Global.osiris.My.Resources.Resources.Loading_2
        Me.pbloading.Location = New System.Drawing.Point(508, 762)
        Me.pbloading.Margin = New System.Windows.Forms.Padding(4)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(49, 42)
        Me.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbloading.TabIndex = 49
        Me.pbloading.TabStop = False
        Me.pbloading.Visible = False
        '
        'envio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1411, 825)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtidcentro_usuario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbCentro_usuario)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.pbloading)
        Me.Controls.Add(Me.txtidcentro)
        Me.Controls.Add(Me.lblprogreso)
        Me.Controls.Add(Me.txtmedico)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtidtecnico)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtidpaciente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtidprocedimiento)
        Me.Controls.Add(Me.txtidmodalidad)
        Me.Controls.Add(Me.txtidseguro)
        Me.Controls.Add(Me.txtidprioridad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "envio"
        Me.Text = "envio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numCant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgproc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdirectorio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents txtmotivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprocedimiento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbSeguros As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbModalidad As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsexo As TextBox
    Friend WithEvents lblsexo As Label
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtci As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbtecnicos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbprioridad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dlg As FolderBrowserDialog
    Friend WithEvents txtidpaciente As TextBox
    Friend WithEvents txtidseguro As TextBox
    Friend WithEvents lblinforme As Label
    Friend WithEvents txtidtecnico As TextBox
    Friend WithEvents txtidprioridad As TextBox
    Friend WithEvents txtidmodalidad As TextBox
    Friend WithEvents txtidprocedimiento As TextBox
    Friend WithEvents txtmedico As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Private WithEvents Timer2 As Timer
    Friend WithEvents cbCentro As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents comprimir As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblprogreso As Label
    Friend WithEvents dgEstudios As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbloading As PictureBox
    Friend WithEvents txtdoctor_solicitante As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnagregar_estudio As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents modificar As ToolStripMenuItem
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents est_anterior As ToolStripMenuItem
    Friend WithEvents resubirest As ToolStripMenuItem
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCentro_usuario As ComboBox
    Friend WithEvents txtidcentro_usuario As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txthora_entrega As DateTimePicker
    Friend WithEvents txtfecha_entrega As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents dgproc As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents btnenviar_correo As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lista_estudios As ToolStripMenuItem
    Friend WithEvents txtidestudioe As TextBox
    Friend WithEvents subirmodificado As ToolStripMenuItem
    Friend WithEvents numCant As NumericUpDown
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label20 As Label
End Class
