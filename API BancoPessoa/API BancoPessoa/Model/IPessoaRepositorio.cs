using API_BancoPessoa.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_BancoPessoa.Model
{
    interface IPessoaRepositorio
    {
        IEnumerable<PessoaFisica> GetAllPessoaFisica();
        IEnumerable<PessoaJuridica> GetAllPessoaJuridica();
        IEnumerable<Pessoa> GetAll();
    }
}
