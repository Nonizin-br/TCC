namespace conta_tcc
{
    partial class Welcome
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
            cadastroButton = new Button();
            loginButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cadastroButton
            // 
            cadastroButton.BackColor = Color.Khaki;
            cadastroButton.ForeColor = SystemColors.ControlText;
            cadastroButton.Location = new Point(51, 175);
            cadastroButton.Name = "cadastroButton";
            cadastroButton.Size = new Size(161, 41);
            cadastroButton.TabIndex = 0;
            cadastroButton.Text = "Cadastrar";
            cadastroButton.UseVisualStyleBackColor = false;
            cadastroButton.Click += button1_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Khaki;
            loginButton.Location = new Point(240, 175);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(161, 41);
            loginButton.TabIndex = 1;
            loginButton.Text = "Logar";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(122, 52);
            label1.Name = "label1";
            label1.Size = new Size(212, 50);
            label1.TabIndex = 2;
            label1.Text = "Bem Vindo!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(cadastroButton);
            panel1.Location = new Point(164, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 277);
            panel1.TabIndex = 3;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Welcome";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cadastroButton;
        private Button loginButton;
        private Label label1;
        private Panel panel1;
    }
}
