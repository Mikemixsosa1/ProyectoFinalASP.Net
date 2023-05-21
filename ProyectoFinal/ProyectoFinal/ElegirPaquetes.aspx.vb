Imports System.Data.SqlClient
Public Class ElegirPaquetes
    Inherits System.Web.UI.Page

    Public divAdminContent As Boolean



    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Response.Redirect("Mercancia.aspx")
    End Sub



    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("Login.aspx")

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        If Not IsPostBack Then
            ' Recuperar el valor de isAdmin de la sesión
            Dim isAdmin As Boolean = False ' Valor predeterminado si no se encuentra en la sesión
            If Session("isAdmin") IsNot Nothing AndAlso TypeOf Session("isAdmin") Is Boolean Then
                isAdmin = DirectCast(Session("isAdmin"), Boolean)
            End If

            ' Utilizar el valor de isAdmin para mostrar u ocultar el contenido
            If isAdmin Then
                ' Mostrar el contenido para los administradores
                divAdminContent = True
            Else
                ' Ocultar el contenido para los no administradores
                divAdminContent = False
            End If
        End If

        Dim connectionString As String = "Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True"


        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT idPaquete, Horas, Nombre, Animador, Bailarines, DJ, Luces, Precio FROM Paquete"

            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                GridView1.DataSource = reader
                GridView1.DataBind()
            End Using
        End Using

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class