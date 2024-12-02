<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Promo_Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .linea-divisoria {
            border-top: 2px solid #ddd;
            margin: 20px 0;
        }

        .contenedor-pagina {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #f5a9a9;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }

        .contenedor-label {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
        }

        .etiqueta-personalizada {
            font-weight: bold;
            color: #333;
        }

        .boton-personalizado {
            background-color: #28a745;
            border: none;
        }

            .boton-personalizado:hover {
                background-color: #218838;
            }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contenedor-pagina" style="margin-top: 30px;">

        <div class="linea-divisoria"></div>

        <div class="mb-3">
            <asp:Label ID="lblVoucher" runat="server" Text="Ingresá el código de tu voucher" CssClass="form-label etiqueta-personalizada"></asp:Label>
            <asp:TextBox ID="txtVoucher" runat="server" CssClass="form-control" placeholder="xxxxxxxxxxxxxxxxxxx"></asp:TextBox>
        </div>

        <div class="linea-divisoria"></div>

        <div class="text-center">
            <asp:Button ID="btnSiguiente" runat="server" OnClick="btnSiguiente_Click" Text="Siguiente" CssClass="btn btn-info px-4 ms-2" />
        </div>

    </div>

    <div class="contenedor-label" style="margin-top: 30px;">
        <asp:Label ID="lblError" Text="Aquí se verán palabras cuando ocurra algún error" CssClass="text-danger mt-3" runat="server" />
    </div>
</asp:Content>
