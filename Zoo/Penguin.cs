using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Penguin : Birds,IFly,ILayEggs
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

        public override string Sound()
        {
            return $"{Name} sound is Chirping Chatter";
        }

        public override string Type()
        {
            return $"{Name} is a Penguin it's from Birds";
        }

        public string canFly()
        {
            return $"{Name} is a bird but it can't fly";
        }
        public string LayEggs()
        {
            return $"{Name} reproduces by Laying Eggs";
        }
    }
}
