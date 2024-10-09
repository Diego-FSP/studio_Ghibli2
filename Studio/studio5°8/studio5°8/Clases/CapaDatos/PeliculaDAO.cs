using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio5_8.Clases.CapaDatos
{
    internal class PeliculaDAO
    {
        DataTable dt = new DataTable();
        conexion Peliculas = new conexion();

        PeliculaDAO() //DataAdapter
        {
            MySqlConnection Mc = Peliculas.establecerConexion();
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from peliculas", Mc);
            DA.Fill(dt);
        }

        
        void InsertarPeli()
        {
            // nos conectamos
            MySqlConnection cn = Peliculas.establecerConexion();
            //Creamos el cmd
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "agregarP";
            //Agregamos los parametros
            //cmd.Parameters.Add("@",);
        }
    }
}
