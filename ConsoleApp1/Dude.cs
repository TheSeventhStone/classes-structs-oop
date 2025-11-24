using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dude
    {
        public string name;
        public int exp = 0;

        public Dude()
        {
            Reset();
        }
        public Dude(string name)
        {
            this.name = name;
        }
        public virtual void printStatsInfo()
        {
            Console.WriteLine($"Hero: {this.name} abides - {this.exp} EXP");
        }

        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }
    }
}
