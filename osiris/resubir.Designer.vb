<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resubir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resubir))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.lblprogreso = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.pbloading = New System.Windows.Forms.PictureBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtdirectorio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.comprimir = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncerrar)
        Me.GroupBox1.Controls.Add(Me.lblprogreso)
        Me.GroupBox1.Controls.Add(Me.lblpaciente)
        Me.GroupBox1.Controls.Add(Me.pbloading)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblinforme)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtdirectorio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 211)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subir archivos al servidor"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close_gray
        Me.btncerrar.Location = New System.Drawing.Point(299, 14)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(20, 20)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 54
        Me.btncerrar.TabStop = False
        Me.btncerrar.Visible = False
        '
        'lblprogreso
        '
        Me.lblprogreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblprogreso.AutoSize = True
        Me.lblprogreso.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblprogreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogreso.ForeColor = System.Drawing.Color.White
        Me.lblprogreso.Location = New System.Drawing.Point(67, 124)
        Me.lblprogreso.Name = "lblprogreso"
        Me.lblprogreso.Size = New System.Drawing.Size(0, 18)
        Me.lblprogreso.TabIndex = 51
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(76, 39)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(58, 13)
        Me.lblpaciente.TabIndex = 32
        Me.lblpaciente.Text = "lblpaciente"
        '
        'pbloading
        '
        Me.pbloading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbloading.Image = Global.osiris.My.Resources.Resources.Loading_2
        Me.pbloading.Location = New System.Drawing.Point(24, 117)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(37, 34)
        Me.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbloading.TabIndex = 50
        Me.pbloading.TabStop = False
        Me.pbloading.Visible = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(21, 39)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(25, 13)
        Me.lblid.TabIndex = 31
        Me.lblid.Text = "lblid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(76, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "PACIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "ID"
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.Location = New System.Drawing.Point(21, 110)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(41, 13)
        Me.lblinforme.TabIndex = 3
        Me.lblinforme.Text = "informe"
        Me.lblinforme.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.osiris.My.Resources.Resources.upload
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(98, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(205, 37)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "VOLVER A SUBIR ARCHIVOS"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(273, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 2
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtdirectorio
        '
        Me.txtdirectorio.BackColor = System.Drawing.Color.White
        Me.txtdirectorio.Location = New System.Drawing.Point(24, 87)
        Me.txtdirectorio.Name = "txtdirectorio"
        Me.txtdirectorio.ReadOnly = True
        Me.txtdirectorio.Size = New System.Drawing.Size(243, 20)
        Me.txtdirectorio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(21, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directorio de imágenes"
        '
        'comprimir
        '
        Me.comprimir.WorkerReportsProgress = True
        '
        'resubir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(351, 232)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "resubir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resubir datos al servidor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblpaciente As Label
    Friend WithEvents lblid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblinforme As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtdirectorio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dlg As FolderBrowserDialog
    Friend WithEvents pbloading As PictureBox
    Friend WithEvents lblprogreso As Label
    Friend WithEvents comprimir As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btncerrar As PictureBox
End Class
