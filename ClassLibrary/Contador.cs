using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace ClassLibrary
{
    public static class Contador
    {

        public static void CrearArchivo(String Nombre_Completo, String Direccion)
        {
            

            try
            {
                if (!Directory.Exists(Direccion))
                {
                    Directory.CreateDirectory(Direccion);
                }
                if (!File.Exists(Nombre_Completo))
                {
                    FileStream fs = new FileStream(Nombre_Completo, FileMode.Create);
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                    bw.Write(0);//ID
                    bw.Write(0);//CANTIDAD
                    bw.Close();
                    fs.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static int UltimoID(String Nombre_Completo)
        {
            int ID;
            FileStream fs = new FileStream(Nombre_Completo, FileMode.Open);
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

            ID = br.ReadInt32();
            br.Read();

            br.Close();
            fs.Close();
            return ID;
        }
        public static int CantidadCargada(String Nombre_Completo)
        {
            int Cantidad;
            FileStream fs = new FileStream(Nombre_Completo, FileMode.Open);
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

            br.Read();
            Cantidad = br.ReadInt32();

            br.Close();
            fs.Close();
            return Cantidad;
        }
        public static void Incrementar(String Nombre_Completo)
        {

            int ID = UltimoID(Nombre_Completo) + 1;
            int Cantidad = CantidadCargada(Nombre_Completo) + 1;



            FileStream fs = new FileStream(Nombre_Completo, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

            bw.Write(ID);
            bw.Write(Cantidad);

            bw.Close();
            fs.Close();

        }
        public static void Reducir(String Nombre_Completo)
        {
            
            int ID = UltimoID(Nombre_Completo);
            int Cantidad = CantidadCargada(Nombre_Completo) - 1;
            FileStream fs = new FileStream(Nombre_Completo, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

            bw.Write(ID);
            bw.Write(Cantidad);

            bw.Close();
            fs.Close();

        }
    }
}
