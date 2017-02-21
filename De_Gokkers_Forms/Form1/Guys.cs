using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Guys : Bets
    {
        string name;

        public Guys(string name, int money = 50) : base(money)
        {
            this.name = name;
        }

        //Methods

        public string GetName()
        {
            return this.name;
        }

        public int GetMoney()
        {
            return money;
        }
    }
}
