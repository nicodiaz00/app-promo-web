<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Presentacion.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row row-cols-1 row-cols-md-3 g-4 rowArticulo">
        <div class="col-12 colArticulo">
            <asp:Repeater runat="server" ID="repetidorArticulos">
                <ItemTemplate>

                    <div class="contenedorArticulo">
                        <div class="contenedorImg">
                            <img src="<%#Eval("Imagenes[0].UrlImagen") %>" class="imgArticulo" />
                        </div>
                        <div class="informacionArticulo">
                            <h5><%#Eval("NombreArticulo") %></h5>
                            <p class="oculto"><%# Eval("Id") %></p>
                            <p class="oculto"><%# Eval("CodigoArticulo") %></p>
                            <p><%#Eval("DescripcionArticulo") %></p>
                            <p><%#Eval("Marca.DescripcionMarca") %></p>
                            <p><%#Eval("Categoria.DescripcionCategoria") %></p>
                        </div>
                        <div class="btnElegirArticulo">
                            <asp:Button Text="Seleccionar" CssClass="btn btn-primary mt-3 align-self-start"
                                runat="server" ID="Button1" OnClick="btnSeleccionar_Click"
                                CommandArgument='<%#Eval("Id") %>' CommandName="articuloID" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>



    </div>

</asp:Content>


<%--<asp:Repeater ID="RepeaterArticulo" runat="server">
        <ItemTemplate>
            <div class="col">
                <div class="card">
                    <div id="carousel<%# Eval("Id") %>" class="carousel slide" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <% 
                                bool isActive = true; // Para marcar la primera imagen como activa
                                foreach (var imagen in (System.Collections.IEnumerable)Eval("Imagenes"))
                                {
                        %>
                            <div class="carousel-item <%: isActive ? "active" : "" %>">
                                <img src="<%# Eval("ImagenUrl") %>" class="d-block w-100" alt="...">
                            </div>
                            <% isActive = false; %>
                            <% } %>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Previous</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Next</span>
                        </button>
                    </div>

                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("NombreArticulo") %></h5>
                        <p class="card-text"><%# Eval("DescripcionArticulo") %></p>
                        <a href="<%# Eval("Id") %>">Ver Detalle</a>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>--%>





