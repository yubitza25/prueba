Imports System.Data
Imports Datos
Imports Entidades

Public Class UsuarioLogica
    Private usuarioDatos As New UsuarioDatos()

    Public Function ListarUsuarios() As List(Of Usuario)
        Dim dt As DataTable = usuarioDatos.listarUsuarios() ' Obtén el DataTable
        Dim listaUsuarios As New List(Of Usuario) ' Crea una lista vacía

        ' Recorre el DataTable y llena la lista de usuarios
        For Each row As DataRow In dt.Rows
            Dim usuario As New Usuario()
            usuario.IdUsuario1 = Convert.ToInt32(row("IdUsuario")) ' Asume que la columna es "IdUsuario"
            usuario.NombreUsuario1 = row("nombre_usuario").ToString ' Asume que la columna es "NombreUsuario"
            usuario.Contraseña1 = row("contrasena").ToString() ' Asume que la columna es "Contraseña"
            usuario.DescripcionRol1 = row("descripcionRol").ToString() ' Asume que la columna es "DescripcionRol"

            listaUsuarios.Add(usuario) ' Agrega el usuario a la lista
        Next

        Return listaUsuarios ' Devuelve la lista de usuarios
    End Function

    Public Function BusquedaUsuarios(nombreUsuario As String) As List(Of Usuario)
        Dim dt As DataTable = usuarioDatos.BuscarUsuario(nombreUsuario) ' Obtén el DataTable
        Dim listaUsuarios As New List(Of Usuario) ' Crea una lista vacía

        ' Recorre el DataTable y llena la lista de usuarios
        For Each row As DataRow In dt.Rows
            Dim usuario As New Usuario()
            usuario.IdUsuario1 = Convert.ToInt32(row("idUsuario")) ' Asume que la columna es "idUsuario"
            usuario.NombreUsuario1 = row("nombre_usuario").ToString() ' Asume que la columna es "nombre_usuario"
            usuario.Contraseña1 = row("contrasena").ToString() ' Asume que la columna es "contrasena"
            usuario.DescripcionRol1 = row("descripcionRol").ToString() ' Asume que la columna es "descripcionRol"

            listaUsuarios.Add(usuario) ' Agrega el usuario a la lista
        Next

        Return listaUsuarios ' Devuelve la lista de usuarios
    End Function


End Class
