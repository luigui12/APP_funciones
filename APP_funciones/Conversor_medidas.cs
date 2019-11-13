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
    public partial class Conversor_medidas : Form
    {
        public Conversor_medidas()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.m.Text = "";
            this.p.Text = "";
            this.pu.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //DECLARACION DEVARIABLES
            double c,l;
            if (this.m.Text.Length==0)
            {
                MessageBox.Show("No existen valores en la caja de texto a convertir...!!");
                this.m.Focus();
                return;
            }
            //CONVERTIR VARIABLES DECLARADAS A LA CAJA DE TEXTO
            c = Double.Parse(this.m.Text);
            l = Double.Parse(this.m.Text);
            //LLAMAR LAS CAJAS DE TEXTO CON EL NOMBRE DE LA FUNCION
            double nu = C_pies(c);
            double x = C_pul(l);
            //LLAMAR LAS VARIABLES RETORNADAS
            this.p.Text = nu.ToString();
            this.pu.Text = x.ToString();
        }
        //CONVERTIR METROS A PIES Y PULGADAS
        private double C_pies(double c)
        {
            double nu = 0;
            nu = c * 3.281;
            return nu;
        }
        private double C_pul(double l)
        {
            double x = 0;
            x = l * 39.370;
            return x;
        }
    }
}
