using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
    public partial class frmProductoAdministrar : Form
    {
        public frmProductoAdministrar()
        {
            InitializeComponent();
        }

        private void frmProductoAgregar_Load(object sender, EventArgs e)
        {

        }

        private void tvCategoria_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((e.Node.Level == 0 && e.Node.Name == "0") || e.Node.Level == 2)
            {
                btnGuardar.Enabled = true;
            }
            else
                btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
