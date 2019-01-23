<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Criandousuario.aspx.cs" Inherits="teste1.Criandousuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h4>Dominio a qual o usuario vai ser criado</h4>
            <asp:TextBox ID="txt_dominio" runat="server"></asp:TextBox>

            <h4>Nome</h4>
            <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>

            <h4>Senha</h4>
            <asp:TextBox ID="txt_senha" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" text="adicionar" OnClick="buttonRemoveUser_Click" />

        </div>
        <div id="result" runat="server">

        </div>
    </form>
</body>
</html>
