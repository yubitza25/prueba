Imports Datos
Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class EnPersona
    Private IdPersona As Integer
    Private IdRol As Integer
    Private Nombres As String
    Private ApellidoPaterno As String
    Private ApellidoMaterno As String
    Private Dni As String
    Private FechaNacimiento As String

    Public Property IdPersona1 As Integer
        Get
            Return IdPersona
        End Get
        Set(value As Integer)
            IdPersona = value
        End Set
    End Property

    Public Property IdRol1 As Integer
        Get
            Return IdRol
        End Get
        Set(value As Integer)
            IdRol = value
        End Set
    End Property

    Public Property Nombres1 As String
        Get
            Return Nombres
        End Get
        Set(value As String)
            Nombres = value
        End Set
    End Property

    Public Property ApellidoPaterno1 As String
        Get
            Return ApellidoPaterno
        End Get
        Set(value As String)
            ApellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno1 As String
        Get
            Return ApellidoMaterno
        End Get
        Set(value As String)
            ApellidoMaterno = value
        End Set
    End Property

    Public Property Dni1 As String
        Get
            Return Dni
        End Get
        Set(value As String)
            Dni = value
        End Set
    End Property

    Public Property FechaNacimiento1 As String
        Get
            Return FechaNacimiento
        End Get
        Set(value As String)
            FechaNacimiento = value
        End Set
    End Property

    Public Function listarClientes() As DataTable

        Dim dt As New DataTable
        Dim cn As New Conexion
        Dim da As New SqlDataAdapter("ListarPersonas", cn.SqlCon1)
        cn.SqlCon1.ConnectionString = "Data Source=DESKTOP-KMFS1FS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;"
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt

    End Function

End Class
