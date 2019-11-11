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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse( this.num1.Text.ToString());
            int num2 = Int32.Parse(this.num2.Text.ToString());
            int suma = fnsuma(num1, num2);

            //asigno el resultado al cuadro de texto
            this.sumar.Text = suma.ToString();
        }
            int fnsuma(int a, int b)
        {
            return (a+b);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.num1.Text.ToString());
            int num2 = Int32.Parse(this.num2.Text.ToString());
            int resta = fnresta(num1, num2);

            //asigno el resultado al cuadro de texto
            this.sumar.Text = resta.ToString();
        }
        int fnresta(int a, int b)
        {
            return (a-b);
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.num1.Text.ToString());
            int num2 = Int32.Parse(this.num2.Text.ToString());
            int multi = fnmulti(num1, num2);
            //asigno el resultado en la caja de texto
            this.sumar.Text = multi.ToString();
        }
        int fnmulti(int a, int b)
        {
            return (a*b);
        }

        private void division_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.num1.Text.ToString());
            int num2 = Int32.Parse(this.num2.Text.ToString());
            int division = fndivision(num1, num2);
            //asigno el resultado en la caja de texto
            this.sumar.Text = division.ToString();
        }
        int fndivision(int a, int b)
        {
            return (a / b);
        }

        private void sumar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
