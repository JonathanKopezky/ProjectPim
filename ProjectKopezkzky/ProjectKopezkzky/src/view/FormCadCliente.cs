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
        public FormCadCliente()
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
            Cliente cliente = new Cliente();
            cliente.nome = txbNome.Text;
            cliente.sobrenome = txbSobrenome.Text;
            cliente.CPF = txbCpf.Text;
            cliente.RG = txbRg.Text;
            cliente.dataNascimento = txbNascimento.Text;
            cliente.genero = txtGenero.Text;
            cliente.telefone = txbTelefone.Text;
            cliente.email = txbEmail.Text;
            cliente.endereco = txbEndereco.Text;
            cliente.CEP = txbEndereco.Text;
            cliente.numero = txbnumero.Text;
            cliente.estado = txbEstado.Text;
            cliente.cidade = txbCidade.Text;
            cliente.pais = txbPais.Text;
            cliente.complemento = txbComplemento.Text;
            cliente.senha = txbConfSenha.Text;
            //check all 
            if (ClienteController.VerificaCad(cliente)) 
            {
                MessageBox.Show(ClienteController.message);
            }
           
           


        }

        private void txbSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
