namespace conta_tcc
{
    partial class Cadastro
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
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(183, 20);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(209, 79);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(218, 149);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(218, 223);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 27);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(190, 294);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 8;
            label5.Text = "Confirmar Senha";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 27);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(196, 360);
            button1.Name = "button1";
            button1.Size = new Size(99, 36);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(142, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 423);
            panel1.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Panel panel1;
    }
}