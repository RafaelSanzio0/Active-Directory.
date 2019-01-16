using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace teste1
{
    public partial class remover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            string usuarioDN = txt_usuario.Text;
            string grupoDN = txt_grupo.Text;
            RemoveUserFromGroup(usuarioDN, grupoDN); //chama o metodo passando os valores digitados pelo usuario
            
        }

        public void RemoveUserFromGroup(string usuarioDN, string grupoDN) 
        {
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://192.168.92.200/CN="+grupoDN+",OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local", "contoso\\administrator", "Br@sil01");
                dirEntry.Properties["member"].Remove(usuarioDN);
                dirEntry.CommitChanges();
                dirEntry.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //doSomething with E.Message.ToString();

            }
        }

       
    }
}