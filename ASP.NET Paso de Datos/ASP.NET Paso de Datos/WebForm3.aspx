<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ASP.NET_Paso_de_Datos.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblSaludo" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#33CC33" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="lblEdad" runat="server" Font-Italic="True" Text="Edad"></asp:Label>
&nbsp;<asp:TextBox ID="txbEdad" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="edadValidator" runat="server" ControlToValidate="txbEdad" ErrorMessage="Edad Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300" Display="Dynamic">La Edad es obligatoria</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="edadVal" runat="server" ControlToValidate="txbEdad" Display="Dynamic" ErrorMessage="Edad Erronea" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Integer">La edad no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <br />
        <asp:Label ID="lblConf" runat="server" Font-Italic="True" Text="Confirme Edad"></asp:Label>
&nbsp;<asp:TextBox ID="txbConf" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="confValidator" runat="server" ControlToValidate="txbConf" ErrorMessage="Confirmacion Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300" Display="Dynamic">La Confirmacion es obligatoria</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No coincide" Font-Bold="True" Font-Size="Large" ForeColor="Red" Type="Integer" ControlToCompare="txbEdad" ControlToValidate="txbConf"></asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Font-Italic="True" Text="Introduzca el Email"></asp:Label>
&nbsp;<asp:TextBox ID="txbMail" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txbMail" ErrorMessage="Email requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300" Display="Dynamic">El email es obligatorio</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txbMail" ErrorMessage="Debe inidicar un email correcto" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Bold="True" Font-Size="Large">Email incorrecto</asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnEdad" runat="server" Text="Button" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
    </div>
    </form>
</body>
</html>
