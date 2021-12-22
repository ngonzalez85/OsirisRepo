<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tipo_estudio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tipo_estudio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.txtidtipoestudio = New System.Windows.Forms.TextBox()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.txttipoestudio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbmodalidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidmodalidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidmodalidad)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cbmodalidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dgContenedor)
        Me.GroupBox1.Controls.Add(Me.txtidtipoestudio)
        Me.GroupBox1.Controls.Add(Me.btnaccion)
        Me.GroupBox1.Controls.Add(Me.txttipoestudio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 389)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de tipos de estudio"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnlimpiar.BackgroundImage = Global.osiris.My.Resources.Resources.eraser
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(278, 34)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(30, 30)
        Me.btnlimpiar.TabIndex = 10
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(16, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 3)
        Me.Panel2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.osiris.My.Resources.Resources.borrar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(32, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "QUITAR"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
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
        Me.dgContenedor.Location = New System.Drawing.Point(16, 203)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(282, 169)
        Me.dgContenedor.TabIndex = 6
        '
        'txtidtipoestudio
        '
        Me.txtidtipoestudio.Location = New System.Drawing.Point(212, 19)
        Me.txtidtipoestudio.Name = "txtidtipoestudio"
        Me.txtidtipoestudio.Size = New System.Drawing.Size(23, 20)
        Me.txtidtipoestudio.TabIndex = 1
        Me.txtidtipoestudio.Visible = False
        '
        'btnaccion
        '
        Me.btnaccion.BackColor = System.Drawing.Color.Silver
        Me.btnaccion.FlatAppearance.BorderSize = 0
        Me.btnaccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaccion.ForeColor = System.Drawing.Color.White
        Me.btnaccion.Image = Global.osiris.My.Resources.Resources.floppy_disk
        Me.btnaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaccion.Location = New System.Drawing.Point(157, 135)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(115, 47)
        Me.btnaccion.TabIndex = 5
        Me.btnaccion.Text = "GUARDAR"
        Me.btnaccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaccion.UseVisualStyleBackColor = False
        '
        'txttipoestudio
        '
        Me.txttipoestudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttipoestudio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttipoestudio.Location = New System.Drawing.Point(16, 43)
        Me.txttipoestudio.Name = "txttipoestudio"
        Me.txttipoestudio.Size = New System.Drawing.Size(256, 13)
        Me.txttipoestudio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción del tipo de estudio"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(16, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 3)
        Me.Panel1.TabIndex = 13
        '
        'cbmodalidad
        '
        Me.cbmodalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmodalidad.FormattingEnabled = True
        Me.cbmodalidad.Location = New System.Drawing.Point(16, 91)
        Me.cbmodalidad.Name = "cbmodalidad"
        Me.cbmodalidad.Size = New System.Drawing.Size(256, 21)
        Me.cbmodalidad.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Modalidad"
        '
        'txtidmodalidad
        '
        Me.txtidmodalidad.Location = New System.Drawing.Point(241, 20)
        Me.txtidmodalidad.Name = "txtidmodalidad"
        Me.txtidmodalidad.Size = New System.Drawing.Size(23, 20)
        Me.txtidmodalidad.TabIndex = 14
        Me.txtidmodalidad.Visible = False
        '
        'tipo_estudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(337, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tipo_estudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de estudio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents txtidtipoestudio As TextBox
    Friend WithEvents btnaccion As Button
    Friend WithEvents txttipoestudio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtidmodalidad As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbmodalidad As ComboBox
    Friend WithEvents Label2 As Label
End Class
