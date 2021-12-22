<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verestudios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verestudios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.txtarchivo = New System.Windows.Forms.TextBox()
        Me.txtidmodificado = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btndescargar = New System.Windows.Forms.Button()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = Global.osiris.My.Resources.Resources.close
        Me.btncerrar.Location = New System.Drawing.Point(634, 13)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(27, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 54
        Me.btncerrar.TabStop = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(519, 46)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(33, 22)
        Me.txtidestudio.TabIndex = 101
        Me.txtidestudio.Visible = False
        '
        'txtarchivo
        '
        Me.txtarchivo.Location = New System.Drawing.Point(478, 46)
        Me.txtarchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtarchivo.Name = "txtarchivo"
        Me.txtarchivo.Size = New System.Drawing.Size(33, 22)
        Me.txtarchivo.TabIndex = 100
        Me.txtarchivo.Visible = False
        '
        'txtidmodificado
        '
        Me.txtidmodificado.Location = New System.Drawing.Point(437, 46)
        Me.txtidmodificado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmodificado.Name = "txtidmodificado"
        Me.txtidmodificado.Size = New System.Drawing.Size(33, 22)
        Me.txtidmodificado.TabIndex = 99
        Me.txtidmodificado.Visible = False
        '
        'btndescargar
        '
        Me.btndescargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndescargar.FlatAppearance.BorderSize = 0
        Me.btndescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescargar.ForeColor = System.Drawing.Color.White
        Me.btndescargar.Image = CType(resources.GetObject("btndescargar.Image"), System.Drawing.Image)
        Me.btndescargar.Location = New System.Drawing.Point(570, 269)
        Me.btndescargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btndescargar.Name = "btndescargar"
        Me.btndescargar.Size = New System.Drawing.Size(86, 73)
        Me.btndescargar.TabIndex = 103
        Me.btndescargar.UseVisualStyleBackColor = False
        Me.btndescargar.Visible = False
        '
        'dgContenedor
        '
        Me.dgContenedor.AllowUserToAddRows = False
        Me.dgContenedor.AllowUserToDeleteRows = False
        Me.dgContenedor.AllowUserToResizeRows = False
        Me.dgContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgContenedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgContenedor.BackgroundColor = System.Drawing.Color.White
        Me.dgContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgContenedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgContenedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContenedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.EnableHeadersVisualStyles = False
        Me.dgContenedor.Location = New System.Drawing.Point(34, 146)
        Me.dgContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.ReadOnly = True
        Me.dgContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgContenedor.RowHeadersVisible = False
        Me.dgContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContenedor.Size = New System.Drawing.Size(528, 196)
        Me.dgContenedor.TabIndex = 102
        '
        'lblpaciente
        '
        Me.lblpaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblpaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaciente.ForeColor = System.Drawing.Color.White
        Me.lblpaciente.Location = New System.Drawing.Point(30, 13)
        Me.lblpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(83, 24)
        Me.lblpaciente.TabIndex = 104
        Me.lblpaciente.Text = "Paciente"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "ESTUDIOS MODIFICADOS"
        '
        'verestudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 383)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.btndescargar)
        Me.Controls.Add(Me.dgContenedor)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.txtarchivo)
        Me.Controls.Add(Me.txtidmodificado)
        Me.Controls.Add(Me.btncerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "verestudios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "verestudios"
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents txtidestudio As TextBox
    Friend WithEvents txtarchivo As TextBox
    Friend WithEvents txtidmodificado As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btndescargar As Button
    Friend WithEvents dgContenedor As DataGridView
    Friend WithEvents lblpaciente As Label
    Friend WithEvents Label1 As Label
End Class
