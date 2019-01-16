using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class Autentica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botao_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(txt_usuario.Text))
            {
                try
                {
                    DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://192.168.92.200/DC=contoso,DC=local", "contoso\\administrator", "Br@sil01");
                    DirectorySearcher directorySearcher = new DirectorySearcher(directoryEntry);
                    directorySearcher.Filter = "(SAMAccountName=" + txt_usuario.Text + ")";
                    SearchResult searchResult = directorySearcher.FindOne();
                    if ((Int32)searchResult.Properties["userAccountControl"][0] == 512) 
                    {
                        resultado.InnerText = "Conta Ativada!";
                    }
                    if ((Int32)searchResult.Properties["userAccountControl"][0] == 514)
                        resultado.InnerText = "Conta desativada";

                }
                catch (Exception)
                {
                    Console.WriteLine("Exceção tratada");
                    resultado.InnerText = "Conta nao encontrada";
                }

            }

        }
    }
}