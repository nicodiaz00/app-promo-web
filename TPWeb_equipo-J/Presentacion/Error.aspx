<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Presentacion.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row filaMain">
        
        <div class="col-12">
            <div class="contenedorMain">
                <asp:Label  runat="server" ID="lblError" Text=""></asp:Label>
<asp:Button runat="server" ID="btnVolver" Text="VOLVER" CssClass="btn btn-primary" OnClick="btnVolver_Click"  />
            </div>
            
        </div>

    </div>

</asp:Content>
