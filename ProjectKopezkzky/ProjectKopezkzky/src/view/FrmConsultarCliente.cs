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
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente();

            frmCadastrarCliente.ShowDialog();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            FrmEditarCliente frmEditarCliente = new FrmEditarCliente();

            frmEditarCliente.ShowDialog();
        }
    }
}
