<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="criarGrupo.aspx.cs" Inherits="teste1.criarGrupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Criação de Grupos de segurança</h3>
            <h5>Nome do grupo</h5>
            <asp:TextBox ID="txt_grupo" runat="server"></asp:TextBox><br /><br />

            <h5>Caminho do grupo</h5>
            <asp:TextBox ID="txt_caminho" runat="server" ></asp:TextBox><br /><br />

            <asp:Button ID="botao" text="finalizar" runat="server" OnClick="buttoncreate_Click" />
        </div>

        <div id="resultado" runat="server">


        </div>

    </form>
</body>
</html>
