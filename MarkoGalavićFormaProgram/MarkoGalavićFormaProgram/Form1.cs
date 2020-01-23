using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkoGalavićFormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
                textBox2.Visible = true;
            else
                textBox2.Visible = false;

            if (textBox3.Visible == false)
                textBox3.Visible = true;
            else
                textBox3.Visible = false;

        }
    }
}
