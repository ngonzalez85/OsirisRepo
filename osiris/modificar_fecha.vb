Public Class modificar_fecha
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        modificar_fechaentrega(txtidestudio.Text, txtfecha_entrega.Text, txthora_entrega.Text)
        Me.Close()
        busqueda_estudios.llenar_datagridview_estudios("fecha")
        MessageBox.Show("Modificado correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class