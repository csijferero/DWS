<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PruebasValidacion.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pruebas de Validacion</title>
<script type="text/javascript">
function ValidaEdad(source, arguments) 
{
    txbSeguimiento.value = "Estoy en la validación del cliente";
    //Obtiene valor inicial
    var valor = txbRepEdad.value;
    //Comprobación de valor numerico
    if (isNaN(parseInt(valor))) 
    {
        arguments.IsValid = false; 
        return;
    }
    valor = parseInt(valor);    //Se hace el cast a int ya que proviene de un string                

    if (valor < 18 || valor > 75) 
    {//Se realiza la comparación del valor esperado
        arguments.IsValid = false; 
        return;
    }
    arguments.IsValid = true;    //Si llego hasta aqui entonces la validación fue exitosa
}
</script>

    <style type="text/css">
        .auto-style1 {
            width: 577px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbBienvenido" Text="Pruebas de Validación" runat="server"
            Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="txbSeguimiento" runat="server" Rows="4" TextMode="MultiLine" Width="555px"></asp:TextBox>
        <br />
        <table>
            <tr>
                <td>&nbsp;Edad 
                </td>
                <td>&nbsp;<asp:TextBox ID="txbEdad" runat="server" BackColor="#66FF66" BorderStyle="Inset" Width="221px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txbEdad" ErrorMessage="El campo Edad debe estar cumplimentado" Font-Italic="True" ForeColor="Red" Display="Dynamic">Campo Obligatorio</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="La edad tiene que estar entre 18 y 75 años" ControlToValidate="txbEdad" Display="Dynamic" ForeColor="Red" MaximumValue="75" MinimumValue="18" SetFocusOnError="True" Type="Integer">Edad inadecuada</asp:RangeValidator>
&nbsp;</td>
            </tr>
                        <tr>
                <td>&nbsp;Repite Edad 
                </td>
                <td>&nbsp;<asp:TextBox ID="txbRepEdad" runat="server" BackColor="#66FF66" BorderStyle="Inset" Width="221px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbEdad" ControlToValidate="txbRepEdad" ErrorMessage="Los campos Edad y Repite Edad deben ser iguales" ForeColor="Red" Display="Dynamic">Debe repetir la edad</asp:CompareValidator>   
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txbRepEdad" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="ValidaEdad" Font-Bold="True" Display="Dynamic">CUSTOM DETECTÓ ERROR</asp:CustomValidator>

                &nbsp;Validación mediante CustomValidator</td>
            </tr>
            <tr>
                <td>&nbsp;E-mail 
                </td>
                <td>&nbsp;<asp:TextBox ID="txbMail" runat="server" BackColor="#66FF66" BorderStyle="Inset" Width="221px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txbMail" ErrorMessage="Debe inidicar un email correcto" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email incorrecto</asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>&nbsp;
                </td>
                <td>&nbsp;<asp:Button ID="btnEnviar" runat="server" Text="Enviar" Width="112px" OnClick="btnEnviar_Click" />
                </td>
                <td class="auto-style1">&nbsp;
                    Páginas de Expresiones Regulares: &quot;regexlib.com&quot; ó &quot;regularexpression.com&quot;</td>
            </tr>

        </table>
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        

    </div>
    </form>
</body>
</html>
