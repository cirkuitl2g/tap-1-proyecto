using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary;
namespace sistema
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        clsProducto objProducto;
        clsCategoria objCategoria;
        
        private void frmProducto_Load(object sender, EventArgs e)
        {
            objCategoria = new clsCategoria();
            objProducto = new clsProducto();

            tvCategoria.Nodes.Clear();
            LoadTree(tvCategoria, objCategoria.NTC);
            if (tvCategoria.GetNodeCount(true) != 0)
            {
                tvCategoria.Nodes[0].Expand();
            }
            
        }
        private void tvCategoria_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblNombre.Text = tvCategoria.SelectedNode.Text;
            lblProfundidad.Text = tvCategoria.SelectedNode.Level.ToString();
            lblId.Text = tvCategoria.SelectedNode.Name;

            // tbEditar.Text = tvCategoria.SelectedNode.Text;
            //lblIdNodoEditar.Text = tvCategoria.SelectedNode.Name;
        }
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

        private void btnMas_Click(object sender, EventArgs e)
        {
            tvCategoria.ExpandAll();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            tvCategoria.CollapseAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

           
    }
}
