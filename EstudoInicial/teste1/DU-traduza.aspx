<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DU-traduza.aspx.cs" Inherits="teste1.traduza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <h5>Traduza o nome de domínio amigável para um domínio totalmente qualificado</h5><br />

            <asp:TextBox ID="txt_DmAmigavel" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" text="traduzir" Onclick="Button1_Click" />

        </div>
        <div id="resultado" runat="server">


        </div>

    </form>
</body>
</html>
