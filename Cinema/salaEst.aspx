<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="salaEst.aspx.cs" Inherits="Cinema.salaEst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Compra un altro biglietto" OnClick="Button2_Click"/>
            <asp:Button ID="Button1" runat="server" Text="Torna all'ingresso" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
