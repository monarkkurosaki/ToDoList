namespace TaskManagement;

class Program
{
    static void Main(string[] args)
    {
        int indexOf;
        Console.WriteLine("welcome to the task manager");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
        
        string userInput = "";

        List<string> tasks = new List<string>();

        while (!userInput.Equals("4"))
        {
            Console.WriteLine("Enter 1 to enter task");
            Console.WriteLine("Enter 2 if you want to remove the tasks");
            Console.WriteLine("Enter 3 if your want to view the entry");
            Console.WriteLine("Enter 4 to exit the program");
            userInput = Console.ReadLine();
            
            if (userInput.Equals("1"))
            {
                Console.Clear();
                Console.Write("Enter the task you want to enter: ");
                string taskToBeAdded = Console.ReadLine();
                tasks.Add(taskToBeAdded);
               
            }else if (userInput.Equals("2"))
            {
                Console.Clear();
                Console.Write("Enter the task you want to delete: ");
                string taskToBeDeleted = Console.ReadLine();
                indexOf = tasks.IndexOf(taskToBeDeleted);
                tasks.RemoveAt(indexOf);
                
            }else if (userInput.Equals("3"))
            {
                Console.Clear();
                foreach (var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
            else
            {
                 Environment.Exit(0);
            }
        }
    }
}