<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web5CustomDomicilio.aspx.cs" Inherits="PruebasValidacion.WebFormDomicilio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
function ValidaCP(source, arguments) 
{
    //Obtiene valor inicial
    var valor = txbCP.value;
    //Comprobación de valor numerico
    if (isNaN(parseInt(valor))) 
    {
        arguments.IsValid = false; 
        return;
    }
    valor = parseInt(valor);    //Se hace el cast a int ya que proviene de un string                

    if (valor < 41000 || valor > 41999) 
    {//Se realiza la comparación del valor esperado
        arguments.IsValid = false; 
        return;
    }
    arguments.IsValid = true;    //Si llego hasta aquí entonces la validación fue exitosa
}
</script>
    <style type="text/css">
        .auto-style1 {
            margin-left: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
            <asp:Label ID="lbBienvenido" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#0099ff" Text="Prueba de CustomValidator"></asp:Label>
            <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbNombre" runat="server"></asp:Label>
        <asp:Label ID="lbApellidos" runat="server"></asp:Label>
    
            <asp:Label ID="lbPassword" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbRepetir" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbMovil" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbTelefono" runat="server" Visible="False"></asp:Label>
    
            <asp:Label ID="lbEmail" runat="server" Visible="False"></asp:Label>
    
        <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:Label ID="Label2" runat="server" Text="Población"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbPoblacion" runat="server" Width="188px"></asp:TextBox>
        <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:Label ID="Label3" runat="server" Text="Código Postal"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbCP" runat="server" Width="93px"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txbCP" ErrorMessage="El código postal debe de ser de cinco cifras y empezar por 41"  ClientValidationFunction="ValidaCP" Font-Bold="True" Display="Dynamic" ForeColor="Red">El código postal debe de ser de cinco cifras y empezar por 41</asp:CustomValidator>

        <br class="auto-style1" />
        <br class="auto-style1" />
        <asp:ImageButton ID="ibtnEnviar" runat="server" ClientValidationFunction="ValidaCP" Height="129px" ImageUrl="~/Imagenes/formulario.png" Width="168px" PostBackUrl="~/Web6SummaryGlobal.aspx" />
    
    </div>
    </form>
</body>
</html>
