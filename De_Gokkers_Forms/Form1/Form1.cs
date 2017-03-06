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
        int countgames = 0;

        Guys player1;
        Guys player2;
        Guys player3;
        Guys[] Guylist = new Guys[3];

        bool player1bet = false;
        bool player2bet = false;
        bool player3bet = false;
        bool done = false;
        bool firts = true;
        bool noBet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            MoneyBedLabel.Text = "" + moneyBed;
            ColorBox.BackColor = Color.FromArgb(115, 225, 223);
            player1 = new Guys("Sietse", 100);
            player2 = new Guys("Fer", 100);
            player3 = new Guys("Lidy", 100);
            Guylist[0] = player1;
            Guylist[1] = player2;
            Guylist[2] = player3;
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
            go.Enabled = true;
        }

        private void go_Click(object sender, EventArgs e)
        {
            go.Enabled = false;
            int temp;
            do
            {
                //Tot 1 persoon heeft gewedt kan het spel niet beginnen
                if (!player1bet && !player2bet && !player3bet)
                {
                    noBet = true;
                    break;
                }
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
            done = false;
            if (!noBet)
            {
                    countgames++;
                    count = 0;
                    //label1.Text = "RONDE WIN:";
                    for (int i = 0; i < amountCats; i++)
                    {
                        if (cat[i].GetHaveWon())
                        {
                            if (i == 0)
                            {
                                label1.Text = "Kat 1 heeft gewonnen";
                                label1.BackColor = Color.FromArgb(115, 225, 223);
                                for (int j = 0; j < Guylist.Length; j++)
                                {
                                    if (Guylist[j].GetKitten() == 5)
                                    {
                                        Guylist[j].Win();
                                    }
                                }
                            }
                            else if (i == 1)
                            {
                                label1.Text = "Kat 2 heeft gewonnen";
                                label1.BackColor = Color.FromArgb(79, 70, 245);
                                for (int j = 0; j < Guylist.Length; j++)
                                {
                                    if (Guylist[j].GetKitten() == 4)
                                    {
                                        Guylist[j].Win();
                                    }
                                }
                            }
                            else if (i == 2)
                            {
                                label1.Text = "Kat 3 heeft gewonnen";
                                label1.BackColor = Color.FromArgb(255, 105, 100);
                                for (int j = 0; j < Guylist.Length; j++)
                                {
                                    if (Guylist[j].GetKitten() == 3)
                                    {
                                        Guylist[j].Win();
                                    }
                                }
                            }
                            else if (i == 3)
                            {
                                label1.Text = "Kat 4 heeft gewonnen";
                                label1.BackColor = Color.FromArgb(252, 159, 86);
                                for (int j = 0; j < Guylist.Length; j++)
                                {
                                    if (Guylist[j].GetKitten() == 2)
                                    {
                                        Guylist[j].Win();
                                    }
                                }
                            }
                            else if (i == 4)
                            {
                                label1.Text = "Kat 5 heeft gewonnen";
                                label1.BackColor = Color.FromArgb(245, 79, 139);
                                for (int j = 0; j < Guylist.Length; j++)
                                {
                                    if (Guylist[j].GetKitten() == 1)
                                    {
                                        Guylist[j].Win();
                                    }
                                }
                            }
                            RefreshForm();
                        }
                    }
                for (int i = 0; i < amountCats; i++)
                {
                        temp = cat[i].Run();
                }
                do
                    {
                        for (int i = 0; i < amountCats; i++)
                        {
                        if (!cat[i].GetStop())
                        {
                            temp = 0;
                            if (!cat[i].GetStop())
                            {
                                temp = cat[i].Run();
                            }
                            if (i == 0)
                            {
                                temp += pictureBox3.Location.X;
                                pictureBox3.Location = new Point(temp, pictureBox3.Location.Y);
                            }
                            else if (i == 1)
                            {
                                temp += pictureBox4.Location.X;
                                pictureBox4.Location = new Point(temp, pictureBox4.Location.Y);
                            }
                            else if (i == 2)
                            {
                                temp += pictureBox5.Location.X;
                                pictureBox5.Location = new Point(temp, pictureBox5.Location.Y);
                            }
                            else if (i == 3)
                            {
                                temp += pictureBox6.Location.X;
                                pictureBox6.Location = new Point(temp, pictureBox6.Location.Y);
                            }
                            else if (i == 4)
                            {
                                temp += pictureBox7.Location.X;
                                pictureBox7.Location = new Point(temp, pictureBox7.Location.Y);
                            }

                            Application.DoEvents();
                            if (temp >= 1600)
                            {
                                if (i == 0)
                                {
                                    pictureBox3.Location = new Point(0, pictureBox3.Location.Y);
                                }
                                else if (i == 1)
                                {
                                    pictureBox4.Location = new Point(0, pictureBox4.Location.Y);
                                }
                                else if (i == 2)
                                {
                                    pictureBox5.Location = new Point(0, pictureBox5.Location.Y);
                                }
                                else if (i == 3)
                                {
                                    pictureBox6.Location = new Point(0, pictureBox6.Location.Y);
                                }
                                else if (i == 4)
                                {
                                    pictureBox7.Location = new Point(0, pictureBox7.Location.Y);
                                }
                            }
                            else if (cat[i].GetStop())
                            { }
                            else if (temp >= 240 && temp <= 300)
                            {
                                if (i == 0)
                                {
                                    pictureBox3.Location = new Point(257, pictureBox3.Location.Y);
                                    cat[i].Stop();
                                }
                                else if (i == 1)
                                {
                                    pictureBox4.Location = new Point(257, pictureBox4.Location.Y);
                                    cat[i].Stop();
                                }
                                else if (i == 2)
                                {
                                    pictureBox5.Location = new Point(257, pictureBox5.Location.Y);
                                    cat[i].Stop();
                                }
                                else if (i == 3)
                                {
                                    pictureBox6.Location = new Point(257, pictureBox6.Location.Y);
                                    cat[i].Stop();
                                }
                                else if (i == 4)
                                {
                                    pictureBox7.Location = new Point(257, pictureBox7.Location.Y);
                                    cat[i].Stop();
                                }
                                count++;
                            }
                        }
                        }
                        if (count == amountCats)
                        {
                            done = true;
                        }
                        Application.DoEvents();
                        temp = 0;
                    } while (!done);

                    moneyBed = 5;
                    color = 1;
                    amountCats = 5;
                    count = 0;

                    player1bet = false;
                    player2bet = false;
                    player3bet = false;
                    done = false;
                    firts = true;
                    noBet = false;
                    for (int i = 0; i < amountCats; i++)
                    {
                        cat[i].CanMove();
                    }
            }
        }

        private void RefreshForm()
        {
            playerlabel1.Text = player1.GetName() + " heeft: " + player1.GetMoney() + " euro in totaal.\n ";
            playerlabel2.Text = player2.GetName() + " heeft: " + player2.GetMoney() + " euro in totaal.\n ";
            playerlabel3.Text = player3.GetName() + " heeft: " + player3.GetMoney() + " euro in totaal.\n ";
            player1bet = false;
            player2bet = false;
            player3bet = false;
        }
    }
}
