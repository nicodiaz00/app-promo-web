<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Presentacion.Registro" %>

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
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido1"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txt" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido2"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido3"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido4"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtDireccion" class="form-label">Dirección</label>
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido5"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtCiudad" class="form-label">Ciudad</label>
                <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido6"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtCodigoPostal" class="form-label">Codigo postal</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigoPostal"></asp:TextBox>
                <asp:Label runat="server" Text="*Campo obligatorio" CssClass="textoRojo" Visible="false" ID="lblrequerido7"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtCodigoArticulo" class="form-label">ID Articulo</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigoArticulo" Enabled="false"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtFechaCanje" class="form-label">Fecha</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFecha" Enabled="false" TextMode="DateTime"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button runat="server" ID="btnParticipar" CssClass="btn btn-primary" Text="Participar" OnClick="btnParticipar_Click" />
            </div>
            <div id="overlay" class="overlay" style="display: none;">
                <div class="popup">
                    <h3>FALTAN DATOS</h3>
                    <p id="mensaje">
                        
                    </p>
                    <button class="btn-cerrar-popup" onclick="cerrarPopup()">Cerrar</button>
                </div>
            </div>


        </div>
    </div>
</asp:Content>
