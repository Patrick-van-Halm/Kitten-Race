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
        int money;

        public Guys(string name, int money = 50) : base()
        {
            this.name = name;
            this.money = money;
        }

        //Methods

        public string GetName()
        {
            return this.name;
        }

        public int GetMoney()
        {
            return this.money;
        }
    }
}
