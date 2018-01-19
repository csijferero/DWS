<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Combo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 92px;
            height: 110px;
        }
        .auto-style3 {
            height: 110px;
        }
        .auto-style4 {
            height: 161px;
            width: 243px;
            margin-right: 6px;
        }
        .auto-style5 {
            width: 571px;
            height: 110px;
        }
        .auto-style6 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1"><img src="imagenes/bici.jpg" class="auto-style4" /></td>
                <td class="auto-style5" style="background-color: #00FFFF"><span style="color: rgb(33, 33, 33); font-family: Calibri, sans-serif; font-size: 14.6667px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 204, 204); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Cuando se pulse el botón Saludar, debe presentarse el saludo en su etiqueta y el nombre elegido en txtAmigo.</span><br style="color: rgb(33, 33, 33); font-family: Calibri, sans-serif; font-size: 14.6667px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;" />
                    <br style="color: rgb(33, 33, 33); font-family: Calibri, sans-serif; font-size: 14.6667px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;" />
                    <span style="color: rgb(33, 33, 33); font-family: Calibri, sans-serif; font-size: 14.6667px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 204, 204); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Si pulsas el botón Añadir a la lista, se incorporará el texto al final del ddl. Luego se limpiará txtAmigo</span></td>
                <td class="auto-style3"></td>
            </tr>
        </table>
    </div>
        <asp:Label ID="lblQuien" runat="server" Text="A quien quieres saludar?"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlAmigo" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaludo" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="txtSaludo" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Label ID="txtAmigo" runat="server" Text="Amigo:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txbAmigo" runat="server" CssClass="auto-style6"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAmigo" runat="server" Text="Button" />
    </form>
</body>
</html>
