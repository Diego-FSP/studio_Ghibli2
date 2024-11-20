using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
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
            mFondo.settings.playCount = 999;
            mFondo.Ctlcontrols.play();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                seleccion = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDPelicula"].Value.ToString());
                info.Text = "Informacion ID: " + seleccion;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["IDPelicula"].Value.ToString();
                info.Show();
            }
            catch
            {
                seleccion = 0;
            }
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

        public void Tamaño(object sender, EventArgs e)
        {
            int X = this.Size.Width;
            int Y = this.Size.Height;
            // Location 137; 220
            // Size 601; 184
            //dataGridView1.Location = new System.Drawing.Point(X/2 - 310, Y/2 - 64);
            dataGridView1.Size = new System.Drawing.Size(X - 294, 184 + (Y / 563));
            pictureBox1.Size = new System.Drawing.Size(X - 40, 143);
            button3.Location = new System.Drawing.Point(X - 133, Y - 87);
            // Location 633; 423
            button1.Location = new System.Drawing.Point(dataGridView1.Size.Width + 137 - 102, dataGridView1.Size.Height + 239);
            // 391; 423
            info.Location = new System.Drawing.Point(dataGridView1.Size.Width/2 + 137 - (102/2), dataGridView1.Size.Height + 239);
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
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
