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
namespace sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsUsuario objUsuario = null;
        private void frmLogin_Load(object sender, EventArgs e)
        {            
            objUsuario = new clsUsuario();
            
        }

        frmMenuPrincipal objFrmMenuPrincipal = null;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if (tbContraseña.Text != String.Empty && tbUsuario.Text != String.Empty)
            {
                foreach (clsUsuario item in objUsuario.GetUsuario())
                {
                    if (item.Usuario == tbUsuario.Text && item.Contraseña == tbContraseña.Text)
                    {
                        cont += 1;
                       // MessageBox.Show("Datos Correctos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        objFrmMenuPrincipal = new frmMenuPrincipal(this);
                        this.Hide();
                        objFrmMenuPrincipal.ShowDialog();
                       
                        break;
                    }
                }
                if(cont==0)
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Focus();
            }
            else {
                tbUsuario.Focus();
            }                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbMostrarContraseña.Checked)
            {
                tbContraseña.UseSystemPasswordChar = false;
            }
            else
                tbContraseña.UseSystemPasswordChar = true;
        }
    }
}
