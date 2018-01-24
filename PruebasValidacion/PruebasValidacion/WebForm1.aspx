<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PruebasValidacion.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pruebas de Validacion</title>

    </head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbBienvenido" Text="Prueba de RequeridedValidator" runat="server"
            Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="valNombre" runat="server" ErrorMessage="Nombre Requerido" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbNombre">El nombre es obligatorio</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblApell" runat="server" Text="Apellidos"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbApell" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="valApell" runat="server" ErrorMessage="Apellido Requerido" Font-Bold="True" Font-Size="Large" ForeColor="Red" ControlToValidate="txbApell">Los apellidos son obligatorios</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="Ir al Password" Height="125px" ImageUrl="~/Imagenes/eYEpp28U.jpg" Width="127px" PostBackUrl="~/WebForm2.aspx" />
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />

    </div>
    </form>
</body>
</html>
