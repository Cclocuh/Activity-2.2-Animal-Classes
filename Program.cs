using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animal beast = new Animal();

            beast.Talk();
            beast.Greet();
            beast.Sing();
            */
            Dog bowser = new Dog();

            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick");
            bowser.FeedMe();
            bowser.TouchMe();

            Robin red = new Robin();
            red.Talk();
            red.Greet();
            red.Sing();
            //red.Fetch("worm");
            //red.FeedMe();
            //red.TouchMe();

            Horse horse = new Horse();
            horse.Talk();
            horse.Greet();
            horse.BathMe();
            horse.BiteMe();

            Cow calvin = new Cow();
            calvin.Talk(); 
            calvin.MilkMe();
           
            Console.ReadLine();
        }
    }
}
