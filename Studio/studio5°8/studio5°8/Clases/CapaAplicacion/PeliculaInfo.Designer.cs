namespace studio5_8.Clases.CapaAplicacion
{
    partial class PeliculaInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombre = new Label();
            id = new Label();
            director = new Label();
            duracion = new Label();
            Descripcion = new Button();
            Genero = new Label();
            trama = new Label();
            Poster = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Poster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombre.Location = new Point(270, 9);
            nombre.Name = "nombre";
            nombre.Size = new Size(274, 37);
            nombre.TabIndex = 0;
            nombre.Text = "nombre de la pelicula";
            nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(12, 9);
            id.Name = "id";
            id.Size = new Size(45, 30);
            id.TabIndex = 1;
            id.Text = "ID: ";
            // 
            // director
            // 
            director.AutoSize = true;
            director.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            director.Location = new Point(12, 91);
            director.Name = "director";
            director.Size = new Size(73, 21);
            director.TabIndex = 2;
            director.Text = "Director: ";
            // 
            // duracion
            // 
            duracion.AutoSize = true;
            duracion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duracion.Location = new Point(12, 131);
            duracion.Name = "duracion";
            duracion.Size = new Size(80, 21);
            duracion.TabIndex = 3;
            duracion.Text = "Duración: ";
            // 
            // Descripcion
            // 
            Descripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descripcion.Location = new Point(78, 247);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(322, 176);
            Descripcion.TabIndex = 4;
            Descripcion.UseVisualStyleBackColor = false;
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Font = new Font("Segoe UI", 12F);
            Genero.Location = new Point(12, 171);
            Genero.Name = "Genero";
            Genero.Size = new Size(68, 21);
            Genero.TabIndex = 5;
            Genero.Text = "Genero: ";
            // 
            // trama
            // 
            trama.AutoSize = true;
            trama.Font = new Font("Segoe UI", 12F);
            trama.Location = new Point(12, 247);
            trama.Name = "trama";
            trama.Size = new Size(60, 21);
            trama.TabIndex = 6;
            trama.Text = "Trama: ";
            // 
            // Poster
            // 
            Poster.Location = new Point(422, 61);
            Poster.Name = "Poster";
            Poster.Size = new Size(274, 362);
            Poster.SizeMode = PictureBoxSizeMode.Zoom;
            Poster.TabIndex = 7;
            Poster.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icono;
            pictureBox1.Location = new Point(721, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // PeliculaInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Poster);
            Controls.Add(trama);
            Controls.Add(Genero);
            Controls.Add(Descripcion);
            Controls.Add(duracion);
            Controls.Add(director);
            Controls.Add(id);
            Controls.Add(nombre);
            Name = "PeliculaInfo";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)Poster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombre;
        private Label id;
        private Label director;
        private Label duracion;
        private Button Descripcion;
        private Label Genero;
        private Label trama;
        private PictureBox Poster;
        private PictureBox pictureBox1;
    }
}