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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicioo));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(57, 237);
            button1.Name = "button1";
            button1.Size = new Size(240, 23);
            button1.TabIndex = 0;
            button1.Text = "Conectar a MysSql";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Calibri", 9F);
            label1.Location = new Point(148, 81);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(106, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "root";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Calibri", 9F);
            label2.Location = new Point(140, 161);
            label2.Name = "label2";
            label2.Size = new Size(76, 14);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(106, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(44, 73, 104);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(297, 262);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(44, 73, 104);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Calibri", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 27);
            label3.Name = "label3";
            label3.Size = new Size(205, 42);
            label3.TabIndex = 6;
            label3.Text = "INICIA SESIÓN";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.totoro;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(589, 325);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Inicioo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 238, 152);
            ClientSize = new Size(589, 325);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicioo";
            Text = "Iniciar Secion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}
