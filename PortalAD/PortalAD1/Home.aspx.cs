using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalAD1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string GetADUserInfo(string filtro, string valor, string retorno)

        {
            string resultado = string.Empty; //resultado ad

            try
            {

                //This is a generic LDAP call, it would do a DNS lookup to find a DC in your AD site, scales better

                DirectoryEntry enTry = new DirectoryEntry("LDAP://192.168.92.200/DC=contoso,DC=local", "contoso\\administrator", "Br@sil01"); //como a maquina nao esta no dominio é preciso passar o user e senha

                DirectorySearcher mySearcher = new DirectorySearcher(enTry);

                mySearcher.Filter = "(" + filtro + "=" + valor + ")";//var com uma função filter
                mySearcher.PropertiesToLoad.Add(retorno);

                SearchResult resEnt = mySearcher.FindOne(); //busca apenas 1 usuario

                resultado = resEnt.Properties[retorno][0].ToString();

            }

            catch (Exception f)
            {

                divnome.InnerText = "erro:" + f.Message;

            }

            return resultado;

        }
        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            string filter = ddlfilter.SelectedValue; // valor do campo consulta que o usuario pegou
            string valor = txt_samaccountname.Text; //valor = dados que o usuario digita
            string retorno = ddlretorno.SelectedValue; // retorna o valor do campo retorno 
            string displayname = GetADUserInfo(filter, valor, retorno);
            divnome.InnerText = displayname;

        }

    }
}