using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.AdminBD;
using System.Data;
using System.Data.SqlClient;
namespace Datos.Admin
{
    public  class AdminProductos
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();


        public DataTable Mostrar()
        {

            string Mostrar= "MostrarProductos";
            SqlCommand cmd = new SqlCommand(Mostrar, BaseDatos.ConectarDB());
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            

            BaseDatos.ConectarDB().Close();
            return tabla;

        }


        public void NuevoProducto(string nombre, string desc, string marca, double precio, int stock)
        {
            string Insertar = "InsetarProductos";
            SqlCommand cmd = new SqlCommand(Insertar, BaseDatos.ConectarDB());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@descrip", desc);
            cmd.Parameters.AddWithValue("@Marca", marca);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            BaseDatos.ConectarDB().Close();

        }

        public void EditarProducto(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            string Editar = "EditarProductos";
            SqlCommand cmd = new SqlCommand(Editar, BaseDatos.ConectarDB());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@descrip", desc);
            cmd.Parameters.AddWithValue("@Marca", marca);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            BaseDatos.ConectarDB().Close();
        }





        public void Eliminar(int id)
        {
            string Eliminar = "EliminarProducto";
            SqlCommand cmd = new SqlCommand(Eliminar, BaseDatos.ConectarDB());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idpro", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            BaseDatos.ConectarDB().Close();


        }










    }
}
