using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studio5_8.Clases.CapaDatos;
using MySql.Data.MySqlClient;
using Peli;

namespace studio5_8.Clases.CapaNegocio
{
    class PeliculaCN
    {
        PeliculaDAO PeliDAO;
        
       
        public PeliculaCN(Conexion c)
        {
            PeliDAO = new PeliculaDAO(c);
        }
        public DataTable ListaPeli()
        {
            return PeliDAO.ListaPeli();
        }

        public void nuevaPeli(PeliculaCE p)
        {
            PeliDAO.AgregarPeli(p);
        }
    }
}
