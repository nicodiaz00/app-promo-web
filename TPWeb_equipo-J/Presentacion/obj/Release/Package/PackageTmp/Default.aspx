<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <main>
        
        <section class="row filaMain">
            
            
            <div class="col-12">
                <div class="contenedorMain">
                    <div class="titulo">
                        <h2>Bienvenido a PROMO WEB</h2>
                        <p>Ingresa el codigo y participa</p>
                    </div>
                    
                    <div class="mb-3 contenedortxt">
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtVoucher"></asp:TextBox>
                    </div>
                    
                    
                    
                </div>
                <div class="contenedorMain">
                    <asp:Button  runat="server" ID="btnCanjearCupon" OnClick="btnCanjearCupon_Click" Text="Canjear Cupon" CssClass="btn btn-primary"/>

                </div>
                <div class="contenedorMain">
                    <asp:Label runat="server" ID="lblError" Text=""></asp:Label>
                    <asp:Button  runat="server" ID="btnRecargar" Visible="false" Text="Aceptar" CssClass="btn btn-warning" OnClick="btnRecargar_Click"/>
                </div>
                

            </div>
            
            
        </section>
    </main>

</asp:Content>
