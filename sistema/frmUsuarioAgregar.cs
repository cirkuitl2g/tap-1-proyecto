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
    public partial class frmUsuarioAgregar : Form
    {
        public frmUsuarioAgregar()
        {
            InitializeComponent();
        }
        clsUsuario objUsuario;
        private void frmUsuarioAgregar_Load(object sender, EventArgs e)
        {
            objUsuario = new clsUsuario();
            
        }
        
        public void btnAgregar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (clsUsuario item in objUsuario.GetUsuario())
            {
                if (item.Usuario == tbUsuario.Text)
                {
                    cont += 1;
                    MessageBox.Show("Usuario no valido","Usuario Repetido",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    break;
                }
            }

            if (cont==0)
            {
                objUsuario.ID = Contador.UltimoID(objUsuario.NCC());
                objUsuario.Usuario = tbUsuario.Text;
                objUsuario.Contraseña = tbContraseña.Text;
                objUsuario.Nombre = tbNombre.Text;
                objUsuario.Apellido = tbApellido.Text;
                objUsuario.FNac = dtpFNac.Value;
                objUsuario.Direccion = tbDireccion.Text;

                objUsuario.Agregar();

                Reset();
            }
           
        }
        void Reset()
        {
            tbUsuario.Clear();
            tbContraseña.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            dtpFNac.ResetText();
            tbUsuario.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
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
