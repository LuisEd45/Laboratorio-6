namespace Laboratorio_6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxplaca = new System.Windows.Forms.TextBox();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.textBoxcolor = new System.Windows.Forms.TextBox();
            this.textBoxprecioxkilometro = new System.Windows.Forms.TextBox();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVehiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxplaca
            // 
            this.textBoxplaca.Location = new System.Drawing.Point(155, 78);
            this.textBoxplaca.Name = "textBoxplaca";
            this.textBoxplaca.Size = new System.Drawing.Size(156, 22);
            this.textBoxplaca.TabIndex = 0;
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(155, 125);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(156, 22);
            this.textBoxmarca.TabIndex = 1;
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Location = new System.Drawing.Point(155, 174);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(156, 22);
            this.textBoxmodelo.TabIndex = 2;
            // 
            // textBoxcolor
            // 
            this.textBoxcolor.Location = new System.Drawing.Point(155, 220);
            this.textBoxcolor.Name = "textBoxcolor";
            this.textBoxcolor.Size = new System.Drawing.Size(156, 22);
            this.textBoxcolor.TabIndex = 3;
            // 
            // textBoxprecioxkilometro
            // 
            this.textBoxprecioxkilometro.Location = new System.Drawing.Point(155, 263);
            this.textBoxprecioxkilometro.Name = "textBoxprecioxkilometro";
            this.textBoxprecioxkilometro.Size = new System.Drawing.Size(156, 22);
            this.textBoxprecioxkilometro.TabIndex = 4;
            // 
            // buttoningresar
            // 
            this.buttoningresar.Location = new System.Drawing.Point(171, 318);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(113, 28);
            this.buttoningresar.TabIndex = 5;
            this.buttoningresar.Text = "Ingresar";
            this.buttoningresar.UseVisualStyleBackColor = true;
            this.buttoningresar.Click += new System.EventHandler(this.buttoningresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Placa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio Por Kilómetro";
            // 
            // buttonVehiculos
            // 
            this.buttonVehiculos.Location = new System.Drawing.Point(507, 318);
            this.buttonVehiculos.Name = "buttonVehiculos";
            this.buttonVehiculos.Size = new System.Drawing.Size(113, 28);
            this.buttonVehiculos.TabIndex = 11;
            this.buttonVehiculos.Text = "Ir a vehículos";
            this.buttonVehiculos.UseVisualStyleBackColor = true;
            this.buttonVehiculos.Click += new System.EventHandler(this.buttonVehiculos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVehiculos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.textBoxprecioxkilometro);
            this.Controls.Add(this.textBoxcolor);
            this.Controls.Add(this.textBoxmodelo);
            this.Controls.Add(this.textBoxmarca);
            this.Controls.Add(this.textBoxplaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxplaca;
        private System.Windows.Forms.TextBox textBoxmarca;
        private System.Windows.Forms.TextBox textBoxmodelo;
        private System.Windows.Forms.TextBox textBoxcolor;
        private System.Windows.Forms.TextBox textBoxprecioxkilometro;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVehiculos;
    }
}

