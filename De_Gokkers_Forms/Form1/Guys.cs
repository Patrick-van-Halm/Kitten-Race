using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Guy
    {
        Bet myBet;
        string name;
        int money;

        public Guy(string name, int money = 50)
        {
            this.name = name;
            this.money = money;
            myBet = new Bet(this);
        }

        //Methods


        public void SetMoney(int money)
        {
            this.money = money;
        }

        public int GetMoney()
        {
            return this.money;
        }

        public string GetName()
        {
            return this.name;
        }

        public Bet GetBettor()
        {
            return myBet;
        }
    }
}
