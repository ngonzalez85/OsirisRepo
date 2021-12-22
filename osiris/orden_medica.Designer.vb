<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orden_medica
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
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.txtidcentro = New System.Windows.Forms.TextBox()
        Me.txtidestudio = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblpaciente
        '
        Me.lblpaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblpaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblpaciente.Location = New System.Drawing.Point(13, 18)
        Me.lblpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(83, 24)
        Me.lblpaciente.TabIndex = 66
        Me.lblpaciente.Text = "Paciente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 65)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(428, 234)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adjuntos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(25, 23)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(371, 174)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TreeView2)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(363, 145)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Medvital"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TreeView2
        '
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView2.Location = New System.Drawing.Point(4, 4)
        Me.TreeView2.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(355, 137)
        Me.TreeView2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TreeView3)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(363, 145)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Osiris"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TreeView3
        '
        Me.TreeView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView3.Location = New System.Drawing.Point(4, 4)
        Me.TreeView3.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.Size = New System.Drawing.Size(355, 137)
        Me.TreeView3.TabIndex = 1
        '
        'txtidcita
        '
        Me.txtidcita.Location = New System.Drawing.Point(272, 310)
        Me.txtidcita.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(36, 22)
        Me.txtidcita.TabIndex = 69
        Me.txtidcita.Text = "0"
        Me.txtidcita.Visible = False
        '
        'txtidcentro
        '
        Me.txtidcentro.Location = New System.Drawing.Point(316, 310)
        Me.txtidcentro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcentro.Name = "txtidcentro"
        Me.txtidcentro.Size = New System.Drawing.Size(36, 22)
        Me.txtidcentro.TabIndex = 68
        Me.txtidcentro.Visible = False
        '
        'txtidestudio
        '
        Me.txtidestudio.Location = New System.Drawing.Point(232, 310)
        Me.txtidestudio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidestudio.Name = "txtidestudio"
        Me.txtidestudio.Size = New System.Drawing.Size(32, 22)
        Me.txtidestudio.TabIndex = 70
        Me.txtidestudio.Visible = False
        '
        'orden_medica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(476, 348)
        Me.Controls.Add(Me.txtidestudio)
        Me.Controls.Add(Me.txtidcita)
        Me.Controls.Add(Me.txtidcentro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblpaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "orden_medica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARCHIVOS "
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblpaciente As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TreeView3 As TreeView
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents txtidcentro As TextBox
    Friend WithEvents txtidestudio As TextBox
End Class
