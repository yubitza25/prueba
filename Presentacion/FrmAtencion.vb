Public Class FrmAtencion
    Private Sub VerPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPacientesToolStripMenuItem.Click
        Dim FormularioAtencion As New FrmListarPaciente
        FormularioAtencion.Show()
    End Sub

    Private Sub FrmAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarConsultaToolStripMenuItem.Click
        Dim FormularioConsulta As New FrmAgregarConsulta
        FormularioConsulta.Show()
    End Sub

    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click

    End Sub
End Class