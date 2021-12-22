<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pago_detallado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pago_detallado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblcant = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbbuscar = New System.Windows.Forms.ComboBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.ver_firma = New System.Windows.Forms.ToolStripMenuItem()
        Me.cambiar_estado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ver_imagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.reimprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.informe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.dgEstudios = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.txtlike = New System.Windows.Forms.TextBox()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.cbfiltrado = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel10.Location = New System.Drawing.Point(288, 34)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(467, 4)
        Me.Panel10.TabIndex = 81
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
        Me.btnImprimir.Location = New System.Drawing.Point(963, 8)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(40, 37)
        Me.btnImprimir.TabIndex = 80
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblcant
        '
        Me.lblcant.BackColor = System.Drawing.SystemColors.Control
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(17, 20)
        Me.lblcant.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(151, 20)
        Me.ToolStripStatusLabel1.Text = "Cantidad de registros"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblcant, Me.ToolStripStatusLabel2, Me.lbltotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 664)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1592, 25)
        Me.StatusStrip1.TabIndex = 79
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(88, 20)
        Me.ToolStripStatusLabel2.Text = "Monto total"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.SystemColors.Control
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(17, 20)
        Me.lbltotal.Text = "0"
        '
        'txtbuscar
        '
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Location = New System.Drawing.Point(288, 13)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(467, 15)
        Me.txtbuscar.TabIndex = 74
        '
        'cbbuscar
        '
        Me.cbbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbuscar.FormattingEnabled = True
        Me.cbbuscar.Items.AddRange(New Object() {"PACIENTE", "ESTUDIO", "ESTADO", "MEDICO"})
        Me.cbbuscar.Location = New System.Drawing.Point(101, 14)
        Me.cbbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbuscar.Name = "cbbuscar"
        Me.cbbuscar.Size = New System.Drawing.Size(160, 24)
        Me.cbbuscar.TabIndex = 72
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
        Me.btnactualizar.Location = New System.Drawing.Point(1011, 6)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(40, 37)
        Me.btnactualizar.TabIndex = 76
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'ver_firma
        '
        Me.ver_firma.CheckOnClick = True
        Me.ver_firma.Name = "ver_firma"
        Me.ver_firma.Size = New System.Drawing.Size(256, 24)
        Me.ver_firma.Text = "Visualizar firma en informe"
        '
        'cambiar_estado
        '
        Me.cambiar_estado.Name = "cambiar_estado"
        Me.cambiar_estado.Size = New System.Drawing.Size(256, 24)
        Me.cambiar_estado.Text = "Quitar firma"
        '
        'ver_imagen
        '
        Me.ver_imagen.Name = "ver_imagen"
        Me.ver_imagen.Size = New System.Drawing.Size(256, 24)
        Me.ver_imagen.Text = "Visualizar estudio"
        '
        'reimprimir
        '
        Me.reimprimir.Name = "reimprimir"
        Me.reimprimir.Size = New System.Drawing.Size(256, 24)
        Me.reimprimir.Text = "Reimprimir"
        '
        'informe
        '
        Me.informe.Name = "informe"
        Me.informe.Size = New System.Drawing.Size(256, 24)
        Me.informe.Text = "Ver informe (PDF)"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.informe, Me.reimprimir, Me.ver_imagen, Me.cambiar_estado, Me.ver_firma})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(257, 124)
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
        Me.dgEstudios.Size = New System.Drawing.Size(1521, 544)
        Me.dgEstudios.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgEstudios)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 53)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1560, 588)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Filtrar por"
        '
        'txthasta
        '
        Me.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txthasta.Location = New System.Drawing.Point(552, 64)
        Me.txthasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.Size = New System.Drawing.Size(129, 22)
        Me.txthasta.TabIndex = 83
        '
        'txtdesde
        '
        Me.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdesde.Location = New System.Drawing.Point(385, 64)
        Me.txtdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(129, 22)
        Me.txtdesde.TabIndex = 82
        '
        'txtlike
        '
        Me.txtlike.Location = New System.Drawing.Point(1101, 21)
        Me.txtlike.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlike.Name = "txtlike"
        Me.txtlike.Size = New System.Drawing.Size(19, 22)
        Me.txtlike.TabIndex = 84
        Me.txtlike.Visible = False
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(1129, 21)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 85
        Me.txtidtemp.Visible = False
        '
        'cbfiltrado
        '
        Me.cbfiltrado.AutoSize = True
        Me.cbfiltrado.Location = New System.Drawing.Point(784, 12)
        Me.cbfiltrado.Name = "cbfiltrado"
        Me.cbfiltrado.Size = New System.Drawing.Size(77, 21)
        Me.cbfiltrado.TabIndex = 86
        Me.cbfiltrado.Text = "Filtrado"
        Me.cbfiltrado.UseVisualStyleBackColor = True
        '
        'pago_detallado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1592, 689)
        Me.Controls.Add(Me.cbfiltrado)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.txtlike)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cbbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txthasta)
        Me.Controls.Add(Me.txtdesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pago_detallado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte detallado"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents lblcant As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbbuscar As ComboBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents ver_firma As ToolStripMenuItem
    Friend WithEvents cambiar_estado As ToolStripMenuItem
    Friend WithEvents ver_imagen As ToolStripMenuItem
    Friend WithEvents reimprimir As ToolStripMenuItem
    Friend WithEvents informe As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents dgEstudios As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txthasta As DateTimePicker
    Friend WithEvents txtdesde As DateTimePicker
    Friend WithEvents txtlike As TextBox
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lbltotal As ToolStripStatusLabel
    Friend WithEvents cbfiltrado As CheckBox
End Class
