<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidacionCliente.aspx.cs" Inherits="Presentacion.ValidacionCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <div class="col-12">
        <h2>Ingresa tu Dni</h2>
        <asp:TextBox runat="server" ID="txtDocumento"></asp:TextBox>
        <asp:Button Text="Ingresar" runat="server" ID="btnRegistrarse" OnClick="btnRegistrarse_Click"/>

       
    </div>
</div>
</asp:Content>
