<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignar_informe
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMedico = New System.Windows.Forms.ComboBox()
        Me.txtestudio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtidmedico = New System.Windows.Forms.TextBox()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.txtidinforme = New System.Windows.Forms.TextBox()
        Me.checkUrgente = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(19, 195)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(385, 4)
        Me.Panel4.TabIndex = 71
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(17, 70)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 4)
        Me.Panel2.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(15, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 17)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Asignar un médico informante"
        '
        'cbMedico
        '
        Me.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMedico.FormattingEnabled = True
        Me.cbMedico.Location = New System.Drawing.Point(19, 164)
        Me.cbMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedico.Name = "cbMedico"
        Me.cbMedico.Size = New System.Drawing.Size(384, 24)
        Me.cbMedico.TabIndex = 68
        '
        'txtestudio
        '
        Me.txtestudio.BackColor = System.Drawing.Color.White
        Me.txtestudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtestudio.Location = New System.Drawing.Point(18, 115)
        Me.txtestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestudio.Name = "txtestudio"
        Me.txtestudio.ReadOnly = True
        Me.txtestudio.Size = New System.Drawing.Size(385, 15)
        Me.txtestudio.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(14, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Estudio realizado"
        '
        'txtpaciente
        '
        Me.txtpaciente.BackColor = System.Drawing.Color.White
        Me.txtpaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpaciente.Location = New System.Drawing.Point(17, 49)
        Me.txtpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.ReadOnly = True
        Me.txtpaciente.Size = New System.Drawing.Size(385, 15)
        Me.txtpaciente.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Nombre del paciente"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(97, 273)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 46)
        Me.Button4.TabIndex = 72
        Me.Button4.Text = "ASIGNAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtidmedico
        '
        Me.txtidmedico.Location = New System.Drawing.Point(4, 244)
        Me.txtidmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmedico.Name = "txtidmedico"
        Me.txtidmedico.Size = New System.Drawing.Size(19, 22)
        Me.txtidmedico.TabIndex = 74
        Me.txtidmedico.Visible = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(4, 273)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(19, 22)
        Me.txtidestudio.TabIndex = 73
        Me.txtidestudio.Visible = False
        '
        'txtidinforme
        '
        Me.txtidinforme.Location = New System.Drawing.Point(4, 214)
        Me.txtidinforme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidinforme.Name = "txtidinforme"
        Me.txtidinforme.Size = New System.Drawing.Size(19, 22)
        Me.txtidinforme.TabIndex = 75
        Me.txtidinforme.Visible = False
        '
        'checkUrgente
        '
        Me.checkUrgente.AutoSize = True
        Me.checkUrgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUrgente.ForeColor = System.Drawing.Color.Maroon
        Me.checkUrgente.Location = New System.Drawing.Point(76, 228)
        Me.checkUrgente.Name = "checkUrgente"
        Me.checkUrgente.Size = New System.Drawing.Size(268, 24)
        Me.checkUrgente.TabIndex = 76
        Me.checkUrgente.Text = "ASIGNAR COMO URGENTE"
        Me.checkUrgente.UseVisualStyleBackColor = True
        '
        'asignar_informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 339)
        Me.Controls.Add(Me.checkUrgente)
        Me.Controls.Add(Me.txtidinforme)
        Me.Controls.Add(Me.txtidmedico)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMedico)
        Me.Controls.Add(Me.txtestudio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpaciente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "asignar_informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar estudio a otro medico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMedico As ComboBox
    Friend WithEvents txtestudio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtidmedico As TextBox
    Friend WithEvents txtidestudio As TextBox
    Friend WithEvents txtidinforme As TextBox
    Friend WithEvents checkUrgente As CheckBox
End Class
