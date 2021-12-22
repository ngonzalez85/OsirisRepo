<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busqueda_estudios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busqueda_estudios))
        Me.txtidcentro_usuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCentro_usuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.dgEstudios = New System.Windows.Forms.DataGridView()
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
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbuscar = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtlike = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblcant = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbEstudio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtidcentro_usuario
        '
        Me.txtidcentro_usuario.Location = New System.Drawing.Point(1480, 27)
        Me.txtidcentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_usuario.Name = "txtidcentro_usuario"
        Me.txtidcentro_usuario.Size = New System.Drawing.Size(19, 22)
        Me.txtidcentro_usuario.TabIndex = 8
        Me.txtidcentro_usuario.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Centros"
        '
        'cbCentro_usuario
        '
        Me.cbCentro_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCentro_usuario.FormattingEnabled = True
        Me.cbCentro_usuario.Location = New System.Drawing.Point(72, 17)
        Me.cbCentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCentro_usuario.Name = "cbCentro_usuario"
        Me.cbCentro_usuario.Size = New System.Drawing.Size(140, 24)
        Me.cbCentro_usuario.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtprueba)
        Me.GroupBox2.Controls.Add(Me.rtb1)
        Me.GroupBox2.Controls.Add(Me.dgEstudios)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 57)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1636, 588)
        Me.GroupBox2.TabIndex = 9
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
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(1448, 463)
        Me.rtb1.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(132, 117)
        Me.rtb1.TabIndex = 9
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
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
        Me.dgEstudios.Size = New System.Drawing.Size(1597, 544)
        Me.dgEstudios.TabIndex = 0
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
        'txtdesde
        '
        Me.txtdesde.Checked = False
        Me.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdesde.Location = New System.Drawing.Point(413, 18)
        Me.txtdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(113, 22)
        Me.txtdesde.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de subida"
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(1508, 27)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 56
        Me.txtidtemp.Visible = False
        '
        'txthasta
        '
        Me.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txthasta.Location = New System.Drawing.Point(561, 18)
        Me.txthasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.Size = New System.Drawing.Size(111, 22)
        Me.txthasta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "al"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(680, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filtrar por:"
        '
        'cbbuscar
        '
        Me.cbbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbuscar.FormattingEnabled = True
        Me.cbbuscar.Items.AddRange(New Object() {"PACIENTE", "ESTUDIO", "ESTADO", "MEDICO", "TECNICO", "CEDULA"})
        Me.cbbuscar.Location = New System.Drawing.Point(761, 17)
        Me.cbbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbuscar.Name = "cbbuscar"
        Me.cbbuscar.Size = New System.Drawing.Size(127, 24)
        Me.cbbuscar.TabIndex = 7
        '
        'txtbuscar
        '
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Location = New System.Drawing.Point(1233, 18)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(246, 15)
        Me.txtbuscar.TabIndex = 8
        '
        'txtlike
        '
        Me.txtlike.Location = New System.Drawing.Point(1452, 27)
        Me.txtlike.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlike.Name = "txtlike"
        Me.txtlike.Size = New System.Drawing.Size(19, 22)
        Me.txtlike.TabIndex = 57
        Me.txtlike.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblcant})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 664)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1668, 25)
        Me.StatusStrip1.TabIndex = 58
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
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel10.Location = New System.Drawing.Point(1233, 36)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(259, 4)
        Me.Panel10.TabIndex = 64
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(219, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 21)
        Me.CheckBox1.TabIndex = 65
        Me.CheckBox1.Text = "Filtrar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbEstudio
        '
        Me.cbEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEstudio.FormattingEnabled = True
        Me.cbEstudio.Items.AddRange(New Object() {"TODOS"})
        Me.cbEstudio.Location = New System.Drawing.Point(980, 16)
        Me.cbEstudio.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstudio.Name = "cbEstudio"
        Me.cbEstudio.Size = New System.Drawing.Size(245, 24)
        Me.cbEstudio.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(896, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "T. Estudio:"
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
        Me.btnImprimir.Location = New System.Drawing.Point(1503, 8)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(32, 29)
        Me.btnImprimir.TabIndex = 59
        Me.btnImprimir.UseVisualStyleBackColor = False
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
        Me.btnactualizar.Location = New System.Drawing.Point(1537, 4)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(40, 37)
        Me.btnactualizar.TabIndex = 9
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'busqueda_estudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1668, 689)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbEstudio)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtlike)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cbbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthasta)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesde)
        Me.Controls.Add(Me.txtidcentro_usuario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbCentro_usuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "busqueda_estudios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de informes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidcentro_usuario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCentro_usuario As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgEstudios As DataGridView
    Friend WithEvents txtdesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnactualizar As Button
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents txthasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbuscar As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents txtprueba As TextBox
    Friend WithEvents reimprimir As ToolStripMenuItem
    Friend WithEvents ver_imagen As ToolStripMenuItem
    Friend WithEvents txtlike As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblcant As ToolStripStatusLabel
    Friend WithEvents cambiar_estado As ToolStripMenuItem
    Friend WithEvents btnImprimir As Button
    Friend WithEvents ver_firma As ToolStripMenuItem
    Friend WithEvents Panel10 As Panel
    Friend WithEvents enviar_correo As ToolStripMenuItem
    Friend WithEvents descargar As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cbEstudio As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents modificarfecha As ToolStripMenuItem
    Friend WithEvents est_anterior As ToolStripMenuItem
    Friend WithEvents subirmodificado As ToolStripMenuItem
    Friend WithEvents resubirest As ToolStripMenuItem
End Class
