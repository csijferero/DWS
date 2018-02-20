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
            width: 687px;
            height: 133px;
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
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Resources/taxi-sign-wallpaper-3202-1.jpg" Width="482px" />
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

            <asp:GridView ID="dgv" runat="server" AutoGenerateColumns="False" Height="96px" Width="684px">
                <Columns>
                    <asp:BoundField HeaderText="idConductor" Visible="False" DataField="idConductor" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombreConductor" />
                    <asp:BoundField HeaderText="Apellidos" DataField="apellidosConductor" />
                    <asp:BoundField HeaderText="Dirección" DataField="direccionConductor" />
                    <asp:BoundField DataField="emailConductor" HeaderText="Email" />
                    <asp:BoundField HeaderText="DNI" DataField="dniConductor" />
                    <asp:BoundField DataField="licenciaConductor" HeaderText="Licencia" />
                    <asp:BoundField DataField="matriculaConductor" HeaderText="Mátricula" />
                </Columns>
            </asp:GridView>

        </div>

    </form>

</body>
</html>
