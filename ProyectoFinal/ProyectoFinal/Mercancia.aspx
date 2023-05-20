<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PaginaMaster.Master" CodeBehind="Mercancia.aspx.vb" Inherits="ProyectoFinal.Mercancia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .container {
            max-width: 400px;
            margin: 0 auto;
            padding: 20px;
            background-color: #f1f1f1;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .form-group input[type="text"],
        .form-group input[type="number"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        .form-group .btn-calculate {
            background-color: #4CAF50;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            transition: background-color 0.3s;
        }

        .form-group .btn-calculate:hover {
            background-color: #45a049;
        }

        .auto-style1 {
            margin-top: 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        table th, table td {
            padding: 8px;
            border-bottom: 1px solid #ddd;
        }

        table th {
            text-align: left;
            background-color: #f2f2f2;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Formulario de Mercancía</h1>
        <div class="form-group">
            <label for="idMercancia">ID Mercancía:</label>
            <input type="text" id="idMercancia" name="idMercancia">
        </div>
        <div class="form-group">
            <label for="mercancia">Mercancía:</label>
            <input type="text" id="mercancia" name="mercancia">
        </div>
        <div class="form-group">
            <label for="precio">Precio:</label>
            <input type="number" id="precio" name="precio" value="0">
        </div>
        <div class="form-group">
            <label for="cantidad">Cantidad:</label>
            <input type="number" id="cantidad" name="cantidad" value="1">
        </div>
        <div class="form-group">
            <button type="button" id="btnCalculate" class="btn-calculate">Calcular Total</button>
        </div>
        <div class="auto-style1">
            <label for="total">Total:</label>
            <input type="text" id="total" name="total" readonly>
        </div>
        <table id="datagrid">
            <thead>
                <tr>
                    <th>ID Mercancía</th>
                    <th>Precio</th>
                    <th>Cantidad</th>
                </tr>
            </thead>
            <tbody>
                <!-- Los datos del DataGrid se llenarán dinámicamente desde el código detrás -->
            </tbody>
        </table>
    </div>

    <script>
        // Animación al cargar la página
        window.addEventListener('DOMContentLoaded', function () {
            var container = document.querySelector('.container');
            container.classList.add('slide-in');
        });

        // Animación al hacer clic en el botón "Calcular Total"
        var btnCalculate = document.getElementById('btnCalculate');
        btnCalculate.addEventListener('click', function () {
            var container = document.querySelector('.container');
            container.classList.remove('slide-in');
            container.classList.add('slide-out');
            // Aquí puedes agregar lógica adicional al hacer clic en el botón "Calcular Total"
        });
    </script>
</asp:Content>
