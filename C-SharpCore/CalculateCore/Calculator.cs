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

namespace CalculateCore
{
    public partial class Calculator : Form
    {
        Double number1 = 0, number2 = 0, result = 0;

        public Calculator()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            number1 = Double.Parse(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            number2 = Double.Parse(textBox3.Text);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            result = number1 + number2;
            textBox2.Text = result.ToString();

        }
        private void Subtract_Click(object sender, EventArgs e)
        {
            result = number1 - number2;
            textBox2.Text = result.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            result = number1 * number2;
            textBox2.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            result = number1 / number2;
            textBox2.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        
    }
}
