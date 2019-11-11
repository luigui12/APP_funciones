namespace APP_funciones
{
    partial class Perimetro_Superficie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.longitud = new System.Windows.Forms.TextBox();
            this.perimetro = new System.Windows.Forms.TextBox();
            this.superficie = new System.Windows.Forms.TextBox();
            this.alv1 = new System.Windows.Forms.Button();
            this.alv2 = new System.Windows.Forms.Button();
            this.alv3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DE UN CUADRADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perimetro : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Superficie :  ";
            // 
            // longitud
            // 
            this.longitud.Location = new System.Drawing.Point(127, 101);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(100, 20);
            this.longitud.TabIndex = 4;
            // 
            // perimetro
            // 
            this.perimetro.Location = new System.Drawing.Point(127, 133);
            this.perimetro.Name = "perimetro";
            this.perimetro.ReadOnly = true;
            this.perimetro.Size = new System.Drawing.Size(100, 20);
            this.perimetro.TabIndex = 5;
            // 
            // superficie
            // 
            this.superficie.Location = new System.Drawing.Point(127, 168);
            this.superficie.Name = "superficie";
            this.superficie.ReadOnly = true;
            this.superficie.Size = new System.Drawing.Size(100, 20);
            this.superficie.TabIndex = 6;
            // 
            // alv1
            // 
            this.alv1.Location = new System.Drawing.Point(32, 221);
            this.alv1.Name = "alv1";
            this.alv1.Size = new System.Drawing.Size(75, 23);
            this.alv1.TabIndex = 7;
            this.alv1.Text = "Calcular";
            this.alv1.UseVisualStyleBackColor = true;
            this.alv1.Click += new System.EventHandler(this.alv1_Click);
            // 
            // alv2
            // 
            this.alv2.Location = new System.Drawing.Point(115, 221);
            this.alv2.Name = "alv2";
            this.alv2.Size = new System.Drawing.Size(75, 23);
            this.alv2.TabIndex = 8;
            this.alv2.Text = "Nuevo";
            this.alv2.UseVisualStyleBackColor = true;
            this.alv2.Click += new System.EventHandler(this.alv2_Click);
            // 
            // alv3
            // 
            this.alv3.Location = new System.Drawing.Point(196, 221);
            this.alv3.Name = "alv3";
            this.alv3.Size = new System.Drawing.Size(75, 23);
            this.alv3.TabIndex = 9;
            this.alv3.Text = "Salir";
            this.alv3.UseVisualStyleBackColor = true;
            this.alv3.Click += new System.EventHandler(this.alv3_Click);
            // 
            // Perimetro_Superficie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 295);
            this.Controls.Add(this.alv3);
            this.Controls.Add(this.alv2);
            this.Controls.Add(this.alv1);
            this.Controls.Add(this.superficie);
            this.Controls.Add(this.perimetro);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Perimetro_Superficie";
            this.Text = "Perimetro_Superficie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox longitud;
        private System.Windows.Forms.TextBox perimetro;
        private System.Windows.Forms.TextBox superficie;
        private System.Windows.Forms.Button alv1;
        private System.Windows.Forms.Button alv2;
        private System.Windows.Forms.Button alv3;
    }
}