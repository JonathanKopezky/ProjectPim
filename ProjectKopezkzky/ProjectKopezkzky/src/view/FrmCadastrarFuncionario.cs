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
    public partial class FrmCadastrarFuncionario : Form
    {

        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            Funcionario funcionario = new Funcionario();


            if(txtBoxSenha1.Text != txtBoxSenha2.Text)
            {
                MessageBox.Show("As senhas precisam ser iguais");
            }
            else if(!verificaCampos())
            {
                MessageBox.Show("Algo de errado com o preencimento");
            }
            else
            {
                funcionario.nome = txtBoxNome.Text;
                funcionario.sobrenome = txtBoxSobrenome.Text;
                funcionario.dataNascimento = maskedTextBox2.Text;
                funcionario.formacaoAcademica = txtBoxFormacaoAcademica.Text;
                funcionario.RG = maskedTextBox4.Text;
                funcionario.CPF = maskedTextBox5.Text;
                funcionario.tituloEleitor = txtBoxEleitor.Text;
                funcionario.reservista = txtBoxReservista.Text;
                funcionario.nomeMae = txtBoxNomeMae.Text;
                funcionario.nomePai = txtBoxNomePai.Text;
                funcionario.dependentes = Int32.Parse(txtBoxDependentes.Text);
                funcionario.CNH = txtBoxCNH.Text;
                funcionario.telefone = maskedTextBox1.Text;
                funcionario.email = txtBoxEmail.Text;
                funcionario.genero = txtBoxGenero.Text;
                funcionario.estadoCivil = txtBoxEstadoCivil.Text;
                funcionario.CEP = maskedTextBox16.Text;
                funcionario.pais = txtBoxPais.Text;
                funcionario.estado = txtBoxEstado.Text;
                funcionario.cidade = txtBoxCidade.Text;
                funcionario.endereco = txtBoxEndereco.Text;
                funcionario.numero = Int32.Parse(txtBoxNumero.Text);
                funcionario.complemento = txtBoxComplemento.Text;
                funcionario.observacoes = maskedTextBox16.Text;
                funcionario.senha = txtBoxSenha1.Text;

                funcionarioController.createFuncionario(funcionario);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox16_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox15_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox13_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox14_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private bool verificaCampos()
        {
            if (
                    !string.IsNullOrWhiteSpace(txtBoxNome.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxSobrenome.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox2.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxFormacaoAcademica.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox4.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox5.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxEleitor.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxReservista.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxNomeMae.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxNomePai.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxDependentes.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxCNH.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxGenero.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxEstadoCivil.Text) ||
                    !string.IsNullOrWhiteSpace(maskedTextBox16.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxPais.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxEstado.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxCidade.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxNumero.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxEndereco.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxComplemento.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxObservacoes.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxSenha1.Text) ||
                    !string.IsNullOrWhiteSpace(txtBoxSenha2.Text)
             )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
