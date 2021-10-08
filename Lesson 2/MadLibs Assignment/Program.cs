using System;

namespace MadLibs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var rapperName = Console.ReadLine();
            Console.WriteLine("Favourite day of the week? Please write full day");
            var week = Console.ReadLine();
            Console.WriteLine("Name a coding language you are interested in");
            var langName = Console.ReadLine();
            Console.WriteLine("Favourite food? If plural end with a 'z', e.g. beanz");
            var yummyFood = Console.ReadLine();
            Console.WriteLine("Who is your favourite writer or poet?");
            var coolPerson = Console.ReadLine();
            Console.WriteLine("Descriptive word rhyming with 'stay', e.g. gourmet, risqué, okay");
            var adj1 = Console.ReadLine();
            Console.WriteLine("\n\nYo yo yo... When i write SEE you write SHARP!\nSEE!");
            var answer1 = Console.ReadLine();
            Console.WriteLine("\nSEE!");
            var answer2 = Console.ReadLine();
            Console.WriteLine($"\nYo my name is {rapperName} and I'm here to say\nI code like a girl on {week},\nmy interest - {langName}, my style - {adj1},\nI study, have some {yummyFood} then hit the hay!\n\nYo thanks for playing \n...and as {coolPerson} likes to say, keep it fly, fresh and responsible!\n");


         /* 
         Rap lyric generator
         I used \n rather than new WriteLines here to be purposely unclear about the output to anybody reading the script.

         for me: check and run AS YOU GO! 
         ... and ask about bool output in tute
         */
        }
    }
}

