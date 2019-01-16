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
    public partial class criarGrupo : System.Web.UI.Page
    {
        private string path = "OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local"; //caminho onde o grupo vai ser criado


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttoncreate_Click(object sender, EventArgs e)
        {
            string nomeGrupo = txt_grupo.Text;
            string ouPath = txt_caminho.Text;

            Create(ouPath, nomeGrupo);
        }

        public void Create(string ouPath, string nomeGrupo)
        {
            if (!MyTools.verificaObj("LDAP://192.168.92.200/" + nomeGrupo))
            {
                try
                {                                           //path=OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local
                    DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/" + ouPath, "contoso\\administrator", "Br@sil01");
                    DirectoryEntry group = entry.Children.Add("CN=" + nomeGrupo, "group");
                    group.Properties["sAmAccountName"].Value = nomeGrupo;
                    group.CommitChanges();
                    resultado.InnerText = "Objeto criado";
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
        

               
       