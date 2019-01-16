<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RenomearObj.aspx.cs" Inherits="teste1.RenomearObj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Pagina responsavel para renomear o nome de algum objeto</h3><br />

            <h5>Caminho do Objeto</h5>
            <asp:TextBox ID="txt_obj" runat="server"></asp:TextBox><br />
            <h5>Novo nome</h5>
            <asp:TextBox ID="txt_newObj" runat="server"></asp:TextBox><br /><br />


            <asp:Button ID="botao" runat="server" Text="enviar" OnClick="botao_Click" />
        </div>
    </form>
</body>
</html>
