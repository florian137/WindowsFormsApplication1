﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p, s, d;
            p = 2 * (double.Parse(textBox1.Text) + double.Parse(textBox2.Text));
            s = double.Parse(textBox2.Text) * double.Parse(textBox1.Text);
            d = Math.Sqrt(double.Parse(textBox1.Text)* double.Parse(textBox1.Text) + double.Parse(textBox2.Text) * double.Parse(textBox2.Text));
            textBox3.Text = p.ToString();
            textBox4.Text = s.ToString();
            textBox5.Text = d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
