using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    class PessoaDAO
    {
        

        public PessoaDAO(){
            
        }

        public void cadastrarPessoa(PessoaFisica pessoa)
        {
            try
            {
                using(NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdInserir = String.Format("Insert into pessoaFisica(nome,sobrenome,cpf,dataNascimento,endereco) values('{0}','{1}','{2}','{3}',{4})",pessoa.nome,pessoa.sobrenome,pessoa.cpf,pessoa.dataNascimento,pessoa.endereco.id);
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, conexao))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                    conexao.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cadastrarPessoa(PessoaJuridica pessoa)
        {
            try
            {
                using (NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdInserir = String.Format("Insert into pessoaJuridica(cnpj,razaosocial,nomefantasia,endereco) values('{0}','{1}','{2}',{3})", pessoa.cnpj, pessoa.razaoSocial, pessoa.nomeFantasia, pessoa.endereco.id);
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, conexao))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                    conexao.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
