using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Notice;
using Peli;
using studio5_8.Clases.CapaDatos;
using studio5_8.Clases.CapaNegocio;

namespace studio5_8
{
    public partial class NuevaPelicula : Form
    {
        PeliculaCN conexion;
        DirectorCN director;
        string[] Generos = { "Acción", "Animación", "Aventuras", "Bélico", "Biográfico", "Ciencia ficción", "Comedia", "Documental", "Drama", "Erótico", "Espionaje", "Fantástico", "Histórico", "Mudo", "Musical", "Negro Policíaco", "Suspense", "Terror" };
        public NuevaPelicula(Conexion conex)
        {

            DataTable dt = new DataTable();
            InitializeComponent();
            conexion = new PeliculaCN(conex);
            director = new DirectorCN(conex);
            //direc.DataSource = director.ListaDirec();

            /*
            MySqlDataAdapter DA = new MySqlDataAdapter("Select id_pelicula AS IDPelicula, nombre AS Nombre  from peliculas order by id_pelicula asc", );
            DA.Fill(dt);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] fc = { int.Parse(diaC.Text), int.Parse(mesC.Text), int.Parse(AñoC.Text) };
                int[] fe = { int.Parse(diaE.Text), int.Parse(mesE.Text), int.Parse(anioE.Text) };

                MemoryStream ms = new MemoryStream();
                Imagen.Image.Save(ms, ImageFormat.Jpeg);
                byte[] abyte = ms.ToArray();

                int c = direc.SelectedIndex;

                PeliculaCE pelicula = new PeliculaCE
                {
                    idStudio = 1,
                    IdPelicula = conexion.CantidadP() + 1,
                    Nombre = textBox1.Text,
                    director = direc.SelectedIndex+1,
                    FechaCreacion = fecha(fc),
                    FechaEstreno = fecha(fe),
                    Duracion = comboBox3.Text + "H " + comboBox4.Text + "m",
                    Genero = comboBox2.Text,
                    Presupuesto = int.Parse(textBox7.Text),
                    Calificacion = comboBox1.Text + "/10",
                    ProgramaEstilo = comboBox5.Text,
                    descripcion = textBox2.Text,
                    poster = abyte
                };
                conexion.nuevaPeli(pelicula);
                MessageBox.Show("Se Agrego la Pelicula Correctamente");
                textBox1.Text = "";
                direc.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox1.Text = "";
                textBox7.Text = "";
                comboBox2.Text = "";
                comboBox5.Text = "";
                diaC.Text = textBox1.Text;
                diaE.Text = direc.Text;
                mesC.Text = textBox1.Text;
                mesE.Text = direc.Text;
                AñoC.Text = textBox1.Text;
                anioE.Text = direc.Text;
            }
            catch (Exception j)
            {

                MessageBox.Show("No se agrego Pelicula"+j);
            }
        }
        public DateTime fecha(int[] f)
        {
            Console.ForegroundColor = ConsoleColor.White;
            DateTime elegido;
            return elegido = new DateTime(f[2], f[1], f[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void NuevaPelicula_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void a1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void direc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Selecionar = new OpenFileDialog();
            Selecionar.Filter = "imagenes|*.jpg; *.png";
            Selecionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Selecionar.Title = "Selecionar";

            if (Selecionar.ShowDialog() == DialogResult.OK) 
            {
                Imagen.Image = Image.FromFile(Selecionar.FileName);
            }
        }
    }
}
