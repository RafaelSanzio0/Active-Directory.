<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autentica.aspx.cs" Inherits="teste1.Autentica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Verificar status de conta</h2>
            <h3>Entre com seu usuário</h3>
            <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>

            <asp:Button ID="botao" runat="server" Text="confirmar" OnClick="botao_Click" />
        </div>

        <div id="resultado" runat="server"></div>
        
        <asp:TreeView ID="TreeView1" runat="server">
        </asp:TreeView>
        
    </form>
</body>
</html>
