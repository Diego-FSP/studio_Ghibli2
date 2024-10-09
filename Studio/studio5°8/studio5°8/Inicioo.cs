using studio5_8.Clases.CapaDatos;
namespace studio5_8
{
    public partial class Inicioo : Form
    {
        public Inicioo()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(121, 134, 69);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion bd= new conexion();
            bd.establecerConexion();
        }
    }
}
