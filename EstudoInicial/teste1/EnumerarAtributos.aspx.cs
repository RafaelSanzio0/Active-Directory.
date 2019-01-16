using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class EnumerarAtributos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string AttributeValuesSingleString (string attributeName, string objectDn)
        {
            string strValue = string.Empty;
            DirectoryEntry ent = new DirectoryEntry("LDAP://192.168.92.200/"+objectDn,"contoso\\administrator","Br@sil01");
            strValue = ent.Properties[attributeName].Value.ToString();
            ent.Close();
            ent.Dispose();
            return strValue;
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string att = txt_att.Text;
            string path = txt_ca.Text;
            string show = AttributeValuesSingleString(att,path);
            resultado.InnerText = show;
        }
    }
}