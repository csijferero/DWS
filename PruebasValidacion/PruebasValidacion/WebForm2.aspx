<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PruebasValidacion.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbBienvenido" Text="Prueba de CompareValidator" runat="server"
            Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblSaludo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="valPass" runat="server" ErrorMessage="Contraseña Requerida" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbPass" Display="Dynamic">La contraseña es obligatoria</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblConf" runat="server" Text="Repetir"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbConf" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ValConf" runat="server" ErrorMessage="Confirmacion Requerida" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbConf" Display="Dynamic">La confirmacion es obligatoria</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbPass" ControlToValidate="txbConf" Display="Dynamic" ErrorMessage="Contraseñas Diferentes" Font-Bold="True" Font-Size="Large" ForeColor="Red">Las contraseñas no coinciden</asp:CompareValidator>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="Ir al Telefono" Height="125px" ImageUrl="~/Imagenes/eYEpp28U.jpg" Width="127px" PostBackUrl="~/WebForm3.aspx" />
    
    </div>
    </form>
</body>
</html>
