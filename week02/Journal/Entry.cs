public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public int _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt created: {_promptText}");
        Console.WriteLine($"Entry wrote: {_entryText}");
        Console.WriteLine($"Mood Rated at: {_mood}/10");
        Console.WriteLine();
    }
}