<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblinformes_realizados = New System.Windows.Forms.Label()
        Me.lbltotalGeneral = New System.Windows.Forms.Label()
        Me.lbltotal_general = New System.Windows.Forms.Label()
        Me.lblcantidadMes = New System.Windows.Forms.Label()
        Me.lbltotal_mes = New System.Windows.Forms.Label()
        Me.lbltus_estadisticas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.horaActual = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblpc = New System.Windows.Forms.Label()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbperfil = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblplantilla = New System.Windows.Forms.Label()
        Me.lblrol = New System.Windows.Forms.Label()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbperfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblinformes_realizados
        '
        Me.lblinformes_realizados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblinformes_realizados.AutoSize = True
        Me.lblinformes_realizados.Font = New System.Drawing.Font("Cambria", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinformes_realizados.ForeColor = System.Drawing.Color.Black
        Me.lblinformes_realizados.Location = New System.Drawing.Point(861, 450)
        Me.lblinformes_realizados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinformes_realizados.Name = "lblinformes_realizados"
        Me.lblinformes_realizados.Size = New System.Drawing.Size(225, 30)
        Me.lblinformes_realizados.TabIndex = 18
        Me.lblinformes_realizados.Text = "Informes realizados"
        '
        'lbltotalGeneral
        '
        Me.lbltotalGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotalGeneral.AutoSize = True
        Me.lbltotalGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalGeneral.ForeColor = System.Drawing.Color.Black
        Me.lbltotalGeneral.Location = New System.Drawing.Point(1099, 549)
        Me.lbltotalGeneral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalGeneral.Name = "lbltotalGeneral"
        Me.lbltotalGeneral.Size = New System.Drawing.Size(104, 113)
        Me.lbltotalGeneral.TabIndex = 17
        Me.lbltotalGeneral.Text = "0"
        '
        'lbltotal_general
        '
        Me.lbltotal_general.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal_general.AutoSize = True
        Me.lbltotal_general.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal_general.ForeColor = System.Drawing.Color.Black
        Me.lbltotal_general.Location = New System.Drawing.Point(1111, 501)
        Me.lbltotal_general.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal_general.Name = "lbltotal_general"
        Me.lbltotal_general.Size = New System.Drawing.Size(199, 38)
        Me.lbltotal_general.TabIndex = 16
        Me.lbltotal_general.Text = "Total general"
        '
        'lblcantidadMes
        '
        Me.lblcantidadMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcantidadMes.AutoSize = True
        Me.lblcantidadMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidadMes.ForeColor = System.Drawing.Color.Black
        Me.lblcantidadMes.Location = New System.Drawing.Point(879, 549)
        Me.lblcantidadMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcantidadMes.Name = "lblcantidadMes"
        Me.lblcantidadMes.Size = New System.Drawing.Size(104, 113)
        Me.lblcantidadMes.TabIndex = 15
        Me.lblcantidadMes.Text = "0"
        '
        'lbltotal_mes
        '
        Me.lbltotal_mes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal_mes.AutoSize = True
        Me.lbltotal_mes.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal_mes.ForeColor = System.Drawing.Color.Black
        Me.lbltotal_mes.Location = New System.Drawing.Point(860, 501)
        Me.lbltotal_mes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal_mes.Name = "lbltotal_mes"
        Me.lbltotal_mes.Size = New System.Drawing.Size(202, 38)
        Me.lbltotal_mes.TabIndex = 14
        Me.lbltotal_mes.Text = "Total del mes"
        '
        'lbltus_estadisticas
        '
        Me.lbltus_estadisticas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltus_estadisticas.AutoSize = True
        Me.lbltus_estadisticas.Font = New System.Drawing.Font("Cambria", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltus_estadisticas.ForeColor = System.Drawing.Color.Black
        Me.lbltus_estadisticas.Location = New System.Drawing.Point(857, 394)
        Me.lbltus_estadisticas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltus_estadisticas.Name = "lbltus_estadisticas"
        Me.lbltus_estadisticas.Size = New System.Drawing.Size(361, 59)
        Me.lbltus_estadisticas.TabIndex = 13
        Me.lbltus_estadisticas.Text = "Tus estadísticas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 59)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Bienvenido al sistema"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Cambria", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.Black
        Me.lblusuario.Location = New System.Drawing.Point(64, 242)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(243, 59)
        Me.lblusuario.TabIndex = 11
        Me.lblusuario.Text = "lblusuario"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Cambria", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.Black
        Me.lblhora.Location = New System.Drawing.Point(53, 57)
        Me.lblhora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(344, 117)
        Me.lblhora.TabIndex = 10
        Me.lblhora.Text = "la hora"
        '
        'horaActual
        '
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1419, 752)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 29)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Estas en"
        '
        'lblpc
        '
        Me.lblpc.AutoSize = True
        Me.lblpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpc.ForeColor = System.Drawing.Color.Black
        Me.lblpc.Location = New System.Drawing.Point(68, 330)
        Me.lblpc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpc.Name = "lblpc"
        Me.lblpc.Size = New System.Drawing.Size(66, 29)
        Me.lblpc.TabIndex = 22
        Me.lblpc.Text = "lblpc"
        '
        'pblogo
        '
        Me.pblogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pblogo.Location = New System.Drawing.Point(1088, 39)
        Me.pblogo.Margin = New System.Windows.Forms.Padding(4)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(183, 71)
        Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblogo.TabIndex = 24
        Me.pblogo.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(949, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Estas en"
        '
        'pbperfil
        '
        Me.pbperfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbperfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbperfil.Image = Global.osiris.My.Resources.Resources.perfil_usuario
        Me.pbperfil.Location = New System.Drawing.Point(1063, 171)
        Me.pbperfil.Margin = New System.Windows.Forms.Padding(4)
        Me.pbperfil.Name = "pbperfil"
        Me.pbperfil.Size = New System.Drawing.Size(256, 215)
        Me.pbperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbperfil.TabIndex = 25
        Me.pbperfil.TabStop = False
        '
        'lblplantilla
        '
        Me.lblplantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblplantilla.AutoSize = True
        Me.lblplantilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblplantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplantilla.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblplantilla.Location = New System.Drawing.Point(1084, 394)
        Me.lblplantilla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblplantilla.Name = "lblplantilla"
        Me.lblplantilla.Size = New System.Drawing.Size(199, 17)
        Me.lblplantilla.TabIndex = 26
        Me.lblplantilla.Text = "CAMBIAR CLAVE DE ACCESO"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.ForeColor = System.Drawing.Color.Black
        Me.lblrol.Location = New System.Drawing.Point(68, 299)
        Me.lblrol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(41, 29)
        Me.lblrol.TabIndex = 27
        Me.lblrol.Text = "rol"
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
        Me.btnactualizar.Location = New System.Drawing.Point(425, 386)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(40, 37)
        Me.btnactualizar.TabIndex = 53
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeColumns = False
        Me.dgContenedor.AllowUserToResizeRows = False
        Me.dgContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgContenedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgContenedor.BackgroundColor = System.Drawing.Color.Azure
        Me.dgContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgContenedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgContenedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContenedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgContenedor.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgContenedor.EnableHeadersVisualStyles = False
        Me.dgContenedor.Location = New System.Drawing.Point(75, 390)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(343, 251)
        Me.dgContenedor.TabIndex = 52
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 18000
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1397, 704)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.dgContenedor)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.lblplantilla)
        Me.Controls.Add(Me.pbperfil)
        Me.Controls.Add(Me.pblogo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblpc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblinformes_realizados)
        Me.Controls.Add(Me.lbltotalGeneral)
        Me.Controls.Add(Me.lbltotal_general)
        Me.Controls.Add(Me.lblcantidadMes)
        Me.Controls.Add(Me.lbltotal_mes)
        Me.Controls.Add(Me.lbltus_estadisticas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.lblhora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "inicio"
        Me.Text = "inicio"
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbperfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblinformes_realizados As Label
    Friend WithEvents lbltotalGeneral As Label
    Friend WithEvents lbltotal_general As Label
    Friend WithEvents lblcantidadMes As Label
    Friend WithEvents lbltotal_mes As Label
    Friend WithEvents lbltus_estadisticas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents horaActual As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents lblpc As Label
    Friend WithEvents pblogo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pbperfil As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblplantilla As Label
    Friend WithEvents lblrol As Label
    Friend WithEvents btnactualizar As Button
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents Timer1 As Timer
End Class
