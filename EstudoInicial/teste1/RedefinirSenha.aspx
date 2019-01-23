<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedefinirSenha.aspx.cs" Inherits="teste1.RedefinirSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Redefir senha do usuário</h3>
            <h4>usuario DN</h4>
            <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>

            <h4>Nova Senha</h4>
            <asp:TextBox ID="txt_senha" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="botao"  runat="server" Text="alterar" OnClick="botao_Click" />
            </div>
        <div id="result" runat="server"></div>
        </form>
</html>
