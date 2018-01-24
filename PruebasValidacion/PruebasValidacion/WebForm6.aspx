<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="PruebasValidacion.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbBienvenido" Text="Prueba de ValidationSummary" runat="server"
            Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#FF3399"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="valNombre" runat="server" ErrorMessage="Nombre Requerido" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbNombre">El nombre es obligatorio</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblApell" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="txbApell" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="valApell" runat="server" ErrorMessage="Apellido Requerido" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbApell">Los apellidos son obligatorios</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txbPass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="valPass" runat="server" ErrorMessage="Contraseña Requerida" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbPass" Display="Dynamic">La contraseña es obligatoria</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblConf" runat="server" Text="Repetir"></asp:Label>
        <asp:TextBox ID="txbConf" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ValConf" runat="server" ErrorMessage="Confirmacion Requerida" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbConf" Display="Dynamic">La confirmacion es obligatoria</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbPass" ControlToValidate="txbConf" Display="Dynamic" ErrorMessage="Contraseñas Diferentes" Font-Bold="True" Font-Size="Large" ForeColor="Red">Las contraseñas no coinciden</asp:CompareValidator>
        <br />
        <asp:Label ID="lblMovil" runat="server" Font-Italic="True" Text="Movil"></asp:Label>
        <asp:TextBox ID="txbMovil" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:RangeValidator ID="MovilRango" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="Movil Erroneo" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="699999999" MinimumValue="600000000" Type="Integer">El movil no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <asp:Label ID="lblFijo" runat="server" Font-Italic="True" Text="Fijo"></asp:Label>
        <asp:TextBox ID="txbFijo" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:RequiredFieldValidator ID="fijoValidator" runat="server" ControlToValidate="txbFijo" Display="Dynamic" ErrorMessage="Fijo Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300">El fijo es obligatorio</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="FijoRango" runat="server" ControlToValidate="txbFijo" Display="Dynamic" ErrorMessage="Fijo Erroneo" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="959999999" MinimumValue="950000000" Type="Integer">El fijo no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Font-Italic="True" Text="Introduzca el Email"></asp:Label>
        <asp:TextBox ID="txbMail" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txbMail" Display="Dynamic" ErrorMessage="Email requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300">El email es obligatorio</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txbMail" ErrorMessage="Debe inidicar un email correcto" Font-Bold="True" Font-Size="Large" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email incorrecto</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="lblPob" runat="server" Text="Poblacion"></asp:Label>
        <asp:TextBox ID="txbPob" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCP" runat="server" Text="CP"></asp:Label>
        <asp:TextBox ID="txbCP" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txbCP" ErrorMessage="Error de Formato" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="41999" MinimumValue="41000" Type="Integer">Debe tener 6 digitos y comenzar por 41</asp:RangeValidator>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="Ir al Password" Height="125px" ImageUrl="~/Imagenes/eYEpp28U.jpg" Width="127px" PostBackUrl="~/WebForm7.aspx" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
