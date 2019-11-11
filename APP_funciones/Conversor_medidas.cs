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
    }
}
