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
        Conexion conex;
        PeliculaCN negocios;
        public Menu(Conexion conexion)
        {
            InitializeComponent();
            negocios = new PeliculaCN(conexion);
            //DataGridViewTextBoxColumn n = negocios.ListaPeli().Columns.;
            Actualizar();
            conex = conexion;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevaPeli_Click(object sender, EventArgs e)
        {

            NuevaPelicula nueva = new NuevaPelicula(conex);
            nueva.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dataGridView1.DataSource = negocios.ListaPeli();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                negocios.EliminarP(int.Parse(textBox1.Text));
                textBox1.Text = " ";

                MessageBox.Show("Se Elimino la Pelicula");
                Actualizar();
            }
            catch(Exception) {

                MessageBox.Show("Selecciona un ID de Pelicula");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
