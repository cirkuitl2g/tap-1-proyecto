using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class clsCategoria
    {

        public int Id { get; set; }        
        public String Nombre { get; set; }
        public int Level { get; set; }     //public int Index { get; set; }      
        
        private const String ND = "categoria.dat";
        private const String NC = "categoria.con";
        private const String NT = "categoria.bin";
        private const String DIR = @"C:\Proyecto\Categoria";
        private string ndc = DIR + "\\" + ND;
        private string ncc = DIR + "\\" + NC;
        private string ntc = DIR + "\\" + NT;

        //devuelve el nombre del archivo de datos completo
        public String NDC {
            get { return ndc; }
            
        }
        //devuelve el nombre del archivo de contador completo
        public String NCC
        {
            get { return ncc; }
        }
        public String NTC {
            get { return ntc; }
        }

        public clsCategoria(){

            Contador.CrearArchivo(NCC,DIR);

            if (!Directory.Exists(DIR)) 
            {

                Directory.CreateDirectory(DIR);
            }
            if(!File.Exists(NDC))
            {

                FileStream fs = new FileStream(NDC, FileMode.Create);
                fs.Close();
            }
        }
        public void Agregar() 
        {           
           
            FileStream fs = null;
            BinaryWriter bw = null;
            try
            {
                fs = new FileStream(NDC, FileMode.Append);
                bw = new BinaryWriter(fs, Encoding.UTF8);

                bw.Write(Id);
                bw.Write(Nombre);
               // bw.Write(Index);
                bw.Write(Level);                 
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            MessageBox.Show("datos guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            Contador.Incrementar(NCC);

            bw.Close();
            fs.Close();
            
        }
        public List<clsCategoria> GetCategorias() 
        {
            List<clsCategoria> objListCategoria = new List<clsCategoria>();
            try
            {
                FileStream fs = new FileStream(NDC, FileMode.Open);
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

                while (br.PeekChar() != -1)
                {
                    clsCategoria objCategoriaTemp = new clsCategoria();

                    objCategoriaTemp.Id= br.ReadInt32();
                    objCategoriaTemp.Nombre = br.ReadString();
                    objCategoriaTemp.Level = br.ReadInt32();                 

                    

                    objListCategoria.Add(objCategoriaTemp);
                }                

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return objListCategoria;        
        }


        
        

        

    }
}
