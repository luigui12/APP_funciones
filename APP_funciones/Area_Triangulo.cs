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
    public partial class Area_Triangulo : Form
    {
        public Area_Triangulo()
        {
            InitializeComponent();
            MessageBox.Show("BIENVENIDO ESPERO DISFRUTE DE ESTE CONTENIDO... <3");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.a.Text = "";
            this.b.Text = "";
            this.c.Text = "";
            this.alv1.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //LLAMAMOS VARIABLES
            double a, b, c;
            //VALIDAR CAJAS DE TEXTO
            if (this.a.Text.Length == 0)
            {
                MessageBox.Show("Ey, ey! no se registran valores en la cajas de textos...!!");
                this.a.Focus();
                return;
            }
            if (this.b.Text.Length==0)
            {
                MessageBox.Show("Ey, ey! no se registran valores en la cajas de textos...!!");
                this.a.Focus();
                return;
            }
            if (this.c.Text.Length == 0)
            {
                MessageBox.Show("Ey, ey! no se registran valores en la cajas de textos...!!");
                this.a.Focus();
                return;
            }
            a = Double.Parse(this.a.Text);
            b = Double.Parse(this.b.Text);
            c = Double.Parse(this.c.Text);
            double ar = C_area(a, b, c);
            //ASIGNAMOS RESULTADOS A LA CAJA DE TEXTOS
            this.alv1.Text = ar.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //CREAMOS METODO PARA EL AREA
        private double C_area(double a, double b, double c)
        {
            double ar = 0, sp = 0, alv1=0, alv2=0, alv3=0;
            //semiparametro
            sp = ((a+b+c)/2);
            alv1 = (sp - a);
            alv2 = (sp - b);
            alv3 = (sp - c);
            //VERIFICAR RAIZ NEGATIVA
            if (sp < 0)
            {
                MessageBox.Show("Error este ejercicio tiene solucion imaginaria...");
                return 0;
            }
            ar = (Math.Sqrt(sp*alv1*alv2*alv3));
            return ar;
        }
    }
}
