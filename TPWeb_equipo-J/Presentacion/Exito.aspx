<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="Presentacion.Exito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row rowExito">
        
        <div class="col-12 contenedorExito">
            <h3>Gracias por participar</h3>
            <asp:Button runat="server" ID="volverInicio" Text="Volver"  CssClass="btn btn-primary" OnClick="volverInicio_Click"/>
        </div>
        
    </div>
</asp:Content>
