<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaster.Master" CodeBehind="Mercancia.aspx.vb" Inherits="ProyectoFinal.Mercancia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
	<title>Formulario de Mercancía</title>
	<script language="VBscript">
		Sub CalcularTotal()
			Dim precio, cantidad, total
			precio = CDbl(precio_txt.value)
			cantidad = CDbl(cantidad_txt.value)
			total = precio * cantidad
			total_txt.value = "$" & FormatNumber(total, 2)
		End Sub
	</script>
</head>
<body>
	<h1>Formulario de Mercancía</h1>
	<form>
		<div>
			<label for="idMercancia">ID Mercancía:</label>
			<input type="text" id="idMercancia" name="idMercancia">
		</div>
		<div>
			<label for="mercancia">Mercancía:</label>
			<input type="text" id="mercancia" name="mercancia">
		</div>
		<div>
			<label for="precio">Precio:</label>
			<input type="text" id="precio_txt" name="precio_txt" value="0">
		</div>
		<div>
			<label for="cantidad">Cantidad:</label>
			<input type="text" id="cantidad_txt" name="cantidad_txt" value="1">
		</div>
		<div>
			<button type="button" onclick="CalcularTotal()">Calcular Total</button>
		</div>
		<div class="auto-style1">
			<label for="total">Total:</label>
			<input type="text" id="total_txt" name="total_txt" readonly>
		</div>
	</form>
</body>
</asp:Content>
