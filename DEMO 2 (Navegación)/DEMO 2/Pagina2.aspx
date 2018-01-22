<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="DEMO_2.Pagina2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página 2</title>
</head>
<body>
  <h1>Página 2</h1>
  <form id="form1" runat="server" style="font-family: Arial; font-size:medium; background-color: #FFFF99">
    
    <div >

        Resultado obtenido de la página anterior: &nbsp;
        <asp:Label ID="lbResultado" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
    </div>
  </form>
</body>
</html>
