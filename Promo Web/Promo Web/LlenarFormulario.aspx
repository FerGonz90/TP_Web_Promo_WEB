<%@ Page Title="Formulario de Participación" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LlenarFormulario.aspx.cs" Inherits="Promo_Web.LlenarFormulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
    function disableEnterKey(event) {
        if (event.key === "Enter") {
            event.preventDefault();
            return false;
        }
    }
</script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">

        <h1>Ingresa tus datos</h1>

        <div class="row mt-3">
            <div class="col-md-4">
                <asp:Label ID="lblDocumento" runat="server" Text="Documento:" AssociatedControlID="txtDocumento" CssClass="form-label" />
                <asp:TextBox ID="txtDocumento" runat="server" OnTextChanged="txtDocumento_TextChanged" onkeydown="return disableEnterKey(event);" AutoPostBack="true" CssClass="form-control" />
                <asp:Label ID="lblErrorDocumento" runat="server" CssClass="text-danger"></asp:Label>
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-4">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:" AssociatedControlID="txtNombre" CssClass="form-label" />
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorNombre" runat="server" CssClass="text-danger"></asp:Label>
            </div>
            <div class="col-md-4">
                <asp:Label ID="lblApellido" runat="server" Text="Apellido:" AssociatedControlID="txtApellido" CssClass="form-label" />
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorApellido" runat="server" CssClass="text-danger"></asp:Label>
            </div>
            <div class="col-md-4">
                <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail" CssClass="form-label" />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorEmail" runat="server" CssClass="text-danger"></asp:Label>
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-6">
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección:" AssociatedControlID="txtDireccion" CssClass="form-label" />
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Style="width: 100%;" />
                <asp:Label ID="lblErrorDireccion" runat="server" CssClass="text-danger"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:" AssociatedControlID="txtCiudad" CssClass="form-label" />
                <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorCiudad" runat="server" CssClass="text-danger"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblCP" runat="server" Text="CP:" AssociatedControlID="txtCP" CssClass="form-label" />
                <asp:TextBox ID="txtCP" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorCP" runat="server" CssClass="text-danger"></asp:Label>
            </div>
        </div>


        <div class="row mt-3">
            <div class="col-md-12">
                <asp:CheckBox ID="chkTerminos" runat="server" CssClass="form-check-input" />
                <asp:Label ID="lblTerminos" runat="server" Text="Acepto los términos y condiciones" AssociatedControlID="chkTerminos" CssClass="form-check-label ms-2" />
                <asp:Label ID="lblErrorTerminos" CssClass="text-danger ms-2" runat="server" />
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-12">
                <asp:Button ID="btnParticipar" runat="server" Text="Participar" OnClick="btnParticipar_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>
