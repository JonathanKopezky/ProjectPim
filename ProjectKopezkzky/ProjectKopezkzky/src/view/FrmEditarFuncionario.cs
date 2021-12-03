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
    public partial class FrmEditarFuncionario : Form
    {  Funcionario  funcionario = new Funcionario();
        FuncionarioController funcionarioController = new FuncionarioController();
        public FrmEditarFuncionario()
        {
            InitializeComponent();

            maskedTextBoxRg.Enabled = false;
            maskedTextBoxCpf.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            funcionario.nome = txtBoxNome.Text;
            funcionario.sobrenome = txtBoxSobrenome.Text;
            funcionario.dataNascimento = maskedTextBoxNasc.Text;
            funcionario.formacaoAcademica = txtBoxFormacaoAcademica.Text;
            funcionario.RG = maskedTextBoxRg.Text;
            funcionario.CPF = maskedTextBoxCpf.Text;
            funcionario.tituloEleitor = txtBoxEleitor.Text; 
            funcionario.reservista = txtBoxReservista.Text;
            funcionario.nomeMae = txtBoxNomeMae.Text;
            funcionario.nomePai = txbNomePai.Text;
            funcionario.dependentes = Convert.ToInt32(txtBoxDependentes.Text);
            funcionario.CNH = txtBoxCNH.Text;
            funcionario.telefone = maskedTextBoxTel.Text;
            funcionario.email = txtBoxEmail.Text;
            funcionario.genero = comboBoxGenero.Text;
            funcionario.estadoCivil = comboBoxEstadociv.Text;
            funcionario.CEP = maskedTextBoxCep.Text;
            funcionario.pais = txtBoxPais.Text;
            funcionario.estado = txtBoxEstado.Text;
            funcionario.cidade = txtBoxCidade.Text;
            funcionario.numero = Convert.ToInt32(txtBoxNumero.Text);
            funcionario.endereco = txtBoxEndereco.Text;
            funcionario.complemento = txtBoxComplemento.Text;
            funcionario.observacoes = txtBoxObservacoes.Text;
            funcionario.senha = txtBoxSenha2.Text;

            if (txtBoxSenha1.Text == txtBoxSenha2.Text) 
            {
                if (funcionarioController.updateFuncionario(funcionario)) 
                {
                    MessageBox.Show("Cadastrado Com Sucesso! ");
                    this.Close();
                    ClearTxt();
                }
                else
                {
                    MessageBox.Show("ERRO TENTE NOVAMENTE ","Atencão",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void PreencheFuncionario(Funcionario funcionario) 
        {// vai preencher todos os campos 
            txtBoxNome.Text = funcionario.nome;
            txtBoxSobrenome.Text = funcionario.sobrenome;
            maskedTextBoxNasc.Text = funcionario.dataNascimento;
            txtBoxFormacaoAcademica.Text = funcionario.formacaoAcademica;
            maskedTextBoxRg.Text = funcionario.RG;
            maskedTextBoxCpf.Text = funcionario.CPF;
            txtBoxEleitor.Text = funcionario.tituloEleitor;
            txtBoxReservista.Text = funcionario.reservista;
            txtBoxNomeMae.Text = funcionario.nomeMae;
            txbNomePai.Text = funcionario.nomePai;
            txtBoxDependentes.Text = funcionario.dependentes.ToString();
            txtBoxCNH.Text = funcionario.CNH;
            maskedTextBoxTel.Text = funcionario.telefone;
            txtBoxEmail.Text = funcionario.email;
            comboBoxGenero.Text = funcionario.genero;
            comboBoxEstadociv.Text = funcionario.estadoCivil;
            maskedTextBoxCep.Text = funcionario.CEP;
            txtBoxPais.Text = funcionario.pais;
            txtBoxEstado.Text = funcionario.estado;
            txtBoxCidade.Text = funcionario.cidade;
            txtBoxNumero.Text = funcionario.numero.ToString();
            txtBoxEndereco.Text = funcionario.endereco;
            txtBoxComplemento.Text = funcionario.complemento;
            txtBoxObservacoes.Text = funcionario.observacoes;
            txtBoxSenha1.Text = funcionario.senha;
            txtBoxSenha2.Text = funcionario.senha;

           
             


        }

        public void ClearTxt() 
        {   //Limpa a text box
            txtBoxNome.Text = "";
            txtBoxSobrenome.Text = "";
            maskedTextBoxNasc.Text = "";
            txtBoxFormacaoAcademica.Text = "";
            maskedTextBoxRg.Text ="";
            maskedTextBoxCpf.Text = "";
            txtBoxEleitor.Text = "";
            txtBoxReservista.Text="";
            txtBoxNomeMae.Text = "";
            txbNomePai.Text = "";
            txtBoxDependentes.Text= "";
            txtBoxCNH.Text = "";
            maskedTextBoxTel.Text = "";
            txtBoxEmail.Text = "";
            comboBoxGenero.Text = "";
            comboBoxEstadociv.Text = "";
            maskedTextBoxCep.Text = "";
            txtBoxPais.Text = "";
            txtBoxEstado.Text = "";
            txtBoxCidade.Text = "";
            txtBoxNumero.Text = "";
            txtBoxEndereco.Text = "";
            txtBoxComplemento.Text = "";
            txtBoxObservacoes.Text = "";
            txtBoxSenha1.Text = "";
            txtBoxSenha2.Text = "";
        }

        private void FrmEditarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
