using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Peli;
using Org.BouncyCastle.Utilities;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace studio5_8.Clases.CapaDatos
{
    internal class PeliculaDAO
    {
        DataTable dt = new DataTable();
        Conexion Peliculas = new Conexion();
        public PeliculaDAO(Conexion c) //DataAdapter
        {
            Peliculas = c;
        }
        /*
        PeliculaDAO() //DataAdapter
        {
            
        }
        PeliculaDAO(string u, string c) //DataAdapter
        {
            Peliculas = new conexion( u, c);
        }
        */
        public DataTable DatosPeli(int id)
        {
            dt = new DataTable();
            MySqlConnection Mc = Peliculas.conex;
            MySqlDataAdapter DA = new MySqlDataAdapter("Select id_pelicula, id_estudio, id_director, nombre, fecha_estreno, fecha_creacion, Duracion, genero, presupuesto, calificacion, Programa_stilo, descripcion, portada , poster from peliculas where id_pelicula=" + id, Mc);
            DA.Fill(dt);
            Mc.Close();
            return dt;
        }

        public PeliculaCE DatosPeli(string id)
        {
            dt = DatosPeli(int.Parse(id));
            PeliculaCE peli = new PeliculaCE
            {
                idStudio = 1,
                IdPelicula = int.Parse(dt.Rows[0]["id_pelicula"].ToString()),
                Nombre = dt.Rows[0]["nombre"].ToString(),
                director = int.Parse(dt.Rows[0]["id_director"].ToString()),
                FechaCreacion = DateTime.Parse(dt.Rows[0]["fecha_Creacion"].ToString()),
                FechaEstreno = DateTime.Parse(dt.Rows[0]["fecha_Estreno"].ToString()),
                Duracion = dt.Rows[0]["Duracion"].ToString(),
                Genero = dt.Rows[0]["genero"].ToString(),
                Presupuesto = int.Parse(dt.Rows[0]["Presupuesto"].ToString()),
                Calificacion = dt.Rows[0]["Calificacion"].ToString(),
                ProgramaEstilo = dt.Rows[0]["Programa_stilo"].ToString(),
                descripcion = dt.Rows[0]["descripcion"].ToString(),
                poster = (byte[])dt.Rows[0]["poster"]
            };

            return peli;
        }


        public DataTable ListaPeli()
        {
            dt = new DataTable();
            MySqlConnection Mc = Peliculas.conex;
            MySqlDataAdapter DA = new MySqlDataAdapter("Select id_pelicula AS IDPelicula, nombre AS Nombre, genero AS Genero, calificacion AS Calificacion  from peliculas order by id_pelicula asc", Mc);
            DA.Fill(dt);
            Mc.Close();
            return dt;
        }
        public void AgregarPeli(PeliculaCE p)
        {
            // nos conectamos
            MySqlConnection cn = Peliculas.conex;
            //Creamos el cmd
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "agregarPL";
            cmd.CommandType = CommandType.StoredProcedure;
            //Agregamos los parametros
            //cmd.Parameters.Add("@",).Value=p;
            cmd.Parameters.Add("@unidpelicula",MySqlDbType.Int32).Value=p.IdPelicula;
            cmd.Parameters.Add("@unidestudio",MySqlDbType.Int32).Value = p.idStudio;
            cmd.Parameters.Add("@unidirector",MySqlDbType.Int32).Value = p.director;
            cmd.Parameters.Add("@unnombre",MySqlDbType.VarChar).Value = p.Nombre;
            cmd.Parameters.Add("@unfechaestreno",MySqlDbType.Date).Value = p.FechaEstreno;
            cmd.Parameters.Add("@unfechacreacion",MySqlDbType.Date).Value = p.FechaCreacion;
            cmd.Parameters.Add("@unDuracion",MySqlDbType.VarChar).Value = p.Duracion;
            cmd.Parameters.Add("@ungenero",MySqlDbType.VarChar).Value = p.Genero;
            cmd.Parameters.Add("@unpresupuesto",MySqlDbType.Double).Value = p.Presupuesto;
            cmd.Parameters.Add("@uncalificacion",MySqlDbType.VarChar).Value = p.Calificacion;
            cmd.Parameters.Add("@unprogramastilo",MySqlDbType.VarChar).Value = p.ProgramaEstilo;
            cmd.Parameters.Add("@undescripcion", MySqlDbType.VarChar).Value = p.descripcion;
            cmd.Parameters.Add("@unposter", MySqlDbType.LongBlob).Value = p.poster;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ModificarPeli(PeliculaCE p)
        {
            // nos conectamos
            MySqlConnection cn = Peliculas.conex;
            //Creamos el cmd
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "ModificarPL";
            cmd.CommandType = CommandType.StoredProcedure;
            //Agregamos los parametros
            //cmd.Parameters.Add("@",).Value=p;
            cmd.Parameters.Add("@unidpelicula", MySqlDbType.Int32).Value = p.IdPelicula;
            cmd.Parameters.Add("@unidestudio", MySqlDbType.Int32).Value = p.idStudio;
            cmd.Parameters.Add("@unidirector", MySqlDbType.Int32).Value = p.director;
            cmd.Parameters.Add("@unnombre", MySqlDbType.VarChar).Value = p.Nombre;
            cmd.Parameters.Add("@unfechaestreno", MySqlDbType.Date).Value = p.FechaEstreno;
            cmd.Parameters.Add("@unfechacreacion", MySqlDbType.Date).Value = p.FechaCreacion;
            cmd.Parameters.Add("@unDuracion", MySqlDbType.VarChar).Value = p.Duracion;
            cmd.Parameters.Add("@ungenero", MySqlDbType.VarChar).Value = p.Genero;
            cmd.Parameters.Add("@unpresupuesto", MySqlDbType.Double).Value = p.Presupuesto;
            cmd.Parameters.Add("@uncalificacion", MySqlDbType.VarChar).Value = p.Calificacion;
            cmd.Parameters.Add("@unprogramastilo", MySqlDbType.VarChar).Value = p.ProgramaEstilo;
            cmd.Parameters.Add("@undescripcion", MySqlDbType.VarChar).Value = p.descripcion;
            cmd.Parameters.Add("@unposter", MySqlDbType.LongBlob).Value = p.poster;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int CantP()
        {
            dt = new DataTable();
            int p = 0;
            MySqlConnection Mc = Peliculas.conex;
            MySqlDataAdapter DA = new MySqlDataAdapter("Select id_pelicula AS IDPelicula, nombre AS Nombre from peliculas", Mc);
            DA.Fill(dt);
            p= dt.Rows.Count;
            return p;
        }
        
        public void EliminarPeli(int ID)
        {
            // nos conectamos
            MySqlConnection cn = Peliculas.conex;
            //Creamos el cmd
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "eliminarP";
            cmd.CommandType = CommandType.StoredProcedure;
            //Agregamos los parametros
            //cmd.Parameters.Add("@",).Value=p;
            cmd.Parameters.Add("@unidpelicula", MySqlDbType.Int32).Value = ID;
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            cmd.Connection.Close();
        }
    }
}
