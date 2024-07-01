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
        </asp:Panel>
        <asp:Panel ID="panelIngredientess" runat="server" GroupingText="Escoge los ingredientes:">
            
            <asp:Table ID="tablaIngredien" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"> <asp:CheckBox ID="chkHongo" runat="server" Text="Champiñones" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" /> </asp:TableCell>
                    <asp:TableCell runat="server" Text="$8">  </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"><asp:CheckBox ID="chkPeperoni" runat="server" Text="Peperoni" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" />  </asp:TableCell>
                    <asp:TableCell runat="server" Text="$10">  </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"> <asp:CheckBox ID="chkSalchicha" runat="server" Text="Salchicha" AutoPostBack="True" onCheckedChanged ="Opciones_CheckedChanged" /> </asp:TableCell>
                    <asp:TableCell runat="server" Text="$12">  </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
        <!-- Panel para seleccionar el tamaño de la pizza -->
         <b>Escoge el tamaño de la pizza:</b>
            <asp:RadioButtonList ID="rblTamano" runat="server" AutoPostBack="True" onSelectedIndexChanged="Opciones_CheckedChanged">
                <asp:ListItem Text="Personal => $5" Value="5"></asp:ListItem>
                <asp:ListItem Text="Mediana => $10" Value="10"></asp:ListItem>
                <asp:ListItem Text="Familiar => $15" Value="15"></asp:ListItem>
                <asp:ListItem Text="Gigante => $20" Value="20"></asp:ListItem>
            </asp:RadioButtonList>
        

         <!-- Panel para seleccionar los extras -->
        <b>Escoge algun extra:</b>
            <asp:CheckBoxList ID="cblExtras" runat="server" AutoPostBack="True" onSelectedIndexChanged="Opciones_CheckedChanged">
                <asp:ListItem Text="Papas fritas => $3" Value="3"></asp:ListItem>
                <asp:ListItem Text="Dedos de queso => $4" Value="4"></asp:ListItem>
                <asp:ListItem Text="Brownie => $2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Bordes de queso => $5" Value="5"></asp:ListItem>
                <asp:ListItem Text="Bordes de salchicha con queso => $6" Value="6"></asp:ListItem>
            </asp:CheckBoxList>
        

        <!-- Panel para seleccionar las bebidas -->
        <b>Escoge alguna bebida:</b>
            <asp:CheckBoxList ID="cblBebidas" runat="server" AutoPostBack="True" onSelectedIndexChanged="Opciones_CheckedChanged">
                <asp:ListItem Text="Pepsi => $1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Sprite => $1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Fiora => $1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Coca Cola => $1" Value="1"></asp:ListItem>
            </asp:CheckBoxList>
        
        
        <asp:Literal ID="literalSeleccionActual" runat="server" Text="&quot;&quot;"></asp:Literal>
        <p>
            Valor a pagar:</p>
        <asp:TextBox ID="txtTotal" runat="server" ReadOnly="True" ></asp:TextBox>
        <p>
            <asp:LinkButton ID="lnkCheckout" runat="server" OnClick="lnkCheckout_Click">Ir a pago...</asp:LinkButton>
        </p>
    <!-- Enlace a la página de contactos -->
        <p>
            <asp:HyperLink ID="hlContactos" runat="server" NavigateUrl="~/Contactos.aspx">Contactos</asp:HyperLink>
        </p>
</asp:Content>
