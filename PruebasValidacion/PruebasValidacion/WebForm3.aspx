<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="PruebasValidacion.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbBienvenido" Text="Prueba de RangeValidator" runat="server"
            Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#FF3399"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblHola" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblMovil" runat="server" Font-Italic="True" Text="Movil"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbMovil" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:RangeValidator ID="MovilRango" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="Movil Erroneo" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="699999999" MinimumValue="600000000" Type="Integer">El movil no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <asp:Label ID="lblFijo" runat="server" Font-Italic="True" Text="Fijo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbFijo" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:RequiredFieldValidator ID="fijoValidator" runat="server" ControlToValidate="txbFijo" Display="Dynamic" ErrorMessage="Fijo Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300">El fijo es obligatorio</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="FijoRango" runat="server" ControlToValidate="txbFijo" Display="Dynamic" ErrorMessage="Fijo Erroneo" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="959999999" MinimumValue="950000000" Type="Integer">El fijo no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="Ir al Email" Height="125px" ImageUrl="~/Imagenes/eYEpp28U.jpg" Width="127px" PostBackUrl="~/WebForm4.aspx" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
