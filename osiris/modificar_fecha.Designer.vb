<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_fecha
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txthora_entrega = New System.Windows.Forms.DateTimePicker()
        Me.txtfecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(238, 53)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 25)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Hora"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(26, 53)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 25)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Fecha"
        '
        'txthora_entrega
        '
        Me.txthora_entrega.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.txthora_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txthora_entrega.Location = New System.Drawing.Point(300, 50)
        Me.txthora_entrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txthora_entrega.Name = "txthora_entrega"
        Me.txthora_entrega.ShowUpDown = True
        Me.txthora_entrega.Size = New System.Drawing.Size(125, 30)
        Me.txthora_entrega.TabIndex = 39
        '
        'txtfecha_entrega
        '
        Me.txtfecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_entrega.Location = New System.Drawing.Point(101, 50)
        Me.txtfecha_entrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha_entrega.Name = "txtfecha_entrega"
        Me.txtfecha_entrega.Size = New System.Drawing.Size(129, 30)
        Me.txtfecha_entrega.TabIndex = 37
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.osiris.My.Resources.Resources.floppy_disk
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(147, 102)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 46)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "GUARDAR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(329, 118)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(21, 30)
        Me.txtidestudio.TabIndex = 73
        Me.txtidestudio.Visible = False
        '
        'modificar_fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(458, 173)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txthora_entrega)
        Me.Controls.Add(Me.txtfecha_entrega)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "modificar_fecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar fecha de entrega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txthora_entrega As DateTimePicker
    Friend WithEvents txtfecha_entrega As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents txtidestudio As TextBox
End Class
