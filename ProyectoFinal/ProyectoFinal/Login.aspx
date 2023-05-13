<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ProyectoFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .error {
            color: red;
        }
    </style>
</head>
<body style="height: 258px">
    <form id="form1" runat="server">
        <div>
            <label for="txtUsuario">Nombre de usuario:</label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <label for="txtPassword">Contraseña:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar sesión" OnClick="btnIniciarSesion_Click" />
            <br />
            
        </div>
    </form>
</body>
</html>
