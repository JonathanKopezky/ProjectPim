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
          //  Cliente cliente = new Cliente();
            clienteController.getCadCliente(cliente);

            FrmUpdateCliente frmUpdateCliente = new FrmUpdateCliente();
            frmUpdateCliente.preencher(cliente);
            frmUpdateCliente.ShowDialog();
           

        }

        private void FecharButtons()
        {   //Deixa os botoes inativo quando abrir o form
            btnAlterar.Enabled = false;
            btnCadCliente.Enabled = false;
            btnDelete.Enabled = false;
            btnBuscar.Enabled = false;
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            cliente.CPF = txtcpf.Text;
            cliente.status = "0";
            if (clienteController.DeletCad(cliente))
            {
                MessageBox.Show("Cliente excluido");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            cliente.CPF = txtcpf.Text;
            if (clienteController.ConsultarCad(cliente))
            {// so vai ativar o botao delete e alterar se ja ouver cadastro
                MessageBox.Show("Cliente ja cadastrado");
                btnDelete.Enabled = true;
                btnAlterar.Enabled = true;
                
            }
            else
            {   //vai liberar o botao cadastrar se nao haver reserva 
                MessageBox.Show("Cliente sem cadastro");
                btnCadCliente.Enabled = true;

            }



        }

            public void blockBtn()
            {   //desativa e ativa o  bnt buscar caso txt for vazio
                if (!string.IsNullOrWhiteSpace(txtcpf.Text)) 
                {
                    btnBuscar.Enabled = true;
                } else 
                {
                    btnBuscar.Enabled = false;
                }

        }

     
        private void txtcpf_TextChanged(object sender, EventArgs e)
        {
            blockBtn();
        }
    }
}
