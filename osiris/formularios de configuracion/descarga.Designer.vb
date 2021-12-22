<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class descarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(descarga))
        Me.pbloading = New System.Windows.Forms.PictureBox()
        Me.lblestado = New System.Windows.Forms.Label()
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbloading
        '
        Me.pbloading.Image = Global.osiris.My.Resources.Resources.Loading_2
        Me.pbloading.Location = New System.Drawing.Point(16, 15)
        Me.pbloading.Name = "pbloading"
        Me.pbloading.Size = New System.Drawing.Size(37, 34)
        Me.pbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbloading.TabIndex = 50
        Me.pbloading.TabStop = False
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.White
        Me.lblestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblestado.Location = New System.Drawing.Point(54, 23)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(521, 18)
        Me.lblestado.TabIndex = 49
        Me.lblestado.Text = "DESCARGANDO EL ESTUDIO ANTERIOR, POR FAVOR ESPERE..."
        '
        'descarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 62)
        Me.Controls.Add(Me.pbloading)
        Me.Controls.Add(Me.lblestado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "descarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Descargando"
        CType(Me.pbloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbloading As PictureBox
    Friend WithEvents lblestado As Label
End Class
