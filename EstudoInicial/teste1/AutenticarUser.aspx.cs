using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{/*
    public partial class AutenticarUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Authenticate(string userName,string password)
        {
            bool authentic = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/DC=contoso,DC=local" + userName,password,"contoso\\administrator","Br@sil01");
                object nativeObject = entry.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = txt_nome.Text;
            string password = txt_senha.Text;
           // string domain = txt_dominio.Text;
            Authenticate(userName, password);
            
        }
    }
}
*/
}