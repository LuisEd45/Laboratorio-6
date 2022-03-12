using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_6
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var Vehiculo in vehiculos)
            {
                writer.WriteLine(Vehiculo.placa);
                writer.WriteLine(Vehiculo.marca);
                writer.WriteLine(Vehiculo.modelo);
                writer.WriteLine(Vehiculo.color);
                writer.WriteLine(Vehiculo.precioxkilometro);
            }
            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttoningresar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.placa = textBoxplaca.Text;
            vehiculo.marca = textBoxmarca.Text;
            vehiculo.modelo = Convert.ToInt16(textBoxmodelo.Text);
            vehiculo.color = textBoxcolor.Text;
            vehiculo.precioxkilometro = Convert.ToDecimal(textBoxprecioxkilometro.Text);

            int posicion = vehiculos.FindIndex(x => x.placa == textBoxplaca.Text);
            if(posicion == -1)
            {
                vehiculos.Add(vehiculo);
                GuardarVehiculo();
            }
            else
            {
                MessageBox.Show("El vehículo ya estaba ingresado.");
            }
            vehiculos.Add(vehiculo);

            Form formulario = new Form2();
            formulario.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVehiculos_Click(object sender, EventArgs e)
        {
            FormAlquiler formularioAlquiler = new FormAlquiler();
            formularioAlquiler.Show();
        }
    }
}
