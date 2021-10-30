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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            ClosedPanel();
        }

        private void consultarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClosedPanel()
        {
            //Primeiro inicia o system com os painel fechados 
            panelCadCliente.Visible = false;

        }

        private void HidePanel()
        {   // Segundo se estiver aberto  Feche 
            if (panelCadCliente.Visible == true)
            {
                panelCadCliente.Visible = false;
            }

            
        }

        private void ShowPanelCad(Panel Cadastro)
        {
            if (panelCadCliente.Visible == false)
            {
                HidePanel();
                panelCadCliente.Visible = true;
            }
            else 
            {
                panelCadCliente.Visible = false;
            }

  
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void CadastralClienteMenu_Click(object sender, EventArgs e)
        {
            ShowPanelCad(panelCadCliente);
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteController ClienteController = new ClienteController();
            //Passando os parametros para o model

            Cliente Cliente = new Cliente () ;
            Cliente.nome = txbNome.Text;
            Cliente.dataNascimento = txbNascimento.Text;
            Cliente.CPF = txbCpf.Text;
            Cliente.email = txbEmail.Text;
            Cliente.endereco = txbEndereco.Text;
            Cliente.complemento = txtComplemento.Text;
            Cliente.cidade = txbCidade.Text;
            Cliente.pais = txbCidade.Text;
            Cliente.numero = txbnumero.Text;
            Cliente.CEP = txbCep.Text;
            Cliente.estado = txbEstado.Text;
            Cliente.telefone = txbTelefone.Text;
            //fim

            if (ClienteController.VerificaCad(Cliente))
            {
                MessageBox.Show("criando ");
            }
            else 
            {
                MessageBox.Show("Cadastre algum cliente");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCadCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbNumero(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelDatanasc_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}
