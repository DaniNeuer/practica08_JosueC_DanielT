<%@ Page Language="C#" MasterPageFile="~/Site.Master"
AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="practica08_JosueC_DanielT.Default" %>

<asp:Content ID="Content1"
ContentPlaceHolderID="ContenedorPrincipal" runat="server">
        <div class="nuevoEstilo2">
            Pizzeria de: Josue y Daniel</div>
        <asp:Panel ID="panelTipoMasa" runat="server" GroupingText="&quot;Escoge un tipo de masa:&quot;">
            
            <asp:Table ID="tablaTipMasa" runat="server" Height="97px" Width="175px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"><asp:RadioButton ID="rbtDelgada" runat="server" Text="Delgada" GroupName="grupoTipos" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged"/>  </asp:TableCell>
                    <asp:TableCell runat="server" Text="$5">  </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"> <asp:RadioButton ID="rbtPanPizza" runat="server" Text="Pan pizza" GroupName="grupoTipos" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged"  /> </asp:TableCell>
                    <asp:TableCell runat="server" Text="$8">   </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ><asp:RadioButton ID="rbtGruesa" runat="server" Text="Gruesa" GroupName="grupoTipos" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" />  </asp:TableCell>
                    <asp:TableCell runat="server" Text="$10">  </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Panel ID="panelIngredientes" runat="server">
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="panelIngredientess" runat="server" GroupingText="Escoge los ingredientes:">
            
            <asp:Table ID="tablaIngredien" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"> <asp:CheckBox ID="chkHongo" runat="server" Text="Champiñones" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" /> </asp:TableCell>
                    <asp:TableCell runat="server" Text="$8">  </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"><asp:CheckBox ID="chkPeperoni" runat="server" Text="Peperoni " AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" />  </asp:TableCell>
                    <asp:TableCell runat="server" Text="$10">  </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"> <asp:CheckBox ID="chkSalchicha" runat="server" Text="Salchicha" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" /> </asp:TableCell>
                    <asp:TableCell runat="server" Text="$12">  </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
        <asp:Literal ID="literalSeleccionActual" runat="server" Text="&quot;&quot;"></asp:Literal>
        <p>
            Valor a pagar:</p>
        <asp:TextBox ID="txtTotal" runat="server" ReadOnly="True" ></asp:TextBox>
        <p>
            <asp:LinkButton ID="lnkCheckout" runat="server" OnClick="lnkCheckout_Click">Ir a pago...</asp:LinkButton>
        </p>
</asp:Content>
