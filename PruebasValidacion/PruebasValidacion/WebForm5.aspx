<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="PruebasValidacion.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <script type="text/javascript">
        function validaCP(source, arguments) {
            if (Convert.ToInt32(txbCP.Text) < 41000 || Convert.ToInt32(txbCP.Text) > 41999) {//Se realiza la comparación del valor esperado
                arguments.IsValid = false;
            }
            else
                arguments.IsValid = true;    //Si llego hasta aqui entonces la validación fue exitosa
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lbBienvenido" Text="Prueba de CustomValidator" runat="server"
                Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#FF3399"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblHola" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblPob" runat="server" Text="Poblacion"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPob" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCP" runat="server" Text="CP"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbCP" runat="server" TextMode="Number"></asp:TextBox>
            <asp:CustomValidator ID="custoVal" runat="server" ClientValidationFunction="validaCP" ControlToValidate="txbCP" ErrorMessage="Error de Formato" Font-Bold="True" Font-Size="Large" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">Debe tener 6 digitos y comenzar por 41</asp:CustomValidator>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="Ir al Sumario" Height="125px" ImageUrl="~/Imagenes/eYEpp28U.jpg" Width="127px" PostBackUrl="~/WebForm6.aspx" />

            <br />

        </div>
    </form>
</body>
</html>
