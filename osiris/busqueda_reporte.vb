Public Class busqueda_reporte
    Private Sub busqueda_reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_combobox_centros(cbcentro, main_menu.txtidcentro.Text)
    End Sub
End Class