Imports Datos
Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class EnPaciente
    Private IdAtencion As Integer
    Private Estado As String
    Private Nombres As String
    Private ApellidoPaterno As String
    Private ApellidoMaterno As String
    Private Dni As String
    Private DiagnosticoDescripcion As String
    Private TipoOrdenMedica As String
    Private CostoServicio As Decimal


    Public Property IdAtencion1 As Integer
        Get
            Return IdAtencion
        End Get
        Set(value As Integer)
            IdAtencion = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
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

    Public Property DiagnosticoDescripcion1 As String
        Get
            Return DiagnosticoDescripcion
        End Get
        Set(value As String)
            DiagnosticoDescripcion = value
        End Set
    End Property

    Public Property TipoOrdenMedica1 As String
        Get
            Return TipoOrdenMedica
        End Get
        Set(value As String)
            TipoOrdenMedica = value
        End Set
    End Property

    Public Property CostoServicio1 As Decimal
        Get
            Return CostoServicio
        End Get
        Set(value As Decimal)
            CostoServicio = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Function ListarAtenciones() As DataTable
        Dim dt As New DataTable
        Dim cn As New Conexion
        Dim da As New SqlDataAdapter("ListarAtencionesPacientes", cn.SqlCon1)
        cn.SqlCon1.ConnectionString = "Data Source=DESKTOP-0QM5JAS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;"
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
End Class
