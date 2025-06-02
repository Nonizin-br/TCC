using System.Net.Http;
using System.Runtime.CompilerServices;

namespace conta_tcc
{
    public partial class Welcome : Form
    {
        HttpClient _client;
        public Welcome(HttpClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro(_client);
            cadastro.ShowDialog();
            cadastro = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            login = null;
            this.Show();
        }
    }
}
