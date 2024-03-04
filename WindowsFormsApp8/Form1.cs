using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string action = " ";
        private bool hasComma = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox1.Text);
            action = ((System.Windows.Forms.Button)sender).Text;
            textBox1.Clear();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Double.Parse(textBox1.Text);
                switch (action)
                {
                    case "x":
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if (num1 / num2 == 0)
                        {
                            textBox1.Clear();
                            MessageBox.Show("Попытка деления на ноль.");
                        }
                        textBox1.Text = (num1 / num2).ToString();
                        break;
                    case "+":
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_nums_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((System.Windows.Forms.Button)sender).Text;

        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Split(',').Length - 1 >= 1 || hasComma)
            {
                return;
            }

            textBox1.Text = textBox1.Text + ",";
            hasComma = true;
        }

    }
}
