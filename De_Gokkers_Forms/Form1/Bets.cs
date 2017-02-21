﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Bets
    {
        protected int bet;
        protected int kitten;
        protected int money;

        public Bets(int money)
        {
            this.money = money;
        }

        public void Bet(int bet, int kitten)
        {
            this.bet = bet;
            this.kitten = kitten;
            this.money -= bet;
        }

        public int GetBet()
        {
            return this.bet;
        }

        public int GetKitten()
        {
            return this.kitten;
        }
    }
}
