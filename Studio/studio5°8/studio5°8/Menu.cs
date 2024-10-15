using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studio5_8.Clases.CapaDatos;
using studio5_8.Clases.CapaNegocio;

namespace studio5_8
{
    public partial class Menu : Form
    {

        PeliculaCN negocios;
        public Menu(Conexion conexion)
        {
            InitializeComponent();
            negocios = new PeliculaCN(conexion);
            //DataGridViewTextBoxColumn n = negocios.ListaPeli().Columns.;
            dataGridView1.DataSource = negocios.ListaPeli();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevaPeli_Click(object sender, EventArgs e)
        {
            NuevaPelicula nueva = new NuevaPelicula(negocios);
            nueva.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocios.ListaPeli();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            negocios.EliminarP(int.Parse(textBox1.Text));
            textBox1.Text = " ";
        }
    }
}
