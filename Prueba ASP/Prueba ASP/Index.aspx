<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prueba_ASP.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="187px" ImageUrl="~/imagenes/s-l1600.jpg" Width="220px" />
        <br />
        <br />
        <asp:Label ID="lbBienvenida" runat="server" Text="Bienvenido a ASP.net!"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Tu nombre?"></asp:Label>
&nbsp;
        <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaludar" runat="server" Text="Button" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chbVuelta" runat="server" Text="Borrar a la vuelta" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbMay" runat="server" Text="Mayuscula" />
        <asp:RadioButton ID="rbMin" runat="server" Text="Minuscula" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="btn" runat="server" Text="Button" Width="148px" />
        <br />
        <asp:CheckBox ID="chbPagina" runat="server" Text="Ir a la pagina de Altair" />
        <br />
        <asp:Image ID="imgInicio" runat="server" Height="69px" ImageUrl="https://www.siva.gov.co/images/imagenes/logo-inicio.png" Width="87px" />
    
    </div>
    </form>
</body>
</html>
