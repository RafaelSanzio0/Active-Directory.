<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObterPing.aspx.cs" Inherits="teste1.ObterPing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>input with address you computer</h2>
            <asp:TextBox ID="txt_ping" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn" runat="server" Text="enviar" OnClick="btn_Click" />

        </div>
        <div id="result" runat="server"></div>

    </form>
</body>
</html>
