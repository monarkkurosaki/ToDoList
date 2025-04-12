namespace TaskManagement;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
}
public class Lists
{
    
    public List<Task> tasks = new List<Task>();

    public void TakeInput()
    {
        Console.Write("Enter your task: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description of title: ");
        string description = Console.ReadLine();
        
        Task newTask = new Task
        {
            Title = title,
            Description = description
        };
        
        tasks.Add(newTask);
    }

    public void DisplayOutput()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}