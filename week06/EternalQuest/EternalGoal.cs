public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void recordEvent()
    {
        _lastEarnedPoints = GetPoint(); 
        Console.WriteLine($"Congrats! You have earned {_lastEarnedPoints} points!");
    }


    public override bool IsComplete()
    {
        return false;
    }

    // serialize
    public override string GetStringRepresentation()
    {
        string _shortName = GetName();
        string _description = GetDescription();
        int _points = GetPoint();
        return $"EternalGoal: {_shortName} | {_description} | {_points}";
    }

    // Deserialize
    public static EternalGoal Deserialize(string line)
    {
        if (!line.StartsWith("EternalGoal:")) return null;
        string[] parts = line.Substring(12).Trim().Split('|');
        if (parts.Length != 3) return null;
        string name = parts[0].Trim();
        string description = parts[1].Trim();
        if (!int.TryParse(parts[2].Trim(), out int points)) return null;
        return new EternalGoal(name, description, points);
    }
}