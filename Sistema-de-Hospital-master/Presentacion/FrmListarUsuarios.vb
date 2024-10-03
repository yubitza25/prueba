Imports Entidades
Imports Datos

Public Class FrmListarUsuarios
    Private Sub FrmListarUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tabla As DataTable
        Dim user As New EnUsuario
        tabla = user.listarUsuarios()
        Me.DgTablaUsuarios.DataSource = tabla

        DgTablaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Cambiar los nombres de las columnas
        DgTablaUsuarios.Columns("idUsuario").HeaderText = "ID Usuario"
        DgTablaUsuarios.Columns("nombre_usuario").HeaderText = "Nombre del Usuario"
        DgTablaUsuarios.Columns("contrasena").HeaderText = "Contraseña"
        DgTablaUsuarios.Columns("Rol").HeaderText = "Rol"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim agregar As New FrmRegistrarUsuario
        agregar.ShowDialog()
    End Sub

    Private Sub DgTablaUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgTablaUsuarios.CellContentClick

    End Sub
End Class