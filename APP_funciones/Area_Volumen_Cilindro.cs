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
    public partial class Area_Volumen_Cilindro : Form
    {
        public Area_Volumen_Cilindro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.radio.Text = "";
            this.altura.Text = "";
            this.area.Text = "";
            this.v.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            double ra, al;
            //VALIDACION DE DATOS EN LA CAJA
            if (this.radio.Text.Length==0)
            {
                MessageBox.Show("Ojo, no existen valores en la caja de datos...!!");
                return;
            }
            if (this.altura.Text.Length==0)
            {
                MessageBox.Show("Ojo, no existen valores en la caja de datos...!!");
                return;
            }
            ra = Double.Parse(this.radio.Text);
            al = Double.Parse(this.altura.Text);
            double area = C_area(ra, al);
            double v = C_volumen(ra, al);
            //ASIGNAR VALORES A LA CAJA DE TEXTO AL AREA
            this.area.Text = area.ToString();
            //ASIGNAR VALORES A LA CAJA DE TEXTO DEL VOLUMEN
            this.v.Text = v.ToString();
        }
        //CREAMOS METODO PARA CALCULAR EL AREA 
        private double C_area(double ra, double al)
        {
            double area = 0, alv=0;
            alv = (2 * Math.PI * ra * ra);
            area = (2 * Math.PI * ra* al + alv);
            return area;
        }

        //CREAMOS METODO PARA CALCULAR EL VOLUMEN
        private double C_volumen(double ra, double al)
        {
            double v = 0;
            v = (Math.PI * ra * ra * al);
            return v;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
