using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_personas
{
    public partial class Form1 : Form
    {
        // clse de objeto 
        // Instanciar clase 
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttoningreso_Click(object sender, EventArgs e)
        {
           
            persona.Dpi = textBox1DPI.Text;
            persona.Nombre = textBox2nom.Text;
            persona.Apellido = textBox3ape.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;

        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            labelDPI.Text = persona.Dpi;
            labelnom.Text = persona.Nombre;
            labelape.Text = persona.Apellido;
            labelfecha.Text = persona.FechaNacimiento.ToShortDateString();
            int edad = persona.edad();
            labeledad.Text = edad.ToString();

            labelDPI.Visible = true;
            labelnom.Visible = true;
            labelape.Visible = true;
            labelfecha.Visible = true;
            labeledad.Visible = true; 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            labelnom.Text = persona.Nombre;
            //persona.normalizarNombre().trim();
            persona.PrimeraMayuscula();
            labelape.Text = persona.Apellido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
    }
}
