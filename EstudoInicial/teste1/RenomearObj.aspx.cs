using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class RenomearObj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botao_Click(object sender, EventArgs e)
        {
            string ObjectDn = txt_obj.Text;
            string newName = txt_newObj.Text;
            Rename(ObjectDn, newName);

        }
        //obj user = CN=JANIELE NASCIMENTO,OU=USERS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local
        public static void Rename(string objectDn, string newName)
        {
            DirectoryEntry child = new DirectoryEntry("LDAP://192.168.92.200/" + objectDn, "contoso\\administrator", "Br@sil01");
            child.Rename("CN=" + newName);
        }
    }
}