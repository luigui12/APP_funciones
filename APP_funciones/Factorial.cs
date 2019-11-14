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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void n_Click(object sender, EventArgs e)
        {
            this.numero.Text = "";
            this.re.Text = "";

        }

        private void sa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por visitar... :) ");
            this.Close();
        }

        private void C_Click(object sender, EventArgs e)
        {
            long n;
            if (this.numero.Text.Length==0)
            {
                MessageBox.Show("No existen valores en la caja de texto a factorizar...");
                this.numero.Focus();
                return;
            }
            n = long.Parse(this.numero.Text);
            long x = C_numero(n);
            this.re.Text = x.ToString();
        }
        private long C_numero (long n)
        {
            int x1 = 1;
            for(int i=1;i<=n; i++)
            {
                x1 = x1 * i;
            }
            return x1;
        }
    }
}
