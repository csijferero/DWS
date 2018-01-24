<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP.NET_Paso_de_Datos.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblBienvenida" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#33CC33" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblMovil" runat="server" Font-Italic="True" Text="Movil"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbMovil" runat="server" TextMode="Phone"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="movilValidator" runat="server" ControlToValidate="txbMovil" ErrorMessage="Movil Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300" Display="Dynamic">El movil es obligatorio</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="MovilRango" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="Movil Erroneo" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="699999999" MinimumValue="600000000" Type="Integer">El movil no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <asp:Label ID="lblFijo" runat="server" Font-Italic="True" Text="Fijo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbFijo" runat="server" TextMode="Phone"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="fijoValidator" runat="server" ControlToValidate="txbFijo" ErrorMessage="Fijo Requerido" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300" Display="Dynamic">El fijo es obligatorio</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="FijoRango" runat="server" ControlToValidate="txbFijo" Display="Dynamic" ErrorMessage="Fijo Erroneo" Font-Bold="True" Font-Size="Large" ForeColor="Red" MaximumValue="959999999" MinimumValue="950000000" Type="Integer">El fijo no tiene un formato adecuado</asp:RangeValidator>
        <br />
        <br />
        <asp:Button ID="btnTFN" runat="server" Text="Button" OnClick="btnTFN_Click" />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="80px" />
    
    </div>
    </form>
</body>
</html>
