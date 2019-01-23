using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class Criandousuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            string ldapPath = txt_dominio.Text;
            string userName = txt_nome.Text;
            string userPassword = txt_senha.Text;
            CreateUserAccount(ldapPath, userName, userPassword); //chama o metodo passando os valores digitados pelo usuario
            result.InnerText = "Usuario criado com sucesso";

        }
        //iappath = OU=USERS,OU=PREFEITURA,DC=contoso,DC=local

        public string CreateUserAccount(string ldapPath, string userName, string userPassword)
        {
            string oGUID = string.Empty;

            try
            {
                string connectionPrefix = "LDAP://192.168.92.200/" + ldapPath;
                DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix,"contoso\\administrator","Br@sil01");
                DirectoryEntry newUser = dirEntry.Children.Add
                    ("CN=" + userName, "user");
                newUser.Properties["samAccountName"].Value = userName;
                newUser.CommitChanges();
                oGUID = newUser.Guid.ToString();

                newUser.Invoke("SetPassword", new object[] { userPassword });
                newUser.CommitChanges();
                dirEntry.Close();
                newUser.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //DoSomethingwith --> E.Message.ToString();

            }
            return oGUID;
        }
    }
}