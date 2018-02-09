<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaDetalleAlumno.aspx.cs" Inherits="WebAlumnosFP.PaginaDetalleAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style type="text/css">
        table {
            margin-left: 10%;
            margin-top: 10%;
            padding: 30px;
            border: red 2px solid;
            text-align: center;
        }

        #Image {
            margin-top: 25px;
        }

        h2 {
            color: red;
        }
        .auto-style1 {
            width: 154px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="PanelForm" runat="server">
                <table>
                    <tr>
                        <th colspan="3">
                            <h2>Datos del Alumno</h2>
                        </th>
                    </tr>
                    <tr>
                        <td>Apellidos, Nombre</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txbApellNom" runat="server" BackColor="#FFCC99"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="validaRequiredApellidosNombre" runat="server" ErrorMessage="Debe indicar sus Apellidos, Nombre" Display="Dynamic" ControlToValidate="txbApellNom" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>DNI</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txbDNI" runat="server" BackColor="#FFCC99"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="validaRequiredDNI" runat="server" ErrorMessage="Debe Indicar su DNI" ControlToValidate="txbDNI" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="validaRegularExpressionDNI" runat="server" ErrorMessage="El DNI está compuesto por 8cifras - LETRA" ControlToValidate="txbDNI" Display="Dynamic" ForeColor="Red" ValidationExpression="\d{8}-[A-Z]"></asp:RegularExpressionValidator>

                        </td>
                    </tr>
                    
                    
                    <tr>
                        <td>Movil</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txbMovil" runat="server" BackColor="#FFCC99"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="validaRequiredMovil" runat="server" ErrorMessage="Debe introducir número de móvil" ForeColor="Red" ControlToValidate="txbMovil" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="validaRangeMovil" runat="server" ErrorMessage="El móvil debe tener 9 dígitos y comenzar por 6 o 7" ControlToValidate="txbMovil" ForeColor="Red" MaximumValue="799999999" MinimumValue="600000000" Display="Dynamic"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Teléfono</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txbTelefono" runat="server" BackColor="#FFCC99"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RangeValidator ID="validaRangeTelefono" runat="server" ErrorMessage="El fijo de 9 dígitos y que comience por 954 o 955" ControlToValidate="txbTelefono" ForeColor="Red" MaximumValue="955999999" MinimumValue="954000000" Display="Dynamic"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Email</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txbMail" runat="server" BackColor="#FFCC99"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="validaRequiredEmail" runat="server" ErrorMessage="Debe introducir su e-mail" ControlToValidate="txbMail" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="validaRegularExpressionEmail" runat="server" ErrorMessage="El texto introducido no es un email correcto" ControlToValidate="txbMail" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Grupo</td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="ddlGrupos" runat="server" BackColor="#FFCC99">
                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    <tr> <td>&nbsp; </td>
                        <td class="auto-style1">
                           
                        </td>
                        <td></td></tr>
                    <tr>
                        <td>&nbsp; </td>
                        <td class="auto-style1">
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"/>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="#0066FF" />
                        </td>
                    </tr>

                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
