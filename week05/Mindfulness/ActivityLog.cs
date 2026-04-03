using System.Net;

public static class ActivityLog
{
    private static Dictionary<string, int> _counts = new Dictionary<string, int>();

    public static void LogActivity(string activityName)
    {
        if (_counts.ContainsKey(activityName))
        _counts[activityName]++;
        else
        _counts[activityName] = 1;
    }

    public static void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");

        foreach (var entry in _counts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} time");
        }
    }
}