<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class descagar_estudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(descagar_estudio))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndescargar = New System.Windows.Forms.Button()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlogo = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pbloading = New System.Windows.Forms.PictureBox()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(23, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 3)
        Me.Panel2.TabIndex = 39
        '
        'txtdireccion
        '
        Me.txtdireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtdireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtdireccion.BackColor = System.Drawing.Color.White
        Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdireccion.Location = New System.Drawing.Point(23, 82)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(277, 13)
        Me.txtdireccion.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(20, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Ingrese la carpteta de destino"
        '
        'btndescargar
        '
        Me.btndescargar.BackColor = System.Drawing.Color.SteelBlue
        Me.btndescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndescargar.FlatAppearance.BorderSize = 0
        Me.btndescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescargar.ForeColor = System.Drawing.Color.White
        Me.btndescargar.Location = New System.Drawing.Point(156, 108)
        Me.btndescargar.Name = "btndescargar"
        Me.btndescargar.Size = New System.Drawing.Size(144, 37)
        Me.btndescargar.TabIndex = 37
        Me.btndescargar.Text = "Descargar"
        Me.btndescargar.UseVisualStyleBackColor = False
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(75, 37)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(58, 13)
        Me.lblpaciente.TabIndex = 44
        Me.lblpaciente.Text = "lblpaciente"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(20, 37)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(25, 13)
        Me.lblid.TabIndex = 43
        Me.lblid.Text = "lblid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(75, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "PACIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(20, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ID"
        '
        'btnlogo
        '
        Me.btnlogo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnlogo.FlatAppearance.BorderSize = 0
        Me.btnlogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnlogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogo.ForeColor = System.Drawing.Color.White
        Me.btnlogo.Location = New System.Drawing.Point(306, 78)
        Me.btnlogo.Name = "btnlogo"
        Me.btnlogo.Size = New System.Drawing.Size(37, 20)
        Me.btnlogo.TabIndex = 45
        Me.btnlogo.Text = "..."
        Me.btnlogo.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        '
        'pbloading
        '
        Me.pbloading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbloading.Image = Global.osiris.My.Resources.Resources.Loading_2
        Me.pbloading.Location = New System.Drawing.Point(113, 109)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(37, 34)
        Me.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbloading.TabIndex = 50
        Me.pbloading.TabStop = False
        Me.pbloading.Visible = False
        '
        'descagar_estudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(367, 183)
        Me.Controls.Add(Me.pbloading)
        Me.Controls.Add(Me.btnlogo)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btndescargar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "descagar_estudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descargar estudio"
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btndescargar As Button
    Friend WithEvents lblpaciente As Label
    Friend WithEvents lblid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnlogo As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbloading As PictureBox
End Class
