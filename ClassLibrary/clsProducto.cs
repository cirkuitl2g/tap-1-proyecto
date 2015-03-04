using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ClassLibrary
{
    public class clsProducto
    {
        
        
        public int ID { get; set; }
        public int IDCategoria { get; set; }

        public String TituloProducto { get; set; }
        public String Marca { get; set; }
        public String Descripcion { get; set; }

        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int Garantia { get; set; }

        public Double Costo { get; set; }
        public Double IVA { get; set; }
        public Double Ganancia { get; set; }

        private const String ND = "producto.dat";
        private const String NC = "producto.con";
        private const String DIR = @"C:\Proyecto\Productos";
        private string ndc = DIR + "\\" + ND;
        private string ncc = DIR + "\\" + NC;

        //devuelve el nombre del archivo de datos completo
        public String NDC
        {
            get { return ndc; }

        }
        //devuelve el nombre del archivo de contador completo
        public String NCC
        {
            get { return ncc; }
        }
        public clsProducto() 
        {
            Contador.CrearArchivo(NCC, DIR);

            if (!Directory.Exists(DIR))
            {

                Directory.CreateDirectory(DIR);
            }
            if (!File.Exists(NDC))
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

                bw.Write(ID);
                bw.Write(IDCategoria);
                bw.Write(TituloProducto);
                bw.Write(Marca);
                bw.Write(Descripcion);
                bw.Write(Stock);
                bw.Write(StockMin);
                bw.Write(Garantia);
                bw.Write(Costo);
                bw.Write(IVA);
                bw.Write(Ganancia);                           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("datos guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Contador.Incrementar(NCC);

            bw.Close();
            fs.Close();

        }
        public List<clsProducto> GetProductos() 
        {

            List<clsProducto> objListProducto = new List<clsProducto>();
            try
            {
                FileStream fs = new FileStream(NDC, FileMode.Open);
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

                while (br.PeekChar() != -1)
                {
                    clsProducto objProductoTemp = new clsProducto();

                    objProductoTemp.ID = br.ReadInt32();
                    objProductoTemp.IDCategoria= br.ReadInt32();

                    objProductoTemp.TituloProducto = br.ReadString();
                    objProductoTemp.Marca = br.ReadString();
                    objProductoTemp.Descripcion = br.ReadString();

                    objProductoTemp.Stock = br.ReadInt32();
                    objProductoTemp.StockMin = br.ReadInt32();
                    objProductoTemp.Garantia = br.ReadInt32();

                    objProductoTemp.Costo = br.ReadDouble();
                    objProductoTemp.IVA = br.ReadDouble();
                    objProductoTemp.Ganancia = br.ReadDouble();


                    objListProducto.Add(objProductoTemp);
                }

                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            return objListProducto;
        }

        public void EliminarProducto(int ID)        { // X  X    X
           
            List<clsProducto> objListProductos = new List<clsProducto>();
            try
            {
                foreach (clsProducto objProductos in GetProductos())
                {

                    if (objProductos.ID != ID)
                    {
                        objListProductos.Add(objProductos);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show("Usuario Removido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Contador.Reducir(NCC);
            AplicarCambios(objListProductos);
        }
        private void AplicarCambios(List<clsProducto> a)
        {
           
            FileStream fs = null;
            BinaryWriter bw = null;
          
            fs = new FileStream(NDC, FileMode.Create);
            fs.Close();
            foreach (clsProducto objUsuario in a)
            {
                try
                {                    
                    
                    fs = new FileStream(NDC, FileMode.Append);
                    bw = new BinaryWriter(fs, Encoding.UTF8);

                    bw.Write(ID);
                    bw.Write(IDCategoria);

                    bw.Write(TituloProducto);
                    bw.Write(Marca);
                    bw.Write(Descripcion);

                    bw.Write(Stock);
                    bw.Write(StockMin);
                    bw.Write(Garantia);

                    bw.Write(Costo);
                    bw.Write(IVA);
                    bw.Write(Ganancia);                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                bw.Close();
                fs.Close();
            }
        }
        public void Editar(clsProducto producto)
        {
            Console.WriteLine("[" + DateTime.Now.ToShortTimeString() + "] Entrando Metodo clsUsuario.Editar(clsUsuario usuario) Lin 177");
            List<clsProducto> objListProductoReturn = new List<clsProducto>();
            // List<clsProducto> objListUsuario = GetProductos();
            int ID = producto.ID;
            try
            {
                foreach (clsProducto objProducto in GetProductos())
                {
                    if (objProducto.ID != ID)
                    {
                        objListProductoReturn.Add(objProducto);
                    }
                    else
                    {
                        objListProductoReturn.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Producto Editado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AplicarCambios(objListProductoReturn);
        }
        public clsProducto GetProductoById(int ID)
        {
            
            clsProducto objProducto = null;
            try
            {
                foreach (clsProducto item in GetProductos())
                {
                    if (item.ID == ID)
                    {
                        objProducto = item;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            return objProducto;
        }        
    }
}
