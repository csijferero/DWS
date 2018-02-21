<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyWeb_Fernandez_JoseAntonio.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 201px;
        }
        .auto-style2 {
            width: 171px;
        }
        .auto-style3 {
            width: 167px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
    <div style="margin-left:auto;margin-right:auto;" class="auto-style1">


        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="201px" ImageUrl="~/Resources/Sevitaxi.jpg" PostBackUrl="~/Login.aspx" Width="201px" />


        <br />
        <br />


    </div>
        <div style="margin-left:auto;margin-right:auto;text-align: center; background-color: Snow;" class="auto-style2">


            <br />
            <asp:TextBox ID="txbNewUser" runat="server" Width="160px" placeholder="Usuario" MaxLength="10"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="loginVal" runat="server" ControlToValidate="txbNewUser" Display="Dynamic" ErrorMessage="Usuario Necesario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="loginValEx" runat="server" ControlToValidate="txbNewUser" Display="Dynamic" ErrorMessage="Ya existe un login igual" Font-Bold="True" ForeColor="Red"></asp:CustomValidator>
            <br />
            <asp:TextBox ID="txbAlias" runat="server" Width="160px" placeholder="Alias" MaxLength="4"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="aliasVal" runat="server" ControlToValidate="txbAlias" Display="Dynamic" ErrorMessage="Alias Necesario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="aliasValEx" runat="server" ControlToValidate="txbAlias" Display="Dynamic" ErrorMessage="Ya existe un alias igual" Font-Bold="True" ForeColor="Red"></asp:CustomValidator>
            <br />
            <asp:TextBox ID="txbNombre" runat="server" Width="160px" placeholder="Nombre" MaxLength="50"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="nombreVal" runat="server" ControlToValidate="txbNewUser" Display="Dynamic" ErrorMessage="Nombre Necesario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="txbNewPass" runat="server" Width="160px" placeholder="Contraseña" TextMode="Password" MaxLength="10"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="passVal" runat="server" ControlToValidate="txbNewPass" Display="Dynamic" ErrorMessage="Contraseña Necesaria" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txbConfirmNewPass" runat="server" Width="160px" placeholder="Confirmar Contraseña" TextMode="Password" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="passConfVal" runat="server" ControlToValidate="txbConfirmNewPass" Display="Dynamic" ErrorMessage="Contraseña Necesaria" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbNewPass" ControlToValidate="txbConfirmNewPass" Display="Dynamic" ErrorMessage="Las contraseñas no coinciden" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
            <asp:CheckBox ID="chbTerminos" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Small" Text="Acepto los Terminos y Condiciones" />
            <br />
            <asp:CustomValidator ID="confVal" runat="server" Display="Dynamic" ErrorMessage="Necesita Aceptar" Font-Bold="True" ForeColor="Red"></asp:CustomValidator>
            <br />


        </div>

        <div style="margin-left:auto;margin-right:auto;text-align: center;" class="auto-style3">

            <asp:Button ID="btnRegistro" runat="server" BackColor="#3366FF" Font-Bold="True" ForeColor="White" Text="Registrarse" Width="166px" OnClick="btnRegistro_Click" />

        </div>

    </form>

</body>
</html>
