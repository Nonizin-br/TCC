namespace conta_tcc
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            cadastro = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro login = new Cadastro();
            login.ShowDialog();
            login = null;
            this.Show();
        }
    }
}
