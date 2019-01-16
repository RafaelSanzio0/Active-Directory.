using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botao_Click(object sender, EventArgs e)
        {
            string objectDN = txt_obj.Text;
            string show = ConvertDNtoGUID(objectDN);

        }
        //CN=Janiele Sanzio,OU=USERS,OU=LAB2008,OU=CONTOSO,DC=contoso,DC=local
        public string ConvertDNtoGUID(string objectDN)
        {

            DirectoryEntry directoryObject = new DirectoryEntry(objectDN,"contoso\\administrator","Br@sil01");
            return directoryObject.Guid.ToString();
        }
    }
}
