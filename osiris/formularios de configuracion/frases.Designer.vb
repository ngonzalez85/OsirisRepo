<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frases
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtidfrase = New System.Windows.Forms.TextBox()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.btnaccion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtidfrase)
        Me.GroupBox1.Controls.Add(Me.dgContenedor)
        Me.GroupBox1.Controls.Add(Me.btnaccion)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(639, 395)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de tus frases"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Silver
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.osiris.My.Resources.Resources.floppy_disk
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(290, 315)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 58)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        Me.btnNuevo.Visible = False
        '
        'txtidfrase
        '
        Me.txtidfrase.Location = New System.Drawing.Point(35, 348)
        Me.txtidfrase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidfrase.Name = "txtidfrase"
        Me.txtidfrase.Size = New System.Drawing.Size(32, 22)
        Me.txtidfrase.TabIndex = 20
        Me.txtidfrase.Visible = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
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
        Me.dgContenedor.Location = New System.Drawing.Point(35, 37)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(569, 271)
        Me.dgContenedor.TabIndex = 19
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
        Me.btnaccion.Location = New System.Drawing.Point(451, 315)
        Me.btnaccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaccion.Name = "btnaccion"
        Me.btnaccion.Size = New System.Drawing.Size(153, 58)
        Me.btnaccion.TabIndex = 10
        Me.btnaccion.Text = "AGREGAR"
        Me.btnaccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaccion.UseVisualStyleBackColor = False
        '
        'frases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 446)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frases"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidfrase As TextBox
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents btnaccion As Button
    Friend WithEvents btnNuevo As Button
End Class
