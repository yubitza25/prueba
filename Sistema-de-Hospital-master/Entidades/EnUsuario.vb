' Entidades/EnUsuario.vb
Imports Microsoft.Data.SqlClient
Imports System.Data
Imports Datos

Public Class EnUsuario
    Private idUsuario As Integer
    Private descripcionRol As String
    Private nombreUsuario As String
    Private contraseña As String

    Public Property IdUsuario1 As Integer
        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property

    Public Property DescripcionRol1 As String
        Get
            Return descripcionRol
        End Get
        Set(value As String)
            descripcionRol = value
        End Set
    End Property

    Public Property NombreUsuario1 As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property Contraseña1 As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Function listarUsuarios() As DataTable

        Dim dt As New DataTable

        Dim cn As New Conexion

        Dim da As New SqlDataAdapter("ListarUsuarios", cn.SqlCon1)

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.Fill(dt)

        Return dt

    End Function

End Class
