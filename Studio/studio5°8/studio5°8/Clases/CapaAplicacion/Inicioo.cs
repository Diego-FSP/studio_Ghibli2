using studio5_8.Clases.CapaDatos;
using System.Media;
namespace studio5_8
{
    public partial class Inicioo : Form
    {
        Menu menu;
        SoundPlayer Fondo = new SoundPlayer("Resources/Scrooge_s-Office.wav");
        public Inicioo()
        {
            InitializeComponent();
            Fondo.PlayLooping();
            //BackColor = Color.FromArgb(121, 134, 69);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion(textBox1.Text, textBox2.Text);
            bd.establecerConexion();
            if (bd.E)
            {
                Fondo.Stop();
                menu = new Menu(bd);
                menu.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Equipo de Proyecto:

	Desarrollador: Diego Silupu
	Diseñadora: Keila Mateo
	Investigadores: Keila y Diego

Herramientas utilizadas:

	. Visual Studio y Mysql
	. Lenguaje de programacion: C#
	. Diseño: Paint y Adobe Flash

Inspiracion o Referencias:

	. Inspirado en las peliculas del Studio Ghibli 
	. Pagina ofical del estudio de peliculas

Colaboradores:

    Profesores:

	. Claudio Viacava 
	. Luis Duran
 
    Compañeros:

	. Francisco Garcia 
	. Geraldine Vargas
	. Aylen Toledo

Recursos Y Licencias:

	. En nuestro proyecto se utilizaron imagenes y musica del Studio Ghibli, de pinterest 
	. Iconos y fuentes de informacion fueron utilizados de 'https://www.ghibli.jp/'");
        }
    }
}
