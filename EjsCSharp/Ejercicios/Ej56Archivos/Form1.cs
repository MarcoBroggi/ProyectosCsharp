using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaArchivosTexto;

namespace Ej56Archivos
{
    public partial class Form1 : Form
    {

        OpenFileDialog abrirArchivo;
        SaveFileDialog guardarArchivo;
        string ruta;
        string contenido;
        public Form1()
        {
            InitializeComponent();
            abrirArchivo = new OpenFileDialog();
            guardarArchivo = new SaveFileDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (abrirArchivo.ShowDialog()== DialogResult.OK)
            {
                this.ruta = abrirArchivo.FileName;
                this.contenido = ArchivoTexto.Cargar(ruta);
                textBoxArchivo.Text = this.contenido;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(guardarArchivo.ShowDialog()==DialogResult.OK)
            {
                this.ruta = guardarArchivo.FileName;
                this.contenido = textBoxArchivo.Text;
                ArchivoTexto.Guardar(ruta, contenido);

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.contenido = textBoxArchivo.Text;
            ArchivoTexto.Guardar(ruta, contenido);
        }
    }
}
