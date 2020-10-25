using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercising
{
    public class Lion:Animal
    {
        public Lion() : base() { }
        public Lion(string name,int age,double height,bool hasFur) : base(name, age, height, hasFur) { }
        public override void ProduceSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
