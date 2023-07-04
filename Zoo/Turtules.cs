using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    //Derived class from reptiles (inherits the reptiles)
    public class Turtules : Reptiles,ILayEggs
    {
        public override string Name { get; set; }
        public override int age { get; set; }

        public Turtules(string Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating plants");
        }


        public override string Sound()
        {
            return $"{Name} sound is Hissing!";

        }

        public override string Type()
        {
            return $"{Name} is a Turtule it's from Reptiles";
        }
        public string LayEggs()
        {
            return $"{Name} reproduces by Laying Eggs";
        }
    }
}
