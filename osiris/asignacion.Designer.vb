<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class asignacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(asignacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkUrgente = New System.Windows.Forms.CheckBox()
        Me.txtidinforme = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        Me.txtidmedico = New System.Windows.Forms.TextBox()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEstudio = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMedico = New System.Windows.Forms.ComboBox()
        Me.txtestudio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ver_imagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.lista_estudios = New System.Windows.Forms.ToolStripMenuItem()
        Me.proceso_informe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ver_adjuntos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbcentro = New System.Windows.Forms.ComboBox()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.checkUrgente)
        Me.GroupBox1.Controls.Add(Me.txtidinforme)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtestado)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.txtidtemp)
        Me.GroupBox1.Controls.Add(Me.txtprueba)
        Me.GroupBox1.Controls.Add(Me.txtidmedico)
        Me.GroupBox1.Controls.Add(Me.txtidestudio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbEstudio)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMedico)
        Me.GroupBox1.Controls.Add(Me.txtestudio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtpaciente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 543)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1497, 164)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar a un médico informante"
        '
        'checkUrgente
        '
        Me.checkUrgente.AutoSize = True
        Me.checkUrgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUrgente.ForeColor = System.Drawing.Color.Maroon
        Me.checkUrgente.Location = New System.Drawing.Point(450, 112)
        Me.checkUrgente.Name = "checkUrgente"
        Me.checkUrgente.Size = New System.Drawing.Size(268, 24)
        Me.checkUrgente.TabIndex = 65
        Me.checkUrgente.Text = "ASIGNAR COMO URGENTE"
        Me.checkUrgente.UseVisualStyleBackColor = True
        '
        'txtidinforme
        '
        Me.txtidinforme.Location = New System.Drawing.Point(1337, 18)
        Me.txtidinforme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidinforme.Name = "txtidinforme"
        Me.txtidinforme.Size = New System.Drawing.Size(67, 22)
        Me.txtidinforme.TabIndex = 64
        Me.txtidinforme.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(824, 132)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(385, 4)
        Me.Panel4.TabIndex = 63
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(29, 79)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 4)
        Me.Panel3.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(824, 71)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 4)
        Me.Panel1.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(428, 71)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 4)
        Me.Panel2.TabIndex = 60
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(1217, 18)
        Me.txtestado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(111, 22)
        Me.txtestado.TabIndex = 54
        Me.txtestado.Visible = False
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
        Me.btnactualizar.Location = New System.Drawing.Point(1434, 18)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(55, 37)
        Me.btnactualizar.TabIndex = 54
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(8, 114)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 30
        Me.txtidtemp.Visible = False
        '
        'txtprueba
        '
        Me.txtprueba.Location = New System.Drawing.Point(1141, 18)
        Me.txtprueba.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprueba.Name = "txtprueba"
        Me.txtprueba.Size = New System.Drawing.Size(67, 22)
        Me.txtprueba.TabIndex = 53
        Me.txtprueba.Visible = False
        '
        'txtidmedico
        '
        Me.txtidmedico.Location = New System.Drawing.Point(2, 43)
        Me.txtidmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmedico.Name = "txtidmedico"
        Me.txtidmedico.Size = New System.Drawing.Size(19, 22)
        Me.txtidmedico.TabIndex = 29
        Me.txtidmedico.Visible = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(8, 84)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(19, 22)
        Me.txtidestudio.TabIndex = 28
        Me.txtidestudio.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(25, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Filtrar por estudio"
        '
        'cbEstudio
        '
        Me.cbEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEstudio.FormattingEnabled = True
        Me.cbEstudio.Items.AddRange(New Object() {"TODOS"})
        Me.cbEstudio.Location = New System.Drawing.Point(29, 50)
        Me.cbEstudio.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstudio.Name = "cbEstudio"
        Me.cbEstudio.Size = New System.Drawing.Size(384, 24)
        Me.cbEstudio.TabIndex = 26
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1239, 90)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 46)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "ASIGNAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(820, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Asignar un médico informante"
        '
        'cbMedico
        '
        Me.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMedico.FormattingEnabled = True
        Me.cbMedico.Location = New System.Drawing.Point(824, 101)
        Me.cbMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedico.Name = "cbMedico"
        Me.cbMedico.Size = New System.Drawing.Size(384, 24)
        Me.cbMedico.TabIndex = 4
        '
        'txtestudio
        '
        Me.txtestudio.BackColor = System.Drawing.Color.White
        Me.txtestudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtestudio.Location = New System.Drawing.Point(824, 50)
        Me.txtestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestudio.Name = "txtestudio"
        Me.txtestudio.ReadOnly = True
        Me.txtestudio.Size = New System.Drawing.Size(385, 15)
        Me.txtestudio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(820, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estudio realizado"
        '
        'txtpaciente
        '
        Me.txtpaciente.BackColor = System.Drawing.Color.White
        Me.txtpaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpaciente.Location = New System.Drawing.Point(428, 50)
        Me.txtpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.ReadOnly = True
        Me.txtpaciente.Size = New System.Drawing.Size(385, 15)
        Me.txtpaciente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(424, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del paciente"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(166, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContenedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgContenedor.EnableHeadersVisualStyles = False
        Me.dgContenedor.Location = New System.Drawing.Point(33, 64)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(1625, 431)
        Me.dgContenedor.TabIndex = 45
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ver_imagen, Me.lista_estudios, Me.proceso_informe, Me.ver_adjuntos})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(208, 100)
        '
        'ver_imagen
        '
        Me.ver_imagen.Name = "ver_imagen"
        Me.ver_imagen.Size = New System.Drawing.Size(207, 24)
        Me.ver_imagen.Text = "Visualizar estudio"
        '
        'lista_estudios
        '
        Me.lista_estudios.Name = "lista_estudios"
        Me.lista_estudios.Size = New System.Drawing.Size(207, 24)
        Me.lista_estudios.Text = "Lista de estudios"
        '
        'proceso_informe
        '
        Me.proceso_informe.Name = "proceso_informe"
        Me.proceso_informe.Size = New System.Drawing.Size(207, 24)
        Me.proceso_informe.Text = "Proceso de informe"
        '
        'ver_adjuntos
        '
        Me.ver_adjuntos.Name = "ver_adjuntos"
        Me.ver_adjuntos.Size = New System.Drawing.Size(207, 24)
        Me.ver_adjuntos.Text = "Visualizar adjuntos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Centros disponibles"
        '
        'cbcentro
        '
        Me.cbcentro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbcentro.FormattingEnabled = True
        Me.cbcentro.Location = New System.Drawing.Point(197, 20)
        Me.cbcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcentro.Name = "cbcentro"
        Me.cbcentro.Size = New System.Drawing.Size(192, 24)
        Me.cbcentro.TabIndex = 57
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(405, 20)
        Me.txtidcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(41, 22)
        Me.txtidcentro.TabIndex = 59
        Me.txtidcentro.Visible = False
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(1547, 599)
        Me.rtb1.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(132, 117)
        Me.rtb1.TabIndex = 61
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackgroundImage = Global.osiris.My.Resources.Resources.buscar
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Location = New System.Drawing.Point(405, 13)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(33, 31)
        Me.btnbuscar.TabIndex = 60
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close_gray
        Me.btncerrar.Location = New System.Drawing.Point(1649, 15)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(27, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 52
        Me.btncerrar.TabStop = False
        '
        'asignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1692, 721)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtidcentro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbcentro)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.dgContenedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "asignacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de asignación de tareas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMedico As ComboBox
    Friend WithEvents txtestudio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEstudio As ComboBox
    Friend WithEvents txtidmedico As TextBox
    Friend WithEvents txtidestudio As TextBox
    Private WithEvents Timer1 As Timer
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents txtprueba As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ver_imagen As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents cbcentro As ComboBox
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtidinforme As TextBox
    Friend WithEvents lista_estudios As ToolStripMenuItem
    Friend WithEvents btnbuscar As Button
    Friend WithEvents proceso_informe As ToolStripMenuItem
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents checkUrgente As CheckBox
    Friend WithEvents ver_adjuntos As ToolStripMenuItem
End Class
