using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isOpPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isOpPerformed))
                textBox.Clear();

            isOpPerformed = false;
            Button n = (Button) sender;
            if(n.Text == ".")
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }
            else
            textBox.Text = textBox.Text + n.Text;
           
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (resultValue != 0)
            {
                Equal.PerformClick();
                opPerformed = n.Text;
                lcurrentOp.Text = resultValue + " " + opPerformed;
                isOpPerformed = true;
            }
            else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                lcurrentOp.Text = resultValue + " " + opPerformed;
                isOpPerformed = true;
            }
           

        }

        private void nce_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch(opPerformed)
                {
                case "+": 
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;

                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;

                default:
                    break;

            }

            resultValue = Double.Parse(textBox.Text);
            lcurrentOp.Text = "";
        }
    }
}
