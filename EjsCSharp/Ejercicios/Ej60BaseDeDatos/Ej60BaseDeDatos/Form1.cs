using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej60BaseDeDatos
{
    public partial class Form1 : Form
    {

        Producto producto = new Producto();
        DB baseDeDatos = new DB();
        List<Producto> productos = new List<Producto>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            this.productos=baseDeDatos.Cargar();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            baseDeDatos.CrearProducto(this.producto);

            MessageBox.Show("Producto creado!");
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            baseDeDatos.ModificarProductoNombre(this.producto, 100, "Cambio");

            MessageBox.Show("Producto modificado!");
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            baseDeDatos.BorrarProducto(100);
        }
    }
}
