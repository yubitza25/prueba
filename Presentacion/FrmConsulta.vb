Public Class FrmAgregarConsulta


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim FormularioAgregarConsulta As New FrmAgregarConsultaDiagnostico
        FormularioAgregarConsulta.Show()
    End Sub
End Class