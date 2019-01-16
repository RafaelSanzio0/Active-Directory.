using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace teste1
{
    public partial class EnumerarOU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //codigo executavelss
        public static void Main(String[] args)
        {
            EnumerarOU enumerarCatalogos = new EnumerarOU();
            Console.WriteLine(enumerarCatalogos.EnumerateDomains());
            System.Diagnostics.Debug.WriteLine(enumerarCatalogos.EnumerateDomains());
 
            Console.ReadLine();
        }
        //---------------------

        public List <string> EnumerateDomains()
        {
            List<string> alGCs = new List<string>();
            Forest currentForest = Forest.GetCurrentForest();
            foreach (GlobalCatalog gc in currentForest.GlobalCatalogs)
            {
                alGCs.Add(gc.Name);
            }
            Console.WriteLine(alGCs);
            return alGCs;
        }

        public List <string> EnumerateOU(string OuDn)
        {
            List <string> alObjects = new List<string>();
            try
            {
                DirectoryEntry directoryObject = new DirectoryEntry("LDAP://192.168.92.200/" + OuDn, "contoso\\administrator", "Br@sil01");
                foreach (DirectoryEntry child in directoryObject.Children)
                {
                    string childPath = child.Path.ToString();
                    alObjects.Add(childPath.Remove(0, 7));
                    //remove the LDAP prefix from the path

                    child.Close();
                    child.Dispose();
                }
                directoryObject.Close();
                directoryObject.Dispose();
            }
            catch (DirectoryServicesCOMException e)
            {
                Console.WriteLine("An Error Occurred: " + e.Message.ToString());
            }
             Console.WriteLine(alObjects);
            return alObjects;
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string path = txt_ou.Text;
            List <string> a = EnumerateOU(path);
            resultado.InnerHtml = string.Join("<br>", a);
        }
    }
}