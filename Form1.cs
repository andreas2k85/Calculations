using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculations
{
    public partial class Form1 : Form
    {
        string box = string.Empty;
        string calc = string.Empty;
        string calc1 = string.Empty;
        char proc;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        //Screen

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clipboard.Clear();
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        

        //Numbers

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "1";
            this.textBox1.Text += box;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "2";
            this.textBox1.Text += box;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "3";
            this.textBox1.Text += box;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "4";
            this.textBox1.Text += box;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "5";
            this.textBox1.Text += box;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "6";
            this.textBox1.Text += box;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "7";
            this.textBox1.Text += box;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "8";
            this.textBox1.Text += box;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "9";
            this.textBox1.Text += box;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            box += "0";
            this.textBox1.Text += box;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Contains(","))
                box += ",";
        }

        //Calcs

        private void button15_Click(object sender, EventArgs e)
        {
            calc = box;
            proc = '/';
            box = string.Empty;
            this.textBox2.Text = "÷";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calc = box;
            proc = '*';
            box = string.Empty;
            this.textBox2.Text = "×";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calc = box;
            proc = '-';
            box = string.Empty;
            this.textBox2.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            calc = box;
            proc = '+';
            box = string.Empty;
            this.textBox2.Text = "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double opr;
            this.textBox2.Text = "√";
            if (double.TryParse(textBox1.Text, out opr))
            {
                textBox1.Text = (Math.Sqrt(opr)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calc1 = box;
            double a, b;
            double.TryParse(calc, out a);
            double.TryParse(calc1, out b);

            this.textBox1.Text = "";
            this.box = string.Empty;
            this.calc = string.Empty;
            this.calc1 = string.Empty;

            switch (proc)
            {
                case '+':
                    result = a + b;
                    textBox1.Text = result.ToString();
                    
                    this.textBox2.Text = "=";
                    break;
                case '-':
                    result = a - b;
                    textBox1.Text = result.ToString();
                    
                    this.textBox2.Text = "=";
                    break;
                case '*':
                    result = a * b;
                    textBox1.Text = result.ToString();
                    
                    this.textBox2.Text = "=";
                    break;
                case '/':
                    if (a != 0)
                    {
                        result = a / b;
                        textBox1.Text = result.ToString();
                        
                        this.textBox2.Text = "=";
                    }
                    else
                    {
                        textBox1.Text = "Can't divide by zero";
                    }
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
            this.textBox2.Text = "";
            this.box = string.Empty;
            this.calc = string.Empty;
            this.calc1 = string.Empty;
            this.temp = string.Empty;
        }
    }
}
