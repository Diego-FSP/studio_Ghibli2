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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Poster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombre.Location = new Point(275, 9);
            nombre.Name = "nombre";
            nombre.Size = new Size(274, 37);
            nombre.TabIndex = 0;
            nombre.Text = "nombre de la pelicula";
            nombre.TextAlign = ContentAlignment.TopCenter;
            nombre.Click += nombre_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.FromArgb(242, 238, 215);
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
            director.BackColor = Color.White;
            director.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            director.Location = new Point(90, 87);
            director.Name = "director";
            director.Size = new Size(73, 21);
            director.TabIndex = 2;
            director.Text = "Director: ";
            // 
            // duracion
            // 
            duracion.AutoSize = true;
            duracion.BackColor = Color.White;
            duracion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duracion.Location = new Point(90, 122);
            duracion.Name = "duracion";
            duracion.Size = new Size(80, 21);
            duracion.TabIndex = 3;
            duracion.Text = "Duración: ";
            // 
            // Descripcion
            // 
            Descripcion.BackColor = Color.FromArgb(242, 238, 215);
            Descripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descripcion.Location = new Point(78, 260);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(322, 176);
            Descripcion.TabIndex = 4;
            Descripcion.UseVisualStyleBackColor = false;
            Descripcion.Click += Descripcion_Click;
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.BackColor = Color.White;
            Genero.Font = new Font("Segoe UI", 12F);
            Genero.Location = new Point(90, 158);
            Genero.Name = "Genero";
            Genero.Size = new Size(68, 21);
            Genero.TabIndex = 5;
            Genero.Text = "Genero: ";
            // 
            // trama
            // 
            trama.AutoSize = true;
            trama.BackColor = Color.White;
            trama.Font = new Font("Segoe UI", 12F);
            trama.Location = new Point(12, 281);
            trama.Name = "trama";
            trama.Size = new Size(60, 21);
            trama.TabIndex = 6;
            trama.Text = "Trama: ";
            // 
            // Poster
            // 
            Poster.BackColor = Color.FromArgb(242, 238, 215);
            Poster.Location = new Point(409, 49);
            Poster.Name = "Poster";
            Poster.Size = new Size(274, 387);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 134, 69);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(78, 49);
            button1.Name = "button1";
            button1.Size = new Size(322, 205);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(121, 134, 69);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 54);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 10;
            label1.Text = "Informacion:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(90, 191);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 11;
            label2.Text = "Fecha de Estreno: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(90, 224);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 12;
            label3.Text = "Fecha de Creacion: ";
            // 
            // button2
            // 
            button2.Location = new Point(701, 383);
            button2.Name = "button2";
            button2.Size = new Size(87, 39);
            button2.TabIndex = 13;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PeliculaInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 238, 152);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Poster);
            Controls.Add(trama);
            Controls.Add(Genero);
            Controls.Add(Descripcion);
            Controls.Add(duracion);
            Controls.Add(director);
            Controls.Add(id);
            Controls.Add(nombre);
            Controls.Add(button1);
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}