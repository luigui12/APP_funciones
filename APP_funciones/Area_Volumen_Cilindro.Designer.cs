namespace APP_funciones
{
    partial class Area_Volumen_Cilindro
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
            this.radio = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.ra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio
            // 
            this.radio.Location = new System.Drawing.Point(151, 95);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(100, 20);
            this.radio.TabIndex = 0;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(151, 121);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 20);
            this.altura.TabIndex = 1;
            // 
            // ra
            // 
            this.ra.AutoSize = true;
            this.ra.Location = new System.Drawing.Point(50, 98);
            this.ra.Name = "ra";
            this.ra.Size = new System.Drawing.Size(35, 13);
            this.ra.TabIndex = 3;
            this.ra.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(69, 208);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(150, 208);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(231, 208);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 8;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(151, 147);
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Size = new System.Drawing.Size(100, 20);
            this.area.TabIndex = 9;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(151, 173);
            this.v.Name = "v";
            this.v.ReadOnly = true;
            this.v.Size = new System.Drawing.Size(100, 20);
            this.v.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Volumen";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "CALCULO DE CILINDRO";
            // 
            // Area_Volumen_Cilindro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.area);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ra);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.radio);
            this.Name = "Area_Volumen_Cilindro";
            this.Text = "Area_Volumen_Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radio;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Label ra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}