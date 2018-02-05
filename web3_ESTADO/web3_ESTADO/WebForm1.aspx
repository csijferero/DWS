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
    
        <asp:Label ID="lblPeso" runat="server" Text="Peso"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPeso" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblVol" runat="server" Text="Volumen"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbVolumen" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDensidad" runat="server" Text="Densidad"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txbDensidad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enviar" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm1.aspx" Text="ViewState" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblHora" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblHoraAnterior" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDir" runat="server" Text="WebForm1.aspx" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
