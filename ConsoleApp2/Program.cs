using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int min;
            int max;
            Console.WriteLine("What would you like the lowest possible number to be?");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What would you like the highest possible number to be?");
            max = Convert.ToInt32(Console.ReadLine());
            int Counter = 1;
            int UserGuess = -1;
            int NumToGuess = num.Next(min, max);
            while (UserGuess != NumToGuess)
            {
                Console.WriteLine("Guess a number.");
                UserGuess = Convert.ToInt32(Console.ReadLine());
                if (UserGuess > NumToGuess)
                    Console.WriteLine("Guess was too high");
                if (UserGuess < NumToGuess)
                    Console.WriteLine("Guess was too low");
                if (UserGuess == NumToGuess)
                    Console.WriteLine("Correct!! It took " + Counter + " tries.");
                Counter++;
            }
            Console.ReadKey();
        }
    }
}
