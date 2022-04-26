using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EventosEj68
{
    public partial class Form1 : Form
    {
        private Persona persona = new Persona();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.persona.Apellido==string.Empty)
            {
                this.persona.Nombre = textBox1.Text;
                this.persona.Apellido = textBox2.Text;
                button1.Text = "Actualizar";
                persona.EventoString += NotificarCambio;
                    
            }
            else
            {
                persona.MostrarEvento(textBox1.Text, textBox2.Text);

                this.persona.Nombre = textBox1.Text;

                this.persona.Apellido = textBox2.Text;

                MessageBox.Show(persona.Mostrar());

            }

        }

    }
}
