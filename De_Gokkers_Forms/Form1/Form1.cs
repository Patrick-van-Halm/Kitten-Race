using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        int lanes = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 15+1 || numericUpDown1.Value == 4)
            {
                label7.Text = "There is a maximum of 15 Euro and a Minimum of 5 Euro";
                label7.Show();
                timer1.Enabled = true;
                if (numericUpDown1.Value == 16)
                {
                    numericUpDown1.Value = 15;
                }
                else if (numericUpDown1.Value == 4)
                {
                    numericUpDown1.Value = 5;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label7.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Hide();
            timer1.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == lanes+1 || numericUpDown2.Value == 0)
            {
                label7.Text = "There is a maximum of " + lanes + " Lanes and a Minimum of 1 Lanes";
                label7.Show();
                timer1.Enabled = true;
                if (numericUpDown2.Value == 6)
                {
                    numericUpDown2.Value = 5;
                }
                else if(numericUpDown2.Value == 0)
                {
                    numericUpDown2.Value = 1;
                }
            }
        }
    }
}
