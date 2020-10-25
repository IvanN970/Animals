using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercising
{
    public class Animal
    {
        protected string name;
        protected int age;
        protected double height;
        protected bool hasFur;
        public Animal()
        {
            name = null;
            age = 0;
            height = 0;
            hasFur = false;
        }
        public Animal(string name,int age,double height,bool hasFur)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.hasFur = hasFur;
        }
        public string Name
        {
            set { name = value;}
            get { return name;}
        }
        public int Age
        {
            set { age = value;}
            get { return age;}
        }
        public double Height
        {
           set { height = value;}
           get { return height;}
        }
        public bool HasFur
        {
            set { hasFur = value;}
            get { return hasFur; }
        }
        public virtual void ProduceSound()
        {
            Console.WriteLine("Base class");
        }
        public override string ToString()
        {
            return "Name:" + " " + name + " " + "Age:" + " " + age + " " + "Height:" + " " + height + " " + "HasFur:" + " " + HasFur;
        }
    }
}
