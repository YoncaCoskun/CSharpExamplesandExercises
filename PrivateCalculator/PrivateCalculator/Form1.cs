using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int count;
        int sum;
        int number;
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            textBox1.Text =" ";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
           
            number = Convert.ToInt32(textBox1.Text);
            textBox1.ResetText();
            count = 1;
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            
            number = Convert.ToInt32(textBox1.Text);
            textBox1.ResetText();
            count = 2;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            
            number = Convert.ToInt32(textBox1.Text);
            textBox1.ResetText();
            count = 3;
        }

        private void btnCik_Click(object sender, EventArgs e)
        {

            number = Convert.ToInt32(textBox1.Text + "-");
            textBox1.ResetText();
            count = 4;
        }
       
       

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int tb = Convert.ToInt32(textBox1.Text);

            if (count == 1)
            {
                sum = number / tb;
            }
            else if (count == 2)
            {
                sum = number * tb;
            }
            else if (count == 3)
            {
                sum = number + tb;
            }
            else if (count == 4)
            {
                sum = number - tb;
            }

            textBox1.ResetText();
            textBox1.Text = sum.ToString();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
