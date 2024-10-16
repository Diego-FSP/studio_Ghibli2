using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
        string[] Generos = {"Acción","Animación","Aventuras","Bélico","Biográfico","Ciencia ficción","Comedia","Documental","Drama","Erótico","Espionaje","Fantástico","Histórico","Mudo","Musical","Negro Policíaco","Suspense","Terror"};
        public NuevaPelicula(Conexion conex)
        {
            
            DataTable dt = new DataTable();
            InitializeComponent();
            conexion = new PeliculaCN(conex);
            director = new DirectorCN(conex);
            dataGridView1.DataSource = director.ListaDirec();
            /*
            MySqlDataAdapter DA = new MySqlDataAdapter("Select id_pelicula AS IDPelicula, nombre AS Nombre  from peliculas order by id_pelicula asc", );
            DA.Fill(dt);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] fc = { int.Parse(d1.Text), int.Parse(m1.Text), int.Parse(a1.Text) };
                int[] fe = { int.Parse(d1.Text), int.Parse(m2.Text), int.Parse(a2.Text) };
                
                PeliculaCE pelicula = new PeliculaCE
                {
                    idStudio = 1,
                    IdPelicula = conexion.CantidadP() + 1,
                    Nombre = textBox1.Text,
                    director = int.Parse(textBox2.Text),
                    FechaCreacion = fecha(fc),
                    FechaEstreno = fecha(fe),
                    Duracion = textBox5.Text,
                    Genero = Generos[ comboBox1.SelectedIndex].ToString(),
                    Presupuesto = int.Parse(textBox7.Text),
                    Calificacion = textBox8.Text + "/10",
                    ProgramaEstilo = textBox9.Text
                };

                conexion.nuevaPeli(pelicula);
                MessageBox.Show("Se Agrego la Pelicula Correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                d1.Text = textBox1.Text;
                d2.Text = textBox2.Text;
                m1.Text = textBox1.Text;
                m2.Text = textBox2.Text;
                a1.Text = textBox1.Text;
                a2.Text = textBox2.Text;
            }
            catch(Exception)
            {

                MessageBox.Show("No se agrego Pelicula");
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
    }
}
