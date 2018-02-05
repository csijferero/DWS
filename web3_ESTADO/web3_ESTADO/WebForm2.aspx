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
    
        <asp:Label ID="lblURL" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblPeso" runat="server" Text="Peso"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPeso" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblVol" runat="server" Text="Volumen"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbVolumen" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDensidad" runat="server" Text="Densidad"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbDensidad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
