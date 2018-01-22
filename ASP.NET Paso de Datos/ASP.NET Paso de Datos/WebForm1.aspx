<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_Paso_de_Datos.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;<asp:Label ID="lblNombre" runat="server" Font-Italic="True" Font-Size="Large" Text="Introduzca su nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbNombre" runat="server" Width="162px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="nombreValidator" runat="server" ControlToValidate="txbNombre" ErrorMessage="Nombre Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300">El nombre es obligatorio</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="115px" ImageUrl="~/imagenes/s-l1600.jpg" OnClick="ImageButton1_Click" Width="162px" />
    
    </div>
    </form>
</body>
</html>
