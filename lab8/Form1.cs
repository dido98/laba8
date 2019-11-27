using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool po = false;
        bool deleno = false;

        bool Floating = false;
        double old = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Floating = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            plus = false;
            minus = false;
            po = false;
            deleno = false;
            Floating = false;
            textBox1.Text = String.Format("{0}", 0);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Floating == false)
            {
                Floating = true;
                textBox1.Text = String.Format("{0}{1}", textBox1.Text, ".");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Floating)
            {
                double curr = double.Parse(textBox1.Text);
                double newcurr = curr * (-1);
                textBox1.Text = String.Format("{0}", newcurr);
            }
            else
            {
                int curr = int.Parse(textBox1.Text);
                int newcurr = curr * (-1);
                textBox1.Text = String.Format("{0}", newcurr);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            double curr = double.Parse(textBox1.Text);
            if (curr == 0)
                if (deleno == true)
                    return;

            if (plus == true)
            {
                textBox1.Text = String.Format("{0}", old + curr);
            }
            if (minus == true)
            {
                textBox1.Text = String.Format("{0}", old - curr);
            }
            if (po == true)
            {
                textBox1.Text = String.Format("{0}", old * curr);
            }
            if (deleno == true)
            {
                textBox1.Text = String.Format("{0}", old / curr);
            }

            old = 0;

             plus = false;
             minus = false;
             po = false;
             deleno = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", 1/curr);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Sqrt(curr));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", curr * curr);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", curr * curr * curr);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Sin(curr));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Cos(curr));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Tan(curr));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Cos(curr));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                return;
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = String.Format("{0}{1}", textBox1.Text, 9);
        }

        private void button14_Click(object sender, EventArgs e)
        {
             plus = false;
             minus = false;
             po = false;
             deleno = false;

            plus = true;
            if (old == 0)
            {
                old = double.Parse(textBox1.Text);
                Floating = false;
                textBox1.Text = "0";
            }
            else
            {
                button12_Click(sender, e);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            plus = false;
             minus = false;
             po = false;
             deleno = false;

            minus = true;
            if (old == 0)
            {
                old = double.Parse(textBox1.Text);
                Floating = false;
                textBox1.Text = "0";
            }
            else
            {
                button12_Click(sender, e);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
             plus = false;
             minus = false;
             po = false;
             deleno = false;

            po = true;
            if (old == 0)
            {
                old = double.Parse(textBox1.Text);
                Floating = false;
                textBox1.Text = "0";
            }
            else
            {
                button12_Click(sender, e);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
             plus = false;
             minus = false;
             po = false;
             deleno = false;

            deleno = true;
            if (old == 0)
            {
                old = double.Parse(textBox1.Text);
                Floating = false;
                textBox1.Text = "0";
            }
            else
            {
                button12_Click(sender, e);
            }
        }
    }
}
