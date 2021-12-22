<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enviar_informe_medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enviar_informe_medico))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblhost = New System.Windows.Forms.Label()
        Me.lblport = New System.Windows.Forms.Label()
        Me.lblemisor = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(244, 95)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(14, 16)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(107, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 37)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "ENVIAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtcorreo
        '
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcorreo.Location = New System.Drawing.Point(30, 37)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(300, 13)
        Me.txtcorreo.TabIndex = 67
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel7.Location = New System.Drawing.Point(30, 56)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 3)
        Me.Panel7.TabIndex = 66
        '
        'lblhost
        '
        Me.lblhost.AutoSize = True
        Me.lblhost.Location = New System.Drawing.Point(478, 32)
        Me.lblhost.Name = "lblhost"
        Me.lblhost.Size = New System.Drawing.Size(16, 13)
        Me.lblhost.TabIndex = 69
        Me.lblhost.Text = "..."
        '
        'lblport
        '
        Me.lblport.AutoSize = True
        Me.lblport.Location = New System.Drawing.Point(478, 56)
        Me.lblport.Name = "lblport"
        Me.lblport.Size = New System.Drawing.Size(16, 13)
        Me.lblport.TabIndex = 70
        Me.lblport.Text = "..."
        '
        'lblemisor
        '
        Me.lblemisor.AutoSize = True
        Me.lblemisor.Location = New System.Drawing.Point(478, 9)
        Me.lblemisor.Name = "lblemisor"
        Me.lblemisor.Size = New System.Drawing.Size(16, 13)
        Me.lblemisor.TabIndex = 71
        Me.lblemisor.Text = "..."
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(478, 86)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(16, 13)
        Me.lblpassword.TabIndex = 72
        Me.lblpassword.Text = "..."
        '
        'enviar_informe_medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 139)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblemisor)
        Me.Controls.Add(Me.lblport)
        Me.Controls.Add(Me.lblhost)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "enviar_informe_medico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar al correo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button4 As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblhost As Label
    Friend WithEvents lblport As Label
    Friend WithEvents lblemisor As Label
    Friend WithEvents lblpassword As Label
End Class
