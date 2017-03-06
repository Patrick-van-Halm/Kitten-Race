using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Bet
    {
        protected int kitten;
        protected int betMoney;
        protected Guy bettor;

        public Bet(Guy bettor)
        {
            this.bettor = bettor;
        }

        public void BetMoney(int bet, int kitten)
        {
            if (kitten == 5)
                kitten = 1;
            else if (kitten == 4)
                kitten = 2;
            else if (kitten == 2)
                kitten = 4;
            else if (kitten == 1)
                kitten = 5;
            this.betMoney = bet;
            this.kitten = kitten;
            bettor.SetMoney(bettor.GetMoney() - bet);
        }

        public void Win()
        {
            bettor.SetMoney(bettor.GetMoney() + 2 * this.betMoney);
        }

        public int GetBetMoney()
        {
            return this.betMoney;
        }

        public int GetKitten()
        {
            return this.kitten;
        }
    }
}
