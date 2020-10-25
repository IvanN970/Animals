using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Exercising
{
    class Program
    {
        static void Main()
        {
            Animal dog = new Dog("Sharo", 3, 1.20, true);
            Animal cat = new Cat("Penka", 4, 0.70, true);
            Animal lion = new Lion("Misho", 5, 1.50, true);
            Animal[] animals = new Animal[] { dog, cat, lion };
            PrintAnimals(animals);
        }
        static void PrintAnimals(Animal[] animals)
        {
            for(int i=0;i<animals.Length;i++)
            {
                Console.WriteLine(animals[i]);
            }
        }
    }
}
