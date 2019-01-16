<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DU-converter.aspx.cs" Inherits="teste1.converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3></h3><br />

            <h5>Caminho do Objeto</h5>
            <asp:TextBox ID="txt_obj" runat="server"></asp:TextBox><br />
           

            <asp:Button ID="botao" runat="server" Text="converter" OnClick="botao_Click" />
        </div>
    </form>
    <div id="resultado" runat="server"></div>
</body>
</html>
