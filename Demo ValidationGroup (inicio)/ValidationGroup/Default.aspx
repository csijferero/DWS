<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationGroup.Default" UnobtrusiveValidationMode="None"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba de Validation Group</title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 26px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            width: 586%;
        }
        .auto-style5 {
            width: 102%;
        }
        .auto-style6 {
            width: 13333%;
        }
        .auto-style7 {
            width: 13267%;
        }
        .auto-style11 {
            width: 99px;
            height: 12px;
        }
        .auto-style12 {
            height: 33px;
            width: 3px;
        }
        .auto-style13 {
            width: 3px;
        }
        .auto-style16 {
            width: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

            <div>
                <table width="100%" cellspacing="12">
                    <tr><td align=center bgcolor="#CCFFCC" class="auto-style12">
                        <asp:Label ID="Label1" runat="server" Text="Validacion Clientes"></asp:Label></td>
                        <td align="center" bgcolor="#CCFFCC" class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text="Validacion Admin"></asp:Label>
                        </td>
                    </tr>
                    <tr><td class="auto-style13">
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style11">
                                    <asp:Label ID="Label3" runat="server" Text="Usuario : "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtUsu" runat="server" BackColor="#FFCC00"></asp:TextBox>
                                </td>
                            </tr>
                            <tr><td colspan="2">
                                <asp:RequiredFieldValidator ID="valUserUser" runat="server" ControlToValidate="txtUsu" ErrorMessage="Usuario requerido" ValidationGroup="ValidarCliente" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td></tr>
                        </table>
                        </td>
                    <td style="width: 84px">
                    <table class="auto-style4">
                            <tr>
                                <td class="auto-style16">
                                     <asp:Label ID="Label4" runat="server" Text="CorreoAdmin : "></asp:Label>
                                </td>
                                <td>
                                    
                                    <asp:TextBox ID="txtCorreo" runat="server" BackColor="#FFCC00"></asp:TextBox>
                                    
                                </td>
                            </tr>
                             <tr><td colspan="2">
                                 <asp:RegularExpressionValidator ID="valEmail" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Correo Admin Erroneo" ValidationGroup="ValidarAdmin" Font-Bold="True" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                                 <asp:RequiredFieldValidator ID="valCorreoReq" runat="server" ControlToValidate="txtCorreo" Display="Dynamic" ErrorMessage="Correo Admin Requerido" Font-Bold="True" ForeColor="Red" ValidationGroup="ValidarAdmin"></asp:RequiredFieldValidator>
                                 </td></tr>
                        </table>
                       
                        
                        </td>
                    </tr>
                    <tr><td class="auto-style13">
                        <table class="auto-style7">
                            <tr>
                                <td style="width: 100px">
                                    <asp:Label ID="Label5" runat="server" Text="Contraseña : "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPass" runat="server" BackColor="#FFCC00" 
                                        TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                             <tr><td colspan="2">
                                 <asp:RequiredFieldValidator ID="valPassUser" runat="server" ControlToValidate="txtPass" ErrorMessage="Contraseña User Requerida" ValidationGroup="ValidarCliente" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                 </td></tr>
                        </table>
                    </td>
                    <td>
                     <table class="auto-style5">
                            <tr>
                                <td class="auto-style1">
                                   <asp:Label ID="Label6" runat="server" Text="Contraseña : "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPassAdmin" runat="server" BackColor="#FFCC00" 
                                        TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                             <tr><td colspan="2">
                                 <asp:RequiredFieldValidator ID="valPassAdm" runat="server" ControlToValidate="txtPassAdmin" ErrorMessage="Contraseña Admin Requerida" ValidationGroup="ValidarAdmin" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                 </td></tr>
                        </table>
                        </td>
                    </tr>
                    <tr><td colspan="2" align="center">
                        <asp:Button ID="btnValidarTodo" runat="server" Text="Validar Todo" Width="289px" OnClick="btnValidarTodo_Click" PostBackUrl="~/PaginaGeneral.aspx" ValidationGroup="ValidarCliente" />
                    </td>
                  </tr>
                    <tr><td align="center" bgcolor="#CCFFCC" class="auto-style13">
                        <asp:Button ID="Button1" runat="server" Text="Validar Cliente" 
                            ValidationGroup="ValidarCliente" PostBackUrl="~/PaginaCliente.aspx" />
                        </td>
                    <td align="center" bgcolor="#CCFFCC">
                        <asp:Button ID="Button2" runat="server" Text="Validar Admin" 
                            ValidationGroup="ValidarAdmin" PostBackUrl="~/PaginaAdministrador.aspx" />
                        </td>
                    </tr>
                </table>
            </div>
    </form>
</body>
</html>
