<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiar_clave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cambiar_clave))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblreqpass = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtveridicar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncambiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblreqpass)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtveridicar)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtclave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btncambiar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 202)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio de clave del usuario"
        '
        'lblreqpass
        '
        Me.lblreqpass.AutoSize = True
        Me.lblreqpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreqpass.ForeColor = System.Drawing.Color.DimGray
        Me.lblreqpass.Location = New System.Drawing.Point(191, 88)
        Me.lblreqpass.Name = "lblreqpass"
        Me.lblreqpass.Size = New System.Drawing.Size(17, 24)
        Me.lblreqpass.TabIndex = 38
        Me.lblreqpass.Text = "*"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(26, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 3)
        Me.Panel1.TabIndex = 37
        '
        'txtveridicar
        '
        Me.txtveridicar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtveridicar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtveridicar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtveridicar.Location = New System.Drawing.Point(26, 104)
        Me.txtveridicar.Name = "txtveridicar"
        Me.txtveridicar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtveridicar.Size = New System.Drawing.Size(277, 13)
        Me.txtveridicar.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(26, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 3)
        Me.Panel2.TabIndex = 35
        '
        'txtclave
        '
        Me.txtclave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtclave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtclave.Location = New System.Drawing.Point(26, 57)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(277, 13)
        Me.txtclave.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(23, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Vuelva a ingresar la nueva clave"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(23, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ingrese la nueva clave"
        '
        'btncambiar
        '
        Me.btncambiar.BackColor = System.Drawing.Color.SteelBlue
        Me.btncambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncambiar.FlatAppearance.BorderSize = 0
        Me.btncambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncambiar.ForeColor = System.Drawing.Color.White
        Me.btncambiar.Location = New System.Drawing.Point(174, 139)
        Me.btncambiar.Name = "btncambiar"
        Me.btncambiar.Size = New System.Drawing.Size(129, 37)
        Me.btncambiar.TabIndex = 33
        Me.btncambiar.Text = "Cambiar clave"
        Me.btncambiar.UseVisualStyleBackColor = False
        '
        'cambiar_clave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 228)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cambiar_clave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btncambiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtveridicar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtclave As TextBox
    Friend WithEvents lblreqpass As Label
End Class
