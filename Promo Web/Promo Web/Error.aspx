<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Promo_Web.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container error-container mt-4">
        <div class="error-box">
            <h1>¡Ups! 😥</h1>
            <p>Algo salió mal. Por favor, intenta nuevamente más tarde.</p>

            <div class="row d-flex align-items-center">
                <div class="d-flex align-items-center">
                    <p class="mb-0 me-2"><strong>Detalle del error:</strong></p>
                    <asp:Label ID="lblDetalleError" runat="server" CssClass="text-danger"></asp:Label>
                </div>
            </div>


            <div class="btn-home mt-2">
                <a href="Default.aspx" class="btn btn-primary">Volver al inicio</a>
            </div>
        </div>
    </div>
</asp:Content>
