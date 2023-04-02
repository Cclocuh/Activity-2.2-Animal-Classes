using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cow : Animal, IMilkable
    {
        public Cow()
        {
            Console.WriteLine("Horse constructor. Calm Cow.");
        }
        public new void Talk()
        {
            Console.WriteLine("Moo Moo");
        }
        public void MilkMe()
        {
            Console.WriteLine("Please squeeze the mike out 3 times a day.");
        }
    }
}
