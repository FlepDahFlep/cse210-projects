using System;

class Program
{
    static void Main(string[] args)
    {
        //Added the activity log to view how many times you did the activities below
        while (true)
        {
            Console.WriteLine("\nHere's the Menu");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");

            Console.Write("Choose a number: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ReflectingActivity().Run();
            else if (choice == "3")
                new ListingActivity().Run();
            else if (choice == "4")
            {
                ActivityLog.DisplayLog();
            }
            else if (choice == "5")
                break;
        }
    }
}