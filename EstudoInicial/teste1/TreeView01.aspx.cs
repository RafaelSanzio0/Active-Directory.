using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class TreeView01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //PostBack = É quando a página tem que ir até o servidor para processar alguma informação e depois retorna a própria página.
            {
               
            }
        }


        public List<string> Popular_Treeview(string path)
        {
               
            DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/" + path, "contoso\\administrator", "Br@sil01");
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = ("(objectClass=organizationalUnit)");
            mySearcher.SizeLimit = int.MaxValue;
            mySearcher.PageSize = int.MaxValue;
            mySearcher.SearchScope = SearchScope.OneLevel;

            foreach (SearchResult resEnt in mySearcher.FindAll())
            {
                string OUName = resEnt.GetDirectoryEntry().Name;
                Console.WriteLine(OUName);
                foreach (string property in resEnt.Properties.PropertyNames)
                {
                    Console.WriteLine("\t{0}", property);
                    foreach (var innerProp in resEnt.Properties[property])
                        Console.WriteLine("\t\t{0}", innerProp);
                }
            }

            mySearcher.Dispose();
            entry.Dispose();
            
        }




        protected void T_SelectedNodeChanged(object sender, EventArgs e)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "x", "alert('ok');",true); //responsavel para executar
                                                                                         //um script em JS

        }
    }
       
    
}