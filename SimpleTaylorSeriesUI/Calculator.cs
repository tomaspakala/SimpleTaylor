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
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                    textBox1.Enabled = true;
                    textBox3.Enabled = true;
                    button1.Enabled = true;
                    break;
                }
                case 10:
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = true;
                    button1.Enabled = true;
                    break;
                }
                case 11:
                    {
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
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
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.CosineHyper(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 1: // Sinh
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.SineHyper(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 2:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Sine(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 3:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Cosine(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 4:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Tangent(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 5:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Arccosinus(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 6:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Arcsinus(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 7:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Arctangent(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 8:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.EExponential(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 9:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Logarithm(Double.Parse(textBox1.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 10:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = HighPrecisionPi.GetPi(Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
                case 11:
                    {
                        if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            label5.Text = TaylorApproxer.Power(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), Int32.Parse(textBox3.Text)).ToString();
                        }
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }
    }
}
