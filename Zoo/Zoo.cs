using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public  class Zoo
    {
        private List<Animals> animals;
        public Zoo()
        {
            animals = new List<Animals>();
        }

        public void AddAnimal(Animals animal)
        {
            animals.Add(animal);
        }

        public void AnimalInformation()
        {
            int count = 1;
            foreach (var animal in animals)
            {
                string s1= $"Animal Number {count}";
                Console.SetCursorPosition((Console.WindowWidth - s1.Length) / 2, Console.CursorTop);
                Console.WriteLine(s1);

                string s2 = $"Name: {animal.Name}";
                Console.SetCursorPosition((Console.WindowWidth - s2.Length) / 2, Console.CursorTop);
                Console.WriteLine(s2);

                string s3 = $"Age: {animal.age}";
                Console.SetCursorPosition((Console.WindowWidth - s3.Length) / 2, Console.CursorTop);
                Console.WriteLine(s3);

                string s4 = $"Type: {animal.Type()}";
                Console.SetCursorPosition((Console.WindowWidth - s4.Length) / 2, Console.CursorTop);
                Console.WriteLine(s4);

                string s5= "eating whatttttttt?";
                Console.SetCursorPosition((Console.WindowWidth - s5.Length) / 2, Console.CursorTop);
                animal.Eat();

                string s6 = $"Sound: {animal.Sound()}";
                Console.SetCursorPosition((Console.WindowWidth - s6.Length) / 2, Console.CursorTop);
                Console.WriteLine(s6);

                count++;
                string horizontalLine = new string('-', Console.WindowWidth);
                Console.WriteLine(horizontalLine);
                Console.WriteLine();
            }
        }
    }

}


