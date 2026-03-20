using System;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //I added a library to add more scripture verses for the memorizer
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), 
        "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        ));

        library.Add(new Scripture(new Reference("Philippians", 4, 13), 
        "I can do all things through Christ which strengtheneth me"
        ));

        library.Add(new Scripture(new Reference("3 Nephi", 11, 11), 
        "And behold, I am the light and the life of the world."
        ));

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        int wordsToHide = 2;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            break;

            Console.WriteLine("\nOptions: Press Enter to continue or type 'quit' to leave the program");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            break;
            
            //Raising the difficulty of the Memorizer
            scripture.HideRandomWords(wordsToHide);

            wordsToHide++;
        }

    }
}