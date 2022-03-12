namespace Laboratorio_6
{
    partial class Form2
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
            this.textBoxnit = new System.Windows.Forms.TextBox();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nit";
            // 
            // textBoxnit
            // 
            this.textBoxnit.Location = new System.Drawing.Point(118, 70);
            this.textBoxnit.Name = "textBoxnit";
            this.textBoxnit.Size = new System.Drawing.Size(156, 22);
            this.textBoxnit.TabIndex = 8;
            // 
            // buttoningresar
            // 
            this.buttoningresar.Location = new System.Drawing.Point(131, 226);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(113, 28);
            this.buttoningresar.TabIndex = 9;
            this.buttoningresar.Text = "Ingresar";
            this.buttoningresar.UseVisualStyleBackColor = true;
            this.buttoningresar.Click += new System.EventHandler(this.buttoningresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(118, 120);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(156, 22);
            this.textBoxnombre.TabIndex = 11;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(118, 174);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(156, 22);
            this.textBoxdireccion.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dirección";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.textBoxnit);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnit;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.Label label3;
    }
}