using System.Diagnostics;

public class FitnessTracker
{
    private List<Activity> _activities = new List<Activity>();

    private int _totalXP = 0;

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
        _totalXP += activity.GetXP();
    }

    public int GetLevel()
    {
        return _totalXP / 100;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Total XP: {_totalXP}");
        Console.WriteLine($"Level: {GetLevel()}");
    }
}