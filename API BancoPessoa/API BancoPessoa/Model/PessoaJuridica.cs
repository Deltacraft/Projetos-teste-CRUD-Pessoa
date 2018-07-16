using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BancoPessoa.Model
{
    public class PessoaJuridica : Pessoa
    {
        public int id { get; set; }

        public string cnpj { get; set; }

        public string razaoSocial { get; set; }

        public string nomeFantasia { get; set; }

        public Endereco endereco { get; set; }
    }
}
