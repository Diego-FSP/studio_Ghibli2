namespace studio5_8
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            dataGridView1 = new DataGridView();
            NuevaPeli = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            info = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(44, 73, 104);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(137, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(601, 184);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NuevaPeli
            // 
            NuevaPeli.ForeColor = Color.FromArgb(64, 64, 64);
            NuevaPeli.Location = new Point(137, 423);
            NuevaPeli.Name = "NuevaPeli";
            NuevaPeli.Size = new Size(98, 49);
            NuevaPeli.TabIndex = 1;
            NuevaPeli.Text = "Agregar";
            NuevaPeli.UseVisualStyleBackColor = true;
            NuevaPeli.Click += NuevaPeli_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(633, 423);
            button1.Name = "button1";
            button1.Size = new Size(105, 49);
            button1.TabIndex = 2;
            button1.Text = "Actualizar";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(338, 189);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(464, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(33, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 238, 215);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(293, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(97, 118, 142);
            label2.Location = new Point(437, 193);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // info
            // 
            info.ForeColor = Color.FromArgb(64, 64, 64);
            info.Location = new Point(376, 423);
            info.Name = "info";
            info.Size = new Size(105, 49);
            info.TabIndex = 7;
            info.Text = "Informacion";
            info.UseVisualStyleBackColor = true;
            info.Visible = false;
            info.Click += info_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(44, 73, 104);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(855, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 9);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(44, 73, 104);
            label4.Font = new Font("Arial", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(323, 46);
            label4.Name = "label4";
            label4.Size = new Size(195, 38);
            label4.TabIndex = 10;
            label4.Text = "スタジオジブリ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(44, 73, 104);
            label5.Font = new Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(311, 84);
            label5.Name = "label5";
            label5.Size = new Size(223, 40);
            label5.TabIndex = 11;
            label5.Text = "STUDIO GHIBLI";
            // 
            // button3
            // 
            button3.Location = new Point(762, 476);
            button3.Name = "button3";
            button3.Size = new Size(105, 36);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 118, 142);
            ClientSize = new Size(879, 524);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(info);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NuevaPeli);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button NuevaPeli;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button info;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}