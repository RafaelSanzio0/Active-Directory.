using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste1
{
    public partial class RedefinirSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botao_Click(object sender, EventArgs e)
        {
            string userDn = txt_usuario.Text;
            string password = txt_senha.Text;
            ResetPassword(userDn, password);
            result.InnerText = "Senha alterada com sucesso";

        }
        public void ResetPassword(string userDn, string password)
        {
            DirectoryEntry uEntry = new DirectoryEntry("LDAP://192.168.92.200/"+userDn,"contoso\\administrator","Br@sil01");
            uEntry.Invoke("SetPassword", new object[] { password });
            uEntry.Properties["LockOutTime"].Value = 0; //unlock account
            uEntry.Close();
        }
    }
}