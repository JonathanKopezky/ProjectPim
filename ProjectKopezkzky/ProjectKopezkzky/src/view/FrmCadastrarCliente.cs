using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectKopezkzky.src.controller;
using ProjectKopezkzky.src.model;

namespace ProjectKopezkzky.src.view
{
    public partial class FrmCadastrarCliente : Form
    {
        ClienteController ClienteController = new ClienteController();
        Cliente cliente = new Cliente();
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {   // pasando parametros para cliente 

            this.cliente.nome = txtBoxNome.Text;
            this.cliente.sobrenome = txtBoxSobrenome.Text;
            this.cliente.CPF = txtBoxCPF.Text;
            this.cliente.RG = txtBoxRG.Text;
            this.cliente.dataNascimento = txtBoxNasc.Text;
            this.cliente.genero = txtBoxGenero.Text;
            this.cliente.telefone = txtBoxTelefone.Text;
            this.cliente.email = txtBoxEmail.Text;
            this.cliente.endereco = txtBoxEndereco.Text;
            this.cliente.CEP = txtBoxCEP.Text;
            this.cliente.numero = Int32.Parse(txtBoxNumero.Text);
            this.cliente.estado = txtBoxEstado.Text;
            this.cliente.cidade = txtBoxCidade.Text;
            this.cliente.pais = txtBoxPais.Text;
            this.cliente.complemento = txtBoxComplemento.Text;
            this.cliente.senha = txtBoxSenha1.Text;
            if (!ClienteController.VerificaCad(cliente))
            {
                MessageBox.Show("Cadastro existe");
            }
            else
            {
                MessageBox.Show("Cadastrado com suceeso");
                // Close();
                limpar();
            }




        }

        private void limpar()
        { // vai limpar todos textbox
            txtBoxNome.Clear();
            txtBoxSobrenome.Clear();
            txtBoxCPF.Clear();
            txtBoxRG.Clear();
            txtBoxNasc.Clear();
            txtBoxGenero.Clear();
            txtBoxTelefone.Clear();
            txtBoxEndereco.Clear();
            txtBoxCEP.Clear();
            txtBoxNumero.Clear();
            txtBoxEstado.Clear();
            txtBoxCidade.Clear();
            txtBoxPais.Clear();
            txtBoxComplemento.Clear();
            txtBoxSenha1.Clear();
            txtBoxSenha2.Clear();
            txtBoxEmail.Clear();
        }

        private void txbSobrenome_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbPais_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void blockButton()
        {// funcao desativa o botao enquanto texbox for vazio 

            if (!string.IsNullOrWhiteSpace(txtBoxNome.Text) && !string.IsNullOrWhiteSpace(txtBoxSobrenome.Text)
                && !string.IsNullOrWhiteSpace(txtBoxCPF.Text) && !string.IsNullOrWhiteSpace(txtBoxRG.Text)
                 && !string.IsNullOrWhiteSpace(txtBoxNasc.Text) && !string.IsNullOrWhiteSpace(txtBoxGenero.Text)
                  && !string.IsNullOrWhiteSpace(txtBoxTelefone.Text) && !string.IsNullOrWhiteSpace(txtBoxEmail.Text)
                   && !string.IsNullOrWhiteSpace(txtBoxEndereco.Text) && !string.IsNullOrWhiteSpace(txtBoxCEP.Text)
                    && !string.IsNullOrWhiteSpace(txtBoxNumero.Text) && !string.IsNullOrWhiteSpace(txtBoxEstado.Text)
                     && !string.IsNullOrWhiteSpace(txtBoxCidade.Text) && !string.IsNullOrWhiteSpace(txtBoxPais.Text)
                     && !string.IsNullOrWhiteSpace(txtBoxComplemento.Text) && !string.IsNullOrWhiteSpace(txtBoxSenha1.Text))
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbRg_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbNascimento_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbEndereco_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbCep_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbnumero_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbEstado_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbCidade_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbComplemento_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            blockButton();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
