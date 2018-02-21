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


        <asp:Image ID="pictureBox1" runat="server" Height="201px" ImageUrl="~/Resources/Sevitaxi.jpg" Width="201px" />


        <br />
        <br />


    </div>
        <div style="margin-left:auto;margin-right:auto;text-align: center; background-color: Snow;" class="auto-style2">


            <br />
            <asp:TextBox ID="txbNewUser" runat="server" Width="160px" placeholder="Usuario"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="loginVal" runat="server" ControlToValidate="txbUser" Display="Dynamic" ErrorMessage="Usuario Necesario" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="loginVal2" runat="server" ControlToValidate="txbUser" Display="Dynamic" ErrorMessage="Login Incorrecto" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:CustomValidator>
            <br />
            <asp:TextBox ID="txbAlias" runat="server" Width="160px" placeholder="Alias"></asp:TextBox>
            <asp:RequiredFieldValidator ID="aliasVal" runat="server" ControlToValidate="txbUser" Display="Dynamic" ErrorMessage="Alias Necesario" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="loginVal4" runat="server" ControlToValidate="txbUser" Display="Dynamic" ErrorMessage="Login Incorrecto" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:CustomValidator>
            <br />
            <asp:TextBox ID="txbNombre" runat="server" Width="160px" placeholder="Nombre"></asp:TextBox>
            <asp:RequiredFieldValidator ID="nombreVal" runat="server" ControlToValidate="txbUser" Display="Dynamic" ErrorMessage="Nombre Necesario" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="loginVal6" runat="server" ControlToValidate="txbUser" Display="Dynamic" ErrorMessage="Login Incorrecto" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:CustomValidator>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txbNewPass" runat="server" Width="160px" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="passVal" runat="server" ControlToValidate="txbPass" Display="Dynamic" ErrorMessage="Contraseña Necesaria" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="passVal2" runat="server" ControlToValidate="txbPass" Display="Dynamic" ErrorMessage="Contraseña Incorrecta" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:CustomValidator>
            <br />
            <asp:TextBox ID="txbConfirmNewPass" runat="server" Width="160px" placeholder="Confirmar Contraseña" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="passConfVal" runat="server" ControlToValidate="txbPass" Display="Dynamic" ErrorMessage="Contraseña Necesaria" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="passVal4" runat="server" ControlToValidate="txbPass" Display="Dynamic" ErrorMessage="Contraseña Incorrecta" Font-Bold="True" ForeColor="Red" ValidationGroup="acceder"></asp:CustomValidator>
            <br />
            <asp:CheckBox ID="chbTerminos" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Small" Text="Acepto los Terminos y Condiciones" />
            <br />


        </div>

        <div style="margin-left:auto;margin-right:auto;text-align: center;" class="auto-style3">

            <asp:Button ID="btnRegistro" runat="server" BackColor="#3366FF" Font-Bold="True" ForeColor="White" Text="Registrarse" Width="166px" OnClick="btnRegistro_Click" />

        </div>

    </form>

</body>
</html>
