using studio5_8.Clases.CapaDatos;
namespace studio5_8
{
    public partial class Inicioo : Form
    {
        Menu menu;
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
            Conexion bd = new Conexion(textBox1.Text, textBox2.Text);
            bd.establecerConexion();
            menu = new Menu(bd);
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
