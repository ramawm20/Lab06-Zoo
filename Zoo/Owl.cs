using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Owl : Birds
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

        public override string Fly()
        {
            return $"{Name} Can fly ";
        }

        public override string Sound()
        {
            return $"{Name} Sound is Hoots!";
        }

        public override string Type()
        {
            return $"{Name} is Owl it's from Birds";
        }
    }
}
