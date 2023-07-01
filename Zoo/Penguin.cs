using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Penguin : Birds
    {
        public override string Name { get; set; }
        public override int age { get; set; }

        public Penguin(string Name ,int age)
        {
            this.Name = Name;
            this.age = age;
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating Fish");
        }

        public override string Fly()
        {
            return $"{Name} Can't fly";
        }

        public override string Sound()
        {
            return $"{Name} sound is Chirping Chatter";
        }

        public override string Type()
        {
            return $"{Name} is a Penguin it's from Birds";
        }
    }
}
