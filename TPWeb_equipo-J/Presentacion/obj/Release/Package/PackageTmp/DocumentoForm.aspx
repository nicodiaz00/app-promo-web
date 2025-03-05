<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocumentoForm.aspx.cs" Inherits="Presentacion.DocumentoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row filaMain">
        <div class="col-12">
            <div class="contenedorDocumento">
                <p>Ingresa Documento</p>
                <asp:TextBox runat="server" ID="txtDocumento" CssClass="form-control" ></asp:TextBox>
                <asp:Button  runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" Text="Ingresa" CssClass="btn btn-primary"/>
            </div>
            <div class="contenedorMain">
                <asp:Label runat="server" ID="lblerrorDni" Text=""></asp:Label>
                <asp:Button runat="server" ID="btnErrorDni" Visible="false" CssClass="btn btn-warning" OnClick="btnErrorDni_Click" Text="Aceptar"/>
            </div>
            
        </div>
    </div>
</asp:Content>
