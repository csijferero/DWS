<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DEMO_2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página 1</title>
</head>
<body>
    <form runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif; font-size: medium">
        txt-1&nbsp;
        <asp:TextBox ID="txb1" runat="server" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
        txt-2&nbsp;
        <asp:TextBox ID="txb2" runat="server" Width="170px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnResponse" runat="server" Width="244px" 
            Text="Botón Para usar Response.Redirect" onclick="btnResponse_Click" />
            
       
          &nbsp;para ir a <b>PAGINA 2</b><br />
        <br />
       
        <!-- En este botón usamos su propiedad "PostBackUrl" para indicar a qué página tiene que ir.
             El carácter '~' indica que es una página del proyecto. Se puede omitir-->

        <asp:Button ID="btnCross" runat="server"  Width="241px" 
            Text="Botón para usar Cross Page Posting"  PostBackUrl="~/Pagina3.aspx" 
            onclick="btnCross_Click" />
         &nbsp;para ir a <b>PAGINA 3</b><br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Pagina2.aspx">HyperLink a la Página 2</asp:HyperLink>
        
        <br />
        
        <br />
        <asp:Button ID="btn3" runat="server"  Width="138px" 
            Text="Ir a la Página 3"  PostBackUrl="~/Pagina3.aspx"/>
        &nbsp;este botón no tiene controlador de evento<br />
        
    </div>
    </form>
</body>
</html>
