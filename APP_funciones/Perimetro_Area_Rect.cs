using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_funciones
{
    public partial class Perimetro_Area_Rect : Form
    {
        public Perimetro_Area_Rect()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.b.Text = "";
            this.a.Text = "";
            this.peri.Text = "";
            this.area.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double b, a;
            //VALIDAR DATOS EN LA CAJAS DE TEXTO
            if (this.a.Text.Length==0)
            {
                MessageBox.Show("No existen un valor en la caja de texto Altura...!!");
                return;
            }
            if (this.b.Text.Length==0)
            {
                MessageBox.Show("No existe un valor en la caja de texto Base...!!");
            }
            b = Double.Parse(this.b.Text);
            a = Double.Parse(this.a.Text);
            double p = C_perimetro(b, a);
            double s = C_superficie(b, a);
            //ENVIAR VALOR A CAJAS DE TEXTOS
            this.peri.Text = p.ToString();
            this.area.Text = s.ToString();
        }
        private double C_perimetro(double b, double a)
        {
            double p = 0;
            p = (2*a)+(2*b);
            return p;
        }
        private double C_superficie(double b, double a)
        {
            double s = 0;
            s = (b * a);
            return s;
        }
    }
}
