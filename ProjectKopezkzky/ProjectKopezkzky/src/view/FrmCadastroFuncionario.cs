using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.controller;

namespace ProjectKopezkzky.src.view
{
    public partial class FrmCadastroFuncionario : Form
    {

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
        }



        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void blockButton()
        {// funcao desativa o botao enquanto texbox for vazio 

            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txbSobrenome.Text)
               && !string.IsNullOrWhiteSpace(maskedTextBoxDateNasc.Text) && !string.IsNullOrWhiteSpace(txbFormacao.Text)
                              && !string.IsNullOrWhiteSpace(maskedTextBoxRg.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxCpf.Text)
                                && !string.IsNullOrWhiteSpace(txbTitulo.Text) && !string.IsNullOrWhiteSpace(txbReservista.Text)
                                 && !string.IsNullOrWhiteSpace(txbNomeMae.Text) && !string.IsNullOrWhiteSpace(txbNomePai.Text)
                                    && !string.IsNullOrWhiteSpace(txbDependente.Text) && !string.IsNullOrWhiteSpace(txbCnh.Text)
                                      && !string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxEmail.Text)
                                        && !string.IsNullOrWhiteSpace(comboBoxGenero.Text) && !string.IsNullOrWhiteSpace(comboBoxEstadoCivil.Text)
                                       && !string.IsNullOrWhiteSpace(txbObservacao.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxPais.Text)
                                       && !string.IsNullOrWhiteSpace(maskedTextBoxEstado.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxCidade.Text)
                                       && !string.IsNullOrWhiteSpace(txbEndereco.Text) && !string.IsNullOrWhiteSpace(txbNumero.Text)
                                     && !string.IsNullOrWhiteSpace(txbComplemento.Text) && !string.IsNullOrWhiteSpace(txbObservacao.Text)
                                   && !string.IsNullOrWhiteSpace(txbSenha.Text) && !string.IsNullOrWhiteSpace(txbConfirmaSenha.Text) )
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        public void preencheTxt(Funcionario funcionario) 
        {
            maskedTextBoxCpf.Text = funcionario.CPF;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            Funcionario funcionario = new Funcionario();


            if (txbSenha.Text != txbConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas precisam ser iguais");
            }

            else
            {
                funcionario.nome = textBox1.Text;
                funcionario.sobrenome = textBox2.Text;
                funcionario.dataNascimento = maskedTextBox2.Text;
                funcionario.formacaoAcademica = textBox11.Text;
                funcionario.RG = maskedTextBoxRg.Text;
                funcionario.CPF = maskedTextBox5.Text;
                funcionario.tituloEleitor = textBox6.Text;
                funcionario.reservista = textBox7.Text;
                funcionario.nomeMae = textBox4.Text;
                funcionario.nomePai = textBox5.Text;
                funcionario.dependentes = Int32.Parse(textBox3.Text);
                funcionario.CNH = textBox10.Text;
                funcionario.telefone = maskedTextBox1.Text;
                funcionario.email = maskedTextBox3.Text;
                funcionario.genero = textBox8.Text;
                funcionario.estadoCivil = textBox9.Text;
                funcionario.CEP = maskedTextBox16.Text;
                funcionario.pais = maskedTextBox12.Text;
                funcionario.estado = maskedTextBox7.Text;
                funcionario.cidade = maskedTextBox8.Text;
                funcionario.endereco = maskedTextBox6.Text;
                funcionario.numero = Int32.Parse(maskedTextBox10.Text);
                funcionario.complemento = maskedTextBox11.Text;
                funcionario.observacoes = maskedTextBox16.Text;
                funcionario.senha = maskedTextBox14.Text;

                funcionarioController.createFuncionario(funcionario);
            }
        }

        public void ClearTxb() 
        {
            txtNome.Text ="";
            txbSobrenome.Text = "";
            maskedTextBoxDateNasc.Text = "";
            txbFormacao.Text = "";
            txbFormacao.Text = "";
            maskedTextBoxRg.Text = "";
            maskedTextBoxCpf.Text = "";
            txbTitulo.Text = "";
            txbReservista.Text = "";
            txbNomeMae.Text = "";
            txbNomePai.Text = "";
            txbDependente.Text = "";
            txbCnh.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxEmail.Text = "";
            comboBoxGenero.Text = "";
            comboBoxEstadoCivil.Text = "";
            maskedTextBoxCep.Text = "";
            maskedTextBoxPais.Text = "";
            maskedTextBoxEstado.Text = "";
            maskedTextBoxCidade.Text = "";
            txbEndereco.Text = "";
            txbNumero.Text = "";
            txbComplemento.Text = "";
            maskedTextBoxCep.Text = "";
            txbConfirmaSenha.Text = "";
            txbSenha.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   //check
            blockButton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox16_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // blockButton();
        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox15_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox13_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private void maskedTextBox14_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { //check
            blockButton();
        }

        private bool verificaCampos()
        {
            if (
                    !string.IsNullOrWhiteSpace(textBox1.Text) ||
                    !string.IsNullOrWhiteSpace(textBox2.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox2.Text) ||
                    !string.IsNullOrWhiteSpace(textBox11.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBoxRg.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox5.Text) ||
                    !string.IsNullOrWhiteSpace(textBox6.Text) ||
                    !string.IsNullOrWhiteSpace(textBox7.Text) ||
                    !string.IsNullOrWhiteSpace(textBox4.Text) ||
                    !string.IsNullOrWhiteSpace(textBox5.Text) ||
                    !string.IsNullOrWhiteSpace(textBox3.Text) ||
                    !string.IsNullOrWhiteSpace(textBox10.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox3.Text) ||
                    !string.IsNullOrWhiteSpace(textBox8.Text) ||
                    !string.IsNullOrWhiteSpace(textBox9.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox16.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox12.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox7.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox8.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox6.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox10.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox11.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox15.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox13.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox14.Text)
             )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
