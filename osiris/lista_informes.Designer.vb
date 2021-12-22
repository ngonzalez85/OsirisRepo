<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lista_informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lista_informes))
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.informe = New System.Windows.Forms.ToolStripMenuItem()
        Me.reimprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ver_imagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
        Me.dgContenedor.BackgroundColor = System.Drawing.Color.White
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgContenedor.Location = New System.Drawing.Point(0, 0)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(1239, 510)
        Me.dgContenedor.TabIndex = 6
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(1009, 52)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(100, 20)
        Me.txtflag.TabIndex = 7
        Me.txtflag.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.informe, Me.reimprimir, Me.ver_imagen})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 70)
        Me.ContextMenuStrip1.Text = "Operaciones"
        '
        'informe
        '
        Me.informe.Name = "informe"
        Me.informe.Size = New System.Drawing.Size(167, 22)
        Me.informe.Text = "Ver informe (PDF)"
        '
        'reimprimir
        '
        Me.reimprimir.Name = "reimprimir"
        Me.reimprimir.Size = New System.Drawing.Size(167, 22)
        Me.reimprimir.Text = "Reimprimir"
        '
        'ver_imagen
        '
        Me.ver_imagen.Name = "ver_imagen"
        Me.ver_imagen.Size = New System.Drawing.Size(167, 22)
        Me.ver_imagen.Text = "Visualizar estudio"
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(1127, 402)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(100, 96)
        Me.rtb1.TabIndex = 8
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'txtprueba
        '
        Me.txtprueba.Location = New System.Drawing.Point(12, 478)
        Me.txtprueba.Name = "txtprueba"
        Me.txtprueba.Size = New System.Drawing.Size(51, 20)
        Me.txtprueba.TabIndex = 54
        Me.txtprueba.Visible = False
        '
        'lista_informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 510)
        Me.Controls.Add(Me.txtprueba)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.dgContenedor)
        Me.Controls.Add(Me.txtflag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "lista_informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de informes"
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents txtflag As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents informe As ToolStripMenuItem
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents reimprimir As ToolStripMenuItem
    Friend WithEvents txtprueba As TextBox
    Friend WithEvents ver_imagen As ToolStripMenuItem
End Class
