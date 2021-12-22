<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adjuntos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adjuntos))
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblestado1 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.lblprogreso = New System.Windows.Forms.Label()
        Me.comprimir = New System.ComponentModel.BackgroundWorker()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidadjunto1 = New System.Windows.Forms.TextBox()
        Me.txtidantecedente = New System.Windows.Forms.TextBox()
        Me.dgadjuntos = New System.Windows.Forms.DataGridView()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.lbadjunto = New System.Windows.Forms.Label()
        Me.cbtipoarchivo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idadjunto = New System.Windows.Forms.Label()
        Me.txtarchivo = New System.Windows.Forms.TextBox()
        Me.btndescargar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgadjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(13, 75)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(33, 22)
        Me.txtidestudio.TabIndex = 32
        Me.txtidestudio.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(171, 271)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(178, 44)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "SUBIR ARCHIVO"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblestado1
        '
        Me.lblestado1.AutoSize = True
        Me.lblestado1.ForeColor = System.Drawing.Color.White
        Me.lblestado1.Location = New System.Drawing.Point(394, 230)
        Me.lblestado1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestado1.Name = "lblestado1"
        Me.lblestado1.Size = New System.Drawing.Size(51, 17)
        Me.lblestado1.TabIndex = 54
        Me.lblestado1.Text = "estado"
        Me.lblestado1.Visible = False
        '
        'btnSubir
        '
        Me.btnSubir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubir.FlatAppearance.BorderSize = 0
        Me.btnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubir.ForeColor = System.Drawing.Color.White
        Me.btnSubir.Location = New System.Drawing.Point(824, 149)
        Me.btnSubir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(233, 46)
        Me.btnSubir.TabIndex = 59
        Me.btnSubir.Text = "SUBIR ESTUDIO ANTERIOR"
        Me.btnSubir.UseVisualStyleBackColor = False
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.ForeColor = System.Drawing.Color.White
        Me.lbldireccion.Location = New System.Drawing.Point(568, 9)
        Me.lbldireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(70, 17)
        Me.lbldireccion.TabIndex = 60
        Me.lbldireccion.Text = "Ubicación"
        Me.lbldireccion.Visible = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.ForeColor = System.Drawing.Color.White
        Me.lblinforme.Location = New System.Drawing.Point(523, 149)
        Me.lblinforme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(55, 17)
        Me.lblinforme.TabIndex = 61
        Me.lblinforme.Text = "informe"
        Me.lblinforme.Visible = False
        '
        'lblprogreso
        '
        Me.lblprogreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblprogreso.AutoSize = True
        Me.lblprogreso.BackColor = System.Drawing.Color.Transparent
        Me.lblprogreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogreso.ForeColor = System.Drawing.Color.White
        Me.lblprogreso.Location = New System.Drawing.Point(568, 204)
        Me.lblprogreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprogreso.Name = "lblprogreso"
        Me.lblprogreso.Size = New System.Drawing.Size(86, 24)
        Me.lblprogreso.TabIndex = 63
        Me.lblprogreso.Text = "progreso"
        Me.lblprogreso.Visible = False
        '
        'comprimir
        '
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
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContenedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.EnableHeadersVisualStyles = False
        Me.dgContenedor.Location = New System.Drawing.Point(572, 246)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(416, 278)
        Me.dgContenedor.TabIndex = 64
        '
        'lblpaciente
        '
        Me.lblpaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblpaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaciente.ForeColor = System.Drawing.Color.White
        Me.lblpaciente.Location = New System.Drawing.Point(13, 9)
        Me.lblpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(83, 24)
        Me.lblpaciente.TabIndex = 65
        Me.lblpaciente.Text = "Paciente"
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Location = New System.Drawing.Point(718, 52)
        Me.txtobs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(339, 89)
        Me.txtobs.TabIndex = 67
        Me.txtobs.Text = "SIN OBSERVACIONES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(718, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Observación"
        '
        'txtidadjunto1
        '
        Me.txtidadjunto1.Location = New System.Drawing.Point(13, 45)
        Me.txtidadjunto1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidadjunto1.Name = "txtidadjunto1"
        Me.txtidadjunto1.Size = New System.Drawing.Size(33, 22)
        Me.txtidadjunto1.TabIndex = 71
        Me.txtidadjunto1.Visible = False
        '
        'txtidantecedente
        '
        Me.txtidantecedente.Location = New System.Drawing.Point(811, 18)
        Me.txtidantecedente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidantecedente.Name = "txtidantecedente"
        Me.txtidantecedente.Size = New System.Drawing.Size(33, 22)
        Me.txtidantecedente.TabIndex = 75
        Me.txtidantecedente.Visible = False
        '
        'dgadjuntos
        '
        Me.dgadjuntos.AllowUserToAddRows = False
        Me.dgadjuntos.AllowUserToDeleteRows = False
        Me.dgadjuntos.AllowUserToResizeRows = False
        Me.dgadjuntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgadjuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgadjuntos.BackgroundColor = System.Drawing.Color.White
        Me.dgadjuntos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgadjuntos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgadjuntos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgadjuntos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgadjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgadjuntos.EnableHeadersVisualStyles = False
        Me.dgadjuntos.Location = New System.Drawing.Point(32, 335)
        Me.dgadjuntos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgadjuntos.Name = "dgadjuntos"
        Me.dgadjuntos.ReadOnly = True
        Me.dgadjuntos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgadjuntos.RowHeadersVisible = False
        Me.dgadjuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgadjuntos.Size = New System.Drawing.Size(471, 189)
        Me.dgadjuntos.TabIndex = 76
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.Crimson
        Me.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrar.FlatAppearance.BorderSize = 0
        Me.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.ForeColor = System.Drawing.Color.White
        Me.btnborrar.Location = New System.Drawing.Point(261, 271)
        Me.btnborrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(88, 44)
        Me.btnborrar.TabIndex = 77
        Me.btnborrar.Text = "QUITAR"
        Me.btnborrar.UseVisualStyleBackColor = False
        Me.btnborrar.Visible = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.FlatAppearance.BorderSize = 0
        Me.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo.Location = New System.Drawing.Point(171, 271)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(88, 44)
        Me.btn_nuevo.TabIndex = 78
        Me.btn_nuevo.Text = "NUEVO"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        Me.btn_nuevo.Visible = False
        '
        'lbadjunto
        '
        Me.lbadjunto.AutoSize = True
        Me.lbadjunto.ForeColor = System.Drawing.Color.White
        Me.lbadjunto.Location = New System.Drawing.Point(190, 204)
        Me.lbadjunto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbadjunto.Name = "lbadjunto"
        Me.lbadjunto.Size = New System.Drawing.Size(55, 17)
        Me.lbadjunto.TabIndex = 79
        Me.lbadjunto.Text = "adjunto"
        Me.lbadjunto.Visible = False
        '
        'cbtipoarchivo
        '
        Me.cbtipoarchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbtipoarchivo.FormattingEnabled = True
        Me.cbtipoarchivo.Location = New System.Drawing.Point(224, 227)
        Me.cbtipoarchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbtipoarchivo.Name = "cbtipoarchivo"
        Me.cbtipoarchivo.Size = New System.Drawing.Size(162, 24)
        Me.cbtipoarchivo.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(106, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Tipo de archivo:"
        '
        'idadjunto
        '
        Me.idadjunto.AutoSize = True
        Me.idadjunto.ForeColor = System.Drawing.Color.White
        Me.idadjunto.Location = New System.Drawing.Point(203, 45)
        Me.idadjunto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idadjunto.Name = "idadjunto"
        Me.idadjunto.Size = New System.Drawing.Size(29, 17)
        Me.idadjunto.TabIndex = 82
        Me.idadjunto.Text = "nro"
        Me.idadjunto.Visible = False
        '
        'txtarchivo
        '
        Me.txtarchivo.Location = New System.Drawing.Point(852, 18)
        Me.txtarchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtarchivo.Name = "txtarchivo"
        Me.txtarchivo.Size = New System.Drawing.Size(33, 22)
        Me.txtarchivo.TabIndex = 83
        Me.txtarchivo.Visible = False
        '
        'btndescargar
        '
        Me.btndescargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndescargar.FlatAppearance.BorderSize = 0
        Me.btndescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescargar.ForeColor = System.Drawing.Color.White
        Me.btndescargar.Image = CType(resources.GetObject("btndescargar.Image"), System.Drawing.Image)
        Me.btndescargar.Location = New System.Drawing.Point(996, 451)
        Me.btndescargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btndescargar.Name = "btndescargar"
        Me.btndescargar.Size = New System.Drawing.Size(86, 73)
        Me.btndescargar.TabIndex = 84
        Me.btndescargar.UseVisualStyleBackColor = False
        Me.btndescargar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.osiris.My.Resources.Resources.skeleton1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(605, 49)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close
        Me.btncerrar.Location = New System.Drawing.Point(1055, 15)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(27, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 52
        Me.btncerrar.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackgroundImage = CType(resources.GetObject("pb1.BackgroundImage"), System.Drawing.Image)
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb1.Location = New System.Drawing.Point(171, 71)
        Me.pb1.Margin = New System.Windows.Forms.Padding(4)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(168, 128)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 20
        Me.pb1.TabStop = False
        '
        'adjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1097, 561)
        Me.Controls.Add(Me.btndescargar)
        Me.Controls.Add(Me.txtarchivo)
        Me.Controls.Add(Me.idadjunto)
        Me.Controls.Add(Me.cbtipoarchivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbadjunto)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.dgadjuntos)
        Me.Controls.Add(Me.txtidantecedente)
        Me.Controls.Add(Me.txtidadjunto1)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.dgContenedor)
        Me.Controls.Add(Me.lblprogreso)
        Me.Controls.Add(Me.lblinforme)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.btnSubir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblestado1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.pb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adjuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar adjuntos"
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgadjuntos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents txtidestudio As TextBox
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblestado1 As Label
    Friend WithEvents dlg As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSubir As Button
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblinforme As Label
    Friend WithEvents lblprogreso As Label
    Friend WithEvents comprimir As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents lblpaciente As Label
    Friend WithEvents txtobs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtidadjunto1 As TextBox
    Friend WithEvents txtidantecedente As TextBox
    Friend WithEvents dgadjuntos As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents lbadjunto As Label
    Friend WithEvents cbtipoarchivo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents idadjunto As Label
    Friend WithEvents txtarchivo As TextBox
    Friend WithEvents btndescargar As Button
End Class
