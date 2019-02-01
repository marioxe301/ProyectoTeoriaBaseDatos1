<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-align: center" class="auto-style1"><em style="background-color: #FFFFCC">LOGIN</em></h1>
    <h2 class="auto-style2" style="text-align: center">USERNAME:</h2>
    <h2 style="text-align: center">
        <asp:TextBox ID="TB1" runat="server" Height="27px" Width="156px"></asp:TextBox>
        </h2>
    <h2 class="auto-style2" style="text-align: center">PASSWORD:</h2>
    <h2 style="text-align: center">
        <asp:TextBox ID="TB2" runat="server" Height="27px" Width="156px" TextMode="Password"></asp:TextBox>
        </h2>
        <h2 style="text-align: center; background-color: #FFFFCC">
            <asp:Button ID="B1" runat="server" OnClick="Button1_Click" Text="Entrar" />
        </h2>
    </form>
</body>
</html>
