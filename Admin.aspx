<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h1 style="text-align: center">INGRESO O MODIFICACION DE CLIENTES</h1>
            
        </div>
        <h2 style="text-align: center">Nombre:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Telefono:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            Pagina Web:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">Correo Electronico:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            Pais:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            Direccion:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">Mod Nombre:<asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="140px">
            </asp:DropDownList>
        </h2>
        <h2 class="auto-style1">
            <asp:Button ID="Button1" runat="server" Text="Modificar Cliente " OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Agregar Cliente" OnClick="Button2_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">SOLICITUD DE ORDENES DE DESARROLLO</h1>
        <h2 style="text-align: center">Cliente:<asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="140px">
            </asp:DropDownList>
&nbsp;Nombre Proyecto:<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </h2>
    <h2 style="text-align: center">
        <asp:Button ID="Button3" runat="server" Text="Ingresar Orden" OnClick="Button3_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">CONFIRMACION DE ORDENES</h1>
        <h2 style="text-align: center">Nombre Proyecto:<asp:DropDownList ID="DropDownList3" runat="server" Height="30px" Width="140px">
            </asp:DropDownList>
&nbsp; Ubicacion:<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
&nbsp; Tipo Proyecto:<asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        </h2>
        <h2 style="text-align: center">URL_Github:<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;URL Trello:<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
&nbsp;Fecha solicitud:<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">Fecha Inicio:<asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
&nbsp;Fecha Fin:<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
&nbsp;Estado:<asp:DropDownList ID="DropDownList5" runat="server">
            </asp:DropDownList>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button4" runat="server" Text="Confirmar Orden" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Denegar Orden" OnClick="Button5_Click" />
        </h2>
        <h1 style="text-align: center">
            Empleado:<asp:DropDownList ID="DropDownList7" runat="server">
            </asp:DropDownList>
        &nbsp;Proyecto:<asp:DropDownList ID="DropDownList8" runat="server">
            </asp:DropDownList>
        &nbsp;Equipo:<asp:DropDownList ID="DropDownList9" runat="server">
            </asp:DropDownList>
        </h1>
        <h2 style="text-align: center">
            <asp:Button ID="Button13" runat="server" Text="Asignar a Proyecto" OnClick="Button13_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">
            INGRESO Y MODIFICACION DE EQUIPOS TRABAJO</h1>
        <h2 style="text-align: center">
            Mod Equipo:<asp:DropDownList ID="DropDownList6" runat="server">
            </asp:DropDownList>
        &nbsp;Nombre Equipo:<asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button10" runat="server" Text="Ingresar Equipo" OnClick="Button10_Click" />
            <asp:Button ID="Button11" runat="server" Text="Modificar Equipo" OnClick="Button11_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">
            INGRESO Y MODIFICACION DE EMPLEADOS</h1>
        <h2 style="text-align: center">
            Primer Nombre:<asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
&nbsp;Segundo Nombre:<asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">
            Primer Apellido: <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
&nbsp;Segundo Apellido: <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">
            Direccion:<asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
&nbsp;Fecha Nacimiento:<asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">
            Fecha Contratacion:<asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
&nbsp;Salario:<asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
&nbsp;</h2>
        <h2 style="text-align: center">
            Equipo:<asp:DropDownList ID="DropDownList10" runat="server">
            </asp:DropDownList>
        &nbsp; Supervisor:<asp:DropDownList ID="DropDownList11" runat="server">
            </asp:DropDownList>
        &nbsp;Mod Empleado:<asp:DropDownList ID="DropDownList12" runat="server">
            </asp:DropDownList>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button14" runat="server" Text="Ingresar Empleado" OnClick="Button14_Click" />
            <asp:Button ID="Button15" runat="server" Text="Modificar Empleado" OnClick="Button15_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">
            ESTADO PROYECTOS</h1>
        <h2 style="text-align: center">
            Proyecto:<asp:DropDownList ID="DropDownList13" runat="server">
            </asp:DropDownList>
        &nbsp;Estado:<asp:DropDownList ID="DropDownList14" runat="server">
            </asp:DropDownList>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button17" runat="server" Text="Cambiar Estado" OnClick="Button17_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">
            INGRESO,ASIGNACION Y MODIFICACION DE HERRAMIENTAS</h1>
        <h2 style="text-align: center">
            Nombre Herramienta:<asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
