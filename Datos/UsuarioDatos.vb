Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class UsuarioDatos
    Public Function listarUsuarios() As DataTable
        Dim dt As New DataTable
        Dim cn As New Conexion
        Dim da As New SqlDataAdapter("ListarUsuarios", cn.SqlCon1)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        ' Abrir conexión
        If cn.SqlCon1.State = ConnectionState.Closed Then
            cn.SqlCon1.Open()
        End If

        da.Fill(dt)

        Return dt
    End Function

    Public Function BuscarUsuario(nombreUsuario As String) As DataTable
        Dim dt As New DataTable
        Dim cn As New Conexion
        Dim da As New SqlDataAdapter("BuscarUsuarioPorNombre", cn.SqlCon1)

        ' Agregar el parámetro
        da.SelectCommand.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        ' Abrir conexión
        If cn.SqlCon1.State = ConnectionState.Closed Then
            cn.SqlCon1.Open()
        End If

        da.Fill(dt)

        Return dt
    End Function


End Class
