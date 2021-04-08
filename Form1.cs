using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "devide";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "mul";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "sub";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "add";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        string operation;
        double y;
        double x;
        double result;
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                y = double.Parse(textBox1.Text);
                switch (operation)
                {
                    case "add":
                        textBox1.Text = (x + y).ToString("0.0");
                        break;
                    case "sub":
                        textBox1.Text = (x - y).ToString("0.0");
                        break;
                    case "mul":
                        textBox1.Text = (x * y).ToString("0.0");
                        break;
                    case "devide":
                        textBox1.Text = (x / y).ToString("0.0");
                        break;



                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
    }
}
