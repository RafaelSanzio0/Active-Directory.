<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnumerarOU.aspx.cs" Inherits="teste1.EnumerarOU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enumerar objs de uma OU</h2>
            <asp:TextBox ID="txt_ou" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn" runat="server" Text="enviar" OnClick="btn_Click" />
        </div>
    </form>
    <div id="resultado" runat="server"></div>
</body>
</html>
