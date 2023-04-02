using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Horse : Animal, IRidable
    {
        public Horse()
        {
            Console.WriteLine("Horse constructor. Huge Horse.");
        }

        public new void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }

        public new void Talk()
        {
            Console.WriteLine("Horse neigh");
        }

        public void BathMe()
        {
            Console.WriteLine("Please pour water on me.");
        }

        public void BiteMe()
        {
            Console.WriteLine("It's Fight night. I can bite too!!!");
        }
    }
}
