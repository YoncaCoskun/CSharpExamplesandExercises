using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinueExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            lstNameSurname.Items.Add(txtNameSurname.Text);
            lstPhone.Items.Add(txtPhone.Text);
            lstAddress.Items.Add(txtAddress.Text);
            lstPizzaSize.Items.Add(comboBox1.Text);
            lstDrink.Items.Add(comboBox2.Text);
            lstItems.Items.Add(label8.Text+" "+label9.Text+" "+label10.Text+" "+label11.Text+" "+label12.Text+" "+label13.Text);
            
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = chkSausage.Text;
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = chkCheese.Text;
        }

        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = chkOlive.Text;
        }

        private void chkCorn_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = chkCorn.Text;
        }

        private void chkPepper_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = chkPepper.Text;
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = chkMushroom.Text;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            txtNameSurname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }

       
    
    
      
     

       

      
    }
}
