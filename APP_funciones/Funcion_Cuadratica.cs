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
    public partial class Funcion_Cuadratica : Form
    {
        public Funcion_Cuadratica()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Funcion_Cuadratica_Load(object sender, EventArgs e)
        {
            //este evento
            //se ejecuta cada vez que se habre el formulario

            //establecer el control txtX2 de solo
            //lectura
            this.x2.ReadOnly = true;
            this.x1.ReadOnly = true;

        }
        //CREAR METODO PARA CALCULAR X1
        private double X1(double a, double b, double c)
        {
            //DECLARAR VARIABLES 
            double x1 = 0, d = 0;
            //CALCULAR DISCRIMINATE
            d = (b * b) - (4 * a * c);
            //VERIFICAR SI A ES DISTINTO DE 0(CERO)
            if (a == 0)
            {
                MessageBox.Show("ERROR AL DIVIDIR PARA 0...!!");
                return 0;//ABANDONAR
            }
           //VERIFICAR RAICES NEGATIVAS
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias...");
                return 0;
            }
            x1 = (-b + Math.Sqrt(d))/(2*a);
            return x1;
        }
            //CREAR OTRO METODO PARA CALCULAR X2
        private double X2(double a, double b, double c)
        {
            //DECLARAMOS VARIABLES PARA X2
            double x2 = 0, d=0;
            //CALCULAR DISCRIMINANTE
            d = (b * b) - (4 * a * c);
            //VERIFICAR SI A ES DISTINTO DE 0
            if (a == 0)
            {
                MessageBox.Show("Error al dividir para cero...!!");
                return 0;
            }
            //VERIFICAR RAICES NEGATIVAS
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene solucion imaginaria...");
                return 0; //ABANDONAR
            }
            x2 = (-b + Math.Sqrt(d)) / (2*a);
            return x2;
        }

        private void calcularx1_Click(object sender, EventArgs e)
        {
            //LLAMADA A LA FUNCION X1 
            double a, b, c;
            //VALIDAR SI EL USUARIO A INGRESADO VALORES
            if (this.A.Text.Length==0)
            {
                MessageBox.Show("Por favor ingrese el valor de A..!!");
                this.A.Focus(); //UBICA EL CURSOR EN EL CUADRO DE TEXTO.
                return;
            }
            a = Double.Parse(this.A.Text);
            b = Double.Parse(this.B.Text);
            c = Double.Parse(this.C.Text);
            double x1 = X1(a, b, c);
            double x2 = X2(a, b, c);
            //ASIGNO EL RESULTADO DE X1 EN EL TEXTBOXTXTX1
            this.x1.Text = x1.ToString();
            //ASIGNO EL RESULTADO DE X2 EN EL TEXTBOXTXTX2
            this.x2.Text = x2.ToString();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.A.Text = "";
            this.B.Text = "";
            this.C.Text = "";
            this.x1.Text = "";
            this.x2.Text = "";
            this.A.Focus();
            this.B.Focus();
            this.C.Focus();
        }

        private void calcularx2_Click(object sender, EventArgs e)
        {

        }
    }
}
