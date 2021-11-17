using ProjectKopezkzky.src.controller;
using ProjectKopezkzky.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKopezkzky.src.view
{
    public partial class FrmUpdateCliente : Form
    { Cliente cliente = new Cliente();
        ClienteController clienteController = new ClienteController();
        public FrmUpdateCliente()
        {
            InitializeComponent();
        }

        private void FrmUpdateCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente.nome = txbNome.Text;
            cliente.sobrenome = txbSobrenome.Text;
            cliente.dataNascimento = txbNascimento.Text;
            cliente.genero = txbGenero.Text;
            cliente.telefone = txbTelefone.Text;
            cliente.email = txbEmail.Text;
            cliente.numero = Int32.Parse(textBoxNumero.Text);
            cliente.endereco = txbEndereco.Text;
            cliente.CEP = txbCep.Text;
            cliente.estado = txbEstado.Text;
            cliente.cidade = txbCidade.Text;
            cliente.pais = txbPais.Text;
            cliente.complemento = txbComplemento.Text;
            cliente.senha = txbSenha.Text;
            if (clienteController.AtualizaCad(cliente)) 
            {
                MessageBox.Show("Aterado Com Sucesso");
            } else 
            {
                MessageBox.Show("Erro ao alterar !!!");
            }


        }
    }
}
