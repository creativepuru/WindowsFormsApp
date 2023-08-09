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
    public partial class Arithmetic_Operations : Form
    {

        private int operand1;
        private int operand2;
        private string selectedOperation;

        public Arithmetic_Operations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
