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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void Temperatura_Load(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            double c;
            if (this.c1.Text.Length==0)
            {
                MessageBox.Show("Error, no se puede convertir, si no existe un valor...");
                this.c1.Focus();
                return;
            }
            c= Double.Parse(this.c1.Text);
            //LLAMAMOS LA FUNCION Y EL VALOR DONDE RETORNARA
            double fa = C_temp(c);
            //ENVIAR VALOR A LA CAJA DE TEXTO
            this.f.Text = fa.ToString();
        }

        private void n_Click(object sender, EventArgs e)
        {
            this.c1.Text = "";
            this.f.Text = "";
        }

        private void s_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double C_temp(double c)
        {
            double fa = 0;
            fa = (c*9/5)+32;
            /*fa = (1.8*c)+32;*/
            return fa;
        }
    }
}
