public abstract class Goal
{
    private string _shortName = "";
    private string _description = "";
    private int _points = 0;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    protected int _lastEarnedPoints = 0;

    public int GetLastEarnedPoints()
    {
        return _lastEarnedPoints;
    }


    // getters
    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoint()
    {
        return _points;
    }

    // Methods

    // Abstract methods
    public abstract void recordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // virtual method
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        return $"[] {_shortName} ({_description})";
    }
    
    public static Goal DeserializeGoal(string line)
    {
        if (line.StartsWith("SimpleGoal:")) return SimpleGoal.Deserialize(line);
        if (line.StartsWith("ChecklistGoal:")) return ChecklistGoal.Deserialize(line);
        if (line.StartsWith("EternalGoal:")) return EternalGoal.Deserialize(line);
        return null;
    }

    
}