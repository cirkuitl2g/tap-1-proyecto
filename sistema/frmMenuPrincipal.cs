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
    public partial class frmMenuPrincipal : Form
    {
        
        frmLogin objFrmLogin = null;       
        public frmMenuPrincipal(frmLogin objFrmLoginParametro)
        {
            InitializeComponent();
            objFrmLogin = objFrmLoginParametro;
        }
        frmUsuario objFrmUsuario = null;
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (objFrmUsuario == null || objFrmUsuario.IsDisposed)
            {
                objFrmUsuario = new frmUsuario();
                objFrmUsuario.Show();
            }
            else objFrmUsuario.Focus();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            objFrmLogin.Visible = true;
        }
        frmCategoria objFrmCategoria = null;
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (objFrmCategoria == null || objFrmCategoria.IsDisposed)
            {
                objFrmCategoria = new frmCategoria();
                objFrmCategoria.Show();
            }
            else
                objFrmCategoria.Focus();
        }
        frmProducto objFrmProducto = null;
        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (objFrmProducto == null || objFrmProducto.IsDisposed)
            {
                objFrmProducto = new frmProducto();
                objFrmProducto.Show();
            }
            else {
                objFrmProducto.Focus();
            }

        }
    }
}
