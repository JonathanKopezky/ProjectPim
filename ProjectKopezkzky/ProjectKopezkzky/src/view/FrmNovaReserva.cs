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
    public partial class FrmNovaReserva : Form
    {
        ListViewItem cadastroListView;

        public FrmNovaReserva()
        {
            InitializeComponent();
        }

        private void AddClienteToListView()
        {
            //verifica se o campo txt esta vazio
            if (txtBoxCPF.Text.Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o CPF!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //limpa a os itens da listView
                listViewCliente.Items.Clear();

                //cria um obj do tipo ListViewItem, e add os dados no obj
                cadastroListView = new ListViewItem(txtBoxCPF.Text.Trim());
                cadastroListView.SubItems.Add("Vinicius de Paula Silva");
                cadastroListView.SubItems.Add("Rua Orozimbo Maia");

                //add o obj a lista
                listViewCliente.Items.Add(cadastroListView);

                //limpa txtBoxCPF
                txtBoxCPF.Text = string.Empty;
            }
        }
      
        private void FrmNovaReserva_Load(object sender, EventArgs e)
        {
            txtBoxCPF.Select();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The selected value is " + dateTimePickerEntrada.Text);
            MessageBox.Show("Number Day: " + dateTimePickerEntrada.Value.Day.ToString());
            MessageBox.Show("DayOfWeek: " + dateTimePickerEntrada.Value.DayOfWeek.ToString());
            MessageBox.Show("Mouth: " + dateTimePickerEntrada.Value.Month.ToString());
            MessageBox.Show("Year: " + dateTimePickerEntrada.Value.Year.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxQartIndDuplo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxQartInd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClienteToListView();
        }

        private void btnInserirTeste_Click(object sender, EventArgs e)
        {
            




        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
