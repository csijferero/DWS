<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="PruebasValidacion.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbBienvenido" Text="Prueba de RegularExpresionValidator" runat="server"
            Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#FF3399"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblHola" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Font-Italic="True" Text="Introduzca el Email"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbMail" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txbMail" Display="Dynamic" ErrorMessage="Email requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300">El email es obligatorio</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txbMail" ErrorMessage="Debe inidicar un email correcto" Font-Bold="True" Font-Size="Large" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email incorrecto</asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="Ir al Domicilio" Height="125px" ImageUrl="~/Imagenes/eYEpp28U.jpg" Width="127px" PostBackUrl="~/WebForm5.aspx" />
    
    </div>
    </form>
</body>
</html>
