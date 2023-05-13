<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaster.Master" CodeBehind="FormRegistro.aspx.vb" Inherits="ProyectoFinal.FormRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
	<meta charset="UTF-8">
	<title>Cotizador de eventos</title>
</head>
<body>
	<h1>Cotizador de paquetes</h1>
	<form>
		<fieldset>
			<legend>Paquetes</legend>
			<label for="paquetes">Selecciona el paquete:</label>
			<select id="paquetes">
				<option value="0">Selecciona un paquete</option>
				<option value="1">Paquete básico</option>
				<option value="2">Paquete intermedio</option>
				<option value="3">Paquete premium</option>
			</select>
			<br><br>
			<label for="horas">Horas de servicio:</label>&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
		</fieldset>
		<br>
		<fieldset>
			<legend>Entretenimiento</legend>
			<label for="animador">Animador:</label>&nbsp;
            <asp:CheckBox ID="chkAnimador" runat="server" Text=" " />
			<br><br>
			<label for="bailarines">Bailarines:</label>
            <asp:CheckBox ID="CheckBox2" runat="server" Text=" " />
&nbsp;<br><br>
			<label for="dj">DJ:="dj">DJ
            <asp:CheckBox ID="CheckBox3" runat="server" Text=" " />
&nbsp;<br><br>
			<label for="luces">Luces:for="luc
            <asp:CheckBox ID="CheckBox4" runat="server" Text=" " />
&nbsp;</fieldset>
		<br>
		<fieldset>
			<legend>Costo totalet>
			<legend>Costo total</legend>
			<label for="precio">Precio total:</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;</fieldset>
		<br>
		<button type="button" id="cotizar">Cotizar</button>
	</form>
</body>
</asp:Content>
