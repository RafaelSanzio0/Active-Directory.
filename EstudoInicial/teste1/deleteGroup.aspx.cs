using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using teste1.Class;

namespace teste1
{
    public partial class deleteGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string path = "OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local";

        protected void botao_Click(object sender, EventArgs e)
        {
            string grouPath = txt_caminho_grupo.Text;
            string ouPath = txt_caminho_dominio.Text;
            Delete(ouPath, grouPath);

        }

        public void Delete(string ouPath, string groupPath)
        {
           if (!MyTools.verificaObj("LDAP://192.168.92.200/" + groupPath))
            {
                try
                {
                    //oupath = OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local
                    //groupparth = CN=oi,OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local
                    DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/" + ouPath, "contoso\\administrator", "Br@sil01");
                    DirectoryEntry group = new DirectoryEntry("LDAP://192.168.92.200/"+groupPath, "contoso\\administrator", "Br@sil01");
                    entry.Children.Remove(group);
                    group.CommitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
            else
            {
                Console.WriteLine(path + " doesn't exist");
            }
        }
    }
}

       
    
