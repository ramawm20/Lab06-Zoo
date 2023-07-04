using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    //Class cats inherits from Mammals which inherits from animals 
    public class Cats : Mammals,IBirth
    {
        //Override the name and age from the animals class
        public override string Name { get; set; }
        public override int age { get; set; }


        public Cats(string Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }
        

        public override string Sound()
        {
            return $"{Name} sound is Meow!";
        }

        public override string Type()
        {
            return $"{Name} is a cat it's from Mammals";
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Is eating Tuna");
        }

        public string givingBirth()
        {
            return $"{Name} reproduces by giving Birth";
        }
    }
}
