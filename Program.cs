using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Human
    {
        private int Age;
        private string Name;

        public Human() { Name = "Saber"; Age = 19; }
        
        public Human(string Name, int Age) { this.Name = Name; this.Age = Age; }

        public Human(string Name){ this.Name = Name; this.Age = 18; }

        public Human(int Age) { this.Name = "Shoker"; this.Age = Age; }

        public void GetInfo()
        {
            Console.WriteLine("Name is {0}, age is {1}.", this.Name, this.Age);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Human Masha = new Human("Masha", 20);

            Masha.GetInfo();
        }
    }
}
