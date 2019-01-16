
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


namespace PortalAD
{
    public partial class Home2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }


        public Tabela GetADUserInfo(string filtro, string txt_valor, string[] retorno)

        {

            Tabela tabela = new Tabela();


            try
            {

               // This is a generic LDAP call, it would do a DNS lookup to find a DC in your AD site, scales better

                DirectoryEntry enTry = new DirectoryEntry("LDAP://192.168.92.200/DC=contoso,DC=local", "contoso\\administrator", "Br@sil01"); //como a maquina nao esta no dominio é preciso passar o user e senha

                DirectorySearcher mySearcher = new DirectorySearcher(enTry);

                mySearcher.Filter = "(" + filtro + "=" + txt_valor + ")";//var com uma função filter
                mySearcher.PropertiesToLoad.AddRange(retorno);

                SearchResultCollection resEnt = mySearcher.FindAll(); //busca apenas 1 usuario



                
                foreach (SearchResult searchresult in resEnt)
                {
                    Linha linha = new Linha();


                    for(int i = 0; i < retorno.Length; i++)
                    {
                        Coluna colunaobj = new Coluna();
                        colunaobj.Nome = retorno[i];
                        

                        if (searchresult.Properties.Contains(retorno[i]))
                        {
                            colunaobj.Valor = searchresult.Properties[retorno[i]][0].ToString();

                        }

                        linha.Add(colunaobj);


                    }

                    tabela.Add(linha);
                }

            }

            catch (Exception f)
            {

              //  divnome.InnerText = "erro:" + f.Message;

            }

            return tabela;

        }



        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            
            string filter = ddlfilter.SelectedValue; // valor do campo consulta que o usuario pegou
            string valor = txt_samaccountname.Text; //valor = dados que o usuario digita

            List<string> selecionados = new List<string>(); //cria uma lista de selecionados

            for(int i = 0; i <= checkboxlist1.Items.Count-1; i++) 
            {
                if (checkboxlist1.Items[i].Selected) // verifica se o item foi selecionado, se sim add
                {
                    selecionados.Add(checkboxlist1.Items[i].Value);

                }

            }


            //string retorno = ddlretorno.SelectedValue; // retorna o valor do campo retorno 
            Tabela tabela = GetADUserInfo(filter, valor,selecionados.ToArray());
            rptData.DataSource = tabela;
            rptData.DataBind();



        }

        protected void rptData_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType==ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Linha linha = e.Item.DataItem as Linha;
                HtmlTableCell tdsamaccountname = e.Item.FindControl("tdsamaccountname") as HtmlTableCell;
                HtmlTableCell tdname = e.Item.FindControl("tdname") as HtmlTableCell;
                HtmlTableCell tdmail = e.Item.FindControl("tdmail") as HtmlTableCell;
                HtmlTableCell tdpwdlastset = e.Item.FindControl("tdpwdlastset") as HtmlTableCell;
                
                foreach(Coluna coluna in linha)
                {
                    if (coluna.Nome.ToLower() == "samaccountname")
                        tdsamaccountname.InnerText = coluna.Valor;
                    else if (coluna.Nome.ToLower() == "mail")
                        tdmail.InnerText = coluna.Valor;
                    else if (coluna.Nome.ToLower() == "pwdlastset")
                        tdpwdlastset.InnerText = coluna.Valor;
                    else if (coluna.Nome.ToLower() == "displayname")
                        tdname.InnerText = coluna.Valor;
                }
                 
            }

        }
    }

    public class Tabela : List<Linha>
    {

    }

    public class Linha : List<Coluna>
    {

    }

    public class Coluna
    {
        public string Nome;
        public string Valor;
    }
}

