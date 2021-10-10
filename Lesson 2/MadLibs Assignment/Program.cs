using System;

namespace MadLibs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            var rapperName = Console.ReadLine();
        
            Console.WriteLine("Favourite day of the week? Please write full day");
            var week = Console.ReadLine().Trim();

            Console.WriteLine("Name a coding language you are interested in");
            var langName = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("Favourite food? Slang preferred if applicable, e.g. 'choccy' or 'beanz'");
            var yummyFood = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Who is your favourite writer or poet?");
            var coolPerson = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("Descriptive word rhyming with 'stay', e.g. gourmet, okay, passé, doomsday");
            var adj1 = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("\n\nYo yo yo... When i write 'SEE' you write 'SHARP'!\n\nSEE!");
            Console.ReadLine(); //note for later: why define a new variable if u don't care what the input is

            Console.WriteLine("\nSEE!");
            Console.ReadLine(); 

            Console.WriteLine($"\nYo my name's BIG {(char.ToUpper(rapperName[0]))} and I'm here to say\nI code like a girl on {(char.ToUpper(week[0]) + week.Substring(1))},\nMy interest - {langName}, \nMy style - {adj1},\nOpen VScode up to have a play!\n\nI sit down and study {langName} all day, \nHave a whole lotta {yummyFood} then hit the hay!\n\n...Thanks for playing \nAnd as {coolPerson} likes to say, keep it FLY, FRESH... and RESPONSIBLE!\n");


         /* 
         Rap lyric generator
         I used \n rather than new WriteLines here to be purposely unclear about the output to anybody reading the script.

         NOTES FOR LATER: 
         check and run AS YOU GO! 
         actually,new lines (i.e. Console.Write[Line]) mo'betta for error troubleshooting
         sus out formatting conventions/extensions
         and ask about bool output in tute
         */
            
        }
    }
}

