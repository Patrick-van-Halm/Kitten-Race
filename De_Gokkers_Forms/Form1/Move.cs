using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Form1
{
    class Move
    {
        private int movement;
        private Random rmd;
        public Move()
        {
            rmd = new Random();
        }
        public int Moved()
        {
            return rmd.Next(0, 25);
        }
    }
}
