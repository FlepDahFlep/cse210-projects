using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice !=5)
        {
            Console.WriteLine("Welcome to the Journal Menu!");
            Console.WriteLine("Select the options to continue:");
            Console.WriteLine("1. Write a new entry for your journal");
            Console.WriteLine("2. Display your last written entries");
            Console.WriteLine("3. Save your written journal");
            Console.WriteLine("4. Load your previous saved journal");
            Console.WriteLine("5. Quit/Leave");

            Console.Write("What do you want to do today? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How would like to rate your mood today? From 1-10: ");
                int mood = int.Parse(Console.ReadLine());

                Entry entry = new Entry();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._date = DateTime.Now.ToShortDateString();
                entry._mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter the filename here: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Enter the filename here: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
        }
    }
}