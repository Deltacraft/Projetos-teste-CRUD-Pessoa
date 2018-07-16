using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Util
{
    static class Validador
    {
        public static bool validarEndereco(Endereco endereco,bool tudoValido)
        {
            if (endereco.cep == "") tudoValido = false;
            if (endereco.logradouro == "") tudoValido = false;
            if (endereco.numero == 0) tudoValido = false;
            if (endereco.bairro == "") tudoValido = false;
            if (endereco.cidade == "") tudoValido = false;
            if (endereco.uf == "") tudoValido = false;
            return tudoValido;
        }

        public static bool validarPessoa(PessoaFisica pessoaFisica,bool tudoValido)
        {
            if (pessoaFisica.cpf == "") tudoValido = false;
            if (pessoaFisica.nome == "") tudoValido = false;
            if (pessoaFisica.sobrenome == "") tudoValido = false;
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - pessoaFisica.dataNascimento.Year;
            if (pessoaFisica.dataNascimento > dataAtual.AddYears(-idade)) idade--;
            if (idade < 19) tudoValido = false;
            return tudoValido;
        }
        
        public static bool validarPessoa(PessoaJuridica pessoaJuridica,bool tudoValido)
        {
            if (pessoaJuridica.cnpj == "") tudoValido = false;
            if (pessoaJuridica.razaoSocial == "") tudoValido = false;
            if (pessoaJuridica.nomeFantasia == "") tudoValido = false;
            return tudoValido;
        }
    }
}
