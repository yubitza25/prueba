Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Datos

Public Class Usuario
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

    Public Sub New(idUsuario As Integer, descripcionRol As String, nombreUsuario As String, contraseña As String, idUsuario1 As Integer, descripcionRol1 As String, nombreUsuario1 As String, contraseña1 As String)
        Me.idUsuario = idUsuario
        Me.descripcionRol = descripcionRol
        Me.nombreUsuario = nombreUsuario
        Me.contraseña = contraseña
        Me.IdUsuario1 = idUsuario1
        Me.DescripcionRol1 = descripcionRol1
        Me.NombreUsuario1 = nombreUsuario1
        Me.Contraseña1 = contraseña1
    End Sub
End Class

