using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace sistema
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        
      

        clsCategoria objCat;
        bool salvar = false;
        
        
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            
            objCat = new clsCategoria();
            treeView1.Nodes.Clear();
            LoadTree(treeView1, objCat.NTC);
            if (treeView1.GetNodeCount(true) != 0) 
            {
                treeView1.Nodes[0].Expand();
            }     

            
        }
        //treeview methods//
        public static void SaveTree(TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, tree.Nodes.Cast<TreeNode>().ToList());
            }
        }
        public static void LoadTree(TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                tree.Nodes.AddRange(nodeList);
            }
        }       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveTree(treeView1, objCat.NTC);
            salvar = false;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            LoadTree(treeView1, objCat.NTC);
          
          
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level != 0)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
                salvar = true;
            
            }
           
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if(treeView1.GetNodeCount(true)==0)
            {
                TreeNode tn2 = new TreeNode();
                tn2.Text = "Varios";
                tn2.Name = "0";
                treeView1.Nodes.Add(tn2);
                treeView1.Select();
            }
            TreeNode tn = new TreeNode();
            tn.Text = tbTexto.Text;
            tn.Name = Contador.UltimoID(objCat.NCC).ToString();
            Contador.Incrementar(objCat.NCC);
            treeView1.SelectedNode.Nodes.Add(tn);
            salvar = true;
           

            
        }
        private void button3_Click(object sender, EventArgs e)
        {

            //List<Categoria>objListCat = objCat.GetCategorias();
            // int cant = objListCat.Count;


        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = tbEditar.Text;
        }

        private String GetParent(TreeNode a) 
        {
            String padre =String.Empty;
            if (a.Parent != null)
            {
                padre = padre + GetParent(a.Parent);
            }
            else {
                return padre;
                }
            return padre = padre + a.Text+" ";
        }
      
        private void treeView1_AfterSelect_(object sender, TreeViewEventArgs e)
        {
            String padres = String.Empty;

            lblNombre.Text = treeView1.SelectedNode.Text;
            lblProfundidad.Text = treeView1.SelectedNode.Level.ToString();
            lblId.Text = treeView1.SelectedNode.Name;

            tbEditar.Text = treeView1.SelectedNode.Text;
            lblIdNodoEditar.Text = treeView1.SelectedNode.Name;

            lblPadre.Text = GetParent(treeView1.SelectedNode);
           
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {           
            
            

            if (e.Node.Level  == 2)
            {
                btnAñadir.Enabled = false;
            }
            else {
                btnAñadir.Enabled = true;
            }
        }

               
    }
}
