using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public static class UserInterface
    {



        public static string GetUserStringInput(string Prompt)
        {
            string userInput;
            Console.WriteLine(Prompt);
            try
            {
                userInput = Console.ReadLine().ToString();
            }
            catch
            {
                Console.WriteLine("Invalid");
                return GetUserStringInput(Prompt);
            }
            return userInput;
        }

        public static int GetUserIntInput(string Prompt)
        {
            int result;
            Console.WriteLine(Prompt);

            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid");
                return GetUserIntInput(Prompt);
            }
            return result;
        }

        public static int GetRandom(int min, int max)
        {
            Random rng = new Random();
            int winningNumber = rng.Next(min, max);
            return winningNumber;
        }

        public static void DisplayContesttantInfo(Contestant contestant, Dictionary<int, string> dictionary)
        {

        }
    }
}
