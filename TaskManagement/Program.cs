namespace TaskManagement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the task manager");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Enter 1 to enter task");
        Console.WriteLine("Enter 2 if you want to view the tasks");
        Console.WriteLine("Enter 3 if your want to remove the entry");
        Console.WriteLine("Enter 4 to exit the program");
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        Lists inputObj = new Lists();
        while (userInput != null)
        {
            if (userInput.Equals(1))
            {
                inputObj.TakeInput();
                break;
            }
            else if (userInput.Equals(2))
            {
                inputObj.DisplayOutput();
                break;
            }
            else if (userInput.Equals(3))
            {
                Console.Clear();
                inputObj.EntryRemove();
                break;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}