using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace ClassLibrary
{
    public class clsUsuario
    {
        public int ID { get; set; }

        public String Usuario { get; set; }
        public String Contraseña { get; set; }

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FNac { get; set; }
        public String Direccion { get; set; }        
        
        private const string dir = @"C:\Proyecto\usuario";
        private string ndc = dir+"\\"+"usuario.dat";
        private string ncc = dir + "\\" + "usuario.con";
        
        public string NCC() 
        {            
            return this.ndc;
        }

        

        public clsUsuario() 
        {
            Contador.CrearArchivo(ncc,dir );

            if (!Directory.Exists(dir))
            {

                Directory.CreateDirectory(dir);
            }
            if (!File.Exists(ndc))
            {

                FileStream fs = new FileStream(ndc, FileMode.Create);
                fs.Close();
                fs = new FileStream(ndc, FileMode.Append);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(0);
                bw.Write("admin");
                bw.Write("admin");
                bw.Write("admin");
                bw.Write("admin");
                bw.Write(DateTime.Now.ToShortDateString());
                bw.Write("admin");
                bw.Close();
                fs.Close();
                Contador.Incrementar(ncc);
            }
        }
        public void Agregar()
        {

            FileStream fs = null;
            BinaryWriter bw = null;
            try
            {
                fs = new FileStream(ndc, FileMode.Append);
                bw = new BinaryWriter(fs, Encoding.UTF8);

                bw.Write(ID);
                bw.Write(Usuario);
                bw.Write(Contraseña);
                bw.Write(Nombre);
                bw.Write(Apellido);
                bw.Write(FNac.ToShortDateString());
                bw.Write(Direccion);               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("datos guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Contador.Incrementar(ncc);

            bw.Close();
            fs.Close();

        }
        public List<clsUsuario> GetUsuario()
        {
            Console.WriteLine("["+DateTime.Now.ToShortTimeString()+"] Entrando Metodo clsUsuario.GetUsuario() Lin 85");
            List<clsUsuario> objListUsuario = new List<clsUsuario>();
            try
            {
                FileStream fs = new FileStream(ndc, FileMode.Open);
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

                while (br.PeekChar() != -1)
                {
                    clsUsuario objUsuarioTemp = new clsUsuario();                    

                    objUsuarioTemp.ID = br.ReadInt32();

                    objUsuarioTemp.Usuario = br.ReadString();
                    objUsuarioTemp.Contraseña = br.ReadString();
                    objUsuarioTemp.Nombre = br.ReadString();
                    objUsuarioTemp.Apellido = br.ReadString();
                    objUsuarioTemp.FNac = DateTime.Parse(br.ReadString());
                    objUsuarioTemp.Direccion = br.ReadString();

                    objListUsuario.Add(objUsuarioTemp);
                }

                br.Close();
                fs.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine("Error: ( "+ex.Message+" ) en clsUsuario.cs");
            }
         
            return objListUsuario;
            
        }
        public void EliminarUsuario(int ID) 
        {
            Console.WriteLine("Entrando Metodo clsUsuario.RemoveUsuarioAt(int ID) Lin 119");
            List<clsUsuario> objListUsuario = new List<clsUsuario>();
            try
            {
                foreach (clsUsuario objUsuario in GetUsuario())
                {

                    if (objUsuario.ID != ID)
                    {
                        objListUsuario.Add(objUsuario);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            MessageBox.Show("Usuario Removido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.WriteLine("Usuario Removido con exito");
            Contador.Reducir(ncc);            
            AplicarCambios(objListUsuario);
        }
        private void AplicarCambios(List<clsUsuario> a) 
        {
            Console.WriteLine("Entrando en Metodo clsUsuario.AplicarCambios(List<clsUsuario> a) Lin 145");
            FileStream fs = null;
            BinaryWriter bw = null;
            Console.WriteLine("Sobre escribiendo archivo: " + ndc + " . Lin 153");
            fs = new FileStream(ndc, FileMode.Create);
            foreach(clsUsuario objUsuario in a)
            {                
                try
                {
                    fs.Close();
                    Console.WriteLine("Abriendo archivo: " + ndc + " para agregar datos... Lin 157");
                    fs = new FileStream(ndc, FileMode.Append);
                    bw = new BinaryWriter(fs, Encoding.UTF8);

                    bw.Write(objUsuario.ID);
                    bw.Write(objUsuario.Usuario);
                    bw.Write(objUsuario.Contraseña);
                    bw.Write(objUsuario.Nombre);
                    bw.Write(objUsuario.Apellido);
                    bw.Write(objUsuario.FNac.ToShortDateString());
                    bw.Write(objUsuario.Direccion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error : " + ex.Message + " . ");
                }
                bw.Close();
                fs.Close();             
            }            
        }
        public void Editar(clsUsuario usuario) 
        {
            Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Entrando Metodo clsUsuario.Editar(clsUsuario usuario) Lin 177");
            List<clsUsuario> objListUsuarioReturn = new List<clsUsuario>();
            List<clsUsuario> objListUsuario = GetUsuario();
            int ID = usuario.ID;

            try
            {       
                foreach(clsUsuario objUsuario in objListUsuario)
                {
                    if (objUsuario.ID != ID)
                    {
                        objListUsuarioReturn.Add(objUsuario);
                    }
                    else 
                    {
                        objListUsuarioReturn.Add(usuario);
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Error:"+ ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Usuario Editado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AplicarCambios(objListUsuarioReturn);
            Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Saliendo de Metodo clsUsuario.Editar(clsUsuario usuario) Lin 207");
        }
        public clsUsuario GetUsuarioById(int ID) 
        {
            Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Entrando Metodo clsUsuario.GetUsuarioById(int ID) Lin 208");
            clsUsuario objUsuario = null;
            try
            {                
                foreach (clsUsuario item in GetUsuario())
                {
                    if(item.ID == ID)
                    {
                        objUsuario = item;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Error:" + ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Saliento de Metodo clsUsuario.GetUsuarioById(int ID) Lin 228");
            return objUsuario;            
        }        
    }    
}
