﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Cat
    {
        Move move = new Move();

        private bool    won;
        private bool    isAlive;
        private bool    disqualified;
        private bool    stop;
        private int     position;
        public Cat()
        {
            this.isAlive        = true;
            this.position       = 0;
            this.disqualified   = false;
            this.stop           = false;
        }
        public int Run()
        {
            this.stop = false;
            return this.position = this.move.Moved();
        }
        public void ResetCat()
        {
            this.won = false;
        }
        public void Fire()
        {
            this.disqualified = true;
        }
        public void Stop()
        {
            this.stop = true;
        }
        public void CanMove()
        {
            this.stop = false;
        }
        public void HasWon()
        {
            this.won = true;
        }
        public bool GetIsAlive()
        {
            return this.isAlive;
        }
        public int GetPosition()
        {
            return this.position;
        }
        public void SETPosition(int position)
        {
            this.position = position;
        }
        public bool GetDisqualified()
        {
            return this.disqualified;
        }
        public bool GetStop()
        {
            return this.stop;
        }
        public void SetIsAlive()
        {
            this.isAlive = false;
        }
        public bool GetHaveWon()
        {
            return this.won;
        }
    }
}
