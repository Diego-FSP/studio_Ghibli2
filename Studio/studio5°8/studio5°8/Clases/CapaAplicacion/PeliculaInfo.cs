﻿using Directores;
using studio5_8.Clases.CapaDatos;
using studio5_8.Clases.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studio5_8.Clases.CapaAplicacion
{
    public partial class PeliculaInfo : Form
    {
        PeliculaCN peliculaN;
        DataTable info = new DataTable();
        public PeliculaInfo(Conexion conex, int f)
        {
            InitializeComponent();
            peliculaN = new PeliculaCN(conex);
            info = peliculaN.infoPeli(f);
            nombre.Text = info.Rows[0]["nombre"].ToString();
            duracion.Text += info.Rows[0]["duracion"].ToString();
            id.Text += info.Rows[0]["id_pelicula"].ToString();
            DirectorCN directorCN = new DirectorCN(conex);
            director.Text += directorCN.nombreD(int.Parse(info.Rows[0]["id_director"].ToString()));
            Descripcion.Text += info.Rows[0]["descripcion"].ToString();
            Genero.Text += info.Rows[0]["genero"].ToString();
            Poster.Image = Image.FromFile(info.Rows[0]["portada"].ToString());
            //portada
        }
    }
}
