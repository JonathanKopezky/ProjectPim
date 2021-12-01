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
    public partial class FrmConsultarFuncionario : Form
    {
        FuncionarioController funcionarioController = new FuncionarioController();
        Funcionario funcionario = new Funcionario();
        public FrmConsultarFuncionario()
        {
            InitializeComponent();
            btnBuscar.Enabled = false;
            btnCadFuncionario.Enabled = false;
            btnDeletaFuncionario.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            funcionario.CPF = textBoxcpf.Text;
            if (funcionarioController.verifica(funcionario))
            {
                MessageBox.Show(" JA CADASTRADO");
                btnDeletaFuncionario.Enabled = true;
                btnAlterar.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Funcionario sem cadastro");
                btnCadFuncionario.Enabled = true;
            }
        }

        private void btnDeletaFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.CPF = textBoxcpf.Text;
            funcionario.status = "INATIVO";
            if (funcionarioController.deleteFuncionario(funcionario)) 
            {

                MessageBox.Show("Excluido Com Sucesso");
                }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(funcionario.CPF);
            funcionarioController.getFuncionario(funcionario);
            FrmEditarFuncionario frmEditarFuncionario = new FrmEditarFuncionario();
            frmEditarFuncionario.PreencheFuncionario(funcionario);
            frmEditarFuncionario.ShowDialog();

        }

        public void blockBtn()
        {   //desativa e ativa o  bnt buscar caso txt for vazio
            if (!string.IsNullOrWhiteSpace(textBoxcpf.Text))
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }

        }

        private void maskedTextBoxBusca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            blockBtn();
        }

        private void textBoxcpf_TextChanged(object sender, EventArgs e)
        {
            blockBtn();
        }
    }
}
