using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class MainMenu
    {
        
        public MainMenu()
        {
            StartMenu();
            Inputs();
        }

        private static void StartMenu()
        {

            AsciiArt.DragonArt();
            Console.WriteLine("                -- EldenRPG --            ");
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Quit Game");
            Console.WriteLine("+---------------------------------------------+");
            Console.Write("> ");
        }

        


        public static void Inputs()
        {

            int playerInput = Convert.ToInt32(Console.ReadLine());

            switch (playerInput)
            {
                case 1:
                    Console.Write("Enter your Name: ");
                    String playerName = Console.ReadLine();
                    new NewGame(playerName);
                    break;
                case 2: // Load
                    Console.Clear();
                    Console.WriteLine("Load Game");
                    break;
                case 3: // About
                    Console.Clear();
                    new About();
                    break;
                case 4:
                    Console.WriteLine("Quit Game");
                    break;
            }
            
        }
    }
}
