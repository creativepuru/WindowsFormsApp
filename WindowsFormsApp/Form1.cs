using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        private int operand1;
        private int operand2;
        private string selectedOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out operand1) && int.TryParse(textBox3.Text, out operand2))
            {
                selectedOperation = comboBox1.SelectedItem?.ToString();

                if (selectedOperation == "+")
                {
                    textBox4.Text = (operand1 + operand2).ToString();
                }
                else if (selectedOperation == "-")
                {
                    textBox4.Text = (operand1 - operand2).ToString();
                }
                else if (selectedOperation == "*")
                {
                    textBox4.Text = (operand1 * operand2).ToString();
                }
                else if (selectedOperation == "/")
                {
                    if (operand2 != 0)
                    {
                        textBox4.Text = (operand1 / operand2).ToString();
                    }
                    else
                    {
                        textBox4.Text = "Error: Division by zero";
                    }
                }
                else
                {
                    textBox4.Text = "Error: Invalid operation";
                }
            }
            else
            {
                textBox4.Text = "Error: Invalid input";
            }
        }
    }
}
