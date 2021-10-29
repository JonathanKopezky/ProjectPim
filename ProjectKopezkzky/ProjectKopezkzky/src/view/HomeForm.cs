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
            panelConsulta.Visible = false;

        }

        private void HidePanel()
        {   // Segundo se estiver aberto  Feche 
            if (panelCadCliente.Visible == true)
            {
                panelCadCliente.Visible = false;
            }

            if (panelConsulta.Visible == true) 
            {
                panelConsulta.Visible = false;
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

            if (panelConsulta.Visible == false)
            {
                HidePanel();
                panelConsulta.Visible = true;
            }
            else 
            {
                panelConsulta.Visible = false;
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
    }
}
