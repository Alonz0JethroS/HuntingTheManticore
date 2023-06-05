using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class NewGame
    {
        public NewGame(String playerName)
        {
            ChooseClass();

        }
        public static void ChooseClass()
        {
            Console.Clear();
            AsciiArt.DragonArt();
            Console.WriteLine("Choose a Class:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Assassin");
            Console.WriteLine("3. Magician");
            Console.WriteLine("4. Go Back To Main Menu");
            Console.WriteLine("+---------------------------------------------+");
            Console.Write("> ");
            int classInput = Convert.ToInt32(Console.ReadLine());
            switch (classInput)
            {
                case 1:
                    Console.Clear();
                    Warrior();
                    break;
                case 2:
                    Console.Clear();
                    Assassin();
                    break;
                case 3:
                    Console.Clear();
                    Magician();
                    break;
                case 4:
                    Console.Clear();
                    new MainMenu();
                    break;
            }
        }

        public static void Warrior()
        {
            AsciiArt.WarriorArt();
            Console.WriteLine("Warrior:");
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine(" +10% Reduction");
            Console.WriteLine(" +50 Attack");
            Console.WriteLine("");
            Console.WriteLine("Skills:");
            Console.WriteLine("------");
            Console.WriteLine("Frenzy: Unleash massive damage on the enemy");
            Console.WriteLine();
            Console.WriteLine("Is this your Class? ");
            Console.WriteLine("1.) Yes \n2.) No");
            Console.WriteLine("+---------------------------------------------+");
            Console.Write("> ");
            inputChoice();
        }

        private static void Assassin()
        {
            AsciiArt.WarriorArt(); // lfa
            Console.WriteLine("Assassin:");
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine(" +10% Accuracy");
            Console.WriteLine(" +10% Evasion");
            Console.WriteLine(" +10% Critical Hit");
            Console.WriteLine("");
            Console.WriteLine("Skills:");
            Console.WriteLine("------");
            Console.WriteLine("Backstab: Do x4 Damage.");
            Console.WriteLine();
            Console.WriteLine("Is this your Class? <yes/no>");
            Console.WriteLine("+---------------------------------------------+");
            Console.Write("> ");
            String input = Console.ReadLine();
            inputChoice();
        }

        private static void Magician()
        {
            AsciiArt.MagicianArt();
            Console.WriteLine("Magician:");
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine(" +10  Magic Damage");
            Console.WriteLine(" +10% Casting");
            Console.WriteLine("");
            Console.WriteLine("Spells:");
            Console.WriteLine("------");
            Console.WriteLine("Fireball: Cast a fire damage that inflicts fire damage");
            Console.WriteLine("Frost: Cast a ice damage that has a chance to freeze enemy");
            Console.WriteLine("Bolt: Cast a thunder bolt that has a chance to paralyze the enemy");
            Console.WriteLine();
            Console.WriteLine("Is this your Class? ");
            Console.WriteLine("1.) Yes \n2.) No");
            Console.WriteLine("+---------------------------------------------+");
            Console.Write("> ");
            String input = Console.ReadLine();
            inputChoice();
        }

        public static void inputChoice()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                ConfirmationWarrior();
            }
            else if (input == 2)
            {
                Console.Clear();
                ChooseClass();
            }
        }

        private static void ConfirmationAssassin()
        {
            Console.Clear();
            StatusWarrior();
            Console.WriteLine("Confirm? ");
            Console.WriteLine("1.) Yes \n2.) No");
            Console.WriteLine("+---------------------------------------------+");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Welcome");
            }
            else if(input == 2)
            {
                Console.Clear();
                ChooseClass();
            }
        }
        private static void ConfirmationMagician()
        {
            Console.Clear();
            StatusMagician();
            Console.WriteLine("Confirm? ");
            Console.WriteLine("1.) Yes \n2.) No");
            Console.WriteLine("+---------------------------------------------+");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Welcome");
            }
            else if(input == 2)
            {
                Console.Clear();
                ChooseClass();
            }
        }
        private static void ConfirmationWarrior()
        {
            Console.Clear();
            StatusWarrior();
            Console.WriteLine("Confirm? ");
            Console.WriteLine("1.) Yes \n2.) No");
            Console.WriteLine("+---------------------------------------------+");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Welcome");
            }
            else if(input == 2)
            {
                Console.Clear();
                ChooseClass();
            }
        }

        public static void StatusWarrior()
        {
            AsciiArt.WarriorArt();
            Console.WriteLine("Name: ");
            Console.WriteLine("Class: ");
            Console.WriteLine("Status: ");
            Console.WriteLine("Atk: ");
            Console.WriteLine("Mag: ");
            Console.WriteLine("HP: ");
            Console.WriteLine("MP: ");
            Console.WriteLine("Spd: ");
            Console.WriteLine("Acc: ");
            Console.WriteLine("Crt: ");
        }

        private static void StatusMagician()
        {
            AsciiArt.MagicianArt();
            Console.WriteLine("Name: ");
            Console.WriteLine("Class: ");
            Console.WriteLine("Status: ");
            Console.WriteLine("Atk: ");
            Console.WriteLine("Mag: ");
            Console.WriteLine("HP: ");
            Console.WriteLine("MP: ");
            Console.WriteLine("Spd: ");
            Console.WriteLine("Acc: ");
            Console.WriteLine("Crt: ");
        }

        // --------------------------------------------------------------------------------------------------
        
    }
}
