using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BancoPessoa.Model
{
    public class PessoaFisica : Pessoa
    {
        public int id { get; set; }

        public string cpf { get; set; }

        public string nome { get; set; }

        public string sobrenome { get; set; }

        public DateTime dataNascimento { get; set; }

        public Endereco endereco { get; set; }
    }
}
