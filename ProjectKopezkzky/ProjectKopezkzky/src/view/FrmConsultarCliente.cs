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
    public partial class FrmConsultarCliente : Form
    {
        Cliente cliente = new Cliente();
        ClienteController clienteController = new ClienteController();
        public FrmConsultarCliente()
        {
            InitializeComponent();
            FecharButtons();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {   //Chama o form cadastrar cliente 
            FormCadCliente frmCadCliente = new FormCadCliente();
            frmCadCliente.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {   // chama o form Alterar  Cadastro
            FrmUpdateCliente frmUpdateCliente = new FrmUpdateCliente();
            frmUpdateCliente.ShowDialog();

        }

        private void FecharButtons()
        {   //Deixa os botoes inativo quando abrir o form
            btnAlterar.Enabled = false;
            btnCadCliente.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ShowButtons()
        {
            //if()
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            cliente.CPF = txtCpf.Text;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cliente.CPF = txtCpf.Text;
            if (clienteController.ConsultarCad(cliente))
            {
                MessageBox.Show("Cliente ja cadastrado");
            }
            else 
            {
                MessageBox.Show("Cliente sem cadastro");
            }

        }
    }
}
