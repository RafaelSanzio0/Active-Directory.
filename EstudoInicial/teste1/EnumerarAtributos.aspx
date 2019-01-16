<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnumerarAtributos.aspx.cs" Inherits="teste1.EnumerarAtributos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Atributo</h2>
            <asp:TextBox ID="txt_att" runat="server"></asp:TextBox>
            <h2>Caminho</h2>
            <asp:TextBox ID="txt_ca" runat="server"></asp:TextBox>
            <asp:Button ID="btn" runat="server" Text="enviar" OnClick="btn_Click" />
        </div>
        <div id="resultado" runat="server">

        </div>
    </form>
</body>
</html>
