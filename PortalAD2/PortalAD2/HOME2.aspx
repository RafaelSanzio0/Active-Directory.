<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home2.aspx.cs" Inherits="PortalAD.Home2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h3>atributo de consulta</h3>
            
        </div><br />

        <asp:DropDownList id="ddlfilter" Runat="Server">
        <asp:ListItem Text="Displayname" Value="Displayname"/>
        <asp:ListItem Text="mail" Value="mail"/>
        <asp:ListItem Text="samaccountname" Value="samaccountname" />
        </asp:DropDownList>

    <h3> atributos de retorno </h3>

        
          <asp:CheckBoxList id="checkboxlist1" 
               CellPadding="5"
               CellSpacing="5"
               RepeatColumns="2"
               RepeatDirection="Vertical"
               RepeatLayout="Flow"
               TextAlign="Right"
               runat="server">
 
             <asp:ListItem Value="displayname" >name</asp:ListItem> 
             <asp:ListItem Value="mail">mail</asp:ListItem>
             <asp:ListItem Value="samaccountname" >samaccountname</asp:ListItem>
             <asp:ListItem  Value="pwdlastset">pwdlastset</asp:ListItem>
        
 
          </asp:CheckBoxList>
 
          <br /><br />

          <asp:label id="Message" runat="server" AssociatedControlID="checkboxlist1"/> 

         <asp:TextBox ID="txt_samaccountname" runat="server" ></asp:TextBox><br /><br />
         <asp:Button ID="btnconsultar" runat="server" text="consultar" OnClick="btn_consultar_Click" />

          <asp:Repeater ID="rptData" runat="server" OnItemDataBound="rptData_ItemDataBound">

        <HeaderTemplate>

            <table cellpadding="0" cellspacing="1" width="1000">

                <tr style="background-color:#d6f6f9">

                    <td>samaccountname</td>
                    <td>name</td>
                    <td>mail</td>
                    <td>pwdlastname</td>


                </tr>

        </HeaderTemplate>

        <ItemTemplate>

            <tr style="background-color:#f8f8f8">

                <td id="tdsamaccountname" runat="server"></td>
                <td id="tdname" runat="server"></td>
                <td id="tdmail" runat="server"></td>
                <td id="tdpwdlastset" runat="server"></td>

            </tr>

        </ItemTemplate>

        <FooterTemplate>

                <tr style="background-color:#d6f6f9">

                    <td style="height:3px" colspan="8"></td>

                </tr>

            </table>

        </FooterTemplate>

    </asp:Repeater>



  <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" NavigateUrl="teste.aspx"></asp:HyperLink>
 
      
    </form>


</body>
</html>
