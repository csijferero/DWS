<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web2ComparePassword.aspx.cs" Inherits="PruebasValidacion.WebFormPassword" %>

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
    
            <asp:Label ID="lbBienvenido" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Lime" Text="Pruebas de CompareValidator"></asp:Label>
            <br />
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
           &nbsp;&nbsp; &nbsp;<asp:Label ID="lbNombre" runat="server"></asp:Label>
            <asp:Label ID="lbApellidos" runat="server"></asp:Label>
        <br/>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
       &nbsp;&nbsp; <asp:TextBox ID="txbPass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rvPass" runat="server" ControlToValidate="txbPass" Display="Dynamic" ErrorMessage="Campo no puede estar vacio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Repetir"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="txbRepetir" runat="server" TextMode="Password"></asp:TextBox>
    
            <asp:CompareValidator ID="cv2" runat="server" ControlToCompare="txbPass" ControlToValidate="txbRepetir" Display="Dynamic" ErrorMessage="Las contraseñas no coinciden" ForeColor="Red"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="rvRepetir" runat="server" ControlToValidate="txbRepetir" Display="Dynamic" ErrorMessage="Campo no puede estar vacio" ForeColor="Red"></asp:RequiredFieldValidator>
    
            <br/>
            <br/>
            <asp:ImageButton ID="ibtnEnviar" runat="server" Height="129px" Width="168px" ImageUrl="~/Imagenes/phone.png" PostBackUrl="~/Web3RangeTelefono.aspx" />
    
    </div>
    </form>
</body>
</html>
