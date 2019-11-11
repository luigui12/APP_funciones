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
    public partial class Cuadrado_de_un_Numero : Form
    {
        public Cuadrado_de_un_Numero()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.numero.Text = "";
            this.resultado.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //LLAMAR A LA FUNCION CUADRADA
            int n;
            if (this.numero.Text.Length == 0)
            {
                MessageBox.Show("Por Favor ingrese un numero...!!");
                return;
            }
            n = int.Parse(this.numero.Text);
            int r = cuadrado (n);
            //ASIGNAER RESULTADO A LA CAJA DE TEXTO
            this.resultado.Text = r.ToString();
        }
        //METODO PARA EL NUMERO AL CUADRADO
        private int cuadrado(int n)
        {
            int r = 0;
            r = n * n;
            return r;
        }

    }
}
