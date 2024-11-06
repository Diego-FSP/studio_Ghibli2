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
public class DirectorCN
    {
        DirectorDAO DirecDAO;
        
        public string nombreD(int ID)
        {
            return DirecDAO.Direc(ID);
        }
        public DirectorCN(Conexion c)
        {
            DirecDAO = new DirectorDAO(c);
        }
        public DataTable ListaDirec()
        {
            return DirecDAO.ListaDirec();
        }
        /*
        public void nuevaPeli(PeliculaCE p)
        {
            PeliDAO.AgregarPeli(p);
        }
        public int CantidadP()
        {
            int v=PeliDAO.CantP();
            return v;
        }
        public void EliminarP(int p)
        {
            PeliDAO.EliminarPeli(p);
        }
        */
    }
}
