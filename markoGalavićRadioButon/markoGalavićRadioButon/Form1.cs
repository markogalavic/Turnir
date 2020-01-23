using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićRadioButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (radioButtonAvion.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz avionom";
            }
            else if (radioButtonAutobus.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz autobusom";
            }
            else if (radioButtonAuto.Checked)
            {
                textBox1.Text = "Odabrali ste vlastiti prijevoz";
            }
            else
            {
                //U slučaju da ništa nije odabrano//
                MessageBox.Show("Odaberite tip prijevoza");
                return;
            }
        }
    }
}
