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
    public partial class Calculator : Form
    {
        Double result = 0;
        String OperationPerformed = "";
        bool Performed= false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (Performed))
                textBox.Clear();

            Performed= false;
            Button n = (Button) sender;
            if(n.Text == ".")
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }
            else
            textBox.Text = textBox.Text + n.Text;
           
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (result != 0)
            {
                Equal.PerformClick();
                OperationPerformed = n.Text;
                lcurrentOp.Text = result + " " + OperationPerformed;
                Performed= true;
            }
            else
            {
                OperationPerformed = n.Text;
                result = Double.Parse(textBox.Text);
                lcurrentOp.Text = result + " " + OperationPerformed;
                Performed= true;
            }
           

        }

        private void CancelAll_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch(OperationPerformed)
                {
                case "+": 
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;

                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;

                default:
                    break;

            }

            result = Double.Parse(textBox.Text);
            lcurrentOp.Text = "";
        }
    }
}
