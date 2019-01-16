<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mover.aspx.cs" Inherits="teste1.mover" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h3>Mover Obj</h3>

             <h5>Local Atual</h5>
            <asp:TextBox ID="txt_oldlocal" runat="server"></asp:TextBox><br /><br />

            <h5>Novo Local</h5><br />

            <asp:TextBox ID="txt_newlocal" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" text="adicionar" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
