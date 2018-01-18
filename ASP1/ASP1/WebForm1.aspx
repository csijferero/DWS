<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP1.WebForm1" %>

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
        <asp:Label ID="lbNombre" runat="server" Text="Tu nombre?"></asp:Label>
&nbsp;
        <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaludar" runat="server" Text="Button" OnClick="btnSaludar_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chbVuelta" runat="server" Text="Borrar a la vuelta" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbMay" runat="server" Text="Mayuscula" GroupName="rb" />
        <asp:RadioButton ID="rbMin" runat="server" Text="Minuscula" GroupName="rb" />
        <br />
        <br />
        <asp:Label ID="label" runat="server" Text=" "></asp:Label>
        <br />
        <asp:Button ID="btn" runat="server" Text="Button" Width="148px" />
        <br />
        <br />
        <asp:CheckBox ID="chbPagina" runat="server" Text="Ir a la pagina de Altair" />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="49px" ImageUrl="~/imagenes/logo-inicio.png" Width="74px" OnClick="ImageButton1_Click" />
    
    </div>
    </form>
</body>
</html>
