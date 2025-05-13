public class Resumes
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayRezume()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }
}