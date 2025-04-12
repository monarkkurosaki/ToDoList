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
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput.Equals(1))
        {
            Lists inputObj = new Lists();
            inputObj.TakeInput();
        }
            
        
        if (userInput.Equals(2))
        {
            
        }
    }
}