<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="remover.aspx.cs" Inherits="teste1.remover" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
   <div>
            <h3>Remover usuario</h3>
             <h5>Nome</h5>
            <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox><br /><br />

            <h5>grupo</h5><br />

            <asp:TextBox ID="txt_grupo" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" text="remover" OnClick="buttonRemoveUser_Click" />



        </div><br />

     <div id="divnome" runat="server">


            </div>
    </form>
</body>
</html>
