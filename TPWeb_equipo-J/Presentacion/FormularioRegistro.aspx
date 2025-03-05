<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioRegistro.aspx.cs" Inherits="Presentacion.FormularioRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row" id="rowFormulario">
        <div class="col-12">
            <div class="mb-3">
                <label for="txtId" class="form-label">ID</label> 
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDocumentoCliente" class="form-label">Documento</label>
                <asp:TextBox runat="server" ID="txtDocumentoCliente" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txt" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDireccion" class="form-label">Dirección</label>
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCiudad" class="form-label">Ciudad</label>
                <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCodigoPostal" class="form-label">Codigo postal</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigoPostal"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCodigoArticulo" class="form-label">Codigo Articulo</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigoArticulo" Enabled="false"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button runat="server" ID="btnParcipar" Text="PARTICIPAR" OnClick="btnParticipar_Click" />
            </div>


        </div>
    </div>
</asp:Content>
