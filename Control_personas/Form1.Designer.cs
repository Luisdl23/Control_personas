
namespace Control_personas
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
            this.textBox1DPI = new System.Windows.Forms.TextBox();
            this.textBox2nom = new System.Windows.Forms.TextBox();
            this.textBox3ape = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttoningreso = new System.Windows.Forms.Button();
            this.labelDPI = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.labelape = new System.Windows.Forms.Label();
            this.labelfecha = new System.Windows.Forms.Label();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labeledad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1DPI
            // 
            this.textBox1DPI.Location = new System.Drawing.Point(227, 65);
            this.textBox1DPI.Name = "textBox1DPI";
            this.textBox1DPI.Size = new System.Drawing.Size(144, 20);
            this.textBox1DPI.TabIndex = 0;
            // 
            // textBox2nom
            // 
            this.textBox2nom.Location = new System.Drawing.Point(227, 119);
            this.textBox2nom.Name = "textBox2nom";
            this.textBox2nom.Size = new System.Drawing.Size(144, 20);
            this.textBox2nom.TabIndex = 1;
            // 
            // textBox3ape
            // 
            this.textBox3ape.Location = new System.Drawing.Point(227, 184);
            this.textBox3ape.Name = "textBox3ape";
            this.textBox3ape.Size = new System.Drawing.Size(144, 20);
            this.textBox3ape.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // buttoningreso
            // 
            this.buttoningreso.Location = new System.Drawing.Point(286, 378);
            this.buttoningreso.Name = "buttoningreso";
            this.buttoningreso.Size = new System.Drawing.Size(141, 37);
            this.buttoningreso.TabIndex = 8;
            this.buttoningreso.Text = "Ingresar Persona";
            this.buttoningreso.UseVisualStyleBackColor = true;
            this.buttoningreso.Click += new System.EventHandler(this.buttoningreso_Click);
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.Location = new System.Drawing.Point(592, 82);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(35, 13);
            this.labelDPI.TabIndex = 9;
            this.labelDPI.Text = "label5";
            this.labelDPI.Visible = false;
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Location = new System.Drawing.Point(592, 126);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(35, 13);
            this.labelnom.TabIndex = 10;
            this.labelnom.Text = "label6";
            this.labelnom.Visible = false;
            // 
            // labelape
            // 
            this.labelape.AutoSize = true;
            this.labelape.Location = new System.Drawing.Point(592, 191);
            this.labelape.Name = "labelape";
            this.labelape.Size = new System.Drawing.Size(35, 13);
            this.labelape.TabIndex = 11;
            this.labelape.Text = "label7";
            this.labelape.Visible = false;
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Location = new System.Drawing.Point(592, 257);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(35, 13);
            this.labelfecha.TabIndex = 12;
            this.labelfecha.Text = "label8";
            this.labelfecha.Visible = false;
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.Location = new System.Drawing.Point(595, 368);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(144, 23);
            this.buttonmostrar.TabIndex = 13;
            this.buttonmostrar.Text = "Mostrar persona";
            this.buttonmostrar.UseVisualStyleBackColor = true;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Arreglos ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeledad
            // 
            this.labeledad.AutoSize = true;
            this.labeledad.Location = new System.Drawing.Point(592, 305);
            this.labeledad.Name = "labeledad";
            this.labeledad.Size = new System.Drawing.Size(35, 13);
            this.labeledad.TabIndex = 15;
            this.labeledad.Text = "label5";
            this.labeledad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 453);
            this.Controls.Add(this.labeledad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonmostrar);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.labelape);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.buttoningreso);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3ape);
            this.Controls.Add(this.textBox2nom);
            this.Controls.Add(this.textBox1DPI);
            this.Name = "Form1";
            this.Text = "                                   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1DPI;
        private System.Windows.Forms.TextBox textBox2nom;
        private System.Windows.Forms.TextBox textBox3ape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttoningreso;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label labelape;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeledad;
    }
}

