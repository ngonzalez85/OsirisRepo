<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class colaboraciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colaboraciones))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbcentro = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtidcentro_solicitante = New System.Windows.Forms.TextBox()
        Me.lblcomentarioreci = New System.Windows.Forms.TextBox()
        Me.txtreserva = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgSolicitudes = New System.Windows.Forms.DataGridView()
        Me.btnimagen = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnverimagen = New System.Windows.Forms.Button()
        Me.btnverinforme = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbcentro2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtidmedicoayudante = New System.Windows.Forms.TextBox()
        Me.txtdicom = New System.Windows.Forms.TextBox()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.txtidinforme = New System.Windows.Forms.TextBox()
        Me.txtidmedicosoli = New System.Windows.Forms.TextBox()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblmedicoreci = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblcomentariosoli = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblfechasoli = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblmedicosoli = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtidcentro2 = New System.Windows.Forms.TextBox()
        Me.lblmedicosolicitante = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbltecnico = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblestudio = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.btn_listo = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(982, 747)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_listo)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbcentro)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnimagen)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(974, 718)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mis Solicitudes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Centros disponibles"
        '
        'cbcentro
        '
        Me.cbcentro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbcentro.FormattingEnabled = True
        Me.cbcentro.Location = New System.Drawing.Point(157, 17)
        Me.cbcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcentro.Name = "cbcentro"
        Me.cbcentro.Size = New System.Drawing.Size(192, 24)
        Me.cbcentro.TabIndex = 57
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtidcentro_solicitante)
        Me.GroupBox6.Controls.Add(Me.lblcomentarioreci)
        Me.GroupBox6.Controls.Add(Me.txtreserva)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 441)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(859, 264)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Comentario recibido"
        '
        'txtidcentro_solicitante
        '
        Me.txtidcentro_solicitante.Location = New System.Drawing.Point(1421, 305)
        Me.txtidcentro_solicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_solicitante.Name = "txtidcentro_solicitante"
        Me.txtidcentro_solicitante.Size = New System.Drawing.Size(41, 22)
        Me.txtidcentro_solicitante.TabIndex = 64
        Me.txtidcentro_solicitante.Visible = False
        '
        'lblcomentarioreci
        '
        Me.lblcomentarioreci.Location = New System.Drawing.Point(24, 36)
        Me.lblcomentarioreci.Margin = New System.Windows.Forms.Padding(4)
        Me.lblcomentarioreci.Multiline = True
        Me.lblcomentarioreci.Name = "lblcomentarioreci"
        Me.lblcomentarioreci.Size = New System.Drawing.Size(811, 207)
        Me.lblcomentarioreci.TabIndex = 0
        '
        'txtreserva
        '
        Me.txtreserva.Location = New System.Drawing.Point(1421, 369)
        Me.txtreserva.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreserva.Name = "txtreserva"
        Me.txtreserva.Size = New System.Drawing.Size(41, 22)
        Me.txtreserva.TabIndex = 67
        Me.txtreserva.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgSolicitudes)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(941, 368)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'dgSolicitudes
        '
        Me.dgSolicitudes.AllowUserToAddRows = False
        Me.dgSolicitudes.AllowUserToDeleteRows = False
        Me.dgSolicitudes.AllowUserToResizeRows = False
        Me.dgSolicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSolicitudes.BackgroundColor = System.Drawing.Color.White
        Me.dgSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSolicitudes.EnableHeadersVisualStyles = False
        Me.dgSolicitudes.Location = New System.Drawing.Point(8, 22)
        Me.dgSolicitudes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSolicitudes.Name = "dgSolicitudes"
        Me.dgSolicitudes.ReadOnly = True
        Me.dgSolicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgSolicitudes.RowHeadersVisible = False
        Me.dgSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSolicitudes.Size = New System.Drawing.Size(925, 327)
        Me.dgSolicitudes.TabIndex = 47
        '
        'btnimagen
        '
        Me.btnimagen.BackColor = System.Drawing.Color.White
        Me.btnimagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimagen.Enabled = False
        Me.btnimagen.FlatAppearance.BorderSize = 0
        Me.btnimagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimagen.ForeColor = System.Drawing.Color.White
        Me.btnimagen.Image = CType(resources.GetObject("btnimagen.Image"), System.Drawing.Image)
        Me.btnimagen.Location = New System.Drawing.Point(875, 538)
        Me.btnimagen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.Size = New System.Drawing.Size(84, 82)
        Me.btnimagen.TabIndex = 21
        Me.btnimagen.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnverimagen)
        Me.TabPage2.Controls.Add(Me.btnverinforme)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cbcentro2)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.btn_enviar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(974, 718)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pedidos de medicos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnverimagen
        '
        Me.btnverimagen.BackColor = System.Drawing.Color.White
        Me.btnverimagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnverimagen.Enabled = False
        Me.btnverimagen.FlatAppearance.BorderSize = 0
        Me.btnverimagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnverimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverimagen.ForeColor = System.Drawing.Color.White
        Me.btnverimagen.Image = CType(resources.GetObject("btnverimagen.Image"), System.Drawing.Image)
        Me.btnverimagen.Location = New System.Drawing.Point(864, 446)
        Me.btnverimagen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnverimagen.Name = "btnverimagen"
        Me.btnverimagen.Size = New System.Drawing.Size(79, 72)
        Me.btnverimagen.TabIndex = 61
        Me.btnverimagen.UseVisualStyleBackColor = False
        '
        'btnverinforme
        '
        Me.btnverinforme.BackColor = System.Drawing.Color.White
        Me.btnverinforme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnverinforme.Enabled = False
        Me.btnverinforme.FlatAppearance.BorderSize = 0
        Me.btnverinforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnverinforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverinforme.ForeColor = System.Drawing.Color.White
        Me.btnverinforme.Image = CType(resources.GetObject("btnverinforme.Image"), System.Drawing.Image)
        Me.btnverinforme.Location = New System.Drawing.Point(872, 521)
        Me.btnverinforme.Margin = New System.Windows.Forms.Padding(4)
        Me.btnverinforme.Name = "btnverinforme"
        Me.btnverinforme.Size = New System.Drawing.Size(82, 82)
        Me.btnverinforme.TabIndex = 62
        Me.btnverinforme.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 17)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Centros disponibles"
        '
        'cbcentro2
        '
        Me.cbcentro2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbcentro2.FormattingEnabled = True
        Me.cbcentro2.Location = New System.Drawing.Point(153, 17)
        Me.cbcentro2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcentro2.Name = "cbcentro2"
        Me.cbcentro2.Size = New System.Drawing.Size(192, 24)
        Me.cbcentro2.TabIndex = 59
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgPedidos)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 50)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(934, 347)
        Me.GroupBox5.TabIndex = 32
        Me.GroupBox5.TabStop = False
        '
        'dgPedidos
        '
        Me.dgPedidos.AllowUserToAddRows = False
        Me.dgPedidos.AllowUserToDeleteRows = False
        Me.dgPedidos.AllowUserToResizeRows = False
        Me.dgPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPedidos.BackgroundColor = System.Drawing.Color.White
        Me.dgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.EnableHeadersVisualStyles = False
        Me.dgPedidos.Location = New System.Drawing.Point(6, 15)
        Me.dgPedidos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.ReadOnly = True
        Me.dgPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgPedidos.RowHeadersVisible = False
        Me.dgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPedidos.Size = New System.Drawing.Size(920, 324)
        Me.dgPedidos.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcomentario)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 442)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(839, 219)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar un comentario"
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(8, 26)
        Me.txtcomentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(823, 172)
        Me.txtcomentario.TabIndex = 0
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enviar.FlatAppearance.BorderSize = 0
        Me.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enviar.ForeColor = System.Drawing.Color.White
        Me.btn_enviar.Location = New System.Drawing.Point(672, 668)
        Me.btn_enviar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(184, 46)
        Me.btn_enviar.TabIndex = 31
        Me.btn_enviar.Text = "ENVIAR"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtidmedicoayudante)
        Me.Panel1.Controls.Add(Me.txtdicom)
        Me.Panel1.Controls.Add(Me.txtidcita)
        Me.Panel1.Controls.Add(Me.txtidcentro)
        Me.Panel1.Controls.Add(Me.txtidtemp)
        Me.Panel1.Controls.Add(Me.txtestado)
        Me.Panel1.Controls.Add(Me.txtidinforme)
        Me.Panel1.Controls.Add(Me.txtidmedicosoli)
        Me.Panel1.Controls.Add(Me.txtidestudio)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(1003, 38)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 722)
        Me.Panel1.TabIndex = 3
        '
        'txtidmedicoayudante
        '
        Me.txtidmedicoayudante.Location = New System.Drawing.Point(291, 4)
        Me.txtidmedicoayudante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmedicoayudante.Name = "txtidmedicoayudante"
        Me.txtidmedicoayudante.Size = New System.Drawing.Size(25, 22)
        Me.txtidmedicoayudante.TabIndex = 65
        Me.txtidmedicoayudante.Visible = False
        '
        'txtdicom
        '
        Me.txtdicom.Location = New System.Drawing.Point(4, 65)
        Me.txtdicom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdicom.Name = "txtdicom"
        Me.txtdicom.Size = New System.Drawing.Size(19, 22)
        Me.txtdicom.TabIndex = 64
        Me.txtdicom.Visible = False
        '
        'txtidcita
        '
        Me.txtidcita.Location = New System.Drawing.Point(4, 35)
        Me.txtidcita.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(19, 22)
        Me.txtidcita.TabIndex = 63
        Me.txtidcita.Visible = False
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(131, 4)
        Me.txtidcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(24, 22)
        Me.txtidcentro.TabIndex = 62
        Me.txtidcentro.Visible = False
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(4, 6)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 62
        Me.txtidtemp.Visible = False
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(163, 4)
        Me.txtestado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(21, 22)
        Me.txtestado.TabIndex = 61
        Me.txtestado.Visible = False
        '
        'txtidinforme
        '
        Me.txtidinforme.Location = New System.Drawing.Point(192, 4)
        Me.txtidinforme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidinforme.Name = "txtidinforme"
        Me.txtidinforme.Size = New System.Drawing.Size(25, 22)
        Me.txtidinforme.TabIndex = 59
        Me.txtidinforme.Visible = False
        '
        'txtidmedicosoli
        '
        Me.txtidmedicosoli.Location = New System.Drawing.Point(225, 4)
        Me.txtidmedicosoli.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmedicosoli.Name = "txtidmedicosoli"
        Me.txtidmedicosoli.Size = New System.Drawing.Size(25, 22)
        Me.txtidmedicosoli.TabIndex = 58
        Me.txtidmedicosoli.Visible = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(258, 4)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(25, 22)
        Me.txtidestudio.TabIndex = 57
        Me.txtidestudio.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.rtb1)
        Me.GroupBox4.Controls.Add(Me.lblestado)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lblmedicoreci)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.lblcomentariosoli)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lblfechasoli)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblmedicosoli)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(50, 313)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(282, 392)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de la solicitud"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(8, 214)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(52, 17)
        Me.lblestado.TabIndex = 58
        Me.lblestado.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 198)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "ESTADO"
        '
        'lblmedicoreci
        '
        Me.lblmedicoreci.AutoSize = True
        Me.lblmedicoreci.Location = New System.Drawing.Point(8, 105)
        Me.lblmedicoreci.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedicoreci.Name = "lblmedicoreci"
        Me.lblmedicoreci.Size = New System.Drawing.Size(130, 17)
        Me.lblmedicoreci.TabIndex = 56
        Me.lblmedicoreci.Text = "Nombre del medico"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 17)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "MEDICO AL QUE SOLICITA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 534)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Médico que solicita"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 518)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "MEDICO SOLICITANE"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(291, 492)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(53, 22)
        Me.TextBox3.TabIndex = 49
        Me.TextBox3.Visible = False
        '
        'lblcomentariosoli
        '
        Me.lblcomentariosoli.BackColor = System.Drawing.Color.White
        Me.lblcomentariosoli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblcomentariosoli.Location = New System.Drawing.Point(9, 272)
        Me.lblcomentariosoli.Margin = New System.Windows.Forms.Padding(4)
        Me.lblcomentariosoli.Multiline = True
        Me.lblcomentariosoli.Name = "lblcomentariosoli"
        Me.lblcomentariosoli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblcomentariosoli.Size = New System.Drawing.Size(265, 99)
        Me.lblcomentariosoli.TabIndex = 52
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(461, 80)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(36, 22)
        Me.TextBox5.TabIndex = 51
        Me.TextBox5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 492)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre del técnico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 476)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "TÉCNICO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "COMENTARIO"
        '
        'lblfechasoli
        '
        Me.lblfechasoli.AutoSize = True
        Me.lblfechasoli.Location = New System.Drawing.Point(8, 161)
        Me.lblfechasoli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfechasoli.Name = "lblfechasoli"
        Me.lblfechasoli.Size = New System.Drawing.Size(122, 17)
        Me.lblfechasoli.TabIndex = 9
        Me.lblfechasoli.Text = "Fecha de solicitud"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 145)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "FECHA SOLICITUD"
        '
        'lblmedicosoli
        '
        Me.lblmedicosoli.AutoSize = True
        Me.lblmedicosoli.Location = New System.Drawing.Point(8, 50)
        Me.lblmedicosoli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedicosoli.Name = "lblmedicosoli"
        Me.lblmedicosoli.Size = New System.Drawing.Size(130, 17)
        Me.lblmedicosoli.TabIndex = 3
        Me.lblmedicosoli.Text = "Nombre del medico"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 34)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(241, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "MEDICO QUE SOLICITA AYUDA:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtidcentro2)
        Me.GroupBox3.Controls.Add(Me.lblmedicosolicitante)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.txtmotivo)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.lbltecnico)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblestudio)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblpaciente)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(50, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(283, 285)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del paciente"
        '
        'txtidcentro2
        '
        Me.txtidcentro2.Location = New System.Drawing.Point(52, -14)
        Me.txtidcentro2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro2.Name = "txtidcentro2"
        Me.txtidcentro2.Size = New System.Drawing.Size(24, 22)
        Me.txtidcentro2.TabIndex = 66
        Me.txtidcentro2.Visible = False
        '
        'lblmedicosolicitante
        '
        Me.lblmedicosolicitante.AutoSize = True
        Me.lblmedicosolicitante.Location = New System.Drawing.Point(31, 534)
        Me.lblmedicosolicitante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedicosolicitante.Name = "lblmedicosolicitante"
        Me.lblmedicosolicitante.Size = New System.Drawing.Size(128, 17)
        Me.lblmedicosolicitante.TabIndex = 54
        Me.lblmedicosolicitante.Text = "Médico que solicita"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 518)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 17)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "MEDICO SOLICITANE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(291, 492)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 22)
        Me.TextBox1.TabIndex = 49
        Me.TextBox1.Visible = False
        '
        'txtmotivo
        '
        Me.txtmotivo.BackColor = System.Drawing.Color.White
        Me.txtmotivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmotivo.Location = New System.Drawing.Point(8, 171)
        Me.txtmotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmotivo.Multiline = True
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtmotivo.Size = New System.Drawing.Size(266, 94)
        Me.txtmotivo.TabIndex = 52
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(461, 80)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 22)
        Me.TextBox2.TabIndex = 51
        Me.TextBox2.Visible = False
        '
        'lbltecnico
        '
        Me.lbltecnico.AutoSize = True
        Me.lbltecnico.Location = New System.Drawing.Point(29, 492)
        Me.lbltecnico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltecnico.Name = "lbltecnico"
        Me.lbltecnico.Size = New System.Drawing.Size(130, 17)
        Me.lbltecnico.TabIndex = 15
        Me.lbltecnico.Text = "Nombre del técnico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 476)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TÉCNICO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 150)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "MOTIVO"
        '
        'lblestudio
        '
        Me.lblestudio.AutoSize = True
        Me.lblestudio.Location = New System.Drawing.Point(8, 110)
        Me.lblestudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestudio.Name = "lblestudio"
        Me.lblestudio.Size = New System.Drawing.Size(117, 17)
        Me.lblestudio.TabIndex = 11
        Me.lblestudio.Text = "Estudio realizado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 94)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "ESTUDIO"
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(8, 50)
        Me.lblpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(139, 17)
        Me.lblpaciente.TabIndex = 3
        Me.lblpaciente.Text = "Nombre del paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PACIENTE"
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(-48, 335)
        Me.rtb1.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(94, 70)
        Me.rtb1.TabIndex = 66
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'btn_listo
        '
        Me.btn_listo.BackColor = System.Drawing.Color.White
        Me.btn_listo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_listo.Enabled = False
        Me.btn_listo.FlatAppearance.BorderSize = 0
        Me.btn_listo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_listo.ForeColor = System.Drawing.Color.White
        Me.btn_listo.Image = CType(resources.GetObject("btn_listo.Image"), System.Drawing.Image)
        Me.btn_listo.Location = New System.Drawing.Point(882, 452)
        Me.btn_listo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_listo.Name = "btn_listo"
        Me.btn_listo.Size = New System.Drawing.Size(84, 82)
        Me.btn_listo.TabIndex = 59
        Me.btn_listo.UseVisualStyleBackColor = False
        '
        'colaboraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 773)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "colaboraciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "colaboraciones"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblmedicosolicitante As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtmotivo As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbltecnico As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblestudio As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblpaciente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcomentario As TextBox
    Friend WithEvents btn_enviar As Button
    Friend WithEvents txtidinforme As TextBox
    Friend WithEvents txtidmedicosoli As TextBox
    Friend WithEvents txtidestudio As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblcomentariosoli As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblfechasoli As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblmedicosoli As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnimagen As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblcomentarioreci As TextBox
    Friend WithEvents dgSolicitudes As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label9 As Label
    Friend WithEvents cbcentro As ComboBox
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents txtidcentro_solicitante As TextBox
    Friend WithEvents txtreserva As TextBox
    Friend WithEvents txtdicom As TextBox
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents lblmedicoreci As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtidmedicoayudante As TextBox
    Friend WithEvents btnverimagen As Button
    Friend WithEvents btnverinforme As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cbcentro2 As ComboBox
    Friend WithEvents dgPedidos As DataGridView
    Friend WithEvents txtidcentro2 As TextBox
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents btn_listo As Button
End Class
