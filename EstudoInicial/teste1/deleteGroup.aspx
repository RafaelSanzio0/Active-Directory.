<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteGroup.aspx.cs" Inherits="teste1.deleteGroup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Deletar Grupos do AD</h3>
            
            <h5>Caminho onde esta o grupo</h5>
            <asp:TextBox ID="txt_caminho_dominio" runat="server" ></asp:TextBox><br /><br />

            <h5>caminho com o grupo incluso</h5>
            <asp:TextBox ID="txt_caminho_grupo" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="botao" text="finalizar" runat="server" OnClick="botao_Click" />


        </div>
    </form>
</body>
</html>
