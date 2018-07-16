using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API_BancoPessoa.Util;
using Npgsql;

namespace API_BancoPessoa.Model
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private List<PessoaFisica> pessoasFisicas = new List<PessoaFisica>();
        private List<PessoaJuridica> pessoasJuridicas = new List<PessoaJuridica>();
        private List<Pessoa> todasPessoas = new List<Pessoa>();

        public IEnumerable<PessoaFisica> GetAllPessoaFisica()
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdBuscar = String.Format("SELECT p.id,p.nome,p.sobrenome,p.datanascimento,p.cpf,e.cep,e.logradouro,e.numero,e.complemento,e.bairro,e.cidade,e.uf from pessoafisica as p inner join endereco as e on p.endereco=e.id");
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdBuscar, conexao))
                    {
                        Adpt.Fill(dt);
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
            pessoasFisicas = new List<PessoaFisica>();
            foreach (DataRow linha in dt.Rows)
            {
                PessoaFisica pessoa = new PessoaFisica();
                Endereco endereco = new Endereco();
                endereco.cep = linha[5].ToString();
                endereco.logradouro = linha[6].ToString();
                endereco.numero = Convert.ToInt32(linha[7].ToString());
                endereco.complemento = linha[8].ToString();
                endereco.bairro = linha[9].ToString();
                endereco.cidade = linha[10].ToString();
                endereco.uf = linha[11].ToString();
                pessoa.id = Convert.ToInt32(linha[0].ToString());
                pessoa.nome = linha[1].ToString();
                pessoa.sobrenome = linha[2].ToString();
                pessoa.dataNascimento = Convert.ToDateTime(linha[3].ToString());
                pessoa.cpf = linha[4].ToString();
                pessoa.endereco = endereco;
                pessoasFisicas.Add(pessoa);
            }
            return pessoasFisicas.AsEnumerable<PessoaFisica>();
        }

        public IEnumerable<PessoaJuridica> GetAllPessoaJuridica()
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdBuscar = String.Format("SELECT p.id,p.razaosocial,p.nomefantasia,p.cnpj,e.cep,e.logradouro,e.numero,e.complemento,e.bairro,e.cidade,e.uf from pessoajuridica as p inner join endereco as e on p.endereco=e.id");
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdBuscar, conexao))
                    {
                        Adpt.Fill(dt);
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
            pessoasFisicas = new List<PessoaFisica>();
            foreach (DataRow linha in dt.Rows)
            {
                PessoaJuridica pessoa = new PessoaJuridica();
                Endereco endereco = new Endereco();
                endereco.cep = linha[4].ToString();
                endereco.logradouro = linha[5].ToString();
                endereco.numero = Convert.ToInt32(linha[6].ToString());
                endereco.complemento = linha[7].ToString();
                endereco.bairro = linha[8].ToString();
                endereco.cidade = linha[9].ToString();
                endereco.uf = linha[10].ToString();
                pessoa.id = Convert.ToInt32(linha[0].ToString());
                pessoa.razaoSocial = linha[1].ToString();
                pessoa.nomeFantasia = linha[2].ToString();
                pessoa.cnpj = linha[3].ToString();
                pessoa.endereco = endereco;
                pessoasJuridicas.Add(pessoa);
            }
            return pessoasJuridicas.AsEnumerable<PessoaJuridica>();
        }


        public IEnumerable<Pessoa> GetAll()
        {
            DataTable dt = new DataTable();
            todasPessoas = new List<Pessoa>();
            try
            {
                using (NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdBuscar = String.Format("SELECT p.id,p.nome,p.sobrenome,p.datanascimento,p.cpf,e.cep,e.logradouro,e.numero,e.complemento,e.bairro,e.cidade,e.uf from pessoafisica as p inner join endereco as e on p.endereco=e.id");
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdBuscar, conexao))
                    {
                        Adpt.Fill(dt);
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
            pessoasFisicas = new List<PessoaFisica>();
            foreach (DataRow linha in dt.Rows)
            {
                PessoaFisica pessoa = new PessoaFisica();
                Endereco endereco = new Endereco();
                endereco.cep = linha[5].ToString();
                endereco.logradouro = linha[6].ToString();
                endereco.numero = Convert.ToInt32(linha[7].ToString());
                endereco.complemento = linha[8].ToString();
                endereco.bairro = linha[9].ToString();
                endereco.cidade = linha[10].ToString();
                endereco.uf = linha[11].ToString();
                pessoa.id = Convert.ToInt32(linha[0].ToString());
                pessoa.nome = linha[1].ToString();
                pessoa.sobrenome = linha[2].ToString();
                pessoa.dataNascimento = Convert.ToDateTime(linha[3].ToString());
                pessoa.cpf = linha[4].ToString();
                pessoa.endereco = endereco;
                todasPessoas.Add(pessoa);
            }

            dt = new DataTable();
            try
            {
                using (NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdBuscar = String.Format("SELECT p.id,p.razaosocial,p.nomefantasia,p.cnpj,e.cep,e.logradouro,e.numero,e.complemento,e.bairro,e.cidade,e.uf from pessoajuridica as p inner join endereco as e on p.endereco=e.id");
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdBuscar, conexao))
                    {
                        Adpt.Fill(dt);
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
            pessoasJuridicas = new List<PessoaJuridica>();
            foreach (DataRow linha in dt.Rows)
            {
                PessoaJuridica pessoa = new PessoaJuridica();
                Endereco endereco = new Endereco();
                endereco.cep = linha[4].ToString();
                endereco.logradouro = linha[5].ToString();
                endereco.numero = Convert.ToInt32(linha[6].ToString());
                endereco.complemento = linha[7].ToString();
                endereco.bairro = linha[8].ToString();
                endereco.cidade = linha[9].ToString();
                endereco.uf = linha[10].ToString();
                pessoa.id = Convert.ToInt32(linha[0].ToString());
                pessoa.razaoSocial = linha[1].ToString();
                pessoa.nomeFantasia = linha[2].ToString();
                pessoa.cnpj = linha[3].ToString();
                pessoa.endereco = endereco;
                todasPessoas.Add(pessoa);
            }
            return todasPessoas.AsEnumerable<Pessoa>();
        }
    }
}