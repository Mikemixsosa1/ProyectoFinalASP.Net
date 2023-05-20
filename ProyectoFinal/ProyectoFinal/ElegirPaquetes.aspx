<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaster.Master" CodeBehind="ElegirPaquetes.aspx.vb" Inherits="ProyectoFinal.ElegirPaquetes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <label for="txtIDPaquete">ID Paquete:</label>
            <input type="text" id="txtIDPaquete" runat="server" />
        </div>
        <div>
            <label for="txtPaquetes">Paquetes:</label>
            <input type="text" id="txtPaquetes" runat="server" />
        </div>
        <div>
            <label for="txtHoras">Horas:</label>
            <input type="text" id="txtHoras" runat="server" />
        </div>
        <div>
            <label for="txtAnimador">Animador:</label>
            <input type="text" id="txtAnimador" runat="server" />
        </div>
        <div>
            <label for="txtBailarines">Bailarines:</label>
            <input type="text" id="txtBailarines" runat="server" />
        </div>
        <div>
            <label for="txtDj">DJ:</label>
            <input type="text" id="txtDj" runat="server" />
        </div>
        <div>
            <label for="txtLuces">Luces:</label>
            <input type="text" id="txtLuces" runat="server" />
        </div>
        <div>
            <label for="txtPrecio">Precio:</label>
            <input type="text" id="txtPrecio" runat="server" />
        </div>
        <div>
            <asp:GridView ID="dataGridView" runat="server">
                <Columns>
        <asp:BoundField DataField="idPaquete" HeaderText="ID Paquete" />
        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="horas" HeaderText="Horas" />
        <asp:BoundField DataField="animador" HeaderText="Animador" />
        <asp:BoundField DataField="bailarines" HeaderText="Bailarines" />
        <asp:BoundField DataField="dj" HeaderText="DJ" />
        <asp:BoundField DataField="luces" HeaderText="Luces" />
    </Columns>
            </asp:GridView>
        </div>
</asp:Content>
