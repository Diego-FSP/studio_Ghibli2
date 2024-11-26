using Directores;
using studio5_8.Clases.CapaDatos;
using studio5_8.Clases.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studio5_8.Clases.CapaAplicacion
{
    public partial class PeliculaInfo : Form
    {
        PeliculaCN peliculaN;
        DataTable info = new DataTable();
        public PeliculaInfo(Conexion conex, int f)
        {
            InitializeComponent();
            peliculaN = new PeliculaCN(conex);
            info = peliculaN.infoPeli(f);
            nombre.Text = info.Rows[0]["nombre"].ToString();
            duracion.Text += info.Rows[0]["duracion"].ToString();
            id.Text += info.Rows[0]["id_pelicula"].ToString();
            DirectorCN directorCN = new DirectorCN(conex);
            director.Text += directorCN.nombreD(int.Parse(info.Rows[0]["id_director"].ToString()));
            Descripcion.Text += info.Rows[0]["descripcion"].ToString();
            Genero.Text += info.Rows[0]["genero"].ToString();
            label2.Text += info.Rows[0]["fecha_estreno"].ToString();
            label3.Text += info.Rows[0]["fecha_creacion"].ToString();

            try
            {
                MemoryStream ms = new MemoryStream((byte[])info.Rows[0]["poster"]);
                Bitmap bm = new Bitmap(ms);
                Poster.Image = bm;
            }
            catch (Exception)
            {
                Poster.Image = Image.FromFile(info.Rows[0]["portada"].ToString());
            }

            //portada
        }

        private void Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trama_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Tamaño(object sender, EventArgs e)
        {
            int X = this.Size.Width;
            int Y = this.Size.Height;

            // Location 137; 220
            // Size 408; 244
            //dataGridView1.Location = new System.Drawing.Point(X/2 - 310, Y/2 - 64);
            //dataGridView1.Size = new System.Drawing.Size(X - 294, 184 + (Y / 563));
            //pictureBox1.Size = new System.Drawing.Size(X - 40, 143);
            //button3.Location = new System.Drawing.Point(X - 133, Y - 87);
            // Location 633; 423
            //button1.Location = new System.Drawing.Point(dataGridView1.Size.Width + 137 - 102, dataGridView1.Size.Height + 239);
            // 391; 423
            //info.Location = new System.Drawing.Point(dataGridView1.Size.Width / 2 + 137 - (102 / 2), dataGridView1.Size.Height + 239);
        }
    }
}
