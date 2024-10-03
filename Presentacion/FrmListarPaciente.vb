Imports Entidades

Public Class FrmListarPaciente

    Private Sub FrmListarAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable
        Dim Aten As New EnPaciente
        tabla = Aten.ListarAtenciones()
        Me.DGVListaPaciente.DataSource = tabla

        DGVListaPaciente.Columns("idAtencion").HeaderText = "ID Atencion"
        DGVListaPaciente.Columns("NombreCompleto").HeaderText = "Paciente"
        DGVListaPaciente.Columns("dni").HeaderText = "DNI"
        DGVListaPaciente.Columns("DiagnosticoDescripcion").HeaderText = "Diagnostico"
        DGVListaPaciente.Columns("TipoOrdenMedica").HeaderText = "Tipo Orden Medica"
        DGVListaPaciente.Columns("CostoServicio").HeaderText = "Costo"
        DGVListaPaciente.Columns("estado").HeaderText = "Estado"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DGVListaPaciente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaPaciente.CellContentClick

    End Sub
End Class