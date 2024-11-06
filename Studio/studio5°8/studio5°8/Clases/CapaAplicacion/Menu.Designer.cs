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
            dataGridView1 = new DataGridView();
            NuevaPeli = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            info = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(121, 134, 69);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(601, 280);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NuevaPeli
            // 
            NuevaPeli.Location = new Point(159, 389);
            NuevaPeli.Name = "NuevaPeli";
            NuevaPeli.Size = new Size(98, 49);
            NuevaPeli.TabIndex = 1;
            NuevaPeli.Text = "Agregar";
            NuevaPeli.UseVisualStyleBackColor = true;
            NuevaPeli.Click += NuevaPeli_Click;
            // 
            // button1
            // 
            button1.Location = new Point(535, 389);
            button1.Name = "button1";
            button1.Size = new Size(116, 49);
            button1.TabIndex = 2;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 74);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 238, 215);
            textBox1.Location = new Point(456, 74);
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
            label1.Location = new Point(255, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 37);
            label1.TabIndex = 5;
            label1.Text = "Menu Peliculas GHIBLI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 78);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // info
            // 
            info.Location = new Point(358, 389);
            info.Name = "info";
            info.Size = new Size(105, 49);
            info.TabIndex = 7;
            info.Text = "Informacion";
            info.UseVisualStyleBackColor = true;
            info.Visible = false;
            info.Click += info_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 234, 152);
            ClientSize = new Size(800, 450);
            Controls.Add(info);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NuevaPeli);
            Controls.Add(dataGridView1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}