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
        int moneyBed = 5;
        int color = 1;

        Guys player1;
        Guys player2;
        Guys player3;

        bool player1bet = false;
        bool player2bet = false;
        bool player3bet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoneyBedLabel.Text = "" + moneyBed;
            ColorBox.BackColor = Color.FromArgb(249, 79, 139);
            player1 = new Guys("Sietse", 100);
            player2 = new Guys("Fer", 100);
            player3 = new Guys("Lidy", 100);
            playerlabel1.Text = player1.GetName() + " heeft: " + player1.GetMoney() + " euro in totaal.";
            playerlabel2.Text = player2.GetName() + " heeft: " + player2.GetMoney() + " euro in totaal.";
            playerlabel3.Text = player3.GetName() + " heeft: " + player3.GetMoney() + " euro in totaal.";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(BedMoney.Value > 0 && moneyBed != 15)
            {
                BedMoney.Value = 0;
                moneyBed++;
                MoneyBedLabel.Text = "" + moneyBed;
            }
            else if (BedMoney.Value < 0 && moneyBed != 5)
            {
                BedMoney.Value = 0;
                moneyBed--;
                MoneyBedLabel.Text = "" + moneyBed;
            }
        }

        private void ColorChoose_ValueChanged(object sender, EventArgs e)
        {
            if (ColorChoose.Value > 5)
                ColorChoose.Value = 1;
            else if (ColorChoose.Value < 1)
                ColorChoose.Value = 5;
            color = (int)ColorChoose.Value;

            if (color == 1)
                ColorBox.BackColor = Color.FromArgb(245, 79, 139);
            else if(color == 2)
                ColorBox.BackColor = Color.FromArgb(252, 159, 86);
            else if (color == 3)
                ColorBox.BackColor = Color.FromArgb(255, 105, 100);
            else if (color == 4)
                ColorBox.BackColor = Color.FromArgb(79, 70, 245);
            else if (color == 5)
                ColorBox.BackColor = Color.FromArgb(115, 225, 223);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerRadio1.Checked && !player1bet)
            {
                player1bet = true;
                player1.Bet(int.Parse(MoneyBedLabel.Text), color);
                playerlabel1.Text = player1.GetName() + " heeft: " + player1.GetMoney() + " euro in totaal.\n" + player1.GetName() + " wedt " + player1.GetBet() + " euro op kat " + player1.GetKitten() + ".";
            }
            else if (playerRadio2.Checked && !player2bet)
            {
                player2bet = true;
                player2.Bet(int.Parse(MoneyBedLabel.Text), color);
                playerlabel2.Text = player2.GetName() + " heeft: " + player2.GetMoney() + " euro in totaal.\n" + player2.GetName() + " wedt " + player2.GetBet() + " euro op kat " + player2.GetKitten() + ".";
            }
            else if (playerRadio3.Checked && !player3bet)
            {
                player3bet = true;
                player3.Bet(int.Parse(MoneyBedLabel.Text), color);
                playerlabel3.Text = player3.GetName() + " heeft: " + player3.GetMoney() + " euro in totaal.\n" + player3.GetName() + " wedt " + player3.GetBet() + " euro op kat " + player3.GetKitten() + ".";
            }
        }
    }
}
