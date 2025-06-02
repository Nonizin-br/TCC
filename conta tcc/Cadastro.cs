using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace conta_tcc
{
    public partial class Cadastro : Form
    {
        HttpClient _client;
        public Cadastro(HttpClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {

                Dictionary<String, String> data = new Dictionary<String, String>()
                {
                    {"usuario", textBox1.Text},
                    {"senha", textBox3.Text},
                };

                FormUrlEncodedContent form = new FormUrlEncodedContent(data);

                var response = await _client.PostAsync("http://localhost/tcc/cadastro.php", form);

                var responseString = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<jsonData>(responseString);
                if (json.sucesso)
                {
                    Program.loadHome();
                }
            }
        }
    }
}
