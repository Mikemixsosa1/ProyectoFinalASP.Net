Imports System.Data.SqlClient

Public Class Mercancia
    Private MstridMercancia As Integer
    Private MstrProducto As String
    Private MstrCantidad As Integer
    Private MstrPrecio As Double


    Public Property IdMercancia() As Integer
        Get
            Return MstridMercancia
        End Get
        Set(ByVal value As Integer)
            MstridMercancia = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return MstrPrecio
        End Get
        Set(ByVal value As Double)
            MstrPrecio = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return MstrProducto
        End Get
        Set(ByVal value As String)
            MstrProducto = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return MstrCantidad
        End Get
        Set(ByVal value As Integer)
            MstrCantidad = value
        End Set
    End Property


    Public Function InsertMercancia() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.InsertarMercancia", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPrecio))
        cmd.Parameters.Add(New SqlParameter("@Cantidad", MstrCantidad))
        cmd.Parameters.Add(New SqlParameter("@Producto", MstrProducto))



        cnx.Close()
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function

    Public Function Eliminar() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.EliminarMercanciaPorId", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id", MstridMercancia))
        cnx.Close()
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function

    Public Function Update() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.ModificarMercanciaPorId", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPrecio))
        cmd.Parameters.Add(New SqlParameter("@Cantidad", MstrCantidad))
        cmd.Parameters.Add(New SqlParameter("@Producto", MstrProducto))
        cmd.Parameters.Add(New SqlParameter("@Id", MstridMercancia))

        cnx.Close()
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function


    Public Function BuscarMercanciaPorId() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=NombreBaseDeDatos; Integrated Security=True")
        Dim cmd As New SqlCommand("ConsultarMercanciaPorId", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idMercancia", MstridMercancia))

        Dim Producto1 As String
        Dim Cantidad1 As Integer
        Dim Precio1 As Double

        Dim encontro As Boolean

        cnx.Close()
        cnx.Open()

        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        If reader.Read() Then
            Producto1 = reader.GetString(reader.GetOrdinal("Producto"))
            Cantidad1 = reader.GetInt32(reader.GetOrdinal("Cantidad"))
            Precio1 = reader.GetDouble(reader.GetOrdinal("Precio"))

            MstrProducto = Producto1
            MstrCantidad = Cantidad1
            MstrPrecio = Precio1

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
