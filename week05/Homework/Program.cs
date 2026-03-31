using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writing = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        Console.WriteLine(writing.GetSummary());

        Console.WriteLine(writing.GetWritingInformation());
    }
}