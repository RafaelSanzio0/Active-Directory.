using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace teste1
{ 
    public partial class TreeviewExemplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     

            if (!IsPostBack)
            {
                TreeNode node = new TreeNode();
                //node.Text = "C:\\PastaTeste";
                //node.Value = "C:\\PastaTeste";
                node.Text = "CONTOSO";
                node.Value = "DC=CONTOSO,DC=LOCAL";
                arvore.Nodes.Add(node);
            }
        }

        public string[] GetOUs(string path)

        {
            List<string> obj = new List<string>(); //nao precisa de tamanho fixo

            DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/" + path, "contoso\\administrator", "Br@sil01");
      
            foreach (DirectoryEntry child in entry.Children)
            {
                if(child.SchemaClassName == "organizationalUnit")
                {
                    obj.Add(child.Path.Split('/')[3]);
                }
            }

            entry.Dispose();
            return obj.ToArray(); // converter um list para tipo array
        }



        public void ExpandArvore(TreeNode node)
        {
            try
            {
                //string[] directories = Directory.GetDirectories(node.Value);
                string[] directories = GetOUs(node.Value);


                foreach (string directory in directories)
                {
                    TreeNode childNote = new TreeNode();

                    childNote.Text = directory.Split('\\')[directory.Split('\\').Length -1];
                    childNote.Value = directory;
                    node.ChildNodes.Add(childNote);

                }
           
            }
            catch { }

        }

      

        protected void arvore_SelectedNodeChanged(object sender, EventArgs e)
        {
            ExpandArvore((sender as TreeView).SelectedNode); //chamada generica
        }

    }



}