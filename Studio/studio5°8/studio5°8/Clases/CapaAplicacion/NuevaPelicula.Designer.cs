﻿namespace studio5_8
{
    partial class NuevaPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaPelicula));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            label12 = new Label();
            label13 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            diaE = new ComboBox();
            mesE = new ComboBox();
            anioE = new ComboBox();
            diaC = new ComboBox();
            mesC = new ComboBox();
            AñoC = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            direc = new ComboBox();
            textBox2 = new TextBox();
            label14 = new Label();
            button3 = new Button();
            Imagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Imagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(112, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 214);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 2;
            label2.Text = "ID DIRECTOR:";
            label2.Click += label2_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(97, 118, 142);
            linkLabel1.Font = new Font("Calibri", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(302, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(252, 40);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "NUEVA PELICULA";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(444, 130);
            label3.Name = "label3";
            label3.Size = new Size(110, 14);
            label3.TabIndex = 5;
            label3.Text = "FECHA DE ESTRENO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(445, 93);
            label4.Name = "label4";
            label4.Size = new Size(115, 14);
            label4.TabIndex = 6;
            label4.Text = "FECHA DE CREACION:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 161);
            label5.Name = "label5";
            label5.Size = new Size(66, 14);
            label5.TabIndex = 9;
            label5.Text = "DURACIÓN:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 126);
            label6.Name = "label6";
            label6.Size = new Size(53, 14);
            label6.TabIndex = 11;
            label6.Text = "GENERO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(217, 126);
            label7.Name = "label7";
            label7.Size = new Size(83, 14);
            label7.TabIndex = 13;
            label7.Text = "PRESUPUESTO:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(224, 224, 224);
            textBox7.Location = new Point(311, 123);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(84, 23);
            textBox7.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(221, 160);
            label8.Name = "label8";
            label8.Size = new Size(81, 14);
            label8.TabIndex = 16;
            label8.Text = "CALIFICACIÓN:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(444, 166);
            label9.Name = "label9";
            label9.Size = new Size(108, 14);
            label9.TabIndex = 18;
            label9.Text = "PROGRAMA ESTILO:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(44, 73, 104);
            label10.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(585, 70);
            label10.Name = "label10";
            label10.Size = new Size(119, 14);
            label10.TabIndex = 25;
            label10.Text = "Dia    /   Mes   /   Año";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(371, 161);
            label11.Name = "label11";
            label11.Size = new Size(24, 14);
            label11.TabIndex = 27;
            label11.Text = "/10";
            label11.Click += label11_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(652, 296);
            button1.Name = "button1";
            button1.Size = new Size(136, 58);
            button1.TabIndex = 20;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(652, 380);
            button2.Name = "button2";
            button2.Size = new Size(136, 58);
            button2.TabIndex = 26;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(44, 73, 104);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 67);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(368, 178);
            dataGridView2.TabIndex = 28;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(44, 73, 104);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(435, 67);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(314, 131);
            dataGridView3.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(120, 183);
            label12.Name = "label12";
            label12.Size = new Size(32, 14);
            label12.TabIndex = 31;
            label12.Text = "hora";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(173, 183);
            label13.Name = "label13";
            label13.Size = new Size(28, 14);
            label13.TabIndex = 32;
            label13.Text = "min";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.BackColor = Color.FromArgb(224, 224, 224);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(316, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(47, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Aventuras", "Comedia", "Accion", "Drama", "Fantasia", "Suspenso", "Terror" });
            comboBox2.BackColor = Color.FromArgb(224, 224, 224);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Aventuras", "Comedia", "Accion", "Drama", "Fantasia", "Suspenso", "Terror" });
            comboBox2.Location = new Point(112, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(81, 23);
            comboBox2.TabIndex = 33;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // diaE
            // 
            diaE.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            diaE.BackColor = Color.FromArgb(224, 224, 224);
            diaE.FormattingEnabled = true;
            diaE.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            diaE.Location = new Point(565, 126);
            diaE.Name = "diaE";
            diaE.Size = new Size(42, 23);
            diaE.TabIndex = 34;
            // 
            // mesE
            // 
            mesE.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            mesE.BackColor = Color.FromArgb(224, 224, 224);
            mesE.FormattingEnabled = true;
            mesE.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            mesE.Location = new Point(622, 126);
            mesE.Name = "mesE";
            mesE.Size = new Size(42, 23);
            mesE.TabIndex = 35;
            // 
            // anioE
            // 
            anioE.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            anioE.BackColor = Color.FromArgb(224, 224, 224);
            anioE.FormattingEnabled = true;
            anioE.Items.AddRange(new object[] { "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            anioE.Location = new Point(680, 126);
            anioE.Name = "anioE";
            anioE.Size = new Size(56, 23);
            anioE.TabIndex = 36;
            anioE.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // diaC
            // 
            diaC.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            diaC.BackColor = Color.FromArgb(224, 224, 224);
            diaC.FormattingEnabled = true;
            diaC.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            diaC.Location = new Point(565, 89);
            diaC.Name = "diaC";
            diaC.Size = new Size(42, 23);
            diaC.TabIndex = 37;
            // 
            // mesC
            // 
            mesC.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            mesC.BackColor = Color.FromArgb(224, 224, 224);
            mesC.FormattingEnabled = true;
            mesC.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            mesC.Location = new Point(622, 89);
            mesC.Name = "mesC";
            mesC.Size = new Size(42, 23);
            mesC.TabIndex = 38;
            // 
            // AñoC
            // 
            AñoC.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            AñoC.BackColor = Color.FromArgb(224, 224, 224);
            AñoC.FormattingEnabled = true;
            AñoC.Items.AddRange(new object[] { "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            AñoC.Location = new Point(680, 89);
            AñoC.Name = "AñoC";
            AñoC.Size = new Size(56, 23);
            AñoC.TabIndex = 39;
            AñoC.SelectedIndexChanged += comboBox5_SelectedIndexChanged_1;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(224, 224, 224);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            comboBox3.Location = new Point(118, 157);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(36, 23);
            comboBox3.TabIndex = 40;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.FromArgb(224, 224, 224);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox4.Location = new Point(169, 157);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(36, 23);
            comboBox4.TabIndex = 41;
            // 
            // comboBox5
            // 
            comboBox5.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox5.BackColor = Color.FromArgb(224, 224, 224);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "2d", "3d" });
            comboBox5.Location = new Point(565, 162);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(70, 23);
            comboBox5.TabIndex = 42;
            // 
            // direc
            // 
            direc.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            direc.BackColor = Color.FromArgb(224, 224, 224);
            direc.FormattingEnabled = true;
            direc.Items.AddRange(new object[] { "Hayao Miyazaki", "Isao Takahata", "Hiromasa Yonebayashi", "Gorō Miyazaki", "Hiroyuki Morita", "Tomomi Mochizuki", "Yoshifumi Kondo" });
            direc.Location = new Point(136, 211);
            direc.Name = "direc";
            direc.Size = new Size(136, 23);
            direc.TabIndex = 43;
            direc.SelectedIndexChanged += direc_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(125, 145, 166);
            textBox2.Location = new Point(132, 251);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 153);
            textBox2.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(48, 264);
            label14.Name = "label14";
            label14.Size = new Size(79, 14);
            label14.TabIndex = 45;
            label14.Text = "DESCRIPCION:";
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(414, 207);
            button3.Name = "button3";
            button3.Size = new Size(75, 38);
            button3.TabIndex = 46;
            button3.Text = "Cargar poster:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Imagen
            // 
            Imagen.BackColor = Color.FromArgb(125, 145, 166);
            Imagen.Location = new Point(495, 204);
            Imagen.Name = "Imagen";
            Imagen.Size = new Size(151, 205);
            Imagen.SizeMode = PictureBoxSizeMode.Zoom;
            Imagen.TabIndex = 47;
            Imagen.TabStop = false;
            // 
            // NuevaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 118, 142);
            ClientSize = new Size(800, 450);
            Controls.Add(Imagen);
            Controls.Add(button3);
            Controls.Add(label14);
            Controls.Add(textBox2);
            Controls.Add(direc);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(AñoC);
            Controls.Add(mesC);
            Controls.Add(diaC);
            Controls.Add(anioE);
            Controls.Add(mesE);
            Controls.Add(diaE);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevaPelicula";
            Text = "nueva Peli";
            Load += NuevaPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label12;
        private Label label13;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox diaE;
        private ComboBox mesE;
        private ComboBox anioE;
        private ComboBox diaC;
        private ComboBox mesC;
        private ComboBox AñoC;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox direc;
        private TextBox textBox2;
        private Label label14;
        private Button button3;
        private PictureBox Imagen;
    }
}