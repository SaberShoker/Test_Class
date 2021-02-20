using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersOnLib;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int switchClass;

            Console.WriteLine("You number - ");
            switchClass = Convert.ToInt32(Console.ReadLine()); 

            Hero man = new Hero("Shoker", 100, 10, switchClass);

            man.Attack();

            Console.WriteLine("It's OK");
        }
    }
}
