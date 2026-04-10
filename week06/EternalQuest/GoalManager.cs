using System.Runtime.CompilerServices;
using System.Xml;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private int _level = 1;

    //Added this method to update the level based on the score and every 100 points, the level increases by 1.
    private void UpdateLevel()
    {
       _level = (_score / 100) + 1;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\n------ Eternal Quest Menu ------");
            Console.WriteLine($"Current Points: {_score} | Current Level: {_level}");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List of Goals");
            Console.WriteLine("3. Save your goals");
            Console.WriteLine("4. Load your goals");
            Console.WriteLine("5. Record the event");
            Console.WriteLine("6. Quit");
            Console.Write("What do you want to do?: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalDetails(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Current Level: {_level}");
    }

    public void ListGoalNames()
    {
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetDetailsString()}");
            number++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Current Goals:");
        ListGoalNames();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Types of Goal below: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would like to make? ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your current goal?" );
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to accomplished to get the bonus? ");
            int target = int.Parse(Console.ReadLine());
        
            Console.Write("What is the bonus for accomplishing this goal that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, 0));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("What goal did you accomplish today?" );
        int index = int.Parse(Console.ReadLine());

        index = index - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal goal = _goals[index];

        goal.RecordEvent();

        if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                _score += checklist.GetPoints() + checklist.GetBonus();
                UpdateLevel();
            }
            else
            {
                _score += checklist.GetPoints();
                UpdateLevel();
            }
        }
        else
        {
            _score += goal.GetPoints();
            UpdateLevel();
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for this goal file?: ");
        string fileName = Console.ReadLine();
        
        if (!fileName.EndsWith(".txt")) 
        {
            fileName += ".txt";
        }

        Console.WriteLine("Saving to: " + Path.GetFullPath(fileName));

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename you saved your goals in: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }
    }
}