﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }
        

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == '.') return;
            for (int i = last; i < 0; i--)
            {
                if (i < 0)
                {
                    textBox1.Text += (".").ToString();
                }
                return;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("(").ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == ')') return;
            textBox1.Text += (")").ToString();

        }
       

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == '+') return;
            
            textBox1.Text += ("+").ToString();
           
        }
        

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == '-') return;

            textBox1.Text += ("-").ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == 'x') return;

            textBox1.Text += ("x").ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == '/') return;

            textBox1.Text += ("/").ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            char last = textBox1.Text[textBox1.TextLength - 1];
            if (last == '^') return;

            textBox1.Text += ("^").ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) {
                return;
            }
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
