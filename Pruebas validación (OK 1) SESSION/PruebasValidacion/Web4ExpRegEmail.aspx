<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web4ExpRegEmail.aspx.cs" Inherits="PruebasValidacion.WebFormEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
            <asp:Label ID="lbBienvenido" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Red" Text="Pruebas de RegularExpresionValidator"></asp:Label>
            <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        &nbsp;&nbsp;&nbsp;<asp:Label ID="lbNombre" runat="server"></asp:Label>
    
            <asp:Label ID="lbApellidos" runat="server"></asp:Label>
    
            <asp:Label ID="lbPassword" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbRepetir" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbMovil" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbTelefono" runat="server" Visible="False"></asp:Label>
    
            <br class="auto-style1" />
            <br class="auto-style1" />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
    
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txbEmail" Display="Dynamic" ErrorMessage="El texto introducido no es un E-mail correcto" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txbEmail" Display="Dynamic" ErrorMessage="Debe introducir su E-mail" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:ImageButton ID="ibtnEnviar" runat="server" Height="129px" ImageUrl="~/Imagenes/domicilio.png" Width="168px" OnClick="ibtnEnviar_Click" />
    
    </div>
    </form>
</body>
</html>
