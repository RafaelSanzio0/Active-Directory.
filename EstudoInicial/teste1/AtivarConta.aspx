<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtivarConta.aspx.cs" Inherits="teste1.AtivarConta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Ativar conta</h2>

            <h4>Dn do usuario</h4>
            <asp:TextBox ID="txt_user" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn" runat="server" Text="enviar" OnClick="btn_Click" />
        </div>
        <div id="resultado" runat="server"></div>
    </form>
</body>
</html>
