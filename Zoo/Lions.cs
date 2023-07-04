using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Lions:Mammals,IBirth
    {
        public override string Name { get; set; }
        public override int age { get; set; }

        public Lions(string Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }
       
        public override string Sound()
        {
            return $"{Name} sound is Roar!";
        }

        public override string Type()
        {
            return $"{Name} is a Lion it's from Mammals";
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Is eating Meats");
        }
        public string givingBirth()
        {
            return $"{Name} reproduces by giving Birth";
        }
    }
}
