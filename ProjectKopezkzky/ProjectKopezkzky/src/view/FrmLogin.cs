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
using ProjectKopezkzky.src.view;


namespace ProjectKopezkzky.src.view
{
    public partial class FrmLogin : Form
    {
        FrmHome homeForm = new FrmHome();
        LoginController loginController;
        Funcionario funcionario;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario();
            loginController = new LoginController();

            funcionario.CPF = this.cpfTXT.Text;
            funcionario.senha = this.passwordTXT.Text;

            if (loginController.verifyLogin(funcionario))
            {
                MessageBox.Show("Mais q logado Onfire");
            }
            else
            {
                MessageBox.Show("Nao deu bom, então deu ruim");
            }
            
           homeForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
