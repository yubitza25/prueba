Imports Entidades
Imports Logica

Public Class FrmListarUsuarios
    Private Sub FrmListarUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim logica As New UsuarioLogica()
        Dim listaUsuarios As List(Of Usuario) = logica.ListarUsuarios()

        ' Asigna la lista de usuarios directamente al DataGridView
        Me.DgTablaUsuarios.DataSource = listaUsuarios

        DgTablaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub DgTablaUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgTablaUsuarios.CellContentClick

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim logica As New UsuarioLogica()

        ' Obtiene el nombre de usuario a buscar desde el TextBox
        Dim nombreBuscar As String = TxtBuscar.Text.Trim()

        ' Llama a la lógica para buscar usuarios por el nombre
        Dim busquedaUsuarios As List(Of Usuario) = logica.BusquedaUsuarios(nombreBuscar)

        ' Asigna la lista de usuarios directamente al DataGridView
        Me.DgTablaUsuarios.DataSource = busquedaUsuarios

        DgTablaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
End Class
