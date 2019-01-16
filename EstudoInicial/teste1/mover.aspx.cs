using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class mover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Move(string objectLocation, string newLocation)
        {
            //For brevity, removed existence checks
            //
            //old = CN=G-foi,OU=GROUPS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local
            //new = OU=GROUPS,OU=LAB2_2008,OU=CONTOSO,DC=contoso,DC=local

            DirectoryEntry eLocation = new DirectoryEntry("LDAP://192.168.92.200/" + objectLocation,"contoso\\administrator","Br@sil01");
            DirectoryEntry nLocation = new DirectoryEntry("LDAP://192.168.92.200/" + newLocation, "contoso\\administrator", "Br@sil01");
            string newName = eLocation.Name;
            eLocation.MoveTo(nLocation, newName);
            nLocation.Close();
            eLocation.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string objOldLocal = txt_oldlocal.Text;
            string objNewLocal = txt_newlocal.Text;
            Move(objOldLocal,objNewLocal);

        }
    }
}