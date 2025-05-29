namespace conta_tcc
{
    partial class EditAccount
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
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(347, 52);
            label1.Name = "label1";
            label1.Size = new Size(190, 46);
            label1.TabIndex = 1;
            label1.Text = "Editar Perfil";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(217, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 246);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(19, 39);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(19, 97);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "E-mail";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(22, 156);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ex;
            pictureBox1.Location = new Point(259, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(255, 186);
            label7.Name = "label7";
            label7.Size = new Size(163, 23);
            label7.TabIndex = 16;
            label7.Text = "Mudar foto de perfil";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Location = new Point(387, 388);
            button1.Name = "button1";
            button1.Size = new Size(107, 37);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
    }
}