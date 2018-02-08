<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web3_ESTADO.WebForm1" %>

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
        <p>En esta pagina estamos mandando mediante cookies el peso, el volumen, la densidad y el valor de un label oculto.
        <p>Se controlan los rangos y se comprueba que no esten nulos los campos. Guarda en una variable ViewState la hora actual cada vez que se pulsa el boton VIEWSTATE. En session se guarda tambien la hora cada vez que recarga. La primera vez que se entra en la aplicacion se guarda en APPLICATION la hora.</p>
        <br />
        <br />
    
        <asp:Label ID="lblPeso" runat="server" Text="Peso"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPeso" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txbPeso" Display="Dynamic" ErrorMessage="Error de Rango" MaximumValue="150" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txbPeso" Display="Dynamic" ErrorMessage="RequiredFieldValidator">Campo Requerido</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblVol" runat="server" Text="Volumen"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbVolumen" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txbVolumen" Display="Dynamic" ErrorMessage="Error de Rango" MaximumValue="150" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbVolumen" Display="Dynamic" ErrorMessage="RequiredFieldValidator">Campo Requerido</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblDensidad" runat="server" Text="Densidad"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txbDensidad" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txbDensidad" Display="Dynamic" ErrorMessage="Error de Rango" MaximumValue="150" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txbDensidad" Display="Dynamic" ErrorMessage="RequiredFieldValidator">Campo Requerido</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enviar" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm1.aspx" Text="ViewState" CausesValidation="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label1" runat="server" Text="View State Actual"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblHora" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label2" runat="server" Text="ViewState Anterior"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblHoraAnterior" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDir" runat="server" Text="WebForm1.aspx" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
