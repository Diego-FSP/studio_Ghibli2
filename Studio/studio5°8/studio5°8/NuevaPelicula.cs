using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Peli;
using studio5_8.Clases.CapaNegocio;

namespace studio5_8
{
    public partial class NuevaPelicula : Form
    {
        PeliculaCN conexion;
        public NuevaPelicula(PeliculaCN c)
        {
            InitializeComponent();
            conexion = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] fc = { int.Parse(d1.Text), int.Parse(m1.Text), int.Parse(a1.Text) };
            int[] fe = { int.Parse(d1.Text), int.Parse(m2.Text), int.Parse(a2.Text) };

            PeliculaCE pelicula = new PeliculaCE
            {
                idStudio = 1,
                IdPelicula = 24,
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
