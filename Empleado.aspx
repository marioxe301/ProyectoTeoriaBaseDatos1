<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Empleado.aspx.cs" Inherits="Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Registro de realizacion de Actividades</h1>
            <h2 style="text-align: center">Actividad:<asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="140px">
            </asp:DropDownList>
        &nbsp;Tiempo Trabajado:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;Fecha:<asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="44px">
                </asp:DropDownList>
                /<asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="44px">
                </asp:DropDownList>
                /<asp:DropDownList ID="DropDownList5" runat="server" Height="16px" Width="70px">
                </asp:DropDownList>
&nbsp;</h2>
            <h2 style="text-align: center">Proyecto:<asp:DropDownList ID="DropDownList6" runat="server" Height="30px" Width="140px">
            </asp:DropDownList>
            </h2>
            <h2 style="text-align: center">
                <asp:Button ID="Button1" runat="server" Text="Registrar Actividad" OnClick="Button1_Click" />
            </h2>
            <hr />
            <h1 style="text-align: center">Consultar Actividades por Proyecto</h1>
            <h2 style="text-align: center">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </h2>
        </div>
        <h2 style="text-align: center">
            <asp:Button ID="Button2" runat="server" Text="Consultar Actividades" OnClick="Button2_Click" />
        </h2>
    </form>
</body>
</html>
