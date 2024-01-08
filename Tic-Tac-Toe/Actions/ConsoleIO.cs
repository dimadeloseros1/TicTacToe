using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Actions
{
    public static class ConsoleIO
    {
        public static char Player(string prompt)
        {
            char input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadKey().KeyChar;
                input = char.ToUpper(input);

                if (input == 'H' || input == 'C')
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("\nMake sure that the input is either H or C");
                }
            } while (true);
        }

        public static bool ChooseOption(string prompt)
        {
            Console.Write(prompt);
            char answer;
            do
            {
                answer = Console.ReadKey().KeyChar;
                answer = char.ToUpper(answer);

                if (answer == 'H')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } while (true);
        }

        public static int ChoosePosition()
        {
            do
            {
                Console.Write("Choose a position: ");
                if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 9)
                {
                    return num;
                }
                Console.WriteLine("Make sure that the number is between 1 and 9.");
            } while (true);
        }

        public static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again? (yes/no): ");
            do
            {
                string answer = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(answer))
                {
                    if (answer == "yes")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Make sure that the input is at least 1 characther");
                }
            } while (true);
        }

    }
}
