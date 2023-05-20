Public Class Mercancia
    Inherits System.Web.UI.Page



    Protected Sub btnSiguiente3_Click(sender As Object, e As EventArgs) Handles btnSiguiente3.Click
        Response.Redirect("FormRegistroCliente.aspx")
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("ElegirPaquetes.aspx")
    End Sub
End Class