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
    public partial class Perimetro_Superficie : Form
    {
        public Perimetro_Superficie()
        {
            InitializeComponent();
        }

        private void alv2_Click(object sender, EventArgs e)
        {
            this.longitud.Text = "";
            this.perimetro.Text = "";
            this.superficie.Text = "";
        }

        private void alv3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alv1_Click(object sender, EventArgs e)
        {
            //LLAMAMOS LAS VARIABLES 
            double lo;
            //VALIDAR SI EL USUARIO INGRESO VALOR EN LA CAJA DE TEXTO
            if (this.longitud.Text.Length==0)
            {
                MessageBox.Show("Alerta...!! caja de texto vacia.");
                return;
            }
            lo = Double.Parse(this.longitud.Text);
            double p = C_perimetro(lo);
            double a = C_area(lo);

            //ENVIAMOS RESULTADO A LA CAJA DE TEXTO CORRESPONDIENTE
            this.perimetro.Text = p.ToString();
            this.superficie.Text = a.ToString();

        }
        //CREAR METODO PARA PERIMETRO
        private double C_perimetro(double lo)
        {
            double p = 0;
            p = (4*lo);
            return p;
        }

        //CREAMOS METODO PARA EL AREA
        private double C_area(double lo)
        {
            double a = 0;
            a = (lo * lo);
            return a;
        }
    }
}