&nbsp;Tipo de Herramienta:<asp:DropDownList ID="DropDownList15" runat="server">
            </asp:DropDownList>
        </h2>
        <h2 style="text-align: center">
            Mod Herramienta:<asp:DropDownList ID="DropDownList16" runat="server">
            </asp:DropDownList>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button18" runat="server" Text="Ingresar Herramienta" OnClick="Button18_Click" />
            <asp:Button ID="Button19" runat="server" Text="Modificar Herramienta" OnClick="Button19_Click" />
        </h2>
        <h1 style="text-align: center">
            Empleado:<asp:DropDownList ID="DropDownList17" runat="server">
            </asp:DropDownList>
        &nbsp;Herramienta:<asp:DropDownList ID="DropDownList18" runat="server">
            </asp:DropDownList>
        &nbsp;Proyecto:<asp:DropDownList ID="DropDownList19" runat="server">
            </asp:DropDownList>
        </h1>
        <h2 style="text-align: center">
            <asp:Button ID="Button20" runat="server" Text="Asignar Herrammienta" OnClick="Button20_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">
            INGRESO Y ASIGNACION DE ACTIVIDADES</h1>
        <h2 style="text-align: center">
            Nombre de Actividad:<asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
&nbsp;Tiempo Estimado:<asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button23" runat="server" Text="Ingresar Actividad" OnClick="Button23_Click" />
        </h2>
        <h1 style="text-align: center">
            Actividad:<asp:DropDownList ID="DropDownList20" runat="server">
            </asp:DropDownList>
        &nbsp;Empleado:<asp:DropDownList ID="DropDownList21" runat="server">
            </asp:DropDownList>
        &nbsp;Proyecto:<asp:DropDownList ID="DropDownList22" runat="server">
            </asp:DropDownList>
        </h1>
        <h2 style="text-align: center">
            <asp:Button ID="Button24" runat="server" Text="Asignar Actividad" OnClick="Button24_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">LISTADO DE CLIENTES</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button6" runat="server" Text="Mostrar Listado" OnClick="Button6_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">CLIENTES SIN ORDENES DE DESARROLLO</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button7" runat="server" Text="Mostrar Listado" OnClick="Button7_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">CLIENTES CON ORDENES DE DESARROLLO</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button8" runat="server" Text="Mostrar Listado" OnClick="Button8_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">CLIENTES CON PROYECTOS X ESTADO</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button9" runat="server" Text="Mostrar Listado" OnClick="Button9_Click" />
        </h2>
    <hr />
        <h1 style="text-align: center">EQUIPOS DE TRABAJO</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView5" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button12" runat="server" Text="Mostrar Listado" OnClick="Button12_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">EMPLEADOS X EQUIPO</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView6" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button16" runat="server" Text="Mostrar Listado" OnClick="Button16_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">HERRAMIENTAS</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView7" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button21" runat="server" Text="Mostrar Listado" OnClick="Button21_Click" />
        </h2>
        <hr />
        <h1 style="text-align: center">HERRAMIENTAS X EQUIPO Y PROYECTO</h1>
        <h2 style="text-align: center; font-size: medium;">
            <asp:GridView ID="GridView8" runat="server">
            </asp:GridView>
        </h2>
        <h2 style="text-align: center">
            <asp:Button ID="Button22" runat="server" Text="Mostrar Listado" OnClick="Button22_Click" />
        </h2>
        <hr />
        <h1>REPORTES:</h1>
        <h2>Actividades x Proyecto</h2>
        <p style="text-align: center">
            <asp:GridView ID="GridView9" runat="server">
            </asp:GridView>
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button25" runat="server" Text="Mostrar Listado" OnClick="Button25_Click" />
        </p>
        <h2>Actividades x Empleado y Proyecto</h2>
        <p>
            <asp:GridView ID="GridView10" runat="server" style="text-align: center">
            </asp:GridView>
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button26" runat="server" Text="Mostrar Listado" OnClick="Button26_Click" />
        </p>
    </form>
    </body>
</html>
