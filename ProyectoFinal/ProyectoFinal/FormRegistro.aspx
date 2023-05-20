<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaster.Master" CodeBehind="FormRegistro.aspx.vb" Inherits="ProyectoFinal.FormRegistro" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblFecha" runat="server" Text="Fecha:"></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblIDPaquete" runat="server" Text="ID Paquete:"></asp:Label>
        <asp:TextBox ID="txtIDPaquete" runat="server" Width="82px"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblTipoPago" runat="server" Text="Tipo de Pago:"></asp:Label>
        <asp:TextBox ID="txtTipoPago" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblIDMercanciaVendida" runat="server" Text="ID Mercancía Vendida:"></asp:Label>
        <asp:CheckBox runat="server" />
    </div>
    <div>
        <asp:Label ID="lblProducto" runat="server" Text="Producto:"></asp:Label>
        <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblCantidadMercancia" runat="server" Text="Cantidad de Mercancía:"></asp:Label>
        <asp:TextBox ID="txtCantidadMercancia" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblIDCliente" runat="server" Text="ID Cliente:"></asp:Label>
        <asp:TextBox ID="txtIDCliente" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblLimiteVolumen" runat="server" Text="Límite de Volumen:"></asp:Label>
        <asp:TextBox ID="txtLimiteVolumen" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblCantidadPagarPaquete" runat="server" Text="Cantidad a Pagar del Paquete:"></asp:Label>
        <asp:TextBox ID="txtCantidadPagarPaquete" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblCantidadTotal" runat="server" Text="Cantidad Total:"></asp:Label>
        <asp:TextBox ID="txtCantidadTotal" runat="server"></asp:TextBox>
    </div>
    <div>

        <asp:Button ID="lblSiguiente" runat="server" Text="Siguiente" />

        </div>
</asp:Content>
