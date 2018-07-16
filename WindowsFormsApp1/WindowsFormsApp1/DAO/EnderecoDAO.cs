using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    class EnderecoDAO
    {
        public int cadastrarEndereco(Endereco endereco)
        {
            DataTable dt = new DataTable();
            int id = 0;
            try
            {
                using (NpgsqlConnection conexao = FabricaConexao.getConexao())
                {
                    conexao.Open();

                    string cmdInserir = String.Format("Insert into endereco(cep,logradouro,numero,complemento,bairro,cidade,uf) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}') returning id", endereco.cep, endereco.logradouro, endereco.numero, endereco.complemento, endereco.bairro,endereco.cidade,endereco.uf);
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdInserir, conexao))
                    {
                        Adpt.Fill(dt);
                        id = Convert.ToInt32(dt.Rows[0]["id"].ToString());
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
            return id;
        }
    }
}
