<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modalidades))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtidtipo_estudio = New System.Windows.Forms.TextBox()
        Me.txtpuerto_dicom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpuerto_wl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.txtidmodalidad = New System.Windows.Forms.TextBox()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbcentro = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbtipo_estudio = New System.Windows.Forms.ComboBox()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.txtiplocal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtaetitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmodalidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtidrispy = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel9)
        Me.GroupBox1.Controls.Add(Me.txtidrispy)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btncerrar)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.Panel8)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtidtipo_estudio)
        Me.GroupBox1.Controls.Add(Me.txtpuerto_dicom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpuerto_wl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtidcentro)
        Me.GroupBox1.Controls.Add(Me.txtidmodalidad)
        Me.GroupBox1.Controls.Add(Me.dgContenedor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbcentro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbtipo_estudio)
        Me.GroupBox1.Controls.Add(Me.btnaccion)
        Me.GroupBox1.Controls.Add(Me.txtiplocal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtaetitle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmodalidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 469)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de modalidad"
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close_gray
        Me.btncerrar.Location = New System.Drawing.Point(661, 13)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(20, 20)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 54
        Me.btncerrar.TabStop = False
        Me.btncerrar.Visible = False
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
        Me.btnlimpiar.Location = New System.Drawing.Point(612, 169)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(30, 30)
        Me.btnlimpiar.TabIndex = 31
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel8.Location = New System.Drawing.Point(368, 197)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(242, 3)
        Me.Panel8.TabIndex = 30
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel7.Location = New System.Drawing.Point(36, 73)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(274, 3)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel6.Location = New System.Drawing.Point(368, 152)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(274, 3)
        Me.Panel6.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Location = New System.Drawing.Point(368, 111)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(274, 3)
        Me.Panel5.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(368, 73)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(274, 3)
        Me.Panel4.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(36, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(274, 3)
        Me.Panel3.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(36, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 3)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(36, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(274, 3)
        Me.Panel2.TabIndex = 8
        '
        'txtidtipo_estudio
        '
        Me.txtidtipo_estudio.Location = New System.Drawing.Point(648, 175)
        Me.txtidtipo_estudio.Name = "txtidtipo_estudio"
        Me.txtidtipo_estudio.Size = New System.Drawing.Size(23, 20)
        Me.txtidtipo_estudio.TabIndex = 32
        Me.txtidtipo_estudio.Visible = False
        '
        'txtpuerto_dicom
        '
        Me.txtpuerto_dicom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpuerto_dicom.Location = New System.Drawing.Point(368, 136)
        Me.txtpuerto_dicom.Name = "txtpuerto_dicom"
        Me.txtpuerto_dicom.Size = New System.Drawing.Size(274, 13)
        Me.txtpuerto_dicom.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(365, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Puerto DICOM"
        '
        'txtpuerto_wl
        '
        Me.txtpuerto_wl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpuerto_wl.Location = New System.Drawing.Point(368, 95)
        Me.txtpuerto_wl.Name = "txtpuerto_wl"
        Me.txtpuerto_wl.Size = New System.Drawing.Size(274, 13)
        Me.txtpuerto_wl.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(365, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Puerto WL"
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(325, 56)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(23, 20)
        Me.txtidcentro.TabIndex = 3
        Me.txtidcentro.Visible = False
        '
        'txtidmodalidad
        '
        Me.txtidmodalidad.Location = New System.Drawing.Point(292, 19)
        Me.txtidmodalidad.Name = "txtidmodalidad"
        Me.txtidmodalidad.Size = New System.Drawing.Size(23, 20)
        Me.txtidmodalidad.TabIndex = 2
        Me.txtidmodalidad.Visible = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
        Me.dgContenedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.dgContenedor.Location = New System.Drawing.Point(36, 286)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(606, 148)
        Me.dgContenedor.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(33, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Centro en la que opera"
        '
        'cbcentro
        '
        Me.cbcentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbcentro.FormattingEnabled = True
        Me.cbcentro.Location = New System.Drawing.Point(36, 50)
        Me.cbcentro.Name = "cbcentro"
        Me.cbcentro.Size = New System.Drawing.Size(274, 21)
        Me.cbcentro.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(365, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Tipo de estudio"
        '
        'cbtipo_estudio
        '
        Me.cbtipo_estudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbtipo_estudio.FormattingEnabled = True
        Me.cbtipo_estudio.Location = New System.Drawing.Point(368, 175)
        Me.cbtipo_estudio.Name = "cbtipo_estudio"
        Me.cbtipo_estudio.Size = New System.Drawing.Size(242, 21)
        Me.cbtipo_estudio.TabIndex = 29
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
        Me.btnaccion.Location = New System.Drawing.Point(527, 218)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(115, 47)
        Me.btnaccion.TabIndex = 0
        Me.btnaccion.Text = "GUARDAR"
        Me.btnaccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaccion.UseVisualStyleBackColor = False
        '
        'txtiplocal
        '
        Me.txtiplocal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtiplocal.Location = New System.Drawing.Point(36, 175)
        Me.txtiplocal.Name = "txtiplocal"
        Me.txtiplocal.Size = New System.Drawing.Size(274, 13)
        Me.txtiplocal.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(33, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "IP local"
        '
        'txtmarca
        '
        Me.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmarca.Location = New System.Drawing.Point(368, 56)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(274, 13)
        Me.txtmarca.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(365, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Marca"
        '
        'txtaetitle
        '
        Me.txtaetitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaetitle.Location = New System.Drawing.Point(36, 135)
        Me.txtaetitle.Name = "txtaetitle"
        Me.txtaetitle.Size = New System.Drawing.Size(274, 13)
        Me.txtaetitle.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(33, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ae_title"
        '
        'txtmodalidad
        '
        Me.txtmodalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmodalidad.Location = New System.Drawing.Point(36, 95)
        Me.txtmodalidad.Name = "txtmodalidad"
        Me.txtmodalidad.Size = New System.Drawing.Size(274, 13)
        Me.txtmodalidad.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(33, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Modalidad"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel9.Location = New System.Drawing.Point(36, 235)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(274, 3)
        Me.Panel9.TabIndex = 17
        '
        'txtidrispy
        '
        Me.txtidrispy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidrispy.Location = New System.Drawing.Point(36, 218)
        Me.txtidrispy.Name = "txtidrispy"
        Me.txtidrispy.Size = New System.Drawing.Size(274, 13)
        Me.txtidrispy.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(33, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ID Rispy"
        '
        'modalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 492)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modalidades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidtipo_estudio As TextBox
    Friend WithEvents txtpuerto_dicom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpuerto_wl As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents txtidmodalidad As TextBox
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents cbcentro As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbtipo_estudio As ComboBox
    Friend WithEvents btnaccion As Button
    Friend WithEvents txtiplocal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaetitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmodalidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtidrispy As TextBox
    Friend WithEvents Label9 As Label
End Class
