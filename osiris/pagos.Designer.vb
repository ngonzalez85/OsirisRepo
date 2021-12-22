<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pagos))
        Me.lblcant = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCentro_usuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txttotalmedvital = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtneto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtcant_informes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txttotalcomision = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txttotalpagar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgEstudios = New System.Windows.Forms.DataGridView()
        Me.txtidcentro_usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblcant})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 664)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1592, 25)
        Me.StatusStrip1.TabIndex = 79
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(617, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "al"
        '
        'txthasta
        '
        Me.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txthasta.Location = New System.Drawing.Point(645, 14)
        Me.txthasta.Margin = New System.Windows.Forms.Padding(4)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.Size = New System.Drawing.Size(129, 22)
        Me.txthasta.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Fecha de subida"
        '
        'txtdesde
        '
        Me.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdesde.Location = New System.Drawing.Point(479, 14)
        Me.txtdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(129, 22)
        Me.txtdesde.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 16)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 17)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Centros disponibles"
        '
        'cbCentro_usuario
        '
        Me.cbCentro_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCentro_usuario.FormattingEnabled = True
        Me.cbCentro_usuario.Location = New System.Drawing.Point(155, 12)
        Me.cbCentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCentro_usuario.Name = "cbCentro_usuario"
        Me.cbCentro_usuario.Size = New System.Drawing.Size(192, 24)
        Me.cbCentro_usuario.TabIndex = 66
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.txttotalmedvital)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.txtneto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.txtcant_informes)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.txttotalcomision)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.txttotalpagar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dgEstudios)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 53)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1563, 588)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Location = New System.Drawing.Point(880, 530)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(324, 4)
        Me.Panel5.TabIndex = 70
        '
        'txttotalmedvital
        '
        Me.txttotalmedvital.BackColor = System.Drawing.Color.White
        Me.txttotalmedvital.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttotalmedvital.Location = New System.Drawing.Point(880, 508)
        Me.txttotalmedvital.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalmedvital.Name = "txttotalmedvital"
        Me.txttotalmedvital.ReadOnly = True
        Me.txttotalmedvital.Size = New System.Drawing.Size(324, 15)
        Me.txttotalmedvital.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(877, 486)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Total Medvital"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(1212, 530)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(324, 4)
        Me.Panel4.TabIndex = 67
        '
        'txtneto
        '
        Me.txtneto.BackColor = System.Drawing.Color.White
        Me.txtneto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtneto.Location = New System.Drawing.Point(1212, 508)
        Me.txtneto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtneto.Name = "txtneto"
        Me.txtneto.ReadOnly = True
        Me.txtneto.Size = New System.Drawing.Size(324, 15)
        Me.txtneto.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(1208, 486)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 17)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Neto a pagar a médicos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(21, 530)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 4)
        Me.Panel3.TabIndex = 64
        '
        'txtcant_informes
        '
        Me.txtcant_informes.BackColor = System.Drawing.Color.White
        Me.txtcant_informes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcant_informes.Location = New System.Drawing.Point(21, 508)
        Me.txtcant_informes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcant_informes.Name = "txtcant_informes"
        Me.txtcant_informes.ReadOnly = True
        Me.txtcant_informes.Size = New System.Drawing.Size(135, 15)
        Me.txtcant_informes.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(17, 486)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Canidad de Informes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(541, 530)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 4)
        Me.Panel1.TabIndex = 61
        '
        'txttotalcomision
        '
        Me.txttotalcomision.BackColor = System.Drawing.Color.White
        Me.txttotalcomision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttotalcomision.Location = New System.Drawing.Point(541, 508)
        Me.txttotalcomision.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalcomision.Name = "txttotalcomision"
        Me.txttotalcomision.ReadOnly = True
        Me.txttotalcomision.Size = New System.Drawing.Size(324, 15)
        Me.txttotalcomision.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(537, 486)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Total de comisión por uso de software"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(188, 530)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 4)
        Me.Panel2.TabIndex = 58
        '
        'txttotalpagar
        '
        Me.txttotalpagar.BackColor = System.Drawing.Color.White
        Me.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttotalpagar.Location = New System.Drawing.Point(188, 508)
        Me.txttotalpagar.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalpagar.Name = "txttotalpagar"
        Me.txttotalpagar.ReadOnly = True
        Me.txttotalpagar.Size = New System.Drawing.Size(324, 15)
        Me.txttotalpagar.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(184, 486)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Monto total"
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
        Me.dgEstudios.Location = New System.Drawing.Point(15, 23)
        Me.dgEstudios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEstudios.Name = "dgEstudios"
        Me.dgEstudios.ReadOnly = True
        Me.dgEstudios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgEstudios.RowHeadersVisible = False
        Me.dgEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstudios.Size = New System.Drawing.Size(1524, 433)
        Me.dgEstudios.TabIndex = 0
        '
        'txtidcentro_usuario
        '
        Me.txtidcentro_usuario.Location = New System.Drawing.Point(784, 15)
        Me.txtidcentro_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_usuario.Name = "txtidcentro_usuario"
        Me.txtidcentro_usuario.Size = New System.Drawing.Size(19, 22)
        Me.txtidcentro_usuario.TabIndex = 81
        Me.txtidcentro_usuario.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(881, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Generar reporte detallado"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.osiris.My.Resources.Resources.magic_wand
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1059, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btnImprimir.Location = New System.Drawing.Point(1468, 12)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(40, 37)
        Me.btnImprimir.TabIndex = 80
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1592, 689)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtidcentro_usuario)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesde)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbCentro_usuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcant As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txthasta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdesde As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCentro_usuario As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgEstudios As DataGridView
    Friend WithEvents txtidcentro_usuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txttotalcomision As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txttotalpagar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtcant_informes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtneto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txttotalmedvital As TextBox
End Class
