using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Cat
    {
        private bool    isAlive;
        private bool    disqualified;
        private int     position;
        public Cat()
        {
            this.isAlive        = true;
            this.position       = 0;
            this.disqualified   = false;
        }
        public void Run(int distens)
        {
            this.position += distens;
        }
        public int Fire(Cat[] Kittens)
        {
            int temp = 0;
            for (int i = 0; i < Kittens.Length; i++)
            {
                if (Kittens[i].GetPosition()>= temp)
                {
                    temp = Kittens[i].GetPosition();
                }
             }
            for (int i = 0; i < Kittens.Length; i++)
            {
                if (temp == Kittens[i].GetPosition())
                {
                    this.disqualified = true;
                    return i;
                }
            }
            return 0;
        }
        public bool GetIsAlive()
        {
            return this.isAlive;
        }
        public int GetPosition()
        {
            return this.position;
        }
        public bool GetDisqualified()
        {
            return this.disqualified;
        }
        public void SetIsAlive()
        {
            this.isAlive = false;
        }
    }
}
