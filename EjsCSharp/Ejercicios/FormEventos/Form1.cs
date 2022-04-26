using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaEventos;

namespace FormEventos
{
    public partial class Form1 : Form
    {
        public Class1 objeto = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LLeva + xq se manejan colecciones en los eventos.
            objeto.miEvento += objetoMetodo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            objeto.Metodo();
        }

        //Metodo compatible con el delegado del tipo del evento. Este metodo se va a agregar al evento.
        /// <summary>
        /// Metodo que ejecuta el evento. 
        /// </summary>
        /// <param name="mensaje">El mensaje que se le dio desde el metodo de la clase origen que ejecuta el evento</param>
        public void objetoMetodo(string mensaje)
        {
            label1.Text += mensaje;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            objeto.miEvento -= objetoMetodo;

        }
    }
}
