<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="teste1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bem vindo ao portal de controle AD</h1>

            <h4>Para remover um usuario de um grupo</h4>
            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" NavigateUrl="~/remover.aspx">Clique aqui</asp:HyperLink>

            <h4>Para adicionar um usuario a um grupo</h4>
            <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" NavigateUrl="~/add.aspx"  >Clique aqui</asp:HyperLink>

            <h4>Para Criar um grupo</h4>
            <asp:HyperLink ID="HyperLink3" runat="server" Target="_blank" NavigateUrl="~/criarGrupo.aspx">Clique aqui</asp:HyperLink>

            <h4>Para deletar um grupo</h4>
            <asp:HyperLink ID="HyperLink4" runat="server" Target="_blank" NavigateUrl="~/deleteGroup.aspx">Clique aqui</asp:HyperLink>

            <h4>Para criar um usuario</h4>
            <asp:HyperLink ID="HyperLink5" runat="server" Target="_blank" NavigateUrl="~/Criandousuario.aspx">Clique aqui</asp:HyperLink>

             <h4>Para alterar o nome de algum objeto(grupo,usuario,maquina)</h4>
             <asp:HyperLink ID="HyperLink6" runat="server" Target="_blank" NavigateUrl="~/RenomearObj.aspx">Clique aqui</asp:HyperLink>

             <h4>Resetar Senha</h4>
             <asp:HyperLink ID="HyperLink7" runat="server" Target="_blank" NavigateUrl="~/RedefinirSenha.aspx">Clique aqui</asp:HyperLink>

             <h4>Mover Objeto</h4>
             <asp:HyperLink ID="HyperLink8" runat="server" Target="_blank" NavigateUrl="~/mover.aspx">Clique aqui</asp:HyperLink>

            <h4>Enumerar Obj de uma OU</h4>
            <asp:HyperLink ID="HyperLink9" runat="server" Target="_blank" NavigateUrl="~/EnumerarOU.aspx">Clique aqui</asp:HyperLink>

             <h4>Enumerar as propriedades de um objeto: os que têm valores</h4>
            <asp:HyperLink ID="HyperLink10" runat="server" Target="_blank" NavigateUrl="~/EnumerarPro.aspx">Clique aqui</asp:HyperLink>

            <h4>Ativar Conta Usuario</h4>
            <asp:HyperLink ID="HyperLink11" runat="server" Target="_blank" NavigateUrl="~/AtivarConta.aspx">Clique aqui</asp:HyperLink>

            
            <h4>Desativar Conta Usuario</h4>
            <asp:HyperLink ID="HyperLink12" runat="server" Target="_blank" NavigateUrl="~/DesativarConta.aspx">Clique aqui</asp:HyperLink>

            <h4>Desbloquear Conta Usuario</h4>
            <asp:HyperLink ID="HyperLink13" runat="server" Target="_blank" NavigateUrl="~/DesbloquearConta.aspx">Clique aqui</asp:HyperLink>

            <h4>Publicar Compartilhamentos de Rede</h4>
            <asp:HyperLink ID="HyperLink14" runat="server" Target="_blank" NavigateUrl="~/Compartilhar.aspx">Clique aqui</asp:HyperLink>

             <h4>Enumerar Atributos</h4>
            <asp:HyperLink ID="HyperLink15" runat="server" Target="_blank" NavigateUrl="~/EnumerarAtributos.aspx">Clique aqui</asp:HyperLink>

             <h4>Enumerar Conf</h4>
            <asp:HyperLink ID="HyperLink16" runat="server" Target="_blank" NavigateUrl="~/EnumerarConf.aspx">Clique aqui</asp:HyperLink>

             <h4>Autentica</h4>
            <asp:HyperLink ID="HyperLink17" runat="server" Target="_blank" NavigateUrl="~/Autentica.aspx">Clique aqui</asp:HyperLink>

             <h4>Autentica usuario</h4>
            <asp:HyperLink ID="HyperLink18" runat="server" Target="_blank" NavigateUrl="~/AutenticarUser.aspx">Clique aqui</asp:HyperLink>

        </div>
    </form>
</body>
</html>
