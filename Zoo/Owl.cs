using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Owl : Birds, IFly,ILayEggs
    {
        
        public override string Name { get;set; }
        public override int age { get; set; }

        public Owl(string Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats Birds and insects");
        }

        public string canFly()
        {
            return $"{Name} Can Fly";
        }

        public override string Sound()
        {
            return $"{Name} Sound is Hoots!";
        }

        public override string Type()
        {
            return $"{Name} is an Owl It's from Birds";
        }

        public string LayEggs()
        {
            return $"{Name} reproduces by Laying Eggs";
        }
    }
}
