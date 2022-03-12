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
    public partial class Form2 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Form2()
        {
            InitializeComponent();
        }
        private void GuardarAlquileres()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var Cliente in clientes)
            {
                writer.WriteLine(Cliente.nit);
                writer.WriteLine(Cliente.nombre);
                writer.WriteLine(Cliente.direccion);
            }
            writer.Close();
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoningresar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nit = textBoxnit.Text;
            cliente.nombre = textBoxnombre.Text;
            cliente.direccion = textBoxdireccion.Text;
            clientes.Add(cliente);
            GuardarAlquileres();

        }
    }
}
