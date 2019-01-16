using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class DesbloquearConta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            Unlock(user);

        }
        public void Unlock(string userDn)
        {
            try
            {
                DirectoryEntry user = new DirectoryEntry("LDAP://192.168.92.200/" + userDn, "contoso\\administrator", "Br@sil01");
                user.Properties["LockOutTime"].Value = 0; //unlock account

                user.CommitChanges(); //may not be needed but adding it anyways

                user.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //DoSomethingWith --> E.Message.ToString();

            }
        }
    }
}