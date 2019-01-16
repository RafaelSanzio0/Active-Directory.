<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnumerarPro.aspx.cs" Inherits="teste1.EnumerarPro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Enumerar as propriedades de um objeto: os que têm valores</h3>
            <h5>caminho</h5>
            <asp:TextBox ID="txt_path" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn" runat="server" Text="submeter" OnClick="btn_Click" />
            
        </div>
        
    </form>
    <div id="resultado" runat="server"></div>

</body>
</html>
