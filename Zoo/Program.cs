using System;
using static System.Console;

namespace Zoo
  
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string asciiArt = @"
         _    _      _                            _         ___  ___        ______            
        | |  | |    | |                          | |        |  \/  |       |___  /            
        | |  | | ___| | ___ ___  _ __ ___   ___  | |_ ___   | .  . |_   _     / /  ___   ___  
        | |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | |\/| | | | |   / /  / _ \ / _ \ 
        \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |  | | |_| | ./ /__| (_) | (_) |
         \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  \_|  |_/\__, | \_____/\___/ \___/ 
                                                                     __/ |                    
                                                                    |___/                     
";

            int consoleWidth = Console.WindowWidth;
            int asciiArtWidth = asciiArt.TrimEnd().Split('\n').Max(line => line.Length);
            int indentation = (consoleWidth - asciiArtWidth) / 2;

            string indentedAsciiArt = string.Join(
                Environment.NewLine,
                asciiArt.TrimEnd().Split('\n').Select(line => new string(' ', indentation) + line)
            );

            Console.WriteLine(indentedAsciiArt);
            string s = "Let's show you some of the animals in my Zoo with information About each one ";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine();

            Zoo Myzoo = new Zoo();

            Cats cat1 = new Cats("Lulu", 3);
            Cats cat2 = new Cats("Soso", 2);
            Lions lion1 = new Lions("Simba", 2);
            Penguin p1 = new Penguin("Koke", 4);
            Turtules t1 = new Turtules("Limon", 6);
            Owl o1 = new Owl("lumi", 4);

            Myzoo.AddAnimal(cat1);
            Myzoo.AddAnimal(cat2);
            Myzoo.AddAnimal(lion1);
            Myzoo.AddAnimal(t1);
            Myzoo.AddAnimal(p1);
            Myzoo.AddAnimal(o1);


            Myzoo.AnimalInformation();


        }
    }
}