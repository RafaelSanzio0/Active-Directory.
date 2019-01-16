<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutenticarUser.aspx.cs" Inherits="teste1.AutenticarUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <h2>Autenticar usuario</h2>
            <h4>Dominio</h4>
            <asp:TextBox ID="txt_dominio" runat="server"></asp:TextBox>

            <h4>Nome</h4>
            <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>

            <h4>Senha</h4>
            <asp:TextBox ID="txt_senha" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" text="adicionar" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
