using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class About
    {
        public About()
        {
            AsciiArt.DragonArt();
            Console.WriteLine("Elden RPG is a Text-based RPG.");
            Console.WriteLine("");
            Console.WriteLine("         Made by: Jethro Alonzo");
            Console.WriteLine("         ---------------------");
            Console.WriteLine("");
            Console.WriteLine("     +---------Referrences:---------+");
            Console.WriteLine("ASCII ART : www.asciiart.website/index.php");
            Console.WriteLine("Inspiration: www.youtube.com/@kibble43");
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine("> Press any key to go back <");
            Console.Write("> ");
            Console.ReadLine();
            Console.Clear();
            new MainMenu();
            
        }
    }
}
