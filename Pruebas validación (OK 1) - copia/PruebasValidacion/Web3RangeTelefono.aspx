<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web3RangeTelefono.aspx.cs" Inherits="PruebasValidacion.WebFormTelefono" %>

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
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
            <asp:Label ID="lbBienvenido" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Orange" Text="Pruebas de RangeValidator"></asp:Label>
            <br/>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
       &nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="lbNombre" runat="server"></asp:Label>
    
        <asp:Label ID="lbApellidos" runat="server"></asp:Label>
         <!-- las siguientes etiquetas se ocultan porque sólo queremos guardar la info para la siguiente página-->
        <asp:Label ID="lbPassword" runat="server" Visible="False"></asp:Label>
    
        <asp:Label ID="lbRepetir" runat="server" Visible="False"></asp:Label>
    
        <br/>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Movil"></asp:Label>
     &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:TextBox ID="txbMovil" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvMovil" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="* Debe introducir el número de móvil" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvMovil" runat="server" ControlToValidate="txbMovil" Display="Dynamic" ErrorMessage="* El móvil debe tener 9 dígitos y empezar por 6 o 7" ForeColor="Red" MaximumValue="799999999" MinimumValue="599999999" Type="Integer"></asp:RangeValidator>
    
            <br/>
            <br/>
        <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
        &nbsp;&nbsp;    
            <asp:TextBox ID="txbTelefono" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="rvTlf" runat="server" ControlToValidate="txbTelefono" Display="Dynamic" ErrorMessage="* El fijo debe tener 9 dígitos y empezar por 955 o 954" ForeColor="Red" MaximumValue="955999999" MinimumValue="953999999" Type="Integer"></asp:RangeValidator>
            <br/>
            <br/>
            <asp:ImageButton ID="ibtnEnviar" runat="server" Height="129px" ImageUrl="~/Imagenes/email.png" Width="168px" OnClick="ibtnEnviar_Click" />
    
    </div>
    </form>
</body>
</html>
