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
using sistema;

namespace sistema
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        clsUsuario objUsuario;
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Programa Iniciado !!");
            if(objUsuario == null)
                objUsuario = new clsUsuario();
            
            
            //dgvEmpleado.Columns[6].Visible = false;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.DataSource = objUsuario.GetUsuario();
           
        }
        
        frmUsuarioAgregar objUsuarioAgregar;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (objUsuarioAgregar == null || objUsuarioAgregar.IsDisposed)
            {
                objUsuarioAgregar = new frmUsuarioAgregar();
                objUsuarioAgregar.Show();
            }
            else
                objUsuarioAgregar.Focus();
        }
        public void FillDgvUsuario() 
        {
            dgvUsuario.DataSource = objUsuario.GetUsuario();
        }

       
        
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgvUsuario.SelectedRows[0].Cells[0].Value.ToString());            
            objUsuario.EliminarUsuario(ID);            
            FillDgvUsuario();                     
        }

        frmUsuarioEditar frmUsuarioEditar;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (frmUsuarioEditar == null || frmUsuarioEditar.IsDisposed)
            {
                frmUsuarioEditar = new frmUsuarioEditar(objUsuario.GetUsuarioById(int.Parse(dgvUsuario.SelectedRows[0].Cells[0].Value.ToString())));
                frmUsuarioEditar.Show();
            }
            else
                frmUsuarioEditar.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FillDgvUsuario();
        }

    }
}
