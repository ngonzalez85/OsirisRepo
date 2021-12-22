<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class procedimientos_centros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(procedimientos_centros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcomision = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtidprocedimiento_centro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.txtprocedimiento = New System.Windows.Forms.TextBox()
        Me.cbcentro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidprocedimiento = New System.Windows.Forms.TextBox()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcomision)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.txtidprocedimiento_centro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtidcentro)
        Me.GroupBox1.Controls.Add(Me.txtprocedimiento)
        Me.GroupBox1.Controls.Add(Me.cbcentro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidprocedimiento)
        Me.GroupBox1.Controls.Add(Me.dgContenedor)
        Me.GroupBox1.Controls.Add(Me.btnAccion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 446)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignación de precios"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(309, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ver lista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Comisión por uso de software"
        '
        'txtcomision
        '
        Me.txtcomision.Location = New System.Drawing.Point(359, 85)
        Me.txtcomision.Name = "txtcomision"
        Me.txtcomision.Size = New System.Drawing.Size(239, 20)
        Me.txtcomision.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Precio por informe realizado"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(28, 85)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(277, 20)
        Me.txtprecio.TabIndex = 9
        '
        'txtidprocedimiento_centro
        '
        Me.txtidprocedimiento_centro.Location = New System.Drawing.Point(262, 19)
        Me.txtidprocedimiento_centro.Name = "txtidprocedimiento_centro"
        Me.txtidprocedimiento_centro.Size = New System.Drawing.Size(23, 20)
        Me.txtidprocedimiento_centro.TabIndex = 3
        Me.txtidprocedimiento_centro.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(25, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "LIMPIAR CAMPOS"
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(233, 19)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(23, 20)
        Me.txtidcentro.TabIndex = 2
        Me.txtidcentro.Visible = False
        '
        'txtprocedimiento
        '
        Me.txtprocedimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtprocedimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtprocedimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprocedimiento.Location = New System.Drawing.Point(28, 45)
        Me.txtprocedimiento.Name = "txtprocedimiento"
        Me.txtprocedimiento.Size = New System.Drawing.Size(277, 20)
        Me.txtprocedimiento.TabIndex = 1
        '
        'cbcentro
        '
        Me.cbcentro.FormattingEnabled = True
        Me.cbcentro.Location = New System.Drawing.Point(359, 44)
        Me.cbcentro.Name = "cbcentro"
        Me.cbcentro.Size = New System.Drawing.Size(239, 21)
        Me.cbcentro.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seleccione un centro"
        '
        'txtidprocedimiento
        '
        Me.txtidprocedimiento.Location = New System.Drawing.Point(291, 19)
        Me.txtidprocedimiento.Name = "txtidprocedimiento"
        Me.txtidprocedimiento.Size = New System.Drawing.Size(23, 20)
        Me.txtidprocedimiento.TabIndex = 4
        Me.txtidprocedimiento.Visible = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
        Me.dgContenedor.BackgroundColor = System.Drawing.Color.White
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.Location = New System.Drawing.Point(28, 205)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(570, 209)
        Me.dgContenedor.TabIndex = 14
        '
        'btnAccion
        '
        Me.btnAccion.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAccion.FlatAppearance.BorderSize = 0
        Me.btnAccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccion.ForeColor = System.Drawing.Color.White
        Me.btnAccion.Location = New System.Drawing.Point(378, 126)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(220, 47)
        Me.btnAccion.TabIndex = 13
        Me.btnAccion.Text = "AGREGAR"
        Me.btnAccion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción del procedimiento"
        '
        'procedimientos_centros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "procedimientos_centros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas de procedimientos por centro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtidprocedimiento_centro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents txtprocedimiento As TextBox
    Friend WithEvents cbcentro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidprocedimiento As TextBox
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents btnAccion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcomision As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
