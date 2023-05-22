Imports System.Data.SqlClient

Public Class Login
    Inherits System.Web.UI.Page
    Public Property isAdmin As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function validarCredenciales(usuario As String, contrasena As String) As Boolean
        ' Conectar a la base de datos
        Dim conexion As New SqlConnection("Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True")
        conexion.Open()

        ' Verificar si el usuario y la contraseña coinciden con una fila en la tabla Usuario
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"
        Dim comando As New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@Usuario", usuario)
        comando.Parameters.AddWithValue("@Contrasena", contrasena)
        Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())

        ' Verificar si el usuario es un administrador
        If resultado > 0 Then
            Dim query2 As String = "SELECT IsAdmin FROM Usuarios WHERE Usuario = @Usuario"
            Dim comando2 As New SqlCommand(query2, conexion)
            comando2.Parameters.AddWithValue("@Usuario", usuario)
            Dim isAdminResult As Object = comando2.ExecuteScalar()
            If Not IsDBNull(isAdminResult) AndAlso isAdminResult IsNot Nothing Then
                isAdmin = Convert.ToBoolean(isAdminResult)
            End If
        End If

        ' Cerrar la conexión a la base de datos
        conexion.Close()

        ' Devolver verdadero si las credenciales son válidas (hay una fila en la tabla Usuario que coincide)
        Return resultado > 0
    End Function

    Private Function ObtenerIdUsuario(usuario As String, contrasena As String) As Integer
        Dim connectionString As String = "Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True"
        Dim query As String = "SELECT idUsuario FROM Usuarios WHERE Usuario = @usuario "

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@usuario", usuario)
            command.Parameters.AddWithValue("@contrasena", contrasena)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Return reader("idUsuario")
            Else
                Return -1 ' Si no se encuentra el usuario o la contraseña, devolvemos un valor negativo
            End If
        End Using
    End Function

    Protected Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        ' Obtener el nombre de usuario y la contraseña ingresados por el usuario
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtPassword.Text

        ' Verificar si el usuario y la contraseña son válidos
        If validarCredenciales(usuario, contrasena) Then
            ' Si las credenciales son válidas, abrir el formulario principal (Form2)
            Response.Redirect("ElegirPaquetes.aspx")


            'Mandar Datos a controlUsuarios
            Dim fechaActual As Date = Date.Today
            Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay
            Dim idUsuario As Integer = ObtenerIdUsuario(usuario, contrasena)
            Dim isAdmin As Boolean = ObtenerIsAdmin(usuario)
            Dim connectionString As String = "Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True"
            Dim query As String = "INSERT INTO Control_Usuarios (Fecha, Hora, IsAdmin, idUsuario) VALUES (@fecha, @hora, @isAdmin, @idUsuario)"

            Session("isAdmin") = isAdmin


            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@fecha", fechaActual)
                command.Parameters.AddWithValue("@hora", horaActual)
                command.Parameters.AddWithValue("@isAdmin", isAdmin)
                command.Parameters.AddWithValue("@idUsuario", idUsuario)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

            End Using




        Else
            ' Si las credenciales no son válidas, mostrar un mensaje de error
        End If



    End Sub


    Private Function ObtenerIsAdmin(usuario As String) As Boolean
        Dim connectionString As String = "Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True"
        Dim query As String = "SELECT IsAdmin FROM Usuarios WHERE Usuario = @Usuario"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Usuario", usuario)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Return reader.GetBoolean(0)
            Else
                Return False ' Si no se encuentra el usuario, devolvemos un valor por defecto
            End If
        End Using
    End Function

End Class