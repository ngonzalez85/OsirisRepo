<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class procedimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(procedimientos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.chkOrdenar = New System.Windows.Forms.CheckBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.txtidtipo_estudio = New System.Windows.Forms.TextBox()
        Me.cbtipo_estudio = New System.Windows.Forms.ComboBox()
        Me.txtidprocedimiento = New System.Windows.Forms.TextBox()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.txtprocedimiento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btneliminar)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.chkOrdenar)
        Me.GroupBox1.Controls.Add(Me.txtflag)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btncerrar)
        Me.GroupBox1.Controls.Add(Me.txtidtipo_estudio)
        Me.GroupBox1.Controls.Add(Me.cbtipo_estudio)
        Me.GroupBox1.Controls.Add(Me.txtidprocedimiento)
        Me.GroupBox1.Controls.Add(Me.dgContenedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnaccion)
        Me.GroupBox1.Controls.Add(Me.txtprocedimiento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de procedimiento"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Transparent
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.ForeColor = System.Drawing.Color.White
        Me.btneliminar.Image = Global.osiris.My.Resources.Resources.borrar
        Me.btneliminar.Location = New System.Drawing.Point(447, 98)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(30, 30)
        Me.btneliminar.TabIndex = 61
        Me.btneliminar.UseVisualStyleBackColor = False
        Me.btneliminar.Visible = False
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
        Me.btnImprimir.Location = New System.Drawing.Point(562, 19)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(30, 30)
        Me.btnImprimir.TabIndex = 60
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'chkOrdenar
        '
        Me.chkOrdenar.AutoSize = True
        Me.chkOrdenar.Location = New System.Drawing.Point(433, 27)
        Me.chkOrdenar.Name = "chkOrdenar"
        Me.chkOrdenar.Size = New System.Drawing.Size(123, 17)
        Me.chkOrdenar.TabIndex = 55
        Me.chkOrdenar.Text = "Ordenar por alfabeto"
        Me.chkOrdenar.UseVisualStyleBackColor = True
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(156, 13)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(23, 20)
        Me.txtflag.TabIndex = 54
        Me.txtflag.Visible = False
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
        Me.btnlimpiar.Location = New System.Drawing.Point(410, 98)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(30, 30)
        Me.btnlimpiar.TabIndex = 9
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.Location = New System.Drawing.Point(386, 103)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(18, 20)
        Me.btnagregar.TabIndex = 8
        Me.btnagregar.Text = "+"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(33, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 3)
        Me.Panel2.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(33, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 3)
        Me.Panel1.TabIndex = 4
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close_gray
        Me.btncerrar.Location = New System.Drawing.Point(605, 13)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(20, 20)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 53
        Me.btncerrar.TabStop = False
        Me.btncerrar.Visible = False
        '
        'txtidtipo_estudio
        '
        Me.txtidtipo_estudio.Location = New System.Drawing.Point(185, 13)
        Me.txtidtipo_estudio.Name = "txtidtipo_estudio"
        Me.txtidtipo_estudio.Size = New System.Drawing.Size(23, 20)
        Me.txtidtipo_estudio.TabIndex = 0
        Me.txtidtipo_estudio.Visible = False
        '
        'cbtipo_estudio
        '
        Me.cbtipo_estudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbtipo_estudio.FormattingEnabled = True
        Me.cbtipo_estudio.Location = New System.Drawing.Point(33, 103)
        Me.cbtipo_estudio.Name = "cbtipo_estudio"
        Me.cbtipo_estudio.Size = New System.Drawing.Size(347, 21)
        Me.cbtipo_estudio.TabIndex = 6
        '
        'txtidprocedimiento
        '
        Me.txtidprocedimiento.Location = New System.Drawing.Point(214, 13)
        Me.txtidprocedimiento.Name = "txtidprocedimiento"
        Me.txtidprocedimiento.Size = New System.Drawing.Size(23, 20)
        Me.txtidprocedimiento.TabIndex = 1
        Me.txtidprocedimiento.Visible = False
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
        Me.dgContenedor.Location = New System.Drawing.Point(33, 156)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(566, 171)
        Me.dgContenedor.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(30, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de estudio"
        '
        'btnaccion
        '
        Me.btnaccion.BackColor = System.Drawing.Color.Silver
        Me.btnaccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccion.FlatAppearance.BorderSize = 0
        Me.btnaccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaccion.ForeColor = System.Drawing.Color.White
        Me.btnaccion.Image = Global.osiris.My.Resources.Resources.floppy_disk
        Me.btnaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaccion.Location = New System.Drawing.Point(484, 90)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(115, 47)
        Me.btnaccion.TabIndex = 10
        Me.btnaccion.Text = "GUARDAR"
        Me.btnaccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaccion.UseVisualStyleBackColor = False
        '
        'txtprocedimiento
        '
        Me.txtprocedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprocedimiento.Location = New System.Drawing.Point(33, 55)
        Me.txtprocedimiento.Name = "txtprocedimiento"
        Me.txtprocedimiento.Size = New System.Drawing.Size(566, 13)
        Me.txtprocedimiento.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción del procedimiento"
        '
        'procedimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 370)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "procedimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidprocedimiento As TextBox
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnaccion As Button
    Friend WithEvents txtprocedimiento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidtipo_estudio As TextBox
    Friend WithEvents cbtipo_estudio As ComboBox
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtflag As TextBox
    Friend WithEvents chkOrdenar As CheckBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btneliminar As Button
End Class
