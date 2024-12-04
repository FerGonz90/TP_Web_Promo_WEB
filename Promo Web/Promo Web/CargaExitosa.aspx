<%@ Page Title="Carga Exitosa" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CargaExitosa.aspx.cs" Inherits="Promo_Web.CargaExitosa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center; margin-top: 50px;">
        <h1 style="color: green;">¡Carga Exitosa!</h1>
        <p style="font-size: 18px;">Tu voucher fue canjeado y ya estás participando en nuestra Promo.</p>
        <div style="margin: 20px auto; width: 300px; height: 200px; border: 2px solid #ccc; display: flex; align-items: center; justify-content: center;">
            <img src="https://i.pinimg.com/originals/1d/85/a1/1d85a1ca448c0a297f32d3d9d48e4ae5.gif" alt="Fuegos artificiales" style="max-width: 100%; max-height: 100%;">
        </div>
    </div>

    <div class="btn-home mt-2">
        <a href="Default.aspx" class="btn btn-primary">Volver al inicio</a>
    </div>
</asp:Content>

