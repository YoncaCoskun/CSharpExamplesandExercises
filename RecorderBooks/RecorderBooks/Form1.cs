using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecorderBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEmptyData.Text = txtNameSurname.Text;
            lblEmptyDataPhone.Text = txtPhone.Text;
            lblEmptyDataCity.Text = comboBox1.Text;
            lblEmptyDataAddress.Text = txtAddress.Text;

        }

      

    
    }
}
