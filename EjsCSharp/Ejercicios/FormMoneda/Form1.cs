using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace FormMoneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Dolar dolar = new Dolar(double.Parse(textBoxDolar.Text));
                textBox7.Text = textBoxDolar.Text;
                Euro euro = (Euro)dolar;
                textBox8.Text = euro.Cantidad.ToString();
                Peso peso = (Peso)dolar;
                textBox9.Text = peso.Cantidad.ToString();

            }
            catch (ValorInvalidoException exc)
            {
                MessageBox.Show(exc.Message, "Error valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message,"Format Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Euro euro = new Euro(double.Parse(textBoxEuro.Text));
                textBox11.Text = textBoxEuro.Text;
                Dolar dolar = (Dolar)euro;
                textBox10.Text = dolar.Cantidad.ToString();
                Peso peso = (Peso)euro;
                textBox12.Text = peso.Cantidad.ToString();

            }
            catch (ValorInvalidoException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Peso peso = new Peso(double.Parse(textBoxPeso.Text));
                textBox15.Text = textBoxPeso.Text;
                Euro euro = (Euro)peso;
                textBox14.Text = euro.Cantidad.ToString();
                Dolar dolar = (Dolar)peso;
                textBox13.Text = dolar.Cantidad.ToString();

            }
            catch (ValorInvalidoException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indice = 0;
            textBox7.Enabled = !(textBox7.Enabled);
            textBox8.Enabled = !(textBox8.Enabled);
            textBox9.Enabled = !(textBox9.Enabled);
            textBox10.Enabled = !(textBox10.Enabled);
            textBox11.Enabled = !(textBox11.Enabled);
            textBox12.Enabled = !(textBox12.Enabled);
            textBox13.Enabled = !(textBox13.Enabled);
            textBox14.Enabled = !(textBox14.Enabled);
            textBox15.Enabled = !(textBox15.Enabled);

            if (indice == 0)
            {
                Image image = this.imageList1.Images[0];
                this.imageList1.Images[0] = this.imageList1.Images[1];
                this.imageList1.Images[1] = image;
                indice = 1;
            }
            else
            {
                Image image = this.imageList1.Images[1];
                this.imageList1.Images[1] = this.imageList1.Images[0];
                this.imageList1.Images[0] = image;
                indice = 0;
            }
        }
    }
}
