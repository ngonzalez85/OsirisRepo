<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class favoritos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(favoritos))
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbbuscar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthasta = New System.Windows.Forms.DateTimePicker()
        Me.txtidtemp = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesde = New System.Windows.Forms.DateTimePicker()
        Me.txtidcentro_usuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCentro_usuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgContenedor = New System.Windows.Forms.DataGridView()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Location = New System.Drawing.Point(798, 7)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(347, 20)
        Me.txtbuscar.TabIndex = 65
        '
        'cbbuscar
        '
        Me.cbbuscar.FormattingEnabled = True
        Me.cbbuscar.Items.AddRange(New Object() {"paciente", "estudio", "estado", "medico"})
        Me.cbbuscar.Location = New System.Drawing.Point(671, 6)
        Me.cbbuscar.Name = "cbbuscar"
        Me.cbbuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbbuscar.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(615, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Filtrar por"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(490, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "al"
        '
        'txthasta
        '
        Me.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txthasta.Location = New System.Drawing.Point(511, 7)
        Me.txthasta.Name = "txthasta"
        Me.txthasta.Size = New System.Drawing.Size(98, 20)
        Me.txthasta.TabIndex = 62
        '
        'txtidtemp
        '
        Me.txtidtemp.Location = New System.Drawing.Point(1130, 15)
        Me.txtidtemp.Name = "txtidtemp"
        Me.txtidtemp.Size = New System.Drawing.Size(15, 20)
        Me.txtidtemp.TabIndex = 69
        Me.txtidtemp.Visible = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnactualizar.BackColor = System.Drawing.Color.White
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.FlatAppearance.BorderSize = 0
        Me.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizar.ForeColor = System.Drawing.Color.White
        Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
        Me.btnactualizar.Location = New System.Drawing.Point(1151, 5)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(30, 30)
        Me.btnactualizar.TabIndex = 67
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Fecha de subida"
        '
        'txtdesde
        '
        Me.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdesde.Location = New System.Drawing.Point(386, 7)
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(98, 20)
        Me.txtdesde.TabIndex = 60
        '
        'txtidcentro_usuario
        '
        Me.txtidcentro_usuario.Location = New System.Drawing.Point(1109, 15)
        Me.txtidcentro_usuario.Name = "txtidcentro_usuario"
        Me.txtidcentro_usuario.Size = New System.Drawing.Size(15, 20)
        Me.txtidcentro_usuario.TabIndex = 66
        Me.txtidcentro_usuario.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Centros disponibles"
        '
        'cbCentro_usuario
        '
        Me.cbCentro_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCentro_usuario.FormattingEnabled = True
        Me.cbCentro_usuario.Location = New System.Drawing.Point(126, 6)
        Me.cbCentro_usuario.Name = "cbCentro_usuario"
        Me.cbCentro_usuario.Size = New System.Drawing.Size(145, 21)
        Me.cbCentro_usuario.TabIndex = 58
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgContenedor)
        Me.GroupBox2.Controls.Add(Me.txtprueba)
        Me.GroupBox2.Controls.Add(Me.rtb1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 510)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de estuios"
        '
        'dgContenedor
        '
        Me.dgContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContenedor.Location = New System.Drawing.Point(41, 40)
        Me.dgContenedor.Name = "dgContenedor"
        Me.dgContenedor.Size = New System.Drawing.Size(373, 373)
        Me.dgContenedor.TabIndex = 56
        '
        'txtprueba
        '
        Me.txtprueba.Location = New System.Drawing.Point(1083, 312)
        Me.txtprueba.Name = "txtprueba"
        Me.txtprueba.Size = New System.Drawing.Size(51, 20)
        Me.txtprueba.TabIndex = 55
        Me.txtprueba.Visible = False
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(1034, 338)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(100, 96)
        Me.rtb1.TabIndex = 9
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'favoritos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 561)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cbbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthasta)
        Me.Controls.Add(Me.txtidtemp)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesde)
        Me.Controls.Add(Me.txtidcentro_usuario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbCentro_usuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "favoritos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "º"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbbuscar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txthasta As DateTimePicker
    Friend WithEvents txtidtemp As TextBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdesde As DateTimePicker
    Friend WithEvents txtidcentro_usuario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCentro_usuario As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtprueba As TextBox
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents dgContenedor As DataGridView
End Class
