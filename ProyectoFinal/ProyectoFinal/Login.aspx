<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaster.Master" CodeBehind="Login.aspx.vb" Inherits="ProyectoFinal.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <title>Formulario de inicio de sesión</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f1f1f1;
        }

        h2 {
            text-align: center;
            font-size: 28px;
            margin-bottom: 30px;
        }

        .login-form {
            max-width: 400px;
            margin: 0 auto;
            background-color: #ffffff;
            padding: 30px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            animation: fadeIn 0.5s ease-in-out;
        }

        .form-group {
            margin-bottom: 20px;
        }

        label {
            display: block;
            font-size: 18px;
            margin-bottom: 5px;
        }

        input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            border-radius: 4px;
            border: 1px solid #ccc;
        }

        input[type="submit"] {
            width: 100%;
            padding: 10px;
            font-size: 18px;
            background-color: #4CAF50;
            color: #ffffff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }

        @keyframes fadeIn {
            0% { opacity: 0; }
            100% { opacity: 1; }
        }
    </style>
</head>
<body>
    <div class="login-form">
        <h2>Inicio de sesión</h2>
        <form method="post" action="Login.aspx">
            <div class="form-group">
                <label for="username">Nombre de usuario:<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </label>
&nbsp;</div>
<div class="form-group">
    <label for="password">Contraseña:</label>
    <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="¡Debe ingresar una contraseña!"></asp:RequiredFieldValidator>
</div>
            <div>
                &nbsp;<asp:Button ID="Button"  runat="server" Text="Iniciar Sesion" />
            </div>
        </form>
    </div>
</body>
</asp:Content>
