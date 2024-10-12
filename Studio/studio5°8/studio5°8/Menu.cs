using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studio5_8.Clases.CapaDatos;
using studio5_8.Clases.CapaNegocio;

namespace studio5_8
{
    public partial class Menu : Form
    {
        
        PeliculaCN negocios;
        public Menu(Conexion conexion)
        {
            InitializeComponent();
            negocios = new PeliculaCN(conexion);
            dataGridView1.DataSource = negocios.ListaPeli();
        }


    }
}
