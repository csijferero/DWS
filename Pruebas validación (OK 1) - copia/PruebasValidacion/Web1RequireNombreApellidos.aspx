<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web1RequireNombreApellidos.aspx.cs" Inherits="PruebasValidacion.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pruebas de Validacion</title>

</head>
<body>
     <form id="form1" runat="server">
        <div style="margin-left: 50px">
            <asp:Label ID="lbBienvenido" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Red" Text="Pruebas de Validación"></asp:Label>
            <br />
            <table>
                <tr>
                    <td>&nbsp; </td>
                    <td>&nbsp; </td>
                    <td>&nbsp; </td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNombre" runat="server" Width="143px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv" runat="server" ClientValidationFunction="ControlEspacios" ControlToValidate="txbNombre" Display="Dynamic" ErrorMessage="* Este campo no puede estar vacío" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txbApellidos" runat="server" Width="143px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv0" runat="server" ClientValidationFunction="ControlEspacios" ControlToValidate="txbApellidos" Display="Dynamic" ErrorMessage="* Tiene que indicar su/s Apellidos" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
         <div style="margin-left: 50px">
             <asp:ImageButton ID="ibtnEnviar" runat="server" Height="129px" ImageUrl="~/Imagenes/password.png" Width="168px" OnClick="btnEnviar_Click" />
         </div>
   
   
    <div style="margin-left: 320px">
        <br />
        <br />

    </div>
    </form>
     <p>
&nbsp;&nbsp;&nbsp;
     </p>
     <p>
         &nbsp;</p>
</body>
</html>
