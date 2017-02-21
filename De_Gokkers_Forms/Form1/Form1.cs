using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Form1
{
    public partial class Form1 : Form
    {
        List<Cat> cat = new List<Cat>();

        int moneyBed = 5;
        int color = 1;
        int amountCats = 5;
        int count = 0;

         Guys player1;
        Guys player2;
        Guys player3;

        bool player1bet = false;
        bool player2bet = false;
        bool player3bet = false;
        bool done = false;
        bool firts = true;

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
            for (int i = 0; i < amountCats; i++)
            {
                cat.Add(new Cat());
                Thread.Sleep(50);
            }
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

        private void go_Click(object sender, EventArgs e)
        {
            int temp;
            do
            {
                for (int i = 0; i < amountCats; i++)
                {

                    if (!cat[i].GetDisqualified() && cat[i].GetIsAlive() && !cat[i].GetStop())
                    {
                        if (i == 0)
                        {
                            temp = pictureBox3.Location.X + cat[i].Run();
                            pictureBox3.Location = new Point(temp, pictureBox3.Location.Y);
                            if (temp >= 1250)
                            {
                                cat[i].Stop();
                                if (firts)
                                {
                                    firts = false;
                                    cat[i].HasWon();
                                }
                                count++;
                                if (count == 5)
                                {
                                    done = true;
                                }
                            }
                            temp = 0;
                        }
                        else if (i == 1)
                        {
                            temp = pictureBox4.Location.X + cat[i].Run();
                            pictureBox4.Location = new Point(temp, pictureBox4.Location.Y);
                            if (temp >= 1250)
                            {
                                cat[i].Stop();
                                if (firts)
                                {
                                    firts = false;
                                    cat[i].HasWon();
                                }
                                count++;
                                if (count == 5)
                                {
                                    done = true;
                                }
                            }
                            temp = 0;
                        }
                        else if (i == 2)
                        {
                            temp = pictureBox5.Location.X + cat[i].Run();
                            pictureBox5.Location = new Point(temp, pictureBox5.Location.Y);
                            if (temp >= 1250)
                            {
                                cat[i].Stop();
                                if (firts)
                                {
                                    firts = false;
                                    cat[i].HasWon();
                                }
                                count++;
                                if (count == 5)
                                {
                                    done = true;
                                }
                            }
                            temp = 0;
                        }
                        else if (i == 3)
                        {
                            temp = pictureBox6.Location.X + cat[i].Run();
                            pictureBox6.Location = new Point(temp, pictureBox6.Location.Y);
                            if (temp >= 1250)
                            {
                                cat[i].Stop();
                                if (firts)
                                {
                                    firts = false;
                                    cat[i].HasWon();
                                }
                                count++;
                                if (count == 5)
                                {
                                    done = true;
                                }
                            }
                            temp = 0;
                        }
                        else if (i == 4)
                        {
                            temp = pictureBox7.Location.X + cat[i].Run();
                            pictureBox7.Location = new Point(temp, pictureBox7.Location.Y);
                            if (temp >= 1250)
                            {
                                cat[i].Stop();
                                if (firts)
                                {
                                    firts = false;
                                    cat[i].HasWon();
                                }
                                count++;
                                if (count == 5)
                                {
                                    done = true;
                                }
                            }
                            temp = 0;
                        }
                    }
                    else if (cat[i].GetStop())
                    { }
                    else
                    {
                        if (i == 0)
                        {
                            pictureBox3.Hide();
                        }
                        else if (i == 1)
                        {
                            pictureBox4.Hide();
                        }
                        else if (i == 2)
                        {
                            pictureBox5.Hide();
                        }
                        else if (i == 3)
                        {
                            pictureBox6.Hide();
                        }
                        else if (i == 4)
                        {
                            pictureBox7.Hide();
                        }
                    }
                }
                Application.DoEvents();
            } while (!done);
            //label1.Text = "RONDE WIN:";
            for (int i = 0; i < amountCats; i++)
            {
                if (cat[i].GetHaveWon())
                {
                    if (i == 0)
                    {
                        pictureBox3.Hide();
                    }
                    else if (i == 1)
                    {
                        pictureBox4.Hide();
                    }
                    else if (i == 2)
                    {
                        pictureBox5.Hide();
                    }
                    else if (i == 3)
                    {
                        pictureBox6.Hide();
                    }
                    else if (i == 4)
                    {
                        pictureBox7.Hide();
                    }
                }
            }
        }
    }
}
