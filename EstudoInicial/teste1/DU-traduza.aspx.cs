using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class traduza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string friendlyDomainName = txt_DmAmigavel.Text;
            FriendlyDomainToLdapDomain(friendlyDomainName);
        }

        public static string FriendlyDomainToLdapDomain(string friendlyDomainName)
        {
            string ldapPath = null;

            try
            {
                DirectoryContext objContext = new DirectoryContext(
                DirectoryContextType.Domain, friendlyDomainName+"contoso \\administrator","Br@sil01");
                Domain objDomain = Domain.GetDomain(objContext);
                ldapPath = objDomain.Name;
                
            }
            catch (DirectoryServicesCOMException e)
            {
                ldapPath = e.Message.ToString();
            }
            
            return ldapPath;
        }
        
    }
}


