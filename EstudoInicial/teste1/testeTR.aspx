<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testeTR.aspx.cs" Inherits="teste1.testeTR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server">
                <Nodes>
                    <asp:TreeNode Text="Frutas" Value="FRUTAS">
                        <asp:TreeNode Text="maça" Value="maça">
                            <asp:TreeNode Text="laranja" Value="laranja">
                                <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="carro" Value="carro"></asp:TreeNode>
                    <asp:TreeNode Text="casa" Value="casa">
                        <asp:TreeNode Text="azul" Value="azul"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
