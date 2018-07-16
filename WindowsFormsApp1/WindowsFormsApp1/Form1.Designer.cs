namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.tabControlPessoas = new System.Windows.Forms.TabControl();
            this.tabPagePessoaFisica = new System.Windows.Forms.TabPage();
            this.tabPagePessoaJuridica = new System.Windows.Forms.TabPage();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNomeFantasia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonConsultarCEP = new System.Windows.Forms.Button();
            this.tabControlPessoas.SuspendLayout();
            this.tabPagePessoaFisica.SuspendLayout();
            this.tabPagePessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sobrenome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(47, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(110, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(230, 37);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(100, 20);
            this.textBoxSobrenome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de nascimento";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(114, 63);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerDataNascimento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(47, 7);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxCPF.TabIndex = 1;
            // 
            // tabControlPessoas
            // 
            this.tabControlPessoas.Controls.Add(this.tabPagePessoaFisica);
            this.tabControlPessoas.Controls.Add(this.tabPagePessoaJuridica);
            this.tabControlPessoas.Location = new System.Drawing.Point(12, 12);
            this.tabControlPessoas.Name = "tabControlPessoas";
            this.tabControlPessoas.SelectedIndex = 0;
            this.tabControlPessoas.Size = new System.Drawing.Size(342, 126);
            this.tabControlPessoas.TabIndex = 9;
            // 
            // tabPagePessoaFisica
            // 
            this.tabPagePessoaFisica.Controls.Add(this.label4);
            this.tabPagePessoaFisica.Controls.Add(this.dateTimePickerDataNascimento);
            this.tabPagePessoaFisica.Controls.Add(this.maskedTextBoxCPF);
            this.tabPagePessoaFisica.Controls.Add(this.label3);
            this.tabPagePessoaFisica.Controls.Add(this.label1);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxSobrenome);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxNome);
            this.tabPagePessoaFisica.Controls.Add(this.label2);
            this.tabPagePessoaFisica.Location = new System.Drawing.Point(4, 22);
            this.tabPagePessoaFisica.Name = "tabPagePessoaFisica";
            this.tabPagePessoaFisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePessoaFisica.Size = new System.Drawing.Size(334, 100);
            this.tabPagePessoaFisica.TabIndex = 0;
            this.tabPagePessoaFisica.Text = "Pessoa Física";
            this.tabPagePessoaFisica.UseVisualStyleBackColor = true;
            // 
            // tabPagePessoaJuridica
            // 
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxNomeFantasia);
            this.tabPagePessoaJuridica.Controls.Add(this.label7);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxRazaoSocial);
            this.tabPagePessoaJuridica.Controls.Add(this.label6);
            this.tabPagePessoaJuridica.Controls.Add(this.maskedTextBoxCNPJ);
            this.tabPagePessoaJuridica.Controls.Add(this.label5);
            this.tabPagePessoaJuridica.Location = new System.Drawing.Point(4, 22);
            this.tabPagePessoaJuridica.Name = "tabPagePessoaJuridica";
            this.tabPagePessoaJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePessoaJuridica.Size = new System.Drawing.Size(334, 100);
            this.tabPagePessoaJuridica.TabIndex = 1;
            this.tabPagePessoaJuridica.Text = "Pessoa Jurídica";
            this.tabPagePessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(92, 6);
            this.maskedTextBoxCNPJ.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(106, 20);
            this.maskedTextBoxCNPJ.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Razão Social";
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(92, 37);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(236, 20);
            this.textBoxRazaoSocial.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome fantasia";
            // 
            // textBoxNomeFantasia
            // 
            this.textBoxNomeFantasia.Location = new System.Drawing.Point(92, 63);
            this.textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            this.textBoxNomeFantasia.Size = new System.Drawing.Size(236, 20);
            this.textBoxNomeFantasia.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(47, 151);
            this.maskedTextBoxCEP.Mask = "00000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxCEP.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Logradouro";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(80, 177);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(264, 20);
            this.textBoxLogradouro.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Número";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(63, 203);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(39, 20);
            this.textBoxNumero.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Complemento";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(185, 203);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(159, 20);
            this.textBoxComplemento.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(63, 229);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(139, 20);
            this.textBoxBairro.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(63, 255);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(139, 20);
            this.textBoxCidade.TabIndex = 21;
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(235, 255);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(100, 20);
            this.textBoxUF.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(208, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "UF";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(139, 293);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonConsultarCEP
            // 
            this.buttonConsultarCEP.Location = new System.Drawing.Point(121, 149);
            this.buttonConsultarCEP.Name = "buttonConsultarCEP";
            this.buttonConsultarCEP.Size = new System.Drawing.Size(98, 23);
            this.buttonConsultarCEP.TabIndex = 25;
            this.buttonConsultarCEP.Text = "Consultar CEP";
            this.buttonConsultarCEP.UseVisualStyleBackColor = true;
            this.buttonConsultarCEP.Click += new System.EventHandler(this.buttonConsultarCEP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 332);
            this.Controls.Add(this.buttonConsultarCEP);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxComplemento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxLogradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControlPessoas);
            this.Name = "Form1";
            this.Text = "Cadastrar Usuario";
            this.tabControlPessoas.ResumeLayout(false);
            this.tabPagePessoaFisica.ResumeLayout(false);
            this.tabPagePessoaFisica.PerformLayout();
            this.tabPagePessoaJuridica.ResumeLayout(false);
            this.tabPagePessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.TabControl tabControlPessoas;
        private System.Windows.Forms.TabPage tabPagePessoaFisica;
        private System.Windows.Forms.TabPage tabPagePessoaJuridica;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRazaoSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNomeFantasia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonConsultarCEP;
    }
}

