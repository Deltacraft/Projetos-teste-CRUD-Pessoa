using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PessoaJuridica
    {
        public int id{ get; set; }

        public string cnpj { get; set; }

        public string razaoSocial { get; set; }

        public string nomeFantasia { get; set; }

        public Endereco endereco { get; set; }
    }
}
