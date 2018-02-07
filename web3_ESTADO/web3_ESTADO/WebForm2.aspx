<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="web3_ESTADO.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <h1>Jose Antonio</h1>
        <p>En esta pagina recopilamos los cookies para mostrarlos</p>
        <p>Recopilamos los cookies guardados y los mostramos en los textBox, dando la posibilidad de modificarlos con sus respectivas validaciones.</p>
        <p>&nbsp;</p>
        <br />
        <br />
        <br />
    
        <asp:Label ID="lblURL" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblPeso" runat="server" Text="Peso"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPeso" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txbPeso" Display="Dynamic" ErrorMessage="Error de Rango" MaximumValue="150" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txbPeso" Display="Dynamic" ErrorMessage="RequiredFieldValidator">Campo Requerido</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblVol" runat="server" Text="Volumen"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbVolumen" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txbVolumen" Display="Dynamic" ErrorMessage="Error de Rango" MaximumValue="150" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbVolumen" Display="Dynamic" ErrorMessage="RequiredFieldValidator">Campo Requerido</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblDensidad" runat="server" Text="Densidad"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbDensidad" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txbDensidad" Display="Dynamic" ErrorMessage="Error de Rango" MaximumValue="150" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txbDensidad" Display="Dynamic" ErrorMessage="RequiredFieldValidator">Campo Requerido</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
