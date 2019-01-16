using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class Compartilhar : System.Web.UI.Page
    {
        protected  void Page_Load(object sender, EventArgs e)
        {

        }
        public static void Main(String[] args)
        {
            Compartilhar e = new Compartilhar();
            e.CreateShareEntry("OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local", "GroupShared", @"\\192.168.92.200\GroupShared", "Shared a OU of group");
            Console.WriteLine(e);
            Console.ReadLine();
        }


        protected void btn_Click(object sender, EventArgs e)
        {
            string IdapPath = txt_dom.Text;
            string shareNam = txt_nome.Text;
            string shareUncPath = txt_cam.Text;
            string shareDescription = txt_des.Text;
            CreateShareEntry(IdapPath, shareNam, shareUncPath, shareDescription);
        }

        public void CreateShareEntry(string ldapPath,string shareName, string shareUncPath, string shareDescription)
        {
            string oGUID = string.Empty;
            string connectionPrefix = "LDAP://192.168.92.200/" + ldapPath;
            DirectoryEntry directoryObject = new DirectoryEntry(connectionPrefix,"contoso\\administrator", "Br@sil01");
            DirectoryEntry networkShare = directoryObject.Children.Add("CN=" +shareName, "volume");
            networkShare.Properties["uNCName"].Value = shareUncPath;
            networkShare.Properties["Description"].Value = shareDescription;
            networkShare.CommitChanges();

            directoryObject.Close();
            networkShare.Close();
        }
    }
}