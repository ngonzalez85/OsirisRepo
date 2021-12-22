Imports MySql.Data.MySqlClient
Imports System.IO
Public Class asignar_informe
    Private Sub asignar_informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbMedico.Items.Clear()
        llenar_combobox_medicos(cbMedico, main_menu.txtidcentro.Text)
    End Sub

    Private Sub cbMedico_TextChanged(sender As Object, e As EventArgs) Handles cbMedico.TextChanged
        If cbMedico.Text <> "" Then
            consultar_medico(cbMedico.Text)
            If dr.Read Then
                txtidmedico.Text = dr(0)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            'MessageBox.Show("El estudio que desea reasignar se encuentra en proceso de redacción", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dim ask As MsgBoxResult = MsgBox("Esta seguro que desea REASIGNAR el estudio?. El estudio que selecionó se encuentra en proceso de redacción por otro médico informante", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                consultar_ultimo_informe(txtidestudio.Text)
                If dr.Read Then
                    txtidinforme.Text = dr(0)
                End If
                If checkUrgente.Checked = True Then
                    reasignar_estudio(txtidestudio.Text, txtidmedico.Text, txtidmedico.Text, txtidinforme.Text, 3)
                Else
                    reasignar_estudio(txtidestudio.Text, txtidmedico.Text, txtidmedico.Text, txtidinforme.Text, 1)
                End If
                reasignar_informe(txtidestudio.Text, txtidmedico.Text)
                MessageBox.Show("Asignado correctamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtidinforme.Clear()
                Me.Close()
                Dim LFA As New List(Of Form)
                LFA.Clear()
                For Each FRM As Form In Application.OpenForms
                    If FRM.Name = "main_menu" Then
                    ElseIf FRM.Name = "informes" Then

                    Else
                        LFA.Add(FRM)
                    End If
                Next
                Dim X As Integer
                For X = 0 To LFA.Count - 1
                    LFA(X).Close()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class