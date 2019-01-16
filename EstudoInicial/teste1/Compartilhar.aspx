<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compartilhar.aspx.cs" Inherits="teste1.Compartilhar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Publicar compartilhamentos de rede no Active Directory</h2>

            <h4>Dominio</h4>
            <asp:TextBox ID="txt_dom" runat="server"></asp:TextBox>

            <h4>Nome do objeto</h4>
            <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>

            <h4>caminho do Objeto</h4>
            <asp:TextBox ID="txt_cam" runat="server"></asp:TextBox>

            <h4>Descrição</h4>
            <asp:TextBox ID="txt_des" runat="server"></asp:TextBox>

            <asp:Button ID="btn" runat="server" Text="enviar" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
