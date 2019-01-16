<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PortalAD1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Samccountname</h3>
            <asp:TextBox ID="txt_samaccountname" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnconsultar" runat="server" text="consultar" OnClick="btn_consultar_Click" />
        </div><br />

        <h4>Consulta</h4>
        <asp:DropDownList id="ddlfilter" Runat="Server">
        <asp:ListItem Text="Displayname" Value="Displayname"/>
        <asp:ListItem Text="mail" Value="mail"/>
        <asp:ListItem Text="samaccountname" Value="samaccountname" />
        </asp:DropDownList>

        <h4>Retorno</h4>
        <asp:DropDownList id="ddlretorno" Runat="Server">
        <asp:ListItem Text="Displayname" Value="Displayname"/>
        <asp:ListItem Text="mail" Value="mail"/>
        <asp:ListItem Text="samaccountname" Value="samaccountname" />
        </asp:DropDownList>

         <div id="divnome" runat="server">

            </div>

    </form>
</body>
</html>
