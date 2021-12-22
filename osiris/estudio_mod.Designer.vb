<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estudio_mod
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(estudio_mod))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.btndescargar = New System.Windows.Forms.Button()
        Me.txtarchivo = New System.Windows.Forms.TextBox()
        Me.txtidmodificado = New System.Windows.Forms.TextBox()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.lblprogreso = New System.Windows.Forms.Label()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.comprimir = New System.ComponentModel.BackgroundWorker()
        Me.dlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close
        Me.btncerrar.Location = New System.Drawing.Point(633, 13)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(27, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 53
        Me.btncerrar.TabStop = False
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
        Me.btndescargar.Location = New System.Drawing.Point(582, 489)
        Me.btndescargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btndescargar.Name = "btndescargar"
        Me.btndescargar.Size = New System.Drawing.Size(86, 73)
        Me.btndescargar.TabIndex = 95
        Me.btndescargar.UseVisualStyleBackColor = False
        Me.btndescargar.Visible = False
        '
        'txtarchivo
        '
        Me.txtarchivo.Location = New System.Drawing.Point(560, 66)
        Me.txtarchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtarchivo.Name = "txtarchivo"
        Me.txtarchivo.Size = New System.Drawing.Size(33, 22)
        Me.txtarchivo.TabIndex = 94
        Me.txtarchivo.Visible = False
        '
        'txtidmodificado
        '
        Me.txtidmodificado.Location = New System.Drawing.Point(560, 123)
        Me.txtidmodificado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmodificado.Name = "txtidmodificado"
        Me.txtidmodificado.Size = New System.Drawing.Size(33, 22)
        Me.txtidmodificado.TabIndex = 93
        Me.txtidmodificado.Visible = False
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Location = New System.Drawing.Point(152, 69)
        Me.txtobs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(403, 89)
        Me.txtobs.TabIndex = 92
        Me.txtobs.Text = "SIN OBSERVACIONES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(333, 66)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Observación"
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
        Me.dgContenedor.Location = New System.Drawing.Point(44, 284)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(530, 278)
        Me.dgContenedor.TabIndex = 90
        '
        'lblprogreso
        '
        Me.lblprogreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblprogreso.AutoSize = True
        Me.lblprogreso.BackColor = System.Drawing.Color.Transparent
        Me.lblprogreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogreso.ForeColor = System.Drawing.Color.White
        Me.lblprogreso.Location = New System.Drawing.Point(40, 245)
        Me.lblprogreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprogreso.Name = "lblprogreso"
        Me.lblprogreso.Size = New System.Drawing.Size(86, 24)
        Me.lblprogreso.TabIndex = 89
        Me.lblprogreso.Text = "progreso"
        Me.lblprogreso.Visible = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.ForeColor = System.Drawing.Color.White
        Me.lblinforme.Location = New System.Drawing.Point(41, 171)
        Me.lblinforme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(55, 17)
        Me.lblinforme.TabIndex = 88
        Me.lblinforme.Text = "informe"
        Me.lblinforme.Visible = False
        '
        'btnSubir
        '
        Me.btnSubir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubir.FlatAppearance.BorderSize = 0
        Me.btnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubir.ForeColor = System.Drawing.Color.White
        Me.btnSubir.Location = New System.Drawing.Point(322, 171)
        Me.btnSubir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(233, 46)
        Me.btnSubir.TabIndex = 87
        Me.btnSubir.Text = "SUBIR ESTUDIO MODIFICADO"
        Me.btnSubir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.osiris.My.Resources.Resources.skeleton1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(39, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
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
        Me.lblpaciente.TabIndex = 96
        Me.lblpaciente.Text = "Paciente"
        '
        'comprimir
        '
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.ForeColor = System.Drawing.Color.White
        Me.lbldireccion.Location = New System.Drawing.Point(41, 45)
        Me.lbldireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(70, 17)
        Me.lbldireccion.TabIndex = 97
        Me.lbldireccion.Text = "Ubicación"
        Me.lbldireccion.Visible = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(560, 93)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(33, 22)
        Me.txtidestudio.TabIndex = 98
        Me.txtidestudio.Visible = False
        '
        'estudio_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 595)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.btndescargar)
        Me.Controls.Add(Me.txtarchivo)
        Me.Controls.Add(Me.txtidmodificado)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgContenedor)
        Me.Controls.Add(Me.lblprogreso)
        Me.Controls.Add(Me.lblinforme)
        Me.Controls.Add(Me.btnSubir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estudio_mod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudio Modificado"
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents btndescargar As Button
    Friend WithEvents txtarchivo As TextBox
    Friend WithEvents txtidmodificado As TextBox
    Friend WithEvents txtobs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents lblprogreso As Label
    Friend WithEvents lblinforme As Label
    Friend WithEvents btnSubir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpaciente As Label
    Friend WithEvents comprimir As System.ComponentModel.BackgroundWorker
    Friend WithEvents dlg As FolderBrowserDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbldireccion As Label
    Friend WithEvents txtidestudio As TextBox
End Class
