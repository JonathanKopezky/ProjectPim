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
            FormCadCliente formcadcliente = new FormCadCliente();
            formcadcliente.ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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

        private void btnHomeSair_Click(object sender, EventArgs e)
        {

        }
    }
}
