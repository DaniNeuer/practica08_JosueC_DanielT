<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="practica08_JosueC_DanielT.Checkout" %>

<asp:Content ID="Content1"
ContentPlaceHolderID="ContenedorPrincipal" runat="server">
        <div>
            “Tu selección para la pizza es: “<asp:Literal ID="literalSeleccion" runat="server"></asp:Literal>
        </div>
        “El valor a pagar por tu pizza es: ”<asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
        <p>
            “Gracias por tu compra!... vuelve pronto :D”</p>
</asp:Content>