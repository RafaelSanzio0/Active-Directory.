using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class EnumerarPro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string path = txt_path.Text;
             List<string> show =  GetUsedAttributes(path);
            resultado.InnerHtml = string.Join("<br>", show);
            


        }
        public static List<string> GetUsedAttributes(string objectDn)
        {
            DirectoryEntry objRootDSE = new DirectoryEntry("LDAP://192.168.92.200/" + objectDn, "contoso\\administrator", "Br@sil01");
            List<string> props = new List<string>();

            foreach (string strAttrName in objRootDSE.Properties.PropertyNames)
            {
                props.Add(strAttrName);
            }
            return props;
        }
    }
}