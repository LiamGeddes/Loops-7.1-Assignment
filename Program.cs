using System.ComponentModel.Design;

namespace Loops_7._1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============================================
            // ASSIGNMENT 1 - AVERAGE OF NUMBERS IN A LOOP
            //============================================

            int count = 0;
            int number = 0;
            int total = 0;

            Console.WriteLine("ASSIGNMENT 1 - AVERAGE OF NUMBERS");
            Console.WriteLine();

            while (count < 4)
            {
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out number);

                total = total + number;
                count++;
            }
            double average = (double)total / count;

            Console.WriteLine();
            Console.WriteLine("The average is: " + average);

            Console.WriteLine();


            //========================================
            //ASSIGNMENT 2 - HI LOW WITH LIMITED TRIES
            //========================================

            Console.WriteLine("ASSIGNMENT 2 - HI LOW");
            Console.WriteLine();

            Random generator = new Random();

            int secretNumber = generator.Next(1, 101);
            int guess = 0;
            int guesses = 0;

            while (guess != secretNumber && guesses < 7)
            {
                Console.Write("Guess a number from 1 to 100: ");
                int.TryParse(Console.ReadLine(), out guess);

                guesses++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too High.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Correct! You win!");
                }
            }
            if (guess != secretNumber)
            {
                Console.WriteLine();
                Console.WriteLine("You ran out of guesses.");
                Console.WriteLine("The number was " + secretNumber);
            }

            Console.WriteLine();
            Console.WriteLine("Program Finished");

            Console.ReadLine();
        }   
            
    }
}
