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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeliculaInfo));
            nombre = new Label();
            id = new Label();
            director = new Label();
            duracion = new Label();
            Descripcion = new Button();
            Genero = new Label();
            trama = new Label();
            Poster = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Poster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Calibri", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombre.ForeColor = SystemColors.ButtonFace;
            nombre.Location = new Point(252, 9);
            nombre.Name = "nombre";
            nombre.RightToLeft = RightToLeft.Yes;
            nombre.Size = new Size(317, 40);
            nombre.TabIndex = 0;
            nombre.Text = "NOMBRE DE PELICULA";
            nombre.TextAlign = ContentAlignment.TopCenter;
            nombre.Click += nombre_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.FromArgb(97, 118, 142);
            id.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(12, 9);
            id.Name = "id";
            id.Size = new Size(41, 26);
            id.TabIndex = 1;
            id.Text = "ID: ";
            // 
            // director
            // 
            director.AutoSize = true;
            director.BackColor = Color.Gainsboro;
            director.Font = new Font("Calibri", 9F);
            director.ImageAlign = ContentAlignment.TopLeft;
            director.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            director.Location = new Point(90, 87);
            director.Name = "director";
            director.Size = new Size(62, 14);
            director.TabIndex = 2;
            director.Text = "DIRECTOR:";
            director.TextAlign = ContentAlignment.TopCenter;
            // 
            // duracion
            // 
            duracion.AutoSize = true;
            duracion.BackColor = Color.Gainsboro;
            duracion.Font = new Font("Calibri", 9F);
            duracion.ImageAlign = ContentAlignment.TopLeft;
            duracion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            duracion.Location = new Point(90, 122);
            duracion.Name = "duracion";
            duracion.Size = new Size(66, 14);
            duracion.TabIndex = 3;
            duracion.Text = "DURACIÓN:";
            duracion.TextAlign = ContentAlignment.TopCenter;
            // 
            // Descripcion
            // 
            Descripcion.BackColor = Color.FromArgb(125, 145, 166);
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
            Genero.BackColor = Color.Gainsboro;
            Genero.Font = new Font("Calibri", 9F);
            Genero.ImageAlign = ContentAlignment.TopLeft;
            Genero.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            Genero.Location = new Point(90, 158);
            Genero.Name = "Genero";
            Genero.Size = new Size(53, 14);
            Genero.TabIndex = 5;
            Genero.Text = "GENERO:";
            Genero.TextAlign = ContentAlignment.TopCenter;
            // 
            // trama
            // 
            trama.AutoSize = true;
            trama.BackColor = Color.Gainsboro;
            trama.Font = new Font("Calibri", 9F);
            trama.ImageAlign = ContentAlignment.TopLeft;
            trama.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            trama.Location = new Point(12, 325);
            trama.Name = "trama";
            trama.Size = new Size(47, 14);
            trama.TabIndex = 6;
            trama.Text = "TRAMA:";
            trama.TextAlign = ContentAlignment.TopCenter;
            trama.Click += trama_Click;
            // 
            // Poster
            // 
            Poster.BackColor = Color.FromArgb(125, 145, 166);
            Poster.Location = new Point(409, 49);
            Poster.Name = "Poster";
            Poster.Size = new Size(274, 387);
            Poster.SizeMode = PictureBoxSizeMode.Zoom;
            Poster.TabIndex = 7;
            Poster.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 73, 104);
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
            label1.BackColor = Color.FromArgb(44, 73, 104);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
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
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Calibri", 9F);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(90, 191);
            label2.Name = "label2";
            label2.Size = new Size(113, 14);
            label2.TabIndex = 11;
            label2.Text = "FECHA DE ESTRENO: ";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Calibri", 9F);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(90, 224);
            label3.Name = "label3";
            label3.Size = new Size(118, 14);
            label3.TabIndex = 12;
            label3.Text = "FECHA DE CREACION: ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(701, 383);
            button2.Name = "button2";
            button2.Size = new Size(87, 39);
            button2.TabIndex = 13;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // PeliculaInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 118, 142);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Poster);
            Controls.Add(trama);
            Controls.Add(Genero);
            Controls.Add(Descripcion);
            Controls.Add(duracion);
            Controls.Add(director);
            Controls.Add(id);
            Controls.Add(nombre);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PeliculaInfo";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)Poster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private PictureBox pictureBox2;
    }
}