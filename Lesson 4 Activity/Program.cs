using System;

namespace Lesson_4_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 
           //Part 1: Write an application that 
           // - generates a number from 1 to 10
           // - asks the user to guess the number
           // - determines whether the user’s guess was correct and writes the result out to the user
           //In this part of the activity, the user only gets one guess.
           
           var randomGen = new Random();
            var number = randomGen.Next(1,11);

            Console.WriteLine("Guess a number between 1-10. Choose wisely because you only get one guess!");
            var userGuess = Console.ReadLine();
            userGuess = userGuess.Trim();

            if (userGuess == $"{number}")
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("BEOW BEOWWW YOU LOSE!");
            }
           */
            var randomGen = new Random();
            var number = randomGen.Next(1,11);

            Console.WriteLine("Guess a number between 1-10. Choose wisely because you only get three guesses!");

            for(var i = 0; i <= 3; i++)
            {
              var userGuess = Console.ReadLine();
              userGuess = userGuess.Trim();

                if (2-i==0)
                {
                    Console.WriteLine("YOU LOSE!");
                    break;
                }
                else
                { 
                    if(userGuess == $"{number}")
                     {
                     Console.WriteLine("CORRECT! YOU WIN!");
                     break;
                     }

                    else 
                     {
                      Console.WriteLine($"BEOW BEOWWW! YOU NOW HAVE {3-(i+1)} GUESSES LEFT!");
                     }
                }
             }
        }
    }
}
