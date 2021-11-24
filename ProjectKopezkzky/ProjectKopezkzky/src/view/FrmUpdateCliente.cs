﻿using ProjectKopezkzky.src.controller;
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
    {   Cliente cliente = new Cliente();
        ClienteController clienteController = new ClienteController();
        public FrmUpdateCliente()
        {
            InitializeComponent();
            ShowClient();
            txbSenha.Text = cliente.senha;
        }

        private void FrmUpdateCliente_Load(object sender, EventArgs e)
        {

        }
      

        public void ShowClient() 
        { // Quando chamar o form ja vai carregar  as textbox com os texto 
           // clienteController.getCadCliente(cliente);
            txbNome.Text = cliente.nome;
            txbSobrenome.Text = cliente.sobrenome;
            txbCpf.Text = cliente.CPF;
            txbRg.Text = cliente.RG;
            maskedTextBoxDataNasc.Text = cliente.dataNascimento;
            comboxGenero.Text = cliente.genero;
            maskedTextBoxTelefone.Text = cliente.telefone;
            txbEmail.Text = cliente.email;
            txbNumero.Text = Convert.ToString(cliente.numero);
            txbEndereco.Text = cliente.endereco;
            maskedTextBoxCep.Text = cliente.CEP;
            txbEstado.Text = cliente.CEP;
            cliente.cidade = cliente.cidade;
            txbPais.Text = cliente.pais;
            txbComplemento.Text = cliente.complemento;
            txbSenha.Text = cliente.senha;

            txbCpf.Enabled = false;
            txbRg.Enabled = false;
            MessageBox.Show(cliente.nome, cliente.CPF);
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente.nome = txbNome.Text;
            cliente.sobrenome = txbSobrenome.Text;
            cliente.dataNascimento = maskedTextBoxDataNasc.Text;
            cliente.genero = comboxGenero.Text;
            cliente.telefone = maskedTextBoxTelefone.Text;
            cliente.email = txbEmail.Text;
            cliente.numero = Int32.Parse(txbNumero.Text);
            cliente.endereco = txbEndereco.Text;
            cliente.CEP = maskedTextBoxCep.Text;
            cliente.estado = txbEstado.Text;
            cliente.cidade = txbCidade.Text;
            cliente.pais = txbPais.Text;
            cliente.complemento = txbComplemento.Text;
            cliente.senha = txbSenha.Text;
            if (clienteController.setCadCliente(cliente)) 
            {
                MessageBox.Show("Aterado Com Sucesso");
            } else 
            {
                MessageBox.Show("Erro ao alterar !!!");
            }


        }
    }
}