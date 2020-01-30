using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace markoGalavićKlasaArraylist
{
    public partial class Form1 : Form
    {
        ArrayList litaAutomobila = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.AppendText
            (richTextBox1.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");

        }

    }
}
