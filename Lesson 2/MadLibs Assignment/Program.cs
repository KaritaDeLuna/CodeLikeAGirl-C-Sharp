using System;

namespace MadLibs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            var rapperName = Console.ReadLine();
            rapperName = rapperName.Trim();
            rapperName = rapperName.ToUpper();
            /*
            find how to only write first letter of input
            */
            Console.WriteLine("Favourite day of the week? Please write full day");
            var week = Console.ReadLine();
            week = week.Trim();
            /*
             find how to capitalise only the first letter for this one?
            */
            Console.WriteLine("Name a coding language you are interested in");
            var langName = Console.ReadLine();
            langName = langName.Trim();
            langName = langName.ToUpper();
            Console.WriteLine("Favourite food? Slang preferred if applicable, e.g. 'choccy' or 'beanz'");
            var yummyFood = Console.ReadLine();
            yummyFood = yummyFood.Trim();
            yummyFood = yummyFood.ToLower();
            Console.WriteLine("Who is your favourite writer or poet?");
            var coolPerson = Console.ReadLine();
            coolPerson = coolPerson.Trim();
            coolPerson = coolPerson.ToUpper();
            Console.WriteLine("Descriptive word rhyming with 'stay', e.g. gourmet, risqué, blown away");
            var adj1 = Console.ReadLine();
            adj1 = adj1.Trim();
            adj1 = adj1.ToUpper();
            Console.WriteLine("\n\nYo yo yo... When i write SEE you write SHARP!\nSEE!");
            var answer1 = Console.ReadLine();
            Console.WriteLine("\nSEE!");
            var answer2 = Console.ReadLine();
            Console.WriteLine($"\nYo my name is {rapperName} and I'm here to say\nI code like a girl on {week},\nMy interest - {langName}, \nMy style - {adj1},\nOpen VScode up to have a play!\n\nI sit down and study {langName} all day, \nhave a whole lotta {yummyFood} then hit the hay!\n\nThanks for playing \n...and as {coolPerson} likes to say, keep it FLY, FRESH... and RESPONSIBLE!\n");


         /* 
         Rap lyric generator
         I used \n rather than new WriteLines here to be purposely unclear about the output to anybody reading the script.

         for me: check and run AS YOU GO! 
         ... and ask about bool output in tute
         */
        }
    }
}

