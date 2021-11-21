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
        public FrmNovaReserva()
        {
            InitializeComponent();
        }



        private void getData()
        {
            MessageBox.Show("The selected value is " + dateTimePickerEntrada.Text);
            MessageBox.Show("Number Day: " + dateTimePickerEntrada.Value.Day.ToString());
            MessageBox.Show("DayOfWeek: " + dateTimePickerEntrada.Value.DayOfWeek.ToString());
            MessageBox.Show("Mouth: "+ dateTimePickerEntrada.Value.Month.ToString());
            MessageBox.Show("Year: " + dateTimePickerEntrada.Value.Year.ToString());
        }
        
        private void FrmNovaReserva_Load(object sender, EventArgs e)
        {

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
            getData();
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
    }
}
