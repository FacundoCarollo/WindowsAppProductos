using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos.Admin;
namespace Dominio
{
    public class ModeloProducto
    {

        private AdminProductos productos = new AdminProductos();


        public DataTable MostrarProducto()
        {
            DataTable Tabla = new DataTable();
            Tabla = productos.Mostrar();
            return Tabla;

        }

        public void InsertarProducto(string nombre, string desc, string marca, string precio, string stock)
        {
            productos.NuevoProducto(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }


        public void EliminarProducto(string id)
        {
            productos.Eliminar(Convert.ToInt32(id));
        }
        public void EditarProducto(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            productos.EditarProducto(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id) );
        }
    }

}
