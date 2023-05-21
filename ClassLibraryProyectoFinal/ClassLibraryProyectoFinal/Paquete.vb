Imports System.Data.SqlClient

Public Class Paquete
    Private MstrIdPaquete As Integer
    Private MstrHoras As Double
    Private MstrNombre As String
    Private MstrAnimador As String
    Private MstrBailarines As String
    Private MstrDJ As String
    Private MstrLuces As String
    Private MstrPrecio As Double

    Public Property IdPaquete() As Integer
        Get
            Return MstrIdPaquete
        End Get
        Set(ByVal value As Integer)
            MstrIdPaquete = value
        End Set
    End Property

    Public Property Horas() As Double
        Get
            Return MstrHoras
        End Get
        Set(ByVal value As Double)
            MstrHoras = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return MstrNombre
        End Get
        Set(ByVal value As String)
            MstrNombre = value
        End Set
    End Property

    Public Property Animador() As String
        Get
            Return MstrAnimador
        End Get
        Set(ByVal value As String)
            MstrAnimador = value
        End Set
    End Property

    Public Property Bailarines() As String
        Get
            Return MstrBailarines
        End Get
        Set(ByVal value As String)
            MstrBailarines = value
        End Set
    End Property

    Public Property DJ() As String
        Get
            Return MstrDJ
        End Get
        Set(ByVal value As String)
            MstrDJ = value
        End Set
    End Property

    Public Property Luces() As String
        Get
            Return MstrLuces
        End Get
        Set(ByVal value As String)
            MstrLuces = value
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

    Public Function InsertarPaquete() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("InsertarPaquete", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idPaquete", MstrIdPaquete))
        cmd.Parameters.Add(New SqlParameter("@Horas", MstrHoras))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Animador", MstrAnimador))
        cmd.Parameters.Add(New SqlParameter("@Bailarines", MstrBailarines))
        cmd.Parameters.Add(New SqlParameter("@DJ", MstrDJ))
        cmd.Parameters.Add(New SqlParameter("@Luces", MstrLuces))
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPrecio))

        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()

        Return True
    End Function

    Public Function EliminarPaquete() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("EliminarPaquete", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idPaquete", MstrIdPaquete))

        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()

        Return True
    End Function

    Public Function ModificarPaquete() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("ActualizarPaquete", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idPaquete", MstrIdPaquete))
        cmd.Parameters.Add(New SqlParameter("@Horas", MstrHoras))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Animador", MstrAnimador))
        cmd.Parameters.Add(New SqlParameter("@Bailarines", MstrBailarines))
        cmd.Parameters.Add(New SqlParameter("@DJ", MstrDJ))
        cmd.Parameters.Add(New SqlParameter("@Luces", MstrLuces))
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPrecio))

        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()

        Return True
    End Function

    Public Function BuscarPaquetePorId() As Boolean
        Dim cnx As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        Dim cmd As New SqlCommand("ConsultarPaquetePorID", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@idPaquete", MstrIdPaquete))

        Dim Horas1, Nombre1, Animador1, Bailarines1, DJ1, Luces1 As String
        Dim Precio1 As Double

        Dim encontro As Boolean

        cnx.Close()
        cnx.Open()

        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        If reader.Read() Then
            Horas1 = reader(1).ToString
            Nombre1 = reader(2).ToString
            Animador1 = reader(3).ToString
            Bailarines1 = reader(4).ToString
            DJ1 = reader(5).ToString
            Luces1 = reader(6).ToString
            Precio1 = Convert.ToDouble(reader(7))
            Horas = Horas1
            Nombre = Nombre1
            Animador = Animador1
            Bailarines = Bailarines1
            DJ = DJ1
            Luces = Luces1
            Precio = Precio1
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
