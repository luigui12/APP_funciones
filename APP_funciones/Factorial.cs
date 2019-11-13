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
            this.Close();
        }

        private void C_Click(object sender, EventArgs e)
        {

        }
        private long C_numero (int n)
        {
            int x1 = 0;
            for(int i=1;i<n; i++)
            {
                x1 = i * n;
            }
        }
    }
}
