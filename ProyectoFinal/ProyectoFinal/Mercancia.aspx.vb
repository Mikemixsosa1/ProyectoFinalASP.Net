Imports System.Data.SqlClient

Public Class Mercancia
    Inherits System.Web.UI.Page



    Protected Sub btnSiguiente3_Click(sender As Object, e As EventArgs) Handles btnSiguiente3.Click
        Response.Redirect("FormRegistroCliente.aspx")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("ElegirPaquetes.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindGridView()
        End If
    End Sub

    Private Sub BindGridView()
        Dim connectionString As String = "Server=LAPTOP-9AIDSJIC\SQLEXPRESS; Database=Sonidero; Integrated Security=True"
        Dim query As String = "SELECT * FROM Mercancia"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()

                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                GridView1.DataSource = dt
                GridView1.DataBind()
            End Using
        End Using
    End Sub


    Protected Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

    End Sub
End Class