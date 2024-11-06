namespace studio5_8
{
    partial class Inicioo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(175, 263);
            button1.Name = "button1";
            button1.Size = new Size(240, 23);
            button1.TabIndex = 0;
            button1.Text = "Conectar a MysSql";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(254, 250, 224);
            label1.Location = new Point(266, 102);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 238, 215);
            textBox1.Location = new Point(218, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "root";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(254, 250, 224);
            label2.Location = new Point(257, 187);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(242, 238, 215);
            textBox2.Location = new Point(218, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(121, 134, 69);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(297, 262);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 57);
            label3.Name = "label3";
            label3.Size = new Size(152, 35);
            label3.TabIndex = 6;
            label3.Text = "Inicia Sesion";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icono;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Inicioo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 238, 152);
            ClientSize = new Size(589, 325);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Inicioo";
            Text = "Iniciar Secion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
