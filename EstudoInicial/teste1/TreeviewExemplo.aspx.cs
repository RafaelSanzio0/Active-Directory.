using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace teste1
{ 
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Pasta pasta = new Pasta("PastaTeste");
            //Pasta subPasta = new Pasta("Sub1");
            //pasta.SubPastas.Add(subPasta);
            //subPasta = new Pasta("Sub2");
            //pasta.SubPastas.Add(subPasta);
            //subPasta = new Pasta("Sub3");
            //pasta.SubPastas.Add(subPasta);
            //subPasta = new Pasta("Sub4");
            //pasta.SubPastas.Add(subPasta);
            //subPasta = new Pasta("Sub5");
            //Pasta terceiroNivel = new Pasta("Despesas");
            //subPasta.SubPastas.Add(terceiroNivel);
            //terceiroNivel = new Pasta("Timesheet");
            //subPasta.SubPastas.Add(terceiroNivel);
            //pasta.SubPastas.Add(subPasta);

            //if (!IsPostBack)
            //{
            //    TreeNode node = new TreeNode();
            //    node.Text = "root";
            //    node.ImageUrl = "~/images/i.png";
            //    CarregaArvore(pasta, node);
            //    arvore.Nodes.Add(node);
            //}

            if (!IsPostBack)
            {
                TreeNode node = new TreeNode();
                node.Text = "C:\\PastaTeste";
                node.Value = "C:\\PastaTeste";
              //  arvore.Nodes.Add(node);
            }
        }
        
        private void CarregaArvore(Pasta pasta, TreeNode node)
        {
            TreeNode childNote = new TreeNode();
            childNote.Text = pasta.Nome;

            foreach (Pasta item in pasta.SubPastas)
            {
                CarregaArvore(item, childNote);

            }

            node.ChildNodes.Add(childNote);
        }

        public void ExpandArvore(TreeNode node)
        {
            try
            {
                string[] directories = Directory.GetDirectories(node.Value);

                foreach (string directory in directories)
                {
                    TreeNode childNote = new TreeNode();

                    childNote.Text = directory.Split('\\')[directory.Split('\\').Length - 1];
                    childNote.Value = directory;
                    node.ChildNodes.Add(childNote);

                }
           
            }
            catch { }

        }

        protected void arvore_TreeNodeExpanded(object sender, TreeNodeEventArgs e)
        {
        }

        protected void arvore_SelectedNodeChanged(object sender, EventArgs e)
        {
            ExpandArvore((sender as TreeView).SelectedNode);
        }

    }

    public class Pasta
    {

        public Pasta(string nome)
        {
            Nome = nome;
        }
        public string Nome;

        public List<Pasta> SubPastas = new List<Pasta>();

    }

}