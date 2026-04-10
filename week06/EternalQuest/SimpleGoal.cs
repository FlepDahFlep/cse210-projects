public class SimpleGoal : Goal
{
    private bool _IsComplete = false;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        if (!_IsComplete)
        {
            _IsComplete = true;
            Console.WriteLine($"You earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_IsComplete}";
    }

}