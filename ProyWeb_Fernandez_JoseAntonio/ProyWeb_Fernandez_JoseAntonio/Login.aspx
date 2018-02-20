<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyWeb_Fernandez_JoseAntonio.Login" %>

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
            <asp:TextBox ID="txbUser" runat="server" Width="160px" placeholder="Usuario"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txbPass" runat="server" Width="160px" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAcceder" runat="server" BackColor="#0099FF" Font-Bold="True" Text="Acceder" Width="75px" ForeColor="White" />
            <br />
            <br />
            <br />


        </div>

        <div style="margin-left:auto;margin-right:auto;text-align: center;" class="auto-style3">

            <asp:Button ID="btnRegistro" runat="server" BackColor="#CC0000" Font-Bold="True" ForeColor="White" Text="Registrarse" Width="166px" />

        </div>

    </form>

</body>
</html>
