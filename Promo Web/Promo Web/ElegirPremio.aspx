<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="Promo_Web.ElegirPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .img-carrusel {
            width: 100%;
            height: 200px;
            object-fit: contain;
            background-color: #f5a9a9;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="row">
            <!-- Primer Card -->
            <div class="col-md-4">
                <div class="card">
                    <div id="carruselCard1" class="carousel slide" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <asp:Image ID="imgCarrusel1_1" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                            <div class="carousel-item">
                                <asp:Image ID="imgCarrusel1_2" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                            <div class="carousel-item">
                                <asp:Image ID="imgCarrusel1_3" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carruselCard1" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carruselCard1" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>
                    <div class="card-body">
                        <div>
                            <asp:Label ID="lblNombre" CssClass="card-title h5" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="lblDescripcion" CssClass="card-text" runat="server" />
                        </div>
                        <asp:Button ID="btnElegir" Text="Elegir" OnClick="btnElegir_Click" CssClass="btn btn-primary mt-2" runat="server" />
                    </div>
                </div>
            </div>

            <div class="col-md-4">
                <div class="card">
                    <div id="carruselCard2" class="carousel slide" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <asp:Image ID="imgCarrusel2_1" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                            <div class="carousel-item">
                                <asp:Image ID="imgCarrusel2_2" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                            <div class="carousel-item">
                                <asp:Image ID="imgCarrusel2_3" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carruselCard2" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carruselCard2" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>
                    <div class="card-body">
                        <div>
                            <asp:Label ID="lblNombre2" CssClass="card-title h5" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="lblDescripcion2" CssClass="card-text" runat="server" />
                        </div>
                        <asp:Button ID="btnElegir2" Text="Elegir" OnClick="btnElegir2_Click" CssClass="btn btn-primary mt-2" runat="server" />
                    </div>
                </div>
            </div>

            <div class="col-md-4">
                <div class="card">
                    <div id="carruselCard3" class="carousel slide" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <asp:Image ID="imgCarrusel3_1" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                            <div class="carousel-item">
                                <asp:Image ID="imgCarrusel3_2" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                            <div class="carousel-item">
                                <asp:Image ID="imgCarrusel3_3" runat="server" CssClass="d-block w-100 img-carrusel" />
                            </div>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carruselCard3" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carruselCard3" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>
                    <div class="card-body">
                        <div>
                            <asp:Label ID="lblNombre3" CssClass="card-title h5" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="lblDescripcion3" CssClass="card-text" runat="server" />
                        </div>
                        <asp:Button ID="btnElegir3" Text="Elegir" OnClick="btnElegir3_Click" CssClass="btn btn-primary mt-2" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

