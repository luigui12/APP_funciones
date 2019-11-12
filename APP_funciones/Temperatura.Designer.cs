namespace APP_funciones
{
    partial class Temperatura
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ºC : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ºF : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "a";
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(90, 68);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(100, 20);
            this.c1.TabIndex = 14;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(9, 188);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(75, 23);
            this.c.TabIndex = 16;
            this.c.Text = "Calcular";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(90, 188);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(75, 23);
            this.n.TabIndex = 17;
            this.n.Text = "Nuevo";
            this.n.UseVisualStyleBackColor = true;
            this.n.Click += new System.EventHandler(this.n_Click);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(171, 188);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 23);
            this.s.TabIndex = 18;
            this.s.Text = "Salir";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "ºC A ºF";
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(90, 139);
            this.f.Name = "f";
            this.f.ReadOnly = true;
            this.f.Size = new System.Drawing.Size(100, 20);
            this.f.TabIndex = 20;
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 224);
            this.Controls.Add(this.f);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s);
            this.Controls.Add(this.n);
            this.Controls.Add(this.c);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Temperatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f;
    }
}