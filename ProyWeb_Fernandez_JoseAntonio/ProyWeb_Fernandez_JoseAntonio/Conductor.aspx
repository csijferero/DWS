<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conductor.aspx.cs" Inherits="ProyWeb_Fernandez_JoseAntonio.Conductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 971px;
        }
        .auto-style2 {
            width: 969px;
        }
        .auto-style3 {
            width: 780px;
            height: 189px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:auto;margin-right:auto;" class="auto-style1">

            <asp:ImageButton ID="tsbCliente" runat="server" Height="104px" ImageUrl="~/Resources/person_user_customer_man_male_man_boy_people_1687.png" Width="90px" OnClick="tsbCliente_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="tsbConductor" runat="server" Height="104px" ImageUrl="~/Resources/taxi_18540.png" Width="90px" OnClick="tsbConductor_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Resources/taxi-sign-wallpaper-3202-1.jpg" PostBackUrl="~/Login.aspx" Width="469px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="tsbTarifa" runat="server" Height="104px" ImageUrl="~/Resources/construction_project_plan_building_architect_design_develop-73_icon-icons.com_60243.png" Width="90px" OnClick="tsbTarifa_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="tsbCarrera" runat="server" Height="104px" ImageUrl="~/Resources/Ticket_icon-icons.com_54128.png" Width="90px" OnClick="tsbCarrera_Click" />

        &nbsp;

        </div>

        <div style="margin-left:auto;margin-right:auto;" class="auto-style2">


            <asp:ImageButton ID="btnAñadir" runat="server" Height="104px" ImageUrl="~/Resources/new-file_40454.png" Width="90px" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:ImageButton ID="btnUser" runat="server" Height="104px" ImageUrl="~/Resources/Data_settings_theapplication_3364.png" Width="90px" />


        </div>

        <div style="margin-left:auto;margin-right:auto;" class="auto-style3">

            <asp:GridView ID="dgv" runat="server" AutoGenerateColumns="False" Height="96px" Width="780px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowEditing="dgv_RowEditing">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:CommandField ButtonType="Button" EditText="»" ShowEditButton="True">
                    <ControlStyle BackColor="#0066FF" Font-Bold="True" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    <asp:BoundField HeaderText="idConductor" Visible="False" DataField="idConductor" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombreConductor" />
                    <asp:BoundField HeaderText="Apellidos" DataField="apellidosConductor" />
                    <asp:BoundField HeaderText="Dirección" DataField="direccionConductor" />
                    <asp:BoundField DataField="emailConductor" HeaderText="Email" />
                    <asp:BoundField HeaderText="DNI" DataField="dniConductor" />
                    <asp:BoundField DataField="licenciaConductor" HeaderText="Licencia" />
                    <asp:BoundField DataField="matriculaConductor" HeaderText="Mátricula" />
                    <asp:CommandField ButtonType="Button" DeleteText="X" ShowDeleteButton="True">
                    <ControlStyle BackColor="Red" Font-Bold="True" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>

        </div>

    </form>

</body>
</html>
