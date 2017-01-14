using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleApproxTaylorSeries;

namespace SimpleTaylorSeries
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: // Cosh
                case 1: // Sinh
                    {
                    textBox1.Enabled = true;
                    textBox3.Enabled = true;
                    button1.Enabled = true;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: // Cosh
                    {
                        label5.Text = TaylorApproxer.CosineHyper(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        break;
                    }
                case 1: // Sinh
                    {
                        label5.Text = TaylorApproxer.SineHyper(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        break;
                    }
            }
        }
    }
}
