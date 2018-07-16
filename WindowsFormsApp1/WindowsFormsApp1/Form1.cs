using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Util;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConsultarCEP_Click(object sender, EventArgs e)
        {
            var ws = new WSCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(maskedTextBoxCEP.Text);
            textBoxLogradouro.Text = resposta.end;
            textBoxComplemento.Text = resposta.complemento;
            textBoxBairro.Text = resposta.bairro;
            textBoxCidade.Text = resposta.cidade;
            textBoxUF.Text = resposta.uf;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bool tudoValido = true;
            string tabSelecionada = tabControlPessoas.SelectedIndex.ToString();
            PessoaDAO pessoaDAO = new PessoaDAO();

            Endereco endereco = new Endereco();
            endereco.cep = maskedTextBoxCEP.Text;
            endereco.logradouro = textBoxLogradouro.Text;
            endereco.numero = Convert.ToInt32(textBoxNumero.Text);
            endereco.complemento = textBoxComplemento.Text;
            endereco.bairro = textBoxBairro.Text;
            endereco.cidade = textBoxCidade.Text;
            endereco.uf = textBoxUF.Text;
            tudoValido = Validador.validarEndereco(endereco,tudoValido);
            if (tabSelecionada=="0")
            {
                PessoaFisica pessoaFisica = new PessoaFisica();
                pessoaFisica.cpf = maskedTextBoxCPF.Text;
                pessoaFisica.nome = textBoxNome.Text;
                pessoaFisica.sobrenome = textBoxSobrenome.Text;
                pessoaFisica.dataNascimento = dateTimePickerDataNascimento.Value;

                DateTime dataAtual = DateTime.Now;
                int idade = dataAtual.Year - pessoaFisica.dataNascimento.Year;
                if (pessoaFisica.dataNascimento > dataAtual.AddYears(-idade)) idade--;
                if (idade < 19)
                {
                    MessageBox.Show("Uma pessoa fisica só pode se cadastrar\n se tiver mais de 19 anos");
                }

                tudoValido = Validador.validarPessoa(pessoaFisica, tudoValido);
                if (tudoValido)
                {
                    try
                    {
                        EnderecoDAO enderecoDAO = new EnderecoDAO();
                        endereco.id = enderecoDAO.cadastrarEndereco(endereco);
                        pessoaFisica.endereco = endereco;
                        pessoaDAO.cadastrarPessoa(pessoaFisica);
                        MessageBox.Show("Pessoa fisica cadastrada com sucesso!");
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar cadastrar!" + ex.Message);
                    }
                }
            }
            else
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                pessoaJuridica.cnpj = maskedTextBoxCNPJ.Text;
                pessoaJuridica.razaoSocial = textBoxRazaoSocial.Text;
                pessoaJuridica.nomeFantasia = textBoxNomeFantasia.Text;
                tudoValido = Validador.validarPessoa(pessoaJuridica,tudoValido);
                if (tudoValido)
                {
                    EnderecoDAO enderecoDAO = new EnderecoDAO();
                    try
                    {
                        endereco.id = enderecoDAO.cadastrarEndereco(endereco);
                        pessoaJuridica.endereco = endereco;
                        pessoaDAO.cadastrarPessoa(pessoaJuridica);
                        MessageBox.Show("Pessoa juridica cadastrada com sucesso!");
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar cadastrar!"+ex.Message);
                    }
                }
            }
        }
    }
}
