using Practice;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

class Program
{
    static void Main(String[] args)
    {
        int ManticoreHealth = 10;
        int CityHealth = 10;
        Console.WriteLine("       HUNTING THE MANTICORE          ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("(1)Single Player");
        Console.WriteLine("(2)Two Player");
        Console.WriteLine("(3)Exit");
        Console.WriteLine("------------------------------------");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            while (true)
            {
                Console.Clear();
                Random random = new Random();
                int input = random.Next(100);
                if (input <= 100 && input >= 0)
                {
                    Player2(ManticoreHealth, CityHealth, input);
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        else if (choice == 2)
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // Main 
                if (input <= 100 && input >= 0)
                {
                    Console.WriteLine("Player 2, it is your turn");
                    Player2(ManticoreHealth, CityHealth, input);
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        else if(choice == 3)
        {
            // EXIT
        }
    }
    static void Player2(int ManticoreHealth, int CityHealth, int input)
    {
        for (int i = 1; i <= 15; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            // Condition
            if (ManticoreHealth <= 0)
            {
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                break;
            }
            else if (CityHealth <= 0)
            {
                Console.WriteLine("The city of Consolas has been destroyed! :( ");
                Console.WriteLine($"The correct distance is: {input}");
                break;
            }
            else if (CityHealth <= 0 && ManticoreHealth <= 0)
            {
                Console.WriteLine("The city of Consolas and Manticore has both been destroyed!!!");
                break;
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"STATUS: Round: {i} City: {CityHealth}/10 Manticore: {ManticoreHealth}/10");
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The cannon is expected to deal {10} damage this round");
                Console.ResetColor();
            }
            else if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine($"The cannon is expected to deal {3} damage this round");
            }
            else
            {
                Console.WriteLine($"The cannon is expected to deal {1} damage this round");
            }
            Console.Write("Enter desired cannon range: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 == input)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ManticoreHealth -= 10;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    ManticoreHealth -= 3;
                }
                else
                {
                    ManticoreHealth -= 1;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round was a DIRECT HIT!");
            }
            else if (input2 > input)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That round OVERSHOT the target");
            }
            else if (input2 < input)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("That round FELL SHORT of the target");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            CityHealth--;
        }
    }
}















