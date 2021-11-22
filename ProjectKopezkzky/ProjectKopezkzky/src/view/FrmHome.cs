using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectKopezkzky.src.view;

namespace ProjectKopezkzky.src.view
{
    public partial class FrmHome : Form
    {
        

        private Form frmAtivo;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            FecharFormAtivo();
            frmAtivo = frm;
            frm.TopLevel = false; //controla o form para que ele não abra outra janela **fazer teste**
            panelHome.Controls.Add(frm); //add o form no panelFormHome
            frm.BringToFront(); //coloca o form na frente de exibição
            frm.Show();
        }

        private void FecharFormAtivo()
        {
            if (frmAtivo != null) //se houver algum form ativo ele será fechado
            {
                frmAtivo.Close();
            }
        }

        private void consultarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void CadastralClienteMenu_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();

            frmCadastroFuncionario.ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmConsultarCliente());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormAtivo();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFuncBTN_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario fmrCadastroFuncionario = new FrmCadastroFuncionario();

            fmrCadastroFuncionario.ShowDialog();
        }

        private void consultarReservaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmNovaReserva frmNovaReserva = new FrmNovaReserva();

            FormShow(frmNovaReserva);
        }

        private void btnHomeSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();                
            }
        }

        private void consultarReservaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
