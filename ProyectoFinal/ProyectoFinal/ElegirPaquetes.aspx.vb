Public Class ElegirPaquetes
    Inherits System.Web.UI.Page


    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Response.Redirect("Mercancia.aspx")
    End Sub



    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("Login.aspx")

    End Sub
End Class