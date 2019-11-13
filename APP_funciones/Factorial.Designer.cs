namespace APP_funciones
{
    partial class Factorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.C = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.sa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.re = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(26, 166);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 23);
            this.C.TabIndex = 0;
            this.C.Text = "&Calcular";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(119, 166);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(75, 23);
            this.n.TabIndex = 1;
            this.n.Text = "&Nuevo";
            this.n.UseVisualStyleBackColor = true;
            this.n.Click += new System.EventHandler(this.n_Click);
            // 
            // sa
            // 
            this.sa.Location = new System.Drawing.Point(214, 166);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(75, 23);
            this.sa.TabIndex = 2;
            this.sa.Text = "&Salir";
            this.sa.UseVisualStyleBackColor = true;
            this.sa.Click += new System.EventHandler(this.sa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese un numero: ";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(143, 70);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 4;
            // 
            // re
            // 
            this.re.Location = new System.Drawing.Point(143, 107);
            this.re.Name = "re";
            this.re.ReadOnly = true;
            this.re.Size = new System.Drawing.Size(100, 20);
            this.re.TabIndex = 5;
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 215);
            this.Controls.Add(this.re);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.n);
            this.Controls.Add(this.C);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Button sa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox re;
    }
}