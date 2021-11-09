using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentation
{
    public partial class frmProductos : Form
    {

        ModeloProducto producto = new ModeloProducto();
        private string idProducto = null;
        private bool Editar = false;
        public frmProductos()
        {
            InitializeComponent();
        }







        #region Controles Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void barNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


      

        
           
        


        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
          
            
             
             
            
        }

    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void MostrarProductos()
        {
            ModeloProducto mostrar = new ModeloProducto();
            gridProductos.DataSource = mostrar.MostrarProducto();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            
            MostrarProductos();
        }

       

        private void btnModificarP_Click(object sender, EventArgs e)
        {
            if (gridProductos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombreP.Text = gridProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcionP.Text = gridProductos.CurrentRow.Cells["Marca"].Value.ToString();
                txtMarcaP.Text = gridProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecioP.Text = gridProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStockP.Text = gridProductos.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = gridProductos.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }


        private void limpiarForm()
        {
            txtNombreP.Clear();
            txtMarcaP.Text = "";
            txtPrecioP.Clear();
            txtStockP.Clear();
            txtNombreP.Clear();
        }


        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            
            if (gridProductos.SelectedRows.Count > 0)
            {
                idProducto = gridProductos.CurrentRow.Cells["Id"].Value.ToString();
                producto.EliminarProducto(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            
        }

        private void btnGuardaP_Click(object sender, EventArgs e)
        {






         
        }


        void EditarP()
        {
            if (Editar == true)
            {
                try
                {
                    producto.EditarProducto(txtNombreP.Text, txtDescripcionP.Text, txtMarcaP.Text, txtPrecioP.Text, txtStockP.Text, idProducto);
                    MessageBox.Show("se edito correctamente");
                
                    MostrarProductos();
                    limpiarForm();

                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }

        }

        void InsertarP()
        {
            
                try
                {

                    producto.InsertarProducto(txtNombreP.Text, txtDescripcionP.Text, txtMarcaP.Text, txtPrecioP.Text, txtStockP.Text);
                    MessageBox.Show("se inserto correctamente");
                     
                     MostrarProductos();
                     limpiarForm();

            }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            
        }



        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                InsertarP();

            }
            else
            {
                EditarP();
            }

            //EDITAR

        }

        private void gridProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value.GetType()!= typeof(System.DBNull))
            {
                if (this.gridProductos.Columns[e.ColumnIndex].Name == "Stock")
                {
                    if (e.Value != null)
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {
                          
                            if (Convert.ToInt32(e.Value) <= 20)
                            {

                                e.CellStyle.ForeColor = Color.Red;
                            }
                       
                            if (Convert.ToInt32(e.Value) <= 10)
                            {

                                e.CellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }

            }

        }

    }
}
    

