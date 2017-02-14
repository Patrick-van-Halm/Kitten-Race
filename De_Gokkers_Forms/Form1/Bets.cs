using System;
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

        public Bets()
        {
        }

        public void Bet(int bet, int kitten)
        {
            this.bet = bet;
            this.kitten = kitten;
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
