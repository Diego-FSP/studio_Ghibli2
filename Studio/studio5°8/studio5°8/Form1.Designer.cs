namespace studio5_8
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 116);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "ID Director:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(310, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(190, 37);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Nueva Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 70);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de Estreno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 107);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Creacion:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(582, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(582, 104);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(76, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 163);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Duracion:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(536, 160);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(76, 23);
            textBox5.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
    }
}