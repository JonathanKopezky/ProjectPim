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
    public partial class FormCadCliente : Form
    {
        ClienteController ClienteController = new ClienteController();
        Cliente cliente = new Cliente();
        public FormCadCliente()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
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

            this.cliente.nome = txbNome.Text;
            this.cliente.sobrenome = txbSobrenome.Text;
            this.cliente.CPF = maskedTextBoxCpf .Text;
            this.cliente.RG = maskedTextBoxRg.Text;
            this.cliente.dataNascimento = maskedTextBoxDataNasc.Text;
            this.cliente.genero = txtGenero.Text;
            this.cliente.telefone = maskedTextBoxTelefone.Text;
            this.cliente.email = txbEmail.Text;
            this.cliente.endereco = txbEndereco.Text;
            this.cliente.CEP = maskedTextBoxCep.Text;
            this.cliente.numero = Int32.Parse(txbnumero.Text);
            this.cliente.estado = txbEstado.Text;
            this.cliente.cidade = txbCidade.Text;
            this.cliente.pais = txbPais.Text;
            this.cliente.complemento = txbComplemento.Text;
            this.cliente.senha = txbSenha.Text;
            ClienteController.CreateCadCliente(cliente);
            if (ClienteController.CreateCadCliente(cliente))
            {
                MessageBox.Show("Cadastrado Com Sucesso");
                Close();
                limpar();
            }
            else
            {
                MessageBox.Show("Error");
                // Close();
                limpar();
            }




        }

        private void limpar()
        { // vai limpar todos textbox
            txbNome.Clear();
            txbSobrenome.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxRg.Clear();
            maskedTextBoxDataNasc.Clear();
            txtGenero.Clear();
            maskedTextBoxTelefone.Clear();
            txbEndereco.Clear();
            maskedTextBoxCep.Clear();
            txbnumero.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbPais.Clear();
            txbComplemento.Clear();
            txbSenha.Clear();
            txbEmail.Clear();
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

            if (!string.IsNullOrWhiteSpace(txbNome.Text) && !string.IsNullOrWhiteSpace(txbSobrenome.Text)
                && !string.IsNullOrWhiteSpace(maskedTextBoxCpf.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxRg.Text)
                 && !string.IsNullOrWhiteSpace (maskedTextBoxDataNasc.Text) && !string.IsNullOrWhiteSpace(txtGenero.Text)
                  && !string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) && !string.IsNullOrWhiteSpace(txbEmail.Text)
                   && !string.IsNullOrWhiteSpace(txbEndereco.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxCep.Text)
                    && !string.IsNullOrWhiteSpace(txbnumero.Text) && !string.IsNullOrWhiteSpace(txbEstado.Text)
                     && !string.IsNullOrWhiteSpace(txbCidade.Text) && !string.IsNullOrWhiteSpace(txbPais.Text)
                     && !string.IsNullOrWhiteSpace(txbComplemento.Text) && !string.IsNullOrWhiteSpace(txbSenha.Text))
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
    }
}
