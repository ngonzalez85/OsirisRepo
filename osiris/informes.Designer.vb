<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(informes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblidpaciente = New System.Windows.Forms.Label()
        Me.lblmedicosolicitante = New System.Windows.Forms.Label()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.lbltipoestudio = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.lblci = New System.Windows.Forms.Label()
        Me.lbledad = New System.Windows.Forms.Label()
        Me.lbltecnico = New System.Windows.Forms.Label()
        Me.lblfecha_nac = New System.Windows.Forms.Label()
        Me.lblestudio = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btndescargar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btninforme = New System.Windows.Forms.Button()
        Me.btnimagen = New System.Windows.Forms.Button()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtidcentro_solicitante = New System.Windows.Forms.TextBox()
        Me.txtidmedico = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.dgEstudios = New System.Windows.Forms.DataGridView()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.txtreserva = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtbandera = New System.Windows.Forms.TextBox()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.cbcentro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.txtdicom = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.eliminar_temp = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtidprioridad = New System.Windows.Forms.TextBox()
        Me.btn_colaboracion = New System.Windows.Forms.Button()
        Me.btnfirmas = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.pbloading = New System.Windows.Forms.PictureBox()
        Me.btnmisfirmas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BANDEJA DE ENTRADA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblidpaciente)
        Me.GroupBox1.Controls.Add(Me.lblmedicosolicitante)
        Me.GroupBox1.Controls.Add(Me.txtmotivo)
        Me.GroupBox1.Controls.Add(Me.lbltipoestudio)
        Me.GroupBox1.Controls.Add(Me.lblpaciente)
        Me.GroupBox1.Controls.Add(Me.lblci)
        Me.GroupBox1.Controls.Add(Me.lbledad)
        Me.GroupBox1.Controls.Add(Me.lbltecnico)
        Me.GroupBox1.Controls.Add(Me.lblfecha_nac)
        Me.GroupBox1.Controls.Add(Me.lblestudio)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 544)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(872, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motivo del estudio"
        '
        'lblidpaciente
        '
        Me.lblidpaciente.AutoSize = True
        Me.lblidpaciente.Location = New System.Drawing.Point(209, 130)
        Me.lblidpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidpaciente.Name = "lblidpaciente"
        Me.lblidpaciente.Size = New System.Drawing.Size(73, 17)
        Me.lblidpaciente.TabIndex = 50
        Me.lblidpaciente.Text = "idpaciente"
        Me.lblidpaciente.Visible = False
        '
        'lblmedicosolicitante
        '
        Me.lblmedicosolicitante.AutoSize = True
        Me.lblmedicosolicitante.Location = New System.Drawing.Point(1, 137)
        Me.lblmedicosolicitante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedicosolicitante.Name = "lblmedicosolicitante"
        Me.lblmedicosolicitante.Size = New System.Drawing.Size(117, 17)
        Me.lblmedicosolicitante.TabIndex = 49
        Me.lblmedicosolicitante.Text = "Doctor solicitante"
        Me.lblmedicosolicitante.Visible = False
        '
        'txtmotivo
        '
        Me.txtmotivo.Location = New System.Drawing.Point(23, 39)
        Me.txtmotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmotivo.Multiline = True
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(824, 86)
        Me.txtmotivo.TabIndex = 0
        '
        'lbltipoestudio
        '
        Me.lbltipoestudio.AutoSize = True
        Me.lbltipoestudio.Location = New System.Drawing.Point(-32, 119)
        Me.lbltipoestudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipoestudio.Name = "lbltipoestudio"
        Me.lbltipoestudio.Size = New System.Drawing.Size(106, 17)
        Me.lbltipoestudio.TabIndex = 43
        Me.lbltipoestudio.Text = "Tipo de estudio"
        Me.lbltipoestudio.Visible = False
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(-32, 37)
        Me.lblpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(139, 17)
        Me.lblpaciente.TabIndex = 34
        Me.lblpaciente.Text = "Nombre del paciente"
        Me.lblpaciente.Visible = False
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(-32, 21)
        Me.lblci.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(101, 17)
        Me.lblci.TabIndex = 33
        Me.lblci.Text = "CI del paciente"
        Me.lblci.Visible = False
        '
        'lbledad
        '
        Me.lbledad.AutoSize = True
        Me.lbledad.Location = New System.Drawing.Point(-32, 55)
        Me.lbledad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbledad.Name = "lbledad"
        Me.lbledad.Size = New System.Drawing.Size(122, 17)
        Me.lbledad.TabIndex = 35
        Me.lbledad.Text = "Edad del paciente"
        Me.lbledad.Visible = False
        '
        'lbltecnico
        '
        Me.lbltecnico.AutoSize = True
        Me.lbltecnico.Location = New System.Drawing.Point(-32, 103)
        Me.lbltecnico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltecnico.Name = "lbltecnico"
        Me.lbltecnico.Size = New System.Drawing.Size(135, 17)
        Me.lbltecnico.TabIndex = 40
        Me.lbltecnico.Text = "tecnico responsable"
        Me.lbltecnico.Visible = False
        '
        'lblfecha_nac
        '
        Me.lblfecha_nac.AutoSize = True
        Me.lblfecha_nac.Location = New System.Drawing.Point(-32, 71)
        Me.lblfecha_nac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfecha_nac.Name = "lblfecha_nac"
        Me.lblfecha_nac.Size = New System.Drawing.Size(220, 17)
        Me.lblfecha_nac.TabIndex = 36
        Me.lblfecha_nac.Text = "Fecha de nacimiento del paciente"
        Me.lblfecha_nac.Visible = False
        '
        'lblestudio
        '
        Me.lblestudio.AutoSize = True
        Me.lblestudio.Location = New System.Drawing.Point(-32, 87)
        Me.lblestudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestudio.Name = "lblestudio"
        Me.lblestudio.Size = New System.Drawing.Size(117, 17)
        Me.lblestudio.TabIndex = 37
        Me.lblestudio.Text = "Estudio realizado"
        Me.lblestudio.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btndescargar)
        Me.GroupBox3.Controls.Add(Me.btnactualizar)
        Me.GroupBox3.Controls.Add(Me.btninforme)
        Me.GroupBox3.Controls.Add(Me.btnimagen)
        Me.GroupBox3.Location = New System.Drawing.Point(989, 544)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(395, 156)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'btndescargar
        '
        Me.btndescargar.BackColor = System.Drawing.Color.White
        Me.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndescargar.Enabled = False
        Me.btndescargar.FlatAppearance.BorderSize = 0
        Me.btndescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescargar.ForeColor = System.Drawing.Color.White
        Me.btndescargar.Image = CType(resources.GetObject("btndescargar.Image"), System.Drawing.Image)
        Me.btndescargar.Location = New System.Drawing.Point(28, 51)
        Me.btndescargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btndescargar.Name = "btndescargar"
        Me.btndescargar.Size = New System.Drawing.Size(93, 68)
        Me.btndescargar.TabIndex = 63
        Me.btndescargar.UseVisualStyleBackColor = False
        Me.btndescargar.Visible = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.White
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.FlatAppearance.BorderSize = 0
        Me.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
        Me.btnactualizar.Location = New System.Drawing.Point(254, 32)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(133, 107)
        Me.btnactualizar.TabIndex = 21
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'btninforme
        '
        Me.btninforme.BackColor = System.Drawing.Color.White
        Me.btninforme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninforme.Enabled = False
        Me.btninforme.FlatAppearance.BorderSize = 0
        Me.btninforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btninforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninforme.ForeColor = System.Drawing.Color.White
        Me.btninforme.Image = CType(resources.GetObject("btninforme.Image"), System.Drawing.Image)
        Me.btninforme.Location = New System.Drawing.Point(129, 31)
        Me.btninforme.Margin = New System.Windows.Forms.Padding(4)
        Me.btninforme.Name = "btninforme"
        Me.btninforme.Size = New System.Drawing.Size(126, 108)
        Me.btninforme.TabIndex = 20
        Me.btninforme.UseVisualStyleBackColor = False
        '
        'btnimagen
        '
        Me.btnimagen.BackColor = System.Drawing.Color.White
        Me.btnimagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimagen.Enabled = False
        Me.btnimagen.FlatAppearance.BorderSize = 0
        Me.btnimagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimagen.ForeColor = System.Drawing.Color.White
        Me.btnimagen.Image = CType(resources.GetObject("btnimagen.Image"), System.Drawing.Image)
        Me.btnimagen.Location = New System.Drawing.Point(32, 37)
        Me.btnimagen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.Size = New System.Drawing.Size(103, 87)
        Me.btnimagen.TabIndex = 18
        Me.btnimagen.UseVisualStyleBackColor = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(1368, 236)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(41, 22)
        Me.txtidestudio.TabIndex = 6
        Me.txtidestudio.Visible = False
        '
        'txtidcentro_solicitante
        '
        Me.txtidcentro_solicitante.Location = New System.Drawing.Point(1368, 204)
        Me.txtidcentro_solicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro_solicitante.Name = "txtidcentro_solicitante"
        Me.txtidcentro_solicitante.Size = New System.Drawing.Size(41, 22)
        Me.txtidcentro_solicitante.TabIndex = 38
        Me.txtidcentro_solicitante.Visible = False
        '
        'txtidmedico
        '
        Me.txtidmedico.Location = New System.Drawing.Point(1368, 172)
        Me.txtidmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmedico.Name = "txtidmedico"
        Me.txtidmedico.Size = New System.Drawing.Size(41, 22)
        Me.txtidmedico.TabIndex = 39
        Me.txtidmedico.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 40000
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(1368, 140)
        Me.txtestado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(41, 22)
        Me.txtestado.TabIndex = 42
        Me.txtestado.Visible = False
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(166, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstudios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstudios.EnableHeadersVisualStyles = False
        Me.dgEstudios.Location = New System.Drawing.Point(52, 76)
        Me.dgEstudios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEstudios.Name = "dgEstudios"
        Me.dgEstudios.ReadOnly = True
        Me.dgEstudios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgEstudios.RowHeadersVisible = False
        Me.dgEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstudios.Size = New System.Drawing.Size(1332, 447)
        Me.dgEstudios.TabIndex = 44
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.White
        Me.lblestado.Location = New System.Drawing.Point(869, 19)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(507, 24)
        Me.lblestado.TabIndex = 46
        Me.lblestado.Text = "DESCARGANDO ESTUDIOS POR FAVOR ESPERE..."
        Me.lblestado.Visible = False
        '
        'txtreserva
        '
        Me.txtreserva.Location = New System.Drawing.Point(1368, 268)
        Me.txtreserva.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreserva.Name = "txtreserva"
        Me.txtreserva.Size = New System.Drawing.Size(41, 22)
        Me.txtreserva.TabIndex = 47
        Me.txtreserva.Visible = False
        '
        'txtbandera
        '
        Me.txtbandera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbandera.Location = New System.Drawing.Point(1384, 300)
        Me.txtbandera.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbandera.Name = "txtbandera"
        Me.txtbandera.Size = New System.Drawing.Size(41, 22)
        Me.txtbandera.TabIndex = 53
        Me.txtbandera.Text = "0"
        Me.txtbandera.Visible = False
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(16, 615)
        Me.txtidtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(19, 22)
        Me.txtidtemp.TabIndex = 54
        Me.txtidtemp.Visible = False
        '
        'cbcentro
        '
        Me.cbcentro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbcentro.FormattingEnabled = True
        Me.cbcentro.Location = New System.Drawing.Point(167, 14)
        Me.cbcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcentro.Name = "cbcentro"
        Me.cbcentro.Size = New System.Drawing.Size(166, 24)
        Me.cbcentro.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Centros disponibles"
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(1368, 332)
        Me.txtidcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(41, 22)
        Me.txtidcentro.TabIndex = 57
        Me.txtidcentro.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1368, 58)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 26)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtidcita
        '
        Me.txtidcita.Location = New System.Drawing.Point(16, 644)
        Me.txtidcita.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(19, 22)
        Me.txtidcita.TabIndex = 60
        Me.txtidcita.Visible = False
        '
        'txtdicom
        '
        Me.txtdicom.Location = New System.Drawing.Point(16, 674)
        Me.txtdicom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdicom.Name = "txtdicom"
        Me.txtdicom.Size = New System.Drawing.Size(19, 22)
        Me.txtdicom.TabIndex = 61
        Me.txtdicom.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.eliminar_temp})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 28)
        '
        'eliminar_temp
        '
        Me.eliminar_temp.Name = "eliminar_temp"
        Me.eliminar_temp.Size = New System.Drawing.Size(197, 24)
        Me.eliminar_temp.Text = "Eliminar temporal"
        '
        'txtidprioridad
        '
        Me.txtidprioridad.Location = New System.Drawing.Point(13, 585)
        Me.txtidprioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidprioridad.Name = "txtidprioridad"
        Me.txtidprioridad.Size = New System.Drawing.Size(19, 22)
        Me.txtidprioridad.TabIndex = 64
        Me.txtidprioridad.Visible = False
        '
        'btn_colaboracion
        '
        Me.btn_colaboracion.BackgroundImage = CType(resources.GetObject("btn_colaboracion.BackgroundImage"), System.Drawing.Image)
        Me.btn_colaboracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_colaboracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_colaboracion.FlatAppearance.BorderSize = 0
        Me.btn_colaboracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_colaboracion.Location = New System.Drawing.Point(1368, 362)
        Me.btn_colaboracion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_colaboracion.Name = "btn_colaboracion"
        Me.btn_colaboracion.Size = New System.Drawing.Size(33, 31)
        Me.btn_colaboracion.TabIndex = 63
        Me.btn_colaboracion.UseVisualStyleBackColor = True
        Me.btn_colaboracion.Visible = False
        '
        'btnfirmas
        '
        Me.btnfirmas.BackgroundImage = Global.osiris.My.Resources.Resources.preview_small2
        Me.btnfirmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfirmas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfirmas.FlatAppearance.BorderSize = 0
        Me.btnfirmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfirmas.Location = New System.Drawing.Point(1376, 401)
        Me.btnfirmas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfirmas.Name = "btnfirmas"
        Me.btnfirmas.Size = New System.Drawing.Size(33, 31)
        Me.btnfirmas.TabIndex = 62
        Me.btnfirmas.UseVisualStyleBackColor = True
        Me.btnfirmas.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackgroundImage = Global.osiris.My.Resources.Resources.buscar
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Location = New System.Drawing.Point(352, 11)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(33, 31)
        Me.btnbuscar.TabIndex = 58
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close_gray
        Me.btncerrar.Location = New System.Drawing.Point(1400, 15)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(27, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 52
        Me.btncerrar.TabStop = False
        '
        'pbloading
        '
        Me.pbloading.Image = Global.osiris.My.Resources.Resources.Loading_2
        Me.pbloading.Location = New System.Drawing.Point(812, 9)
        Me.pbloading.Margin = New System.Windows.Forms.Padding(4)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(49, 42)
        Me.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbloading.TabIndex = 48
        Me.pbloading.TabStop = False
        Me.pbloading.Visible = False
        '
        'btnmisfirmas
        '
        Me.btnmisfirmas.BackColor = System.Drawing.Color.SteelBlue
        Me.btnmisfirmas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmisfirmas.FlatAppearance.BorderSize = 0
        Me.btnmisfirmas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnmisfirmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmisfirmas.ForeColor = System.Drawing.Color.White
        Me.btnmisfirmas.Location = New System.Drawing.Point(393, 8)
        Me.btnmisfirmas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmisfirmas.Name = "btnmisfirmas"
        Me.btnmisfirmas.Size = New System.Drawing.Size(104, 34)
        Me.btnmisfirmas.TabIndex = 65
        Me.btnmisfirmas.Text = "MIS FIRMAS"
        Me.btnmisfirmas.UseVisualStyleBackColor = False
        '
        'informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1443, 743)
        Me.Controls.Add(Me.btnmisfirmas)
        Me.Controls.Add(Me.txtidprioridad)
        Me.Controls.Add(Me.btn_colaboracion)
        Me.Controls.Add(Me.btnfirmas)
        Me.Controls.Add(Me.txtdicom)
        Me.Controls.Add(Me.txtidcita)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtidcentro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbcentro)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.txtbandera)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.pbloading)
        Me.Controls.Add(Me.txtreserva)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.dgEstudios)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.txtidmedico)
        Me.Controls.Add(Me.txtidcentro_solicitante)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "informes"
        Me.Text = "informes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtmotivo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btninforme As Button
    Friend WithEvents btnimagen As Button
    Friend WithEvents txtidestudio As TextBox
    Friend WithEvents lblestudio As Label
    Friend WithEvents lblfecha_nac As Label
    Friend WithEvents lbledad As Label
    Friend WithEvents lblpaciente As Label
    Friend WithEvents lblci As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtidcentro_solicitante As TextBox
    Friend WithEvents txtidmedico As TextBox
    Friend WithEvents lbltecnico As Label
    Private WithEvents Timer1 As Timer
    Friend WithEvents txtestado As TextBox
    Friend WithEvents lbltipoestudio As Label
    Friend WithEvents dgEstudios As DataGridView
    Friend WithEvents lblestado As Label
    Friend WithEvents txtreserva As TextBox
    Friend WithEvents pbloading As PictureBox
    Friend WithEvents lblmedicosolicitante As Label
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtbandera As TextBox
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents cbcentro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblidpaciente As Label
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents txtdicom As TextBox
    Friend WithEvents btnfirmas As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents eliminar_temp As ToolStripMenuItem
    Friend WithEvents btndescargar As Button
    Friend WithEvents btn_colaboracion As Button
    Friend WithEvents txtidprioridad As TextBox
    Friend WithEvents btnmisfirmas As Button
End Class
