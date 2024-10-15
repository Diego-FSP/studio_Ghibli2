using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Peli;
using studio5_8.Clases.CapaNegocio;

namespace studio5_8
{
    public partial class NuevaPelicula : Form
    {
        PeliculaCN conexion;
        public NuevaPelicula(PeliculaCN c)
        {
            DataTable dt = new DataTable();
            InitializeComponent();
            conexion = c;
            /*
            MySqlDataAdapter DA = new MySqlDataAdapter("Select id_pelicula AS IDPelicula, nombre AS Nombre  from peliculas order by id_pelicula asc", );
            DA.Fill(dt);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] fc = { int.Parse(d1.Text), int.Parse(m1.Text), int.Parse(a1.Text) };
            int[] fe = { int.Parse(d1.Text), int.Parse(m2.Text), int.Parse(a2.Text) };

            PeliculaCE pelicula = new PeliculaCE
            {
                idStudio = 1,
                IdPelicula = conexion.CantidadP()+1,
                Nombre = textBox1.Text,
                director = int.Parse(textBox2.Text),
                FechaCreacion = fecha(fc),
                FechaEstreno = fecha(fe),
                Duracion = textBox5.Text,
                Genero = textBox6.Text,
                Presupuesto = int.Parse(textBox7.Text),
                Calificacion = textBox8.Text,
                ProgramaEstilo = textBox9.Text
            };

            conexion.nuevaPeli(pelicula);
            MessageBox.Show("Se Agrego la Pelicula Correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
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
    }
}
