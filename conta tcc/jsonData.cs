using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_tcc
{
    public  class jsonData
    {
        public bool sucesso {  get; set; }
        public string mensagem { get; set; }

        public Dictionary<String, String> data { get; set; }
    }
}
