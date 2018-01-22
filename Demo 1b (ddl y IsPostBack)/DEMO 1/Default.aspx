<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DEMO_1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
            &nbsp;<asp:Image ID="Image1" runat="server" 
        ImageUrl="~/Imagenes/casaMunecas2.jpg" Height="100px" />
    
    <div style="width: 873px">
        <asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido a ASP.net!"></asp:Label>
        <br />
        A quíen quieres saludar?&nbsp;<asp:DropDownList ID="ddlNombres" runat="server" Font-Bold="True" Font-Size="Small" Height="25px" Width="126px">
        </asp:DropDownList>
&nbsp;<asp:Button ID="btnSaludar" runat="server" Text="Saludar" 
            onclick="btnSaludar_Click" />
        &nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lbSaludo" runat="server" BackColor="#FFFF99" BorderColor="#0066FF" BorderWidth="3px" Font-Bold="True" Font-Size="X-Large" Height="25px" Visible="False" ></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txbNombre" runat="server" Width="142px"></asp:TextBox>
        <asp:Button ID="btnAnyadir" runat="server" Text="Añadir a lista" 
            onclick="btnAnyadir_Click" />
        <br />
    </div>
    </form>
</body>
</html>
