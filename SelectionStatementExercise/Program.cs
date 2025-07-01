using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber  = random.Next(1, 11);
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Give me a number:");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too High!\nYour guess: {response}");
                }
                else 
                {
                    Console.WriteLine($"You guessed it!\nThe favorite number was {favNumber}!");
                } 
            }

           


        }
        
    }
}
