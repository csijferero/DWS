<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web6SummaryGlobal.aspx.cs" Inherits="PruebasValidacion.WebFormGlobal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 50px;
        }
    </style>
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
    arguments.IsValid = true;    //Si llego hasta aqui entonces la validación fue exitosa
}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1" >
    
            <asp:Label ID="lbBienvenido" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#33cc33" Text="Prueba de ValidationSumary"></asp:Label>
    
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txbNombre" Display="Dynamic" ErrorMessage="Escriba un nombre, por favor." ForeColor="Red">* Indique el nombre</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbApellidos" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbApellidos" Display="Dynamic" ErrorMessage="Escriba los apellidos, por favor." ForeColor="Red">* Indique los apellidos</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txbPassword" Display="Dynamic" ErrorMessage="Escriba una contraseña, por favor." ForeColor="Red">* Indique la contraseña</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Repetir"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbRepetir" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txbRepetir" Display="Dynamic" ErrorMessage="Repita la contraseña, por favor." ForeColor="Red">* Repita la contraseña</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbPassword" ControlToValidate="txbRepetir" Display="Dynamic" ErrorMessage="Las contraseñas no coinciden, escríbela de nuevo por favor." ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Móvil"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMovil" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="Escriba un número de movil, por favor." ForeColor="Red">* Indique el móvil</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvMovil" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="* El móvil debe tener 9 dígitos y empezar por 6 o 7" ForeColor="Red" MaximumValue="799999999" MinimumValue="599999999" Type="Integer"></asp:RangeValidator>
    
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Tel.Fijo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbTelefono" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RangeValidator ID="rvTlf" runat="server" ControlToValidate="txbTelefono" Display="Dynamic" ErrorMessage="* El fijo debe tener 9 dígitos y empezar por 955 o 954" ForeColor="Red" MaximumValue="955999999" MinimumValue="953999999" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="E-mail"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbEmail" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txbEmail" Display="Dynamic" ErrorMessage="Escriba un e-mail, por favor." ForeColor="Red">* Indique el e-mail</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Población"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbPoblacion" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Código Postal"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbCP" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txbCP" Display="Dynamic" MaximumValue="41999" MinimumValue="41000"></asp:RangeValidator>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txbCP" ErrorMessage="El código postal debe de ser de cinco cifras y empezar por 41" OnServerValidate ="CustomValidator1_ServerValidate" ClientValidationFunction="ValidaCP" Font-Bold="True" Display="Dynamic" ForeColor="Red">El código postal debe de ser de cinco cifras y empezar por 41</asp:CustomValidator>

            <br />
            <br />
            <asp:ImageButton ID="ibtnEnviar" runat="server" Height="129px" ImageUrl="~/Imagenes/ok.png" Width="168px" PostBackUrl="~/WebFormFin.aspx" />
    
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    
    </div>
    </form>
</body>
</html>
