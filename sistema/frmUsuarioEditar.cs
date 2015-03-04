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
    public partial class frmUsuarioEditar : Form
    {
        clsUsuario objUsuarioTemp = null;
        public frmUsuarioEditar(clsUsuario usuario)
        {
            InitializeComponent();
            objUsuarioTemp = usuario;            
        }
        
        private void frmUsuarioEditar_Load(object sender, EventArgs e)
        {
            tbUsuario.Text = objUsuarioTemp.Usuario;
            tbContraseña.Text = objUsuarioTemp.Contraseña;
            tbNombre.Text = objUsuarioTemp.Nombre;
            tbApellido.Text = objUsuarioTemp.Apellido;
            tbDireccion.Text = objUsuarioTemp.Direccion;
            dtpFNac.Value = objUsuarioTemp.FNac;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objUsuarioTemp.Usuario = tbUsuario.Text;
            objUsuarioTemp.Contraseña = tbContraseña.Text;
            objUsuarioTemp.Nombre = tbNombre.Text;
            objUsuarioTemp.Apellido = tbApellido.Text;
            objUsuarioTemp.FNac = dtpFNac.Value;
            objUsuarioTemp.Direccion = tbDireccion.Text;

            objUsuarioTemp.Editar(objUsuarioTemp);
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
