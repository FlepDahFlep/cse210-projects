using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2026, 04, 3), 30, 5.0));
        activities.Add(new Cycling(new DateTime(2026, 04, 3), 30, 20.0));
        activities.Add(new Swimming(new DateTime(2026, 04, 3), 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
        //Like the last project, I also added a fitness tracker that tracks XP and levels. You get 10 XP for every kilometer and you level up every 100 XP. 
        FitnessTracker tracker = new FitnessTracker();
        foreach (Activity activity in activities)
        {
            tracker.AddActivity(activity);
        }
        
        tracker.ShowStats();
    }
}