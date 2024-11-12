using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using studio5_8.Clases.CapaAplicacion;
using studio5_8.Clases.CapaDatos;
using studio5_8.Clases.CapaNegocio;

namespace studio5_8
{
    public partial class Menu : Form
    {
        Conexion conex;
        PeliculaCN negocios;
        int seleccion = 0;
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
            info.Show();
            seleccion = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDPelicula"].Value.ToString());
            info.Text = "Informacion ID: " + seleccion;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["IDPelicula"].Value.ToString();
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

                if (int.Parse(textBox1.Text) > 0)
                {
                    negocios.EliminarP(int.Parse(textBox1.Text));
                    textBox1.Text = " ";
                    info.Visible = false;
                    MessageBox.Show("Se Elimino la Pelicula");
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Esa pelicula no existe");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecciona un ID de Pelicula");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {
            PeliculaInfo info = new PeliculaInfo(conex, seleccion);
            info.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ACT_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conex.conex.Close();
            this.Close();
        }
    }
}
