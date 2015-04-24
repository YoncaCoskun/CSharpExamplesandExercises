using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int oneEdge;
            int fieldSquare;
            int perimeterSquare;


            

            oneEdge = Convert.ToInt32(txtFirstEdge.Text);
          

            fieldSquare= oneEdge * oneEdge;
            perimeterSquare = 4 * oneEdge;

            lblEmptyDataField.Text = fieldSquare.ToString();
            lblEmptyDataPerimeter.Text = perimeterSquare.ToString();




         


        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblLongEdge.Visible = false;
            txtLongEdge.Visible = false;
            label1.Visible = true;
            label1.Text = "Square";
            button1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label1.Visible = false;

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Rectangle";
            lblFirstEdge.Text = "Short Edge";
            panel1.Visible = true;
            lblLongEdge.Visible = true;
            txtLongEdge.Visible = true;



            btnCount.Visible = false;
            button1.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shortEdge;
            int longEdge;
            int fieldRectangle;
            int perimeterRectangle;

            shortEdge = Convert.ToInt32(txtFirstEdge.Text);
            longEdge = Convert.ToInt32(txtLongEdge.Text);
            fieldRectangle = shortEdge * longEdge;
            perimeterRectangle = (2 * shortEdge) + (2 * longEdge);

            lblEmptyDataField.Text = fieldRectangle.ToString();
            lblEmptyDataPerimeter.Text = perimeterRectangle.ToString();
        }

      
    }
}
