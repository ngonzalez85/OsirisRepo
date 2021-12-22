<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class busqueda_informe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busqueda_informe))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.porMedico = New System.Windows.Forms.CheckBox()
        Me.primerApellido = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtmedico = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtidmedico = New System.Windows.Forms.TextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCentro_usuario = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.reimprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ver_imagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.cambiar_estado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ver_firma = New System.Windows.Forms.ToolStripMenuItem()
        Me.enviar_correo = New System.Windows.Forms.ToolStripMenuItem()
        Me.descargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificarfecha = New System.Windows.Forms.ToolStripMenuItem()
        Me.est_anterior = New System.Windows.Forms.ToolStripMenuItem()
        Me.subirmodificado = New System.Windows.Forms.ToolStripMenuItem()
        Me.resubirest = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblcant = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.txtidcentro_usuario = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.porMedico)
        Me.GroupBox1.Controls.Add(Me.primerApellido)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtmedico)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txthasta)
        Me.GroupBox1.Controls.Add(Me.txtdesde)
        Me.GroupBox1.Controls.Add(Me.txtpaciente)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.txtci)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1380, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de busqueda"
        '
        'porMedico
        '
        Me.porMedico.AutoSize = True
        Me.porMedico.Location = New System.Drawing.Point(957, 40)
        Me.porMedico.Name = "porMedico"
        Me.porMedico.Size = New System.Drawing.Size(101, 21)
        Me.porMedico.TabIndex = 70
        Me.porMedico.Text = "Por Medico"
        Me.porMedico.UseVisualStyleBackColor = True
        '
        'primerApellido
        '
        Me.primerApellido.AutoSize = True
        Me.primerApellido.Location = New System.Drawing.Point(371, 40)
        Me.primerApellido.Name = "primerApellido"
        Me.primerApellido.Size = New System.Drawing.Size(125, 21)
        Me.primerApellido.TabIndex = 69
        Me.primerApellido.Text = "Primer Apellido"
        Me.primerApellido.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(17, 93)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 4)
        Me.Panel1.TabIndex = 68
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(958, 91)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(331, 4)
        Me.Panel3.TabIndex = 66
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
        Me.btnactualizar.Location = New System.Drawing.Point(1297, 58)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(40, 37)
        Me.btnactualizar.TabIndex = 67
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(256, 93)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 4)
        Me.Panel2.TabIndex = 65
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(640, 39)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 21)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "Por rango de fechas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtmedico
        '
        Me.txtmedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtmedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtmedico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmedico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmedico.Location = New System.Drawing.Point(957, 68)
        Me.txtmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedico.Multiline = True
        Me.txtmedico.Name = "txtmedico"
        Me.txtmedico.Size = New System.Drawing.Size(332, 23)
        Me.txtmedico.TabIndex = 22
        Me.txtmedico.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(781, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "A"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(604, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "De"
        Me.Label1.Visible = False
        '
        'txthasta
        '
        Me.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txthasta.Location = New System.Drawing.Point(808, 73)
        Me.txthasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.Size = New System.Drawing.Size(132, 22)
        Me.txthasta.TabIndex = 9
        Me.txthasta.Visible = False
        '
        'txtdesde
        '
        Me.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdesde.Location = New System.Drawing.Point(640, 73)
        Me.txtdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(132, 22)
        Me.txtdesde.TabIndex = 8
        Me.txtdesde.Visible = False
        '
        'txtpaciente
        '
        Me.txtpaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtpaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtpaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpaciente.Location = New System.Drawing.Point(256, 68)
        Me.txtpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpaciente.Multiline = True
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.Size = New System.Drawing.Size(332, 27)
        Me.txtpaciente.TabIndex = 4
        Me.txtpaciente.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(255, 39)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(109, 21)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Por paciente"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtci
        '
        Me.txtci.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.Location = New System.Drawing.Point(17, 68)
        Me.txtci.Margin = New System.Windows.Forms.Padding(4)
        Me.txtci.Multiline = True
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(229, 25)
        Me.txtci.TabIndex = 2
        Me.txtci.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 39)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Por cédula"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtidmedico
        '
        Me.txtidmedico.Location = New System.Drawing.Point(71, 106)
        Me.txtidmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmedico.Name = "txtidmedico"
        Me.txtidmedico.Size = New System.Drawing.Size(28, 22)
        Me.txtidmedico.TabIndex = 23
        Me.txtidmedico.Visible = False
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(-2, 584)
        Me.rtb1.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(132, 117)
        Me.rtb1.TabIndex = 9
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtprueba)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.dgContenedor)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 136)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1676, 524)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de estudios"
        '
        'txtprueba
        '
        Me.txtprueba.Location = New System.Drawing.Point(1513, 433)
        Me.txtprueba.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprueba.Name = "txtprueba"
        Me.txtprueba.Size = New System.Drawing.Size(67, 22)
        Me.txtprueba.TabIndex = 55
        Me.txtprueba.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1448, 463)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(132, 117)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
        Me.dgContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgContenedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgContenedor.BackgroundColor = System.Drawing.Color.White
        Me.dgContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgContenedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgContenedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContenedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.EnableHeadersVisualStyles = False
        Me.dgContenedor.Location = New System.Drawing.Point(15, 23)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(1637, 491)
        Me.dgContenedor.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 23)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Centros"
        '
        'cbCentro_usuario
        '
        Me.cbCentro_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCentro_usuario.FormattingEnabled = True
        Me.cbCentro_usuario.Location = New System.Drawing.Point(16, 49)
        Me.cbCentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCentro_usuario.Name = "cbCentro_usuario"
        Me.cbCentro_usuario.Size = New System.Drawing.Size(140, 24)
        Me.cbCentro_usuario.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.reimprimir, Me.ver_imagen, Me.cambiar_estado, Me.ver_firma, Me.enviar_correo, Me.descargar, Me.modificarfecha, Me.est_anterior, Me.subirmodificado, Me.resubirest})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(261, 244)
        '
        'reimprimir
        '
        Me.reimprimir.Name = "reimprimir"
        Me.reimprimir.Size = New System.Drawing.Size(260, 24)
        Me.reimprimir.Text = "Reimprimir"
        '
        'ver_imagen
        '
        Me.ver_imagen.Name = "ver_imagen"
        Me.ver_imagen.Size = New System.Drawing.Size(260, 24)
        Me.ver_imagen.Text = "Visualizar estudio"
        '
        'cambiar_estado
        '
        Me.cambiar_estado.Name = "cambiar_estado"
        Me.cambiar_estado.Size = New System.Drawing.Size(260, 24)
        Me.cambiar_estado.Text = "Quitar firma"
        '
        'ver_firma
        '
        Me.ver_firma.CheckOnClick = True
        Me.ver_firma.Name = "ver_firma"
        Me.ver_firma.Size = New System.Drawing.Size(260, 24)
        Me.ver_firma.Text = "Visualizar firma en informe"
        '
        'enviar_correo
        '
        Me.enviar_correo.Name = "enviar_correo"
        Me.enviar_correo.Size = New System.Drawing.Size(260, 24)
        Me.enviar_correo.Text = "Enviar por correo"
        '
        'descargar
        '
        Me.descargar.Name = "descargar"
        Me.descargar.Size = New System.Drawing.Size(260, 24)
        Me.descargar.Text = "Descargar estudio"
        '
        'modificarfecha
        '
        Me.modificarfecha.Name = "modificarfecha"
        Me.modificarfecha.Size = New System.Drawing.Size(260, 24)
        Me.modificarfecha.Text = "Modificar Fecha de entrega"
        '
        'est_anterior
        '
        Me.est_anterior.Name = "est_anterior"
        Me.est_anterior.Size = New System.Drawing.Size(260, 24)
        Me.est_anterior.Text = "Estudio anterior"
        '
        'subirmodificado
        '
        Me.subirmodificado.Name = "subirmodificado"
        Me.subirmodificado.Size = New System.Drawing.Size(260, 24)
        Me.subirmodificado.Text = "Estudio modificado"
        '
        'resubirest
        '
        Me.resubirest.Name = "resubirest"
        Me.resubirest.Size = New System.Drawing.Size(260, 24)
        Me.resubirest.Text = "Resubir estudio"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblcant})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 664)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1708, 25)
        Me.StatusStrip1.TabIndex = 59
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(151, 20)
        Me.ToolStripStatusLabel1.Text = "Cantidad de registros"
        '
        'lblcant
        '
        Me.lblcant.BackColor = System.Drawing.SystemColors.Control
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(17, 20)
        Me.lblcant.Text = "0"
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(44, 106)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 61
        Me.txtidtemp.Visible = False
        '
        'txtidcentro_usuario
        '
        Me.txtidcentro_usuario.Location = New System.Drawing.Point(16, 106)
        Me.txtidcentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_usuario.Name = "txtidcentro_usuario"
        Me.txtidcentro_usuario.Size = New System.Drawing.Size(19, 22)
        Me.txtidcentro_usuario.TabIndex = 60
        Me.txtidcentro_usuario.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.BackgroundImage = Global.osiris.My.Resources.Resources.imprimir
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(1340, 62)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(32, 29)
        Me.btnImprimir.TabIndex = 62
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'busqueda_informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1708, 689)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.txtidcentro_usuario)
        Me.Controls.Add(Me.txtidmedico)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbCentro_usuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "busqueda_informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de informe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txthasta As DateTimePicker
    Friend WithEvents txtdesde As DateTimePicker
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtci As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents txtmedico As TextBox
    Friend WithEvents txtidmedico As TextBox
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtprueba As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents btnactualizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCentro_usuario As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents reimprimir As ToolStripMenuItem
    Friend WithEvents ver_imagen As ToolStripMenuItem
    Friend WithEvents cambiar_estado As ToolStripMenuItem
    Friend WithEvents ver_firma As ToolStripMenuItem
    Friend WithEvents enviar_correo As ToolStripMenuItem
    Friend WithEvents descargar As ToolStripMenuItem
    Friend WithEvents modificarfecha As ToolStripMenuItem
    Friend WithEvents est_anterior As ToolStripMenuItem
    Friend WithEvents subirmodificado As ToolStripMenuItem
    Friend WithEvents resubirest As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblcant As ToolStripStatusLabel
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents txtidcentro_usuario As TextBox
    Friend WithEvents primerApellido As CheckBox
    Friend WithEvents porMedico As CheckBox
    Friend WithEvents btnImprimir As Button
End Class
