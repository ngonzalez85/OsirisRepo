<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class misfirmas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(misfirmas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgEstudios = New System.Windows.Forms.DataGridView()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblcant = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCentro_usuario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.reimprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ver_imagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.cambiar_estado = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtlike = New System.Windows.Forms.TextBox()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.txtidcentro_usuario = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgEstudios)
        Me.GroupBox1.Controls.Add(Me.rtb1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1272, 387)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de estudios"
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
        Me.dgEstudios.EnableHeadersVisualStyles = False
        Me.dgEstudios.Location = New System.Drawing.Point(17, 22)
        Me.dgEstudios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEstudios.Name = "dgEstudios"
        Me.dgEstudios.ReadOnly = True
        Me.dgEstudios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgEstudios.RowHeadersVisible = False
        Me.dgEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstudios.Size = New System.Drawing.Size(1237, 358)
        Me.dgEstudios.TabIndex = 1
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(806, 291)
        Me.rtb1.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(132, 117)
        Me.rtb1.TabIndex = 70
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'txtprueba
        '
        Me.txtprueba.Location = New System.Drawing.Point(1125, 307)
        Me.txtprueba.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprueba.Name = "txtprueba"
        Me.txtprueba.Size = New System.Drawing.Size(67, 22)
        Me.txtprueba.TabIndex = 71
        Me.txtprueba.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblcant})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1296, 25)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 16)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Centros"
        '
        'cbCentro_usuario
        '
        Me.cbCentro_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCentro_usuario.FormattingEnabled = True
        Me.cbCentro_usuario.Location = New System.Drawing.Point(82, 13)
        Me.cbCentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCentro_usuario.Name = "cbCentro_usuario"
        Me.cbCentro_usuario.Size = New System.Drawing.Size(140, 24)
        Me.cbCentro_usuario.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "al"
        '
        'txthasta
        '
        Me.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txthasta.Location = New System.Drawing.Point(499, 18)
        Me.txthasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.Size = New System.Drawing.Size(111, 22)
        Me.txthasta.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Fecha de Firma"
        '
        'txtdesde
        '
        Me.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdesde.Location = New System.Drawing.Point(351, 18)
        Me.txtdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(113, 22)
        Me.txtdesde.TabIndex = 63
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.reimprimir, Me.ver_imagen, Me.cambiar_estado, Me.modificado})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(209, 100)
        '
        'reimprimir
        '
        Me.reimprimir.Name = "reimprimir"
        Me.reimprimir.Size = New System.Drawing.Size(208, 24)
        Me.reimprimir.Text = "Reimprimir"
        '
        'ver_imagen
        '
        Me.ver_imagen.Name = "ver_imagen"
        Me.ver_imagen.Size = New System.Drawing.Size(208, 24)
        Me.ver_imagen.Text = "Visualizar estudio"
        '
        'cambiar_estado
        '
        Me.cambiar_estado.Name = "cambiar_estado"
        Me.cambiar_estado.Size = New System.Drawing.Size(208, 24)
        Me.cambiar_estado.Text = "Editar Informe"
        '
        'modificado
        '
        Me.modificado.Name = "modificado"
        Me.modificado.Size = New System.Drawing.Size(208, 24)
        Me.modificado.Text = "Estudio Modificado"
        '
        'txtlike
        '
        Me.txtlike.Location = New System.Drawing.Point(1089, 23)
        Me.txtlike.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlike.Name = "txtlike"
        Me.txtlike.Size = New System.Drawing.Size(19, 22)
        Me.txtlike.TabIndex = 69
        Me.txtlike.Visible = False
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(1143, 23)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 68
        Me.txtidtemp.Visible = False
        '
        'txtidcentro_usuario
        '
        Me.txtidcentro_usuario.Location = New System.Drawing.Point(1116, 23)
        Me.txtidcentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_usuario.Name = "txtidcentro_usuario"
        Me.txtidcentro_usuario.Size = New System.Drawing.Size(19, 22)
        Me.txtidcentro_usuario.TabIndex = 67
        Me.txtidcentro_usuario.Visible = False
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
        Me.btnactualizar.Location = New System.Drawing.Point(1187, 13)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(40, 37)
        Me.btnactualizar.TabIndex = 66
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel10.Location = New System.Drawing.Point(682, 38)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(278, 4)
        Me.Panel10.TabIndex = 73
        '
        'txtbuscar
        '
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Location = New System.Drawing.Point(682, 20)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(246, 15)
        Me.txtbuscar.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(618, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Buscar:"
        '
        'misfirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1296, 492)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.txtprueba)
        Me.Controls.Add(Me.txtlike)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.txtidcentro_usuario)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesde)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbCentro_usuario)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "misfirmas"
        Me.Text = "FIRMAS DEL DIA"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgEstudios As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblcant As ToolStripStatusLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCentro_usuario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txthasta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdesde As DateTimePicker
    Friend WithEvents btnactualizar As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents reimprimir As ToolStripMenuItem
    Friend WithEvents ver_imagen As ToolStripMenuItem
    Friend WithEvents cambiar_estado As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtlike As TextBox
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents txtidcentro_usuario As TextBox
    Friend WithEvents txtprueba As TextBox
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents modificado As ToolStripMenuItem
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label3 As Label
End Class
