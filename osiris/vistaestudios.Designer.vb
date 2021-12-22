<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaestudios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlista = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA DE DESTUDIOS DEL PACIENTE"
        '
        'txtlista
        '
        Me.txtlista.Location = New System.Drawing.Point(12, 71)
        Me.txtlista.Multiline = True
        Me.txtlista.Name = "txtlista"
        Me.txtlista.Size = New System.Drawing.Size(503, 153)
        Me.txtlista.TabIndex = 1
        '
        'vistaestudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 254)
        Me.Controls.Add(Me.txtlista)
        Me.Controls.Add(Me.Label1)
        Me.Name = "vistaestudios"
        Me.Text = "vistaestudios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtlista As TextBox
End Class
