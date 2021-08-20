<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Calculadora.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
        <div class="calc-1">            
            <div>
                <div class="solar">
                    <div >

                    </div>
                    <div class="solar-2">

                    </div>
                    <div class="solar-2">

                    </div>
                </div>
            </div>
            <div class="resultado"> 
                <asp:TextBox ID="txtMiniatura" runat="server" CssClass="txt-miniatura" />
                <asp:TextBox ID="txtResultado" runat="server" CssClass="txt-resultado" />
            </div>
            <div class="teclado-1">
                  <div class="teclado-2">                  
                       <asp:Button ID="btnParentesisIzquierdo" runat="server" Text="(" CssClass="boton" OnClick="btnParentesisIzquierdo_Click"/>

                      <asp:Button ID="btnParentesisDerecho" runat="server" Text=")" CssClass="boton" OnClick="btnParentesisDerecho_Click"/>

                      <asp:Button ID="btnPorciento" runat="server" Text="%" CssClass="boton"/>

                      <asp:Button ID="btnDividir" runat="server" Text="÷" CssClass="boton" OnClick="btnDividir_Click"/> 
                  </div>
                    <div class="teclado-2">
                        <asp:Button ID="btnSiete" runat="server" Text="7" CssClass="boton" OnClick="btnSiete_Click"/> 

                        <asp:Button ID="btnOcho" runat="server" Text="8" CssClass="boton" OnClick="btnOcho_Click"/> 

                        <asp:Button ID="btnNueve" runat="server" Text="9" CssClass="boton" OnClick="btnNueve_Click"/> 

                        <asp:Button ID="btnMultiplicar" runat="server" Text="x" CssClass="boton" OnClick="btnMultiplicar_Click"/>                         
                    </div>
                    <div class="teclado-2">
                        <asp:Button ID="btnCuatro" runat="server" Text="4" CssClass="boton" OnClick="btnCuatro_Click"/>  

                        <asp:Button ID="btnCinco" runat="server" Text="5" CssClass="boton" OnClick="btnCinco_Click"/>  

                        <asp:Button ID="btnSeis" runat="server" Text="6" CssClass="boton" OnClick="btnSeis_Click"/>  

                        <asp:Button ID="btnRestar" runat="server" Text="-" CssClass="boton" OnClick="btnRestar_Click"/>                        
                    </div>
                    <div class="teclado-2">
                        <asp:Button ID="btnUno" runat="server" Text="1" CssClass="boton" OnClick="btnUno_Click"/>  

                        <asp:Button ID="btnDos" runat="server" Text="2" CssClass="boton" OnClick="btnDos_Click"/>  

                        <asp:Button ID="btnTres" runat="server" Text="3" CssClass="boton" OnClick="btnTres_Click"/>  

                        <asp:Button ID="btnSumar" runat="server" Text="+" CssClass="boton" OnClick="btnSumar_Click"/>                        
                    </div>
                    <div class="teclado-2">
                        <asp:Button ID="btnFactorial" runat="server" Text="!" CssClass="boton"/>  

                        <asp:Button ID="btnCero" runat="server" Text="0" CssClass="boton" OnClick="btnCero_Click"/>  

                        <asp:Button ID="btnComa" runat="server" Text="," CssClass="boton"/>  

                        <asp:Button ID="btnIgual" runat="server" Text="=" CssClass="boton" OnClick="btnIgual_Click"/>                         
                    </div>
                </div>
             </div>
    </center>
</asp:Content>
