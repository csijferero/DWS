<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="web3_ESTADO.WebForm3" %>

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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPesoVal" runat="server" Text="Peso"></asp:Label>
        <br />
        <asp:Label ID="lblVol" runat="server" Text="Volumen"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblVolVal" runat="server" Text="Volumen"></asp:Label>
        <br />
        <asp:Label ID="lblDensidad" runat="server" Text="Densidad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDensidadVal" runat="server" Text="Densidad"></asp:Label>
    
    </div>
    </form>
</body>
</html>
