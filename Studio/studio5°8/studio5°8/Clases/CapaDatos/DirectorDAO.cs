﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Peli;

namespace studio5_8.Clases.CapaDatos
{
    internal class DirectorDAO
    {
        DataTable dt = new DataTable();
        Conexion Directores = new Conexion();
        public DirectorDAO(Conexion c) //DataAdapter
        {
            Directores = c;
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
        public DataTable ListaDirec()
        {
            dt = new DataTable();
            MySqlConnection Mc = Directores.conex;
            MySqlDataAdapter DA = new MySqlDataAdapter("Select concat(nombre,' ',Apellido) AS Director  from Director order by id_Director asc", Mc);
            DA.Fill(dt);
            Mc.Close();
            return dt;
        }
        public string Direc(int d)
        {
            dt = new DataTable();
            MySqlConnection Mc = Directores.conex;
            MySqlDataAdapter DA = new MySqlDataAdapter("Select concat(nombre,' ',Apellido) AS Director  from Director order by id_Director asc", Mc);
            DA.Fill(dt);
            Mc.Close();
            string nombre = dt.Rows[d - 1]["Director"].ToString();
            return nombre;
        }
        /*
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
            cmd.Parameters.Add("@ungenero",MySqlDbType.VarChar).Value = p.Duracion;
            cmd.Parameters.Add("@unpresupuesto",MySqlDbType.Double).Value = p.Presupuesto;
            cmd.Parameters.Add("@uncalificacion",MySqlDbType.VarChar).Value = p.Calificacion;
            cmd.Parameters.Add("@unprogramastilo",MySqlDbType.VarChar).Value = p.ProgramaEstilo;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
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
            }
            catch (Exception)
            {
                throw;
            }
            cmd.Connection.Close();
        }
        */
    }
}
