Imports System.Data.SqlClient


Public Class Contrato
    Private MstrIdContrato As Integer
    Private MstrFecha As Date
    Private MstrIdPaquete As Integer
    Private MstrTipoDePago As String
    Private MstrIdMercanciaVendida As Integer
    Private MstrDepositoSeguridad As Double
    Private MstrIdUsuario As Integer
    Private MstrCantidadPaquete As Double
    Private MstrCantidadMercancia As Double
    Private MstrCantidadTotal As Double
    Private MstrCancelado As Boolean
    Private MstrContexto As String

    Public Property IdContrato() As Integer
        Get
            Return MstrIdContrato
        End Get
        Set(ByVal value As Integer)
            MstrIdContrato = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return MstrFecha
        End Get
        Set(ByVal value As Date)
            MstrFecha = value
        End Set
    End Property

    Public Property IdPaquete() As Integer
        Get
            Return MstrIdPaquete
        End Get
        Set(ByVal value As Integer)
            MstrIdPaquete = value
        End Set
    End Property

    Public Property TipoDePago() As String
        Get
            Return MstrTipoDePago
        End Get
        Set(ByVal value As String)
            MstrTipoDePago = value
        End Set
    End Property

    Public Property IdMercanciaVendida() As Integer
        Get
            Return MstrIdMercanciaVendida
        End Get
        Set(ByVal value As Integer)
            MstrIdMercanciaVendida = value
        End Set
    End Property

    Public Property DepositoSeguridad() As Double
        Get
            Return MstrDepositoSeguridad
        End Get
        Set(ByVal value As Double)
            MstrDepositoSeguridad = value
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return MstrIdUsuario
        End Get
        Set(ByVal value As Integer)
            MstrIdUsuario = value
        End Set
    End Property

    Public Property CantidadPaquete() As Double
        Get
            Return MstrCantidadPaquete
        End Get
        Set(ByVal value As Double)
            MstrCantidadPaquete = value
        End Set
    End Property

    Public Property CantidadMercancia() As Double
        Get
            Return MstrCantidadMercancia
        End Get
        Set(ByVal value As Double)
            MstrCantidadMercancia = value
        End Set
    End Property

    Public Property CantidadTotal() As Double
        Get
            Return MstrCantidadTotal
        End Get
        Set(ByVal value As Double)
            MstrCantidadTotal = value
        End Set
    End Property

    Public Property Cancelado() As Boolean
        Get
            Return MstrCancelado
        End Get
        Set(ByVal value As Boolean)
            MstrCancelado = value
        End Set
    End Property

    Public Property Contexto() As String
        Get
            Return MstrContexto
        End Get
        Set(ByVal value As String)
            MstrContexto = value
        End Set
    End Property

    Public Function InsertarContrato() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.InsertarContrato", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Fecha", MstrFecha))
        cmd.Parameters.Add(New SqlParameter("@IdPaquete", MstrIdPaquete))
        cmd.Parameters.Add(New SqlParameter("@TipodePago", MstrTipoDePago))
        cmd.Parameters.Add(New SqlParameter("@idMercanciaVendida", MstrIdMercanciaVendida))
        cmd.Parameters.Add(New SqlParameter("@DepositoSeguridad", MstrDepositoSeguridad))
        cmd.Parameters.Add(New SqlParameter("@idUsuario", MstrIdUsuario))
        cmd.Parameters.Add(New SqlParameter("@CantidadPaquete", MstrCantidadPaquete))
        cmd.Parameters.Add(New SqlParameter("@CantidadMercancia", MstrCantidadMercancia))
        cmd.Parameters.Add(New SqlParameter("@CantidadTotal", MstrCantidadTotal))
        cmd.Parameters.Add(New SqlParameter("@Cancelado", MstrCancelado))
        cmd.Parameters.Add(New SqlParameter("@Contexto", MstrContexto))

        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()

        Return True
    End Function


    Public Function EliminarContrato() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.EliminarContratoPorId", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idContrato", MstrIdContrato))

        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()

        Return True
    End Function

    Public Function ActualizarContrato() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.ActualizarContratoPorId", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Fecha", MstrFecha))
        cmd.Parameters.Add(New SqlParameter("@IdPaquete", MstrIdPaquete))
        cmd.Parameters.Add(New SqlParameter("@TipodePago", MstrTipoDePago))
        cmd.Parameters.Add(New SqlParameter("@idMercanciaVendida", MstrIdMercanciaVendida))
        cmd.Parameters.Add(New SqlParameter("@DepositoSeguridad", MstrDepositoSeguridad))
        cmd.Parameters.Add(New SqlParameter("@idUsuario", MstrIdUsuario))
        cmd.Parameters.Add(New SqlParameter("@CantidadPaquete", MstrCantidadPaquete))
        cmd.Parameters.Add(New SqlParameter("@CantidadMercancia", MstrCantidadMercancia))
        cmd.Parameters.Add(New SqlParameter("@CantidadTotal", MstrCantidadTotal))
        cmd.Parameters.Add(New SqlParameter("@Cancelado", MstrCancelado))
        cmd.Parameters.Add(New SqlParameter("@Contexto", MstrContexto))
        cmd.Parameters.Add(New SqlParameter("@Id", MstrIdContrato))

        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()

        Return True
    End Function

    Public Function BuscarContratoPorId() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("BuscarContratoPorId", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idContrato", MstrIdContrato))

        Dim Fecha1 As Date
        Dim IdPaquete1 As Integer
        Dim TipodePago1 As String
        Dim idMercanciaVendida1 As Integer
        Dim DepositoSeguridad1 As Double
        Dim idUsuario1 As Integer
        Dim CantidadPaquete1 As Double
        Dim CantidadMercancia1 As Double
        Dim CantidadTotal1 As Double
        Dim Cancelado1 As Boolean
        Dim Contexto1 As String

        Dim encontro As Boolean

        cnx.Close()
        cnx.Open()

        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        If reader.Read() Then
            Fecha1 = reader.GetDateTime(reader.GetOrdinal("Fecha"))
            IdPaquete1 = reader.GetInt32(reader.GetOrdinal("IdPaquete"))
            TipodePago1 = reader.GetString(reader.GetOrdinal("TipodePago"))
            idMercanciaVendida1 = reader.GetInt32(reader.GetOrdinal("idMercanciaVendida"))
            DepositoSeguridad1 = reader.GetDouble(reader.GetOrdinal("DepositoSeguridad"))
            idUsuario1 = reader.GetInt32(reader.GetOrdinal("idUsuario"))
            CantidadPaquete1 = reader.GetDouble(reader.GetOrdinal("CantidadPaquete"))
            CantidadMercancia1 = reader.GetDouble(reader.GetOrdinal("CantidadMercancia"))
            CantidadTotal1 = reader.GetDouble(reader.GetOrdinal("CantidadTotal"))
            Cancelado1 = reader.GetBoolean(reader.GetOrdinal("Cancelado"))
            Contexto1 = reader.GetString(reader.GetOrdinal("Contexto"))

            MstrFecha = Fecha1
            MstrIdPaquete = IdPaquete1
            MstrTipoDePago = TipodePago1
            MstrIdMercanciaVendida = idMercanciaVendida1
            MstrDepositoSeguridad = DepositoSeguridad1
            MstrIdUsuario = idUsuario1
            MstrCantidadPaquete = CantidadPaquete1
            MstrCantidadMercancia = CantidadMercancia1
            MstrCantidadTotal = CantidadTotal1
            MstrCancelado = Cancelado1
            MstrContexto = Contexto1

            encontro = True
        End If

        If encontro Then
            Return True
        Else
            Return False
        End If

        cnx.Close()
    End Function




End Class
